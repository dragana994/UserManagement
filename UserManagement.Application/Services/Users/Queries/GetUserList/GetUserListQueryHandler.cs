using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Application.Extensions;
using UserManagement.Application.Interfaces;
using UserManagement.Application.Models;

namespace UserManagement.Application.Services.Users.Queries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, ListModel<UserListModel>>
    {
        private readonly IUserManagementDbContext _context;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IUserManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ListModel<UserListModel>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var data = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(request.FirstName))
            {
                data = data.Where(x => x.FirstName == request.FirstName);
            }

            if (!string.IsNullOrEmpty(request.LastName))
            {
                data = data.Where(x => x.LastName == request.LastName);
            }

            var result = data.ProjectTo<UserListModel>(_mapper.ConfigurationProvider);

            var listModel = new ListModel<UserListModel>
            {
                TotalCount = await data.CountAsync(cancellationToken)
            };

            listModel.TotalPages = (int)Math.Ceiling(listModel.TotalCount / (double)request.PageSize);

            listModel.Data = await result.AsNoTracking()
                .DynamicOrderBy(request.SortColumnName, request.SortAscending)
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return listModel;
        }
    }
}