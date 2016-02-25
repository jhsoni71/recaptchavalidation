public class CustomAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationContext filterContext)
    {
        if (string.IsNullOrEmpty(SessionManager.Username))
        {
            filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary 
                { 
                    { "controller", "User" }, 
                    { "action", "Login" }
                });
        }
    }
}
