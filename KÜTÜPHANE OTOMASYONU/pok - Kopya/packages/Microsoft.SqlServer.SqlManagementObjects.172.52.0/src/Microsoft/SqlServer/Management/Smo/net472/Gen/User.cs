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
	/// Instance class encapsulating : Server[@Name='']/Database/User
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class User  : ISfcSupportsDesignMode, IObjectPermission
	{
		public User() : base(){ }
		public User(Database database, string name) : base()
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
							case "AuthenticationType": return 0;
							case "Certificate": return 1;
							case "CreateDate": return 2;
							case "DateLastModified": return 3;
							case "DefaultSchema": return 4;
							case "HasDBAccess": return 5;
							case "ID": return 6;
							case "IsSystemObject": return 7;
							case "Login": return 8;
							case "LoginType": return 9;
							case "Sid": return 10;
							case "UserType": return 11;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "CreateDate": return 0;
							case "DateLastModified": return 1;
							case "DefaultSchema": return 2;
							case "HasDBAccess": return 3;
							case "ID": return 4;
							case "IsSystemObject": return 5;
							case "Login": return 6;
							case "LoginType": return 7;
							case "Sid": return 8;
							case "AsymmetricKey": return 9;
							case "AuthenticationType": return 10;
							case "Certificate": return 11;
							case "UserType": return 12;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "CreateDate": return 0;
						case "DateLastModified": return 1;
						case "HasDBAccess": return 2;
						case "ID": return 3;
						case "IsSystemObject": return 4;
						case "Login": return 5;
						case "LoginType": return 6;
						case "Sid": return 7;
						case "UserType": return 8;
						case "AsymmetricKey": return 9;
						case "AuthenticationType": return 10;
						case "Certificate": return 11;
						case "DefaultSchema": return 12;
						case "PolicyHealthState": return 13;
						case "DefaultLanguageLcid": return 14;
						case "DefaultLanguageName": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 9, 9, 13, 14, 14, 16, 16, 16, 16, 16, 16, 16 };
			static int [] cloudVersionCount = new int [] { 9, 9, 13 };
			static int sqlDwPropertyCount = 12;
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
				new StaticMetadata("AuthenticationType", false, true, typeof(Microsoft.SqlServer.Management.Smo.AuthenticationType)),
				new StaticMetadata("Certificate", false, false, typeof(System.String)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DefaultSchema", false, false, typeof(System.String)),
				new StaticMetadata("HasDBAccess", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Login", true, false, typeof(System.String)),
				new StaticMetadata("LoginType", false, true, typeof(Microsoft.SqlServer.Management.Smo.LoginType)),
				new StaticMetadata("Sid", false, true, typeof(System.Byte[])),
				new StaticMetadata("UserType", false, false, typeof(Microsoft.SqlServer.Management.Smo.UserType)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DefaultSchema", false, false, typeof(System.String)),
				new StaticMetadata("HasDBAccess", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Login", true, false, typeof(System.String)),
				new StaticMetadata("LoginType", false, true, typeof(Microsoft.SqlServer.Management.Smo.LoginType)),
				new StaticMetadata("Sid", false, true, typeof(System.Byte[])),
				new StaticMetadata("AsymmetricKey", false, false, typeof(System.String)),
				new StaticMetadata("AuthenticationType", false, true, typeof(Microsoft.SqlServer.Management.Smo.AuthenticationType)),
				new StaticMetadata("Certificate", false, false, typeof(System.String)),
				new StaticMetadata("UserType", false, false, typeof(Microsoft.SqlServer.Management.Smo.UserType)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("HasDBAccess", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Login", false, false, typeof(System.String)),
				new StaticMetadata("LoginType", false, true, typeof(Microsoft.SqlServer.Management.Smo.LoginType)),
				new StaticMetadata("Sid", false, true, typeof(System.Byte[])),
				new StaticMetadata("UserType", false, false, typeof(Microsoft.SqlServer.Management.Smo.UserType)),
				new StaticMetadata("AsymmetricKey", false, false, typeof(System.String)),
				new StaticMetadata("AuthenticationType", false, true, typeof(Microsoft.SqlServer.Management.Smo.AuthenticationType)),
				new StaticMetadata("Certificate", false, false, typeof(System.String)),
				new StaticMetadata("DefaultSchema", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("DefaultLanguageLcid", false, false, typeof(System.Int32)),
				new StaticMetadata("DefaultLanguageName", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(AsymmetricKey),"Server[@Name = '{0}']/Database[@Name = '{1}']/AsymmetricKey[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","AsymmetricKey")]
		[CLSCompliant(false)]
		public System.String AsymmetricKey
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AsymmetricKey");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AsymmetricKey", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AuthenticationType AuthenticationType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AuthenticationType)this.Properties.GetValueWithNullReplacement("AuthenticationType");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Certificate),"Server[@Name = '{0}']/Database[@Name = '{1}']/Certificate[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Certificate")]
		[CLSCompliant(false)]
		public System.String Certificate
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Certificate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Certificate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Schema),"Server[@Name = '{0}']/Database[@Name = '{1}']/Schema[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","DefaultSchema")]
		[CLSCompliant(false)]
		public System.String DefaultSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultSchema", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasDBAccess
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasDBAccess");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Login),"Server[@Name = '{0}']/Login[@Name = '{1}']","Parent.Parent.ConnectionContext.TrueName","Login")]
		[CLSCompliant(false)]
		public System.String Login
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Login");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Login", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.LoginType LoginType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.LoginType)this.Properties.GetValueWithNullReplacement("LoginType");
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.UserType UserType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.UserType)this.Properties.GetValueWithNullReplacement("UserType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UserType", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "AsymmetricKey", "Certificate", "Login", "UserType" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "IsSystemObject":
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
		

		public Urn[] EnumOwnedObjects()
		{
			return PermissionWorker.EnumOwnedObjects(this);
		}
		

      private UserEvents events;
      public UserEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new UserEvents(this);
              }
              return this.events;
          }
      }
    
	}





      public class UserEvents
      {
      internal UserEvents(User parent)
      {
          this.parent = parent;
      }

      public ObjectEventSet GetEventSelection()
      {
          InitializeEvents();
          return (ObjectEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(ObjectEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(ObjectEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(ObjectEventSet events)
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.UnsubscribeFromEvents(events);
          }
      }

      public void UnsubscribeAllEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.Dispose();
              this.serverEventsWorker = null;
          }
      }

      public void StartEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StartEvents();
          }
      }

      public void StopEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StopEvents();
          }
      }

      public event ServerEventHandler ServerEvent
      {
          add
          {
              InitializeEvents();
              this.serverEventsWorker.AddDefaultEventHandler(value);
          }

          remove
          {
              if (null != this.serverEventsWorker)
              {
                  this.serverEventsWorker.RemoveDefaultEventHandler(value);
              }
          }
      }

      private void InitializeEvents()
      {
          if (null == serverEventsWorker)
          {
              serverEventsWorker = new ObjectEventsWorker(parent);

          }
      }

      private ObjectEventsWorker serverEventsWorker;
      private User parent;
      }
    
}
