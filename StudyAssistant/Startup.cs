using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyAssistant.Startup))]
namespace StudyAssistant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
