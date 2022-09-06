using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Application.Extensions;
using UserManagement.Application.Interfaces;
using UserManagement.Application.Models;

namespace UserManagement.Application.Services.Permissions.Queries.GetPermissionList
{
    public class GetPermissionListQueryHandler : IRequestHandler<GetPermissionListQuery, ListModel<PermissionListModel>>
    {
        private readonly IUserManagementDbContext _context;
        private readonly IMapper _mapper;

        public GetPermissionListQueryHandler(IUserManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListModel<PermissionListModel>> Handle(GetPermissionListQuery request, CancellationToken cancellationToken)
        {
            var data = _context.Permissions
                .Where(x => !request.DetailMode || x.UserPermissions.Any(y => y.UserId == request.UserId))
                .Select(x => new PermissionListModel
                {
                    Id = x.Id,
                    Code = x.Code,
                    Description = x.Description,
                    Assign = x.UserPermissions.Any(y => y.UserId == request.UserId)
                });

            var listModel = new ListModel<PermissionListModel>
            {
                TotalCount = await data.CountAsync(cancellationToken)
            };

            listModel.TotalPages = (int)Math.Ceiling(listModel.TotalCount / (double)request.PageSize);

            listModel.Data = await data.AsNoTracking()
                .DynamicOrderBy(request.SortColumnName, request.SortAscending)
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return listModel;
        }
    }
}