namespace UserManagement.Application.Models
{
    public class BaseListQuery
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumnName { get; set; }
        public bool SortAscending { get; set; }
    }
}