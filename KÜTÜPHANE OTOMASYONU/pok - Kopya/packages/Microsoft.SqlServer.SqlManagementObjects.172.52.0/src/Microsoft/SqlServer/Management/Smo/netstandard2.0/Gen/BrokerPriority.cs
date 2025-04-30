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

namespace Microsoft.SqlServer.Management.Smo.Broker
{
	/// <summary>
	/// Instance class encapsulating : Server[@Name='']/Database/ServiceBroker/BrokerPriority
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class BrokerPriority 
	{
		public BrokerPriority() : base(){ }
		public BrokerPriority(ServiceBroker serviceBroker, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = serviceBroker;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ServiceBroker Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ServiceBroker;
			}
			set{SetParentImpl(value);}
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
						case "ContractName": return 0;
						case "ID": return 1;
						case "LocalServiceName": return 2;
						case "PolicyHealthState": return 3;
						case "PriorityLevel": return 4;
						case "RemoteServiceName": return 5;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
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
				new StaticMetadata("ContractName", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("LocalServiceName", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("PriorityLevel", false, false, typeof(System.Byte)),
				new StaticMetadata("RemoteServiceName", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(ServiceContract),"Server[@Name = '{0}']/Database[@Name = '{1}']/ServiceBroker/ServiceContract[@Name='{2}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","ContractName")]
		[CLSCompliant(false)]
		public System.String ContractName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ContractName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ContractName", value);
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
		[SfcReference(typeof(BrokerService),"Server[@Name = '{0}']/Database[@Name = '{1}']/ServiceBroker/BrokerService[@Name='{2}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","LocalServiceName")]
		[CLSCompliant(false)]
		public System.String LocalServiceName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LocalServiceName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LocalServiceName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Byte PriorityLevel
		{
			get
			{
				return (System.Byte)this.Properties.GetValueWithNullReplacement("PriorityLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PriorityLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String RemoteServiceName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteServiceName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteServiceName", value);
			}
		}
	}
}
