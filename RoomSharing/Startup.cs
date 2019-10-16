using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomSharing.Startup))]
namespace RoomSharing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
