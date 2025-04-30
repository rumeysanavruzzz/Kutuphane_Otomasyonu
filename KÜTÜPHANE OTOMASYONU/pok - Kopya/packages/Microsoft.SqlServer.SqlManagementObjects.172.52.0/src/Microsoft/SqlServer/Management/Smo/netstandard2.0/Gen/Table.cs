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
	/// Instance class encapsulating : Server[@Name='']/Database/Table
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Table  : ISfcSupportsDesignMode, IObjectPermission, IColumnPermission, IPropertyDataDispatch
	{
		public Table() : base(){ }
		public Table(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, null);
			this.Parent = database;
		}
		public Table(Database database, string name, string schema) : base()
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
							case "CreateDate": return 1;
							case "DataSourceName": return 2;
							case "DateLastModified": return 3;
							case "Durability": return 4;
							case "DwTableDistribution": return 5;
							case "FakeSystemTable": return 6;
							case "FileFormatName": return 7;
							case "FileGroup": return 8;
							case "HasClassifiedColumn": return 9;
							case "HasClusteredColumnStoreIndex": return 10;
							case "HasClusteredIndex": return 11;
							case "HasCompressedPartitions": return 12;
							case "HasHeapIndex": return 13;
							case "HasIndex": return 14;
							case "HasNonClusteredColumnStoreIndex": return 15;
							case "HasNonClusteredIndex": return 16;
							case "HasPrimaryClusteredIndex": return 17;
							case "HasSparseColumn": return 18;
							case "HasSpatialData": return 19;
							case "HasXmlData": return 20;
							case "HasXmlIndex": return 21;
							case "ID": return 22;
							case "IsDroppedLedgerTable": return 23;
							case "IsEdge": return 24;
							case "IsExternal": return 25;
							case "IsIndexable": return 26;
							case "IsLedger": return 27;
							case "IsMemoryOptimized": return 28;
							case "IsNode": return 29;
							case "IsPartitioned": return 30;
							case "IsSchemaOwned": return 31;
							case "IsSystemObject": return 32;
							case "Location": return 33;
							case "LockEscalation": return 34;
							case "Owner": return 35;
							case "PartitionScheme": return 36;
							case "QuotedIdentifierStatus": return 37;
							case "RejectedRowLocation": return 38;
							case "RejectSampleValue": return 39;
							case "RejectType": return 40;
							case "RejectValue": return 41;
							case "RowCount": return 42;
							case "TemporalType": return 43;
							case "TextFileGroup": return 44;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiNullsStatus": return 0;
							case "ChangeTrackingEnabled": return 1;
							case "CreateDate": return 2;
							case "DataSourceName": return 3;
							case "DateLastModified": return 4;
							case "Durability": return 5;
							case "ExternalTableDistribution": return 6;
							case "FakeSystemTable": return 7;
							case "FileFormatNameOd": return 8;
							case "FileGroup": return 9;
							case "FileStreamFileGroup": return 10;
							case "FileStreamPartitionScheme": return 11;
							case "FileTableDirectoryName": return 12;
							case "FileTableNameColumnCollation": return 13;
							case "FileTableNamespaceEnabled": return 14;
							case "HasAfterTrigger": return 15;
							case "HasClassifiedColumn": return 16;
							case "HasClusteredColumnStoreIndex": return 17;
							case "HasClusteredIndex": return 18;
							case "HasCompressedPartitions": return 19;
							case "HasDeleteTrigger": return 20;
							case "HasHeapIndex": return 21;
							case "HasIndex": return 22;
							case "HasInsertTrigger": return 23;
							case "HasInsteadOfTrigger": return 24;
							case "HasNonClusteredColumnStoreIndex": return 25;
							case "HasNonClusteredIndex": return 26;
							case "HasPrimaryClusteredIndex": return 27;
							case "HasSparseColumn": return 28;
							case "HasSpatialData": return 29;
							case "HasSystemTimePeriod": return 30;
							case "HasUpdateTrigger": return 31;
							case "HasXmlData": return 32;
							case "HasXmlIndex": return 33;
							case "HistoryRetentionPeriod": return 34;
							case "HistoryRetentionPeriodUnit": return 35;
							case "HistoryTableID": return 36;
							case "HistoryTableName": return 37;
							case "HistoryTableSchema": return 38;
							case "ID": return 39;
							case "IsDroppedLedgerTable": return 40;
							case "IsEdge": return 41;
							case "IsExternal": return 42;
							case "IsFileTable": return 43;
							case "IsIndexable": return 44;
							case "IsLedger": return 45;
							case "IsMemoryOptimized": return 46;
							case "IsNode": return 47;
							case "IsPartitioned": return 48;
							case "IsSchemaOwned": return 49;
							case "IsSystemObject": return 50;
							case "IsSystemVersioned": return 51;
							case "LedgerType": return 52;
							case "LedgerViewName": return 53;
							case "LedgerViewOperationTypeColumnName": return 54;
							case "LedgerViewOperationTypeDescColumnName": return 55;
							case "LedgerViewSchema": return 56;
							case "LedgerViewSequenceNumberColumnName": return 57;
							case "LedgerViewTransactionIdColumnName": return 58;
							case "LocationOd": return 59;
							case "LockEscalation": return 60;
							case "Owner": return 61;
							case "PartitionScheme": return 62;
							case "QuotedIdentifierStatus": return 63;
							case "RemoteObjectName": return 64;
							case "RemoteSchemaName": return 65;
							case "Replicated": return 66;
							case "RowCount": return 67;
							case "ShardingColumnName": return 68;
							case "SystemTimePeriodEndColumn": return 69;
							case "SystemTimePeriodStartColumn": return 70;
							case "TemporalType": return 71;
							case "TextFileGroup": return 72;
							case "TrackColumnsUpdatedEnabled": return 73;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "CreateDate": return 0;
						case "DataSpaceUsed": return 1;
						case "FakeSystemTable": return 2;
						case "FileGroup": return 3;
						case "HasClusteredIndex": return 4;
						case "HasNonClusteredIndex": return 5;
						case "HasPrimaryClusteredIndex": return 6;
						case "HasSparseColumn": return 7;
						case "ID": return 8;
						case "IndexSpaceUsed": return 9;
						case "IsDroppedLedgerTable": return 10;
						case "IsEdge": return 11;
						case "IsLedger": return 12;
						case "IsNode": return 13;
						case "IsSystemObject": return 14;
						case "Owner": return 15;
						case "Replicated": return 16;
						case "RowCount": return 17;
						case "TextFileGroup": return 18;
						case "AnsiNullsStatus": return 19;
						case "HasAfterTrigger": return 20;
						case "HasDeleteTrigger": return 21;
						case "HasIndex": return 22;
						case "HasInsertTrigger": return 23;
						case "HasInsteadOfTrigger": return 24;
						case "HasUpdateTrigger": return 25;
						case "IsIndexable": return 26;
						case "QuotedIdentifierStatus": return 27;
						case "DateLastModified": return 28;
						case "HasHeapIndex": return 29;
						case "HasNonClusteredColumnStoreIndex": return 30;
						case "HasSpatialData": return 31;
						case "HasXmlData": return 32;
						case "HasXmlIndex": return 33;
						case "IsPartitioned": return 34;
						case "IsSchemaOwned": return 35;
						case "IsVarDecimalStorageFormatEnabled": return 36;
						case "PartitionScheme": return 37;
						case "ChangeTrackingEnabled": return 38;
						case "FileStreamFileGroup": return 39;
						case "FileStreamPartitionScheme": return 40;
						case "HasClassifiedColumn": return 41;
						case "HasCompressedPartitions": return 42;
						case "LockEscalation": return 43;
						case "PolicyHealthState": return 44;
						case "TrackColumnsUpdatedEnabled": return 45;
						case "FileTableDirectoryName": return 46;
						case "FileTableNameColumnCollation": return 47;
						case "FileTableNamespaceEnabled": return 48;
						case "IsFileTable": return 49;
						case "Durability": return 50;
						case "HasClusteredColumnStoreIndex": return 51;
						case "IsMemoryOptimized": return 52;
						case "DataSourceName": return 53;
						case "ExternalTableDistribution": return 54;
						case "FileFormatName": return 55;
						case "HasSystemTimePeriod": return 56;
						case "HistoryTableID": return 57;
						case "HistoryTableName": return 58;
						case "HistoryTableSchema": return 59;
						case "IsExternal": return 60;
						case "IsSystemVersioned": return 61;
						case "Location": return 62;
						case "RejectSampleValue": return 63;
						case "RejectType": return 64;
						case "RejectValue": return 65;
						case "RemoteDataArchiveDataMigrationState": return 66;
						case "RemoteDataArchiveEnabled": return 67;
						case "RemoteDataArchiveFilterPredicate": return 68;
						case "RemoteObjectName": return 69;
						case "RemoteSchemaName": return 70;
						case "RemoteTableName": return 71;
						case "RemoteTableProvisioned": return 72;
						case "ShardingColumnName": return 73;
						case "SystemTimePeriodEndColumn": return 74;
						case "SystemTimePeriodStartColumn": return 75;
						case "TemporalType": return 76;
						case "DataRetentionEnabled": return 77;
						case "DataRetentionFilterColumnName": return 78;
						case "DataRetentionPeriod": return 79;
						case "DataRetentionPeriodUnit": return 80;
						case "HasXmlCompressedPartitions": return 81;
						case "LedgerType": return 82;
						case "LedgerViewName": return 83;
						case "LedgerViewOperationTypeColumnName": return 84;
						case "LedgerViewOperationTypeDescColumnName": return 85;
						case "LedgerViewSchema": return 86;
						case "LedgerViewSequenceNumberColumnName": return 87;
						case "LedgerViewTransactionIdColumnName": return 88;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 19, 28, 38, 46, 46, 50, 53, 77, 77, 81, 89, 89 };
			static int [] cloudVersionCount = new int [] { 0, 0, 74 };
			static int sqlDwPropertyCount = 45;
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
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataSourceName", true, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("Durability", false, false, typeof(Microsoft.SqlServer.Management.Smo.DurabilityType)),
				new StaticMetadata("DwTableDistribution", false, false, typeof(Microsoft.SqlServer.Management.Smo.DwTableDistributionType)),
				new StaticMetadata("FakeSystemTable", false, true, typeof(System.Boolean)),
				new StaticMetadata("FileFormatName", true, false, typeof(System.String)),
				new StaticMetadata("FileGroup", true, false, typeof(System.String)),
				new StaticMetadata("HasClassifiedColumn", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasClusteredColumnStoreIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasHeapIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredColumnStoreIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasPrimaryClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSparseColumn", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasSpatialData", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasXmlData", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasXmlIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDroppedLedgerTable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEdge", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsExternal", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsIndexable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsLedger", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsMemoryOptimized", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsNode", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPartitioned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Location", true, false, typeof(System.String)),
				new StaticMetadata("LockEscalation", false, false, typeof(Microsoft.SqlServer.Management.Smo.LockEscalationType)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("PartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("RejectedRowLocation", true, false, typeof(System.String)),
				new StaticMetadata("RejectSampleValue", true, false, typeof(System.Double)),
				new StaticMetadata("RejectType", true, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalTableRejectType)),
				new StaticMetadata("RejectValue", true, false, typeof(System.Double)),
				new StaticMetadata("RowCount", true, true, typeof(System.Int64)),
				new StaticMetadata("TemporalType", false, true, typeof(Microsoft.SqlServer.Management.Smo.TableTemporalType)),
				new StaticMetadata("TextFileGroup", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("ChangeTrackingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataSourceName", true, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("Durability", false, false, typeof(Microsoft.SqlServer.Management.Smo.DurabilityType)),
				new StaticMetadata("ExternalTableDistribution", true, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType)),
				new StaticMetadata("FakeSystemTable", false, true, typeof(System.Boolean)),
				new StaticMetadata("FileFormatNameOd", true, true, typeof(System.String)),
				new StaticMetadata("FileGroup", true, false, typeof(System.String)),
				new StaticMetadata("FileStreamFileGroup", false, false, typeof(System.String)),
				new StaticMetadata("FileStreamPartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("FileTableDirectoryName", false, false, typeof(System.String)),
				new StaticMetadata("FileTableNameColumnCollation", false, false, typeof(System.String)),
				new StaticMetadata("FileTableNamespaceEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("HasAfterTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasClassifiedColumn", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasClusteredColumnStoreIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasDeleteTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasHeapIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsertTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsteadOfTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredColumnStoreIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasPrimaryClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSparseColumn", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasSpatialData", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSystemTimePeriod", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasUpdateTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasXmlData", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasXmlIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HistoryRetentionPeriod", false, false, typeof(System.Int32)),
				new StaticMetadata("HistoryRetentionPeriodUnit", false, false, typeof(Microsoft.SqlServer.Management.Smo.TemporalHistoryRetentionPeriodUnit)),
				new StaticMetadata("HistoryTableID", false, true, typeof(System.Int32)),
				new StaticMetadata("HistoryTableName", false, false, typeof(System.String)),
				new StaticMetadata("HistoryTableSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDroppedLedgerTable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEdge", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsExternal", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsFileTable", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsIndexable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsLedger", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsMemoryOptimized", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsNode", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPartitioned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemVersioned", false, false, typeof(System.Boolean)),
				new StaticMetadata("LedgerType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LedgerTableType)),
				new StaticMetadata("LedgerViewName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewOperationTypeColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewOperationTypeDescColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewSchema", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewSequenceNumberColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewTransactionIdColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LocationOd", true, true, typeof(System.String)),
				new StaticMetadata("LockEscalation", false, false, typeof(Microsoft.SqlServer.Management.Smo.LockEscalationType)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("PartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("RemoteObjectName", true, false, typeof(System.String)),
				new StaticMetadata("RemoteSchemaName", true, false, typeof(System.String)),
				new StaticMetadata("Replicated", false, true, typeof(System.Boolean)),
				new StaticMetadata("RowCount", true, true, typeof(System.Int64)),
				new StaticMetadata("ShardingColumnName", true, false, typeof(System.String)),
				new StaticMetadata("SystemTimePeriodEndColumn", false, true, typeof(System.String)),
				new StaticMetadata("SystemTimePeriodStartColumn", false, true, typeof(System.String)),
				new StaticMetadata("TemporalType", false, true, typeof(Microsoft.SqlServer.Management.Smo.TableTemporalType)),
				new StaticMetadata("TextFileGroup", false, false, typeof(System.String)),
				new StaticMetadata("TrackColumnsUpdatedEnabled", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataSpaceUsed", true, true, typeof(System.Double)),
				new StaticMetadata("FakeSystemTable", false, true, typeof(System.Boolean)),
				new StaticMetadata("FileGroup", true, false, typeof(System.String)),
				new StaticMetadata("HasClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasPrimaryClusteredIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSparseColumn", true, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IndexSpaceUsed", true, true, typeof(System.Double)),
				new StaticMetadata("IsDroppedLedgerTable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEdge", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsLedger", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsNode", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("Replicated", false, true, typeof(System.Boolean)),
				new StaticMetadata("RowCount", true, true, typeof(System.Int64)),
				new StaticMetadata("TextFileGroup", false, false, typeof(System.String)),
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("HasAfterTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasDeleteTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsertTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasInsteadOfTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasUpdateTrigger", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsIndexable", false, true, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("HasHeapIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasNonClusteredColumnStoreIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSpatialData", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasXmlData", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasXmlIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsPartitioned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsVarDecimalStorageFormatEnabled", true, false, typeof(System.Boolean)),
				new StaticMetadata("PartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("ChangeTrackingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("FileStreamFileGroup", false, false, typeof(System.String)),
				new StaticMetadata("FileStreamPartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("HasClassifiedColumn", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("LockEscalation", false, false, typeof(Microsoft.SqlServer.Management.Smo.LockEscalationType)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("TrackColumnsUpdatedEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("FileTableDirectoryName", false, false, typeof(System.String)),
				new StaticMetadata("FileTableNameColumnCollation", false, false, typeof(System.String)),
				new StaticMetadata("FileTableNamespaceEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsFileTable", false, false, typeof(System.Boolean)),
				new StaticMetadata("Durability", false, false, typeof(Microsoft.SqlServer.Management.Smo.DurabilityType)),
				new StaticMetadata("HasClusteredColumnStoreIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsMemoryOptimized", false, false, typeof(System.Boolean)),
				new StaticMetadata("DataSourceName", true, false, typeof(System.String)),
				new StaticMetadata("ExternalTableDistribution", true, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType)),
				new StaticMetadata("FileFormatName", true, false, typeof(System.String)),
				new StaticMetadata("HasSystemTimePeriod", false, true, typeof(System.Boolean)),
				new StaticMetadata("HistoryTableID", false, true, typeof(System.Int32)),
				new StaticMetadata("HistoryTableName", false, false, typeof(System.String)),
				new StaticMetadata("HistoryTableSchema", false, false, typeof(System.String)),
				new StaticMetadata("IsExternal", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemVersioned", false, false, typeof(System.Boolean)),
				new StaticMetadata("Location", true, false, typeof(System.String)),
				new StaticMetadata("RejectSampleValue", true, false, typeof(System.Double)),
				new StaticMetadata("RejectType", true, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalTableRejectType)),
				new StaticMetadata("RejectValue", true, false, typeof(System.Double)),
				new StaticMetadata("RemoteDataArchiveDataMigrationState", false, false, typeof(Microsoft.SqlServer.Management.Smo.RemoteDataArchiveMigrationState)),
				new StaticMetadata("RemoteDataArchiveEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("RemoteDataArchiveFilterPredicate", false, false, typeof(System.String)),
				new StaticMetadata("RemoteObjectName", true, false, typeof(System.String)),
				new StaticMetadata("RemoteSchemaName", true, false, typeof(System.String)),
				new StaticMetadata("RemoteTableName", false, false, typeof(System.String)),
				new StaticMetadata("RemoteTableProvisioned", false, false, typeof(System.Boolean)),
				new StaticMetadata("ShardingColumnName", true, false, typeof(System.String)),
				new StaticMetadata("SystemTimePeriodEndColumn", false, true, typeof(System.String)),
				new StaticMetadata("SystemTimePeriodStartColumn", false, true, typeof(System.String)),
				new StaticMetadata("TemporalType", false, true, typeof(Microsoft.SqlServer.Management.Smo.TableTemporalType)),
				new StaticMetadata("DataRetentionEnabled", true, false, typeof(System.Boolean)),
				new StaticMetadata("DataRetentionFilterColumnName", true, false, typeof(System.String)),
				new StaticMetadata("DataRetentionPeriod", true, false, typeof(System.Int32)),
				new StaticMetadata("DataRetentionPeriodUnit", true, false, typeof(Microsoft.SqlServer.Management.Smo.DataRetentionPeriodUnit)),
				new StaticMetadata("HasXmlCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("LedgerType", false, false, typeof(Microsoft.SqlServer.Management.Smo.LedgerTableType)),
				new StaticMetadata("LedgerViewName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewOperationTypeColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewOperationTypeDescColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewSchema", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewSequenceNumberColumnName", true, false, typeof(System.String)),
				new StaticMetadata("LedgerViewTransactionIdColumnName", true, false, typeof(System.String)),
			};
		}
		private sealed class XSchemaProps
		{
			private System.Boolean _AnsiNullsStatus;
			internal System.Boolean AnsiNullsStatus { get{ return _AnsiNullsStatus; } set{ _AnsiNullsStatus=value; } }

			private System.String _DataSourceName;
			internal System.String DataSourceName { get{ return _DataSourceName; } set{ _DataSourceName=value; } }

			private Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType _ExternalTableDistribution;
			internal Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType ExternalTableDistribution { get{ return _ExternalTableDistribution; } set{ _ExternalTableDistribution=value; } }

			private System.String _FileFormatName;
			internal System.String FileFormatName { get{ return _FileFormatName; } set{ _FileFormatName=value; } }

			private System.String _FileGroup;
			internal System.String FileGroup { get{ return _FileGroup; } set{ _FileGroup=value; } }

			private System.String _FileStreamFileGroup;
			internal System.String FileStreamFileGroup { get{ return _FileStreamFileGroup; } set{ _FileStreamFileGroup=value; } }

			private System.String _FileStreamPartitionScheme;
			internal System.String FileStreamPartitionScheme { get{ return _FileStreamPartitionScheme; } set{ _FileStreamPartitionScheme=value; } }

			private System.Int32 _ID;
			internal System.Int32 ID { get{ return _ID; } set{ _ID=value; } }

			private System.Boolean _IsExternal;
			internal System.Boolean IsExternal { get{ return _IsExternal; } set{ _IsExternal=value; } }

			private System.Boolean _IsPartitioned;
			internal System.Boolean IsPartitioned { get{ return _IsPartitioned; } set{ _IsPartitioned=value; } }

			private System.Boolean _IsSystemObject;
			internal System.Boolean IsSystemObject { get{ return _IsSystemObject; } set{ _IsSystemObject=value; } }

			private System.String _Location;
			internal System.String Location { get{ return _Location; } set{ _Location=value; } }

			private System.String _PartitionScheme;
			internal System.String PartitionScheme { get{ return _PartitionScheme; } set{ _PartitionScheme=value; } }

			private System.Boolean _QuotedIdentifierStatus;
			internal System.Boolean QuotedIdentifierStatus { get{ return _QuotedIdentifierStatus; } set{ _QuotedIdentifierStatus=value; } }

			private System.Double _RejectSampleValue;
			internal System.Double RejectSampleValue { get{ return _RejectSampleValue; } set{ _RejectSampleValue=value; } }

			private Microsoft.SqlServer.Management.Smo.ExternalTableRejectType _RejectType;
			internal Microsoft.SqlServer.Management.Smo.ExternalTableRejectType RejectType { get{ return _RejectType; } set{ _RejectType=value; } }

			private System.Double _RejectValue;
			internal System.Double RejectValue { get{ return _RejectValue; } set{ _RejectValue=value; } }

			private System.String _RemoteObjectName;
			internal System.String RemoteObjectName { get{ return _RemoteObjectName; } set{ _RemoteObjectName=value; } }

			private System.String _RemoteSchemaName;
			internal System.String RemoteSchemaName { get{ return _RemoteSchemaName; } set{ _RemoteSchemaName=value; } }

			private System.String _ShardingColumnName;
			internal System.String ShardingColumnName { get{ return _ShardingColumnName; } set{ _ShardingColumnName=value; } }

			private System.String _TextFileGroup;
			internal System.String TextFileGroup { get{ return _TextFileGroup; } set{ _TextFileGroup=value; } }

			private System.String _FileFormatNameOd;
			internal System.String FileFormatNameOd { get{ return _FileFormatNameOd; } set{ _FileFormatNameOd=value; } }

			private System.String _LocationOd;
			internal System.String LocationOd { get{ return _LocationOd; } set{ _LocationOd=value; } }

			private Microsoft.SqlServer.Management.Smo.DwTableDistributionType _DwTableDistribution;
			internal Microsoft.SqlServer.Management.Smo.DwTableDistributionType DwTableDistribution { get{ return _DwTableDistribution; } set{ _DwTableDistribution=value; } }

			private System.String _RejectedRowLocation;
			internal System.String RejectedRowLocation { get{ return _RejectedRowLocation; } set{ _RejectedRowLocation=value; } }

		}

		private sealed class XRuntimeProps
		{
			private System.Boolean _ChangeTrackingEnabled;
			internal System.Boolean ChangeTrackingEnabled { get{ return _ChangeTrackingEnabled; } set{ _ChangeTrackingEnabled=value; } }

			private System.DateTime _CreateDate;
			internal System.DateTime CreateDate { get{ return _CreateDate; } set{ _CreateDate=value; } }

			private System.Boolean _DataRetentionEnabled;
			internal System.Boolean DataRetentionEnabled { get{ return _DataRetentionEnabled; } set{ _DataRetentionEnabled=value; } }

			private System.String _DataRetentionFilterColumnName;
			internal System.String DataRetentionFilterColumnName { get{ return _DataRetentionFilterColumnName; } set{ _DataRetentionFilterColumnName=value; } }

			private System.Int32 _DataRetentionPeriod;
			internal System.Int32 DataRetentionPeriod { get{ return _DataRetentionPeriod; } set{ _DataRetentionPeriod=value; } }

			private Microsoft.SqlServer.Management.Smo.DataRetentionPeriodUnit _DataRetentionPeriodUnit;
			internal Microsoft.SqlServer.Management.Smo.DataRetentionPeriodUnit DataRetentionPeriodUnit { get{ return _DataRetentionPeriodUnit; } set{ _DataRetentionPeriodUnit=value; } }

			private System.Double _DataSpaceUsed;
			internal System.Double DataSpaceUsed { get{ return _DataSpaceUsed; } set{ _DataSpaceUsed=value; } }

			private System.DateTime _DateLastModified;
			internal System.DateTime DateLastModified { get{ return _DateLastModified; } set{ _DateLastModified=value; } }

			private Microsoft.SqlServer.Management.Smo.DurabilityType _Durability;
			internal Microsoft.SqlServer.Management.Smo.DurabilityType Durability { get{ return _Durability; } set{ _Durability=value; } }

			private System.Boolean _FakeSystemTable;
			internal System.Boolean FakeSystemTable { get{ return _FakeSystemTable; } set{ _FakeSystemTable=value; } }

			private System.String _FileTableDirectoryName;
			internal System.String FileTableDirectoryName { get{ return _FileTableDirectoryName; } set{ _FileTableDirectoryName=value; } }

			private System.String _FileTableNameColumnCollation;
			internal System.String FileTableNameColumnCollation { get{ return _FileTableNameColumnCollation; } set{ _FileTableNameColumnCollation=value; } }

			private System.Boolean _FileTableNamespaceEnabled;
			internal System.Boolean FileTableNamespaceEnabled { get{ return _FileTableNamespaceEnabled; } set{ _FileTableNamespaceEnabled=value; } }

			private System.Boolean _HasAfterTrigger;
			internal System.Boolean HasAfterTrigger { get{ return _HasAfterTrigger; } set{ _HasAfterTrigger=value; } }

			private System.Boolean _HasClassifiedColumn;
			internal System.Boolean HasClassifiedColumn { get{ return _HasClassifiedColumn; } set{ _HasClassifiedColumn=value; } }

			private System.Boolean _HasClusteredColumnStoreIndex;
			internal System.Boolean HasClusteredColumnStoreIndex { get{ return _HasClusteredColumnStoreIndex; } set{ _HasClusteredColumnStoreIndex=value; } }

			private System.Boolean _HasClusteredIndex;
			internal System.Boolean HasClusteredIndex { get{ return _HasClusteredIndex; } set{ _HasClusteredIndex=value; } }

			private System.Boolean _HasCompressedPartitions;
			internal System.Boolean HasCompressedPartitions { get{ return _HasCompressedPartitions; } set{ _HasCompressedPartitions=value; } }

			private System.Boolean _HasDeleteTrigger;
			internal System.Boolean HasDeleteTrigger { get{ return _HasDeleteTrigger; } set{ _HasDeleteTrigger=value; } }

			private System.Boolean _HasHeapIndex;
			internal System.Boolean HasHeapIndex { get{ return _HasHeapIndex; } set{ _HasHeapIndex=value; } }

			private System.Boolean _HasIndex;
			internal System.Boolean HasIndex { get{ return _HasIndex; } set{ _HasIndex=value; } }

			private System.Boolean _HasInsertTrigger;
			internal System.Boolean HasInsertTrigger { get{ return _HasInsertTrigger; } set{ _HasInsertTrigger=value; } }

			private System.Boolean _HasInsteadOfTrigger;
			internal System.Boolean HasInsteadOfTrigger { get{ return _HasInsteadOfTrigger; } set{ _HasInsteadOfTrigger=value; } }

			private System.Boolean _HasNonClusteredColumnStoreIndex;
			internal System.Boolean HasNonClusteredColumnStoreIndex { get{ return _HasNonClusteredColumnStoreIndex; } set{ _HasNonClusteredColumnStoreIndex=value; } }

			private System.Boolean _HasNonClusteredIndex;
			internal System.Boolean HasNonClusteredIndex { get{ return _HasNonClusteredIndex; } set{ _HasNonClusteredIndex=value; } }

			private System.Boolean _HasPrimaryClusteredIndex;
			internal System.Boolean HasPrimaryClusteredIndex { get{ return _HasPrimaryClusteredIndex; } set{ _HasPrimaryClusteredIndex=value; } }

			private System.Boolean _HasSparseColumn;
			internal System.Boolean HasSparseColumn { get{ return _HasSparseColumn; } set{ _HasSparseColumn=value; } }

			private System.Boolean _HasSpatialData;
			internal System.Boolean HasSpatialData { get{ return _HasSpatialData; } set{ _HasSpatialData=value; } }

			private System.Boolean _HasSystemTimePeriod;
			internal System.Boolean HasSystemTimePeriod { get{ return _HasSystemTimePeriod; } set{ _HasSystemTimePeriod=value; } }

			private System.Boolean _HasUpdateTrigger;
			internal System.Boolean HasUpdateTrigger { get{ return _HasUpdateTrigger; } set{ _HasUpdateTrigger=value; } }

			private System.Boolean _HasXmlCompressedPartitions;
			internal System.Boolean HasXmlCompressedPartitions { get{ return _HasXmlCompressedPartitions; } set{ _HasXmlCompressedPartitions=value; } }

			private System.Boolean _HasXmlData;
			internal System.Boolean HasXmlData { get{ return _HasXmlData; } set{ _HasXmlData=value; } }

			private System.Boolean _HasXmlIndex;
			internal System.Boolean HasXmlIndex { get{ return _HasXmlIndex; } set{ _HasXmlIndex=value; } }

			private System.Int32 _HistoryTableID;
			internal System.Int32 HistoryTableID { get{ return _HistoryTableID; } set{ _HistoryTableID=value; } }

			private System.String _HistoryTableName;
			internal System.String HistoryTableName { get{ return _HistoryTableName; } set{ _HistoryTableName=value; } }

			private System.String _HistoryTableSchema;
			internal System.String HistoryTableSchema { get{ return _HistoryTableSchema; } set{ _HistoryTableSchema=value; } }

			private System.Double _IndexSpaceUsed;
			internal System.Double IndexSpaceUsed { get{ return _IndexSpaceUsed; } set{ _IndexSpaceUsed=value; } }

			private System.Boolean _IsDroppedLedgerTable;
			internal System.Boolean IsDroppedLedgerTable { get{ return _IsDroppedLedgerTable; } set{ _IsDroppedLedgerTable=value; } }

			private System.Boolean _IsEdge;
			internal System.Boolean IsEdge { get{ return _IsEdge; } set{ _IsEdge=value; } }

			private System.Boolean _IsFileTable;
			internal System.Boolean IsFileTable { get{ return _IsFileTable; } set{ _IsFileTable=value; } }

			private System.Boolean _IsIndexable;
			internal System.Boolean IsIndexable { get{ return _IsIndexable; } set{ _IsIndexable=value; } }

			private System.Boolean _IsLedger;
			internal System.Boolean IsLedger { get{ return _IsLedger; } set{ _IsLedger=value; } }

			private System.Boolean _IsMemoryOptimized;
			internal System.Boolean IsMemoryOptimized { get{ return _IsMemoryOptimized; } set{ _IsMemoryOptimized=value; } }

			private System.Boolean _IsNode;
			internal System.Boolean IsNode { get{ return _IsNode; } set{ _IsNode=value; } }

			private System.Boolean _IsSchemaOwned;
			internal System.Boolean IsSchemaOwned { get{ return _IsSchemaOwned; } set{ _IsSchemaOwned=value; } }

			private System.Boolean _IsSystemVersioned;
			internal System.Boolean IsSystemVersioned { get{ return _IsSystemVersioned; } set{ _IsSystemVersioned=value; } }

			private System.Boolean _IsVarDecimalStorageFormatEnabled;
			internal System.Boolean IsVarDecimalStorageFormatEnabled { get{ return _IsVarDecimalStorageFormatEnabled; } set{ _IsVarDecimalStorageFormatEnabled=value; } }

			private Microsoft.SqlServer.Management.Smo.LedgerTableType _LedgerType;
			internal Microsoft.SqlServer.Management.Smo.LedgerTableType LedgerType { get{ return _LedgerType; } set{ _LedgerType=value; } }

			private System.String _LedgerViewName;
			internal System.String LedgerViewName { get{ return _LedgerViewName; } set{ _LedgerViewName=value; } }

			private System.String _LedgerViewOperationTypeColumnName;
			internal System.String LedgerViewOperationTypeColumnName { get{ return _LedgerViewOperationTypeColumnName; } set{ _LedgerViewOperationTypeColumnName=value; } }

			private System.String _LedgerViewOperationTypeDescColumnName;
			internal System.String LedgerViewOperationTypeDescColumnName { get{ return _LedgerViewOperationTypeDescColumnName; } set{ _LedgerViewOperationTypeDescColumnName=value; } }

			private System.String _LedgerViewSchema;
			internal System.String LedgerViewSchema { get{ return _LedgerViewSchema; } set{ _LedgerViewSchema=value; } }

			private System.String _LedgerViewSequenceNumberColumnName;
			internal System.String LedgerViewSequenceNumberColumnName { get{ return _LedgerViewSequenceNumberColumnName; } set{ _LedgerViewSequenceNumberColumnName=value; } }

			private System.String _LedgerViewTransactionIdColumnName;
			internal System.String LedgerViewTransactionIdColumnName { get{ return _LedgerViewTransactionIdColumnName; } set{ _LedgerViewTransactionIdColumnName=value; } }

			private Microsoft.SqlServer.Management.Smo.LockEscalationType _LockEscalation;
			internal Microsoft.SqlServer.Management.Smo.LockEscalationType LockEscalation { get{ return _LockEscalation; } set{ _LockEscalation=value; } }

			private System.String _Owner;
			internal System.String Owner { get{ return _Owner; } set{ _Owner=value; } }

			private Microsoft.SqlServer.Management.Dmf.PolicyHealthState _PolicyHealthState;
			internal Microsoft.SqlServer.Management.Dmf.PolicyHealthState PolicyHealthState { get{ return _PolicyHealthState; } set{ _PolicyHealthState=value; } }

			private Microsoft.SqlServer.Management.Smo.RemoteDataArchiveMigrationState _RemoteDataArchiveDataMigrationState;
			internal Microsoft.SqlServer.Management.Smo.RemoteDataArchiveMigrationState RemoteDataArchiveDataMigrationState { get{ return _RemoteDataArchiveDataMigrationState; } set{ _RemoteDataArchiveDataMigrationState=value; } }

			private System.Boolean _RemoteDataArchiveEnabled;
			internal System.Boolean RemoteDataArchiveEnabled { get{ return _RemoteDataArchiveEnabled; } set{ _RemoteDataArchiveEnabled=value; } }

			private System.String _RemoteDataArchiveFilterPredicate;
			internal System.String RemoteDataArchiveFilterPredicate { get{ return _RemoteDataArchiveFilterPredicate; } set{ _RemoteDataArchiveFilterPredicate=value; } }

			private System.String _RemoteTableName;
			internal System.String RemoteTableName { get{ return _RemoteTableName; } set{ _RemoteTableName=value; } }

			private System.Boolean _RemoteTableProvisioned;
			internal System.Boolean RemoteTableProvisioned { get{ return _RemoteTableProvisioned; } set{ _RemoteTableProvisioned=value; } }

			private System.Boolean _Replicated;
			internal System.Boolean Replicated { get{ return _Replicated; } set{ _Replicated=value; } }

			private System.Int64 _RowCount;
			internal System.Int64 RowCount { get{ return _RowCount; } set{ _RowCount=value; } }

			private System.String _SystemTimePeriodEndColumn;
			internal System.String SystemTimePeriodEndColumn { get{ return _SystemTimePeriodEndColumn; } set{ _SystemTimePeriodEndColumn=value; } }

			private System.String _SystemTimePeriodStartColumn;
			internal System.String SystemTimePeriodStartColumn { get{ return _SystemTimePeriodStartColumn; } set{ _SystemTimePeriodStartColumn=value; } }

			private Microsoft.SqlServer.Management.Smo.TableTemporalType _TemporalType;
			internal Microsoft.SqlServer.Management.Smo.TableTemporalType TemporalType { get{ return _TemporalType; } set{ _TemporalType=value; } }

			private System.Boolean _TrackColumnsUpdatedEnabled;
			internal System.Boolean TrackColumnsUpdatedEnabled { get{ return _TrackColumnsUpdatedEnabled; } set{ _TrackColumnsUpdatedEnabled=value; } }

			private System.Int32 _HistoryRetentionPeriod;
			internal System.Int32 HistoryRetentionPeriod { get{ return _HistoryRetentionPeriod; } set{ _HistoryRetentionPeriod=value; } }

			private Microsoft.SqlServer.Management.Smo.TemporalHistoryRetentionPeriodUnit _HistoryRetentionPeriodUnit;
			internal Microsoft.SqlServer.Management.Smo.TemporalHistoryRetentionPeriodUnit HistoryRetentionPeriodUnit { get{ return _HistoryRetentionPeriodUnit; } set{ _HistoryRetentionPeriodUnit=value; } }

		}

		object IPropertyDataDispatch.GetPropertyValue( int index )
		{
			object value;
			if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
			{
				if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
				{
					switch(index)
					{
						case 0:
						value = this.XSchema.AnsiNullsStatus;
						break;
						case 1:
						value = this.XRuntime.CreateDate;
						break;
						case 2:
						value = this.XSchema.DataSourceName;
						break;
						case 3:
						value = this.XRuntime.DateLastModified;
						break;
						case 4:
						value = this.XRuntime.Durability;
						break;
						case 5:
						value = this.XSchema.DwTableDistribution;
						break;
						case 6:
						value = this.XRuntime.FakeSystemTable;
						break;
						case 7:
						value = this.XSchema.FileFormatName;
						break;
						case 8:
						value = this.XSchema.FileGroup;
						break;
						case 9:
						value = this.XRuntime.HasClassifiedColumn;
						break;
						case 10:
						value = this.XRuntime.HasClusteredColumnStoreIndex;
						break;
						case 11:
						value = this.XRuntime.HasClusteredIndex;
						break;
						case 12:
						value = this.XRuntime.HasCompressedPartitions;
						break;
						case 13:
						value = this.XRuntime.HasHeapIndex;
						break;
						case 14:
						value = this.XRuntime.HasIndex;
						break;
						case 15:
						value = this.XRuntime.HasNonClusteredColumnStoreIndex;
						break;
						case 16:
						value = this.XRuntime.HasNonClusteredIndex;
						break;
						case 17:
						value = this.XRuntime.HasPrimaryClusteredIndex;
						break;
						case 18:
						value = this.XRuntime.HasSparseColumn;
						break;
						case 19:
						value = this.XRuntime.HasSpatialData;
						break;
						case 20:
						value = this.XRuntime.HasXmlData;
						break;
						case 21:
						value = this.XRuntime.HasXmlIndex;
						break;
						case 22:
						value = this.XSchema.ID;
						break;
						case 23:
						value = this.XRuntime.IsDroppedLedgerTable;
						break;
						case 24:
						value = this.XRuntime.IsEdge;
						break;
						case 25:
						value = this.XSchema.IsExternal;
						break;
						case 26:
						value = this.XRuntime.IsIndexable;
						break;
						case 27:
						value = this.XRuntime.IsLedger;
						break;
						case 28:
						value = this.XRuntime.IsMemoryOptimized;
						break;
						case 29:
						value = this.XRuntime.IsNode;
						break;
						case 30:
						value = this.XSchema.IsPartitioned;
						break;
						case 31:
						value = this.XRuntime.IsSchemaOwned;
						break;
						case 32:
						value = this.XSchema.IsSystemObject;
						break;
						case 33:
						value = this.XSchema.Location;
						break;
						case 34:
						value = this.XRuntime.LockEscalation;
						break;
						case 35:
						value = this.XRuntime.Owner;
						break;
						case 36:
						value = this.XSchema.PartitionScheme;
						break;
						case 37:
						value = this.XSchema.QuotedIdentifierStatus;
						break;
						case 38:
						value = this.XSchema.RejectedRowLocation;
						break;
						case 39:
						value = this.XSchema.RejectSampleValue;
						break;
						case 40:
						value = this.XSchema.RejectType;
						break;
						case 41:
						value = this.XSchema.RejectValue;
						break;
						case 42:
						value = this.XRuntime.RowCount;
						break;
						case 43:
						value = this.XRuntime.TemporalType;
						break;
						case 44:
						value = this.XSchema.TextFileGroup;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						value = this.XSchema.AnsiNullsStatus;
						break;
						case 1:
						value = this.XRuntime.ChangeTrackingEnabled;
						break;
						case 2:
						value = this.XRuntime.CreateDate;
						break;
						case 3:
						value = this.XSchema.DataSourceName;
						break;
						case 4:
						value = this.XRuntime.DateLastModified;
						break;
						case 5:
						value = this.XRuntime.Durability;
						break;
						case 6:
						value = this.XSchema.ExternalTableDistribution;
						break;
						case 7:
						value = this.XRuntime.FakeSystemTable;
						break;
						case 8:
						value = this.XSchema.FileFormatNameOd;
						break;
						case 9:
						value = this.XSchema.FileGroup;
						break;
						case 10:
						value = this.XSchema.FileStreamFileGroup;
						break;
						case 11:
						value = this.XSchema.FileStreamPartitionScheme;
						break;
						case 12:
						value = this.XRuntime.FileTableDirectoryName;
						break;
						case 13:
						value = this.XRuntime.FileTableNameColumnCollation;
						break;
						case 14:
						value = this.XRuntime.FileTableNamespaceEnabled;
						break;
						case 15:
						value = this.XRuntime.HasAfterTrigger;
						break;
						case 16:
						value = this.XRuntime.HasClassifiedColumn;
						break;
						case 17:
						value = this.XRuntime.HasClusteredColumnStoreIndex;
						break;
						case 18:
						value = this.XRuntime.HasClusteredIndex;
						break;
						case 19:
						value = this.XRuntime.HasCompressedPartitions;
						break;
						case 20:
						value = this.XRuntime.HasDeleteTrigger;
						break;
						case 21:
						value = this.XRuntime.HasHeapIndex;
						break;
						case 22:
						value = this.XRuntime.HasIndex;
						break;
						case 23:
						value = this.XRuntime.HasInsertTrigger;
						break;
						case 24:
						value = this.XRuntime.HasInsteadOfTrigger;
						break;
						case 25:
						value = this.XRuntime.HasNonClusteredColumnStoreIndex;
						break;
						case 26:
						value = this.XRuntime.HasNonClusteredIndex;
						break;
						case 27:
						value = this.XRuntime.HasPrimaryClusteredIndex;
						break;
						case 28:
						value = this.XRuntime.HasSparseColumn;
						break;
						case 29:
						value = this.XRuntime.HasSpatialData;
						break;
						case 30:
						value = this.XRuntime.HasSystemTimePeriod;
						break;
						case 31:
						value = this.XRuntime.HasUpdateTrigger;
						break;
						case 32:
						value = this.XRuntime.HasXmlData;
						break;
						case 33:
						value = this.XRuntime.HasXmlIndex;
						break;
						case 34:
						value = this.XRuntime.HistoryRetentionPeriod;
						break;
						case 35:
						value = this.XRuntime.HistoryRetentionPeriodUnit;
						break;
						case 36:
						value = this.XRuntime.HistoryTableID;
						break;
						case 37:
						value = this.XRuntime.HistoryTableName;
						break;
						case 38:
						value = this.XRuntime.HistoryTableSchema;
						break;
						case 39:
						value = this.XSchema.ID;
						break;
						case 40:
						value = this.XRuntime.IsDroppedLedgerTable;
						break;
						case 41:
						value = this.XRuntime.IsEdge;
						break;
						case 42:
						value = this.XSchema.IsExternal;
						break;
						case 43:
						value = this.XRuntime.IsFileTable;
						break;
						case 44:
						value = this.XRuntime.IsIndexable;
						break;
						case 45:
						value = this.XRuntime.IsLedger;
						break;
						case 46:
						value = this.XRuntime.IsMemoryOptimized;
						break;
						case 47:
						value = this.XRuntime.IsNode;
						break;
						case 48:
						value = this.XSchema.IsPartitioned;
						break;
						case 49:
						value = this.XRuntime.IsSchemaOwned;
						break;
						case 50:
						value = this.XSchema.IsSystemObject;
						break;
						case 51:
						value = this.XRuntime.IsSystemVersioned;
						break;
						case 52:
						value = this.XRuntime.LedgerType;
						break;
						case 53:
						value = this.XRuntime.LedgerViewName;
						break;
						case 54:
						value = this.XRuntime.LedgerViewOperationTypeColumnName;
						break;
						case 55:
						value = this.XRuntime.LedgerViewOperationTypeDescColumnName;
						break;
						case 56:
						value = this.XRuntime.LedgerViewSchema;
						break;
						case 57:
						value = this.XRuntime.LedgerViewSequenceNumberColumnName;
						break;
						case 58:
						value = this.XRuntime.LedgerViewTransactionIdColumnName;
						break;
						case 59:
						value = this.XSchema.LocationOd;
						break;
						case 60:
						value = this.XRuntime.LockEscalation;
						break;
						case 61:
						value = this.XRuntime.Owner;
						break;
						case 62:
						value = this.XSchema.PartitionScheme;
						break;
						case 63:
						value = this.XSchema.QuotedIdentifierStatus;
						break;
						case 64:
						value = this.XSchema.RemoteObjectName;
						break;
						case 65:
						value = this.XSchema.RemoteSchemaName;
						break;
						case 66:
						value = this.XRuntime.Replicated;
						break;
						case 67:
						value = this.XRuntime.RowCount;
						break;
						case 68:
						value = this.XSchema.ShardingColumnName;
						break;
						case 69:
						value = this.XRuntime.SystemTimePeriodEndColumn;
						break;
						case 70:
						value = this.XRuntime.SystemTimePeriodStartColumn;
						break;
						case 71:
						value = this.XRuntime.TemporalType;
						break;
						case 72:
						value = this.XSchema.TextFileGroup;
						break;
						case 73:
						value = this.XRuntime.TrackColumnsUpdatedEnabled;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
			}
			else
			{
				switch(index)
				{
					case 19:
					value = this.XSchema.AnsiNullsStatus;
					break;
					case 38:
					value = this.XRuntime.ChangeTrackingEnabled;
					break;
					case 0:
					value = this.XRuntime.CreateDate;
					break;
					case 77:
					value = this.XRuntime.DataRetentionEnabled;
					break;
					case 78:
					value = this.XRuntime.DataRetentionFilterColumnName;
					break;
					case 79:
					value = this.XRuntime.DataRetentionPeriod;
					break;
					case 80:
					value = this.XRuntime.DataRetentionPeriodUnit;
					break;
					case 53:
					value = this.XSchema.DataSourceName;
					break;
					case 1:
					value = this.XRuntime.DataSpaceUsed;
					break;
					case 28:
					value = this.XRuntime.DateLastModified;
					break;
					case 50:
					value = this.XRuntime.Durability;
					break;
					case 54:
					value = this.XSchema.ExternalTableDistribution;
					break;
					case 2:
					value = this.XRuntime.FakeSystemTable;
					break;
					case 55:
					value = this.XSchema.FileFormatName;
					break;
					case 3:
					value = this.XSchema.FileGroup;
					break;
					case 39:
					value = this.XSchema.FileStreamFileGroup;
					break;
					case 40:
					value = this.XSchema.FileStreamPartitionScheme;
					break;
					case 46:
					value = this.XRuntime.FileTableDirectoryName;
					break;
					case 47:
					value = this.XRuntime.FileTableNameColumnCollation;
					break;
					case 48:
					value = this.XRuntime.FileTableNamespaceEnabled;
					break;
					case 20:
					value = this.XRuntime.HasAfterTrigger;
					break;
					case 41:
					value = this.XRuntime.HasClassifiedColumn;
					break;
					case 51:
					value = this.XRuntime.HasClusteredColumnStoreIndex;
					break;
					case 4:
					value = this.XRuntime.HasClusteredIndex;
					break;
					case 42:
					value = this.XRuntime.HasCompressedPartitions;
					break;
					case 21:
					value = this.XRuntime.HasDeleteTrigger;
					break;
					case 29:
					value = this.XRuntime.HasHeapIndex;
					break;
					case 22:
					value = this.XRuntime.HasIndex;
					break;
					case 23:
					value = this.XRuntime.HasInsertTrigger;
					break;
					case 24:
					value = this.XRuntime.HasInsteadOfTrigger;
					break;
					case 30:
					value = this.XRuntime.HasNonClusteredColumnStoreIndex;
					break;
					case 5:
					value = this.XRuntime.HasNonClusteredIndex;
					break;
					case 6:
					value = this.XRuntime.HasPrimaryClusteredIndex;
					break;
					case 7:
					value = this.XRuntime.HasSparseColumn;
					break;
					case 31:
					value = this.XRuntime.HasSpatialData;
					break;
					case 56:
					value = this.XRuntime.HasSystemTimePeriod;
					break;
					case 25:
					value = this.XRuntime.HasUpdateTrigger;
					break;
					case 81:
					value = this.XRuntime.HasXmlCompressedPartitions;
					break;
					case 32:
					value = this.XRuntime.HasXmlData;
					break;
					case 33:
					value = this.XRuntime.HasXmlIndex;
					break;
					case 57:
					value = this.XRuntime.HistoryTableID;
					break;
					case 58:
					value = this.XRuntime.HistoryTableName;
					break;
					case 59:
					value = this.XRuntime.HistoryTableSchema;
					break;
					case 8:
					value = this.XSchema.ID;
					break;
					case 9:
					value = this.XRuntime.IndexSpaceUsed;
					break;
					case 10:
					value = this.XRuntime.IsDroppedLedgerTable;
					break;
					case 11:
					value = this.XRuntime.IsEdge;
					break;
					case 60:
					value = this.XSchema.IsExternal;
					break;
					case 49:
					value = this.XRuntime.IsFileTable;
					break;
					case 26:
					value = this.XRuntime.IsIndexable;
					break;
					case 12:
					value = this.XRuntime.IsLedger;
					break;
					case 52:
					value = this.XRuntime.IsMemoryOptimized;
					break;
					case 13:
					value = this.XRuntime.IsNode;
					break;
					case 34:
					value = this.XSchema.IsPartitioned;
					break;
					case 35:
					value = this.XRuntime.IsSchemaOwned;
					break;
					case 14:
					value = this.XSchema.IsSystemObject;
					break;
					case 61:
					value = this.XRuntime.IsSystemVersioned;
					break;
					case 36:
					value = this.XRuntime.IsVarDecimalStorageFormatEnabled;
					break;
					case 82:
					value = this.XRuntime.LedgerType;
					break;
					case 83:
					value = this.XRuntime.LedgerViewName;
					break;
					case 84:
					value = this.XRuntime.LedgerViewOperationTypeColumnName;
					break;
					case 85:
					value = this.XRuntime.LedgerViewOperationTypeDescColumnName;
					break;
					case 86:
					value = this.XRuntime.LedgerViewSchema;
					break;
					case 87:
					value = this.XRuntime.LedgerViewSequenceNumberColumnName;
					break;
					case 88:
					value = this.XRuntime.LedgerViewTransactionIdColumnName;
					break;
					case 62:
					value = this.XSchema.Location;
					break;
					case 43:
					value = this.XRuntime.LockEscalation;
					break;
					case 15:
					value = this.XRuntime.Owner;
					break;
					case 37:
					value = this.XSchema.PartitionScheme;
					break;
					case 44:
					value = this.XRuntime.PolicyHealthState;
					break;
					case 27:
					value = this.XSchema.QuotedIdentifierStatus;
					break;
					case 63:
					value = this.XSchema.RejectSampleValue;
					break;
					case 64:
					value = this.XSchema.RejectType;
					break;
					case 65:
					value = this.XSchema.RejectValue;
					break;
					case 66:
					value = this.XRuntime.RemoteDataArchiveDataMigrationState;
					break;
					case 67:
					value = this.XRuntime.RemoteDataArchiveEnabled;
					break;
					case 68:
					value = this.XRuntime.RemoteDataArchiveFilterPredicate;
					break;
					case 69:
					value = this.XSchema.RemoteObjectName;
					break;
					case 70:
					value = this.XSchema.RemoteSchemaName;
					break;
					case 71:
					value = this.XRuntime.RemoteTableName;
					break;
					case 72:
					value = this.XRuntime.RemoteTableProvisioned;
					break;
					case 16:
					value = this.XRuntime.Replicated;
					break;
					case 17:
					value = this.XRuntime.RowCount;
					break;
					case 73:
					value = this.XSchema.ShardingColumnName;
					break;
					case 74:
					value = this.XRuntime.SystemTimePeriodEndColumn;
					break;
					case 75:
					value = this.XRuntime.SystemTimePeriodStartColumn;
					break;
					case 76:
					value = this.XRuntime.TemporalType;
					break;
					case 18:
					value = this.XSchema.TextFileGroup;
					break;
					case 45:
					value = this.XRuntime.TrackColumnsUpdatedEnabled;
					break;
					default:
					throw new IndexOutOfRangeException();
				}
			}
			return value;
		}
		void IPropertyDataDispatch.SetPropertyValue( int index, object value )
		{
			if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
			{
				if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
				{
					switch(index)
					{
						case 0:
						this.XSchema.AnsiNullsStatus = (System.Boolean)value;
						break;
						case 1:
						this.XRuntime.CreateDate = (System.DateTime)value;
						break;
						case 2:
						this.XSchema.DataSourceName = (System.String)value;
						break;
						case 3:
						this.XRuntime.DateLastModified = (System.DateTime)value;
						break;
						case 4:
						this.XRuntime.Durability = (Microsoft.SqlServer.Management.Smo.DurabilityType)value;
						break;
						case 5:
						this.XSchema.DwTableDistribution = (Microsoft.SqlServer.Management.Smo.DwTableDistributionType)value;
						break;
						case 6:
						this.XRuntime.FakeSystemTable = (System.Boolean)value;
						break;
						case 7:
						this.XSchema.FileFormatName = (System.String)value;
						break;
						case 8:
						this.XSchema.FileGroup = (System.String)value;
						break;
						case 9:
						this.XRuntime.HasClassifiedColumn = (System.Boolean)value;
						break;
						case 10:
						this.XRuntime.HasClusteredColumnStoreIndex = (System.Boolean)value;
						break;
						case 11:
						this.XRuntime.HasClusteredIndex = (System.Boolean)value;
						break;
						case 12:
						this.XRuntime.HasCompressedPartitions = (System.Boolean)value;
						break;
						case 13:
						this.XRuntime.HasHeapIndex = (System.Boolean)value;
						break;
						case 14:
						this.XRuntime.HasIndex = (System.Boolean)value;
						break;
						case 15:
						this.XRuntime.HasNonClusteredColumnStoreIndex = (System.Boolean)value;
						break;
						case 16:
						this.XRuntime.HasNonClusteredIndex = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.HasPrimaryClusteredIndex = (System.Boolean)value;
						break;
						case 18:
						this.XRuntime.HasSparseColumn = (System.Boolean)value;
						break;
						case 19:
						this.XRuntime.HasSpatialData = (System.Boolean)value;
						break;
						case 20:
						this.XRuntime.HasXmlData = (System.Boolean)value;
						break;
						case 21:
						this.XRuntime.HasXmlIndex = (System.Boolean)value;
						break;
						case 22:
						this.XSchema.ID = (System.Int32)value;
						break;
						case 23:
						this.XRuntime.IsDroppedLedgerTable = (System.Boolean)value;
						break;
						case 24:
						this.XRuntime.IsEdge = (System.Boolean)value;
						break;
						case 25:
						this.XSchema.IsExternal = (System.Boolean)value;
						break;
						case 26:
						this.XRuntime.IsIndexable = (System.Boolean)value;
						break;
						case 27:
						this.XRuntime.IsLedger = (System.Boolean)value;
						break;
						case 28:
						this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
						break;
						case 29:
						this.XRuntime.IsNode = (System.Boolean)value;
						break;
						case 30:
						this.XSchema.IsPartitioned = (System.Boolean)value;
						break;
						case 31:
						this.XRuntime.IsSchemaOwned = (System.Boolean)value;
						break;
						case 32:
						this.XSchema.IsSystemObject = (System.Boolean)value;
						break;
						case 33:
						this.XSchema.Location = (System.String)value;
						break;
						case 34:
						this.XRuntime.LockEscalation = (Microsoft.SqlServer.Management.Smo.LockEscalationType)value;
						break;
						case 35:
						this.XRuntime.Owner = (System.String)value;
						break;
						case 36:
						this.XSchema.PartitionScheme = (System.String)value;
						break;
						case 37:
						this.XSchema.QuotedIdentifierStatus = (System.Boolean)value;
						break;
						case 38:
						this.XSchema.RejectedRowLocation = (System.String)value;
						break;
						case 39:
						this.XSchema.RejectSampleValue = (System.Double)value;
						break;
						case 40:
						this.XSchema.RejectType = (Microsoft.SqlServer.Management.Smo.ExternalTableRejectType)value;
						break;
						case 41:
						this.XSchema.RejectValue = (System.Double)value;
						break;
						case 42:
						this.XRuntime.RowCount = (System.Int64)value;
						break;
						case 43:
						this.XRuntime.TemporalType = (Microsoft.SqlServer.Management.Smo.TableTemporalType)value;
						break;
						case 44:
						this.XSchema.TextFileGroup = (System.String)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						this.XSchema.AnsiNullsStatus = (System.Boolean)value;
						break;
						case 1:
						this.XRuntime.ChangeTrackingEnabled = (System.Boolean)value;
						break;
						case 2:
						this.XRuntime.CreateDate = (System.DateTime)value;
						break;
						case 3:
						this.XSchema.DataSourceName = (System.String)value;
						break;
						case 4:
						this.XRuntime.DateLastModified = (System.DateTime)value;
						break;
						case 5:
						this.XRuntime.Durability = (Microsoft.SqlServer.Management.Smo.DurabilityType)value;
						break;
						case 6:
						this.XSchema.ExternalTableDistribution = (Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType)value;
						break;
						case 7:
						this.XRuntime.FakeSystemTable = (System.Boolean)value;
						break;
						case 8:
						this.XSchema.FileFormatNameOd = (System.String)value;
						break;
						case 9:
						this.XSchema.FileGroup = (System.String)value;
						break;
						case 10:
						this.XSchema.FileStreamFileGroup = (System.String)value;
						break;
						case 11:
						this.XSchema.FileStreamPartitionScheme = (System.String)value;
						break;
						case 12:
						this.XRuntime.FileTableDirectoryName = (System.String)value;
						break;
						case 13:
						this.XRuntime.FileTableNameColumnCollation = (System.String)value;
						break;
						case 14:
						this.XRuntime.FileTableNamespaceEnabled = (System.Boolean)value;
						break;
						case 15:
						this.XRuntime.HasAfterTrigger = (System.Boolean)value;
						break;
						case 16:
						this.XRuntime.HasClassifiedColumn = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.HasClusteredColumnStoreIndex = (System.Boolean)value;
						break;
						case 18:
						this.XRuntime.HasClusteredIndex = (System.Boolean)value;
						break;
						case 19:
						this.XRuntime.HasCompressedPartitions = (System.Boolean)value;
						break;
						case 20:
						this.XRuntime.HasDeleteTrigger = (System.Boolean)value;
						break;
						case 21:
						this.XRuntime.HasHeapIndex = (System.Boolean)value;
						break;
						case 22:
						this.XRuntime.HasIndex = (System.Boolean)value;
						break;
						case 23:
						this.XRuntime.HasInsertTrigger = (System.Boolean)value;
						break;
						case 24:
						this.XRuntime.HasInsteadOfTrigger = (System.Boolean)value;
						break;
						case 25:
						this.XRuntime.HasNonClusteredColumnStoreIndex = (System.Boolean)value;
						break;
						case 26:
						this.XRuntime.HasNonClusteredIndex = (System.Boolean)value;
						break;
						case 27:
						this.XRuntime.HasPrimaryClusteredIndex = (System.Boolean)value;
						break;
						case 28:
						this.XRuntime.HasSparseColumn = (System.Boolean)value;
						break;
						case 29:
						this.XRuntime.HasSpatialData = (System.Boolean)value;
						break;
						case 30:
						this.XRuntime.HasSystemTimePeriod = (System.Boolean)value;
						break;
						case 31:
						this.XRuntime.HasUpdateTrigger = (System.Boolean)value;
						break;
						case 32:
						this.XRuntime.HasXmlData = (System.Boolean)value;
						break;
						case 33:
						this.XRuntime.HasXmlIndex = (System.Boolean)value;
						break;
						case 34:
						this.XRuntime.HistoryRetentionPeriod = (System.Int32)value;
						break;
						case 35:
						this.XRuntime.HistoryRetentionPeriodUnit = (Microsoft.SqlServer.Management.Smo.TemporalHistoryRetentionPeriodUnit)value;
						break;
						case 36:
						this.XRuntime.HistoryTableID = (System.Int32)value;
						break;
						case 37:
						this.XRuntime.HistoryTableName = (System.String)value;
						break;
						case 38:
						this.XRuntime.HistoryTableSchema = (System.String)value;
						break;
						case 39:
						this.XSchema.ID = (System.Int32)value;
						break;
						case 40:
						this.XRuntime.IsDroppedLedgerTable = (System.Boolean)value;
						break;
						case 41:
						this.XRuntime.IsEdge = (System.Boolean)value;
						break;
						case 42:
						this.XSchema.IsExternal = (System.Boolean)value;
						break;
						case 43:
						this.XRuntime.IsFileTable = (System.Boolean)value;
						break;
						case 44:
						this.XRuntime.IsIndexable = (System.Boolean)value;
						break;
						case 45:
						this.XRuntime.IsLedger = (System.Boolean)value;
						break;
						case 46:
						this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
						break;
						case 47:
						this.XRuntime.IsNode = (System.Boolean)value;
						break;
						case 48:
						this.XSchema.IsPartitioned = (System.Boolean)value;
						break;
						case 49:
						this.XRuntime.IsSchemaOwned = (System.Boolean)value;
						break;
						case 50:
						this.XSchema.IsSystemObject = (System.Boolean)value;
						break;
						case 51:
						this.XRuntime.IsSystemVersioned = (System.Boolean)value;
						break;
						case 52:
						this.XRuntime.LedgerType = (Microsoft.SqlServer.Management.Smo.LedgerTableType)value;
						break;
						case 53:
						this.XRuntime.LedgerViewName = (System.String)value;
						break;
						case 54:
						this.XRuntime.LedgerViewOperationTypeColumnName = (System.String)value;
						break;
						case 55:
						this.XRuntime.LedgerViewOperationTypeDescColumnName = (System.String)value;
						break;
						case 56:
						this.XRuntime.LedgerViewSchema = (System.String)value;
						break;
						case 57:
						this.XRuntime.LedgerViewSequenceNumberColumnName = (System.String)value;
						break;
						case 58:
						this.XRuntime.LedgerViewTransactionIdColumnName = (System.String)value;
						break;
						case 59:
						this.XSchema.LocationOd = (System.String)value;
						break;
						case 60:
						this.XRuntime.LockEscalation = (Microsoft.SqlServer.Management.Smo.LockEscalationType)value;
						break;
						case 61:
						this.XRuntime.Owner = (System.String)value;
						break;
						case 62:
						this.XSchema.PartitionScheme = (System.String)value;
						break;
						case 63:
						this.XSchema.QuotedIdentifierStatus = (System.Boolean)value;
						break;
						case 64:
						this.XSchema.RemoteObjectName = (System.String)value;
						break;
						case 65:
						this.XSchema.RemoteSchemaName = (System.String)value;
						break;
						case 66:
						this.XRuntime.Replicated = (System.Boolean)value;
						break;
						case 67:
						this.XRuntime.RowCount = (System.Int64)value;
						break;
						case 68:
						this.XSchema.ShardingColumnName = (System.String)value;
						break;
						case 69:
						this.XRuntime.SystemTimePeriodEndColumn = (System.String)value;
						break;
						case 70:
						this.XRuntime.SystemTimePeriodStartColumn = (System.String)value;
						break;
						case 71:
						this.XRuntime.TemporalType = (Microsoft.SqlServer.Management.Smo.TableTemporalType)value;
						break;
						case 72:
						this.XSchema.TextFileGroup = (System.String)value;
						break;
						case 73:
						this.XRuntime.TrackColumnsUpdatedEnabled = (System.Boolean)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
			}
			else
			{
				switch(index)
				{
					case 19:
					this.XSchema.AnsiNullsStatus = (System.Boolean)value;
					break;
					case 38:
					this.XRuntime.ChangeTrackingEnabled = (System.Boolean)value;
					break;
					case 0:
					this.XRuntime.CreateDate = (System.DateTime)value;
					break;
					case 77:
					this.XRuntime.DataRetentionEnabled = (System.Boolean)value;
					break;
					case 78:
					this.XRuntime.DataRetentionFilterColumnName = (System.String)value;
					break;
					case 79:
					this.XRuntime.DataRetentionPeriod = (System.Int32)value;
					break;
					case 80:
					this.XRuntime.DataRetentionPeriodUnit = (Microsoft.SqlServer.Management.Smo.DataRetentionPeriodUnit)value;
					break;
					case 53:
					this.XSchema.DataSourceName = (System.String)value;
					break;
					case 1:
					this.XRuntime.DataSpaceUsed = (System.Double)value;
					break;
					case 28:
					this.XRuntime.DateLastModified = (System.DateTime)value;
					break;
					case 50:
					this.XRuntime.Durability = (Microsoft.SqlServer.Management.Smo.DurabilityType)value;
					break;
					case 54:
					this.XSchema.ExternalTableDistribution = (Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType)value;
					break;
					case 2:
					this.XRuntime.FakeSystemTable = (System.Boolean)value;
					break;
					case 55:
					this.XSchema.FileFormatName = (System.String)value;
					break;
					case 3:
					this.XSchema.FileGroup = (System.String)value;
					break;
					case 39:
					this.XSchema.FileStreamFileGroup = (System.String)value;
					break;
					case 40:
					this.XSchema.FileStreamPartitionScheme = (System.String)value;
					break;
					case 46:
					this.XRuntime.FileTableDirectoryName = (System.String)value;
					break;
					case 47:
					this.XRuntime.FileTableNameColumnCollation = (System.String)value;
					break;
					case 48:
					this.XRuntime.FileTableNamespaceEnabled = (System.Boolean)value;
					break;
					case 20:
					this.XRuntime.HasAfterTrigger = (System.Boolean)value;
					break;
					case 41:
					this.XRuntime.HasClassifiedColumn = (System.Boolean)value;
					break;
					case 51:
					this.XRuntime.HasClusteredColumnStoreIndex = (System.Boolean)value;
					break;
					case 4:
					this.XRuntime.HasClusteredIndex = (System.Boolean)value;
					break;
					case 42:
					this.XRuntime.HasCompressedPartitions = (System.Boolean)value;
					break;
					case 21:
					this.XRuntime.HasDeleteTrigger = (System.Boolean)value;
					break;
					case 29:
					this.XRuntime.HasHeapIndex = (System.Boolean)value;
					break;
					case 22:
					this.XRuntime.HasIndex = (System.Boolean)value;
					break;
					case 23:
					this.XRuntime.HasInsertTrigger = (System.Boolean)value;
					break;
					case 24:
					this.XRuntime.HasInsteadOfTrigger = (System.Boolean)value;
					break;
					case 30:
					this.XRuntime.HasNonClusteredColumnStoreIndex = (System.Boolean)value;
					break;
					case 5:
					this.XRuntime.HasNonClusteredIndex = (System.Boolean)value;
					break;
					case 6:
					this.XRuntime.HasPrimaryClusteredIndex = (System.Boolean)value;
					break;
					case 7:
					this.XRuntime.HasSparseColumn = (System.Boolean)value;
					break;
					case 31:
					this.XRuntime.HasSpatialData = (System.Boolean)value;
					break;
					case 56:
					this.XRuntime.HasSystemTimePeriod = (System.Boolean)value;
					break;
					case 25:
					this.XRuntime.HasUpdateTrigger = (System.Boolean)value;
					break;
					case 81:
					this.XRuntime.HasXmlCompressedPartitions = (System.Boolean)value;
					break;
					case 32:
					this.XRuntime.HasXmlData = (System.Boolean)value;
					break;
					case 33:
					this.XRuntime.HasXmlIndex = (System.Boolean)value;
					break;
					case 57:
					this.XRuntime.HistoryTableID = (System.Int32)value;
					break;
					case 58:
					this.XRuntime.HistoryTableName = (System.String)value;
					break;
					case 59:
					this.XRuntime.HistoryTableSchema = (System.String)value;
					break;
					case 8:
					this.XSchema.ID = (System.Int32)value;
					break;
					case 9:
					this.XRuntime.IndexSpaceUsed = (System.Double)value;
					break;
					case 10:
					this.XRuntime.IsDroppedLedgerTable = (System.Boolean)value;
					break;
					case 11:
					this.XRuntime.IsEdge = (System.Boolean)value;
					break;
					case 60:
					this.XSchema.IsExternal = (System.Boolean)value;
					break;
					case 49:
					this.XRuntime.IsFileTable = (System.Boolean)value;
					break;
					case 26:
					this.XRuntime.IsIndexable = (System.Boolean)value;
					break;
					case 12:
					this.XRuntime.IsLedger = (System.Boolean)value;
					break;
					case 52:
					this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
					break;
					case 13:
					this.XRuntime.IsNode = (System.Boolean)value;
					break;
					case 34:
					this.XSchema.IsPartitioned = (System.Boolean)value;
					break;
					case 35:
					this.XRuntime.IsSchemaOwned = (System.Boolean)value;
					break;
					case 14:
					this.XSchema.IsSystemObject = (System.Boolean)value;
					break;
					case 61:
					this.XRuntime.IsSystemVersioned = (System.Boolean)value;
					break;
					case 36:
					this.XRuntime.IsVarDecimalStorageFormatEnabled = (System.Boolean)value;
					break;
					case 82:
					this.XRuntime.LedgerType = (Microsoft.SqlServer.Management.Smo.LedgerTableType)value;
					break;
					case 83:
					this.XRuntime.LedgerViewName = (System.String)value;
					break;
					case 84:
					this.XRuntime.LedgerViewOperationTypeColumnName = (System.String)value;
					break;
					case 85:
					this.XRuntime.LedgerViewOperationTypeDescColumnName = (System.String)value;
					break;
					case 86:
					this.XRuntime.LedgerViewSchema = (System.String)value;
					break;
					case 87:
					this.XRuntime.LedgerViewSequenceNumberColumnName = (System.String)value;
					break;
					case 88:
					this.XRuntime.LedgerViewTransactionIdColumnName = (System.String)value;
					break;
					case 62:
					this.XSchema.Location = (System.String)value;
					break;
					case 43:
					this.XRuntime.LockEscalation = (Microsoft.SqlServer.Management.Smo.LockEscalationType)value;
					break;
					case 15:
					this.XRuntime.Owner = (System.String)value;
					break;
					case 37:
					this.XSchema.PartitionScheme = (System.String)value;
					break;
					case 44:
					this.XRuntime.PolicyHealthState = (Microsoft.SqlServer.Management.Dmf.PolicyHealthState)value;
					break;
					case 27:
					this.XSchema.QuotedIdentifierStatus = (System.Boolean)value;
					break;
					case 63:
					this.XSchema.RejectSampleValue = (System.Double)value;
					break;
					case 64:
					this.XSchema.RejectType = (Microsoft.SqlServer.Management.Smo.ExternalTableRejectType)value;
					break;
					case 65:
					this.XSchema.RejectValue = (System.Double)value;
					break;
					case 66:
					this.XRuntime.RemoteDataArchiveDataMigrationState = (Microsoft.SqlServer.Management.Smo.RemoteDataArchiveMigrationState)value;
					break;
					case 67:
					this.XRuntime.RemoteDataArchiveEnabled = (System.Boolean)value;
					break;
					case 68:
					this.XRuntime.RemoteDataArchiveFilterPredicate = (System.String)value;
					break;
					case 69:
					this.XSchema.RemoteObjectName = (System.String)value;
					break;
					case 70:
					this.XSchema.RemoteSchemaName = (System.String)value;
					break;
					case 71:
					this.XRuntime.RemoteTableName = (System.String)value;
					break;
					case 72:
					this.XRuntime.RemoteTableProvisioned = (System.Boolean)value;
					break;
					case 16:
					this.XRuntime.Replicated = (System.Boolean)value;
					break;
					case 17:
					this.XRuntime.RowCount = (System.Int64)value;
					break;
					case 73:
					this.XSchema.ShardingColumnName = (System.String)value;
					break;
					case 74:
					this.XRuntime.SystemTimePeriodEndColumn = (System.String)value;
					break;
					case 75:
					this.XRuntime.SystemTimePeriodStartColumn = (System.String)value;
					break;
					case 76:
					this.XRuntime.TemporalType = (Microsoft.SqlServer.Management.Smo.TableTemporalType)value;
					break;
					case 18:
					this.XSchema.TextFileGroup = (System.String)value;
					break;
					case 45:
					this.XRuntime.TrackColumnsUpdatedEnabled = (System.Boolean)value;
					break;
					default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		XSchemaProps _XSchema;
		XSchemaProps XSchema 
		{
			get
			{
				if( _XSchema == null )
				{
					_XSchema = new XSchemaProps();
				}
				return _XSchema; 
			}
		}
		XRuntimeProps _XRuntime;
		XRuntimeProps XRuntime
		{
			get
			{
				if( _XRuntime == null )
				{
					_XRuntime = new XRuntimeProps();
				}
				return _XRuntime;
			}
		}

		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ChangeTrackingEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ChangeTrackingEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ChangeTrackingEnabled", value);
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean DataRetentionEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DataRetentionEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataRetentionEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String DataRetentionFilterColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DataRetentionFilterColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataRetentionFilterColumnName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 DataRetentionPeriod
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("DataRetentionPeriod");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataRetentionPeriod", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DataRetentionPeriodUnit DataRetentionPeriodUnit
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DataRetentionPeriodUnit)this.Properties.GetValueWithNullReplacement("DataRetentionPeriodUnit");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataRetentionPeriodUnit", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(ExternalDataSource),"Server[@Name = '{0}']/Database[@Name = '{1}']/ExternalDataSource[@Name='{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","DataSourceName")]
		[CLSCompliant(false)]
		public System.String DataSourceName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DataSourceName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataSourceName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double DataSpaceUsed
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("DataSpaceUsed");
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DurabilityType Durability
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DurabilityType)this.Properties.GetValueWithNullReplacement("Durability");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Durability", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType ExternalTableDistribution
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalTableDistributionType)this.Properties.GetValueWithNullReplacement("ExternalTableDistribution");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExternalTableDistribution", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean FakeSystemTable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("FakeSystemTable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(ExternalFileFormat),"Server[@Name = '{0}']/Database[@Name = '{1}']/ExternalFileFormat[@Name='{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","FileFormatName")]
		[CLSCompliant(false)]
		public System.String FileFormatName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileFormatName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileFormatName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileStreamFileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileStreamFileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileStreamFileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(PartitionScheme),"Server[@Name='{0}']/Database[@Name='{1}']/PartitionScheme[@Name='{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","FileStreamPartitionScheme")]
		[CLSCompliant(false)]
		public System.String FileStreamPartitionScheme
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileStreamPartitionScheme");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileStreamPartitionScheme", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileTableDirectoryName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileTableDirectoryName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileTableDirectoryName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileTableNameColumnCollation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileTableNameColumnCollation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileTableNameColumnCollation", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean FileTableNamespaceEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("FileTableNamespaceEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileTableNamespaceEnabled", value);
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasClassifiedColumn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasClassifiedColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasClusteredColumnStoreIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasClusteredColumnStoreIndex");
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean HasCompressedPartitions
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasCompressedPartitions");
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
		public System.Boolean HasHeapIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasHeapIndex");
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
		public System.Boolean HasNonClusteredColumnStoreIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasNonClusteredColumnStoreIndex");
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasSparseColumn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasSparseColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasSpatialData
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasSpatialData");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasSystemTimePeriod
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasSystemTimePeriod");
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean HasXmlCompressedPartitions
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasXmlCompressedPartitions");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasXmlData
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasXmlData");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasXmlIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasXmlIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 HistoryTableID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("HistoryTableID");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String HistoryTableName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HistoryTableName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HistoryTableName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String HistoryTableSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HistoryTableSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HistoryTableSchema", value);
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double IndexSpaceUsed
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("IndexSpaceUsed");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDroppedLedgerTable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDroppedLedgerTable");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsExternal
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsExternal");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsExternal", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFileTable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFileTable");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsFileTable", value);
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsLedger
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsLedger");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsLedger", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsMemoryOptimized
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMemoryOptimized");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsMemoryOptimized", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsPartitioned
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPartitioned");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemVersioned
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemVersioned");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSystemVersioned", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.LedgerTableType LedgerType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.LedgerTableType)this.Properties.GetValueWithNullReplacement("LedgerType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LedgerViewName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LedgerViewName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LedgerViewOperationTypeColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LedgerViewOperationTypeColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewOperationTypeColumnName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LedgerViewOperationTypeDescColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LedgerViewOperationTypeDescColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewOperationTypeDescColumnName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LedgerViewSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LedgerViewSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewSchema", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LedgerViewSequenceNumberColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LedgerViewSequenceNumberColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewSequenceNumberColumnName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String LedgerViewTransactionIdColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LedgerViewTransactionIdColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LedgerViewTransactionIdColumnName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String Location
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Location");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Location", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.LockEscalationType LockEscalation
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.LockEscalationType)this.Properties.GetValueWithNullReplacement("LockEscalation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LockEscalation", value);
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(PartitionScheme),"Server[@Name='{0}']/Database[@Name='{1}']/PartitionScheme[@Name='{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","PartitionScheme")]
		[CLSCompliant(false)]
		public System.String PartitionScheme
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PartitionScheme");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PartitionScheme", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double RejectSampleValue
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("RejectSampleValue");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RejectSampleValue", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalTableRejectType RejectType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalTableRejectType)this.Properties.GetValueWithNullReplacement("RejectType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RejectType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double RejectValue
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("RejectValue");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RejectValue", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.RemoteDataArchiveMigrationState RemoteDataArchiveDataMigrationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.RemoteDataArchiveMigrationState)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveDataMigrationState");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveDataMigrationState", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean RemoteDataArchiveEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String RemoteDataArchiveFilterPredicate
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveFilterPredicate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveFilterPredicate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String RemoteObjectName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteObjectName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteObjectName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String RemoteSchemaName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteSchemaName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteSchemaName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String RemoteTableName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteTableName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteTableName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.Boolean RemoteTableProvisioned
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("RemoteTableProvisioned");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteTableProvisioned", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Replicated
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Replicated");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 RowCount
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("RowCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ShardingColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ShardingColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ShardingColumnName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SystemTimePeriodEndColumn
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SystemTimePeriodEndColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SystemTimePeriodStartColumn
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SystemTimePeriodStartColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.TableTemporalType TemporalType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.TableTemporalType)this.Properties.GetValueWithNullReplacement("TemporalType");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String TextFileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("TextFileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TextFileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean TrackColumnsUpdatedEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("TrackColumnsUpdatedEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TrackColumnsUpdatedEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase)]
		[SfcReference(typeof(ExternalFileFormat),"Server[@Name = '{0}']/Database[@Name = '{1}']/ExternalFileFormat[@Name='{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","FileFormatNameOd")]
		[CLSCompliant(false)]
		public System.String FileFormatNameOd
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileFormatNameOd");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.Int32 HistoryRetentionPeriod
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("HistoryRetentionPeriod");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HistoryRetentionPeriod", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public Microsoft.SqlServer.Management.Smo.TemporalHistoryRetentionPeriodUnit HistoryRetentionPeriodUnit
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.TemporalHistoryRetentionPeriodUnit)this.Properties.GetValueWithNullReplacement("HistoryRetentionPeriodUnit");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HistoryRetentionPeriodUnit", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase)]
		public System.String LocationOd
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LocationOd");
			}
		}
		[SfcProperty]
		public Microsoft.SqlServer.Management.Smo.DwTableDistributionType DwTableDistribution
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DwTableDistributionType)this.Properties.GetValueWithNullReplacement("DwTableDistribution");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DwTableDistribution", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation)]
		public System.String RejectedRowLocation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RejectedRowLocation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RejectedRowLocation", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "AnsiNullsStatus", "Durability", "FileGroup", "FileTableNameColumnCollation", "IsEdge", "IsFileTable", "IsLedger", "IsMemoryOptimized", "IsNode", "LedgerType", "LedgerViewName", "LedgerViewOperationTypeColumnName", "LedgerViewOperationTypeDescColumnName", "LedgerViewSchema", "LedgerViewSequenceNumberColumnName", "LedgerViewTransactionIdColumnName", "PartitionScheme", "QuotedIdentifierStatus", "RemoteTableName", "RemoteTableProvisioned", "TextFileGroup", "RejectedRowLocation" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "HasCompressedPartitions":
					return false;
				case "HasXmlCompressedPartitions":
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
		

      private TableEvents events;
      public TableEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new TableEvents(this);
              }
              return this.events;
          }
      }
    
	}







      public class TableEvents
      {
      internal TableEvents(Table parent)
      {
          this.parent = parent;
      }

      public TableEventSet GetEventSelection()
      {
          InitializeEvents();
          return (TableEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(TableEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(TableEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(TableEventSet events)
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
              serverEventsWorker = new TableEventsWorker(parent);

          }
      }

      private TableEventsWorker serverEventsWorker;
      private Table parent;
      }
    
}
