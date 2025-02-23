#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 7/31/2024
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '12.2.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://learn.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '3.0.3'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '6.0.3'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.5'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '4.0.3'; }, 
               @{ModuleName = 'Az.App'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '2.2.5'; }, 
               @{ModuleName = 'Az.ArcResourceBridge'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '2.0.2'; }, 
               @{ModuleName = 'Az.Automanage'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.10.0'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.6.2'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.4'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '3.2.1'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.14.1'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '8.2.0'; }, 
               @{ModuleName = 'Az.ConfidentialLedger'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '4.2.1'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.14.4'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.8.1'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.18.6'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.2'; }, 
               @{ModuleName = 'Az.DataProtection'; RequiredVersion = '2.4.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '4.3.1'; }, 
               @{ModuleName = 'Az.DevCenter'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.DnsResolver'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ElasticSan'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.11.1'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.1.0'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '6.1.0'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.6'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '6.0.1'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.3.1'; }, 
               @{ModuleName = 'Az.LoadTesting'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.1'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.MachineLearningServices'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.4.2'; }, 
               @{ModuleName = 'Az.ManagedServiceIdentity'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '2.4.0'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '5.2.1'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '7.8.0'; }, 
               @{ModuleName = 'Az.NetworkCloud'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Nginx'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.2.1'; }, 
               @{ModuleName = 'Az.Oracle'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.6.5'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.5'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '7.0.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.10.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.ResourceGraph'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '7.3.0'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.6.2'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '3.1.2'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.3.3'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '5.2.0'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '2.4.0'; }, 
               @{ModuleName = 'Az.StackHCIVM'; RequiredVersion = '1.0.4'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '7.2.0'; }, 
               @{ModuleName = 'Az.StorageMover'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.1'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '3.0.9'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.2.2'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '3.2.1'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '12.2.0 - August 2024
Az.Accounts
* Reduced the frequency of displaying sign-in announcement messages.
* Upgraded Azure.Core to 1.41.0 to include the fix for ''BearerTokenAuthenticationPolicy''
* Removed the informational table about selected context to avoid duplication with output table.

Az.Cdn
* Bypassed object id validation for KeyVault access policy during ''Start-AzFrontDoorCdnProfilePrepareMigration''

Az.Compute
* Renamed parameter ''-VmId'' to ''-SourceId'' and added ''-VmId'' as an alias to ''New-AzRestorePointCollection'' cmdlet.

Az.Databricks
* Fixed Access Connector Resource update for ''Update-AzDatabricksWorkspace''

Az.DataFactory
* Added security enhancement feature snowflake support storage integration.
* Supported ''domain'' Property In Dynamics Family.
* Enabled UAMI auth for Data Factory Sql Server connector.
* Supported managed identity for Data Factory Azure Table connector.

Az.MachineLearningServices
* Updated API version to 2024-04-01
* Added Kind and HubResourceId parameters for Workspace cmdlets
* Fixed batch deployment creation issue
* Fixed Connection creation issue
* Added Connection Properties object cmdlets for connection creation
    - ''New-AzMLWorkspaceAadAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceAccessKeyAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceAccountKeyAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceApiKeyAuthWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceCustomKeysWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceManagedIdentityAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceNoneAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceOAuth2AuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspacePatAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceSasAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceServicePrincipalAuthTypeWorkspaceConnectionPropertiesObject''
    - ''New-AzMLWorkspaceUsernamePasswordAuthTypeWorkspaceConnectionPropertiesObject''
* Added Model reference object cmdlets for batch deployment creation
    - ''New-AzMLWorkspaceIdAssetReferenceObject''
    - ''New-AzMLWorkspaceDataPathAssetReferenceObject''
    - ''New-AzMLWorkspaceOutputPathAssetReferenceObject''

Az.Nginx
* Added feature for auto scaling and upgradeprofile, and nginx configuration analysis

Az.RedisCache
* Added support for Disabling Access Keys Authentication

Az.Resources
* Added null check and empty list check to the permissions object in the ToPSRoleDefinition method.
* Added argument completer for ''EnforcementMode'', ''IdentityType''
    * ''New-AzPolicyAssignment''
    * ''New-AzPolicyExemption''
    * ''Update-AzPolicyAssignment''
    * ''Update-AzPolicyExemption''
* Fixed bug deserializing property: ''policyDefinitionReferenceId'' [#25112] 
* Fixed overriding of Bicep parameters in Deployment cmdlets to support ''SecureString'' parameters.
* Added Test cmdlets for Deployment Stacks.

Az.Sql
* Added breaking change announcement for cmdlets: ''New-AzSqlInstanceLink'', ''Get-AzSqlInstanceLink'', ''Remove-AzSqlInstanceLink'', ''Update-AzSqlInstanceLink''.
* Added ''IsGeneralPurposeV2'' and ''StorageIOps'' parameters to ''New-AzSqlInstance'', ''Set-AzSqlInstance'' to enable the creation of GPv2 instances
* Added IsGeneralPurposeV2 and StorageIOps fields to the model of the managed instance so that it displays information about GPv2 instances that are returned by ''Get-AzSqlInstance''.
* Added new cmdlet ''Set-AzSqlDatabaseReplicationLink'' for updating replication link type
* Updated ''Get-AzSqlDatabaseReplicationLink'' to use the new sdk

Az.StackHCI
* Upgraded API version to 2024-04-01
* Allowed registration for 23H2 and above versions of the device

Az.Storage
* Upgraded Microsoft.Azure.Storage.DataMovement to 2.0.5

Az.StorageSync
* Fixed the Register-AzStorageSyncServer with Azure FileSync Agent v17
* Improved performance for Managed Identity migration cmdlet
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

