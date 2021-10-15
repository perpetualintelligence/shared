/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The Perpetual Intelligence role based permissions.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    public static class RbacPerms
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
        /// Joins all the specified permissions.
        /// </summary>
        public static string Join(params string[] permissions)
        {
            return Join(permissions.AsEnumerable());
        }

        /// <summary>
        /// Joins all the specified permissions.
        /// </summary>
        public static string Join(IEnumerable<string> permissions)
        {
            if (permissions is null)
            {
                throw new ArgumentNullException(nameof(permissions));
            }

            // Make sure permissions are valid
            IEnumerable<string> diff = permissions.Except(All);
            if (diff.Count() > 0)
            {
                throw new InvalidOperationException($"Permissions '{string.Join(UserRoles.RbacSeperator.ToString(), diff)}' are not valid.");
            }

            return string.Join(UserRoles.RbacSeperator.ToString(), permissions);
        }

        /// <summary>
        /// Returns potentials permissions based on the specified role.
        /// </summary>
        /// <param name="role"></param>
        public static string PotentialsExternalUser(string role)
        {
            if (!UserRoles.IsValidExternal(role))
            {
                throw new InvalidOperationException($"'{role}' is not a valid external role.");
            }

            // To define potential permissions for external role start will all permissions. Make sure we copy this
            // otherwise we will modify the original collection
            List<string> perms = All.ToList();

            // Fall through based on roles and superset to subset.
            switch (role)
            {
                case UserRoles.Owner:
                    {
                        // All Perms
                        break;
                    }
                case UserRoles.Administrator:
                    {
                        // All Perms
                        break;
                    }
                case UserRoles.Developer:
                    {
                        // All Perms
                        break;
                    }
                case UserRoles.Expert:
                    {
                        // All Perms
                        break;
                    }
                case UserRoles.Contributor:
                    {
                        perms.Remove(Clear);
                        perms.Remove(Delete);
                        perms.Remove(Download);
                        perms.Remove(Export);
                        perms.Remove(Lock);
                        perms.Remove(Remove);
                        perms.Remove(Unlock);
                        break;
                    }
                case UserRoles.Analyst:
                    {
                        perms.Remove(Add);
                        perms.Remove(Clear);
                        perms.Remove(Create);
                        perms.Remove(Delete);
                        perms.Remove(Import);
                        perms.Remove(Lock);
                        perms.Remove(Publish);
                        perms.Remove(Remove);
                        perms.Remove(Unlock);
                        perms.Remove(Update);
                        perms.Remove(Upload);
                        break;
                    }
                case UserRoles.Support:
                    {
                        // Need to revisit
                        perms.Remove(Clear);
                        perms.Remove(Delete);
                        perms.Remove(Download);
                        perms.Remove(Export);
                        perms.Remove(Import);
                        perms.Remove(Lock);
                        perms.Remove(Publish);
                        perms.Remove(Remove);
                        perms.Remove(Unlock);
                        perms.Remove(Update);
                        perms.Remove(Upload);
                        break;
                    }
                case UserRoles.ReadOnly:
                    {
                        // Need to revisit
                        perms.Remove(Add);
                        perms.Remove(Clear);
                        perms.Remove(Create);
                        perms.Remove(Delete);
                        perms.Remove(Download);
                        perms.Remove(Export);
                        perms.Remove(Import);
                        perms.Remove(Lock);
                        perms.Remove(Publish);
                        perms.Remove(Remove);
                        perms.Remove(Test);
                        perms.Remove(Unlock);
                        perms.Remove(Update);
                        perms.Remove(Upload);
                        break;
                    }
                default:
                    {
                        throw new NotSupportedException($"'{role}' is not yet supported.");
                    }
            }

            return Join(perms);
        }

        /// <summary>
        /// Returns potentials internal permissions based on the specified role.
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

            // Perms do not have any special processing for internal users. They are decided based on external role.
            return PotentialsExternalUser(externalRole);
        }

        /// <summary>
        /// Splits all the specified permissions.
        /// </summary>
        public static HashSet<string> Split(string permissions)
        {
            if (permissions is null)
            {
                throw new ArgumentNullException(nameof(permissions));
            }

            // https://stackoverflow.com/questions/19003055/convert-comma-separated-string-into-a-hashset
            HashSet<string> permSet = new ();  // Or a more realistic size
            StringTokenizer st = new(permissions, new char[] { UserRoles.RbacSeperator });
            foreach(StringSegment perm in st)
            {
                permSet.Add(perm.Value);
            }
            return permSet;
        }

        /// <summary>
        /// Get the subscribed permissions for the specified role.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="subscribedPerms"></param>
        /// <returns></returns>
        public static string SubscribedExternalUser(string role, string subscribedPerms)
        {
            // Get allowed application permissions Role based applications may be subset of all subscribed applications.
            HashSet<string> potentials = Split(PotentialsExternalUser(role));
            HashSet<string> subscribed = Split(subscribedPerms);
            return Join(potentials.Intersect(subscribed));
        }

        /// <summary>
        /// . Get the subscribed permissions of an internal user for the specified role in the specified admin account.
        /// </summary>
        /// <param name="internalAdminRole"></param>
        /// <param name="externalRole"></param>
        /// <param name="subscribedPerms"></param>
        /// <returns></returns>
        public static string SubscribedInternalUser(string internalAdminRole, string externalRole, string subscribedPerms)
        {
            // Get allowed application permissions Role based applications may be subset of all subscribed applications.
            HashSet<string> potentials = Split(PotentialsInternalUser(internalAdminRole, externalRole));
            HashSet<string> subscribed = Split(subscribedPerms);
            return Join(potentials.Intersect(subscribed));
        }

        /// <summary>
        /// RBAC add permission.
        /// </summary>
        public const string Add = "ad";

        /// <summary>
        /// RBAC clear permission.
        /// </summary>
        public const string Clear = "cl";

        /// <summary>
        /// RBAC create permission.
        /// </summary>
        public const string Create = "cr";

        /// <summary>
        /// RBAC delete permission.
        /// </summary>
        public const string Delete = "dt";

        /// <summary>
        /// RBAC download permission.
        /// </summary>
        public const string Download = "dw";

        /// <summary>
        /// RBAC export permission.
        /// </summary>
        public const string Export = "ex";

        /// <summary>
        /// RBAC import permission.
        /// </summary>
        public const string Import = "im";

        /// <summary>
        /// RBAC list permission.
        /// </summary>
        public const string List = "lt";

        /// <summary>
        /// RBAC lock permission.
        /// </summary>
        public const string Lock = "lk";

        /// <summary>
        /// RBAC protect permission.
        /// </summary>
        public const string Protect = "pt";

        /// <summary>
        /// RBAC publish permission.
        /// </summary>
        public const string Publish = "pb";

        /// <summary>
        /// RBAC read permission.
        /// </summary>
        public const string Read = "rd";

        /// <summary>
        /// RBAC remove permission.
        /// </summary>
        public const string Remove = "rm";

        /// <summary>
        /// RBAC switch permission.
        /// </summary>
        public const string Switch = "sw";

        /// <summary>
        /// RBAC test permission.
        /// </summary>
        public const string Test = "ts";

        /// <summary>
        /// RBAC unlock permission.
        /// </summary>
        public const string Unlock = "ul";

        /// <summary>
        /// RBAC unprotect permission.
        /// </summary>
        public const string Unprotect = "ut";

        /// <summary>
        /// RBAC update permission.
        /// </summary>
        public const string Update = "ud";

        /// <summary>
        /// RBAC upload permission.
        /// </summary>
        public const string Upload = "up";

        /// <summary>
        /// RBAC validate permission.
        /// </summary>
        public const string Validate = "vd";

        /// <summary>
        /// All External RBAC permissions. NOTE - Update this if new RBAC application is added.
        /// </summary>
        public static IEnumerable<string> All = new List<string>()
        {
            { Add },
            { Clear },
            { Create },
            { Delete },
            { Download },
            { Export },
            { Import },
            { List },
            { Lock },
            { Protect },
            { Publish },
            { Read },
            { Remove },
            { Switch },
            { Test },
            { Unlock },
            { Unprotect },
            { Update },
            { Upload },
            { Validate },
        }.AsReadOnly();
    }
}
