using System.Web.Http;
using Newtonsoft.Json;
using Syncfusion.EJ.PdfViewer;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Shopping.Core.Areas.ShopPage.Controllers.ApiControllers
{
    public class PdfsController : ApiController
    {
        [HttpPost]
        public object GetPdfs(Dictionary<string, string> jsonResult)
        {
            PdfViewerHelper helper = new PdfViewerHelper();
            string value;
            jsonResult.TryGetValue("newFileName", out value);
            string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            helper.Load(path + "\\Areas\\ShopPage\\Pdfs\\" + (string.IsNullOrEmpty(value) ? "1.pdf" : value));
            object output = helper.ProcessPdf(jsonResult);
            string response = JsonConvert.SerializeObject(output);
            return response;
        }
    }
}
