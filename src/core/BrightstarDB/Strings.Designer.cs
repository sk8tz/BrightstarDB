﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrightstarDB {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BrightstarDB.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string must not be NULL..
        /// </summary>
        internal static string BrightstarConnectionString_MustMotBeNull {
            get {
                return ResourceManager.GetString("BrightstarConnectionString_MustMotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string must not be an empty string..
        /// </summary>
        internal static string BrightstarConnectionString_MustNotBeEmpty {
            get {
                return ResourceManager.GetString("BrightstarConnectionString_MustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection type &apos;{0}&apos; is unsupported from BrightstarDB 1.5 onwards..
        /// </summary>
        internal static string BrightstarConnectionString_ObsoleteType {
            get {
                return ResourceManager.GetString("BrightstarConnectionString_ObsoleteType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commit point must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_CommitPointMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_CommitPointMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export file name must not be an empty string..
        /// </summary>
        internal static string BrightstarServiceClient_ExportFileNameMustNotBeEmptyString {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_ExportFileNameMustNotBeEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export file name must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_ExportFileNameMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_ExportFileNameMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested number of commit points exceeds maximum value of 100..
        /// </summary>
        internal static string BrightstarServiceClient_GetCommitPoints_TakeToLarge {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_GetCommitPoints_TakeToLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested number of job records exceeds the maximum of 100..
        /// </summary>
        internal static string BrightstarServiceClient_GetJobInfo_TakeToLarge {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_GetJobInfo_TakeToLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested number of statistics records exceeds the maximum value of 100..
        /// </summary>
        internal static string BrightstarServiceClient_GetStatistics_TakeTooLarge {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_GetStatistics_TakeTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested number of transaction records exceeds the maximum of 100..
        /// </summary>
        internal static string BrightstarServiceClient_GetTransactions_TakeTooLarge {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_GetTransactions_TakeTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import file name must not be an empty string..
        /// </summary>
        internal static string BrightstarServiceClient_ImportFileNameMustNotBeEmptyString {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_ImportFileNameMustNotBeEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import file name must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_ImportFileNameMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_ImportFileNameMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid commit point info object.
        /// </summary>
        internal static string BrightstarServiceClient_InvalidCommitPointInfoObject {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_InvalidCommitPointInfoObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid date range. Ensure that the latest date is later than or the same as the earliest date..
        /// </summary>
        internal static string BrightstarServiceClient_InvalidDateRange {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_InvalidDateRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid store name. Store name may only include letters, digits or the following punctuation characters: -_.+,().
        /// </summary>
        internal static string BrightstarServiceClient_InvalidStoreName {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_InvalidStoreName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid transaction info object.
        /// </summary>
        internal static string BrightstarServiceClient_InvalidTransactionInfoObject {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_InvalidTransactionInfoObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job Id must not be an empty string..
        /// </summary>
        internal static string BrightstarServiceClient_JobIdMustNotBeEmptyString {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_JobIdMustNotBeEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job Id must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_JobIdMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_JobIdMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the connection string configuration information. Please check that the application configuration file contains the required appSettings elements..
        /// </summary>
        internal static string BrightstarServiceClient_NoConnectionStringConfiguration {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_NoConnectionStringConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default graph URI must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_QueryDefaultGraphUriMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_QueryDefaultGraphUriMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression must not be an empty string..
        /// </summary>
        internal static string BrightstarServiceClient_QueryMustNotBeEmptyString {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_QueryMustNotBeEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_QueryMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_QueryMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip value must be a non-negative integer..
        /// </summary>
        internal static string BrightstarServiceClient_SkipMustNotBeNegative {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_SkipMustNotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The store &apos;{0}&apos; does not exist or cannot be accessed..
        /// </summary>
        internal static string BrightstarServiceClient_StoreDoesNotExist {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_StoreDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot save changes to a read-only store..
        /// </summary>
        internal static string BrightstarServiceClient_StoreIsReadOnly {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_StoreIsReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store name conflicts with the name of an existing store..
        /// </summary>
        internal static string BrightstarServiceClient_StoreNameConflict {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_StoreNameConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store name must not be an empty string..
        /// </summary>
        internal static string BrightstarServiceClient_StoreNameMustNotBeEmptyString {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_StoreNameMustNotBeEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store name must not be NULL..
        /// </summary>
        internal static string BrightstarServiceClient_StoreNameMustNotBeNull {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_StoreNameMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requestd page size must be greater than zero..
        /// </summary>
        internal static string BrightstarServiceClient_TakeMustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_TakeMustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server provided unexpected content in response to the service request..
        /// </summary>
        internal static string BrightstarServiceClient_UnexpectedResponseContent {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_UnexpectedResponseContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SPARQL Update expression must not be null or an empty string..
        /// </summary>
        internal static string BrightstarServiceClient_UpdateExpressionMustNotBeEmptyString {
            get {
                return ResourceManager.GetString("BrightstarServiceClient_UpdateExpressionMustNotBeEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception was raised by the DotNetRDF storage server. See Inner Exception for details..
        /// </summary>
        internal static string DotNetRdf_ErrorFromUnderlyingServer {
            get {
                return ResourceManager.GetString("DotNetRdf_ErrorFromUnderlyingServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configured item must be a DotNetRDF IStorageProvider instance..
        /// </summary>
        internal static string DotNetRdf_NotAStorageProvider {
            get {
                return ResourceManager.GetString("DotNetRdf_NotAStorageProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store creation failed. No further information is available. Please check your storage server configuration and permissions..
        /// </summary>
        internal static string DotNetRdf_StoreCreationFailed {
            get {
                return ResourceManager.GetString("DotNetRdf_StoreCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The storage provider for this store does not provide the methods required to clear the store data..
        /// </summary>
        internal static string DotNetRdf_StoreDoesNotSupportDelete {
            get {
                return ResourceManager.GetString("DotNetRdf_StoreDoesNotSupportDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The storage provider for this store does not support SPARQL query..
        /// </summary>
        internal static string DotNetRdf_StoreMustImplementIQueryableStorage {
            get {
                return ResourceManager.GetString("DotNetRdf_StoreMustImplementIQueryableStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation is not supported by the DotNetRDF storage server..
        /// </summary>
        internal static string DotNetRdf_UnsupportedByServer {
            get {
                return ResourceManager.GetString("DotNetRdf_UnsupportedByServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument provided was not of or assignable to the expected type &apos;{0}&apos;.
        /// </summary>
        internal static string EntityFramework_InvalidEntityType {
            get {
                return ResourceManager.GetString("EntityFramework_InvalidEntityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; of type &apos;{1}&apos; cannot be used as an identity property. An identity property must be a read-only System.String property. If this property is intended to be the identity property for the entity, please change it to a read-only System.String property. If it is not intended to be the identity property for the entity, please add the [ResourceAddress] attribute to the property which is intended to be the identity property for the entity..
        /// </summary>
        internal static string EntityFramework_InvalidPropertyMessage {
            get {
                return ResourceManager.GetString("EntityFramework_InvalidPropertyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to write to a fixed page..
        /// </summary>
        internal static string INode_Attempt_to_write_to_a_fixed_page {
            get {
                return ResourceManager.GetString("INode_Attempt_to_write_to_a_fixed_page", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity is not a valid URI nor CURIE with regards to the current namespace mappings..
        /// </summary>
        internal static string InvalidDataObjectIdentity {
            get {
                return ResourceManager.GetString("InvalidDataObjectIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value provided must be an instance of the type {0} or of a type derived from it..
        /// </summary>
        internal static string InvalidEntityType {
            get {
                return ResourceManager.GetString("InvalidEntityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request does not use HTTP(S).
        /// </summary>
        internal static string NotAnHttpRequest {
            get {
                return ResourceManager.GetString("NotAnHttpRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must be a non-empty, non-null string..
        /// </summary>
        internal static string StringParameterMustBeNonEmpty {
            get {
                return ResourceManager.GetString("StringParameterMustBeNonEmpty", resourceCulture);
            }
        }
    }
}
