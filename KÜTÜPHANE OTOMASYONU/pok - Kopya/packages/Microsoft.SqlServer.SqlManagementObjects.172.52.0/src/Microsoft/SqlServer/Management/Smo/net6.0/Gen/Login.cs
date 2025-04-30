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
	/// Instance class encapsulating : Server[@Name='']/Login
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Login  : ISfcSupportsDesignMode, IObjectPermission
	{
		public Login() : base(){ }
		public Login(Server server, string name) : base()
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
							case "CreateDate": return 0;
							case "DateLastModified": return 1;
							case "DefaultDatabase": return 2;
							case "ID": return 3;
							case "IsDisabled": return 4;
							case "IsSystemObject": return 5;
							case "Language": return 6;
							case "LanguageAlias": return 7;
							case "LoginType": return 8;
							case "PasswordExpirationEnabled": return 9;
							case "PasswordPolicyEnforced": return 10;
							case "Sid": return 11;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "CreateDate": return 0;
							case "DateLastModified": return 1;
							case "DefaultDatabase": return 2;
							case "ID": return 3;
							case "IsDisabled": return 4;
							case "IsSystemObject": return 5;
							case "Language": return 6;
							case "LanguageAlias": return 7;
							case "LoginType": return 8;
							case "PasswordExpirationEnabled": return 9;
							case "PasswordPolicyEnforced": return 10;
							case "Sid": return 11;
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
						case "DefaultDatabase": return 2;
						case "DenyWindowsLogin": return 3;
						case "HasAccess": return 4;
						case "IsSystemObject": return 5;
						case "Language": return 6;
						case "LanguageAlias": return 7;
						case "LoginType": return 8;
						case "Sid": return 9;
						case "WindowsLoginAccessType": return 10;
						case "AsymmetricKey": return 11;
						case "Certificate": return 12;
						case "Credential": return 13;
						case "ID": return 14;
						case "IsDisabled": return 15;
						case "IsLocked": return 16;
						case "IsPasswordExpired": return 17;
						case "MustChangePassword": return 18;
						case "PasswordExpirationEnabled": return 19;
						case "PasswordPolicyEnforced": return 20;
						case "PolicyHealthState": return 21;
						case "PasswordHashAlgorithm": return 22;
						case "SidHexString": return 23;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 11, 11, 21, 22, 22, 24, 24, 24, 24, 24, 24, 24 };
			static int [] cloudVersionCount = new int [] { 0, 0, 12 };
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
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DefaultDatabase", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDisabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Language", false, false, typeof(System.String)),
				new StaticMetadata("LanguageAlias", true, true, typeof(System.String)),
				new StaticMetadata("LoginType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LoginType)),
				new StaticMetadata("PasswordExpirationEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PasswordPolicyEnforced", false, false, typeof(System.Boolean)),
				new StaticMetadata("Sid", false, false, typeof(System.Byte[])),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DefaultDatabase", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDisabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Language", false, false, typeof(System.String)),
				new StaticMetadata("LanguageAlias", true, true, typeof(System.String)),
				new StaticMetadata("LoginType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LoginType)),
				new StaticMetadata("PasswordExpirationEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PasswordPolicyEnforced", false, false, typeof(System.Boolean)),
				new StaticMetadata("Sid", false, false, typeof(System.Byte[])),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DefaultDatabase", false, false, typeof(System.String)),
				new StaticMetadata("DenyWindowsLogin", false, false, typeof(System.Boolean)),
				new StaticMetadata("HasAccess", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Language", false, false, typeof(System.String)),
				new StaticMetadata("LanguageAlias", false, true, typeof(System.String)),
				new StaticMetadata("LoginType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LoginType)),
				new StaticMetadata("Sid", false, false, typeof(System.Byte[])),
				new StaticMetadata("WindowsLoginAccessType", false, true, typeof(Microsoft.SqlServer.Management.Smo.WindowsLoginAccessType)),
				new StaticMetadata("AsymmetricKey", false, false, typeof(System.String)),
				new StaticMetadata("Certificate", false, false, typeof(System.String)),
				new StaticMetadata("Credential", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDisabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsLocked", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsPasswordExpired", false, true, typeof(System.Boolean)),
				new StaticMetadata("MustChangePassword", false, true, typeof(System.Boolean)),
				new StaticMetadata("PasswordExpirationEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PasswordPolicyEnforced", false, false, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("PasswordHashAlgorithm", false, true, typeof(Microsoft.SqlServer.Management.Smo.PasswordHashAlgorithm)),
				new StaticMetadata("SidHexString", false, true, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone, "string.empty")]
		[SfcReference(typeof(AsymmetricKey),"Server[@Name = '{0}']/Database[@Name = 'master']/AsymmetricKey[@Name = '{1}']","Parent.ConnectionContext.TrueName","AsymmetricKey")]
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone, "string.empty")]
		[SfcReference(typeof(Certificate),"Server[@Name = '{0}']/Database[@Name = 'master']/Certificate[@Name = '{1}']","Parent.ConnectionContext.TrueName","Certificate")]
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
		[SfcProperty(SfcPropertyFlags.Standalone, "string.empty")]
		[SfcReference(typeof(Credential),"Server[@Name = '{0}']/Credential[@Name = '{1}']","Parent.ConnectionContext.TrueName","Credential")]
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
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "master")]
		[SfcReference(typeof(Database),"Server[@Name = '{0}']/Database[@Name = '{1}']","Parent.ConnectionContext.TrueName","DefaultDatabase")]
		[CLSCompliant(false)]
		public System.String DefaultDatabase
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultDatabase");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultDatabase", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean DenyWindowsLogin
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DenyWindowsLogin");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DenyWindowsLogin", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "true")]
		public System.Boolean HasAccess
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasAccess");
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
		public System.Boolean IsDisabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDisabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsLocked
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsLocked");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsPasswordExpired
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPasswordExpired");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Language
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Language");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Language", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LanguageAlias
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LanguageAlias");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.LoginType LoginType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.LoginType)this.Properties.GetValueWithNullReplacement("LoginType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LoginType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean MustChangePassword
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("MustChangePassword");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean PasswordExpirationEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("PasswordExpirationEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PasswordExpirationEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.PasswordHashAlgorithm PasswordHashAlgorithm
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.PasswordHashAlgorithm)this.Properties.GetValueWithNullReplacement("PasswordHashAlgorithm");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean PasswordPolicyEnforced
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("PasswordPolicyEnforced");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PasswordPolicyEnforced", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte[] Sid
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("Sid");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Sid", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.WindowsLoginAccessType WindowsLoginAccessType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.WindowsLoginAccessType)this.Properties.GetValueWithNullReplacement("WindowsLoginAccessType");
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "AsymmetricKey", "Certificate", "LoginType", "Sid" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "AsymmetricKey":
					return "string.empty";
				case "Certificate":
					return "string.empty";
				case "Credential":
					return "string.empty";
				case "DefaultDatabase":
					return "master";
				case "DenyWindowsLogin":
					return false;
				case "HasAccess":
					return true;
				case "IsDisabled":
					return false;
				case "IsLocked":
					return false;
				case "IsSystemObject":
					return false;
				case "MustChangePassword":
					return false;
				case "PasswordExpirationEnabled":
					return false;
				case "PasswordPolicyEnforced":
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
		

      private LoginEvents events;
      public LoginEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new LoginEvents(this);
              }
              return this.events;
          }
      }
    
	}




      public class LoginEvents
      {
      internal LoginEvents(Login parent)
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
      private Login parent;
      }
    
}
