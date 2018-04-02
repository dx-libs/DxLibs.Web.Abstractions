#if FW
using Owin;
#elif NETCORE
using Microsoft.AspNetCore.Builder; 
#endif

namespace DxLibs.Web
{
    public interface IStartup
    {
#if FW
        void Configure(IAppBuilder app);
#elif NETCORE
        void Configure(IApplicationBuilder app);
#endif
    }
}
