// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.PowerShell;

    /// <summary>Class representing a database principal assignment.</summary>
    [System.ComponentModel.TypeConverter(typeof(DatabasePrincipalAssignmentTypeConverter))]
    public partial class DatabasePrincipalAssignment
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.DatabasePrincipalAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DatabasePrincipalAssignment(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.DatabasePrincipalPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.PrincipalType) content.GetValueForProperty("PrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.PrincipalType.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DatabasePrincipalRole) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DatabasePrincipalRole.CreateFrom);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("TenantName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantName = (string) content.GetValueForProperty("TenantName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantName, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalName = (string) content.GetValueForProperty("PrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalName, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.DatabasePrincipalAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DatabasePrincipalAssignment(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.DatabasePrincipalPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.PrincipalType) content.GetValueForProperty("PrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.PrincipalType.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DatabasePrincipalRole) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DatabasePrincipalRole.CreateFrom);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("TenantName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantName = (string) content.GetValueForProperty("TenantName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).TenantName, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalName = (string) content.GetValueForProperty("PrincipalName",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).PrincipalName, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.ResourceProvisioningState.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.DatabasePrincipalAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignment"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignment DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DatabasePrincipalAssignment(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.DatabasePrincipalAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignment"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignment DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DatabasePrincipalAssignment(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DatabasePrincipalAssignment" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DatabasePrincipalAssignment" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignment FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing a database principal assignment.
    [System.ComponentModel.TypeConverter(typeof(DatabasePrincipalAssignmentTypeConverter))]
    public partial interface IDatabasePrincipalAssignment

    {

    }
}