## WebFramework Lab

- Mission #1 : Create your own web framework.
- Mission #X : Swap your framework to WebApi or Nancy
- Mission #Y : Create two web sites running your framework with Azure AD SSO.
- Mission #Z : Test your framework with Selfhost.

-Bonus : Try Helios, maybe on a Azure WebSite.

##Creating your own framework
Here is some scenarios that you might want to takle.

To create a simple framework may want;
- Routing
- Serving HTML - static files or a redering engine (Razor/Markdown)
- Serving JSON
- Serving Files

Try supporting a route like Web Api/MVC;
- /Api/Orders/1
- Bindings - /APi/Orders/1?x=1&y=2
- Nested routes
- POST/PUT/DELETE/OPTIONS


##Resources

###OWIN & Katana
[http://www.asp.net/aspnet/overview/owin-and-katana/an-overview-of-project-katana](http://www.asp.net/aspnet/overview/owin-and-katana/an-overview-of-project-katana)

[http://katanaproject.codeplex.com/](http://katanaproject.codeplex.com/)

[http://www.nuget.org/packages/Microsoft.Owin.SelfHost/3.0.0-alpha1](http://www.nuget.org/packages/Microsoft.Owin.SelfHost/3.0.0-alpha1)

[http://odetocode.com/blogs/scott/archive/2014/02/10/building-a-simple-file-server-with-owin-and-katana.aspx](http://odetocode.com/blogs/scott/archive/2014/02/10/building-a-simple-file-server-with-owin-and-katana.aspx)

###Helios
[http://blogs.msdn.com/b/webdev/archive/2014/02/18/introducing-asp-net-project-helios.aspx](http://blogs.msdn.com/b/webdev/archive/2014/02/18/introducing-asp-net-project-helios.aspx)

[http://blogs.msdn.com/b/webdev/archive/2014/02/18/supplemental-to-asp-net-project-helios.aspx](http://blogs.msdn.com/b/webdev/archive/2014/02/18/supplemental-to-asp-net-project-helios.aspx)

###Azure AD
[http://www.cloudidentity.com/blog/2014/02/20/ws-federation-in-microsoft-owin-componentsa-quick-start/](http://www.cloudidentity.com/blog/2014/02/20/ws-federation-in-microsoft-owin-componentsa-quick-start/)

[http://www.cloudidentity.com/blog/2013/12/10/protecting-a-self-hosted-api-with-microsoft-owin-security-activedirectory/](http://www.cloudidentity.com/blog/2013/12/10/protecting-a-self-hosted-api-with-microsoft-owin-security-activedirectory/)