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


        public ResponseModel SetErrors(Exception Error)
        {
            return new ResponseModel()
            {
                Errors = Error.Message.ToList(),
                Success = false
            };

        }
        public ResponseModel SetErrors(IEnumerable<Exception> Errors)
        {
            return new ResponseModel()
            {
                Errors = Errors.Select(x => x.Message).ToList(),
                Success = false
            };
        }

    }
}