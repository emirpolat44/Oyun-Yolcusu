using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OyunHaberSitesi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "DeleteCategory",
            url: "Category/DeleteCategory/{id}",
            defaults: new { controller = "Category", action = "DeleteCategory" }
            );

            routes.MapRoute(
                name: "EditCategory",
                url: "Category/EditCategory/{id}",
                defaults: new { controller = "Category", action = "EditCategory"}
            );

            routes.MapRoute(
                name: "DeleteNew",
                url: "Category/DeleteNew/{id}",
                defaults: new { controller = "New", action = "DeleteNew" }
            );

            routes.MapRoute(
                name: "EditNew",
                url: "Category/EditNew/{id}",
                defaults: new { controller = "New", action = "EditNew" }
            );

            routes.MapRoute(
                name: "EditComment",
                url: "Comment/EditComment/{id}",
                defaults: new { controller = "Comment", action = "EditComment" }
            );

            routes.MapRoute(
                name: "DeleteComment",
                url: "Comment/DeleteComment/{id}",
                defaults: new { controller = "Comment", action = "DeleteComment" }
            );

            routes.MapRoute(
                name: "AddComment",
                url: "Comment/AddComment/{id}",
                defaults: new { controller = "Comment", action = "AddComment" }
            );
            routes.MapRoute(
                name: "GetCommentList",
                url: "Comment/GetCommentList/{id}",
                defaults: new { controller = "Comment", action = "GetCommentList" }
            );
             routes.MapRoute(
                name: "RegisterLogin",
                url: "Login/RegisterLogin/{id}",
                defaults: new { controller = "Login", action = "RegisterLogin" }
            );
             routes.MapRoute(
                name: "GetUserList",
                url: "User/GetUserList/{id}",
                defaults: new { controller = "User", action = "GetUserList" }
            );
        }
    }
}
