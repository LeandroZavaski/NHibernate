using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHibernateBook.Startup))]
namespace NHibernateBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
