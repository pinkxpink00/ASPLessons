using ASPLessons.Models;

namespace ASPLessons.Infrastracture.Helpers
{
    public class RouteHelper
    {
        public void GetCurrentRoute(RouteData routeData)
        {
            var route = RouteResponse.Routes
                .FirstOrDefault(x => x.Action == routeData.Values["Action"]
                                     && x.Controller == routeData.Values["Controller"]);

            if (route == null)
            {
                var routeResponce = new RouteResponse()
                {
                    Controller = routeData.Values["controller"]?.ToString(),
                    Action = routeData.Values["action"]?.ToString(),
                };

                RouteResponse.Routes.Add(routeResponce);
            }
        }
    }
}
