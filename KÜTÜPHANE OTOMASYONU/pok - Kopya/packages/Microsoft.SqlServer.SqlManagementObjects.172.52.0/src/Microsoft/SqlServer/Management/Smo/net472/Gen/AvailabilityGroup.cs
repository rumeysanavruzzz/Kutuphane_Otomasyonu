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
	/// Instance class encapsulating : Server[@Name='']/AvailabilityGroup
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class AvailabilityGroup  : IObjectPermission
	{
		public AvailabilityGroup() : base(){ }
		public AvailabilityGroup(Server server, string name) : base()
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
		/// This object supports permissions.
		/// </summary>
		internal override UserPermissionCollection Permissions
		{
			get
			{
				// call the base class 
				return GetUserPermissions();
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
						case "AutomatedBackupPreference": return 0;
						case "FailureConditionLevel": return 1;
						case "HealthCheckTimeout": return 2;
						case "ID": return 3;
						case "IsManagedInstanceLink": return 4;
						case "LocalReplicaRole": return 5;
						case "PolicyHealthState": return 6;
						case "PrimaryReplicaServerName": return 7;
						case "UniqueId": return 8;
						case "BasicAvailabilityGroup": return 9;
						case "DatabaseHealthTrigger": return 10;
						case "DtcSupportEnabled": return 11;
						case "IsDistributedAvailabilityGroup": return 12;
						case "ClusterType": return 13;
						case "RequiredSynchronizedSecondariesToCommit": return 14;
						case "IsContained": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 9, 9, 13, 15, 15, 16, 16 };
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
				new StaticMetadata("AutomatedBackupPreference", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityGroupAutomatedBackupPreference)),
				new StaticMetadata("FailureConditionLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityGroupFailureConditionLevel)),
				new StaticMetadata("HealthCheckTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsManagedInstanceLink", true, true, typeof(System.Boolean)),
				new StaticMetadata("LocalReplicaRole", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("PrimaryReplicaServerName", false, true, typeof(System.String)),
				new StaticMetadata("UniqueId", false, true, typeof(System.Guid)),
				new StaticMetadata("BasicAvailabilityGroup", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseHealthTrigger", false, false, typeof(System.Boolean)),
				new StaticMetadata("DtcSupportEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDistributedAvailabilityGroup", false, false, typeof(System.Boolean)),
				new StaticMetadata("ClusterType", false, false, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityGroupClusterType)),
				new StaticMetadata("RequiredSynchronizedSecondariesToCommit", false, false, typeof(System.Int32)),
				new StaticMetadata("IsContained", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityGroupAutomatedBackupPreference AutomatedBackupPreference
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityGroupAutomatedBackupPreference)this.Properties.GetValueWithNullReplacement("AutomatedBackupPreference");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutomatedBackupPreference", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean BasicAvailabilityGroup
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("BasicAvailabilityGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BasicAvailabilityGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityGroupClusterType ClusterType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityGroupClusterType)this.Properties.GetValueWithNullReplacement("ClusterType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ClusterType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean DatabaseHealthTrigger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DatabaseHealthTrigger");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DatabaseHealthTrigger", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean DtcSupportEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DtcSupportEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DtcSupportEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityGroupFailureConditionLevel FailureConditionLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityGroupFailureConditionLevel)this.Properties.GetValueWithNullReplacement("FailureConditionLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FailureConditionLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 HealthCheckTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("HealthCheckTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HealthCheckTimeout", value);
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsContained
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsContained");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsContained", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsDistributedAvailabilityGroup
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDistributedAvailabilityGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsDistributedAvailabilityGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsManagedInstanceLink
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsManagedInstanceLink");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole LocalReplicaRole
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityReplicaRole)this.Properties.GetValueWithNullReplacement("LocalReplicaRole");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String PrimaryReplicaServerName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PrimaryReplicaServerName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 RequiredSynchronizedSecondariesToCommit
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("RequiredSynchronizedSecondariesToCommit");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequiredSynchronizedSecondariesToCommit", value);
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
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "IsContained" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "BasicAvailabilityGroup":
					return false;
				case "DatabaseHealthTrigger":
					return false;
				case "DtcSupportEnabled":
					return false;
				case "IsContained":
					return false;
				case "IsDistributedAvailabilityGroup":
					return false;
				case "IsManagedInstanceLink":
					return false;
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}

		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, asRole);
		}
		

		public void Deny(ObjectPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String granteeName, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, asRole);
		}
		

		public ObjectPermissionInfo[] EnumObjectPermissions()
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, null, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, granteeName, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, null, permissions);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName, ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, granteeName, permissions);
		}
		
	}



}
