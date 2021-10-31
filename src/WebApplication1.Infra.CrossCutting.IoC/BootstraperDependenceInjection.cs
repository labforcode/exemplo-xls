using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Infra.CrossCutting.ClosedXml.Interfaces;
using WebApplication1.Infra.CrossCutting.ClosedXml.Services;

namespace WebApplication1.Infra.CrossCutting.IoC
{
    public class BootstraperDependenceInjection
    {
        public static void Injector(IServiceCollection services)
        {
            services.AddScoped<ICloseXml, CloseXml>();
        }
    }
}
