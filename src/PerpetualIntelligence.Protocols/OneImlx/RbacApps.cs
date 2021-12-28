/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The Perpetual Intelligence role based applications.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    public static class RbacApps
    {
        /// <summary>
        /// Checks if the specified applications are subset of subscribed applications.
        /// </summary>
        public static bool IsSubset(string subscribed, string subset)
        {
            HashSet<string> subsetSet = Split(subset);
            return subsetSet.IsSubsetOf(Split(subscribed));
        }

        /// <summary>
        /// Joins all the specified applications.
        /// </summary>
        public static string Join(params string[] apps)
        {
            return Join(apps.AsEnumerable());
        }

        /// <summary>
        /// Joins all the specified applications.
        /// </summary>
        public static string Join(IEnumerable<string> apps)
        {
            if (apps is null)
            {
                throw new ArgumentNullException(nameof(apps));
            }

            // Make sure permissions are valid
            IEnumerable<string> diff = apps.Except(All);
            if (diff.Count() > 0)
            {
                throw new InvalidOperationException($"Applications '{string.Join(UserRoles.RbacSeperator.ToString(), diff)}' are not valid.");
            }

            return string.Join(UserRoles.RbacSeperator.ToString(), apps);
        }

        /// <summary>
        /// Get the potential applications for an external role.
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static string PotentialsExternalUser(string role)
        {
            if (!UserRoles.IsValidExternal(role))
            {
                throw new InvalidOperationException($"'{role}' is not a valid external role.");
            }

            // To define potential applications for external role start will all external applications.
            List<string> apps = All.Except(Internal).ToList();

            // Fall through based on roles and superset to subset.
            switch (role)
            {
                case UserRoles.Owner:
                    {
                        break;
                    }
                case UserRoles.Administrator:
                    {
                        apps.Remove(PiAccount);
                        break;
                    }
                case UserRoles.Developer:
                    {
                        apps.Remove(PiAccount);
                        apps.Remove(Team);
                        apps.Remove(Subscriptions);
                        apps.Remove(Payment);
                        apps.Remove(Settings);
                        apps.Remove(Usage);
                        break;
                    }
                case UserRoles.Expert:
                    {
                        apps.Remove(PiAccount);
                        apps.Remove(Team);
                        apps.Remove(Subscriptions);
                        apps.Remove(Payment);
                        apps.Remove(Developer);
                        break;
                    }
                case UserRoles.Contributor:
                    {
                        apps.Remove(PiAccount);
                        apps.Remove(Team);
                        apps.Remove(Subscriptions);
                        apps.Remove(Payment);
                        apps.Remove(Settings);
                        apps.Remove(Usage);
                        apps.Remove(Developer);
                        break;
                    }
                case UserRoles.Analyst:
                    {
                        apps.Remove(PiAccount);
                        apps.Remove(Team);
                        apps.Remove(Subscriptions);
                        apps.Remove(Payment);
                        apps.Remove(Settings);
                        apps.Remove(Developer);
                        apps.Remove(Support);
                        break;
                    }
                case UserRoles.Support:
                    {
                        apps.Remove(PiAccount);
                        apps.Remove(Team);
                        apps.Remove(Subscriptions);
                        apps.Remove(Payment);
                        apps.Remove(Developer);
                        break;
                    }
                case UserRoles.ReadOnly:
                    {
                        apps.Remove(PiAccount);
                        apps.Remove(Team);
                        apps.Remove(Subscriptions);
                        apps.Remove(Payment);
                        apps.Remove(Settings);
                        apps.Remove(Developer);
                        apps.Remove(Usage);
                        apps.Remove(Support);
                        break;
                    }
                default:
                    {
                        throw new NotSupportedException($"'{role}' is not yet supported.");
                    }
            }

            return Join(apps);
        }

        /// <summary>
        /// Get the potential applications for an internal role.
        /// </summary>
        /// <param name="internalAdminRole">Internal admin role.</param>
        /// <param name="externalRole"></param>
        /// <returns></returns>
        public static string PotentialsInternalUser(string internalAdminRole, string externalRole)
        {
            if (!UserRoles.IsValidExternal(externalRole))
            {
                throw new InvalidOperationException($"'{externalRole}' is not a valid external role.");
            }

            if (!UserRoles.IsValidInternal(internalAdminRole))
            {
                throw new InvalidOperationException($"'{internalAdminRole}' is not a valid internal role.");
            }

            // Determine the base apps based on the specified admin role.
            List<string> apps = new List<string>();
            if (internalAdminRole.Equals(UserRoles.piBusinessAdminRole))
            {
                apps = BusinessAdmin.ToList();
            }
            else if (internalAdminRole.Equals(UserRoles.piOrgAdminRole))
            {
                apps = OrgAdmin.ToList();
            }
            else
            {
                throw new NotSupportedException($"Admin role '{internalAdminRole}' is not supported.");
            }

            switch (externalRole)
            {
                // Owner of admin business accounts.
                case UserRoles.Owner:
                    {
                        // Here the piOrgAdminRole does not have access to Stripe data and that is determined by
                        // OrgAdmin list.
                        return Join(apps);
                    }
                default:
                    {
                        // For non owners of Business Admin account, stripe data and business account info is not allowed.
                        apps.Remove(PiInternalStripeData);
                        apps.Remove(PiAccount);
                        return Join(apps);
                    }
            }
        }

        /// <summary>
        /// Splits all the specified permissions.
        /// </summary>
        public static HashSet<string> Split(string apps)
        {
            if (apps is null)
            {
                throw new System.ArgumentNullException(nameof(apps));
            }

            // https://stackoverflow.com/questions/19003055/convert-comma-separated-string-into-a-hashset
            HashSet<string> appSet = new();  // Or a more realistic size
            StringTokenizer st = new(apps, new char[] { UserRoles.RbacSeperator });
            foreach (StringSegment app in st)
            {
                appSet.Add(app.Value);
            }
            return appSet;
        }

        /// <summary>
        /// Get the subscribed applications for the specified role.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="subscribedApps"></param>
        /// <returns></returns>
        public static string SubscribedExternalUser(string role, string subscribedApps)
        {
            // Get allowed application permissions Role based applications may be subset of all subscribed applications.
            HashSet<string> potentials = Split(PotentialsExternalUser(role));
            HashSet<string> subscribed = Split(subscribedApps);
            return Join(potentials.Intersect(subscribed));
        }

        /// <summary>
        /// Get the subscribed applications of an internal user for the specified role in the specified admin account.
        /// </summary>
        /// <param name="internalAdminRole">Internal admin role.</param>
        /// <param name="externalRole"></param>
        /// <param name="subscribedApps"></param>
        /// <returns></returns>
        public static string SubscribedInternalUser(string internalAdminRole, string externalRole, string subscribedApps)
        {
            // Get allowed application permissions Role based applications may be subset of all subscribed applications.
            HashSet<string> potentials = Split(PotentialsInternalUser(internalAdminRole, externalRole));
            HashSet<string> subscribed = Split(subscribedApps);
            return Join(potentials.Intersect(subscribed));
        }

        /// <summary>
        /// RBAC application for managing chargeables service.
        /// </summary>
        public const string Apps = "ap";

        /// <summary>
        /// RBAC application for branding service.
        /// </summary>
        public const string Branding = "bd";

        /// <summary>
        /// RBAC application for customer service.
        /// </summary>
        public const string Customers = "ct";

        /// <summary>
        /// RBAC application for dashboard service.
        /// </summary>
        public const string Dashboard = "db";

        /// <summary>
        /// RBAC application for developer service.
        /// </summary>
        public const string Developer = "dv";

        /// <summary>
        /// RBAC application for identity service.
        /// </summary>
        public const string Identity = "id";

        /// <summary>
        /// RBAC application for licensing service.
        /// </summary>
        public const string Licensing = "li";

        /// <summary>
        /// RBAC application for multilanguage service.
        /// </summary>
        public const string Multilanguage = "ml";

        /// <summary>
        /// RBAC application for managing payments.
        /// </summary>
        public const string Payment = "pm";

        /// <summary>
        /// RBAC application for managing Business Account.
        /// </summary>
        public const string PiAccount = "ba";

        /// <summary>
        /// RBAC application for managing Stripe data.
        /// </summary>
        public const string PiInternalStripeData = "pisd";

        /// <summary>
        /// RBAC application for managing virtual machines.
        /// </summary>
        public const string PiInternalVirtualMachines = "pivm";

        /// <summary>
        /// RBAC application for managing settings.
        /// </summary>
        public const string Settings = "st";

        /// <summary>
        /// RBAC application for managing subscriptions.
        /// </summary>
        public const string Subscriptions = "su";

        /// <summary>
        /// RBAC application for support service.
        /// </summary>
        public const string Support = "sp";

        /// <summary>
        /// RBAC application for managing switch.
        /// </summary>
        public const string Switch = "sw";

        /// <summary>
        /// RBAC application for managing team.
        /// </summary>
        public const string Team = "tm";

        /// <summary>
        /// RBAC application for managing usage.
        /// </summary>
        public const string Usage = "ug";

        /// <summary>
        /// RBAC application for managing User Account.
        /// </summary>
        public const string UserAccount = "ua";

        /// <summary>
        /// RBAC application for support service.
        /// </summary>
        public const string Vault = "vu";

        /// <summary>
        /// All External RBAC applications. NOTE - Update this if new RBAC application is added.
        /// </summary>
        public static IEnumerable<string> All = new List<string>()
        {
            { Branding },
            { PiAccount },
            { Apps },
            { Customers },
            { Dashboard },
            { Developer },
            { Identity },
            { Licensing },
            { Multilanguage },
            { Payment },
            { PiInternalStripeData },
            { PiInternalVirtualMachines },
            { Settings },
            { Subscriptions },
            { Support },
            { Switch },
            { Team },
            { Usage },
            { UserAccount },
        }.AsReadOnly();

        /// <summary>
        /// Business Admin RBAC applications.
        /// </summary>
        public static IEnumerable<string> BusinessAdmin = new List<string>
        {
            // Internal - No logic so add alphabetically
            { Branding },
            { PiAccount },
            { Apps },
            { Dashboard },
            { PiInternalStripeData },
            { PiInternalVirtualMachines },
            { Settings },
            { Support },
            { Switch },
            { Team },
            { Usage },
            { UserAccount },
        }.AsReadOnly();

        /// <summary>
        /// All External RBAC applications.
        /// </summary>
        public static IEnumerable<string> External = new List<string>()
        {
            { Branding },
            { PiAccount },
            { Apps },
            { Customers },
            { Dashboard },
            { Developer },
            { Identity },
            { Licensing },
            { Multilanguage },
            { Payment },
            { Settings },
            { Subscriptions },
            { Support },
            { Switch },
            { Team },
            { Usage },
            { UserAccount },
        }.AsReadOnly();

        /// <summary>
        /// External Free RBAC applications.
        /// </summary>
        public static IEnumerable<string> ExternalFree = new List<string>()
        {
            { PiAccount },
            { Dashboard },
            { Developer },
            { Payment },
            { Settings },
            { Subscriptions },
            { Support },
            { Switch },
            { Team },
            { Usage },
            { UserAccount },
        }.AsReadOnly();

        /// <summary>
        /// External Paid RBAC applications.
        /// </summary>
        public static IEnumerable<string> ExternalPaid = new List<string>()
        {
             // External - No logic so add alphabetically
            { Apps },
            { Branding },
            { Customers },
            { Identity },
            { Licensing },
            { Multilanguage },
        }.AsReadOnly();

        /// <summary>
        /// All Internal RBAC applications. NOTE - Update this if new RBAC application is added.
        /// </summary>
        public static IEnumerable<string> Internal = new List<string>()
        {
            // Internal - No logic so add alphabetically
            { PiInternalStripeData },
            { PiInternalVirtualMachines },
        }.AsReadOnly();

        /// <summary>
        /// Business Admin RBAC applications.
        /// </summary>
        public static IEnumerable<string> OrgAdmin = new List<string>
        {
            // Internal - No logic so add alphabetically
            { Branding },
            { PiAccount },
            { PiInternalVirtualMachines },
            { Support },
            { Switch },
            { Team },
            { UserAccount },
        }.AsReadOnly();

        /// <summary>
        /// Define secondary applications associated with primary applications
        /// </summary>
        public static ReadOnlyDictionary<string, string> Secondary = new ReadOnlyDictionary<string, string>
            (
                new Dictionary<string, string>()
                {
                    { Multilanguage, Customers },
                    { Identity, Apps },
                }
            );
    }
}
