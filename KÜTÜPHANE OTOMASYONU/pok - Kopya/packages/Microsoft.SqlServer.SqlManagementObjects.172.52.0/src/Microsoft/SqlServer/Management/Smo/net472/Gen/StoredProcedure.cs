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
	/// Instance class encapsulating : Server[@Name='']/Database/StoredProcedure
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class StoredProcedure  : ISfcSupportsDesignMode, IObjectPermission
	{
		public StoredProcedure() : base(){ }
		public StoredProcedure(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, null);
			this.Parent = database;
		}
		public StoredProcedure(Database database, string name, string schema) : base()
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
						switch(propertyName)
						{
							case "AnsiNullsStatus": return 0;
							case "AssemblyName": return 1;
							case "BodyStartIndex": return 2;
							case "ClassName": return 3;
							case "CreateDate": return 4;
							case "DateLastModified": return 5;
							case "ExecutionContext": return 6;
							case "ExecutionContextPrincipal": return 7;
							case "ForReplication": return 8;
							case "ID": return 9;
							case "ImplementationType": return 10;
							case "IsEncrypted": return 11;
							case "IsNativelyCompiled": return 12;
							case "IsSchemaBound": return 13;
							case "IsSchemaOwned": return 14;
							case "IsSystemObject": return 15;
							case "MethodName": return 16;
							case "Owner": return 17;
							case "QuotedIdentifierStatus": return 18;
							case "Recompile": return 19;
							case "Startup": return 20;
							case "Text": return 21;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiNullsStatus": return 0;
							case "AssemblyName": return 1;
							case "BodyStartIndex": return 2;
							case "ClassName": return 3;
							case "CreateDate": return 4;
							case "DateLastModified": return 5;
							case "ExecutionContext": return 6;
							case "ExecutionContextPrincipal": return 7;
							case "ForReplication": return 8;
							case "ID": return 9;
							case "ImplementationType": return 10;
							case "IsEncrypted": return 11;
							case "IsNativelyCompiled": return 12;
							case "IsSchemaBound": return 13;
							case "IsSchemaOwned": return 14;
							case "IsSystemObject": return 15;
							case "MethodName": return 16;
							case "Owner": return 17;
							case "QuotedIdentifierStatus": return 18;
							case "Recompile": return 19;
							case "Startup": return 20;
							case "Text": return 21;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AnsiNullsStatus": return 0;
						case "BodyStartIndex": return 1;
						case "CreateDate": return 2;
						case "ForReplication": return 3;
						case "ID": return 4;
						case "ImplementationType": return 5;
						case "IsEncrypted": return 6;
						case "IsSchemaBound": return 7;
						case "IsSystemObject": return 8;
						case "Owner": return 9;
						case "QuotedIdentifierStatus": return 10;
						case "Recompile": return 11;
						case "Startup": return 12;
						case "Text": return 13;
						case "AssemblyName": return 14;
						case "ClassName": return 15;
						case "DateLastModified": return 16;
						case "ExecutionContext": return 17;
						case "ExecutionContextPrincipal": return 18;
						case "IsSchemaOwned": return 19;
						case "MethodName": return 20;
						case "PolicyHealthState": return 21;
						case "IsNativelyCompiled": return 22;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 14, 14, 21, 22, 22, 22, 23, 23, 23, 23, 23, 23 };
			static int [] cloudVersionCount = new int [] { 0, 0, 22 };
			static int sqlDwPropertyCount = 22;
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
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("ForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Recompile", false, false, typeof(System.Boolean)),
				new StaticMetadata("Startup", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("ForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Recompile", false, false, typeof(System.Boolean)),
				new StaticMetadata("Startup", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("ForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Recompile", false, false, typeof(System.Boolean)),
				new StaticMetadata("Startup", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AnsiNullsStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullsStatus");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullsStatus", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
			}
		}
		[DmfIgnoreProperty]
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExecutionContext ExecutionContext
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExecutionContext)this.Properties.GetValueWithNullReplacement("ExecutionContext");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContext", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","ExecutionContextPrincipal")]
		[CLSCompliant(false)]
		public System.String ExecutionContextPrincipal
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ExecutionContextPrincipal");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContextPrincipal", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ForReplication
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ForReplication");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ForReplication", value);
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "TransactSql")]
		public Microsoft.SqlServer.Management.Smo.ImplementationType ImplementationType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ImplementationType)this.Properties.GetValueWithNullReplacement("ImplementationType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ImplementationType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsEncrypted
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEncrypted");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsEncrypted", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsNativelyCompiled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsNativelyCompiled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsNativelyCompiled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSchemaBound
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSchemaBound");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSchemaBound", value);
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
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String MethodName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MethodName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MethodName", value);
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean QuotedIdentifierStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("QuotedIdentifierStatus");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QuotedIdentifierStatus", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Recompile
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Recompile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Recompile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Startup
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Startup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Startup", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "ForReplication", "IsNativelyCompiled" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "ImplementationType":
					return ImplementationType.TransactSql;
				case "IsEncrypted":
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
		

      private StoredProcedureEvents events;
      public StoredProcedureEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new StoredProcedureEvents(this);
              }
              return this.events;
          }
      }
    
	}




      public class StoredProcedureEvents
      {
      internal StoredProcedureEvents(StoredProcedure parent)
      {
          this.parent = parent;
      }

      public StoredProcedureEventSet GetEventSelection()
      {
          InitializeEvents();
          return (StoredProcedureEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(StoredProcedureEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(StoredProcedureEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(StoredProcedureEventSet events)
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
              serverEventsWorker = new StoredProcedureEventsWorker(parent);

          }
      }

      private StoredProcedureEventsWorker serverEventsWorker;
      private StoredProcedure parent;
      }
    
}
