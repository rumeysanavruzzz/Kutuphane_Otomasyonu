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
	/// Instance class encapsulating : Server[@Name='']/Database/UserDefinedType
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class UserDefinedType  : ISfcSupportsDesignMode, IObjectPermission
	{
		public UserDefinedType() : base(){ }
		public UserDefinedType(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, null);
			this.Parent = database;
		}
		public UserDefinedType(Database database, string name, string schema) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, schema);
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AssemblyName": return 0;
							case "BinaryTypeIdentifier": return 1;
							case "ClassName": return 2;
							case "Collation": return 3;
							case "ID": return 4;
							case "IsBinaryOrdered": return 5;
							case "IsComVisible": return 6;
							case "IsFixedLength": return 7;
							case "IsNullable": return 8;
							case "IsSchemaOwned": return 9;
							case "MaxLength": return 10;
							case "NumericPrecision": return 11;
							case "NumericScale": return 12;
							case "Owner": return 13;
							case "UserDefinedTypeFormat": return 14;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AssemblyName": return 0;
						case "BinaryTypeIdentifier": return 1;
						case "ClassName": return 2;
						case "Collation": return 3;
						case "ID": return 4;
						case "IsBinaryOrdered": return 5;
						case "IsComVisible": return 6;
						case "IsFixedLength": return 7;
						case "IsNullable": return 8;
						case "IsSchemaOwned": return 9;
						case "MaxLength": return 10;
						case "NumericPrecision": return 11;
						case "NumericScale": return 12;
						case "Owner": return 13;
						case "UserDefinedTypeFormat": return 14;
						case "PolicyHealthState": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 15, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
			static int [] cloudVersionCount = new int [] { 0, 0, 15 };
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
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BinaryTypeIdentifier", false, true, typeof(System.Byte[])),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsBinaryOrdered", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsComVisible", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFixedLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsNullable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("MaxLength", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, true, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("UserDefinedTypeFormat", false, true, typeof(Microsoft.SqlServer.Management.Smo.UserDefinedTypeFormat)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BinaryTypeIdentifier", false, true, typeof(System.Byte[])),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsBinaryOrdered", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsComVisible", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFixedLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsNullable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("MaxLength", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, true, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("UserDefinedTypeFormat", false, true, typeof(Microsoft.SqlServer.Management.Smo.UserDefinedTypeFormat)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(SqlAssembly),"Server[@Name = '{0}']/Database[@Name = '{1}']/SqlAssembly[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","AssemblyName")]
		[CLSCompliant(false)]
		public System.String AssemblyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AssemblyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AssemblyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte[] BinaryTypeIdentifier
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("BinaryTypeIdentifier");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ClassName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ClassName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ClassName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Collation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Collation");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsBinaryOrdered
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsBinaryOrdered");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsComVisible
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsComVisible");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFixedLength
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFixedLength");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsNullable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsNullable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSchemaOwned
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSchemaOwned");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 MaxLength
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaxLength");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumericPrecision
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumericPrecision");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumericScale
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumericScale");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		public Microsoft.SqlServer.Management.Smo.UserDefinedTypeFormat UserDefinedTypeFormat
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.UserDefinedTypeFormat)this.Properties.GetValueWithNullReplacement("UserDefinedTypeFormat");
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
		

      private UserDefinedTypeEvents events;
      public UserDefinedTypeEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new UserDefinedTypeEvents(this);
              }
              return this.events;
          }
      }
    
	}




      public class UserDefinedTypeEvents
      {
      internal UserDefinedTypeEvents(UserDefinedType parent)
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
      private UserDefinedType parent;
      }
    
}
