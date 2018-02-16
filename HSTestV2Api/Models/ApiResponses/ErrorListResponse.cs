using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSTestV2Api.Models.ApiResponses
{
    public class ErrorListResponse
    {
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public IEnumerable<string> ErrorDescriptions { get; set; }

        public static ErrorListResponse Http500(IEnumerable<string> description = null)
        {
            return new ErrorListResponse()
            {
                Success = false,
                ErrorCode = 500,
                ErrorMessage = "Server Error",
                ErrorDescriptions = description
            };
        }

        public static ErrorListResponse Http404(IEnumerable<string> description = null)
        {
            return new ErrorListResponse()
            {
                Success = false,
                ErrorCode = 404,
                ErrorMessage = "Not Found",
                ErrorDescriptions = description
            };
        }

        public static ErrorListResponse Http401(IEnumerable<string> description = null)
        {
            return new ErrorListResponse()
            {
                Success = false,
                ErrorCode = 401,
                ErrorMessage = "Unauthorized",
                ErrorDescriptions = description
            };
        }

        public static ErrorListResponse Http400(IEnumerable<string> description = null)
        {
            return new ErrorListResponse()
            {
                Success = false,
                ErrorCode = 400,
                ErrorMessage = "Bad Request",
                ErrorDescriptions = description
            };
        }
    }
}