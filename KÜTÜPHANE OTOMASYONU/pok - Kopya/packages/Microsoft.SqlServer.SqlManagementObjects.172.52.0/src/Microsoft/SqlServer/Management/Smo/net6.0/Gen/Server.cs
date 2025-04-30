/*
**** This file has been automatically generated. Do not attempt to modify manually! ****
*/
/*
**** The generated file is compatible with SFC attribute (metadata) requirement ****
*/
using System;
using System.Collections;
using System.Net;
using Microsoft.SqlServer.Management.Sdk.Sfc.Metadata;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Common;

namespace Microsoft.SqlServer.Management.Smo
{
	/// <summary>
	/// Instance class encapsulating : Server[@Name='']
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Server  : ISfcSupportsDesignMode
	{
		/// <summary>
		/// This object extend ISfcSupportsDesignMode.
		/// </summary>
		bool ISfcSupportsDesignMode.IsDesignMode
		{
			get
			{
				// call the base class 
				return IsDesignMode;
			}
		}
		internal override SqlPropertyMetadataProvider GetPropertyMetadataProvider()
		{
			return new PropertyMetadataProvider(this.ServerVersion,this.DatabaseEngineType, this.DatabaseEngineEdition);
		}
		internal class PropertyMetadataProvider : SqlPropertyMetadataProvider
		{
			internal PropertyMetadataProvider(Common.ServerVersion version,DatabaseEngineType databaseEngineType, DatabaseEngineEdition databaseEngineEdition) : base(version,databaseEngineType, databaseEngineEdition)
			{
			}
			public override int PropertyNameToIDLookup(string propertyName)
			{
				if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						switch(propertyName)
						{
							case "BuildNumber": return 0;
							case "Collation": return 1;
							case "CollationID": return 2;
							case "ComparisonStyle": return 3;
							case "Edition": return 4;
							case "EngineEdition": return 5;
							case "HostPlatform": return 6;
							case "InstanceName": return 7;
							case "IsCaseSensitive": return 8;
							case "IsContainedAuthentication": return 9;
							case "IsJsonDataTypeEnabled": return 10;
							case "IsSingleUser": return 11;
							case "IsXTPSupported": return 12;
							case "MaxPrecision": return 13;
							case "PathSeparator": return 14;
							case "ProductLevel": return 15;
							case "ProductUpdateLevel": return 16;
							case "ResourceLastUpdateDateTime": return 17;
							case "ResourceVersionString": return 18;
							case "ServerType": return 19;
							case "SqlCharSet": return 20;
							case "SqlCharSetName": return 21;
							case "SqlSortOrder": return 22;
							case "SqlSortOrderName": return 23;
							case "Status": return 24;
							case "VersionMajor": return 25;
							case "VersionMinor": return 26;
							case "VersionString": return 27;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "BuildNumber": return 0;
							case "Collation": return 1;
							case "CollationID": return 2;
							case "ComparisonStyle": return 3;
							case "Edition": return 4;
							case "EngineEdition": return 5;
							case "InstanceName": return 6;
							case "IsCaseSensitive": return 7;
							case "IsContainedAuthentication": return 8;
							case "IsSingleUser": return 9;
							case "IsXTPSupported": return 10;
							case "MaxPrecision": return 11;
							case "ProductLevel": return 12;
							case "ProductUpdateLevel": return 13;
							case "ResourceLastUpdateDateTime": return 14;
							case "ResourceVersionString": return 15;
							case "ServerType": return 16;
							case "SqlCharSet": return 17;
							case "SqlCharSetName": return 18;
							case "SqlSortOrder": return 19;
							case "SqlSortOrderName": return 20;
							case "Status": return 21;
							case "VersionMajor": return 22;
							case "VersionMinor": return 23;
							case "VersionString": return 24;
							case "HostPlatform": return 25;
							case "PathSeparator": return 26;
							case "IsFullTextInstalled": return 27;
							case "IsJsonDataTypeEnabled": return 28;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AuditLevel": return 0;
						case "BackupDirectory": return 1;
						case "BuildNumber": return 2;
						case "DefaultFile": return 3;
						case "DefaultLog": return 4;
						case "ErrorLogPath": return 5;
						case "HasNullSaPassword": return 6;
						case "HostPlatform": return 7;
						case "InstallDataDirectory": return 8;
						case "IsCaseSensitive": return 9;
						case "IsContainedAuthentication": return 10;
						case "IsFullTextInstalled": return 11;
						case "IsJsonDataTypeEnabled": return 12;
						case "IsXTPSupported": return 13;
						case "Language": return 14;
						case "LoginMode": return 15;
						case "MailProfile": return 16;
						case "MasterDBLogPath": return 17;
						case "MasterDBPath": return 18;
						case "MaxPrecision": return 19;
						case "NumberOfLogFiles": return 20;
						case "OSVersion": return 21;
						case "PathSeparator": return 22;
						case "PerfMonMode": return 23;
						case "PhysicalMemory": return 24;
						case "Platform": return 25;
						case "Processors": return 26;
						case "Product": return 27;
						case "RootDirectory": return 28;
						case "ServerType": return 29;
						case "ServiceName": return 30;
						case "VersionMajor": return 31;
						case "VersionMinor": return 32;
						case "Collation": return 33;
						case "Edition": return 34;
						case "EngineEdition": return 35;
						case "InstanceName": return 36;
						case "IsClustered": return 37;
						case "IsSingleUser": return 38;
						case "NetName": return 39;
						case "ProductLevel": return 40;
						case "ProductUpdateLevel": return 41;
						case "Status": return 42;
						case "TapeLoadWaitTime": return 43;
						case "VersionString": return 44;
						case "BrowserServiceAccount": return 45;
						case "BrowserStartMode": return 46;
						case "BuildClrVersionString": return 47;
						case "CollationID": return 48;
						case "ComparisonStyle": return 49;
						case "ComputerNamePhysicalNetBIOS": return 50;
						case "InstallSharedDirectory": return 51;
						case "NamedPipesEnabled": return 52;
						case "ResourceLastUpdateDateTime": return 53;
						case "ResourceVersionString": return 54;
						case "ServiceAccount": return 55;
						case "ServiceInstanceId": return 56;
						case "ServiceStartMode": return 57;
						case "SqlCharSet": return 58;
						case "SqlCharSetName": return 59;
						case "SqlSortOrder": return 60;
						case "SqlSortOrderName": return 61;
						case "TcpEnabled": return 62;
						case "FilestreamLevel": return 63;
						case "FilestreamShareName": return 64;
						case "PhysicalMemoryUsageInKB": return 65;
						case "PolicyHealthState": return 66;
						case "SqlDomainGroup": return 67;
						case "ProcessorUsage": return 68;
						case "ClusterName": return 69;
						case "ClusterQuorumState": return 70;
						case "ClusterQuorumType": return 71;
						case "ErrorLogSizeKb": return 72;
						case "HadrManagerStatus": return 73;
						case "IsHadrEnabled": return 74;
						case "ServiceAccountSid": return 75;
						case "IsPolyBaseInstalled": return 76;
						case "HostDistribution": return 77;
						case "HostRelease": return 78;
						case "HostServicePackLevel": return 79;
						case "HostSku": return 80;
						case "HardwareGeneration": return 81;
						case "ReservedStorageSizeMB": return 82;
						case "ServiceTier": return 83;
						case "UsedStorageSizeMB": return 84;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 33, 45, 63, 68, 69, 76, 76, 77, 81, 85, 85, 85 };
			static int [] cloudVersionCount = new int [] { 25, 27, 29 };
			static int sqlDwPropertyCount = 28;
			public override int Count
			{
				get
				{
					if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
					{
						if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
						{
							return sqlDwPropertyCount;
						}
						else
						{
							int index = (currentVersionIndex < cloudVersionCount.Length) ? currentVersionIndex : cloudVersionCount.Length - 1;
							return cloudVersionCount[index];
						}
					}
					 else 
					{
						int index = (currentVersionIndex < versionCount.Length) ? currentVersionIndex : versionCount.Length - 1;
						return versionCount[index];
					}
				}
			}
			protected override int[] VersionCount
			{
				get
				{
					if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
					{
						if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
						{
							 return new int[] { sqlDwPropertyCount }; 
						}
						else
						{
							 return cloudVersionCount; 
						}
					}
					 else 
					{
						 return versionCount;  
					}
				}
			}
			new internal static int[] GetVersionArray(DatabaseEngineType databaseEngineType, DatabaseEngineEdition databaseEngineEdition)
			{
				if(databaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(databaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						 return new int[] { sqlDwPropertyCount }; 
					}
					else
					{
						 return cloudVersionCount; 
					}
				}
				 else 
				{
					 return versionCount;  
				}
			}
			public override StaticMetadata GetStaticMetadata(int id)
			{
				if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						 return sqlDwStaticMetadata[id]; 
					}
					else
					{
						 return cloudStaticMetadata[id]; 
					}
				}
				 else 
				{
					return staticMetadata[id];
				}
			}
			new internal static StaticMetadata[] GetStaticMetadataArray(DatabaseEngineType databaseEngineType, DatabaseEngineEdition databaseEngineEdition)
			{
				if(databaseEngineType == DatabaseEngineType.SqlAzureDatabase)
				{
					if(databaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
					{
						 return sqlDwStaticMetadata; 
					}
					else
					{
						 return cloudStaticMetadata;
					}
				}
				 else 
				{
					return staticMetadata;
				}
			}
			internal static StaticMetadata [] sqlDwStaticMetadata = 
			{
				new StaticMetadata("BuildNumber", true, true, typeof(System.Int32)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("CollationID", false, true, typeof(System.Int32)),
				new StaticMetadata("ComparisonStyle", false, true, typeof(System.Int32)),
				new StaticMetadata("Edition", false, true, typeof(System.String)),
				new StaticMetadata("EngineEdition", false, true, typeof(Microsoft.SqlServer.Management.Smo.Edition)),
				new StaticMetadata("HostPlatform", false, true, typeof(System.String)),
				new StaticMetadata("InstanceName", false, true, typeof(System.String)),
				new StaticMetadata("IsCaseSensitive", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsContainedAuthentication", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsJsonDataTypeEnabled", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsSingleUser", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXTPSupported", true, true, typeof(System.Boolean)),
				new StaticMetadata("MaxPrecision", false, true, typeof(System.Byte)),
				new StaticMetadata("PathSeparator", false, true, typeof(System.String)),
				new StaticMetadata("ProductLevel", false, true, typeof(System.String)),
				new StaticMetadata("ProductUpdateLevel", false, true, typeof(System.String)),
				new StaticMetadata("ResourceLastUpdateDateTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("ResourceVersionString", false, true, typeof(System.String)),
				new StaticMetadata("ServerType", false, true, typeof(Microsoft.SqlServer.Management.Common.DatabaseEngineType)),
				new StaticMetadata("SqlCharSet", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlCharSetName", false, true, typeof(System.String)),
				new StaticMetadata("SqlSortOrder", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlSortOrderName", false, true, typeof(System.String)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.ServerStatus)),
				new StaticMetadata("VersionMajor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionMinor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionString", false, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("BuildNumber", true, true, typeof(System.Int32)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("CollationID", false, true, typeof(System.Int32)),
				new StaticMetadata("ComparisonStyle", false, true, typeof(System.Int32)),
				new StaticMetadata("Edition", false, true, typeof(System.String)),
				new StaticMetadata("EngineEdition", false, true, typeof(Microsoft.SqlServer.Management.Smo.Edition)),
				new StaticMetadata("InstanceName", false, true, typeof(System.String)),
				new StaticMetadata("IsCaseSensitive", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsContainedAuthentication", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSingleUser", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXTPSupported", true, true, typeof(System.Boolean)),
				new StaticMetadata("MaxPrecision", false, true, typeof(System.Byte)),
				new StaticMetadata("ProductLevel", false, true, typeof(System.String)),
				new StaticMetadata("ProductUpdateLevel", false, true, typeof(System.String)),
				new StaticMetadata("ResourceLastUpdateDateTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("ResourceVersionString", false, true, typeof(System.String)),
				new StaticMetadata("ServerType", false, true, typeof(Microsoft.SqlServer.Management.Common.DatabaseEngineType)),
				new StaticMetadata("SqlCharSet", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlCharSetName", false, true, typeof(System.String)),
				new StaticMetadata("SqlSortOrder", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlSortOrderName", false, true, typeof(System.String)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.ServerStatus)),
				new StaticMetadata("VersionMajor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionMinor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionString", false, true, typeof(System.String)),
				new StaticMetadata("HostPlatform", false, true, typeof(System.String)),
				new StaticMetadata("PathSeparator", false, true, typeof(System.String)),
				new StaticMetadata("IsFullTextInstalled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsJsonDataTypeEnabled", true, true, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AuditLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.AuditLevel)),
				new StaticMetadata("BackupDirectory", false, false, typeof(System.String)),
				new StaticMetadata("BuildNumber", true, true, typeof(System.Int32)),
				new StaticMetadata("DefaultFile", false, false, typeof(System.String)),
				new StaticMetadata("DefaultLog", false, false, typeof(System.String)),
				new StaticMetadata("ErrorLogPath", false, true, typeof(System.String)),
				new StaticMetadata("HasNullSaPassword", true, true, typeof(System.Boolean)),
				new StaticMetadata("HostPlatform", true, true, typeof(System.String)),
				new StaticMetadata("InstallDataDirectory", false, true, typeof(System.String)),
				new StaticMetadata("IsCaseSensitive", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsContainedAuthentication", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextInstalled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsJsonDataTypeEnabled", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsXTPSupported", true, true, typeof(System.Boolean)),
				new StaticMetadata("Language", true, true, typeof(System.String)),
				new StaticMetadata("LoginMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.ServerLoginMode)),
				new StaticMetadata("MailProfile", false, false, typeof(System.String)),
				new StaticMetadata("MasterDBLogPath", false, true, typeof(System.String)),
				new StaticMetadata("MasterDBPath", false, true, typeof(System.String)),
				new StaticMetadata("MaxPrecision", false, true, typeof(System.Byte)),
				new StaticMetadata("NumberOfLogFiles", false, false, typeof(System.Int32)),
				new StaticMetadata("OSVersion", true, true, typeof(System.String)),
				new StaticMetadata("PathSeparator", false, true, typeof(System.String)),
				new StaticMetadata("PerfMonMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.PerfMonMode)),
				new StaticMetadata("PhysicalMemory", true, true, typeof(System.Int32)),
				new StaticMetadata("Platform", true, true, typeof(System.String)),
				new StaticMetadata("Processors", true, true, typeof(System.Int32)),
				new StaticMetadata("Product", true, true, typeof(System.String)),
				new StaticMetadata("RootDirectory", false, true, typeof(System.String)),
				new StaticMetadata("ServerType", false, true, typeof(Microsoft.SqlServer.Management.Common.DatabaseEngineType)),
				new StaticMetadata("ServiceName", false, true, typeof(System.String)),
				new StaticMetadata("VersionMajor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionMinor", true, true, typeof(System.Int32)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("Edition", false, true, typeof(System.String)),
				new StaticMetadata("EngineEdition", false, true, typeof(Microsoft.SqlServer.Management.Smo.Edition)),
				new StaticMetadata("InstanceName", false, true, typeof(System.String)),
				new StaticMetadata("IsClustered", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSingleUser", false, true, typeof(System.Boolean)),
				new StaticMetadata("NetName", false, true, typeof(System.String)),
				new StaticMetadata("ProductLevel", false, true, typeof(System.String)),
				new StaticMetadata("ProductUpdateLevel", false, true, typeof(System.String)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.ServerStatus)),
				new StaticMetadata("TapeLoadWaitTime", false, false, typeof(System.Int32)),
				new StaticMetadata("VersionString", false, true, typeof(System.String)),
				new StaticMetadata("BrowserServiceAccount", true, true, typeof(System.String)),
				new StaticMetadata("BrowserStartMode", true, true, typeof(Microsoft.SqlServer.Management.Smo.ServiceStartMode)),
				new StaticMetadata("BuildClrVersionString", false, true, typeof(System.String)),
				new StaticMetadata("CollationID", false, true, typeof(System.Int32)),
				new StaticMetadata("ComparisonStyle", false, true, typeof(System.Int32)),
				new StaticMetadata("ComputerNamePhysicalNetBIOS", false, true, typeof(System.String)),
				new StaticMetadata("InstallSharedDirectory", false, true, typeof(System.String)),
				new StaticMetadata("NamedPipesEnabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("ResourceLastUpdateDateTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("ResourceVersionString", false, true, typeof(System.String)),
				new StaticMetadata("ServiceAccount", false, true, typeof(System.String)),
				new StaticMetadata("ServiceInstanceId", true, true, typeof(System.String)),
				new StaticMetadata("ServiceStartMode", false, true, typeof(Microsoft.SqlServer.Management.Smo.ServiceStartMode)),
				new StaticMetadata("SqlCharSet", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlCharSetName", false, true, typeof(System.String)),
				new StaticMetadata("SqlSortOrder", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlSortOrderName", false, true, typeof(System.String)),
				new StaticMetadata("TcpEnabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("FilestreamLevel", false, true, typeof(Microsoft.SqlServer.Management.Smo.FileStreamEffectiveLevel)),
				new StaticMetadata("FilestreamShareName", false, true, typeof(System.String)),
				new StaticMetadata("PhysicalMemoryUsageInKB", true, true, typeof(System.Int64)),
				new StaticMetadata("PolicyHealthState", false, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("SqlDomainGroup", false, true, typeof(System.String)),
				new StaticMetadata("ProcessorUsage", true, true, typeof(System.Int32)),
				new StaticMetadata("ClusterName", false, true, typeof(System.String)),
				new StaticMetadata("ClusterQuorumState", false, true, typeof(Microsoft.SqlServer.Management.Smo.ClusterQuorumState)),
				new StaticMetadata("ClusterQuorumType", false, true, typeof(Microsoft.SqlServer.Management.Smo.ClusterQuorumType)),
				new StaticMetadata("ErrorLogSizeKb", true, false, typeof(System.Int32)),
				new StaticMetadata("HadrManagerStatus", false, true, typeof(Microsoft.SqlServer.Management.Smo.HadrManagerStatus)),
				new StaticMetadata("IsHadrEnabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("ServiceAccountSid", false, false, typeof(System.Byte[])),
				new StaticMetadata("IsPolyBaseInstalled", false, true, typeof(System.Boolean)),
				new StaticMetadata("HostDistribution", true, true, typeof(System.String)),
				new StaticMetadata("HostRelease", true, true, typeof(System.String)),
				new StaticMetadata("HostServicePackLevel", true, true, typeof(System.String)),
				new StaticMetadata("HostSku", true, true, typeof(System.Int32)),
				new StaticMetadata("HardwareGeneration", true, true, typeof(System.String)),
				new StaticMetadata("ReservedStorageSizeMB", true, true, typeof(System.Int32)),
				new StaticMetadata("ServiceTier", true, true, typeof(System.String)),
				new StaticMetadata("UsedStorageSizeMB", true, true, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AuditLevel AuditLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AuditLevel)this.Properties.GetValueWithNullReplacement("AuditLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AuditLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String BackupDirectory
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BackupDirectory");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BackupDirectory", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String BrowserServiceAccount
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BrowserServiceAccount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ServiceStartMode BrowserStartMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ServiceStartMode)this.Properties.GetValueWithNullReplacement("BrowserStartMode");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "v2.0.50727")]
		public System.String BuildClrVersionString
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BuildClrVersionString");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 BuildNumber
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("BuildNumber");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ClusterName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ClusterName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ClusterQuorumState ClusterQuorumState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ClusterQuorumState)this.Properties.GetValueWithNullReplacement("ClusterQuorumState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ClusterQuorumType ClusterQuorumType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ClusterQuorumType)this.Properties.GetValueWithNullReplacement("ClusterQuorumType");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Collation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Collation");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 CollationID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CollationID");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ComparisonStyle
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ComparisonStyle");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ComputerNamePhysicalNetBIOS
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ComputerNamePhysicalNetBIOS");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultFile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultFile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultFile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultLog
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultLog");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultLog", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Edition
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Edition");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ErrorLogPath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ErrorLogPath");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 ErrorLogSizeKb
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ErrorLogSizeKb");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ErrorLogSizeKb", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.FileStreamEffectiveLevel FilestreamLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.FileStreamEffectiveLevel)this.Properties.GetValueWithNullReplacement("FilestreamLevel");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FilestreamShareName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FilestreamShareName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.HadrManagerStatus HadrManagerStatus
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.HadrManagerStatus)this.Properties.GetValueWithNullReplacement("HadrManagerStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String HardwareGeneration
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HardwareGeneration");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String HostDistribution
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HostDistribution");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String HostPlatform
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HostPlatform");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String HostRelease
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HostRelease");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String HostServicePackLevel
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HostServicePackLevel");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 HostSku
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("HostSku");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String InstallDataDirectory
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("InstallDataDirectory");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String InstallSharedDirectory
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("InstallSharedDirectory");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String InstanceName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("InstanceName");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsCaseSensitive
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsCaseSensitive");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsClustered
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsClustered");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFullTextInstalled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFullTextInstalled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsHadrEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsHadrEnabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsJsonDataTypeEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsJsonDataTypeEnabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsPolyBaseInstalled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPolyBaseInstalled");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSingleUser
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSingleUser");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsXTPSupported
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsXTPSupported");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String Language
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Language");
			}
		}
		[DmfIgnoreProperty]
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ServerLoginMode LoginMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ServerLoginMode)this.Properties.GetValueWithNullReplacement("LoginMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LoginMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String MailProfile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MailProfile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MailProfile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String MasterDBLogPath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MasterDBLogPath");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String MasterDBPath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MasterDBPath");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte MaxPrecision
		{
			get
			{
				return (System.Byte)this.Properties.GetValueWithNullReplacement("MaxPrecision");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean NamedPipesEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NamedPipesEnabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String NetName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("NetName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 NumberOfLogFiles
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumberOfLogFiles");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NumberOfLogFiles", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String OSVersion
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OSVersion");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String PathSeparator
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PathSeparator");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.PerfMonMode PerfMonMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.PerfMonMode)this.Properties.GetValueWithNullReplacement("PerfMonMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PerfMonMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 PhysicalMemory
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PhysicalMemory");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 PhysicalMemoryUsageInKB
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("PhysicalMemoryUsageInKB");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String Platform
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Platform");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 Processors
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Processors");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 ProcessorUsage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ProcessorUsage");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String Product
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Product");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ProductLevel
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ProductLevel");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ProductUpdateLevel
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ProductUpdateLevel");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 ReservedStorageSizeMB
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ReservedStorageSizeMB");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime ResourceLastUpdateDateTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("ResourceLastUpdateDateTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "10.50.0000")]
		public System.String ResourceVersionString
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ResourceVersionString");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String RootDirectory
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RootDirectory");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Common.DatabaseEngineType ServerType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Common.DatabaseEngineType)this.Properties.GetValueWithNullReplacement("ServerType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ServiceAccount
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ServiceAccount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String ServiceInstanceId
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ServiceInstanceId");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ServiceName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ServiceName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ServiceStartMode ServiceStartMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ServiceStartMode)this.Properties.GetValueWithNullReplacement("ServiceStartMode");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String ServiceTier
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ServiceTier");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int16 SqlCharSet
		{
			get
			{
				return (System.Int16)this.Properties.GetValueWithNullReplacement("SqlCharSet");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SqlCharSetName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlCharSetName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String SqlDomainGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlDomainGroup");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int16 SqlSortOrder
		{
			get
			{
				return (System.Int16)this.Properties.GetValueWithNullReplacement("SqlSortOrder");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SqlSortOrderName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlSortOrderName");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ServerStatus Status
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ServerStatus)this.Properties.GetValueWithNullReplacement("Status");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 TapeLoadWaitTime
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TapeLoadWaitTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TapeLoadWaitTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean TcpEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("TcpEnabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 UsedStorageSizeMB
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("UsedStorageSizeMB");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 VersionMajor
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("VersionMajor");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 VersionMinor
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("VersionMinor");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String VersionString
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("VersionString");
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "ServiceAccountSid" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "BuildClrVersionString":
					return "v2.0.50727";
				case "ResourceVersionString":
					return "10.50.0000";
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}

		public void Deny(ServerPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Deny(ServerPermissionSet permission, System.String[] granteeNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, cascade, null);
		}
		
		public void Grant(ServerPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Grant(ServerPermissionSet permission, System.String[] granteeNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, null);
		}
		
		public void Grant(ServerPermissionSet permission, System.String[] granteeNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, asRole);
		}
		
		public void Revoke(ServerPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Revoke(ServerPermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(ServerPermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, asRole);
		}
		

		public void Deny(ServerPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Deny(ServerPermissionSet permission, System.String granteeName, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, cascade, null);
		}
		
		public void Grant(ServerPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Grant(ServerPermissionSet permission, System.String granteeName, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, null);
		}
		
		public void Grant(ServerPermissionSet permission, System.String granteeName, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, asRole);
		}
		
		public void Revoke(ServerPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Revoke(ServerPermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(ServerPermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, asRole);
		}
		

		public ServerPermissionInfo[] EnumServerPermissions()
		{
			return (ServerPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Server, this, null, null);
		}
		
		public ServerPermissionInfo[] EnumServerPermissions(System.String granteeName)
		{
			return (ServerPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Server, this, granteeName, null);
		}
		
		public ServerPermissionInfo[] EnumServerPermissions(ServerPermissionSet permissions)
		{
			return (ServerPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Server, this, null, permissions);
		}
		
		public ServerPermissionInfo[] EnumServerPermissions(System.String granteeName, ServerPermissionSet permissions)
		{
			return (ServerPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Server, this, granteeName, permissions);
		}
		

		public ObjectPermissionInfo[] EnumObjectPermissions()
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, null, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, granteeName, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, null, permissions);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName, ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, granteeName, permissions);
		}
		
	}




}
