using Machine.Specifications;
using System.Web.Routing;

namespace WebApplication2.Tests
{
    [Subject("Compound constraints route with to many params")]
    public class When_requesting_compound_constraints_request_with_to_many_params
    {
        static MockHttpContext httpContext;
        static RouteCollection routes;
        static RouteData routeData;

        Establish context = () =>
        {
            httpContext = new MockHttpContext(requestUrl: "~/CompoundRouteConstraint/Home/Index/3/1/2/3/4");
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
        };

        Because of = () => routeData = routes.GetRouteData(httpContext);

        It should_not_be_null = () => routeData.ShouldNotBeNull();
        It should_have_home_controller = () => routeData.Values["controller"].ShouldEqual("Home");
        It should_have_index_action = () => routeData.Values["action"].ShouldEqual("Index");
        It should_have_optional_id_param = () => routeData.Values["id"].ShouldEqual("3");
        It should_have_other_params_in_catchall = () => routeData.Values["catchall"].ShouldEqual("1/2/3/4");
    }
}
