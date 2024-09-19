using System.Collections.Generic;
using ApiOcrAruba;
using ApiOcrAruba.Interfaces;
using ApiOcrAruba.Models;
using Soneta.Business;
using Soneta.Core;
using Soneta.Types.DynamicApi;

[assembly: Service(
    typeof(IPDFWebApi),
    typeof(PDFWebApi),
    ServiceScope.Session)]

[assembly: DynamicApiController(
    typeof(IPDFWebApi),
    typeof(PDFWebApi))]


namespace ApiOcrAruba
{
    public class PDFWebApi: IPDFWebApi
    {
        CoreModule cm;

        public PDFWebApi(Session session)
        {
            cm = CoreModule.GetInstance(session);
        }

        public List<ZalacznikEmail> GetDocuments()
        {
            return new List<ZalacznikEmail> {
                new ZalacznikEmail() {Id = 1, NazwaPliku="PlikTest1.pdf"},
                new ZalacznikEmail() {Id = 2, NazwaPliku="PlikTest2.pdf"}
                };
        }
        //fcc0c82495904b2abac9457330bd1152
    }
}
