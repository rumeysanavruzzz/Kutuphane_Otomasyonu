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
	/// Instance class encapsulating : Server[@Name='']/AvailabilityGroup/DatabaseReplicaState
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class DatabaseReplicaState 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public AvailabilityGroup Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as AvailabilityGroup;
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
						case "AvailabilityDatabaseName": return 0;
						case "AvailabilityDateabaseId": return 1;
						case "AvailabilityGroupId": return 2;
						case "AvailabilityGroupName": return 3;
						case "AvailabilityReplicaId": return 4;
						case "AvailabilityReplicaServerName": return 5;
						case "DatabaseId": return 6;
						case "EndOfLogLSN": return 7;
						case "EstimatedDataLoss": return 8;
						case "EstimatedRecoveryTime": return 9;
						case "FileStreamSendRate": return 10;
						case "IsFailoverReady": return 11;
						case "IsJoined": return 12;
						case "IsLocal": return 13;
						case "IsSuspended": return 14;
						case "LastCommitLSN": return 15;
						case "LastCommitTime": return 16;
						case "LastHardenedLSN": return 17;
						case "LastHardenedTime": return 18;
						case "LastReceivedLSN": return 19;
						case "LastReceivedTime": return 20;
						case "LastRedoneLSN": return 21;
						case "LastRedoneTime": return 22;
						case "LastSentLSN": return 23;
						case "LastSentTime": return 24;
						case "LogSendQueueSize": return 25;
						case "LogSendRate": return 26;
						case "PolicyHealthState": return 27;
						case "RecoveryLSN": return 28;
						case "RedoQueueSize": return 29;
						case "RedoRate": return 30;
						case "ReplicaAvailabilityMode": return 31;
						case "ReplicaRole": return 32;
						case "SuspendReason": return 33;
						case "SynchronizationPerformance": return 34;
						case "SynchronizationState": return 35;
						case "TruncationLSN": return 36;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 37, 37, 37, 37, 37, 37, 37 };
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
				new StaticMetadata("AvailabilityDatabaseName", false, true, typeof(System.String)),
				new StaticMetadata("AvailabilityDateabaseId", false, true, typeof(System.Guid)),
				new StaticMetadata("AvailabilityGroupId", false, true, typeof(System.Guid)),
				new StaticMetadata("AvailabilityGroupName", false, true, typeof(System.String)),
				new StaticMetadata("AvailabilityReplicaId", false, true, typeof(System.Guid)),
				new StaticMetadata("AvailabilityReplicaServerName", false, true, typeof(System.String)),
				new StaticMetadata("DatabaseId", false, true, typeof(System.Int32)),
				new StaticMetadata("EndOfLogLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("EstimatedDataLoss", false, true, typeof(System.Int32)),
				new StaticMetadata("EstimatedRecoveryTime", false, true, typeof(System.Double)),
				new StaticMetadata("FileStreamSendRate", false, true, typeof(System.Int64)),
				new StaticMetadata("IsFailoverReady", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsJoined", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsLocal", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSuspended", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastCommitLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("LastCommitTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastHardenedLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("LastHardenedTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastReceivedLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("LastReceivedTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastRedoneLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("LastRedoneTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastSentLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("LastSentTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LogSendQueueSize", false, true, typeof(System.Int64)),
				new StaticMetadata("LogSendRate", false, true, typeof(System.Int64)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("RecoveryLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("RedoQueueSize", false, true, typeof(System.Int64)),
				new StaticMetadata("RedoRate", false, true, typeof(System.Int64)),
				new StaticMetadata("ReplicaAvailabilityMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaAvailabilityMode)),
				new StaticMetadata("ReplicaRole", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole)),
				new StaticMetadata("SuspendReason", false, true, typeof(Microsoft.SqlServer.Management.Smo.DatabaseReplicaSuspendReason)),
				new StaticMetadata("SynchronizationPerformance", false, true, typeof(System.Double)),
				new StaticMetadata("SynchronizationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState)),
				new StaticMetadata("TruncationLSN", false, true, typeof(System.Decimal)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Guid AvailabilityDateabaseId
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("AvailabilityDateabaseId");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Guid AvailabilityGroupId
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("AvailabilityGroupId");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String AvailabilityGroupName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AvailabilityGroupName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Guid AvailabilityReplicaId
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("AvailabilityReplicaId");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 DatabaseId
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("DatabaseId");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal EndOfLogLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("EndOfLogLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 EstimatedDataLoss
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("EstimatedDataLoss");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Double EstimatedRecoveryTime
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("EstimatedRecoveryTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int64 FileStreamSendRate
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("FileStreamSendRate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsFailoverReady
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFailoverReady");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsJoined
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsJoined");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsLocal
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsLocal");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSuspended
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSuspended");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal LastCommitLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("LastCommitLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastCommitTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastCommitTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal LastHardenedLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("LastHardenedLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastHardenedTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastHardenedTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal LastReceivedLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("LastReceivedLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastReceivedTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastReceivedTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal LastRedoneLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("LastRedoneLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastRedoneTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastRedoneTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal LastSentLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("LastSentLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastSentTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastSentTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int64 LogSendQueueSize
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("LogSendQueueSize");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int64 LogSendRate
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("LogSendRate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal RecoveryLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("RecoveryLSN");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int64 RedoQueueSize
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("RedoQueueSize");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int64 RedoRate
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("RedoRate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaAvailabilityMode ReplicaAvailabilityMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaAvailabilityMode)this.Properties.GetValueWithNullReplacement("ReplicaAvailabilityMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReplicaAvailabilityMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole ReplicaRole
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole)this.Properties.GetValueWithNullReplacement("ReplicaRole");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseReplicaSuspendReason SuspendReason
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseReplicaSuspendReason)this.Properties.GetValueWithNullReplacement("SuspendReason");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Double SynchronizationPerformance
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("SynchronizationPerformance");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState SynchronizationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState)this.Properties.GetValueWithNullReplacement("SynchronizationState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Decimal TruncationLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("TruncationLSN");
			}
		}
	}
}
