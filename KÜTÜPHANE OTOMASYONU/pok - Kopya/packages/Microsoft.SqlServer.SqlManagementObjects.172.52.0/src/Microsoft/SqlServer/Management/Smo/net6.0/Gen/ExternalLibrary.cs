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
	/// Instance class encapsulating : Server[@Name='']/Database/ExternalLibrary
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class ExternalLibrary  : ISfcSupportsDesignMode
	{
		public ExternalLibrary() : base(){ }
		public ExternalLibrary(Database database, string name) : base()
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
						case "ExternalLibraryLanguage": return 0;
						case "ID": return 1;
						case "Owner": return 2;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 3 };
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
				new StaticMetadata("ExternalLibraryLanguage", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ExternalLibraryLanguage
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ExternalLibraryLanguage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExternalLibraryLanguage", value);
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
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
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
