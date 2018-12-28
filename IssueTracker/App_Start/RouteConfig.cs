using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IssueTracker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Components",
             url: "components",
            defaults: new { controller = "Project", action = "Component" }
        );


            routes.MapRoute(
             name: "TaskList",
              url: "task/list",
             defaults: new { controller = "Task", action = "Index" }
         );
            routes.MapRoute(
               name: "Task Detail",
               url: "task/{taskId}",
              defaults: new { controller = "Task", action = "TaskDetail" }
           );

            routes.MapRoute(
              name: "Log off",
              url: "signout",
             defaults: new { controller = "Login", action = "LogOff" }
          );

            routes.MapRoute(
               name: "Login",
               url: "login",
              defaults: new { controller = "Login", action = "Login" }
           );

            routes.MapRoute(
             name: "AllAgileBoardDetails",
             url: "agile",
             defaults: new { controller = "Agile", action = "GetAllAgileBoardDetails" }
          );

            routes.MapRoute(
             name: "AgileBoard",
             url: "agile/{id}",
             defaults: new { controller = "Agile", action = "GetAgileBoard" }
          );

            routes.MapRoute(
             name: "AgileBoardSettings",
             url: "agile/{id}/settings",
             defaults: new { controller = "Agile", action = "GetAgileBoardSettings" }
          );

            routes.MapRoute(
             name: "AgileBoardSettingsByType",
             url: "agile/{id}/settings/{settingstype}",
             defaults: new { controller = "Agile", action = "GetAgileBoardSettings" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                        name: "Project",
                         url: "project/project-list",
                        defaults: new { controller = "Project", action = "ProjectDetails" }
                    );
            routes.MapRoute(
                         name: "ProjectIndex",
                          url: "task/index",
                         defaults: new { controller = "Task", action = "Index" }
                     );
            
        }
    }
}
