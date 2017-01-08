using Owin;

namespace CodeTweet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //something new!
            ConfigureAuth(app);
            //aaaa
        }
    }
}
