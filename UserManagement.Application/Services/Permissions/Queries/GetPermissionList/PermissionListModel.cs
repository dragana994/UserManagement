namespace UserManagement.Application.Services.Permissions.Queries.GetPermissionList
{
    public class PermissionListModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Assign { get; set; }
    }
}