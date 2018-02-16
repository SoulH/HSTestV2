using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSTestV2Api.Models.ApiResponses
{
    public class SingleResponse<T> : Response
    {
        public string Type { get; set; }

        public T Value { get; set; }

        SingleResponse(T value)
        {
            Type = value.GetType().Name;
            Value = value;
        }
    }
}