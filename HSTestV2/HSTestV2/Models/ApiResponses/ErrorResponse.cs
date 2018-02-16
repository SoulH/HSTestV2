using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSTestV2Api.Models.ApiResponses
{
    public class ErrorResponse
    {
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDescription { get; set; }

        public static ErrorResponse Http500(string description = "")
        {
            return new ErrorResponse()
            {
                Success = false,
                ErrorCode = 500,
                ErrorMessage = "Server Error",
                ErrorDescription = description
            };
        }

        public static ErrorResponse Http404(string description = "")
        {
            return new ErrorResponse()
            {
                Success = false,
                ErrorCode = 404,
                ErrorMessage = "Not Found",
                ErrorDescription = description
            };
        }

        public static ErrorResponse Http401(string description = "")
        {
            return new ErrorResponse()
            {
                Success = false,
                ErrorCode = 401,
                ErrorMessage = "Unauthorized",
                ErrorDescription = description
            };
        }

        public static ErrorResponse Http400(string description = "")
        {
            return new ErrorResponse()
            {
                Success = false,
                ErrorCode = 400,
                ErrorMessage = "Bad Request",
                ErrorDescription = description
            };
        }
    }
}