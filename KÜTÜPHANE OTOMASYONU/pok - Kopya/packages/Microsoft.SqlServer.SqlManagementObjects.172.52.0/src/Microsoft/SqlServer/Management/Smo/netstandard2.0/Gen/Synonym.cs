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
	/// Instance class encapsulating : Server[@Name='']/Database/Synonym
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Synonym  : ISfcSupportsDesignMode, IObjectPermission
	{
		public Synonym() : base(){ }
		public Synonym(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, null);
			this.Parent = database;
		}
		public Synonym(Database database, string name, string schema) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, schema);
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "BaseDatabase": return 0;
							case "BaseObject": return 1;
							case "BaseSchema": return 2;
							case "BaseType": return 3;
							case "CreateDate": return 4;
							case "DateLastModified": return 5;
							case "ID": return 6;
							case "IsSchemaOwned": return 7;
							case "Owner": return 8;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "BaseDatabase": return 0;
						case "BaseObject": return 1;
						case "BaseSchema": return 2;
						case "BaseServer": return 3;
						case "BaseType": return 4;
						case "CreateDate": return 5;
						case "DateLastModified": return 6;
						case "ID": return 7;
						case "IsSchemaOwned": return 8;
						case "Owner": return 9;
						case "PolicyHealthState": return 10;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 10, 11, 11, 11, 11, 11, 11, 11, 11, 11 };
			static int [] cloudVersionCount = new int [] { 9, 9, 9 };
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
				new StaticMetadata("BaseDatabase", false, false, typeof(System.String)),
				new StaticMetadata("BaseObject", false, false, typeof(System.String)),
				new StaticMetadata("BaseSchema", false, false, typeof(System.String)),
				new StaticMetadata("BaseType", false, true, typeof(Microsoft.SqlServer.Management.Smo.SynonymBaseType)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("BaseDatabase", false, false, typeof(System.String)),
				new StaticMetadata("BaseObject", false, false, typeof(System.String)),
				new StaticMetadata("BaseSchema", false, false, typeof(System.String)),
				new StaticMetadata("BaseServer", false, false, typeof(System.String)),
				new StaticMetadata("BaseType", false, true, typeof(Microsoft.SqlServer.Management.Smo.SynonymBaseType)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String BaseDatabase
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BaseDatabase");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BaseDatabase", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(StoredProcedure),"Server[@Name = '{0}']/Database[@Name = '{1}']/StoredProcedure[@Name='{2}' and @Schema='{3}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","BaseObject","BaseSchema")]
		[SfcReference(typeof(UserDefinedFunction),"Server[@Name = '{0}']/Database[@Name = '{1}']/UserDefinedFunction[@Name='{2}' and @Schema='{3}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","BaseObject","BaseSchema")]
		[SfcReference(typeof(View),"Server[@Name = '{0}']/Database[@Name = '{1}']/View[@Name='{2}' and @Schema='{3}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","BaseObject","BaseSchema")]
		[SfcReference(typeof(Table),"Server[@Name = '{0}']/Database[@Name = '{1}']/Table[@Name='{2}' and @Schema='{3}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","BaseObject","BaseSchema")]
		[SfcReference(typeof(UserDefinedAggregate),"Server[@Name = '{0}']/Database[@Name = '{1}']/UserDefinedAggregate[@Name='{2}' and @Schema='{3}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","BaseObject","BaseSchema")]
		[CLSCompliant(false)]
		public System.String BaseObject
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BaseObject");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BaseObject", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "dbo")]
		public System.String BaseSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BaseSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BaseSchema", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public System.String BaseServer
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BaseServer");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BaseServer", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SynonymBaseType BaseType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SynonymBaseType)this.Properties.GetValueWithNullReplacement("BaseType");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
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
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "BaseDatabase", "BaseObject", "BaseSchema", "BaseServer" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "BaseSchema":
					return "dbo";
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
		

		private void Init(Database database, System.String schema, System.String name, System.String baseServer, System.String baseDatabase, System.String baseSchema, System.String baseObject)
		{
			this.Name = name;
			this.Parent = database;
			if( null != schema )
			{
				this.ChangeSchema(schema, false);
			}
			this.BaseServer = baseServer;
			this.BaseDatabase = baseDatabase;
			this.BaseSchema = baseSchema;	
			this.BaseObject = baseObject;	
		}

		public Synonym(Database database, System.String name, System.String schema, System.String baseServer, System.String baseDatabase, System.String baseSchema, System.String baseObject)
		{
			Init(database, schema, name, baseServer, baseDatabase, baseSchema, baseObject);
		}

		public Synonym(Database database, System.String name, System.String baseServer, System.String baseDatabase, System.String baseSchema, System.String baseObject)
		{
			Init(database, null, name, baseServer, baseDatabase, baseSchema, baseObject);
		}
		

      private SynonymEvents events;
      public SynonymEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new SynonymEvents(this);
              }
              return this.events;
          }
      }
    
	}





      public class SynonymEvents
      {
      internal SynonymEvents(Synonym parent)
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
      private Synonym parent;
      }
    
}
