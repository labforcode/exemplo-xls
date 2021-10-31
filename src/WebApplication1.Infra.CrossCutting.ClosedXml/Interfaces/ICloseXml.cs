using WebApplication1.Infra.CrossCutting.ClosedXml.Dtos;

namespace WebApplication1.Infra.CrossCutting.ClosedXml.Interfaces
{
    public interface ICloseXml
    {
        void GerarXls(ClosedXmlDto closedXmlDto);
    }
}
