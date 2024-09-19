using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiOcrAruba.Models;
using Soneta.Types.DynamicApi;

namespace ApiOcrAruba.Interfaces
{
    public interface IPDFWebApi
    {
        [DynamicApiMethod(HttpMethods.GET, nameof(GetDocuments), MediaType = "text/json")]
        List<ZalacznikEmail> GetDocuments();
    }
}
