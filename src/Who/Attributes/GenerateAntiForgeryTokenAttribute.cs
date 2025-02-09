﻿using System;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace doob.Who.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GenerateAntiForgeryTokenAttribute : ActionFilterAttribute
    {


        public override void OnActionExecuted(ActionExecutedContext context)
        {
           
            var antiforgery = context.HttpContext.RequestServices.GetService<IAntiforgery>();

            var tokens = antiforgery.GetAndStoreTokens(context.HttpContext);
            context.HttpContext.Response.Cookies.Append("XSRF-TOKEN", tokens.RequestToken,
                new CookieOptions() { HttpOnly = false });
        }
    }


}
