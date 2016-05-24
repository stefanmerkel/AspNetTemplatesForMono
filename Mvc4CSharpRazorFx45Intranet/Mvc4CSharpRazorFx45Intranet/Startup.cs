using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc4CSharpRazorFx45Intranet.Startup))]
namespace Mvc4CSharpRazorFx45Intranet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
