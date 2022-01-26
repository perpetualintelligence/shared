/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Attributes;
using PerpetualIntelligence.Shared.Attributes.Api;
using PerpetualIntelligence.Shared.Exceptions;
using PerpetualIntelligence.Shared.Extensions;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Test.Services
{
    /// <summary>
    /// This class provides helper methods for unit tests.
    /// </summary>
    /// <remarks>
    /// <see cref="TestHelper"/> is part of the Perpetual Intelligence infrastructure. Please do not use it directly in
    /// your application code.
    /// </remarks>
    [InternalInfrastructure]
    public static class TestHelper
    {
        /// <summary>
        /// Asserts the value is any of the specified values.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="anyOf">Allowed values.</param>
        public static void AssertAnyOf(string? value, params string[] anyOf)
        {
            if (!anyOf.Contains(value))
            {
                Assert.Fail($"'{value}' is not valid. Allowed Values={string.Join(',', anyOf)}");
            }
        }

        /// <summary>
        /// Asserts the value is any of the given collection.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="groupName"></param>
        /// <param name="ignoreApi"></param>
        /// <param name="inherit"></param>
        /// <summary>
        /// Asserts <see cref="HttpMethodAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertApiExplorer(MemberInfo? member, string? groupName, bool ignoreApi, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            ApiExplorerSettingsAttribute? apiExplorer = member.GetCustomAttribute<ApiExplorerSettingsAttribute>(inherit);
            if (apiExplorer == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(ApiExplorerSettingsAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(groupName, apiExplorer.GroupName, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(ApiExplorerSettingsAttribute).Name}' but its group name is invalid.");
                    Assert.AreEqual(ignoreApi, apiExplorer.IgnoreApi, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(ApiExplorerSettingsAttribute).Name}' but its ignore API value is invalid.");
                }
                else
                {
                    Assert.AreEqual(groupName, apiExplorer.GroupName, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ApiExplorerSettingsAttribute).Name}' but its group name is invalid.");
                    Assert.AreEqual(ignoreApi, apiExplorer.IgnoreApi, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ApiExplorerSettingsAttribute).Name}' but its ignore API value is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts specified number of attributes are applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertApiVersion(MemberInfo? member, string version, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            ApiVersionAttribute? apiVersion = member.GetCustomAttribute<ApiVersionAttribute>(inherit);
            if (apiVersion == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(ApiVersionAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(version, apiVersion.Versions[0].ToString(), $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(ApiVersionAttribute).Name}' but its version is invalid.");
                }
                else
                {
                    Assert.AreEqual(version, apiVersion.Versions[0].ToString(), $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(ApiVersionAttribute).Name}' but its version is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="ArchitectureAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertArchitectureCommentAttribute(MemberInfo? member, string description, string? version, string? severity, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            ArchitectureAttribute? architectureCommentAttribute = member.GetCustomAttribute<ArchitectureAttribute>(inherit);
            if (architectureCommentAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(ArchitectureAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(description, architectureCommentAttribute.Description, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(ArchitectureAttribute).Name}' but its description is invalid.");
                    Assert.AreEqual(version, architectureCommentAttribute.Version, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(ArchitectureAttribute).Name}' but its version is invalid.");
                    Assert.AreEqual(severity, architectureCommentAttribute.Severity, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(ArchitectureAttribute).Name}' but its severity is invalid.");
                }
                else
                {
                    Assert.AreEqual(description, architectureCommentAttribute.Description, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ArchitectureAttribute).Name}' but its description is invalid.");
                    Assert.AreEqual(version, architectureCommentAttribute.Version, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ArchitectureAttribute).Name}' but its version is invalid.");
                    Assert.AreEqual(severity, architectureCommentAttribute.Severity, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ArchitectureAttribute).Name}' but its severity is invalid.");
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public static void AssertArrayEquals<TValue>(TValue[]? expected, TValue[]? actual)
        {
            if (expected is null || actual is null)
            {
                throw new ArgumentNullException(nameof(expected), "Expected or Actual array cannot be null.");
            }

            // For display
            IEnumerable<string?> expectedStr = expected.Select(e => Convert.ToString(e));
            IEnumerable<string?> actualStr = actual.Select(e => Convert.ToString(e));

            if (expected.Length != actual.Length)
            {
                Assert.Fail($"Array length does not match. Expected='{string.Join(',', expectedStr)}' Actual='{string.Join(',', actualStr)}'.");
            }

            Assert.IsTrue(expected.SequenceEqual(actual), $"Array does not match. Expected='{string.Join(',', expectedStr)}' Actual='{string.Join(',', actualStr)}'.");
        }

        /// <summary>
        /// Asserts that the assembly has all types in the valid files or location.
        /// </summary>
        /// <param name="assembly"></param>
        public static void AssertAssemblyTypesLocation(Assembly assembly)
        {
            // e.g. D:/this/PI/Services/test/PerpetualIntelligence.Shared.Test/bin/Debug/net6.0/PerpetualIntelligence.Shared.dll
            string assemblyPath = assembly.Location ?? throw new InvalidOperationException("Assembly code base cannot be null.");
            string assemblyDir = Path.GetDirectoryName(assemblyPath)!;

            // check services dir For Azure pipileing this will be the working directory for the downloaded sources
            string servicesDir = IOHelper.GetParent(assemblyPath, 6) ?? throw new InvalidOperationException("Services dir not found.");

            // check /<services>/test dir
            string testDir = Path.Combine(servicesDir, "test");
            Assert.IsTrue(Directory.Exists(testDir));

            //check /<services>/src dir
            string srcDir = Path.Combine(servicesDir, "src");
            Assert.IsTrue(Directory.Exists(srcDir));

            // Remove the root namespace from input. Assembly name is the root namespace.
            IEnumerable<string?> namespaces = assembly.GetTypes().Where(e => !IsCompilerGenerated(e)).Select(e => e.Namespace).Distinct();
            IEnumerable<Type> allTypes = assembly.GetTypes().Where(e => !IsCompilerGenerated(e));
            foreach (string? ns in namespaces)
            {
                if (ns == null)
                {
                    throw new InvalidOperationException("Namespace cannot be null or empty.");
                }

                // Make sure the types count matches the files count
                IEnumerable<Type> nsTypes = allTypes.Where(e => ns.Equals(e.Namespace));
                AssertNamespaceTypesLocation(nsTypes, ns, srcDir);
            }
        }

        /// <summary>
        /// Asserts specified number of attributes are applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertAttribute<TAttribute>(MemberInfo? member, bool inherit = false) where TAttribute : Attribute
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            TAttribute? attribute = member.GetCustomAttribute<TAttribute>(inherit);
            if (attribute == null)
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.Fail($"Class '{classType.Namespace}.{member.Name}' does not define '{typeof(TAttribute).Name}' attribute.");
                }
                else
                {
                    Assert.Fail($"Member '{member.DeclaringType.FullName}.{member.Name}' does not define '{typeof(TAttribute).Name}' attribute.");
                }
            }
        }

        /// <summary>
        /// Asserts specified number of attributes are applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertAttributeCount(MemberInfo? member, int attributes, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            // HACK: Ignore runtime complier attribute Not all the runtime attributes have compiler generated so as a
            // hack we check the assembly.
            Attribute[] attrs = member.GetCustomAttributes<Attribute>(inherit).Where(e => !IsCompilerGenerated(e)).ToArray();
            if (member.DeclaringType == null)
            {
                Type classType = (Type)member;
                Assert.AreEqual(attributes, attrs.Length, $"Class '{classType.Namespace}.{member.Name}' does not define '{attributes}' attributes.");
            }
            else
            {
                Assert.AreEqual(attributes, attrs.Length, $"Member '{member.DeclaringType.FullName}.{member.Name}' does not define '{attributes}' attributes.");
            }
        }

        /// <summary>
        /// Asserts <see cref="BrowsableAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertBrowsableAttribute(MemberInfo? member, object value, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            BrowsableAttribute? browsable = member.GetCustomAttribute<BrowsableAttribute>(inherit);
            if (browsable == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(BrowsableAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(value, browsable.Browsable, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(EditorBrowsableAttribute).Name}' but its browsable is invalid.");
                }
                else
                {
                    Assert.AreEqual(value, browsable.Browsable, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(EditorBrowsableAttribute).Name}' but its browsable is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts specified type has the constants defined.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="constants"></param>
        public static void AssertConstantCount(Type? type, int constants)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            IEnumerable<FieldInfo>? consts = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly);
            Assert.AreEqual(constants, consts.Count(), $"Type '{type.FullName}' does not define '{constants}' constants.");
        }

        /// <summary>
        /// Asserts <see cref="DataTypeAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertDataTypeAttribute(MemberInfo? member, DataType dataType, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            DataTypeAttribute? dataTypeAttribute = member.GetCustomAttribute<DataTypeAttribute>(inherit);
            if (dataTypeAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(DataTypeAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(dataType, dataTypeAttribute.DataType, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DataTypeAttribute).Name}' but its data type is invalid.");
                }
                else
                {
                    Assert.AreEqual(dataType, dataTypeAttribute.DataType, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DataTypeAttribute).Name}' but its data type is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="DefaultValueAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertDefaultValueAttribute(MemberInfo? member, object value, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            DefaultValueAttribute? defaultValueAttribute = member.GetCustomAttribute<DefaultValueAttribute>(inherit);
            if (defaultValueAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(DefaultValueAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(value, defaultValueAttribute.Value, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DefaultValueAttribute).Name}' but its default value is invalid.");
                }
                else
                {
                    Assert.AreEqual(value, defaultValueAttribute.Value, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DefaultValueAttribute).Name}' but its default value is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="DisplayAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertDisplayAttribute(MemberInfo? member, string displayName, bool? autoGenerateField, string? description, string? groupName, int? order, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            DisplayAttribute? displayAttribute = member.GetCustomAttribute<DisplayAttribute>(inherit);
            if (displayAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(DisplayAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(displayName, displayAttribute.GetName(), $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its display name is invalid.");
                    Assert.AreEqual(autoGenerateField, displayAttribute.GetAutoGenerateField(), $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its autoGenerateField is invalid.");
                    Assert.AreEqual(description, displayAttribute.GetDescription(), $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its description is invalid.");
                    Assert.AreEqual(groupName, displayAttribute.GroupName, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its group name is invalid.");
                    Assert.AreEqual(order, displayAttribute.GetOrder(), $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its order is invalid.");
                }
                else
                {
                    Assert.AreEqual(displayName, displayAttribute.GetName(), $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its display name is invalid.");
                    Assert.AreEqual(autoGenerateField, displayAttribute.GetAutoGenerateField(), $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its autoGenerateField is invalid.");
                    Assert.AreEqual(description, displayAttribute.GetDescription(), $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its description is invalid.");
                    Assert.AreEqual(groupName, displayAttribute.GroupName, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its group name is invalid.");
                    Assert.AreEqual(order, displayAttribute.GetOrder(), $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(DisplayAttribute).Name}' but its order is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="EditableAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertEditableAttribute(MemberInfo? member, bool allowEdit, bool allowInitialEdit, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            EditableAttribute? editableAttribute = member.GetCustomAttribute<EditableAttribute>(inherit);
            if (editableAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(EditableAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(allowEdit, editableAttribute.AllowEdit, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(EditableAttribute).Name}' but its allow edit is invalid.");
                    Assert.AreEqual(allowInitialEdit, editableAttribute.AllowInitialValue, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(EditableAttribute).Name}' but its allow initial edit is invalid.");
                }
                else
                {
                    Assert.AreEqual(allowEdit, editableAttribute.AllowEdit, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(EditableAttribute).Name}' but its allow edit is invalid.");
                    Assert.AreEqual(allowInitialEdit, editableAttribute.AllowInitialValue, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(EditableAttribute).Name}' but its allow initial edit is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="EditorBrowsableAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertEditorBrowsableAttribute(MemberInfo? member, object value, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            EditorBrowsableAttribute? editorBrowsable = member.GetCustomAttribute<EditorBrowsableAttribute>(inherit);
            if (editorBrowsable == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(EditorBrowsableAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(value, editorBrowsable.State, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(EditorBrowsableAttribute).Name}' but its state is invalid.");
                }
                else
                {
                    Assert.AreEqual(value, editorBrowsable.State, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(EditorBrowsableAttribute).Name}' but its state is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="HttpMethodAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertHttpMethod<TMethod>(MemberInfo? member, string template, bool inherit = false) where TMethod : HttpMethodAttribute
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            TMethod? method = member.GetCustomAttribute<TMethod>(inherit);
            if (method == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(TMethod).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(template, method.Template, $"Member '{classType.Namespace}.{member.Name}' has attribute '{typeof(TMethod).Name}' but its template is invalid.");
                }
                else
                {
                    Assert.AreEqual(template, method.Template, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(TMethod).Name}' but its template is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts the types that belong to the specified namespace are internal types.
        /// </summary>
        public static void AssertInternalTypes(Assembly assembly, string @namespace)
        {
            // Make sure the root name space end
            IEnumerable<Type> types = assembly.GetTypes().Where(e => !IsCompilerGenerated(e)).Where(e => e.Namespace != null && e.Namespace.StartsWith(@namespace));
            IEnumerable<Type> invalidTypes = types.Where(e => !e.IsNestedAssembly); // Must be internal class

            Assert.AreEqual(0, invalidTypes.Count(), $"Types must be internal.  {string.Join(',', invalidTypes.Select(e => e.FullName))}");
        }

        /// <summary>
        /// Asserts <see cref="HttpMethodAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertJsonPropertyName(MemberInfo? member, string name, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            JsonPropertyNameAttribute? jsonAttr = member.GetCustomAttribute<JsonPropertyNameAttribute>(inherit);
            if (jsonAttr == null)
            {
                Assert.Fail($"Member '{member.DeclaringType!.FullName}.{member.Name}' does not define '{typeof(JsonPropertyNameAttribute).Name}' attribute.");
            }
            else
            {
                Assert.AreEqual(name, jsonAttr.Name, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(JsonPropertyNameAttribute).Name}' but its name is invalid.");
            }
        }

        /// <summary>
        /// Asserts <see cref="HttpMethodAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertMapToApiVersion(MemberInfo? member, string version, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            MapToApiVersionAttribute? mapApi = member.GetCustomAttribute<MapToApiVersionAttribute>(inherit);
            if (mapApi == null)
            {
                Assert.Fail($"Member '{member.DeclaringType!.FullName}.{member.Name}' does not define '{typeof(MapToApiVersionAttribute).Name}' attribute.");
            }
            else
            {
                Assert.AreEqual(version, mapApi.Versions[0].ToString(), $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(MapToApiVersionAttribute).Name}' but its version is invalid.");
            }
        }

        /// <summary>
        /// Asserts <see cref="MaxLengthAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertMaxLengthAttributeAttribute(MemberInfo? member, int? maxLength, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            MaxLengthAttribute? maxLengthAttribute = member.GetCustomAttribute<MaxLengthAttribute>(inherit);
            if (maxLengthAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(MaxLengthAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(maxLength, maxLengthAttribute.Length, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(MaxLengthAttribute).Name}' but its maximux is invalid.");
                }
                else
                {
                    Assert.AreEqual(maxLength, maxLengthAttribute.Length, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(MaxLengthAttribute).Name}' but its maximum is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="MinLengthAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertMinLengthAttributeAttribute(MemberInfo? member, int? minLength, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            MinLengthAttribute? minLengthAttribute = member.GetCustomAttribute<MinLengthAttribute>(inherit);
            if (minLengthAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(MinLengthAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(minLength, minLengthAttribute.Length, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(MinLengthAttribute).Name}' but its minimum is invalid.");
                }
                else
                {
                    Assert.AreEqual(minLength, minLengthAttribute.Length, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(MinLengthAttribute).Name}' but its minimum is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts that the type has the specified namespace.
        /// </summary>
        /// <param name="type">Type to check.</param>
        /// <param name="namespace">Expected namespace.</param>
        public static void AssertNamespace(Type type, string @namespace)
        {
            Assert.AreEqual(@namespace, type.Namespace, $"Type '{type.FullName}' does not belong to namespace '{@namespace}'.");
        }

        /// <summary>
        /// Asserts that the assembly has valid namespace based on it name.
        /// </summary>
        /// <param name="assembly">Assembly to check.</param>
        /// <param name="rootNamespace">The expected root namespace.</param>
        public static void AssertNamespace(Assembly assembly, string rootNamespace)
        {
            // Make sure the root namespace end
            IEnumerable<Type> types = assembly.GetTypes().Where(e => !IsCompilerGenerated(e));

            // Make sure the root namespace for assembly is valid.
            string actualNamespace = assembly.GetName().Name ?? throw new InvalidOperationException("Assembly name null");
            Assert.AreEqual(rootNamespace, actualNamespace, $"Assembly '{assembly.GetName().Name}' does not have root namespace '{rootNamespace}'.");

            // All types must have namespace, null or not in root namespace is error.
            IEnumerable<Type> invalidTypes = types.Where(e =>
            {
                // Either the namespace should match root namespace or it should be nested namespace. This is to avoid
                if (e.Namespace != null && e.Namespace.StartsWith(rootNamespace))
                {
                    // Make sure do not have any concatenated names to the root namespace without nesting. e.g.
                    // PerpetualIntelligence.Shared123 - invalid PerpetualIntelligence.Shared.Services - valid
                    // PerpetualIntelligence.Shared - valid
                    string trimmed = e.Namespace.Replace(rootNamespace, "");
                    if (trimmed == string.Empty || trimmed.StartsWith("."))
                    {
                        // keep
                        return false;
                    }
                }

                // by default filter
                return true;
            });

            if (invalidTypes.Any())
            {
                Assert.Fail($"Assembly '{assembly.GetName().Name}' contains types '{string.Join(',', invalidTypes.Select(e => e.FullName))}'' that do not have root namespace '{rootNamespace}'.");
            }
        }

        /// <summary>
        /// Asserts that the specified types have valid 1-1 src files or location based on the specified namespace.
        /// </summary>
        /// <param name="types">Types to check. All types must be in same assembly.</param>
        /// <param name="namespace">Namespace to check.</param>
        /// <param name="srcDir">src directory.</param>
        public static void AssertNamespaceTypesLocation(IEnumerable<Type> types, string @namespace, string srcDir)
        {
            // Check for same assembly.
            Assembly assembly = types.First().Assembly;
            Assert.IsTrue(types.All(e => e.Assembly.Equals(assembly)), "All types must belong to same assembly.");

            //check /services/<prj> dir
            string prjDir = Path.Combine(srcDir, assembly.GetName().Name!);
            Assert.IsTrue(Directory.Exists(prjDir));

            // Get the namespace without the root component.
            string nonRootNamspace = @namespace.Replace(assembly.GetName().Name!, "").TrimStart('.');

            // check namespace dir. Start with project dir and combine all namespace.
            List<string> nDirs = new() { prjDir };
            nDirs.AddRange(nonRootNamspace.Split('.'));
            string namespaceDir = Path.Combine(nDirs.ToArray());
            Assert.IsTrue(Directory.Exists(namespaceDir), $"The namespace '{@namespace}' is not valid. The namespace component '{nonRootNamspace}' must be a directory.");

            // Make sure the type has the corresponding file.
            // TODO: We cannot get the actual code file that defines the type. So we are just checking whether there is a new file for each type and file name matches type.
            // Move this to an analyzer.
            IEnumerable<string>? files = Directory.EnumerateFiles(namespaceDir, "*.cs");
            foreach (Type type in types)
            {
                // Delegates can be in any file
                if (IsDelegate(type))
                {
                    continue;
                }

                string? typeFile = null;
                if (type.IsGenericType)
                {
                    // Kill everything after `
                    string typeName = type.Name;
                    int index = typeName.IndexOf("`");
                    if (index >= 0)
                    {
                        typeName = typeName[..index];
                    }

                    typeFile = Path.Combine(namespaceDir, $"{typeName}.cs");
                }
                else
                {
                    typeFile = Path.Combine(namespaceDir, $"{type.Name}.cs");
                }

                if (!files.Contains(typeFile))
                {
                    Assert.Fail($"Type '{type.FullName}' must be defined in the src path '{typeFile}'. Please correct the src path or update the namespace.");
                }
            }

            // Make sure the types count matches the files count
            Assert.AreEqual(files.Count(), types.Count(), $"Namespace '{@namespace}' has {types.Count()} types, but it has {files.Count()} source files.");
        }

        /// <summary>
        /// Asserts <see cref="Result"/> is an error.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        public static void AssertOneImlxError(Result result, string error, string? errorDescription)
        {
            Assert.IsTrue(result.IsError);
            Assert.IsNotNull(result.FirstError);
            Assert.AreEqual(error, result.FirstError.ErrorCode);
            Assert.AreEqual(errorDescription, result.FirstError.FormatDescription());
        }

        /// <summary>
        /// Asserts <see cref="Error"/>
        /// </summary>
        /// <param name="error"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorDescription"></param>
        public static void AssertOneImlxError(Error error, string errorCode, string? errorDescription)
        {
            Assert.IsNotNull(error);
            Assert.AreEqual(errorCode, error.ErrorCode);
            Assert.AreEqual(errorDescription, error.FormatDescription());
        }

        /// <summary>
        /// </summary>
        /// <param name="result"></param>
        /// <param name="exceptionMessage"></param>
        public static void AssertOneImlxHttpResultException(HttpResult result, string exceptionMessage)
        {
            Assert.AreEqual(HttpResultType.Exception, result.ResultType);
            Assert.IsNotNull(result.Exception);
            Assert.AreEqual(exceptionMessage, result.Exception.Message);
            Assert.IsNull(result.HttpResponse);
            Assert.IsNull(result.Raw);
            Assert.AreEqual(JsonValueKind.Undefined, result.Json.ValueKind);
        }

        /// <summary>
        /// </summary>
        /// <param name="result"></param>
        /// <param name="httpStatusCode"></param>
        /// <param name="reasonPhrase"></param>
        /// <param name="raw"></param>
        public static void AssertOneImlxHttpResultResponse(HttpResult result, HttpStatusCode httpStatusCode, string? reasonPhrase, string? raw)
        {
            Assert.AreEqual(HttpResultType.HttpResponse, result.ResultType);
            Assert.IsNotNull(result.HttpResponse);
            Assert.AreEqual(httpStatusCode, result.HttpResponse.StatusCode);
            Assert.AreEqual(reasonPhrase, result.HttpResponse.ReasonPhrase);
            Assert.AreEqual(raw, result.Raw);
            Assert.IsNull(result.Exception);
        }

        /// <summary>
        /// Asserts <see cref="ProducesAttribute"/> is applied on the specified member.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="contentType"></param>
        /// <param name="inherit"></param>
        public static void AssertProduces(MemberInfo? member, string contentType, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            ProducesAttribute? produces = member.GetCustomAttribute<ProducesAttribute>(inherit);
            if (produces == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(ProducesAttribute).Name}' attribute.");
            }
            else
            {
                Assert.AreEqual(contentType, produces.ContentTypes[0], $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(ProducesAttribute).Name}' but its content type is invalid.");
            }
        }

        /// <summary>
        /// Asserts <see cref="ProducesDefaultResponseTypeAttribute"/> is applied on the specified member.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="responseType"></param>
        /// <param name="inherit"></param>
        public static void AssertProducesDefaultResponseType(MemberInfo? member, Type responseType, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            ProducesDefaultResponseTypeAttribute? produces = member.GetCustomAttribute<ProducesDefaultResponseTypeAttribute>(inherit);
            if (produces == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(ProducesDefaultResponseTypeAttribute).Name}' attribute.");
            }
            else
            {
                Assert.AreEqual(responseType, produces.Type, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(ProducesDefaultResponseTypeAttribute).Name}' but its response type is invalid.");
            }
        }

        /// <summary>
        /// Asserts <see cref="ProducesDefaultResponseTypeAttribute"/> is applied on the specified member.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="responseType"></param>
        /// <param name="statusCode"></param>
        /// <param name="inherit"></param>
        public static void AssertProducesResponseType(MemberInfo? member, Type responseType, int statusCode, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            ProducesResponseTypeAttribute? produces = member.GetCustomAttribute<ProducesResponseTypeAttribute>(inherit);
            if (produces == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(ProducesResponseTypeAttribute).Name}' attribute.");
            }
            else
            {
                Assert.AreEqual(responseType, produces.Type, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(ProducesResponseTypeAttribute).Name}' but its response type is invalid.");
                Assert.AreEqual(statusCode, produces.StatusCode, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(ProducesResponseTypeAttribute).Name}' but its status code is invalid.");
            }
        }

        /// <summary>
        /// To check if properties defined in the class are same as in the interface.
        /// </summary>
        public static void AssertPropertiesMatchInterface(Type typeClass, Type typeInterface)
        {
            if (typeClass is null)
            {
                throw new ArgumentNullException(nameof(typeClass));
            }
            if (typeInterface is null)
            {
                throw new ArgumentNullException(nameof(typeInterface));
            }

            var typeProps = GetAllProperties(typeClass).Select(p => p.Name).ToArray();

            // Interface needs flattened hiearchy https://stackoverflow.com/questions/358835/getproperties-to-return-all-properties-for-an-interface-inheritance-hierarchy/2444090
            var typeInterfaceProps = GetAllProperties(typeInterface).Select(p => p.Name).ToArray();

            CollectionAssert.AreEquivalent(typeInterfaceProps, typeProps);
        }

        /// <summary>
        /// Asserts <see cref="RangeAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertRangeAttribute(MemberInfo? member, object minLength, object maxLength, string? message, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            RangeAttribute? rangeAttribute = member.GetCustomAttribute<RangeAttribute>(inherit);
            if (rangeAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(RangeAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(maxLength, rangeAttribute.Maximum, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(RangeAttribute).Name}' but its maximum is invalid.");
                    Assert.AreEqual(minLength, rangeAttribute.Minimum, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(RangeAttribute).Name}' but its minimum is invalid.");
                    Assert.AreEqual(message, rangeAttribute.ErrorMessage, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(RangeAttribute).Name}' but its error meassage is invalid.");
                }
                else
                {
                    Assert.AreEqual(maxLength, rangeAttribute.Maximum, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(RangeAttribute).Name}' but its maximum is invalid.");
                    Assert.AreEqual(minLength, rangeAttribute.Minimum, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(RangeAttribute).Name}' but its minimum is invalid.");
                    Assert.AreEqual(message, rangeAttribute.ErrorMessage, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(RangeAttribute).Name}' but its error message is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="HttpMethodAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertRefactorAttribute(MemberInfo? member, string? description, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            RefactorAttribute? refactorAttribute = member.GetCustomAttribute<RefactorAttribute>(inherit);
            if (refactorAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(RefactorAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(description, refactorAttribute.Description, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(RefactorAttribute).Name}' but its description is invalid.");
                }
                else
                {
                    Assert.AreEqual(description, refactorAttribute.Description, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(RefactorAttribute).Name}' but its description is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="RegularExpressionAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertRegularExpressionAttribute(MemberInfo? member, string pattern, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            RegularExpressionAttribute? regularExpressionAttribute = member.GetCustomAttribute<RegularExpressionAttribute>(inherit);
            if (regularExpressionAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(RegularExpressionAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(pattern, regularExpressionAttribute.Pattern, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(RegularExpressionAttribute).Name}' but its pattern name is invalid.");
                }
                else
                {
                    Assert.AreEqual(pattern, regularExpressionAttribute.Pattern, $"Member '{member.DeclaringType!.FullName}.{member.Name}' has attribute '{typeof(RegularExpressionAttribute).Name}' but its pattern name is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="HttpMethodAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertRoute(MemberInfo? member, string template, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            RouteAttribute? routeAttr = member.GetCustomAttribute<RouteAttribute>(inherit);
            if (routeAttr == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(RouteAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(template, routeAttr.Template, $"Member '{classType.Namespace}.{member.Name}' has attribute '{typeof(RouteAttribute).Name}' but its template is invalid.");
                }
                else
                {
                    Assert.AreEqual(template, routeAttr.Template, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(RouteAttribute).Name}' but its template is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="StringLengthAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertStringLengthAttribute(MemberInfo? member, int? maxLength, int? minLength, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            StringLengthAttribute? stringLengthAttribute = member.GetCustomAttribute<StringLengthAttribute>(inherit);
            if (stringLengthAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(StringLengthAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(maxLength, stringLengthAttribute.MaximumLength, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(StringLengthAttribute).Name}' but its max length is invalid.");
                    Assert.AreEqual(minLength, stringLengthAttribute.MinimumLength, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(StringLengthAttribute).Name}' but its min length is invalid.");
                }
                else
                {
                    Assert.AreEqual(maxLength, stringLengthAttribute.MaximumLength, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(StringLengthAttribute).Name}' but its max length is invalid.");
                    Assert.AreEqual(minLength, stringLengthAttribute.MinimumLength, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(StringLengthAttribute).Name}' but its min length is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="HiddenPropertyAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertSwaggerHideProperty(MemberInfo? member, string? propertyName, string? justification, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            HiddenPropertyAttribute? swaggerHidePropertyAttribute = member.GetCustomAttribute<HiddenPropertyAttribute>(inherit);
            if (swaggerHidePropertyAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(HiddenPropertyAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(propertyName, swaggerHidePropertyAttribute.Property, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(HiddenPropertyAttribute).Name}' but its property name is invalid.");
                    Assert.AreEqual(justification, swaggerHidePropertyAttribute.Justification, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(HiddenPropertyAttribute).Name}' but its justification is invalid.");
                }
                else
                {
                    Assert.AreEqual(propertyName, swaggerHidePropertyAttribute.Property, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ApiExplorerSettingsAttribute).Name}' but its property name is invalid.");
                    Assert.AreEqual(justification, swaggerHidePropertyAttribute.Justification, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(ApiExplorerSettingsAttribute).Name}' but its justification is invalid.");
                }
            }
        }

        /// <summary>
        /// Throws async with message.
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="action"></param>
        /// <param name="message"></param>
        public static async Task AssertThrowsWithMessageAsync<TException>(Func<Task> action, string message) where TException : Exception
        {
            try
            {
                await action.Invoke();
            }
            catch (Exception ex)
            {
                if (ex is TException)
                {
                    if (!ex.Message.Equals(message))
                    {
                        Assert.Fail($"Expected Message={message} Actual Message={ex.Message}");
                    }
                    else
                    {
                        // Good to go, expected exception with message thrown.
                        return;
                    }
                }
                else
                {
                    Assert.Fail($"Expected Exception={typeof(TException).Name} Actual Exception={ex.GetType().Name}");
                }
            }

            Assert.Fail($"Expected exception '{typeof(TException).Name}', but not exception was thrown.");
        }

        /// <summary>
        /// Ensures that an action throws <see cref="ErrorException"/>.
        /// </summary>
        /// <param name="funcTask">The task to execute.</param>
        /// <param name="errorCode">The expected error code.</param>
        /// <param name="errorDescription">The expected error description.</param>
        /// <returns><see cref="TryResult{T}"/> instance that contains the result or an <see cref="Error"/> instance.</returns>
        public static async Task AssertThrowsErrorExceptionAsync(Func<Task> funcTask, string errorCode, string errorDescription)
        {
            try
            {
                // We take Func<Task> so that the task does not execute before AssertThrowsErrorExceptionAsync is called.
                await funcTask.Invoke();
            }
            catch (ErrorException ee)
            {
                Assert.IsNotNull(ee.Error);
                Assert.IsNotNull(ee.Error.ErrorCode);
                Assert.IsNotNull(ee.Error.ErrorDescription);
                Assert.AreEqual(errorCode, ee.Error.ErrorCode);
                Assert.AreEqual(errorDescription, ee.Error.FormatDescription());

                // All good, expected error validated
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail($"The action did not throw '{nameof(ErrorException)}', instead it threw '{ex.GetType().Name}'.");
            }

            Assert.Fail($"The action did not throw '{nameof(ErrorException)}' with error '{errorCode}' and error description '{errorDescription}'.");
        }

        /// <summary>
        /// Ensures that a task throws <see cref="MultiErrorException"/> asynchronously.
        /// </summary>
        /// <param name="funcTask">The task to execute.</param>
        /// <param name="errorCount">The expected error count.</param>
        /// <param name="errorCodes">The expected error codes.</param>
        /// <param name="errorDescriptions">The expected error descriptions.</param>
        public static async Task AssertThrowsMultiErrorExceptionAsync(Func<Task> funcTask, int errorCount, string[] errorCodes, string[] errorDescriptions)
        {
            try
            {
                // We take Func<Task> so that the task does not execute before AssertThrowsMultiErrorExceptionAsync is called.
                await funcTask.Invoke();
            }
            catch (MultiErrorException me)
            {
                Assert.AreEqual(errorCount, me.Errors.Length, "The task did not throw expected errors.");

                for (int idx = 0; idx < me.Errors.Length; idx++)
                {
                    Error ee = me.Errors[idx];
                    Assert.IsNotNull(ee);
                    Assert.IsNotNull(ee.ErrorCode);
                    Assert.IsNotNull(ee.ErrorDescription);
                    Assert.AreEqual(errorCodes[idx], ee.ErrorCode);
                    Assert.AreEqual(errorDescriptions[idx], ee.FormatDescription());
                }

                // All good, expected validation pass
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail($"The task did not throw '{nameof(MultiErrorException)}', instead it threw '{ex.GetType().Name}'.");
            }

            Assert.Fail($"The task did not throw '{nameof(MultiErrorException)}' with errors '{errorCodes.JoinBySpace()}' and error descriptions '{errorDescriptions.JoinBySpace()}'.");
        }

        /// <summary>
        /// Throws exception if caught with message.
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="action"></param>
        /// <param name="message"></param>
        public static void AssertThrowsWithMessage<TException>(Action action, string message) where TException : Exception
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                if (ex is TException)
                {
                    if (!ex.Message.Equals(message))
                    {
                        Assert.Fail($"Expected Message={message} Actual Message={ex.Message}");
                    }
                    else
                    {
                        // Good to go, expected exception with message thrown.
                        return;
                    }
                }
                else
                {
                    Assert.Fail($"Expected Exception={typeof(TException).Name} Actual Exception={ex.GetType().Name}");
                }
            }

            Assert.Fail($"Expected exception '{typeof(TException).Name}', but not exception was thrown.");
        }

        /// <summary>
        /// Asserts <see cref="TodoAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertTodoAttribute(MemberInfo? member, string description, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            TodoAttribute? todoAttribute = member.GetCustomAttribute<TodoAttribute>(inherit);
            if (todoAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(TodoAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(description, todoAttribute.Description, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(TodoAttribute).Name}' but its description is invalid.");
                }
                else
                {
                    Assert.AreEqual(description, todoAttribute.Description, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(TodoAttribute).Name}' but its description is invalid.");
                }
            }
        }

        /// <summary>
        /// Asserts <see cref="WriteDocumentationAttribute"/> is applied on the specified member.
        /// </summary>
        /// <returns></returns>
        public static void AssertToDocumentationAttribute(MemberInfo? member, string description, bool inherit = false)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            WriteDocumentationAttribute? documentationAttribute = member.GetCustomAttribute<WriteDocumentationAttribute>(inherit);
            if (documentationAttribute == null)
            {
                Assert.Fail($"Member '{member.Name}' does not define '{typeof(WriteDocumentationAttribute).Name}' attribute.");
            }
            else
            {
                if (member.DeclaringType == null)
                {
                    Type classType = (Type)member;
                    Assert.AreEqual(description, documentationAttribute.Description, $"Class '{classType.Namespace}.{member.Name}' has attribute '{typeof(WriteDocumentationAttribute).Name}' but its description is invalid.");
                }
                else
                {
                    Assert.AreEqual(description, documentationAttribute.Description, $"Member '{member.DeclaringType.FullName}.{member.Name}' has attribute '{typeof(WriteDocumentationAttribute).Name}' but its description is invalid.");
                }
            }
        }

        /// <summary>
        /// </summary>
        public static bool IsReleasePipelineConfig()
        {
            string? pipelineConfig = System.Environment.GetEnvironmentVariable("PIDEVOPSPIPELINECONFIGURATION");

            // Null for local env
            if (pipelineConfig == null)
            {
                return false;
            }

            return pipelineConfig == "Release";
        }

        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
        {
            if (!type.IsInterface)
                return type.GetProperties();

            // https://stackoverflow.com/questions/358835/getproperties-to-return-all-properties-for-an-interface-inheritance-hierarchy/2444090
            // Do we need distinct check
            return (new Type[] { type })
                   .Concat(type.GetInterfaces())
                   .SelectMany(i => i.GetProperties());
        }

        /// <summary>
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private static bool IsCompilerGenerated(Attribute arg)
        {
            return IsCompilerGenerated(arg.GetType());
        }

        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool IsCompilerGenerated(Type type)
        {
            if (type.IsDefined(typeof(CompilerGeneratedAttribute)))
            {
                return true;
            }

            if (type.Namespace == null)
            {
                return true;
            }

            // https://github.com/coverlet-coverage/coverlet/issues/1191
            if (type.Namespace == "Coverlet.Core.Instrumentation.Tracker")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Determines if the type is a delegate.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns><c>true</c> if the type is sub class of <see cref="Delegate"/>, otherwise <c>false</c>.</returns>
        private static bool IsDelegate(Type type)
        {
            return type.IsSubclassOf(typeof(Delegate));
        }
    }
}
