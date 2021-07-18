using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OopsLive.Models
{
    public class CustomExceptionHandlerFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string ExceptionMessage = filterContext.Exception.Message;
            string ExceptionStackTrack = filterContext.Exception.StackTrace;
            string ControllerName = filterContext.RouteData.Values["controller"].ToString();
            string ActionName = filterContext.RouteData.Values["action"].ToString();
            DateTime ExceptionLogTime = DateTime.Now;

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
    }
}