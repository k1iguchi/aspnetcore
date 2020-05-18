// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity.UI.Services
{
    /// <summary>
    /// This EmailSender is a placeholder and does nothing. To send emails, you need to implement a class with <see cref="IEmailSender" /> interface.
    /// </summary>
    internal class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Debug.WriteLine("This EmailSender is a placeholder and does nothing. To send emails, you need to implement a class with Microsoft.AspNetCore.Identity.UI.Services.IEmailSender interface.");
            return Task.CompletedTask;
        }
    }
}
