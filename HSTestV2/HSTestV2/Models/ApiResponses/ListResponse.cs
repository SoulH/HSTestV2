using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSTestV2Api.Models.ApiResponses
{
    public class ListResponse<T> : Response
    {
        public string Type { get; set; }

        public List<T> Values { get; set; }

        public int TotalCount { get; set; }

        public ListResponse(List<T> list)
        {
            Values = list;
            TotalCount = list.Count;
            if (list.GetType().IsGenericType)
                Type = list.GetType().GenericTypeArguments[0].Name;
            else if (TotalCount > 0)
                Type = list[0].GetType().Name;
            else Type = string.Empty;
        }
    }
}