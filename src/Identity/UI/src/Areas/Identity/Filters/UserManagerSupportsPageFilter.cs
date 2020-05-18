// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Identity.UI.Areas.Identity.Filters
{
    internal class UserManagerSupportsPageFilter<TUser> : IAsyncPageFilter where TUser : class
    {
        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            var result = await next();
            if (result.Result is PageResult page)
            {
                var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<TUser>>();

                page.ViewData["ManageNav.SupportsQueryableUsers"] = userManager.SupportsQueryableUsers;
                page.ViewData["ManageNav.SupportsUserAuthenticationTokens"] = userManager.SupportsUserAuthenticationTokens;
                page.ViewData["ManageNav.SupportsUserAuthenticatorKey"] = userManager.SupportsUserAuthenticatorKey;
                page.ViewData["ManageNav.SupportsUserClaim"] = userManager.SupportsUserClaim;
                page.ViewData["ManageNav.SupportsUserLockout"] = userManager.SupportsUserLockout;
                page.ViewData["ManageNav.SupportsUserLogin"] = userManager.SupportsUserLogin;
                page.ViewData["ManageNav.SupportsUserPassword"] = userManager.SupportsUserPassword;
                page.ViewData["ManageNav.SupportsUserPhoneNumber"] = userManager.SupportsUserPhoneNumber;
                page.ViewData["ManageNav.SupportsUserRole"] = userManager.SupportsUserRole;
                page.ViewData["ManageNav.SupportsUserSecurityStamp"] = userManager.SupportsUserSecurityStamp;
                page.ViewData["ManageNav.SupportsUserTwoFactor"] = userManager.SupportsUserTwoFactor;
                page.ViewData["ManageNav.SupportsUserTwoFactorRecoveryCodes"] = userManager.SupportsUserTwoFactorRecoveryCodes;
                page.ViewData["ManageNav.SupportsUserEmail"] = userManager.SupportsUserEmail;
            }
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return Task.CompletedTask;
        }
    }
}
