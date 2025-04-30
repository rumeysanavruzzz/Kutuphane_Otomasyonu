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
	/// Instance class encapsulating : Server[@Name='']/Information
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Information 
	{
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
							case "IsCaseSensitive": return 7;
							case "IsFullTextInstalled": return 8;
							case "IsSingleUser": return 9;
							case "IsXTPSupported": return 10;
							case "MaxPrecision": return 11;
							case "PathSeparator": return 12;
							case "ProductLevel": return 13;
							case "ResourceLastUpdateDateTime": return 14;
							case "ResourceVersionString": return 15;
							case "SqlCharSet": return 16;
							case "SqlCharSetName": return 17;
							case "SqlSortOrder": return 18;
							case "SqlSortOrderName": return 19;
							case "VersionMajor": return 20;
							case "VersionMinor": return 21;
							case "VersionString": return 22;
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
							case "IsCaseSensitive": return 6;
							case "IsSingleUser": return 7;
							case "IsXTPSupported": return 8;
							case "MaxPrecision": return 9;
							case "ProductLevel": return 10;
							case "ResourceLastUpdateDateTime": return 11;
							case "ResourceVersionString": return 12;
							case "SqlCharSet": return 13;
							case "SqlCharSetName": return 14;
							case "SqlSortOrder": return 15;
							case "SqlSortOrderName": return 16;
							case "VersionMajor": return 17;
							case "VersionMinor": return 18;
							case "VersionString": return 19;
							case "HostPlatform": return 20;
							case "PathSeparator": return 21;
							case "IsFullTextInstalled": return 22;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "BuildNumber": return 0;
						case "Edition": return 1;
						case "ErrorLogPath": return 2;
						case "HasNullSaPassword": return 3;
						case "HostPlatform": return 4;
						case "IsCaseSensitive": return 5;
						case "IsFullTextInstalled": return 6;
						case "IsXTPSupported": return 7;
						case "Language": return 8;
						case "MasterDBLogPath": return 9;
						case "MasterDBPath": return 10;
						case "MaxPrecision": return 11;
						case "NetName": return 12;
						case "OSVersion": return 13;
						case "PathSeparator": return 14;
						case "PhysicalMemory": return 15;
						case "Platform": return 16;
						case "Processors": return 17;
						case "Product": return 18;
						case "RootDirectory": return 19;
						case "VersionMajor": return 20;
						case "VersionMinor": return 21;
						case "VersionString": return 22;
						case "Collation": return 23;
						case "EngineEdition": return 24;
						case "IsClustered": return 25;
						case "IsSingleUser": return 26;
						case "ProductLevel": return 27;
						case "BuildClrVersionString": return 28;
						case "CollationID": return 29;
						case "ComparisonStyle": return 30;
						case "ComputerNamePhysicalNetBIOS": return 31;
						case "ResourceLastUpdateDateTime": return 32;
						case "ResourceVersionString": return 33;
						case "SqlCharSet": return 34;
						case "SqlCharSetName": return 35;
						case "SqlSortOrder": return 36;
						case "SqlSortOrderName": return 37;
						case "FullyQualifiedNetName": return 38;
						case "IsHadrEnabled": return 39;
						case "IsPolyBaseInstalled": return 40;
						case "HostDistribution": return 41;
						case "HostRelease": return 42;
						case "HostServicePackLevel": return 43;
						case "HostSku": return 44;
						case "HardwareGeneration": return 45;
						case "ReservedStorageSizeMB": return 46;
						case "ServiceTier": return 47;
						case "UsedStorageSizeMB": return 48;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 23, 28, 38, 38, 38, 40, 40, 41, 45, 49, 49, 49 };
			static int [] cloudVersionCount = new int [] { 20, 22, 23 };
			static int sqlDwPropertyCount = 23;
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
				new StaticMetadata("EngineEdition", false, true, typeof(System.Int32)),
				new StaticMetadata("HostPlatform", false, true, typeof(System.String)),
				new StaticMetadata("IsCaseSensitive", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextInstalled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSingleUser", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXTPSupported", true, true, typeof(System.Boolean)),
				new StaticMetadata("MaxPrecision", false, true, typeof(System.Byte)),
				new StaticMetadata("PathSeparator", false, true, typeof(System.String)),
				new StaticMetadata("ProductLevel", false, true, typeof(System.String)),
				new StaticMetadata("ResourceLastUpdateDateTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("ResourceVersionString", false, true, typeof(System.String)),
				new StaticMetadata("SqlCharSet", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlCharSetName", false, true, typeof(System.String)),
				new StaticMetadata("SqlSortOrder", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlSortOrderName", false, true, typeof(System.String)),
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
				new StaticMetadata("EngineEdition", false, true, typeof(System.Int32)),
				new StaticMetadata("IsCaseSensitive", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSingleUser", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXTPSupported", true, true, typeof(System.Boolean)),
				new StaticMetadata("MaxPrecision", false, true, typeof(System.Byte)),
				new StaticMetadata("ProductLevel", false, true, typeof(System.String)),
				new StaticMetadata("ResourceLastUpdateDateTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("ResourceVersionString", false, true, typeof(System.String)),
				new StaticMetadata("SqlCharSet", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlCharSetName", false, true, typeof(System.String)),
				new StaticMetadata("SqlSortOrder", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlSortOrderName", false, true, typeof(System.String)),
				new StaticMetadata("VersionMajor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionMinor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionString", false, true, typeof(System.String)),
				new StaticMetadata("HostPlatform", false, true, typeof(System.String)),
				new StaticMetadata("PathSeparator", false, true, typeof(System.String)),
				new StaticMetadata("IsFullTextInstalled", false, true, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("BuildNumber", true, true, typeof(System.Int32)),
				new StaticMetadata("Edition", false, true, typeof(System.String)),
				new StaticMetadata("ErrorLogPath", false, true, typeof(System.String)),
				new StaticMetadata("HasNullSaPassword", true, true, typeof(System.Boolean)),
				new StaticMetadata("HostPlatform", true, true, typeof(System.String)),
				new StaticMetadata("IsCaseSensitive", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextInstalled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXTPSupported", true, true, typeof(System.Boolean)),
				new StaticMetadata("Language", true, true, typeof(System.String)),
				new StaticMetadata("MasterDBLogPath", false, true, typeof(System.String)),
				new StaticMetadata("MasterDBPath", false, true, typeof(System.String)),
				new StaticMetadata("MaxPrecision", false, true, typeof(System.Byte)),
				new StaticMetadata("NetName", true, true, typeof(System.String)),
				new StaticMetadata("OSVersion", true, true, typeof(System.String)),
				new StaticMetadata("PathSeparator", false, true, typeof(System.String)),
				new StaticMetadata("PhysicalMemory", true, true, typeof(System.Int32)),
				new StaticMetadata("Platform", true, true, typeof(System.String)),
				new StaticMetadata("Processors", true, true, typeof(System.Int32)),
				new StaticMetadata("Product", true, true, typeof(System.String)),
				new StaticMetadata("RootDirectory", false, true, typeof(System.String)),
				new StaticMetadata("VersionMajor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionMinor", true, true, typeof(System.Int32)),
				new StaticMetadata("VersionString", true, true, typeof(System.String)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("EngineEdition", false, true, typeof(System.Int32)),
				new StaticMetadata("IsClustered", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSingleUser", false, true, typeof(System.Boolean)),
				new StaticMetadata("ProductLevel", false, true, typeof(System.String)),
				new StaticMetadata("BuildClrVersionString", false, true, typeof(System.String)),
				new StaticMetadata("CollationID", false, true, typeof(System.Int32)),
				new StaticMetadata("ComparisonStyle", false, true, typeof(System.Int32)),
				new StaticMetadata("ComputerNamePhysicalNetBIOS", false, true, typeof(System.String)),
				new StaticMetadata("ResourceLastUpdateDateTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("ResourceVersionString", false, true, typeof(System.String)),
				new StaticMetadata("SqlCharSet", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlCharSetName", false, true, typeof(System.String)),
				new StaticMetadata("SqlSortOrder", false, true, typeof(System.Int16)),
				new StaticMetadata("SqlSortOrderName", false, true, typeof(System.String)),
				new StaticMetadata("FullyQualifiedNetName", true, true, typeof(System.String)),
				new StaticMetadata("IsHadrEnabled", true, true, typeof(System.Boolean)),
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
		public System.String FullyQualifiedNetName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FullyQualifiedNetName");
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean IsHadrEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsHadrEnabled");
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String NetName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("NetName");
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 PhysicalMemory
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PhysicalMemory");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String VersionString
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("VersionString");
			}
		}
	}
}
