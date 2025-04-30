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
	/// Instance class encapsulating : Server[@Name='']/FullTextService
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class FullTextService 
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AllowUnsignedBinaries": return 0;
							case "CatalogUpgradeOption": return 1;
							case "ConnectTimeout": return 2;
							case "DataTimeout": return 3;
							case "DefaultPath": return 4;
							case "LoadOSResourcesEnabled": return 5;
							case "ResourceUsage": return 6;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ConnectTimeout": return 0;
						case "DefaultPath": return 1;
						case "ResourceUsage": return 2;
						case "DataTimeout": return 3;
						case "AllowUnsignedBinaries": return 4;
						case "LoadOSResourcesEnabled": return 5;
						case "CatalogUpgradeOption": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 3, 4, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
			static int [] cloudVersionCount = new int [] { 0, 0, 7 };
			static int sqlDwPropertyCount = 0;
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
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AllowUnsignedBinaries", false, false, typeof(System.Boolean)),
				new StaticMetadata("CatalogUpgradeOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.FullTextCatalogUpgradeOption)),
				new StaticMetadata("ConnectTimeout", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("DataTimeout", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("DefaultPath", false, true, typeof(System.String)),
				new StaticMetadata("LoadOSResourcesEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ResourceUsage", false, false, typeof(Microsoft.SqlServer.Management.Smo.ResourceUsage)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ConnectTimeout", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("DefaultPath", false, true, typeof(System.String)),
				new StaticMetadata("ResourceUsage", false, false, typeof(Microsoft.SqlServer.Management.Smo.ResourceUsage)),
				new StaticMetadata("DataTimeout", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("AllowUnsignedBinaries", false, false, typeof(System.Boolean)),
				new StaticMetadata("LoadOSResourcesEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("CatalogUpgradeOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.FullTextCatalogUpgradeOption)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AllowUnsignedBinaries
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AllowUnsignedBinaries");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AllowUnsignedBinaries", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.FullTextCatalogUpgradeOption CatalogUpgradeOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.FullTextCatalogUpgradeOption)this.Properties.GetValueWithNullReplacement("CatalogUpgradeOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CatalogUpgradeOption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.TimeSpan ConnectTimeout
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("ConnectTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConnectTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.TimeSpan DataTimeout
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("DataTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DefaultPath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultPath");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean LoadOSResourcesEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("LoadOSResourcesEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LoadOSResourcesEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ResourceUsage ResourceUsage
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ResourceUsage)this.Properties.GetValueWithNullReplacement("ResourceUsage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ResourceUsage", value);
			}
		}
	}
}
