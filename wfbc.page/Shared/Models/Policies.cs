﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace wfbc.page.Shared.Models
{
    public static class Policies
    {
        public const string IsCommish = "IsCommish";
        public const string IsManager = "IsManager";

        public static AuthorizationPolicy IsCommishPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                                                   .RequireRole("Commish")
                                                   .Build();
        }

        public static AuthorizationPolicy IsManagerPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                                                   .RequireRole("Manager")
                                                   .Build();
        }
    }
}
