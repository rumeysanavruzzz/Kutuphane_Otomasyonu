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
	/// Instance class encapsulating : Server[@Name='']/LinkedServer
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class LinkedServer  : ISfcSupportsDesignMode
	{
		public LinkedServer() : base(){ }
		public LinkedServer(Server server, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = server;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public Server Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Server;
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
						return -1;
					}
					else
					{
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "Catalog": return 0;
						case "CollationCompatible": return 1;
						case "DataAccess": return 2;
						case "DataSource": return 3;
						case "DistPublisher": return 4;
						case "Distributor": return 5;
						case "ID": return 6;
						case "Location": return 7;
						case "ProductName": return 8;
						case "ProviderName": return 9;
						case "ProviderString": return 10;
						case "Publisher": return 11;
						case "Rpc": return 12;
						case "RpcOut": return 13;
						case "Subscriber": return 14;
						case "CollationName": return 15;
						case "ConnectTimeout": return 16;
						case "LazySchemaValidation": return 17;
						case "QueryTimeout": return 18;
						case "UseRemoteCollation": return 19;
						case "DateLastModified": return 20;
						case "IsPromotionofDistributedTransactionsForRPCEnabled": return 21;
						case "PolicyHealthState": return 22;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 15, 20, 21, 23, 23, 23, 23, 23, 23, 23, 23, 23 };
			static int [] cloudVersionCount = new int [] { 0, 0, 0 };
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
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("Catalog", false, false, typeof(System.String)),
				new StaticMetadata("CollationCompatible", false, false, typeof(System.Boolean)),
				new StaticMetadata("DataAccess", false, false, typeof(System.Boolean)),
				new StaticMetadata("DataSource", false, false, typeof(System.String)),
				new StaticMetadata("DistPublisher", false, false, typeof(System.Boolean)),
				new StaticMetadata("Distributor", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Location", false, false, typeof(System.String)),
				new StaticMetadata("ProductName", false, false, typeof(System.String)),
				new StaticMetadata("ProviderName", false, false, typeof(System.String)),
				new StaticMetadata("ProviderString", false, false, typeof(Microsoft.SqlServer.Management.Smo.Internal.SqlSecureString)),
				new StaticMetadata("Publisher", false, false, typeof(System.Boolean)),
				new StaticMetadata("Rpc", false, false, typeof(System.Boolean)),
				new StaticMetadata("RpcOut", false, false, typeof(System.Boolean)),
				new StaticMetadata("Subscriber", false, false, typeof(System.Boolean)),
				new StaticMetadata("CollationName", false, false, typeof(System.String)),
				new StaticMetadata("ConnectTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("LazySchemaValidation", false, false, typeof(System.Boolean)),
				new StaticMetadata("QueryTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("UseRemoteCollation", false, false, typeof(System.Boolean)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("IsPromotionofDistributedTransactionsForRPCEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String Catalog
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Catalog");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Catalog", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean CollationCompatible
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("CollationCompatible");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CollationCompatible", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String CollationName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("CollationName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CollationName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ConnectTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ConnectTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConnectTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean DataAccess
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DataAccess");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataAccess", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String DataSource
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DataSource");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataSource", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean DistPublisher
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DistPublisher");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DistPublisher", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean Distributor
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Distributor");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Distributor", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsPromotionofDistributedTransactionsForRPCEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPromotionofDistributedTransactionsForRPCEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsPromotionofDistributedTransactionsForRPCEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean LazySchemaValidation
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("LazySchemaValidation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LazySchemaValidation", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String ProductName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ProductName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ProductName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String ProviderName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ProviderName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ProviderName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean Publisher
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Publisher");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Publisher", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 QueryTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("QueryTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QueryTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean Rpc
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Rpc");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Rpc", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean RpcOut
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("RpcOut");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RpcOut", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean Subscriber
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Subscriber");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Subscriber", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean UseRemoteCollation
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("UseRemoteCollation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UseRemoteCollation", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "Catalog", "DataSource", "Location", "ProductName", "ProviderName", "ProviderString" };
		}
	}
}
