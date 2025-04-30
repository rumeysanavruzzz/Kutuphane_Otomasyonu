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
	/// Instance class encapsulating : Server[@Name='']/AvailabilityGroup/AvailabilityDatabase
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class AvailabilityDatabase 
	{
		public AvailabilityDatabase() : base(){ }
		public AvailabilityDatabase(AvailabilityGroup availabilityGroup, string name) : base()
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
						case "IsFailoverReady": return 0;
						case "IsJoined": return 1;
						case "IsPendingSecondarySuspend": return 2;
						case "IsSuspended": return 3;
						case "PolicyHealthState": return 4;
						case "RecoveryLSN": return 5;
						case "SynchronizationState": return 6;
						case "TruncationLSN": return 7;
						case "UniqueId": return 8;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 9, 9, 9, 9, 9, 9, 9 };
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
				new StaticMetadata("IsFailoverReady", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsJoined", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsPendingSecondarySuspend", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSuspended", false, true, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("RecoveryLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("SynchronizationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState)),
				new StaticMetadata("TruncationLSN", false, true, typeof(System.Decimal)),
				new StaticMetadata("UniqueId", false, true, typeof(System.Guid)),
			};
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
		public System.Boolean IsPendingSecondarySuspend
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPendingSecondarySuspend");
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
		public System.Decimal RecoveryLSN
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("RecoveryLSN");
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
