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
	/// Instance class encapsulating : Server[@Name='']/AvailabilityGroup/AvailabilityReplica
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class AvailabilityReplica 
	{
		public AvailabilityReplica() : base(){ }
		public AvailabilityReplica(AvailabilityGroup availabilityGroup, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = availabilityGroup;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public AvailabilityGroup Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as AvailabilityGroup;
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
						case "AvailabilityMode": return 0;
						case "BackupPriority": return 1;
						case "ConnectionModeInPrimaryRole": return 2;
						case "ConnectionModeInSecondaryRole": return 3;
						case "ConnectionState": return 4;
						case "CreateDate": return 5;
						case "DateLastModified": return 6;
						case "EndpointUrl": return 7;
						case "FailoverMode": return 8;
						case "JoinState": return 9;
						case "LastConnectErrorDescription": return 10;
						case "LastConnectErrorNumber": return 11;
						case "LastConnectErrorTimestamp": return 12;
						case "MemberState": return 13;
						case "OperationalState": return 14;
						case "Owner": return 15;
						case "PolicyHealthState": return 16;
						case "QuorumVoteCount": return 17;
						case "ReadonlyRoutingConnectionUrl": return 18;
						case "ReadonlyRoutingListDelimited": return 19;
						case "Role": return 20;
						case "RollupRecoveryState": return 21;
						case "RollupSynchronizationState": return 22;
						case "SessionTimeout": return 23;
						case "UniqueId": return 24;
						case "SeedingMode": return 25;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 25, 25, 26, 26, 26, 26, 26 };
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
				new StaticMetadata("AvailabilityMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaAvailabilityMode)),
				new StaticMetadata("BackupPriority", false, false, typeof(System.Int32)),
				new StaticMetadata("ConnectionModeInPrimaryRole", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionModeInPrimaryRole)),
				new StaticMetadata("ConnectionModeInSecondaryRole", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionModeInSecondaryRole)),
				new StaticMetadata("ConnectionState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionState)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("EndpointUrl", false, false, typeof(System.String)),
				new StaticMetadata("FailoverMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaFailoverMode)),
				new StaticMetadata("JoinState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaJoinState)),
				new StaticMetadata("LastConnectErrorDescription", false, true, typeof(System.String)),
				new StaticMetadata("LastConnectErrorNumber", false, true, typeof(System.Int32)),
				new StaticMetadata("LastConnectErrorTimestamp", false, true, typeof(System.DateTime)),
				new StaticMetadata("MemberState", true, true, typeof(Microsoft.SqlServer.Management.Smo.ClusterMemberState)),
				new StaticMetadata("OperationalState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaOperationalState)),
				new StaticMetadata("Owner", false, true, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("QuorumVoteCount", true, true, typeof(System.Int32)),
				new StaticMetadata("ReadonlyRoutingConnectionUrl", false, false, typeof(System.String)),
				new StaticMetadata("ReadonlyRoutingListDelimited", false, true, typeof(System.String)),
				new StaticMetadata("Role", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole)),
				new StaticMetadata("RollupRecoveryState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRollupRecoveryState)),
				new StaticMetadata("RollupSynchronizationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRollupSynchronizationState)),
				new StaticMetadata("SessionTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("UniqueId", false, true, typeof(System.Guid)),
				new StaticMetadata("SeedingMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaSeedingMode)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaAvailabilityMode AvailabilityMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaAvailabilityMode)this.Properties.GetValueWithNullReplacement("AvailabilityMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AvailabilityMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 BackupPriority
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("BackupPriority");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BackupPriority", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionModeInPrimaryRole ConnectionModeInPrimaryRole
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionModeInPrimaryRole)this.Properties.GetValueWithNullReplacement("ConnectionModeInPrimaryRole");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConnectionModeInPrimaryRole", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionModeInSecondaryRole ConnectionModeInSecondaryRole
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionModeInSecondaryRole)this.Properties.GetValueWithNullReplacement("ConnectionModeInSecondaryRole");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConnectionModeInSecondaryRole", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionState ConnectionState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaConnectionState)this.Properties.GetValueWithNullReplacement("ConnectionState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
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
		public System.String EndpointUrl
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EndpointUrl");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EndpointUrl", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaFailoverMode FailoverMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaFailoverMode)this.Properties.GetValueWithNullReplacement("FailoverMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FailoverMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaJoinState JoinState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaJoinState)this.Properties.GetValueWithNullReplacement("JoinState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String LastConnectErrorDescription
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LastConnectErrorDescription");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 LastConnectErrorNumber
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("LastConnectErrorNumber");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastConnectErrorTimestamp
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastConnectErrorTimestamp");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ClusterMemberState MemberState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ClusterMemberState)this.Properties.GetValueWithNullReplacement("MemberState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaOperationalState OperationalState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaOperationalState)this.Properties.GetValueWithNullReplacement("OperationalState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Owner
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Owner");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 QuorumVoteCount
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("QuorumVoteCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ReadonlyRoutingConnectionUrl
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReadonlyRoutingConnectionUrl");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReadonlyRoutingConnectionUrl", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole Role
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole)this.Properties.GetValueWithNullReplacement("Role");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRollupRecoveryState RollupRecoveryState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRollupRecoveryState)this.Properties.GetValueWithNullReplacement("RollupRecoveryState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRollupSynchronizationState RollupSynchronizationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRollupSynchronizationState)this.Properties.GetValueWithNullReplacement("RollupSynchronizationState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaSeedingMode SeedingMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaSeedingMode)this.Properties.GetValueWithNullReplacement("SeedingMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SeedingMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 SessionTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("SessionTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SessionTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Guid UniqueId
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("UniqueId");
			}
		}
	}
}
