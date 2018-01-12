using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyAssistantMVC.Startup))]
namespace StudyAssistantMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
