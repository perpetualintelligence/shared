/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The Perpetual Intelligence user roles.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    [InternalInfrastructure]
    public static class UserRoles
    {
        /// <summary>
        /// Get all the supported external roles.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetExternalRoleDescriptions()
        {
            return new Dictionary<string, string>()
            {
                {Owner, "Business or company account owner." },
                {Administrator, "Best for business or company administrators." },
                {Expert, "Best for product experts, product managers, product owners and UI/UX Design experts." },
                {Developer, "Best for developers or people primarily using REST APIs and pi.api(); console." },
                {Contributor, "Best for employees or external service providers who will author or modify service data." },
                {Analyst, "Best for people or external agencies who analyze your service usage and service data." },
                {Support, "Best for employees who regularly provide support or dispute resolution." },
                {ReadOnly, "Best for people who need to view service data, but don't need to make any updates" }
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static string GetExternalRolePermissionDescription(string role)
        {
            switch (role)
            {
                case Owner:
                    {
                        return "All permissions for owned business account, user accounts, subscriptions, subscribed services and payment settings.";
                    }
                case Administrator:
                    {
                        return "All permissions for user accounts, subscriptions, subscribed services and payment settings.";
                    }
                case Expert:
                    {
                        return "All permissions for subscribed services including usage and settings. Cannot access API Keys.";
                    }
                case Developer:
                    {
                        return "All permissions for subscribed services, API Keys and REST API. Cannot access usage, settings.";
                    }
                case Contributor:
                    {
                        return "Author, view and edit permissions for subscribed services. Cannot delete. Cannot access API Keys, usage and settings.";
                    }
                case Analyst:
                    {
                        return "View, export permissions for subscribed services including usage and settings. Cannot create, edit, delete. Cannot access support, API Keys.";
                    }
                case Support:
                    {
                        return "View only permissions for subscribed services including usage and settings. Cannot create, edit, delete. Cannot access API Keys.";
                    }
                case ReadOnly:
                    {
                        return "View only permissions for subscribed services. Cannot create, edit, delete. Cannot access support, API Keys, usage and settings.";
                    }
                default:
                    {
                        return "Undefined role..";
                    }
            }
        }

        /// <summary>
        /// Get all the supported external roles.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetExternalRoles()
        {
            return new string[] { Owner, Administrator, Expert, Developer, Contributor, Analyst, Support, ReadOnly };
        }

        /// <summary>
        /// Get all the supported internal roles.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetInternalRoles()
        {
            return new string[] { piUserRole, piEmployeeRole, piDeveloperRole, piTesterRole, piEngineerRole, piSupportRole, piBusinessAdminRole, piOrgAdminRole, piSupportAdminRole, piPaymentAdminRole };
        }

        /// <summary>
        /// </summary>
        /// <param name="role"></param>
        public static bool IsValidExternal(string role)
        {
            if (string.IsNullOrEmpty(role))
                return false;

            return GetExternalRoles().Contains(role);
        }

        /// <summary>
        /// </summary>
        /// <param name="role"></param>
        public static bool IsValidInternal(string role)
        {
            if (string.IsNullOrEmpty(role))
                return false;

            return GetInternalRoles().Contains(role);
        }

        /// <summary>
        /// Administrator role.
        /// </summary>
        public const string Administrator = "Administrator";

        /// <summary>
        /// Engineer role.
        /// </summary>
        public const string Analyst = "Analyst";

        /// <summary>
        /// Support role.
        /// </summary>
        public const string Contributor = "Contributor";

        /// <summary>
        /// Developer role.
        /// </summary>
        public const string Developer = "Developer";

        /// <summary>
        /// Product manager, owner, product definition.
        /// </summary>
        public const string Expert = "Expert";

        /// <summary>
        /// Owner role.
        /// </summary>
        public const string Owner = "Owner";

        /// <summary>
        /// </summary>
        public const string piBusinessAdminRole = "piBusinessAdmin";

        /// <summary>
        /// </summary>
        public const string piDeveloperRole = "piDeveloper";

        /// <summary>
        /// </summary>
        public const string piEmployeeRole = "piEmployee";

        /// <summary>
        /// </summary>
        public const string piEngineerRole = "piEngineer";

        /// <summary>
        /// </summary>
        public const string piOrgAdminRole = "piOrgAdmin";

        /// <summary>
        /// Payment administrator.
        /// </summary>
        public const string piPaymentAdminRole = "piPaymentAdmin";

        /// <summary>
        /// Support administrator.
        /// </summary>
        public const string piSupportAdminRole = "piSupportAdmin";

        /// <summary>
        /// </summary>
        public const string piSupportRole = "piSupport";

        /// <summary>
        /// </summary>
        public const string piTesterRole = "piTester";

        /// <summary>
        /// </summary>
        public const string piUserRole = "piUser";

        /// <summary>
        /// RBAC application separator.
        /// </summary>
        public const char RbacSeperator = ',';

        /// <summary>
        /// Engineer role.
        /// </summary>
        public const string ReadOnly = "ReadOnly";

        /// <summary>
        /// Support role.
        /// </summary>
        public const string Support = "Support";
    }
}
