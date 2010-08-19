namespace System.Web.Mvc
{
    public static class UrlHelperExtensions
    {
        /// <summary>
        ///   Returns an absolute url for an action
        /// </summary>
        /// <param name = "url">UrlHelper</param>
        /// <param name = "action"></param>
        /// <param name = "controller"></param>
        /// <returns></returns>
        public static string AbsoluteAction(this UrlHelper url, string action, object routeValues)
        {
            var requestUrl = url.RequestContext.HttpContext.Request.Url;

            var absoluteAction = string.Format("{0}://{1}{2}",
                                               requestUrl.Scheme,
                                               requestUrl.Authority,
                                               url.Action(action, routeValues));

            return absoluteAction;
        }
    }
}