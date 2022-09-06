using System.Collections.Generic;

namespace UserManagement.Application.Models
{
    public class ListModel<T>
    {
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public IList<T> Data { get; set; }
    }
}