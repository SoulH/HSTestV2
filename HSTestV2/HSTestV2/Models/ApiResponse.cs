using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSTestV2.Models.ApiResponses
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Type { get; set; }
        public T Value { get; set; }
        public List<T> Values { get; set; }
        public int TotalCount { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDescription { get; set; }
        public IEnumerable<string> ErrorDescriptions { get; set; }
    }
}