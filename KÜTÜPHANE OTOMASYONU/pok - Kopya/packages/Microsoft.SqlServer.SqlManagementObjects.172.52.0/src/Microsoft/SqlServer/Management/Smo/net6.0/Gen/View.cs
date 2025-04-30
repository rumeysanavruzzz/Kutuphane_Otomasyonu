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
	/// Instance class encapsulating : Server[@Name='']/Database/View
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class View  : ISfcSupportsDesignMode, IObjectPermission, IColumnPermission
	{
		public View() : base(){ }
		public View(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, null);
			this.Parent = database;
		}
		public View(Database database, string name, string schema) : base()
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
							case "BodyStartIndex": return 1;
							case "CreateDate": return 2;
							case "DateLastModified": return 3;
							case "DwMaterializedViewDistribution": return 4;
							case "HasClusteredIndex": return 5;
							case "HasColumnSpecification": return 6;
							case "HasIndex": return 7;
							case "HasNonClusteredIndex": return 8;
							case "HasPrimaryClusteredIndex": return 9;
							case "ID": return 10;
							case "IsDroppedLedgerView": return 11;
							case "IsEncrypted": return 12;
							case "IsIndexable": return 13;
							case "IsSchemaBound": return 14;
							case "IsSchemaOwned": return 15;
							case "IsSystemObject": return 16;
							case "Owner": return 17;
							case "QuotedIdentifierStatus": return 18;
							case "ReturnsViewMetadata": return 19;
							case "Text": return 20;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiNullsStatus": return 0;
							case "BodyStartIndex": return 1;
							case "CreateDate": return 2;
							case "DateLastModified": return 3;
							case "HasAfterTrigger": return 4;
							case "HasClusteredIndex": return 5;
							case "HasColumnSpecification": return 6;
							case "HasDeleteTrigger": return 7;
							case "HasIndex": return 8;
							case "HasInsertTrigger": return 9;
							case "HasInsteadOfTrigger": return 10;
							case "HasNonClusteredIndex": return 11;
							case "HasPrimaryClusteredIndex": return 12;
							case "HasUpdateTrigger": return 13;
							case "ID": return 14;
							case "IsDroppedLedgerView": return 15;
							case "IsEncrypted": return 16;
							case "IsIndexable": return 17;
							case "IsSchemaBound": return 18;
							case "IsSchemaOwned": return 19;
							case "IsSystemObject": return 20;
							case "LedgerViewType": return 21;
							case "Owner": return 22;
							case "QuotedIdentifierStatus": return 23;
							case "ReturnsViewMetadata": return 24;
							case "Text": return 25;
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
						case "HasClusteredIndex": return 3;
						case "HasColumnSpecification": return 4;
						case "HasNonClusteredIndex": return 5;
						case "HasPrimaryClusteredIndex": return 6;
						case "ID": return 7;
						case "IsEncrypted": return 8;
						case "IsSchemaBound": return 9;
						case "IsSystemObject": return 10;
						case "Owner": return 11;
						case "QuotedIdentifierStatus": return 12;
						case "Text": return 13;
						case "HasAfterTrigger": return 14;
						case "HasDeleteTrigger": return 15;
						case "HasIndex": return 16;
						case "HasInsertTrigger": return 17;
						case "HasInsteadOfTrigger": return 18;
						case "HasUpdateTrigger": return 19;
						case "IsIndexable": return 20;
						case "DateLastModified": return 21;
						case "IsDroppedLedgerView": return 22;
						case "IsSchemaOwned": return 23;
						case "ReturnsViewMetadata": return 24;
						case "PolicyHealthState": return 25;
						case "LedgerViewType": return 26;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 14, 21, 25, 26, 26, 26, 26, 26, 26, 26, 27, 27 };
			static int [] cloudVersionCount = new int [] { 0, 0, 26 };
			static int sqlDwPropertyCount = 21;
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
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DwMaterializedViewDistribution", false, false, typeof(Microsoft.SqlServer.Management.Smo.DwViewDistributionType)),
				new StaticMetadata("HasClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasColumnSpecification", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasPrimaryClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDroppedLedgerView", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsIndexable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReturnsViewMetadata", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("HasAfterTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasColumnSpecification", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasDeleteTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsertTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsteadOfTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasPrimaryClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasUpdateTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDroppedLedgerView", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsIndexable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("LedgerViewType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LedgerViewType)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReturnsViewMetadata", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("HasClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasColumnSpecification", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasPrimaryClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("HasAfterTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasDeleteTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsertTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsteadOfTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasUpdateTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsIndexable", false, true, typeof(System.Boolean)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("IsDroppedLedgerView", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("ReturnsViewMetadata", false, false, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("LedgerViewType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LedgerViewType)),
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
		public System.Boolean HasAfterTrigger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasAfterTrigger");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasClusteredIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasClusteredIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasColumnSpecification
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasColumnSpecification");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasDeleteTrigger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasDeleteTrigger");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasInsertTrigger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasInsertTrigger");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasInsteadOfTrigger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasInsteadOfTrigger");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasNonClusteredIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasNonClusteredIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasPrimaryClusteredIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasPrimaryClusteredIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasUpdateTrigger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasUpdateTrigger");
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
		public System.Boolean IsDroppedLedgerView
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDroppedLedgerView");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsIndexable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsIndexable");
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.LedgerViewType LedgerViewType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.LedgerViewType)this.Properties.GetValueWithNullReplacement("LedgerViewType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewType", value);
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
		public System.Boolean ReturnsViewMetadata
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ReturnsViewMetadata");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReturnsViewMetadata", value);
			}
		}
		[SfcProperty]
		public Microsoft.SqlServer.Management.Smo.DwViewDistributionType DwMaterializedViewDistribution
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DwViewDistributionType)this.Properties.GetValueWithNullReplacement("DwMaterializedViewDistribution");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DwMaterializedViewDistribution", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "LedgerViewType" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
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
		

		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, columnNames, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, columnNames, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, columnNames, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, columnNames, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, columnNames, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, columnNames, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, columnNames, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, columnNames, revokeGrant, cascade, asRole);
		}
		

		public void Deny(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, columnNames, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, columnNames, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, columnNames, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, columnNames, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, columnNames, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, columnNames, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, columnNames, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, columnNames, revokeGrant, cascade, asRole);
		}
		

		public ObjectPermissionInfo[] EnumColumnPermissions()
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, null, null);
		}
		
		public ObjectPermissionInfo[] EnumColumnPermissions(System.String granteeName)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, granteeName, null);
		}
		
		public ObjectPermissionInfo[] EnumColumnPermissions(ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, null, permissions);
		}
		
		public ObjectPermissionInfo[] EnumColumnPermissions(System.String granteeName, ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, granteeName, permissions);
		}
		

      private ViewEvents events;
      public ViewEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new ViewEvents(this);
              }
              return this.events;
          }
      }
    
	}







      public class ViewEvents
      {
      internal ViewEvents(View parent)
      {
          this.parent = parent;
      }

      public ViewEventSet GetEventSelection()
      {
          InitializeEvents();
          return (ViewEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(ViewEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(ViewEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(ViewEventSet events)
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
              serverEventsWorker = new ViewEventsWorker(parent);

          }
      }

      private ViewEventsWorker serverEventsWorker;
      private View parent;
      }
    
}
