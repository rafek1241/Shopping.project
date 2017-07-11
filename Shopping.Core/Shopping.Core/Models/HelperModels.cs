using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Core.Models.HelperModels
{
    public class ResponseModel
    {
        public object Data { get; set; }
        public bool Success { get; set; }
        public object Errors { get; set; }
    }
}