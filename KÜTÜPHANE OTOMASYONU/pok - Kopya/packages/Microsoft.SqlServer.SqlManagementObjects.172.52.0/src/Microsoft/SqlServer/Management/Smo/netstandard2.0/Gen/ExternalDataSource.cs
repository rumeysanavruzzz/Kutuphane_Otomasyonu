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
	/// Instance class encapsulating : Server[@Name='']/Database/ExternalDataSource
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class ExternalDataSource  : ISfcSupportsDesignMode
	{
		public ExternalDataSource() : base(){ }
		public ExternalDataSource(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = database;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		public Database Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Database;
			}
			set{SetParentImpl(value);}
		}
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
							case "Credential": return 0;
							case "DataSourceType": return 1;
							case "ID": return 2;
							case "Location": return 3;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "Credential": return 0;
							case "DatabaseName": return 1;
							case "DataSourceType": return 2;
							case "ID": return 3;
							case "Location": return 4;
							case "ShardMapName": return 5;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "Credential": return 0;
						case "DataSourceType": return 1;
						case "ID": return 2;
						case "Location": return 3;
						case "ResourceManagerLocation": return 4;
						case "ConnectionOptions": return 5;
						case "PushdownOption": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 5, 5, 7, 7, 7 };
			static int [] cloudVersionCount = new int [] { 0, 0, 6 };
			static int sqlDwPropertyCount = 4;
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
				new StaticMetadata("Credential", false, false, typeof(System.String)),
				new StaticMetadata("DataSourceType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalDataSourceType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Location", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("Credential", false, false, typeof(System.String)),
				new StaticMetadata("DatabaseName", false, false, typeof(System.String)),
				new StaticMetadata("DataSourceType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalDataSourceType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Location", false, false, typeof(System.String)),
				new StaticMetadata("ShardMapName", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("Credential", false, false, typeof(System.String)),
				new StaticMetadata("DataSourceType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalDataSourceType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Location", false, false, typeof(System.String)),
				new StaticMetadata("ResourceManagerLocation", false, false, typeof(System.String)),
				new StaticMetadata("ConnectionOptions", false, false, typeof(System.String)),
				new StaticMetadata("PushdownOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalDataSourcePushdownOption)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ConnectionOptions
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ConnectionOptions");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConnectionOptions", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Credential),"Server[@Name = '{0}']/Database[@Name = '{1}']/Credential[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Credential")]
		[CLSCompliant(false)]
		public System.String Credential
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Credential");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Credential", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalDataSourceType DataSourceType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalDataSourceType)this.Properties.GetValueWithNullReplacement("DataSourceType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataSourceType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Location
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Location");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Location", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalDataSourcePushdownOption PushdownOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalDataSourcePushdownOption)this.Properties.GetValueWithNullReplacement("PushdownOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PushdownOption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ResourceManagerLocation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ResourceManagerLocation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ResourceManagerLocation", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.String DatabaseName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DatabaseName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DatabaseName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.String ShardMapName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ShardMapName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ShardMapName", value);
			}
		}
	}
}
