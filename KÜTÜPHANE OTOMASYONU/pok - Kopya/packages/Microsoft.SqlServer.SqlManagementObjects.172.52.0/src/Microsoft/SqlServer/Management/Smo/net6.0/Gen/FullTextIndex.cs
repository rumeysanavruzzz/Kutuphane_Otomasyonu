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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/FullTextIndex
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class FullTextIndex  : ISfcSupportsDesignMode
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "CatalogName": return 0;
							case "ChangeTracking": return 1;
							case "DocumentsProcessed": return 2;
							case "FilegroupName": return 3;
							case "IsEnabled": return 4;
							case "ItemCount": return 5;
							case "NumberOfFailures": return 6;
							case "PendingChanges": return 7;
							case "PopulationStatus": return 8;
							case "SearchPropertyListName": return 9;
							case "StopListName": return 10;
							case "StopListOption": return 11;
							case "UniqueIndexName": return 12;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "CatalogName": return 0;
						case "ChangeTracking": return 1;
						case "IsEnabled": return 2;
						case "PopulationStatus": return 3;
						case "UniqueIndexName": return 4;
						case "DocumentsProcessed": return 5;
						case "ItemCount": return 6;
						case "NumberOfFailures": return 7;
						case "PendingChanges": return 8;
						case "FilegroupName": return 9;
						case "PolicyHealthState": return 10;
						case "StopListName": return 11;
						case "StopListOption": return 12;
						case "SearchPropertyListName": return 13;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 5, 5, 9, 13, 13, 14, 14, 14, 14, 14, 14, 14 };
			static int [] cloudVersionCount = new int [] { 0, 0, 13 };
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
				new StaticMetadata("CatalogName", false, false, typeof(System.String)),
				new StaticMetadata("ChangeTracking", false, false, typeof(Microsoft.SqlServer.Management.Smo.ChangeTracking)),
				new StaticMetadata("DocumentsProcessed", false, true, typeof(System.Int32)),
				new StaticMetadata("FilegroupName", false, false, typeof(System.String)),
				new StaticMetadata("IsEnabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("ItemCount", false, true, typeof(System.Int32)),
				new StaticMetadata("NumberOfFailures", false, true, typeof(System.Int32)),
				new StaticMetadata("PendingChanges", false, true, typeof(System.Int32)),
				new StaticMetadata("PopulationStatus", false, true, typeof(Microsoft.SqlServer.Management.Smo.IndexPopulationStatus)),
				new StaticMetadata("SearchPropertyListName", false, false, typeof(System.String)),
				new StaticMetadata("StopListName", false, false, typeof(System.String)),
				new StaticMetadata("StopListOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.StopListOption)),
				new StaticMetadata("UniqueIndexName", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("CatalogName", false, false, typeof(System.String)),
				new StaticMetadata("ChangeTracking", false, false, typeof(Microsoft.SqlServer.Management.Smo.ChangeTracking)),
				new StaticMetadata("IsEnabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("PopulationStatus", false, true, typeof(Microsoft.SqlServer.Management.Smo.IndexPopulationStatus)),
				new StaticMetadata("UniqueIndexName", false, false, typeof(System.String)),
				new StaticMetadata("DocumentsProcessed", false, true, typeof(System.Int32)),
				new StaticMetadata("ItemCount", false, true, typeof(System.Int32)),
				new StaticMetadata("NumberOfFailures", false, true, typeof(System.Int32)),
				new StaticMetadata("PendingChanges", false, true, typeof(System.Int32)),
				new StaticMetadata("FilegroupName", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("StopListName", false, false, typeof(System.String)),
				new StaticMetadata("StopListOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.StopListOption)),
				new StaticMetadata("SearchPropertyListName", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String CatalogName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("CatalogName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CatalogName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ChangeTracking ChangeTracking
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ChangeTracking)this.Properties.GetValueWithNullReplacement("ChangeTracking");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ChangeTracking", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 DocumentsProcessed
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("DocumentsProcessed");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FilegroupName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FilegroupName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FilegroupName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEnabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ItemCount
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ItemCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumberOfFailures
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumberOfFailures");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 PendingChanges
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PendingChanges");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.IndexPopulationStatus PopulationStatus
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.IndexPopulationStatus)this.Properties.GetValueWithNullReplacement("PopulationStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SearchPropertyListName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SearchPropertyListName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SearchPropertyListName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String StopListName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("StopListName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StopListName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.StopListOption StopListOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.StopListOption)this.Properties.GetValueWithNullReplacement("StopListOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StopListOption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String UniqueIndexName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("UniqueIndexName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UniqueIndexName", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "CatalogName", "FilegroupName", "UniqueIndexName" };
		}
	}
}
