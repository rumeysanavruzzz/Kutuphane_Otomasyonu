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
	/// Instance class encapsulating : Server[@Name='']/Database/AsymmetricKey
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class AsymmetricKey  : ISfcSupportsDesignMode, IObjectPermission
	{
		public AsymmetricKey() : base(){ }
		public AsymmetricKey(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = database;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
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
							case "ID": return 0;
							case "KeyEncryptionAlgorithm": return 1;
							case "KeyLength": return 2;
							case "Owner": return 3;
							case "PrivateKeyEncryptionType": return 4;
							case "PublicKey": return 5;
							case "Sid": return 6;
							case "Thumbprint": return 7;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "ID": return 0;
							case "KeyEncryptionAlgorithm": return 1;
							case "KeyLength": return 2;
							case "Owner": return 3;
							case "PrivateKeyEncryptionType": return 4;
							case "PublicKey": return 5;
							case "Sid": return 6;
							case "Thumbprint": return 7;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ID": return 0;
						case "KeyEncryptionAlgorithm": return 1;
						case "KeyLength": return 2;
						case "Owner": return 3;
						case "PrivateKeyEncryptionType": return 4;
						case "PublicKey": return 5;
						case "Sid": return 6;
						case "Thumbprint": return 7;
						case "PolicyHealthState": return 8;
						case "ProviderName": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 8, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
			static int [] cloudVersionCount = new int [] { 0, 0, 8 };
			static int sqlDwPropertyCount = 8;
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
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("KeyEncryptionAlgorithm", false, true, typeof(Microsoft.SqlServer.Management.Smo.AsymmetricKeyEncryptionAlgorithm)),
				new StaticMetadata("KeyLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("PrivateKeyEncryptionType", false, true, typeof(Microsoft.SqlServer.Management.Smo.PrivateKeyEncryptionType)),
				new StaticMetadata("PublicKey", false, true, typeof(System.Byte[])),
				new StaticMetadata("Sid", false, true, typeof(System.Byte[])),
				new StaticMetadata("Thumbprint", false, true, typeof(System.Byte[])),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("KeyEncryptionAlgorithm", false, true, typeof(Microsoft.SqlServer.Management.Smo.AsymmetricKeyEncryptionAlgorithm)),
				new StaticMetadata("KeyLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("PrivateKeyEncryptionType", false, true, typeof(Microsoft.SqlServer.Management.Smo.PrivateKeyEncryptionType)),
				new StaticMetadata("PublicKey", false, true, typeof(System.Byte[])),
				new StaticMetadata("Sid", false, true, typeof(System.Byte[])),
				new StaticMetadata("Thumbprint", false, true, typeof(System.Byte[])),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("KeyEncryptionAlgorithm", false, true, typeof(Microsoft.SqlServer.Management.Smo.AsymmetricKeyEncryptionAlgorithm)),
				new StaticMetadata("KeyLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("PrivateKeyEncryptionType", false, true, typeof(Microsoft.SqlServer.Management.Smo.PrivateKeyEncryptionType)),
				new StaticMetadata("PublicKey", false, true, typeof(System.Byte[])),
				new StaticMetadata("Sid", false, true, typeof(System.Byte[])),
				new StaticMetadata("Thumbprint", false, true, typeof(System.Byte[])),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("ProviderName", false, false, typeof(System.String)),
			};
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
		public Microsoft.SqlServer.Management.Smo.AsymmetricKeyEncryptionAlgorithm KeyEncryptionAlgorithm
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AsymmetricKeyEncryptionAlgorithm)this.Properties.GetValueWithNullReplacement("KeyEncryptionAlgorithm");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 KeyLength
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("KeyLength");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
		[SfcReference(typeof(DatabaseRole),"Server[@Name = '{0}']/Database[@Name = '{1}']/Role[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
		[SfcReference(typeof(ApplicationRole),"Server[@Name = '{0}']/Database[@Name = '{1}']/ApplicationRole[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
		[CLSCompliant(false)]
		public System.String Owner
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Owner");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Owner", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.PrivateKeyEncryptionType PrivateKeyEncryptionType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.PrivateKeyEncryptionType)this.Properties.GetValueWithNullReplacement("PrivateKeyEncryptionType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(CryptographicProvider),"Server[@Name = '{0}']/CryptographicProvider[@Name = '{1}']","Parent.Parent.ConnectionContext.TrueName","ProviderName")]
		[CLSCompliant(false)]
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte[] PublicKey
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("PublicKey");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte[] Sid
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("Sid");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte[] Thumbprint
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("Thumbprint");
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
