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
	/// Instance class encapsulating : Server[@Name='']/Database
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Database  : ISfcSupportsDesignMode, IPropertyDataDispatch
	{
		public Database() : base(){ }
		public Database(Server server, string name) : base()
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
							case "AnsiNullDefault": return 0;
							case "AnsiNullsEnabled": return 1;
							case "AnsiPaddingEnabled": return 2;
							case "AnsiWarningsEnabled": return 3;
							case "ArithmeticAbortEnabled": return 4;
							case "AutoCreateIncrementalStatisticsEnabled": return 5;
							case "AutoCreateStatisticsEnabled": return 6;
							case "AutoShrink": return 7;
							case "AutoUpdateStatisticsAsync": return 8;
							case "AutoUpdateStatisticsEnabled": return 9;
							case "AzureEdition": return 10;
							case "AzureServiceObjective": return 11;
							case "CaseSensitive": return 12;
							case "CloseCursorsOnCommitEnabled": return 13;
							case "Collation": return 14;
							case "CompatibilityLevel": return 15;
							case "ConcatenateNullYieldsNull": return 16;
							case "CreateDate": return 17;
							case "DatabaseOwnershipChaining": return 18;
							case "DatabaseSnapshotBaseName": return 19;
							case "DateCorrelationOptimization": return 20;
							case "DboLogin": return 21;
							case "DefaultFileGroup": return 22;
							case "DefaultSchema": return 23;
							case "EncryptionEnabled": return 24;
							case "HonorBrokerPriority": return 25;
							case "ID": return 26;
							case "IsAccessible": return 27;
							case "IsDatabaseSnapshot": return 28;
							case "IsDatabaseSnapshotBase": return 29;
							case "IsDbAccessAdmin": return 30;
							case "IsDbBackupOperator": return 31;
							case "IsDbDatareader": return 32;
							case "IsDbDatawriter": return 33;
							case "IsDbDdlAdmin": return 34;
							case "IsDbDenyDatareader": return 35;
							case "IsDbDenyDatawriter": return 36;
							case "IsDbManager": return 37;
							case "IsDbOwner": return 38;
							case "IsDbSecurityAdmin": return 39;
							case "IsFabricDatabase": return 40;
							case "IsFullTextEnabled": return 41;
							case "IsLoginManager": return 42;
							case "IsMaxSizeApplicable": return 43;
							case "IsMirroringEnabled": return 44;
							case "IsParameterizationForced": return 45;
							case "IsReadCommittedSnapshotOn": return 46;
							case "IsSqlDw": return 47;
							case "IsSystemObject": return 48;
							case "IsUpdateable": return 49;
							case "LastGoodCheckDbTime": return 50;
							case "MaxSizeInBytes": return 51;
							case "NumericRoundAbortEnabled": return 52;
							case "Owner": return 53;
							case "QuotedIdentifiersEnabled": return 54;
							case "ReadOnly": return 55;
							case "RealEngineEdition": return 56;
							case "RecursiveTriggersEnabled": return 57;
							case "ReplicationOptions": return 58;
							case "ServiceBrokerGuid": return 59;
							case "Size": return 60;
							case "SnapshotIsolationState": return 61;
							case "SpaceAvailable": return 62;
							case "Status": return 63;
							case "Trustworthy": return 64;
							case "UserAccess": return 65;
							case "UserName": return 66;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiNullDefault": return 0;
							case "AnsiNullsEnabled": return 1;
							case "AnsiPaddingEnabled": return 2;
							case "AnsiWarningsEnabled": return 3;
							case "ArithmeticAbortEnabled": return 4;
							case "AutoCreateIncrementalStatisticsEnabled": return 5;
							case "AutoCreateStatisticsEnabled": return 6;
							case "AutoShrink": return 7;
							case "AutoUpdateStatisticsAsync": return 8;
							case "AutoUpdateStatisticsEnabled": return 9;
							case "AzureEdition": return 10;
							case "AzureServiceObjective": return 11;
							case "CaseSensitive": return 12;
							case "CatalogCollation": return 13;
							case "ChangeTrackingAutoCleanUp": return 14;
							case "ChangeTrackingEnabled": return 15;
							case "ChangeTrackingRetentionPeriod": return 16;
							case "ChangeTrackingRetentionPeriodUnits": return 17;
							case "CloseCursorsOnCommitEnabled": return 18;
							case "Collation": return 19;
							case "CompatibilityLevel": return 20;
							case "ConcatenateNullYieldsNull": return 21;
							case "CreateDate": return 22;
							case "DatabaseOwnershipChaining": return 23;
							case "DatabaseSnapshotBaseName": return 24;
							case "DateCorrelationOptimization": return 25;
							case "DboLogin": return 26;
							case "DefaultFileGroup": return 27;
							case "DefaultFullTextCatalog": return 28;
							case "DefaultSchema": return 29;
							case "EncryptionEnabled": return 30;
							case "HasFileInCloud": return 31;
							case "HasMemoryOptimizedObjects": return 32;
							case "HonorBrokerPriority": return 33;
							case "ID": return 34;
							case "IsAccessible": return 35;
							case "IsDatabaseSnapshot": return 36;
							case "IsDatabaseSnapshotBase": return 37;
							case "IsDbAccessAdmin": return 38;
							case "IsDbBackupOperator": return 39;
							case "IsDbDatareader": return 40;
							case "IsDbDatawriter": return 41;
							case "IsDbDdlAdmin": return 42;
							case "IsDbDenyDatareader": return 43;
							case "IsDbDenyDatawriter": return 44;
							case "IsDbManager": return 45;
							case "IsDbOwner": return 46;
							case "IsDbSecurityAdmin": return 47;
							case "IsFabricDatabase": return 48;
							case "IsFullTextEnabled": return 49;
							case "IsLedger": return 50;
							case "IsLoginManager": return 51;
							case "IsMaxSizeApplicable": return 52;
							case "IsMirroringEnabled": return 53;
							case "IsParameterizationForced": return 54;
							case "IsReadCommittedSnapshotOn": return 55;
							case "IsSqlDw": return 56;
							case "IsSqlDwEdition": return 57;
							case "IsSystemObject": return 58;
							case "IsUpdateable": return 59;
							case "LastGoodCheckDbTime": return 60;
							case "LegacyCardinalityEstimation": return 61;
							case "LegacyCardinalityEstimationForSecondary": return 62;
							case "MaxDop": return 63;
							case "MaxDopForSecondary": return 64;
							case "MaxSizeInBytes": return 65;
							case "MemoryAllocatedToMemoryOptimizedObjectsInKB": return 66;
							case "MemoryUsedByMemoryOptimizedObjectsInKB": return 67;
							case "NumericRoundAbortEnabled": return 68;
							case "Owner": return 69;
							case "ParameterSniffing": return 70;
							case "ParameterSniffingForSecondary": return 71;
							case "QueryOptimizerHotfixes": return 72;
							case "QueryOptimizerHotfixesForSecondary": return 73;
							case "QuotedIdentifiersEnabled": return 74;
							case "ReadOnly": return 75;
							case "RealEngineEdition": return 76;
							case "RecursiveTriggersEnabled": return 77;
							case "ReplicationOptions": return 78;
							case "ServiceBrokerGuid": return 79;
							case "Size": return 80;
							case "SnapshotIsolationState": return 81;
							case "SpaceAvailable": return 82;
							case "Status": return 83;
							case "TemporalHistoryRetentionEnabled": return 84;
							case "Trustworthy": return 85;
							case "UserAccess": return 86;
							case "UserName": return 87;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ActiveConnections": return 0;
						case "AutoClose": return 1;
						case "AutoShrink": return 2;
						case "CompatibilityLevel": return 3;
						case "CreateDate": return 4;
						case "DataSpaceUsage": return 5;
						case "DboLogin": return 6;
						case "DefaultFileGroup": return 7;
						case "DefaultSchema": return 8;
						case "ID": return 9;
						case "IndexSpaceUsage": return 10;
						case "IsAccessible": return 11;
						case "IsDbAccessAdmin": return 12;
						case "IsDbBackupOperator": return 13;
						case "IsDbDatareader": return 14;
						case "IsDbDatawriter": return 15;
						case "IsDbDdlAdmin": return 16;
						case "IsDbDenyDatareader": return 17;
						case "IsDbDenyDatawriter": return 18;
						case "IsDbOwner": return 19;
						case "IsDbSecurityAdmin": return 20;
						case "IsFabricDatabase": return 21;
						case "IsFullTextEnabled": return 22;
						case "IsMirroringEnabled": return 23;
						case "IsSqlDw": return 24;
						case "IsSystemObject": return 25;
						case "Owner": return 26;
						case "PrimaryFilePath": return 27;
						case "ReplicationOptions": return 28;
						case "Size": return 29;
						case "SpaceAvailable": return 30;
						case "Status": return 31;
						case "UserName": return 32;
						case "AnsiNullDefault": return 33;
						case "AnsiNullsEnabled": return 34;
						case "AnsiPaddingEnabled": return 35;
						case "AnsiWarningsEnabled": return 36;
						case "ArithmeticAbortEnabled": return 37;
						case "AutoCreateStatisticsEnabled": return 38;
						case "AutoUpdateStatisticsEnabled": return 39;
						case "CaseSensitive": return 40;
						case "CloseCursorsOnCommitEnabled": return 41;
						case "Collation": return 42;
						case "ConcatenateNullYieldsNull": return 43;
						case "DatabaseOwnershipChaining": return 44;
						case "IsUpdateable": return 45;
						case "LastBackupDate": return 46;
						case "LastDifferentialBackupDate": return 47;
						case "LastGoodCheckDbTime": return 48;
						case "LastLogBackupDate": return 49;
						case "LocalCursorsDefault": return 50;
						case "NumericRoundAbortEnabled": return 51;
						case "PageVerify": return 52;
						case "QuotedIdentifiersEnabled": return 53;
						case "ReadOnly": return 54;
						case "RecoveryModel": return 55;
						case "RecursiveTriggersEnabled": return 56;
						case "UserAccess": return 57;
						case "Version": return 58;
						case "AutoUpdateStatisticsAsync": return 59;
						case "BrokerEnabled": return 60;
						case "DatabaseGuid": return 61;
						case "DatabaseSnapshotBaseName": return 62;
						case "DateCorrelationOptimization": return 63;
						case "DefaultFullTextCatalog": return 64;
						case "HasFullBackup": return 65;
						case "IsDatabaseSnapshot": return 66;
						case "IsDatabaseSnapshotBase": return 67;
						case "IsMailHost": return 68;
						case "IsParameterizationForced": return 69;
						case "IsReadCommittedSnapshotOn": return 70;
						case "IsVarDecimalStorageFormatEnabled": return 71;
						case "LogReuseWaitStatus": return 72;
						case "MirroringFailoverLogSequenceNumber": return 73;
						case "MirroringID": return 74;
						case "MirroringPartner": return 75;
						case "MirroringPartnerInstance": return 76;
						case "MirroringRedoQueueMaxSize": return 77;
						case "MirroringRole": return 78;
						case "MirroringRoleSequence": return 79;
						case "MirroringSafetyLevel": return 80;
						case "MirroringSafetySequence": return 81;
						case "MirroringStatus": return 82;
						case "MirroringTimeout": return 83;
						case "MirroringWitness": return 84;
						case "MirroringWitnessStatus": return 85;
						case "RecoveryForkGuid": return 86;
						case "ServiceBrokerGuid": return 87;
						case "SnapshotIsolationState": return 88;
						case "Trustworthy": return 89;
						case "ChangeTrackingAutoCleanUp": return 90;
						case "ChangeTrackingEnabled": return 91;
						case "ChangeTrackingRetentionPeriod": return 92;
						case "ChangeTrackingRetentionPeriodUnits": return 93;
						case "DefaultFileStreamFileGroup": return 94;
						case "EncryptionEnabled": return 95;
						case "HasDatabaseEncryptionKey": return 96;
						case "HonorBrokerPriority": return 97;
						case "IsManagementDataWarehouse": return 98;
						case "PolicyHealthState": return 99;
						case "AvailabilityDatabaseSynchronizationState": return 100;
						case "AvailabilityGroupName": return 101;
						case "ContainmentType": return 102;
						case "DefaultFullTextLanguageLcid": return 103;
						case "DefaultFullTextLanguageName": return 104;
						case "DefaultLanguageLcid": return 105;
						case "DefaultLanguageName": return 106;
						case "FilestreamDirectoryName": return 107;
						case "FilestreamNonTransactedAccess": return 108;
						case "NestedTriggersEnabled": return 109;
						case "TargetRecoveryTime": return 110;
						case "TransformNoiseWords": return 111;
						case "TwoDigitYearCutoff": return 112;
						case "AutoCreateIncrementalStatisticsEnabled": return 113;
						case "DelayedDurability": return 114;
						case "HasFileInCloud": return 115;
						case "HasMemoryOptimizedObjects": return 116;
						case "MemoryAllocatedToMemoryOptimizedObjectsInKB": return 117;
						case "MemoryUsedByMemoryOptimizedObjectsInKB": return 118;
						case "LegacyCardinalityEstimation": return 119;
						case "LegacyCardinalityEstimationForSecondary": return 120;
						case "MaxDop": return 121;
						case "MaxDopForSecondary": return 122;
						case "ParameterSniffing": return 123;
						case "ParameterSniffingForSecondary": return 124;
						case "QueryOptimizerHotfixes": return 125;
						case "QueryOptimizerHotfixesForSecondary": return 126;
						case "RemoteDataArchiveCredential": return 127;
						case "RemoteDataArchiveEnabled": return 128;
						case "RemoteDataArchiveEndpoint": return 129;
						case "RemoteDataArchiveLinkedServer": return 130;
						case "RemoteDataArchiveUseFederatedServiceAccount": return 131;
						case "RemoteDatabaseName": return 132;
						case "AcceleratedRecoveryEnabled": return 133;
						case "CatalogCollation": return 134;
						case "DataRetentionEnabled": return 135;
						case "PersistentVersionStoreFileGroup": return 136;
						case "PersistentVersionStoreSizeKB": return 137;
						case "IsLedger": return 138;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 33, 59, 90, 100, 100, 113, 119, 133, 133, 138, 139, 139 };
			static int [] cloudVersionCount = new int [] { 0, 0, 88 };
			static int sqlDwPropertyCount = 67;
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
				new StaticMetadata("AnsiNullDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiPaddingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarningsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ArithmeticAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateIncrementalStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoShrink", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsAsync", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AzureEdition", false, false, typeof(System.String)),
				new StaticMetadata("AzureServiceObjective", false, false, typeof(System.String)),
				new StaticMetadata("CaseSensitive", true, true, typeof(System.Boolean)),
				new StaticMetadata("CloseCursorsOnCommitEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Collation", true, false, typeof(System.String)),
				new StaticMetadata("CompatibilityLevel", true, false, typeof(Microsoft.SqlServer.Management.Smo.CompatibilityLevel)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DatabaseOwnershipChaining", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseSnapshotBaseName", false, false, typeof(System.String)),
				new StaticMetadata("DateCorrelationOptimization", false, false, typeof(System.Boolean)),
				new StaticMetadata("DboLogin", true, true, typeof(System.Boolean)),
				new StaticMetadata("DefaultFileGroup", true, true, typeof(System.String)),
				new StaticMetadata("DefaultSchema", true, false, typeof(System.String)),
				new StaticMetadata("EncryptionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("HonorBrokerPriority", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsAccessible", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDatabaseSnapshot", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDatabaseSnapshotBase", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbAccessAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbBackupOperator", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDatareader", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDatawriter", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDdlAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDenyDatareader", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDenyDatawriter", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbManager", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbOwner", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbSecurityAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsFabricDatabase", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsLoginManager", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsMaxSizeApplicable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsMirroringEnabled", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsParameterizationForced", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsReadCommittedSnapshotOn", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSqlDw", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsUpdateable", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastGoodCheckDbTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("MaxSizeInBytes", false, false, typeof(System.Double)),
				new StaticMetadata("NumericRoundAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Owner", true, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifiersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("RealEngineEdition", false, true, typeof(System.Int32)),
				new StaticMetadata("RecursiveTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReplicationOptions", false, true, typeof(Microsoft.SqlServer.Management.Smo.ReplicationOptions)),
				new StaticMetadata("ServiceBrokerGuid", false, true, typeof(System.Guid)),
				new StaticMetadata("Size", false, true, typeof(System.Double)),
				new StaticMetadata("SnapshotIsolationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)),
				new StaticMetadata("SpaceAvailable", true, true, typeof(System.Double)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.DatabaseStatus)),
				new StaticMetadata("Trustworthy", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)),
				new StaticMetadata("UserName", true, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiNullDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiPaddingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarningsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ArithmeticAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateIncrementalStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoShrink", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsAsync", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AzureEdition", false, false, typeof(System.String)),
				new StaticMetadata("AzureServiceObjective", false, false, typeof(System.String)),
				new StaticMetadata("CaseSensitive", true, true, typeof(System.Boolean)),
				new StaticMetadata("CatalogCollation", false, false, typeof(Microsoft.SqlServer.Management.Smo.CatalogCollationType)),
				new StaticMetadata("ChangeTrackingAutoCleanUp", false, false, typeof(System.Boolean)),
				new StaticMetadata("ChangeTrackingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ChangeTrackingRetentionPeriod", false, false, typeof(System.Int32)),
				new StaticMetadata("ChangeTrackingRetentionPeriodUnits", false, false, typeof(Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits)),
				new StaticMetadata("CloseCursorsOnCommitEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Collation", true, false, typeof(System.String)),
				new StaticMetadata("CompatibilityLevel", true, false, typeof(Microsoft.SqlServer.Management.Smo.CompatibilityLevel)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DatabaseOwnershipChaining", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseSnapshotBaseName", false, false, typeof(System.String)),
				new StaticMetadata("DateCorrelationOptimization", false, false, typeof(System.Boolean)),
				new StaticMetadata("DboLogin", true, true, typeof(System.Boolean)),
				new StaticMetadata("DefaultFileGroup", true, true, typeof(System.String)),
				new StaticMetadata("DefaultFullTextCatalog", true, false, typeof(System.String)),
				new StaticMetadata("DefaultSchema", true, false, typeof(System.String)),
				new StaticMetadata("EncryptionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("HasFileInCloud", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasMemoryOptimizedObjects", true, true, typeof(System.Boolean)),
				new StaticMetadata("HonorBrokerPriority", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsAccessible", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDatabaseSnapshot", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDatabaseSnapshotBase", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbAccessAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbBackupOperator", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDatareader", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDatawriter", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDdlAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDenyDatareader", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDenyDatawriter", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbManager", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbOwner", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbSecurityAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsFabricDatabase", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsLedger", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsLoginManager", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsMaxSizeApplicable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsMirroringEnabled", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsParameterizationForced", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsReadCommittedSnapshotOn", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSqlDw", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSqlDwEdition", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsUpdateable", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastGoodCheckDbTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LegacyCardinalityEstimation", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("LegacyCardinalityEstimationForSecondary", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("MaxDop", false, false, typeof(System.Int32)),
				new StaticMetadata("MaxDopForSecondary", false, false, typeof(System.Int32)),
				new StaticMetadata("MaxSizeInBytes", false, false, typeof(System.Double)),
				new StaticMetadata("MemoryAllocatedToMemoryOptimizedObjectsInKB", true, true, typeof(System.Double)),
				new StaticMetadata("MemoryUsedByMemoryOptimizedObjectsInKB", true, true, typeof(System.Double)),
				new StaticMetadata("NumericRoundAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Owner", true, false, typeof(System.String)),
				new StaticMetadata("ParameterSniffing", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("ParameterSniffingForSecondary", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("QueryOptimizerHotfixes", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("QueryOptimizerHotfixesForSecondary", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("QuotedIdentifiersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("RealEngineEdition", false, true, typeof(System.Int32)),
				new StaticMetadata("RecursiveTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReplicationOptions", false, true, typeof(Microsoft.SqlServer.Management.Smo.ReplicationOptions)),
				new StaticMetadata("ServiceBrokerGuid", false, true, typeof(System.Guid)),
				new StaticMetadata("Size", false, true, typeof(System.Double)),
				new StaticMetadata("SnapshotIsolationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)),
				new StaticMetadata("SpaceAvailable", true, true, typeof(System.Double)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.DatabaseStatus)),
				new StaticMetadata("TemporalHistoryRetentionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Trustworthy", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)),
				new StaticMetadata("UserName", true, true, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ActiveConnections", true, true, typeof(System.Int32)),
				new StaticMetadata("AutoClose", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoShrink", false, false, typeof(System.Boolean)),
				new StaticMetadata("CompatibilityLevel", true, false, typeof(Microsoft.SqlServer.Management.Smo.CompatibilityLevel)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataSpaceUsage", true, true, typeof(System.Double)),
				new StaticMetadata("DboLogin", true, true, typeof(System.Boolean)),
				new StaticMetadata("DefaultFileGroup", true, true, typeof(System.String)),
				new StaticMetadata("DefaultSchema", true, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IndexSpaceUsage", true, true, typeof(System.Double)),
				new StaticMetadata("IsAccessible", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbAccessAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbBackupOperator", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDatareader", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDatawriter", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDdlAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDenyDatareader", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbDenyDatawriter", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbOwner", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsDbSecurityAdmin", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsFabricDatabase", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsMirroringEnabled", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsSqlDw", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Owner", false, true, typeof(System.String)),
				new StaticMetadata("PrimaryFilePath", true, true, typeof(System.String)),
				new StaticMetadata("ReplicationOptions", false, true, typeof(Microsoft.SqlServer.Management.Smo.ReplicationOptions)),
				new StaticMetadata("Size", true, true, typeof(System.Double)),
				new StaticMetadata("SpaceAvailable", true, true, typeof(System.Double)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.DatabaseStatus)),
				new StaticMetadata("UserName", true, true, typeof(System.String)),
				new StaticMetadata("AnsiNullDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiPaddingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarningsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ArithmeticAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("CaseSensitive", true, true, typeof(System.Boolean)),
				new StaticMetadata("CloseCursorsOnCommitEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Collation", true, false, typeof(System.String)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseOwnershipChaining", true, false, typeof(System.Boolean)),
				new StaticMetadata("IsUpdateable", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastBackupDate", true, true, typeof(System.DateTime)),
				new StaticMetadata("LastDifferentialBackupDate", true, true, typeof(System.DateTime)),
				new StaticMetadata("LastGoodCheckDbTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastLogBackupDate", true, true, typeof(System.DateTime)),
				new StaticMetadata("LocalCursorsDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericRoundAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PageVerify", false, false, typeof(Microsoft.SqlServer.Management.Smo.PageVerify)),
				new StaticMetadata("QuotedIdentifiersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("RecoveryModel", false, false, typeof(Microsoft.SqlServer.Management.Smo.RecoveryModel)),
				new StaticMetadata("RecursiveTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)),
				new StaticMetadata("Version", true, true, typeof(System.Int32)),
				new StaticMetadata("AutoUpdateStatisticsAsync", false, false, typeof(System.Boolean)),
				new StaticMetadata("BrokerEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseGuid", false, true, typeof(System.Guid)),
				new StaticMetadata("DatabaseSnapshotBaseName", false, false, typeof(System.String)),
				new StaticMetadata("DateCorrelationOptimization", false, false, typeof(System.Boolean)),
				new StaticMetadata("DefaultFullTextCatalog", true, false, typeof(System.String)),
				new StaticMetadata("HasFullBackup", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDatabaseSnapshot", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDatabaseSnapshotBase", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsMailHost", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsParameterizationForced", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsReadCommittedSnapshotOn", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsVarDecimalStorageFormatEnabled", true, false, typeof(System.Boolean)),
				new StaticMetadata("LogReuseWaitStatus", false, true, typeof(Microsoft.SqlServer.Management.Smo.LogReuseWaitStatus)),
				new StaticMetadata("MirroringFailoverLogSequenceNumber", true, true, typeof(System.Decimal)),
				new StaticMetadata("MirroringID", true, true, typeof(System.Guid)),
				new StaticMetadata("MirroringPartner", true, false, typeof(System.String)),
				new StaticMetadata("MirroringPartnerInstance", true, true, typeof(System.String)),
				new StaticMetadata("MirroringRedoQueueMaxSize", true, true, typeof(System.Int32)),
				new StaticMetadata("MirroringRole", true, true, typeof(Microsoft.SqlServer.Management.Smo.MirroringRole)),
				new StaticMetadata("MirroringRoleSequence", true, true, typeof(System.Int32)),
				new StaticMetadata("MirroringSafetyLevel", true, false, typeof(Microsoft.SqlServer.Management.Smo.MirroringSafetyLevel)),
				new StaticMetadata("MirroringSafetySequence", true, true, typeof(System.Int32)),
				new StaticMetadata("MirroringStatus", true, true, typeof(Microsoft.SqlServer.Management.Smo.MirroringStatus)),
				new StaticMetadata("MirroringTimeout", true, false, typeof(System.Int32)),
				new StaticMetadata("MirroringWitness", true, false, typeof(System.String)),
				new StaticMetadata("MirroringWitnessStatus", true, true, typeof(Microsoft.SqlServer.Management.Smo.MirroringWitnessStatus)),
				new StaticMetadata("RecoveryForkGuid", false, true, typeof(System.Guid)),
				new StaticMetadata("ServiceBrokerGuid", false, true, typeof(System.Guid)),
				new StaticMetadata("SnapshotIsolationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)),
				new StaticMetadata("Trustworthy", false, false, typeof(System.Boolean)),
				new StaticMetadata("ChangeTrackingAutoCleanUp", false, false, typeof(System.Boolean)),
				new StaticMetadata("ChangeTrackingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ChangeTrackingRetentionPeriod", false, false, typeof(System.Int32)),
				new StaticMetadata("ChangeTrackingRetentionPeriodUnits", false, false, typeof(Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits)),
				new StaticMetadata("DefaultFileStreamFileGroup", true, true, typeof(System.String)),
				new StaticMetadata("EncryptionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("HasDatabaseEncryptionKey", true, true, typeof(System.Boolean)),
				new StaticMetadata("HonorBrokerPriority", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsManagementDataWarehouse", true, true, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("AvailabilityDatabaseSynchronizationState", true, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState)),
				new StaticMetadata("AvailabilityGroupName", true, true, typeof(System.String)),
				new StaticMetadata("ContainmentType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ContainmentType)),
				new StaticMetadata("DefaultFullTextLanguageLcid", false, false, typeof(System.Int32)),
				new StaticMetadata("DefaultFullTextLanguageName", false, false, typeof(System.String)),
				new StaticMetadata("DefaultLanguageLcid", false, false, typeof(System.Int32)),
				new StaticMetadata("DefaultLanguageName", false, false, typeof(System.String)),
				new StaticMetadata("FilestreamDirectoryName", false, false, typeof(System.String)),
				new StaticMetadata("FilestreamNonTransactedAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.FilestreamNonTransactedAccessType)),
				new StaticMetadata("NestedTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("TargetRecoveryTime", false, false, typeof(System.Int32)),
				new StaticMetadata("TransformNoiseWords", false, false, typeof(System.Boolean)),
				new StaticMetadata("TwoDigitYearCutoff", false, false, typeof(System.Int32)),
				new StaticMetadata("AutoCreateIncrementalStatisticsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("DelayedDurability", false, false, typeof(Microsoft.SqlServer.Management.Smo.DelayedDurability)),
				new StaticMetadata("HasFileInCloud", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasMemoryOptimizedObjects", true, true, typeof(System.Boolean)),
				new StaticMetadata("MemoryAllocatedToMemoryOptimizedObjectsInKB", true, true, typeof(System.Double)),
				new StaticMetadata("MemoryUsedByMemoryOptimizedObjectsInKB", true, true, typeof(System.Double)),
				new StaticMetadata("LegacyCardinalityEstimation", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("LegacyCardinalityEstimationForSecondary", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("MaxDop", false, false, typeof(System.Int32)),
				new StaticMetadata("MaxDopForSecondary", false, false, typeof(System.Int32)),
				new StaticMetadata("ParameterSniffing", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("ParameterSniffingForSecondary", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("QueryOptimizerHotfixes", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("QueryOptimizerHotfixesForSecondary", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)),
				new StaticMetadata("RemoteDataArchiveCredential", true, false, typeof(System.String)),
				new StaticMetadata("RemoteDataArchiveEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("RemoteDataArchiveEndpoint", true, false, typeof(System.String)),
				new StaticMetadata("RemoteDataArchiveLinkedServer", true, false, typeof(System.String)),
				new StaticMetadata("RemoteDataArchiveUseFederatedServiceAccount", true, false, typeof(System.Boolean)),
				new StaticMetadata("RemoteDatabaseName", true, false, typeof(System.String)),
				new StaticMetadata("AcceleratedRecoveryEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("CatalogCollation", false, false, typeof(Microsoft.SqlServer.Management.Smo.CatalogCollationType)),
				new StaticMetadata("DataRetentionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PersistentVersionStoreFileGroup", true, false, typeof(System.String)),
				new StaticMetadata("PersistentVersionStoreSizeKB", true, true, typeof(System.Int64)),
				new StaticMetadata("IsLedger", false, false, typeof(System.Boolean)),
			};
		}
		private sealed class XSchemaProps
		{
			private Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState _AvailabilityDatabaseSynchronizationState;
			internal Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState AvailabilityDatabaseSynchronizationState { get{ return _AvailabilityDatabaseSynchronizationState; } set{ _AvailabilityDatabaseSynchronizationState=value; } }

			private System.String _AvailabilityGroupName;
			internal System.String AvailabilityGroupName { get{ return _AvailabilityGroupName; } set{ _AvailabilityGroupName=value; } }

			private System.String _Collation;
			internal System.String Collation { get{ return _Collation; } set{ _Collation=value; } }

			private System.String _DatabaseSnapshotBaseName;
			internal System.String DatabaseSnapshotBaseName { get{ return _DatabaseSnapshotBaseName; } set{ _DatabaseSnapshotBaseName=value; } }

			private System.Boolean _DataRetentionEnabled;
			internal System.Boolean DataRetentionEnabled { get{ return _DataRetentionEnabled; } set{ _DataRetentionEnabled=value; } }

			private System.String _DefaultSchema;
			internal System.String DefaultSchema { get{ return _DefaultSchema; } set{ _DefaultSchema=value; } }

			private System.DateTime _LastDifferentialBackupDate;
			internal System.DateTime LastDifferentialBackupDate { get{ return _LastDifferentialBackupDate; } set{ _LastDifferentialBackupDate=value; } }

		}

		private sealed class XRuntimeProps
		{
			private System.Boolean _AcceleratedRecoveryEnabled;
			internal System.Boolean AcceleratedRecoveryEnabled { get{ return _AcceleratedRecoveryEnabled; } set{ _AcceleratedRecoveryEnabled=value; } }

			private System.Int32 _ActiveConnections;
			internal System.Int32 ActiveConnections { get{ return _ActiveConnections; } set{ _ActiveConnections=value; } }

			private System.Boolean _AnsiNullDefault;
			internal System.Boolean AnsiNullDefault { get{ return _AnsiNullDefault; } set{ _AnsiNullDefault=value; } }

			private System.Boolean _AnsiNullsEnabled;
			internal System.Boolean AnsiNullsEnabled { get{ return _AnsiNullsEnabled; } set{ _AnsiNullsEnabled=value; } }

			private System.Boolean _AnsiPaddingEnabled;
			internal System.Boolean AnsiPaddingEnabled { get{ return _AnsiPaddingEnabled; } set{ _AnsiPaddingEnabled=value; } }

			private System.Boolean _AnsiWarningsEnabled;
			internal System.Boolean AnsiWarningsEnabled { get{ return _AnsiWarningsEnabled; } set{ _AnsiWarningsEnabled=value; } }

			private System.Boolean _ArithmeticAbortEnabled;
			internal System.Boolean ArithmeticAbortEnabled { get{ return _ArithmeticAbortEnabled; } set{ _ArithmeticAbortEnabled=value; } }

			private System.Boolean _AutoClose;
			internal System.Boolean AutoClose { get{ return _AutoClose; } set{ _AutoClose=value; } }

			private System.Boolean _AutoCreateIncrementalStatisticsEnabled;
			internal System.Boolean AutoCreateIncrementalStatisticsEnabled { get{ return _AutoCreateIncrementalStatisticsEnabled; } set{ _AutoCreateIncrementalStatisticsEnabled=value; } }

			private System.Boolean _AutoCreateStatisticsEnabled;
			internal System.Boolean AutoCreateStatisticsEnabled { get{ return _AutoCreateStatisticsEnabled; } set{ _AutoCreateStatisticsEnabled=value; } }

			private System.Boolean _AutoShrink;
			internal System.Boolean AutoShrink { get{ return _AutoShrink; } set{ _AutoShrink=value; } }

			private System.Boolean _AutoUpdateStatisticsAsync;
			internal System.Boolean AutoUpdateStatisticsAsync { get{ return _AutoUpdateStatisticsAsync; } set{ _AutoUpdateStatisticsAsync=value; } }

			private System.Boolean _AutoUpdateStatisticsEnabled;
			internal System.Boolean AutoUpdateStatisticsEnabled { get{ return _AutoUpdateStatisticsEnabled; } set{ _AutoUpdateStatisticsEnabled=value; } }

			private System.Boolean _BrokerEnabled;
			internal System.Boolean BrokerEnabled { get{ return _BrokerEnabled; } set{ _BrokerEnabled=value; } }

			private System.Boolean _CaseSensitive;
			internal System.Boolean CaseSensitive { get{ return _CaseSensitive; } set{ _CaseSensitive=value; } }

			private Microsoft.SqlServer.Management.Smo.CatalogCollationType _CatalogCollation;
			internal Microsoft.SqlServer.Management.Smo.CatalogCollationType CatalogCollation { get{ return _CatalogCollation; } set{ _CatalogCollation=value; } }

			private System.Boolean _ChangeTrackingAutoCleanUp;
			internal System.Boolean ChangeTrackingAutoCleanUp { get{ return _ChangeTrackingAutoCleanUp; } set{ _ChangeTrackingAutoCleanUp=value; } }

			private System.Boolean _ChangeTrackingEnabled;
			internal System.Boolean ChangeTrackingEnabled { get{ return _ChangeTrackingEnabled; } set{ _ChangeTrackingEnabled=value; } }

			private System.Int32 _ChangeTrackingRetentionPeriod;
			internal System.Int32 ChangeTrackingRetentionPeriod { get{ return _ChangeTrackingRetentionPeriod; } set{ _ChangeTrackingRetentionPeriod=value; } }

			private Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits _ChangeTrackingRetentionPeriodUnits;
			internal Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits ChangeTrackingRetentionPeriodUnits { get{ return _ChangeTrackingRetentionPeriodUnits; } set{ _ChangeTrackingRetentionPeriodUnits=value; } }

			private System.Boolean _CloseCursorsOnCommitEnabled;
			internal System.Boolean CloseCursorsOnCommitEnabled { get{ return _CloseCursorsOnCommitEnabled; } set{ _CloseCursorsOnCommitEnabled=value; } }

			private Microsoft.SqlServer.Management.Smo.CompatibilityLevel _CompatibilityLevel;
			internal Microsoft.SqlServer.Management.Smo.CompatibilityLevel CompatibilityLevel { get{ return _CompatibilityLevel; } set{ _CompatibilityLevel=value; } }

			private System.Boolean _ConcatenateNullYieldsNull;
			internal System.Boolean ConcatenateNullYieldsNull { get{ return _ConcatenateNullYieldsNull; } set{ _ConcatenateNullYieldsNull=value; } }

			private Microsoft.SqlServer.Management.Smo.ContainmentType _ContainmentType;
			internal Microsoft.SqlServer.Management.Smo.ContainmentType ContainmentType { get{ return _ContainmentType; } set{ _ContainmentType=value; } }

			private System.DateTime _CreateDate;
			internal System.DateTime CreateDate { get{ return _CreateDate; } set{ _CreateDate=value; } }

			private System.Guid _DatabaseGuid;
			internal System.Guid DatabaseGuid { get{ return _DatabaseGuid; } set{ _DatabaseGuid=value; } }

			private System.Boolean _DatabaseOwnershipChaining;
			internal System.Boolean DatabaseOwnershipChaining { get{ return _DatabaseOwnershipChaining; } set{ _DatabaseOwnershipChaining=value; } }

			private System.Double _DataSpaceUsage;
			internal System.Double DataSpaceUsage { get{ return _DataSpaceUsage; } set{ _DataSpaceUsage=value; } }

			private System.Boolean _DateCorrelationOptimization;
			internal System.Boolean DateCorrelationOptimization { get{ return _DateCorrelationOptimization; } set{ _DateCorrelationOptimization=value; } }

			private System.Boolean _DboLogin;
			internal System.Boolean DboLogin { get{ return _DboLogin; } set{ _DboLogin=value; } }

			private System.String _DefaultFileGroup;
			internal System.String DefaultFileGroup { get{ return _DefaultFileGroup; } set{ _DefaultFileGroup=value; } }

			private System.String _DefaultFileStreamFileGroup;
			internal System.String DefaultFileStreamFileGroup { get{ return _DefaultFileStreamFileGroup; } set{ _DefaultFileStreamFileGroup=value; } }

			private System.String _DefaultFullTextCatalog;
			internal System.String DefaultFullTextCatalog { get{ return _DefaultFullTextCatalog; } set{ _DefaultFullTextCatalog=value; } }

			private System.Int32 _DefaultFullTextLanguageLcid;
			internal System.Int32 DefaultFullTextLanguageLcid { get{ return _DefaultFullTextLanguageLcid; } set{ _DefaultFullTextLanguageLcid=value; } }

			private System.String _DefaultFullTextLanguageName;
			internal System.String DefaultFullTextLanguageName { get{ return _DefaultFullTextLanguageName; } set{ _DefaultFullTextLanguageName=value; } }

			private System.Int32 _DefaultLanguageLcid;
			internal System.Int32 DefaultLanguageLcid { get{ return _DefaultLanguageLcid; } set{ _DefaultLanguageLcid=value; } }

			private System.String _DefaultLanguageName;
			internal System.String DefaultLanguageName { get{ return _DefaultLanguageName; } set{ _DefaultLanguageName=value; } }

			private Microsoft.SqlServer.Management.Smo.DelayedDurability _DelayedDurability;
			internal Microsoft.SqlServer.Management.Smo.DelayedDurability DelayedDurability { get{ return _DelayedDurability; } set{ _DelayedDurability=value; } }

			private System.Boolean _EncryptionEnabled;
			internal System.Boolean EncryptionEnabled { get{ return _EncryptionEnabled; } set{ _EncryptionEnabled=value; } }

			private System.String _FilestreamDirectoryName;
			internal System.String FilestreamDirectoryName { get{ return _FilestreamDirectoryName; } set{ _FilestreamDirectoryName=value; } }

			private Microsoft.SqlServer.Management.Smo.FilestreamNonTransactedAccessType _FilestreamNonTransactedAccess;
			internal Microsoft.SqlServer.Management.Smo.FilestreamNonTransactedAccessType FilestreamNonTransactedAccess { get{ return _FilestreamNonTransactedAccess; } set{ _FilestreamNonTransactedAccess=value; } }

			private System.Boolean _HasDatabaseEncryptionKey;
			internal System.Boolean HasDatabaseEncryptionKey { get{ return _HasDatabaseEncryptionKey; } set{ _HasDatabaseEncryptionKey=value; } }

			private System.Boolean _HasFileInCloud;
			internal System.Boolean HasFileInCloud { get{ return _HasFileInCloud; } set{ _HasFileInCloud=value; } }

			private System.Boolean _HasFullBackup;
			internal System.Boolean HasFullBackup { get{ return _HasFullBackup; } set{ _HasFullBackup=value; } }

			private System.Boolean _HasMemoryOptimizedObjects;
			internal System.Boolean HasMemoryOptimizedObjects { get{ return _HasMemoryOptimizedObjects; } set{ _HasMemoryOptimizedObjects=value; } }

			private System.Boolean _HonorBrokerPriority;
			internal System.Boolean HonorBrokerPriority { get{ return _HonorBrokerPriority; } set{ _HonorBrokerPriority=value; } }

			private System.Int32 _ID;
			internal System.Int32 ID { get{ return _ID; } set{ _ID=value; } }

			private System.Double _IndexSpaceUsage;
			internal System.Double IndexSpaceUsage { get{ return _IndexSpaceUsage; } set{ _IndexSpaceUsage=value; } }

			private System.Boolean _IsAccessible;
			internal System.Boolean IsAccessible { get{ return _IsAccessible; } set{ _IsAccessible=value; } }

			private System.Boolean _IsDatabaseSnapshot;
			internal System.Boolean IsDatabaseSnapshot { get{ return _IsDatabaseSnapshot; } set{ _IsDatabaseSnapshot=value; } }

			private System.Boolean _IsDatabaseSnapshotBase;
			internal System.Boolean IsDatabaseSnapshotBase { get{ return _IsDatabaseSnapshotBase; } set{ _IsDatabaseSnapshotBase=value; } }

			private System.Boolean _IsDbAccessAdmin;
			internal System.Boolean IsDbAccessAdmin { get{ return _IsDbAccessAdmin; } set{ _IsDbAccessAdmin=value; } }

			private System.Boolean _IsDbBackupOperator;
			internal System.Boolean IsDbBackupOperator { get{ return _IsDbBackupOperator; } set{ _IsDbBackupOperator=value; } }

			private System.Boolean _IsDbDatareader;
			internal System.Boolean IsDbDatareader { get{ return _IsDbDatareader; } set{ _IsDbDatareader=value; } }

			private System.Boolean _IsDbDatawriter;
			internal System.Boolean IsDbDatawriter { get{ return _IsDbDatawriter; } set{ _IsDbDatawriter=value; } }

			private System.Boolean _IsDbDdlAdmin;
			internal System.Boolean IsDbDdlAdmin { get{ return _IsDbDdlAdmin; } set{ _IsDbDdlAdmin=value; } }

			private System.Boolean _IsDbDenyDatareader;
			internal System.Boolean IsDbDenyDatareader { get{ return _IsDbDenyDatareader; } set{ _IsDbDenyDatareader=value; } }

			private System.Boolean _IsDbDenyDatawriter;
			internal System.Boolean IsDbDenyDatawriter { get{ return _IsDbDenyDatawriter; } set{ _IsDbDenyDatawriter=value; } }

			private System.Boolean _IsDbOwner;
			internal System.Boolean IsDbOwner { get{ return _IsDbOwner; } set{ _IsDbOwner=value; } }

			private System.Boolean _IsDbSecurityAdmin;
			internal System.Boolean IsDbSecurityAdmin { get{ return _IsDbSecurityAdmin; } set{ _IsDbSecurityAdmin=value; } }

			private System.Boolean _IsFabricDatabase;
			internal System.Boolean IsFabricDatabase { get{ return _IsFabricDatabase; } set{ _IsFabricDatabase=value; } }

			private System.Boolean _IsFullTextEnabled;
			internal System.Boolean IsFullTextEnabled { get{ return _IsFullTextEnabled; } set{ _IsFullTextEnabled=value; } }

			private System.Boolean _IsLedger;
			internal System.Boolean IsLedger { get{ return _IsLedger; } set{ _IsLedger=value; } }

			private System.Boolean _IsMailHost;
			internal System.Boolean IsMailHost { get{ return _IsMailHost; } set{ _IsMailHost=value; } }

			private System.Boolean _IsManagementDataWarehouse;
			internal System.Boolean IsManagementDataWarehouse { get{ return _IsManagementDataWarehouse; } set{ _IsManagementDataWarehouse=value; } }

			private System.Boolean _IsMirroringEnabled;
			internal System.Boolean IsMirroringEnabled { get{ return _IsMirroringEnabled; } set{ _IsMirroringEnabled=value; } }

			private System.Boolean _IsParameterizationForced;
			internal System.Boolean IsParameterizationForced { get{ return _IsParameterizationForced; } set{ _IsParameterizationForced=value; } }

			private System.Boolean _IsReadCommittedSnapshotOn;
			internal System.Boolean IsReadCommittedSnapshotOn { get{ return _IsReadCommittedSnapshotOn; } set{ _IsReadCommittedSnapshotOn=value; } }

			private System.Boolean _IsSqlDw;
			internal System.Boolean IsSqlDw { get{ return _IsSqlDw; } set{ _IsSqlDw=value; } }

			private System.Boolean _IsSystemObject;
			internal System.Boolean IsSystemObject { get{ return _IsSystemObject; } set{ _IsSystemObject=value; } }

			private System.Boolean _IsUpdateable;
			internal System.Boolean IsUpdateable { get{ return _IsUpdateable; } set{ _IsUpdateable=value; } }

			private System.Boolean _IsVarDecimalStorageFormatEnabled;
			internal System.Boolean IsVarDecimalStorageFormatEnabled { get{ return _IsVarDecimalStorageFormatEnabled; } set{ _IsVarDecimalStorageFormatEnabled=value; } }

			private System.DateTime _LastBackupDate;
			internal System.DateTime LastBackupDate { get{ return _LastBackupDate; } set{ _LastBackupDate=value; } }

			private System.DateTime _LastGoodCheckDbTime;
			internal System.DateTime LastGoodCheckDbTime { get{ return _LastGoodCheckDbTime; } set{ _LastGoodCheckDbTime=value; } }

			private System.DateTime _LastLogBackupDate;
			internal System.DateTime LastLogBackupDate { get{ return _LastLogBackupDate; } set{ _LastLogBackupDate=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff _LegacyCardinalityEstimation;
			internal Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff LegacyCardinalityEstimation { get{ return _LegacyCardinalityEstimation; } set{ _LegacyCardinalityEstimation=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff _LegacyCardinalityEstimationForSecondary;
			internal Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff LegacyCardinalityEstimationForSecondary { get{ return _LegacyCardinalityEstimationForSecondary; } set{ _LegacyCardinalityEstimationForSecondary=value; } }

			private System.Boolean _LocalCursorsDefault;
			internal System.Boolean LocalCursorsDefault { get{ return _LocalCursorsDefault; } set{ _LocalCursorsDefault=value; } }

			private Microsoft.SqlServer.Management.Smo.LogReuseWaitStatus _LogReuseWaitStatus;
			internal Microsoft.SqlServer.Management.Smo.LogReuseWaitStatus LogReuseWaitStatus { get{ return _LogReuseWaitStatus; } set{ _LogReuseWaitStatus=value; } }

			private System.Int32 _MaxDop;
			internal System.Int32 MaxDop { get{ return _MaxDop; } set{ _MaxDop=value; } }

			private System.Int32 _MaxDopForSecondary;
			internal System.Int32 MaxDopForSecondary { get{ return _MaxDopForSecondary; } set{ _MaxDopForSecondary=value; } }

			private System.Double _MemoryAllocatedToMemoryOptimizedObjectsInKB;
			internal System.Double MemoryAllocatedToMemoryOptimizedObjectsInKB { get{ return _MemoryAllocatedToMemoryOptimizedObjectsInKB; } set{ _MemoryAllocatedToMemoryOptimizedObjectsInKB=value; } }

			private System.Double _MemoryUsedByMemoryOptimizedObjectsInKB;
			internal System.Double MemoryUsedByMemoryOptimizedObjectsInKB { get{ return _MemoryUsedByMemoryOptimizedObjectsInKB; } set{ _MemoryUsedByMemoryOptimizedObjectsInKB=value; } }

			private System.Decimal _MirroringFailoverLogSequenceNumber;
			internal System.Decimal MirroringFailoverLogSequenceNumber { get{ return _MirroringFailoverLogSequenceNumber; } set{ _MirroringFailoverLogSequenceNumber=value; } }

			private System.Guid _MirroringID;
			internal System.Guid MirroringID { get{ return _MirroringID; } set{ _MirroringID=value; } }

			private System.String _MirroringPartner;
			internal System.String MirroringPartner { get{ return _MirroringPartner; } set{ _MirroringPartner=value; } }

			private System.String _MirroringPartnerInstance;
			internal System.String MirroringPartnerInstance { get{ return _MirroringPartnerInstance; } set{ _MirroringPartnerInstance=value; } }

			private System.Int32 _MirroringRedoQueueMaxSize;
			internal System.Int32 MirroringRedoQueueMaxSize { get{ return _MirroringRedoQueueMaxSize; } set{ _MirroringRedoQueueMaxSize=value; } }

			private Microsoft.SqlServer.Management.Smo.MirroringRole _MirroringRole;
			internal Microsoft.SqlServer.Management.Smo.MirroringRole MirroringRole { get{ return _MirroringRole; } set{ _MirroringRole=value; } }

			private System.Int32 _MirroringRoleSequence;
			internal System.Int32 MirroringRoleSequence { get{ return _MirroringRoleSequence; } set{ _MirroringRoleSequence=value; } }

			private Microsoft.SqlServer.Management.Smo.MirroringSafetyLevel _MirroringSafetyLevel;
			internal Microsoft.SqlServer.Management.Smo.MirroringSafetyLevel MirroringSafetyLevel { get{ return _MirroringSafetyLevel; } set{ _MirroringSafetyLevel=value; } }

			private System.Int32 _MirroringSafetySequence;
			internal System.Int32 MirroringSafetySequence { get{ return _MirroringSafetySequence; } set{ _MirroringSafetySequence=value; } }

			private Microsoft.SqlServer.Management.Smo.MirroringStatus _MirroringStatus;
			internal Microsoft.SqlServer.Management.Smo.MirroringStatus MirroringStatus { get{ return _MirroringStatus; } set{ _MirroringStatus=value; } }

			private System.Int32 _MirroringTimeout;
			internal System.Int32 MirroringTimeout { get{ return _MirroringTimeout; } set{ _MirroringTimeout=value; } }

			private System.String _MirroringWitness;
			internal System.String MirroringWitness { get{ return _MirroringWitness; } set{ _MirroringWitness=value; } }

			private Microsoft.SqlServer.Management.Smo.MirroringWitnessStatus _MirroringWitnessStatus;
			internal Microsoft.SqlServer.Management.Smo.MirroringWitnessStatus MirroringWitnessStatus { get{ return _MirroringWitnessStatus; } set{ _MirroringWitnessStatus=value; } }

			private System.Boolean _NestedTriggersEnabled;
			internal System.Boolean NestedTriggersEnabled { get{ return _NestedTriggersEnabled; } set{ _NestedTriggersEnabled=value; } }

			private System.Boolean _NumericRoundAbortEnabled;
			internal System.Boolean NumericRoundAbortEnabled { get{ return _NumericRoundAbortEnabled; } set{ _NumericRoundAbortEnabled=value; } }

			private System.String _Owner;
			internal System.String Owner { get{ return _Owner; } set{ _Owner=value; } }

			private Microsoft.SqlServer.Management.Smo.PageVerify _PageVerify;
			internal Microsoft.SqlServer.Management.Smo.PageVerify PageVerify { get{ return _PageVerify; } set{ _PageVerify=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff _ParameterSniffing;
			internal Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff ParameterSniffing { get{ return _ParameterSniffing; } set{ _ParameterSniffing=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff _ParameterSniffingForSecondary;
			internal Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff ParameterSniffingForSecondary { get{ return _ParameterSniffingForSecondary; } set{ _ParameterSniffingForSecondary=value; } }

			private System.String _PersistentVersionStoreFileGroup;
			internal System.String PersistentVersionStoreFileGroup { get{ return _PersistentVersionStoreFileGroup; } set{ _PersistentVersionStoreFileGroup=value; } }

			private System.Int64 _PersistentVersionStoreSizeKB;
			internal System.Int64 PersistentVersionStoreSizeKB { get{ return _PersistentVersionStoreSizeKB; } set{ _PersistentVersionStoreSizeKB=value; } }

			private Microsoft.SqlServer.Management.Dmf.PolicyHealthState _PolicyHealthState;
			internal Microsoft.SqlServer.Management.Dmf.PolicyHealthState PolicyHealthState { get{ return _PolicyHealthState; } set{ _PolicyHealthState=value; } }

			private System.String _PrimaryFilePath;
			internal System.String PrimaryFilePath { get{ return _PrimaryFilePath; } set{ _PrimaryFilePath=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff _QueryOptimizerHotfixes;
			internal Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff QueryOptimizerHotfixes { get{ return _QueryOptimizerHotfixes; } set{ _QueryOptimizerHotfixes=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff _QueryOptimizerHotfixesForSecondary;
			internal Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff QueryOptimizerHotfixesForSecondary { get{ return _QueryOptimizerHotfixesForSecondary; } set{ _QueryOptimizerHotfixesForSecondary=value; } }

			private System.Boolean _QuotedIdentifiersEnabled;
			internal System.Boolean QuotedIdentifiersEnabled { get{ return _QuotedIdentifiersEnabled; } set{ _QuotedIdentifiersEnabled=value; } }

			private System.Boolean _ReadOnly;
			internal System.Boolean ReadOnly { get{ return _ReadOnly; } set{ _ReadOnly=value; } }

			private System.Guid _RecoveryForkGuid;
			internal System.Guid RecoveryForkGuid { get{ return _RecoveryForkGuid; } set{ _RecoveryForkGuid=value; } }

			private Microsoft.SqlServer.Management.Smo.RecoveryModel _RecoveryModel;
			internal Microsoft.SqlServer.Management.Smo.RecoveryModel RecoveryModel { get{ return _RecoveryModel; } set{ _RecoveryModel=value; } }

			private System.Boolean _RecursiveTriggersEnabled;
			internal System.Boolean RecursiveTriggersEnabled { get{ return _RecursiveTriggersEnabled; } set{ _RecursiveTriggersEnabled=value; } }

			private System.String _RemoteDataArchiveCredential;
			internal System.String RemoteDataArchiveCredential { get{ return _RemoteDataArchiveCredential; } set{ _RemoteDataArchiveCredential=value; } }

			private System.Boolean _RemoteDataArchiveEnabled;
			internal System.Boolean RemoteDataArchiveEnabled { get{ return _RemoteDataArchiveEnabled; } set{ _RemoteDataArchiveEnabled=value; } }

			private System.String _RemoteDataArchiveEndpoint;
			internal System.String RemoteDataArchiveEndpoint { get{ return _RemoteDataArchiveEndpoint; } set{ _RemoteDataArchiveEndpoint=value; } }

			private System.String _RemoteDataArchiveLinkedServer;
			internal System.String RemoteDataArchiveLinkedServer { get{ return _RemoteDataArchiveLinkedServer; } set{ _RemoteDataArchiveLinkedServer=value; } }

			private System.Boolean _RemoteDataArchiveUseFederatedServiceAccount;
			internal System.Boolean RemoteDataArchiveUseFederatedServiceAccount { get{ return _RemoteDataArchiveUseFederatedServiceAccount; } set{ _RemoteDataArchiveUseFederatedServiceAccount=value; } }

			private System.String _RemoteDatabaseName;
			internal System.String RemoteDatabaseName { get{ return _RemoteDatabaseName; } set{ _RemoteDatabaseName=value; } }

			private Microsoft.SqlServer.Management.Smo.ReplicationOptions _ReplicationOptions;
			internal Microsoft.SqlServer.Management.Smo.ReplicationOptions ReplicationOptions { get{ return _ReplicationOptions; } set{ _ReplicationOptions=value; } }

			private System.Guid _ServiceBrokerGuid;
			internal System.Guid ServiceBrokerGuid { get{ return _ServiceBrokerGuid; } set{ _ServiceBrokerGuid=value; } }

			private System.Double _Size;
			internal System.Double Size { get{ return _Size; } set{ _Size=value; } }

			private Microsoft.SqlServer.Management.Smo.SnapshotIsolationState _SnapshotIsolationState;
			internal Microsoft.SqlServer.Management.Smo.SnapshotIsolationState SnapshotIsolationState { get{ return _SnapshotIsolationState; } set{ _SnapshotIsolationState=value; } }

			private System.Double _SpaceAvailable;
			internal System.Double SpaceAvailable { get{ return _SpaceAvailable; } set{ _SpaceAvailable=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseStatus _Status;
			internal Microsoft.SqlServer.Management.Smo.DatabaseStatus Status { get{ return _Status; } set{ _Status=value; } }

			private System.Int32 _TargetRecoveryTime;
			internal System.Int32 TargetRecoveryTime { get{ return _TargetRecoveryTime; } set{ _TargetRecoveryTime=value; } }

			private System.Boolean _TransformNoiseWords;
			internal System.Boolean TransformNoiseWords { get{ return _TransformNoiseWords; } set{ _TransformNoiseWords=value; } }

			private System.Boolean _Trustworthy;
			internal System.Boolean Trustworthy { get{ return _Trustworthy; } set{ _Trustworthy=value; } }

			private System.Int32 _TwoDigitYearCutoff;
			internal System.Int32 TwoDigitYearCutoff { get{ return _TwoDigitYearCutoff; } set{ _TwoDigitYearCutoff=value; } }

			private Microsoft.SqlServer.Management.Smo.DatabaseUserAccess _UserAccess;
			internal Microsoft.SqlServer.Management.Smo.DatabaseUserAccess UserAccess { get{ return _UserAccess; } set{ _UserAccess=value; } }

			private System.String _UserName;
			internal System.String UserName { get{ return _UserName; } set{ _UserName=value; } }

			private System.Int32 _Version;
			internal System.Int32 Version { get{ return _Version; } set{ _Version=value; } }

			private System.String _AzureEdition;
			internal System.String AzureEdition { get{ return _AzureEdition; } set{ _AzureEdition=value; } }

			private System.String _AzureServiceObjective;
			internal System.String AzureServiceObjective { get{ return _AzureServiceObjective; } set{ _AzureServiceObjective=value; } }

			private System.Boolean _IsDbManager;
			internal System.Boolean IsDbManager { get{ return _IsDbManager; } set{ _IsDbManager=value; } }

			private System.Boolean _IsLoginManager;
			internal System.Boolean IsLoginManager { get{ return _IsLoginManager; } set{ _IsLoginManager=value; } }

			private System.Boolean _IsMaxSizeApplicable;
			internal System.Boolean IsMaxSizeApplicable { get{ return _IsMaxSizeApplicable; } set{ _IsMaxSizeApplicable=value; } }

			private System.Boolean _IsSqlDwEdition;
			internal System.Boolean IsSqlDwEdition { get{ return _IsSqlDwEdition; } set{ _IsSqlDwEdition=value; } }

			private System.Double _MaxSizeInBytes;
			internal System.Double MaxSizeInBytes { get{ return _MaxSizeInBytes; } set{ _MaxSizeInBytes=value; } }

			private System.Int32 _RealEngineEdition;
			internal System.Int32 RealEngineEdition { get{ return _RealEngineEdition; } set{ _RealEngineEdition=value; } }

			private System.Boolean _TemporalHistoryRetentionEnabled;
			internal System.Boolean TemporalHistoryRetentionEnabled { get{ return _TemporalHistoryRetentionEnabled; } set{ _TemporalHistoryRetentionEnabled=value; } }

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
						value = this.XRuntime.AnsiNullDefault;
						break;
						case 1:
						value = this.XRuntime.AnsiNullsEnabled;
						break;
						case 2:
						value = this.XRuntime.AnsiPaddingEnabled;
						break;
						case 3:
						value = this.XRuntime.AnsiWarningsEnabled;
						break;
						case 4:
						value = this.XRuntime.ArithmeticAbortEnabled;
						break;
						case 5:
						value = this.XRuntime.AutoCreateIncrementalStatisticsEnabled;
						break;
						case 6:
						value = this.XRuntime.AutoCreateStatisticsEnabled;
						break;
						case 7:
						value = this.XRuntime.AutoShrink;
						break;
						case 8:
						value = this.XRuntime.AutoUpdateStatisticsAsync;
						break;
						case 9:
						value = this.XRuntime.AutoUpdateStatisticsEnabled;
						break;
						case 10:
						value = this.XRuntime.AzureEdition;
						break;
						case 11:
						value = this.XRuntime.AzureServiceObjective;
						break;
						case 12:
						value = this.XRuntime.CaseSensitive;
						break;
						case 13:
						value = this.XRuntime.CloseCursorsOnCommitEnabled;
						break;
						case 14:
						value = this.XSchema.Collation;
						break;
						case 15:
						value = this.XRuntime.CompatibilityLevel;
						break;
						case 16:
						value = this.XRuntime.ConcatenateNullYieldsNull;
						break;
						case 17:
						value = this.XRuntime.CreateDate;
						break;
						case 18:
						value = this.XRuntime.DatabaseOwnershipChaining;
						break;
						case 19:
						value = this.XSchema.DatabaseSnapshotBaseName;
						break;
						case 20:
						value = this.XRuntime.DateCorrelationOptimization;
						break;
						case 21:
						value = this.XRuntime.DboLogin;
						break;
						case 22:
						value = this.XRuntime.DefaultFileGroup;
						break;
						case 23:
						value = this.XSchema.DefaultSchema;
						break;
						case 24:
						value = this.XRuntime.EncryptionEnabled;
						break;
						case 25:
						value = this.XRuntime.HonorBrokerPriority;
						break;
						case 26:
						value = this.XRuntime.ID;
						break;
						case 27:
						value = this.XRuntime.IsAccessible;
						break;
						case 28:
						value = this.XRuntime.IsDatabaseSnapshot;
						break;
						case 29:
						value = this.XRuntime.IsDatabaseSnapshotBase;
						break;
						case 30:
						value = this.XRuntime.IsDbAccessAdmin;
						break;
						case 31:
						value = this.XRuntime.IsDbBackupOperator;
						break;
						case 32:
						value = this.XRuntime.IsDbDatareader;
						break;
						case 33:
						value = this.XRuntime.IsDbDatawriter;
						break;
						case 34:
						value = this.XRuntime.IsDbDdlAdmin;
						break;
						case 35:
						value = this.XRuntime.IsDbDenyDatareader;
						break;
						case 36:
						value = this.XRuntime.IsDbDenyDatawriter;
						break;
						case 37:
						value = this.XRuntime.IsDbManager;
						break;
						case 38:
						value = this.XRuntime.IsDbOwner;
						break;
						case 39:
						value = this.XRuntime.IsDbSecurityAdmin;
						break;
						case 40:
						value = this.XRuntime.IsFabricDatabase;
						break;
						case 41:
						value = this.XRuntime.IsFullTextEnabled;
						break;
						case 42:
						value = this.XRuntime.IsLoginManager;
						break;
						case 43:
						value = this.XRuntime.IsMaxSizeApplicable;
						break;
						case 44:
						value = this.XRuntime.IsMirroringEnabled;
						break;
						case 45:
						value = this.XRuntime.IsParameterizationForced;
						break;
						case 46:
						value = this.XRuntime.IsReadCommittedSnapshotOn;
						break;
						case 47:
						value = this.XRuntime.IsSqlDw;
						break;
						case 48:
						value = this.XRuntime.IsSystemObject;
						break;
						case 49:
						value = this.XRuntime.IsUpdateable;
						break;
						case 50:
						value = this.XRuntime.LastGoodCheckDbTime;
						break;
						case 51:
						value = this.XRuntime.MaxSizeInBytes;
						break;
						case 52:
						value = this.XRuntime.NumericRoundAbortEnabled;
						break;
						case 53:
						value = this.XRuntime.Owner;
						break;
						case 54:
						value = this.XRuntime.QuotedIdentifiersEnabled;
						break;
						case 55:
						value = this.XRuntime.ReadOnly;
						break;
						case 56:
						value = this.XRuntime.RealEngineEdition;
						break;
						case 57:
						value = this.XRuntime.RecursiveTriggersEnabled;
						break;
						case 58:
						value = this.XRuntime.ReplicationOptions;
						break;
						case 59:
						value = this.XRuntime.ServiceBrokerGuid;
						break;
						case 60:
						value = this.XRuntime.Size;
						break;
						case 61:
						value = this.XRuntime.SnapshotIsolationState;
						break;
						case 62:
						value = this.XRuntime.SpaceAvailable;
						break;
						case 63:
						value = this.XRuntime.Status;
						break;
						case 64:
						value = this.XRuntime.Trustworthy;
						break;
						case 65:
						value = this.XRuntime.UserAccess;
						break;
						case 66:
						value = this.XRuntime.UserName;
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
						value = this.XRuntime.AnsiNullDefault;
						break;
						case 1:
						value = this.XRuntime.AnsiNullsEnabled;
						break;
						case 2:
						value = this.XRuntime.AnsiPaddingEnabled;
						break;
						case 3:
						value = this.XRuntime.AnsiWarningsEnabled;
						break;
						case 4:
						value = this.XRuntime.ArithmeticAbortEnabled;
						break;
						case 5:
						value = this.XRuntime.AutoCreateIncrementalStatisticsEnabled;
						break;
						case 6:
						value = this.XRuntime.AutoCreateStatisticsEnabled;
						break;
						case 7:
						value = this.XRuntime.AutoShrink;
						break;
						case 8:
						value = this.XRuntime.AutoUpdateStatisticsAsync;
						break;
						case 9:
						value = this.XRuntime.AutoUpdateStatisticsEnabled;
						break;
						case 10:
						value = this.XRuntime.AzureEdition;
						break;
						case 11:
						value = this.XRuntime.AzureServiceObjective;
						break;
						case 12:
						value = this.XRuntime.CaseSensitive;
						break;
						case 13:
						value = this.XRuntime.CatalogCollation;
						break;
						case 14:
						value = this.XRuntime.ChangeTrackingAutoCleanUp;
						break;
						case 15:
						value = this.XRuntime.ChangeTrackingEnabled;
						break;
						case 16:
						value = this.XRuntime.ChangeTrackingRetentionPeriod;
						break;
						case 17:
						value = this.XRuntime.ChangeTrackingRetentionPeriodUnits;
						break;
						case 18:
						value = this.XRuntime.CloseCursorsOnCommitEnabled;
						break;
						case 19:
						value = this.XSchema.Collation;
						break;
						case 20:
						value = this.XRuntime.CompatibilityLevel;
						break;
						case 21:
						value = this.XRuntime.ConcatenateNullYieldsNull;
						break;
						case 22:
						value = this.XRuntime.CreateDate;
						break;
						case 23:
						value = this.XRuntime.DatabaseOwnershipChaining;
						break;
						case 24:
						value = this.XSchema.DatabaseSnapshotBaseName;
						break;
						case 25:
						value = this.XRuntime.DateCorrelationOptimization;
						break;
						case 26:
						value = this.XRuntime.DboLogin;
						break;
						case 27:
						value = this.XRuntime.DefaultFileGroup;
						break;
						case 28:
						value = this.XRuntime.DefaultFullTextCatalog;
						break;
						case 29:
						value = this.XSchema.DefaultSchema;
						break;
						case 30:
						value = this.XRuntime.EncryptionEnabled;
						break;
						case 31:
						value = this.XRuntime.HasFileInCloud;
						break;
						case 32:
						value = this.XRuntime.HasMemoryOptimizedObjects;
						break;
						case 33:
						value = this.XRuntime.HonorBrokerPriority;
						break;
						case 34:
						value = this.XRuntime.ID;
						break;
						case 35:
						value = this.XRuntime.IsAccessible;
						break;
						case 36:
						value = this.XRuntime.IsDatabaseSnapshot;
						break;
						case 37:
						value = this.XRuntime.IsDatabaseSnapshotBase;
						break;
						case 38:
						value = this.XRuntime.IsDbAccessAdmin;
						break;
						case 39:
						value = this.XRuntime.IsDbBackupOperator;
						break;
						case 40:
						value = this.XRuntime.IsDbDatareader;
						break;
						case 41:
						value = this.XRuntime.IsDbDatawriter;
						break;
						case 42:
						value = this.XRuntime.IsDbDdlAdmin;
						break;
						case 43:
						value = this.XRuntime.IsDbDenyDatareader;
						break;
						case 44:
						value = this.XRuntime.IsDbDenyDatawriter;
						break;
						case 45:
						value = this.XRuntime.IsDbManager;
						break;
						case 46:
						value = this.XRuntime.IsDbOwner;
						break;
						case 47:
						value = this.XRuntime.IsDbSecurityAdmin;
						break;
						case 48:
						value = this.XRuntime.IsFabricDatabase;
						break;
						case 49:
						value = this.XRuntime.IsFullTextEnabled;
						break;
						case 50:
						value = this.XRuntime.IsLedger;
						break;
						case 51:
						value = this.XRuntime.IsLoginManager;
						break;
						case 52:
						value = this.XRuntime.IsMaxSizeApplicable;
						break;
						case 53:
						value = this.XRuntime.IsMirroringEnabled;
						break;
						case 54:
						value = this.XRuntime.IsParameterizationForced;
						break;
						case 55:
						value = this.XRuntime.IsReadCommittedSnapshotOn;
						break;
						case 56:
						value = this.XRuntime.IsSqlDw;
						break;
						case 57:
						value = this.XRuntime.IsSqlDwEdition;
						break;
						case 58:
						value = this.XRuntime.IsSystemObject;
						break;
						case 59:
						value = this.XRuntime.IsUpdateable;
						break;
						case 60:
						value = this.XRuntime.LastGoodCheckDbTime;
						break;
						case 61:
						value = this.XRuntime.LegacyCardinalityEstimation;
						break;
						case 62:
						value = this.XRuntime.LegacyCardinalityEstimationForSecondary;
						break;
						case 63:
						value = this.XRuntime.MaxDop;
						break;
						case 64:
						value = this.XRuntime.MaxDopForSecondary;
						break;
						case 65:
						value = this.XRuntime.MaxSizeInBytes;
						break;
						case 66:
						value = this.XRuntime.MemoryAllocatedToMemoryOptimizedObjectsInKB;
						break;
						case 67:
						value = this.XRuntime.MemoryUsedByMemoryOptimizedObjectsInKB;
						break;
						case 68:
						value = this.XRuntime.NumericRoundAbortEnabled;
						break;
						case 69:
						value = this.XRuntime.Owner;
						break;
						case 70:
						value = this.XRuntime.ParameterSniffing;
						break;
						case 71:
						value = this.XRuntime.ParameterSniffingForSecondary;
						break;
						case 72:
						value = this.XRuntime.QueryOptimizerHotfixes;
						break;
						case 73:
						value = this.XRuntime.QueryOptimizerHotfixesForSecondary;
						break;
						case 74:
						value = this.XRuntime.QuotedIdentifiersEnabled;
						break;
						case 75:
						value = this.XRuntime.ReadOnly;
						break;
						case 76:
						value = this.XRuntime.RealEngineEdition;
						break;
						case 77:
						value = this.XRuntime.RecursiveTriggersEnabled;
						break;
						case 78:
						value = this.XRuntime.ReplicationOptions;
						break;
						case 79:
						value = this.XRuntime.ServiceBrokerGuid;
						break;
						case 80:
						value = this.XRuntime.Size;
						break;
						case 81:
						value = this.XRuntime.SnapshotIsolationState;
						break;
						case 82:
						value = this.XRuntime.SpaceAvailable;
						break;
						case 83:
						value = this.XRuntime.Status;
						break;
						case 84:
						value = this.XRuntime.TemporalHistoryRetentionEnabled;
						break;
						case 85:
						value = this.XRuntime.Trustworthy;
						break;
						case 86:
						value = this.XRuntime.UserAccess;
						break;
						case 87:
						value = this.XRuntime.UserName;
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
					case 133:
					value = this.XRuntime.AcceleratedRecoveryEnabled;
					break;
					case 0:
					value = this.XRuntime.ActiveConnections;
					break;
					case 33:
					value = this.XRuntime.AnsiNullDefault;
					break;
					case 34:
					value = this.XRuntime.AnsiNullsEnabled;
					break;
					case 35:
					value = this.XRuntime.AnsiPaddingEnabled;
					break;
					case 36:
					value = this.XRuntime.AnsiWarningsEnabled;
					break;
					case 37:
					value = this.XRuntime.ArithmeticAbortEnabled;
					break;
					case 1:
					value = this.XRuntime.AutoClose;
					break;
					case 113:
					value = this.XRuntime.AutoCreateIncrementalStatisticsEnabled;
					break;
					case 38:
					value = this.XRuntime.AutoCreateStatisticsEnabled;
					break;
					case 2:
					value = this.XRuntime.AutoShrink;
					break;
					case 59:
					value = this.XRuntime.AutoUpdateStatisticsAsync;
					break;
					case 39:
					value = this.XRuntime.AutoUpdateStatisticsEnabled;
					break;
					case 100:
					value = this.XSchema.AvailabilityDatabaseSynchronizationState;
					break;
					case 101:
					value = this.XSchema.AvailabilityGroupName;
					break;
					case 60:
					value = this.XRuntime.BrokerEnabled;
					break;
					case 40:
					value = this.XRuntime.CaseSensitive;
					break;
					case 134:
					value = this.XRuntime.CatalogCollation;
					break;
					case 90:
					value = this.XRuntime.ChangeTrackingAutoCleanUp;
					break;
					case 91:
					value = this.XRuntime.ChangeTrackingEnabled;
					break;
					case 92:
					value = this.XRuntime.ChangeTrackingRetentionPeriod;
					break;
					case 93:
					value = this.XRuntime.ChangeTrackingRetentionPeriodUnits;
					break;
					case 41:
					value = this.XRuntime.CloseCursorsOnCommitEnabled;
					break;
					case 42:
					value = this.XSchema.Collation;
					break;
					case 3:
					value = this.XRuntime.CompatibilityLevel;
					break;
					case 43:
					value = this.XRuntime.ConcatenateNullYieldsNull;
					break;
					case 102:
					value = this.XRuntime.ContainmentType;
					break;
					case 4:
					value = this.XRuntime.CreateDate;
					break;
					case 61:
					value = this.XRuntime.DatabaseGuid;
					break;
					case 44:
					value = this.XRuntime.DatabaseOwnershipChaining;
					break;
					case 62:
					value = this.XSchema.DatabaseSnapshotBaseName;
					break;
					case 135:
					value = this.XSchema.DataRetentionEnabled;
					break;
					case 5:
					value = this.XRuntime.DataSpaceUsage;
					break;
					case 63:
					value = this.XRuntime.DateCorrelationOptimization;
					break;
					case 6:
					value = this.XRuntime.DboLogin;
					break;
					case 7:
					value = this.XRuntime.DefaultFileGroup;
					break;
					case 94:
					value = this.XRuntime.DefaultFileStreamFileGroup;
					break;
					case 64:
					value = this.XRuntime.DefaultFullTextCatalog;
					break;
					case 103:
					value = this.XRuntime.DefaultFullTextLanguageLcid;
					break;
					case 104:
					value = this.XRuntime.DefaultFullTextLanguageName;
					break;
					case 105:
					value = this.XRuntime.DefaultLanguageLcid;
					break;
					case 106:
					value = this.XRuntime.DefaultLanguageName;
					break;
					case 8:
					value = this.XSchema.DefaultSchema;
					break;
					case 114:
					value = this.XRuntime.DelayedDurability;
					break;
					case 95:
					value = this.XRuntime.EncryptionEnabled;
					break;
					case 107:
					value = this.XRuntime.FilestreamDirectoryName;
					break;
					case 108:
					value = this.XRuntime.FilestreamNonTransactedAccess;
					break;
					case 96:
					value = this.XRuntime.HasDatabaseEncryptionKey;
					break;
					case 115:
					value = this.XRuntime.HasFileInCloud;
					break;
					case 65:
					value = this.XRuntime.HasFullBackup;
					break;
					case 116:
					value = this.XRuntime.HasMemoryOptimizedObjects;
					break;
					case 97:
					value = this.XRuntime.HonorBrokerPriority;
					break;
					case 9:
					value = this.XRuntime.ID;
					break;
					case 10:
					value = this.XRuntime.IndexSpaceUsage;
					break;
					case 11:
					value = this.XRuntime.IsAccessible;
					break;
					case 66:
					value = this.XRuntime.IsDatabaseSnapshot;
					break;
					case 67:
					value = this.XRuntime.IsDatabaseSnapshotBase;
					break;
					case 12:
					value = this.XRuntime.IsDbAccessAdmin;
					break;
					case 13:
					value = this.XRuntime.IsDbBackupOperator;
					break;
					case 14:
					value = this.XRuntime.IsDbDatareader;
					break;
					case 15:
					value = this.XRuntime.IsDbDatawriter;
					break;
					case 16:
					value = this.XRuntime.IsDbDdlAdmin;
					break;
					case 17:
					value = this.XRuntime.IsDbDenyDatareader;
					break;
					case 18:
					value = this.XRuntime.IsDbDenyDatawriter;
					break;
					case 19:
					value = this.XRuntime.IsDbOwner;
					break;
					case 20:
					value = this.XRuntime.IsDbSecurityAdmin;
					break;
					case 21:
					value = this.XRuntime.IsFabricDatabase;
					break;
					case 22:
					value = this.XRuntime.IsFullTextEnabled;
					break;
					case 138:
					value = this.XRuntime.IsLedger;
					break;
					case 68:
					value = this.XRuntime.IsMailHost;
					break;
					case 98:
					value = this.XRuntime.IsManagementDataWarehouse;
					break;
					case 23:
					value = this.XRuntime.IsMirroringEnabled;
					break;
					case 69:
					value = this.XRuntime.IsParameterizationForced;
					break;
					case 70:
					value = this.XRuntime.IsReadCommittedSnapshotOn;
					break;
					case 24:
					value = this.XRuntime.IsSqlDw;
					break;
					case 25:
					value = this.XRuntime.IsSystemObject;
					break;
					case 45:
					value = this.XRuntime.IsUpdateable;
					break;
					case 71:
					value = this.XRuntime.IsVarDecimalStorageFormatEnabled;
					break;
					case 46:
					value = this.XRuntime.LastBackupDate;
					break;
					case 47:
					value = this.XSchema.LastDifferentialBackupDate;
					break;
					case 48:
					value = this.XRuntime.LastGoodCheckDbTime;
					break;
					case 49:
					value = this.XRuntime.LastLogBackupDate;
					break;
					case 119:
					value = this.XRuntime.LegacyCardinalityEstimation;
					break;
					case 120:
					value = this.XRuntime.LegacyCardinalityEstimationForSecondary;
					break;
					case 50:
					value = this.XRuntime.LocalCursorsDefault;
					break;
					case 72:
					value = this.XRuntime.LogReuseWaitStatus;
					break;
					case 121:
					value = this.XRuntime.MaxDop;
					break;
					case 122:
					value = this.XRuntime.MaxDopForSecondary;
					break;
					case 117:
					value = this.XRuntime.MemoryAllocatedToMemoryOptimizedObjectsInKB;
					break;
					case 118:
					value = this.XRuntime.MemoryUsedByMemoryOptimizedObjectsInKB;
					break;
					case 73:
					value = this.XRuntime.MirroringFailoverLogSequenceNumber;
					break;
					case 74:
					value = this.XRuntime.MirroringID;
					break;
					case 75:
					value = this.XRuntime.MirroringPartner;
					break;
					case 76:
					value = this.XRuntime.MirroringPartnerInstance;
					break;
					case 77:
					value = this.XRuntime.MirroringRedoQueueMaxSize;
					break;
					case 78:
					value = this.XRuntime.MirroringRole;
					break;
					case 79:
					value = this.XRuntime.MirroringRoleSequence;
					break;
					case 80:
					value = this.XRuntime.MirroringSafetyLevel;
					break;
					case 81:
					value = this.XRuntime.MirroringSafetySequence;
					break;
					case 82:
					value = this.XRuntime.MirroringStatus;
					break;
					case 83:
					value = this.XRuntime.MirroringTimeout;
					break;
					case 84:
					value = this.XRuntime.MirroringWitness;
					break;
					case 85:
					value = this.XRuntime.MirroringWitnessStatus;
					break;
					case 109:
					value = this.XRuntime.NestedTriggersEnabled;
					break;
					case 51:
					value = this.XRuntime.NumericRoundAbortEnabled;
					break;
					case 26:
					value = this.XRuntime.Owner;
					break;
					case 52:
					value = this.XRuntime.PageVerify;
					break;
					case 123:
					value = this.XRuntime.ParameterSniffing;
					break;
					case 124:
					value = this.XRuntime.ParameterSniffingForSecondary;
					break;
					case 136:
					value = this.XRuntime.PersistentVersionStoreFileGroup;
					break;
					case 137:
					value = this.XRuntime.PersistentVersionStoreSizeKB;
					break;
					case 99:
					value = this.XRuntime.PolicyHealthState;
					break;
					case 27:
					value = this.XRuntime.PrimaryFilePath;
					break;
					case 125:
					value = this.XRuntime.QueryOptimizerHotfixes;
					break;
					case 126:
					value = this.XRuntime.QueryOptimizerHotfixesForSecondary;
					break;
					case 53:
					value = this.XRuntime.QuotedIdentifiersEnabled;
					break;
					case 54:
					value = this.XRuntime.ReadOnly;
					break;
					case 86:
					value = this.XRuntime.RecoveryForkGuid;
					break;
					case 55:
					value = this.XRuntime.RecoveryModel;
					break;
					case 56:
					value = this.XRuntime.RecursiveTriggersEnabled;
					break;
					case 127:
					value = this.XRuntime.RemoteDataArchiveCredential;
					break;
					case 128:
					value = this.XRuntime.RemoteDataArchiveEnabled;
					break;
					case 129:
					value = this.XRuntime.RemoteDataArchiveEndpoint;
					break;
					case 130:
					value = this.XRuntime.RemoteDataArchiveLinkedServer;
					break;
					case 131:
					value = this.XRuntime.RemoteDataArchiveUseFederatedServiceAccount;
					break;
					case 132:
					value = this.XRuntime.RemoteDatabaseName;
					break;
					case 28:
					value = this.XRuntime.ReplicationOptions;
					break;
					case 87:
					value = this.XRuntime.ServiceBrokerGuid;
					break;
					case 29:
					value = this.XRuntime.Size;
					break;
					case 88:
					value = this.XRuntime.SnapshotIsolationState;
					break;
					case 30:
					value = this.XRuntime.SpaceAvailable;
					break;
					case 31:
					value = this.XRuntime.Status;
					break;
					case 110:
					value = this.XRuntime.TargetRecoveryTime;
					break;
					case 111:
					value = this.XRuntime.TransformNoiseWords;
					break;
					case 89:
					value = this.XRuntime.Trustworthy;
					break;
					case 112:
					value = this.XRuntime.TwoDigitYearCutoff;
					break;
					case 57:
					value = this.XRuntime.UserAccess;
					break;
					case 32:
					value = this.XRuntime.UserName;
					break;
					case 58:
					value = this.XRuntime.Version;
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
						this.XRuntime.AnsiNullDefault = (System.Boolean)value;
						break;
						case 1:
						this.XRuntime.AnsiNullsEnabled = (System.Boolean)value;
						break;
						case 2:
						this.XRuntime.AnsiPaddingEnabled = (System.Boolean)value;
						break;
						case 3:
						this.XRuntime.AnsiWarningsEnabled = (System.Boolean)value;
						break;
						case 4:
						this.XRuntime.ArithmeticAbortEnabled = (System.Boolean)value;
						break;
						case 5:
						this.XRuntime.AutoCreateIncrementalStatisticsEnabled = (System.Boolean)value;
						break;
						case 6:
						this.XRuntime.AutoCreateStatisticsEnabled = (System.Boolean)value;
						break;
						case 7:
						this.XRuntime.AutoShrink = (System.Boolean)value;
						break;
						case 8:
						this.XRuntime.AutoUpdateStatisticsAsync = (System.Boolean)value;
						break;
						case 9:
						this.XRuntime.AutoUpdateStatisticsEnabled = (System.Boolean)value;
						break;
						case 10:
						this.XRuntime.AzureEdition = (System.String)value;
						break;
						case 11:
						this.XRuntime.AzureServiceObjective = (System.String)value;
						break;
						case 12:
						this.XRuntime.CaseSensitive = (System.Boolean)value;
						break;
						case 13:
						this.XRuntime.CloseCursorsOnCommitEnabled = (System.Boolean)value;
						break;
						case 14:
						this.XSchema.Collation = (System.String)value;
						break;
						case 15:
						this.XRuntime.CompatibilityLevel = (Microsoft.SqlServer.Management.Smo.CompatibilityLevel)value;
						break;
						case 16:
						this.XRuntime.ConcatenateNullYieldsNull = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.CreateDate = (System.DateTime)value;
						break;
						case 18:
						this.XRuntime.DatabaseOwnershipChaining = (System.Boolean)value;
						break;
						case 19:
						this.XSchema.DatabaseSnapshotBaseName = (System.String)value;
						break;
						case 20:
						this.XRuntime.DateCorrelationOptimization = (System.Boolean)value;
						break;
						case 21:
						this.XRuntime.DboLogin = (System.Boolean)value;
						break;
						case 22:
						this.XRuntime.DefaultFileGroup = (System.String)value;
						break;
						case 23:
						this.XSchema.DefaultSchema = (System.String)value;
						break;
						case 24:
						this.XRuntime.EncryptionEnabled = (System.Boolean)value;
						break;
						case 25:
						this.XRuntime.HonorBrokerPriority = (System.Boolean)value;
						break;
						case 26:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 27:
						this.XRuntime.IsAccessible = (System.Boolean)value;
						break;
						case 28:
						this.XRuntime.IsDatabaseSnapshot = (System.Boolean)value;
						break;
						case 29:
						this.XRuntime.IsDatabaseSnapshotBase = (System.Boolean)value;
						break;
						case 30:
						this.XRuntime.IsDbAccessAdmin = (System.Boolean)value;
						break;
						case 31:
						this.XRuntime.IsDbBackupOperator = (System.Boolean)value;
						break;
						case 32:
						this.XRuntime.IsDbDatareader = (System.Boolean)value;
						break;
						case 33:
						this.XRuntime.IsDbDatawriter = (System.Boolean)value;
						break;
						case 34:
						this.XRuntime.IsDbDdlAdmin = (System.Boolean)value;
						break;
						case 35:
						this.XRuntime.IsDbDenyDatareader = (System.Boolean)value;
						break;
						case 36:
						this.XRuntime.IsDbDenyDatawriter = (System.Boolean)value;
						break;
						case 37:
						this.XRuntime.IsDbManager = (System.Boolean)value;
						break;
						case 38:
						this.XRuntime.IsDbOwner = (System.Boolean)value;
						break;
						case 39:
						this.XRuntime.IsDbSecurityAdmin = (System.Boolean)value;
						break;
						case 40:
						this.XRuntime.IsFabricDatabase = (System.Boolean)value;
						break;
						case 41:
						this.XRuntime.IsFullTextEnabled = (System.Boolean)value;
						break;
						case 42:
						this.XRuntime.IsLoginManager = (System.Boolean)value;
						break;
						case 43:
						this.XRuntime.IsMaxSizeApplicable = (System.Boolean)value;
						break;
						case 44:
						this.XRuntime.IsMirroringEnabled = (System.Boolean)value;
						break;
						case 45:
						this.XRuntime.IsParameterizationForced = (System.Boolean)value;
						break;
						case 46:
						this.XRuntime.IsReadCommittedSnapshotOn = (System.Boolean)value;
						break;
						case 47:
						this.XRuntime.IsSqlDw = (System.Boolean)value;
						break;
						case 48:
						this.XRuntime.IsSystemObject = (System.Boolean)value;
						break;
						case 49:
						this.XRuntime.IsUpdateable = (System.Boolean)value;
						break;
						case 50:
						this.XRuntime.LastGoodCheckDbTime = (System.DateTime)value;
						break;
						case 51:
						this.XRuntime.MaxSizeInBytes = (System.Double)value;
						break;
						case 52:
						this.XRuntime.NumericRoundAbortEnabled = (System.Boolean)value;
						break;
						case 53:
						this.XRuntime.Owner = (System.String)value;
						break;
						case 54:
						this.XRuntime.QuotedIdentifiersEnabled = (System.Boolean)value;
						break;
						case 55:
						this.XRuntime.ReadOnly = (System.Boolean)value;
						break;
						case 56:
						this.XRuntime.RealEngineEdition = (System.Int32)value;
						break;
						case 57:
						this.XRuntime.RecursiveTriggersEnabled = (System.Boolean)value;
						break;
						case 58:
						this.XRuntime.ReplicationOptions = (Microsoft.SqlServer.Management.Smo.ReplicationOptions)value;
						break;
						case 59:
						this.XRuntime.ServiceBrokerGuid = (System.Guid)value;
						break;
						case 60:
						this.XRuntime.Size = (System.Double)value;
						break;
						case 61:
						this.XRuntime.SnapshotIsolationState = (Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)value;
						break;
						case 62:
						this.XRuntime.SpaceAvailable = (System.Double)value;
						break;
						case 63:
						this.XRuntime.Status = (Microsoft.SqlServer.Management.Smo.DatabaseStatus)value;
						break;
						case 64:
						this.XRuntime.Trustworthy = (System.Boolean)value;
						break;
						case 65:
						this.XRuntime.UserAccess = (Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)value;
						break;
						case 66:
						this.XRuntime.UserName = (System.String)value;
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
						this.XRuntime.AnsiNullDefault = (System.Boolean)value;
						break;
						case 1:
						this.XRuntime.AnsiNullsEnabled = (System.Boolean)value;
						break;
						case 2:
						this.XRuntime.AnsiPaddingEnabled = (System.Boolean)value;
						break;
						case 3:
						this.XRuntime.AnsiWarningsEnabled = (System.Boolean)value;
						break;
						case 4:
						this.XRuntime.ArithmeticAbortEnabled = (System.Boolean)value;
						break;
						case 5:
						this.XRuntime.AutoCreateIncrementalStatisticsEnabled = (System.Boolean)value;
						break;
						case 6:
						this.XRuntime.AutoCreateStatisticsEnabled = (System.Boolean)value;
						break;
						case 7:
						this.XRuntime.AutoShrink = (System.Boolean)value;
						break;
						case 8:
						this.XRuntime.AutoUpdateStatisticsAsync = (System.Boolean)value;
						break;
						case 9:
						this.XRuntime.AutoUpdateStatisticsEnabled = (System.Boolean)value;
						break;
						case 10:
						this.XRuntime.AzureEdition = (System.String)value;
						break;
						case 11:
						this.XRuntime.AzureServiceObjective = (System.String)value;
						break;
						case 12:
						this.XRuntime.CaseSensitive = (System.Boolean)value;
						break;
						case 13:
						this.XRuntime.CatalogCollation = (Microsoft.SqlServer.Management.Smo.CatalogCollationType)value;
						break;
						case 14:
						this.XRuntime.ChangeTrackingAutoCleanUp = (System.Boolean)value;
						break;
						case 15:
						this.XRuntime.ChangeTrackingEnabled = (System.Boolean)value;
						break;
						case 16:
						this.XRuntime.ChangeTrackingRetentionPeriod = (System.Int32)value;
						break;
						case 17:
						this.XRuntime.ChangeTrackingRetentionPeriodUnits = (Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits)value;
						break;
						case 18:
						this.XRuntime.CloseCursorsOnCommitEnabled = (System.Boolean)value;
						break;
						case 19:
						this.XSchema.Collation = (System.String)value;
						break;
						case 20:
						this.XRuntime.CompatibilityLevel = (Microsoft.SqlServer.Management.Smo.CompatibilityLevel)value;
						break;
						case 21:
						this.XRuntime.ConcatenateNullYieldsNull = (System.Boolean)value;
						break;
						case 22:
						this.XRuntime.CreateDate = (System.DateTime)value;
						break;
						case 23:
						this.XRuntime.DatabaseOwnershipChaining = (System.Boolean)value;
						break;
						case 24:
						this.XSchema.DatabaseSnapshotBaseName = (System.String)value;
						break;
						case 25:
						this.XRuntime.DateCorrelationOptimization = (System.Boolean)value;
						break;
						case 26:
						this.XRuntime.DboLogin = (System.Boolean)value;
						break;
						case 27:
						this.XRuntime.DefaultFileGroup = (System.String)value;
						break;
						case 28:
						this.XRuntime.DefaultFullTextCatalog = (System.String)value;
						break;
						case 29:
						this.XSchema.DefaultSchema = (System.String)value;
						break;
						case 30:
						this.XRuntime.EncryptionEnabled = (System.Boolean)value;
						break;
						case 31:
						this.XRuntime.HasFileInCloud = (System.Boolean)value;
						break;
						case 32:
						this.XRuntime.HasMemoryOptimizedObjects = (System.Boolean)value;
						break;
						case 33:
						this.XRuntime.HonorBrokerPriority = (System.Boolean)value;
						break;
						case 34:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 35:
						this.XRuntime.IsAccessible = (System.Boolean)value;
						break;
						case 36:
						this.XRuntime.IsDatabaseSnapshot = (System.Boolean)value;
						break;
						case 37:
						this.XRuntime.IsDatabaseSnapshotBase = (System.Boolean)value;
						break;
						case 38:
						this.XRuntime.IsDbAccessAdmin = (System.Boolean)value;
						break;
						case 39:
						this.XRuntime.IsDbBackupOperator = (System.Boolean)value;
						break;
						case 40:
						this.XRuntime.IsDbDatareader = (System.Boolean)value;
						break;
						case 41:
						this.XRuntime.IsDbDatawriter = (System.Boolean)value;
						break;
						case 42:
						this.XRuntime.IsDbDdlAdmin = (System.Boolean)value;
						break;
						case 43:
						this.XRuntime.IsDbDenyDatareader = (System.Boolean)value;
						break;
						case 44:
						this.XRuntime.IsDbDenyDatawriter = (System.Boolean)value;
						break;
						case 45:
						this.XRuntime.IsDbManager = (System.Boolean)value;
						break;
						case 46:
						this.XRuntime.IsDbOwner = (System.Boolean)value;
						break;
						case 47:
						this.XRuntime.IsDbSecurityAdmin = (System.Boolean)value;
						break;
						case 48:
						this.XRuntime.IsFabricDatabase = (System.Boolean)value;
						break;
						case 49:
						this.XRuntime.IsFullTextEnabled = (System.Boolean)value;
						break;
						case 50:
						this.XRuntime.IsLedger = (System.Boolean)value;
						break;
						case 51:
						this.XRuntime.IsLoginManager = (System.Boolean)value;
						break;
						case 52:
						this.XRuntime.IsMaxSizeApplicable = (System.Boolean)value;
						break;
						case 53:
						this.XRuntime.IsMirroringEnabled = (System.Boolean)value;
						break;
						case 54:
						this.XRuntime.IsParameterizationForced = (System.Boolean)value;
						break;
						case 55:
						this.XRuntime.IsReadCommittedSnapshotOn = (System.Boolean)value;
						break;
						case 56:
						this.XRuntime.IsSqlDw = (System.Boolean)value;
						break;
						case 57:
						this.XRuntime.IsSqlDwEdition = (System.Boolean)value;
						break;
						case 58:
						this.XRuntime.IsSystemObject = (System.Boolean)value;
						break;
						case 59:
						this.XRuntime.IsUpdateable = (System.Boolean)value;
						break;
						case 60:
						this.XRuntime.LastGoodCheckDbTime = (System.DateTime)value;
						break;
						case 61:
						this.XRuntime.LegacyCardinalityEstimation = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
						break;
						case 62:
						this.XRuntime.LegacyCardinalityEstimationForSecondary = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
						break;
						case 63:
						this.XRuntime.MaxDop = (System.Int32)value;
						break;
						case 64:
						this.XRuntime.MaxDopForSecondary = (System.Int32)value;
						break;
						case 65:
						this.XRuntime.MaxSizeInBytes = (System.Double)value;
						break;
						case 66:
						this.XRuntime.MemoryAllocatedToMemoryOptimizedObjectsInKB = (System.Double)value;
						break;
						case 67:
						this.XRuntime.MemoryUsedByMemoryOptimizedObjectsInKB = (System.Double)value;
						break;
						case 68:
						this.XRuntime.NumericRoundAbortEnabled = (System.Boolean)value;
						break;
						case 69:
						this.XRuntime.Owner = (System.String)value;
						break;
						case 70:
						this.XRuntime.ParameterSniffing = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
						break;
						case 71:
						this.XRuntime.ParameterSniffingForSecondary = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
						break;
						case 72:
						this.XRuntime.QueryOptimizerHotfixes = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
						break;
						case 73:
						this.XRuntime.QueryOptimizerHotfixesForSecondary = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
						break;
						case 74:
						this.XRuntime.QuotedIdentifiersEnabled = (System.Boolean)value;
						break;
						case 75:
						this.XRuntime.ReadOnly = (System.Boolean)value;
						break;
						case 76:
						this.XRuntime.RealEngineEdition = (System.Int32)value;
						break;
						case 77:
						this.XRuntime.RecursiveTriggersEnabled = (System.Boolean)value;
						break;
						case 78:
						this.XRuntime.ReplicationOptions = (Microsoft.SqlServer.Management.Smo.ReplicationOptions)value;
						break;
						case 79:
						this.XRuntime.ServiceBrokerGuid = (System.Guid)value;
						break;
						case 80:
						this.XRuntime.Size = (System.Double)value;
						break;
						case 81:
						this.XRuntime.SnapshotIsolationState = (Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)value;
						break;
						case 82:
						this.XRuntime.SpaceAvailable = (System.Double)value;
						break;
						case 83:
						this.XRuntime.Status = (Microsoft.SqlServer.Management.Smo.DatabaseStatus)value;
						break;
						case 84:
						this.XRuntime.TemporalHistoryRetentionEnabled = (System.Boolean)value;
						break;
						case 85:
						this.XRuntime.Trustworthy = (System.Boolean)value;
						break;
						case 86:
						this.XRuntime.UserAccess = (Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)value;
						break;
						case 87:
						this.XRuntime.UserName = (System.String)value;
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
					case 133:
					this.XRuntime.AcceleratedRecoveryEnabled = (System.Boolean)value;
					break;
					case 0:
					this.XRuntime.ActiveConnections = (System.Int32)value;
					break;
					case 33:
					this.XRuntime.AnsiNullDefault = (System.Boolean)value;
					break;
					case 34:
					this.XRuntime.AnsiNullsEnabled = (System.Boolean)value;
					break;
					case 35:
					this.XRuntime.AnsiPaddingEnabled = (System.Boolean)value;
					break;
					case 36:
					this.XRuntime.AnsiWarningsEnabled = (System.Boolean)value;
					break;
					case 37:
					this.XRuntime.ArithmeticAbortEnabled = (System.Boolean)value;
					break;
					case 1:
					this.XRuntime.AutoClose = (System.Boolean)value;
					break;
					case 113:
					this.XRuntime.AutoCreateIncrementalStatisticsEnabled = (System.Boolean)value;
					break;
					case 38:
					this.XRuntime.AutoCreateStatisticsEnabled = (System.Boolean)value;
					break;
					case 2:
					this.XRuntime.AutoShrink = (System.Boolean)value;
					break;
					case 59:
					this.XRuntime.AutoUpdateStatisticsAsync = (System.Boolean)value;
					break;
					case 39:
					this.XRuntime.AutoUpdateStatisticsEnabled = (System.Boolean)value;
					break;
					case 100:
					this.XSchema.AvailabilityDatabaseSynchronizationState = (Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState)value;
					break;
					case 101:
					this.XSchema.AvailabilityGroupName = (System.String)value;
					break;
					case 60:
					this.XRuntime.BrokerEnabled = (System.Boolean)value;
					break;
					case 40:
					this.XRuntime.CaseSensitive = (System.Boolean)value;
					break;
					case 134:
					this.XRuntime.CatalogCollation = (Microsoft.SqlServer.Management.Smo.CatalogCollationType)value;
					break;
					case 90:
					this.XRuntime.ChangeTrackingAutoCleanUp = (System.Boolean)value;
					break;
					case 91:
					this.XRuntime.ChangeTrackingEnabled = (System.Boolean)value;
					break;
					case 92:
					this.XRuntime.ChangeTrackingRetentionPeriod = (System.Int32)value;
					break;
					case 93:
					this.XRuntime.ChangeTrackingRetentionPeriodUnits = (Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits)value;
					break;
					case 41:
					this.XRuntime.CloseCursorsOnCommitEnabled = (System.Boolean)value;
					break;
					case 42:
					this.XSchema.Collation = (System.String)value;
					break;
					case 3:
					this.XRuntime.CompatibilityLevel = (Microsoft.SqlServer.Management.Smo.CompatibilityLevel)value;
					break;
					case 43:
					this.XRuntime.ConcatenateNullYieldsNull = (System.Boolean)value;
					break;
					case 102:
					this.XRuntime.ContainmentType = (Microsoft.SqlServer.Management.Smo.ContainmentType)value;
					break;
					case 4:
					this.XRuntime.CreateDate = (System.DateTime)value;
					break;
					case 61:
					this.XRuntime.DatabaseGuid = (System.Guid)value;
					break;
					case 44:
					this.XRuntime.DatabaseOwnershipChaining = (System.Boolean)value;
					break;
					case 62:
					this.XSchema.DatabaseSnapshotBaseName = (System.String)value;
					break;
					case 135:
					this.XSchema.DataRetentionEnabled = (System.Boolean)value;
					break;
					case 5:
					this.XRuntime.DataSpaceUsage = (System.Double)value;
					break;
					case 63:
					this.XRuntime.DateCorrelationOptimization = (System.Boolean)value;
					break;
					case 6:
					this.XRuntime.DboLogin = (System.Boolean)value;
					break;
					case 7:
					this.XRuntime.DefaultFileGroup = (System.String)value;
					break;
					case 94:
					this.XRuntime.DefaultFileStreamFileGroup = (System.String)value;
					break;
					case 64:
					this.XRuntime.DefaultFullTextCatalog = (System.String)value;
					break;
					case 103:
					this.XRuntime.DefaultFullTextLanguageLcid = (System.Int32)value;
					break;
					case 104:
					this.XRuntime.DefaultFullTextLanguageName = (System.String)value;
					break;
					case 105:
					this.XRuntime.DefaultLanguageLcid = (System.Int32)value;
					break;
					case 106:
					this.XRuntime.DefaultLanguageName = (System.String)value;
					break;
					case 8:
					this.XSchema.DefaultSchema = (System.String)value;
					break;
					case 114:
					this.XRuntime.DelayedDurability = (Microsoft.SqlServer.Management.Smo.DelayedDurability)value;
					break;
					case 95:
					this.XRuntime.EncryptionEnabled = (System.Boolean)value;
					break;
					case 107:
					this.XRuntime.FilestreamDirectoryName = (System.String)value;
					break;
					case 108:
					this.XRuntime.FilestreamNonTransactedAccess = (Microsoft.SqlServer.Management.Smo.FilestreamNonTransactedAccessType)value;
					break;
					case 96:
					this.XRuntime.HasDatabaseEncryptionKey = (System.Boolean)value;
					break;
					case 115:
					this.XRuntime.HasFileInCloud = (System.Boolean)value;
					break;
					case 65:
					this.XRuntime.HasFullBackup = (System.Boolean)value;
					break;
					case 116:
					this.XRuntime.HasMemoryOptimizedObjects = (System.Boolean)value;
					break;
					case 97:
					this.XRuntime.HonorBrokerPriority = (System.Boolean)value;
					break;
					case 9:
					this.XRuntime.ID = (System.Int32)value;
					break;
					case 10:
					this.XRuntime.IndexSpaceUsage = (System.Double)value;
					break;
					case 11:
					this.XRuntime.IsAccessible = (System.Boolean)value;
					break;
					case 66:
					this.XRuntime.IsDatabaseSnapshot = (System.Boolean)value;
					break;
					case 67:
					this.XRuntime.IsDatabaseSnapshotBase = (System.Boolean)value;
					break;
					case 12:
					this.XRuntime.IsDbAccessAdmin = (System.Boolean)value;
					break;
					case 13:
					this.XRuntime.IsDbBackupOperator = (System.Boolean)value;
					break;
					case 14:
					this.XRuntime.IsDbDatareader = (System.Boolean)value;
					break;
					case 15:
					this.XRuntime.IsDbDatawriter = (System.Boolean)value;
					break;
					case 16:
					this.XRuntime.IsDbDdlAdmin = (System.Boolean)value;
					break;
					case 17:
					this.XRuntime.IsDbDenyDatareader = (System.Boolean)value;
					break;
					case 18:
					this.XRuntime.IsDbDenyDatawriter = (System.Boolean)value;
					break;
					case 19:
					this.XRuntime.IsDbOwner = (System.Boolean)value;
					break;
					case 20:
					this.XRuntime.IsDbSecurityAdmin = (System.Boolean)value;
					break;
					case 21:
					this.XRuntime.IsFabricDatabase = (System.Boolean)value;
					break;
					case 22:
					this.XRuntime.IsFullTextEnabled = (System.Boolean)value;
					break;
					case 138:
					this.XRuntime.IsLedger = (System.Boolean)value;
					break;
					case 68:
					this.XRuntime.IsMailHost = (System.Boolean)value;
					break;
					case 98:
					this.XRuntime.IsManagementDataWarehouse = (System.Boolean)value;
					break;
					case 23:
					this.XRuntime.IsMirroringEnabled = (System.Boolean)value;
					break;
					case 69:
					this.XRuntime.IsParameterizationForced = (System.Boolean)value;
					break;
					case 70:
					this.XRuntime.IsReadCommittedSnapshotOn = (System.Boolean)value;
					break;
					case 24:
					this.XRuntime.IsSqlDw = (System.Boolean)value;
					break;
					case 25:
					this.XRuntime.IsSystemObject = (System.Boolean)value;
					break;
					case 45:
					this.XRuntime.IsUpdateable = (System.Boolean)value;
					break;
					case 71:
					this.XRuntime.IsVarDecimalStorageFormatEnabled = (System.Boolean)value;
					break;
					case 46:
					this.XRuntime.LastBackupDate = (System.DateTime)value;
					break;
					case 47:
					this.XSchema.LastDifferentialBackupDate = (System.DateTime)value;
					break;
					case 48:
					this.XRuntime.LastGoodCheckDbTime = (System.DateTime)value;
					break;
					case 49:
					this.XRuntime.LastLogBackupDate = (System.DateTime)value;
					break;
					case 119:
					this.XRuntime.LegacyCardinalityEstimation = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
					break;
					case 120:
					this.XRuntime.LegacyCardinalityEstimationForSecondary = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
					break;
					case 50:
					this.XRuntime.LocalCursorsDefault = (System.Boolean)value;
					break;
					case 72:
					this.XRuntime.LogReuseWaitStatus = (Microsoft.SqlServer.Management.Smo.LogReuseWaitStatus)value;
					break;
					case 121:
					this.XRuntime.MaxDop = (System.Int32)value;
					break;
					case 122:
					this.XRuntime.MaxDopForSecondary = (System.Int32)value;
					break;
					case 117:
					this.XRuntime.MemoryAllocatedToMemoryOptimizedObjectsInKB = (System.Double)value;
					break;
					case 118:
					this.XRuntime.MemoryUsedByMemoryOptimizedObjectsInKB = (System.Double)value;
					break;
					case 73:
					this.XRuntime.MirroringFailoverLogSequenceNumber = (System.Decimal)value;
					break;
					case 74:
					this.XRuntime.MirroringID = (System.Guid)value;
					break;
					case 75:
					this.XRuntime.MirroringPartner = (System.String)value;
					break;
					case 76:
					this.XRuntime.MirroringPartnerInstance = (System.String)value;
					break;
					case 77:
					this.XRuntime.MirroringRedoQueueMaxSize = (System.Int32)value;
					break;
					case 78:
					this.XRuntime.MirroringRole = (Microsoft.SqlServer.Management.Smo.MirroringRole)value;
					break;
					case 79:
					this.XRuntime.MirroringRoleSequence = (System.Int32)value;
					break;
					case 80:
					this.XRuntime.MirroringSafetyLevel = (Microsoft.SqlServer.Management.Smo.MirroringSafetyLevel)value;
					break;
					case 81:
					this.XRuntime.MirroringSafetySequence = (System.Int32)value;
					break;
					case 82:
					this.XRuntime.MirroringStatus = (Microsoft.SqlServer.Management.Smo.MirroringStatus)value;
					break;
					case 83:
					this.XRuntime.MirroringTimeout = (System.Int32)value;
					break;
					case 84:
					this.XRuntime.MirroringWitness = (System.String)value;
					break;
					case 85:
					this.XRuntime.MirroringWitnessStatus = (Microsoft.SqlServer.Management.Smo.MirroringWitnessStatus)value;
					break;
					case 109:
					this.XRuntime.NestedTriggersEnabled = (System.Boolean)value;
					break;
					case 51:
					this.XRuntime.NumericRoundAbortEnabled = (System.Boolean)value;
					break;
					case 26:
					this.XRuntime.Owner = (System.String)value;
					break;
					case 52:
					this.XRuntime.PageVerify = (Microsoft.SqlServer.Management.Smo.PageVerify)value;
					break;
					case 123:
					this.XRuntime.ParameterSniffing = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
					break;
					case 124:
					this.XRuntime.ParameterSniffingForSecondary = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
					break;
					case 136:
					this.XRuntime.PersistentVersionStoreFileGroup = (System.String)value;
					break;
					case 137:
					this.XRuntime.PersistentVersionStoreSizeKB = (System.Int64)value;
					break;
					case 99:
					this.XRuntime.PolicyHealthState = (Microsoft.SqlServer.Management.Dmf.PolicyHealthState)value;
					break;
					case 27:
					this.XRuntime.PrimaryFilePath = (System.String)value;
					break;
					case 125:
					this.XRuntime.QueryOptimizerHotfixes = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
					break;
					case 126:
					this.XRuntime.QueryOptimizerHotfixesForSecondary = (Microsoft.SqlServer.Management.Smo.DatabaseScopedConfigurationOnOff)value;
					break;
					case 53:
					this.XRuntime.QuotedIdentifiersEnabled = (System.Boolean)value;
					break;
					case 54:
					this.XRuntime.ReadOnly = (System.Boolean)value;
					break;
					case 86:
					this.XRuntime.RecoveryForkGuid = (System.Guid)value;
					break;
					case 55:
					this.XRuntime.RecoveryModel = (Microsoft.SqlServer.Management.Smo.RecoveryModel)value;
					break;
					case 56:
					this.XRuntime.RecursiveTriggersEnabled = (System.Boolean)value;
					break;
					case 127:
					this.XRuntime.RemoteDataArchiveCredential = (System.String)value;
					break;
					case 128:
					this.XRuntime.RemoteDataArchiveEnabled = (System.Boolean)value;
					break;
					case 129:
					this.XRuntime.RemoteDataArchiveEndpoint = (System.String)value;
					break;
					case 130:
					this.XRuntime.RemoteDataArchiveLinkedServer = (System.String)value;
					break;
					case 131:
					this.XRuntime.RemoteDataArchiveUseFederatedServiceAccount = (System.Boolean)value;
					break;
					case 132:
					this.XRuntime.RemoteDatabaseName = (System.String)value;
					break;
					case 28:
					this.XRuntime.ReplicationOptions = (Microsoft.SqlServer.Management.Smo.ReplicationOptions)value;
					break;
					case 87:
					this.XRuntime.ServiceBrokerGuid = (System.Guid)value;
					break;
					case 29:
					this.XRuntime.Size = (System.Double)value;
					break;
					case 88:
					this.XRuntime.SnapshotIsolationState = (Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)value;
					break;
					case 30:
					this.XRuntime.SpaceAvailable = (System.Double)value;
					break;
					case 31:
					this.XRuntime.Status = (Microsoft.SqlServer.Management.Smo.DatabaseStatus)value;
					break;
					case 110:
					this.XRuntime.TargetRecoveryTime = (System.Int32)value;
					break;
					case 111:
					this.XRuntime.TransformNoiseWords = (System.Boolean)value;
					break;
					case 89:
					this.XRuntime.Trustworthy = (System.Boolean)value;
					break;
					case 112:
					this.XRuntime.TwoDigitYearCutoff = (System.Int32)value;
					break;
					case 57:
					this.XRuntime.UserAccess = (Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)value;
					break;
					case 32:
					this.XRuntime.UserName = (System.String)value;
					break;
					case 58:
					this.XRuntime.Version = (System.Int32)value;
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

		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AcceleratedRecoveryEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AcceleratedRecoveryEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AcceleratedRecoveryEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 ActiveConnections
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ActiveConnections");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AnsiNullDefault
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullDefault");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullDefault", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean AnsiNullsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean AnsiPaddingEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiPaddingEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiPaddingEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AnsiWarningsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiWarningsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiWarningsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ArithmeticAbortEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ArithmeticAbortEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ArithmeticAbortEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public System.Boolean AutoClose
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutoClose");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutoClose", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AutoCreateIncrementalStatisticsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutoCreateIncrementalStatisticsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutoCreateIncrementalStatisticsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AutoCreateStatisticsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutoCreateStatisticsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutoCreateStatisticsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AutoShrink
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutoShrink");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutoShrink", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AutoUpdateStatisticsAsync
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutoUpdateStatisticsAsync");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutoUpdateStatisticsAsync", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AutoUpdateStatisticsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutoUpdateStatisticsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutoUpdateStatisticsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState AvailabilityDatabaseSynchronizationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityDatabaseSynchronizationState)this.Properties.GetValueWithNullReplacement("AvailabilityDatabaseSynchronizationState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String AvailabilityGroupName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AvailabilityGroupName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean BrokerEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("BrokerEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BrokerEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean CaseSensitive
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("CaseSensitive");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ChangeTrackingAutoCleanUp
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ChangeTrackingAutoCleanUp");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ChangeTrackingAutoCleanUp", value);
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
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ChangeTrackingRetentionPeriod
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ChangeTrackingRetentionPeriod");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ChangeTrackingRetentionPeriod", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits ChangeTrackingRetentionPeriodUnits
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.RetentionPeriodUnits)this.Properties.GetValueWithNullReplacement("ChangeTrackingRetentionPeriodUnits");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ChangeTrackingRetentionPeriodUnits", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean CloseCursorsOnCommitEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("CloseCursorsOnCommitEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CloseCursorsOnCommitEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "SQL_Latin1_General_CP1_CI_AS")]
		public System.String Collation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Collation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Collation", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.CompatibilityLevel CompatibilityLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.CompatibilityLevel)this.Properties.GetValueWithNullReplacement("CompatibilityLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CompatibilityLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ConcatenateNullYieldsNull
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ConcatenateNullYieldsNull");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConcatenateNullYieldsNull", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ContainmentType ContainmentType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ContainmentType)this.Properties.GetValueWithNullReplacement("ContainmentType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ContainmentType", value);
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
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Guid DatabaseGuid
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("DatabaseGuid");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DatabaseSnapshotBaseName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DatabaseSnapshotBaseName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DatabaseSnapshotBaseName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
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
		public System.Double DataSpaceUsage
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("DataSpaceUsage");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean DateCorrelationOptimization
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DateCorrelationOptimization");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DateCorrelationOptimization", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean DboLogin
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DboLogin");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DefaultFileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultFileGroup");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String DefaultFileStreamFileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultFileStreamFileGroup");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DefaultFullTextCatalog
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultFullTextCatalog");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultFullTextCatalog", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DelayedDurability DelayedDurability
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DelayedDurability)this.Properties.GetValueWithNullReplacement("DelayedDurability");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DelayedDurability", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean EncryptionEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("EncryptionEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptionEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FilestreamDirectoryName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FilestreamDirectoryName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FilestreamDirectoryName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.FilestreamNonTransactedAccessType FilestreamNonTransactedAccess
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.FilestreamNonTransactedAccessType)this.Properties.GetValueWithNullReplacement("FilestreamNonTransactedAccess");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FilestreamNonTransactedAccess", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean HasDatabaseEncryptionKey
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasDatabaseEncryptionKey");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasFileInCloud
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasFileInCloud");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasMemoryOptimizedObjects
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasMemoryOptimizedObjects");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HonorBrokerPriority
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HonorBrokerPriority");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HonorBrokerPriority", value);
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
		public System.Double IndexSpaceUsage
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("IndexSpaceUsage");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsAccessible
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsAccessible");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDatabaseSnapshot
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDatabaseSnapshot");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDatabaseSnapshotBase
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDatabaseSnapshotBase");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbAccessAdmin
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbAccessAdmin");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbBackupOperator
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbBackupOperator");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbDatareader
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbDatareader");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbDatawriter
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbDatawriter");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbDdlAdmin
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbDdlAdmin");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbDenyDatareader
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbDenyDatareader");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbDenyDatawriter
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbDenyDatawriter");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbOwner
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbOwner");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDbSecurityAdmin
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbSecurityAdmin");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFabricDatabase
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFabricDatabase");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFullTextEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFullTextEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsFullTextEnabled", value);
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean IsMailHost
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMailHost");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean IsManagementDataWarehouse
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsManagementDataWarehouse");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsMirroringEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMirroringEnabled");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsParameterizationForced
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsParameterizationForced");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsParameterizationForced", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsReadCommittedSnapshotOn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsReadCommittedSnapshotOn");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsReadCommittedSnapshotOn", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSqlDw
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSqlDw");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSqlDw", value);
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
		public System.Boolean IsUpdateable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsUpdateable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.DateTime LastBackupDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastBackupDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.DateTime LastDifferentialBackupDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastDifferentialBackupDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime LastGoodCheckDbTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastGoodCheckDbTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.DateTime LastLogBackupDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastLogBackupDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Standalone)]
		public System.Boolean LocalCursorsDefault
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("LocalCursorsDefault");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LocalCursorsDefault", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.LogReuseWaitStatus LogReuseWaitStatus
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.LogReuseWaitStatus)this.Properties.GetValueWithNullReplacement("LogReuseWaitStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double MemoryAllocatedToMemoryOptimizedObjectsInKB
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("MemoryAllocatedToMemoryOptimizedObjectsInKB");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double MemoryUsedByMemoryOptimizedObjectsInKB
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("MemoryUsedByMemoryOptimizedObjectsInKB");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Decimal MirroringFailoverLogSequenceNumber
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("MirroringFailoverLogSequenceNumber");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Guid MirroringID
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("MirroringID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String MirroringPartner
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MirroringPartner");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MirroringPartner", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String MirroringPartnerInstance
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MirroringPartnerInstance");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 MirroringRedoQueueMaxSize
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MirroringRedoQueueMaxSize");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 MirroringRoleSequence
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MirroringRoleSequence");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.MirroringSafetyLevel MirroringSafetyLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.MirroringSafetyLevel)this.Properties.GetValueWithNullReplacement("MirroringSafetyLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MirroringSafetyLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 MirroringSafetySequence
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MirroringSafetySequence");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.MirroringStatus MirroringStatus
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.MirroringStatus)this.Properties.GetValueWithNullReplacement("MirroringStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 MirroringTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MirroringTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MirroringTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String MirroringWitness
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MirroringWitness");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MirroringWitness", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.MirroringWitnessStatus MirroringWitnessStatus
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.MirroringWitnessStatus)this.Properties.GetValueWithNullReplacement("MirroringWitnessStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean NestedTriggersEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NestedTriggersEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NestedTriggersEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean NumericRoundAbortEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NumericRoundAbortEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NumericRoundAbortEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Login),"Server[@Name = '{0}']/Login[@Name = '{1}']","Parent.ConnectionContext.TrueName","Owner")]
		[CLSCompliant(false)]
		public System.String Owner
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Owner");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.PageVerify PageVerify
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.PageVerify)this.Properties.GetValueWithNullReplacement("PageVerify");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PageVerify", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(FileGroup),"Server[@Name = '{0}']/Database[@Name = '{1}']/FileGroup[@Name = '{2}']","Parent.ConnectionContext.TrueName","Name","PersistentVersionStoreFileGroup")]
		[CLSCompliant(false)]
		public System.String PersistentVersionStoreFileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PersistentVersionStoreFileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PersistentVersionStoreFileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 PersistentVersionStoreSizeKB
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("PersistentVersionStoreSizeKB");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String PrimaryFilePath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PrimaryFilePath");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean QuotedIdentifiersEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("QuotedIdentifiersEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QuotedIdentifiersEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ReadOnly
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ReadOnly");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReadOnly", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Guid RecoveryForkGuid
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("RecoveryForkGuid");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.RecoveryModel RecoveryModel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.RecoveryModel)this.Properties.GetValueWithNullReplacement("RecoveryModel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RecoveryModel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean RecursiveTriggersEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("RecursiveTriggersEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RecursiveTriggersEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String RemoteDataArchiveCredential
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveCredential");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveCredential", value);
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String RemoteDataArchiveEndpoint
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveEndpoint");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveEndpoint", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String RemoteDataArchiveLinkedServer
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveLinkedServer");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveLinkedServer", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean RemoteDataArchiveUseFederatedServiceAccount
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("RemoteDataArchiveUseFederatedServiceAccount");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDataArchiveUseFederatedServiceAccount", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String RemoteDatabaseName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RemoteDatabaseName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RemoteDatabaseName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ReplicationOptions ReplicationOptions
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ReplicationOptions)this.Properties.GetValueWithNullReplacement("ReplicationOptions");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Guid ServiceBrokerGuid
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("ServiceBrokerGuid");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double Size
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("Size");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SnapshotIsolationState SnapshotIsolationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)this.Properties.GetValueWithNullReplacement("SnapshotIsolationState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double SpaceAvailable
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("SpaceAvailable");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseStatus Status
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseStatus)this.Properties.GetValueWithNullReplacement("Status");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 TargetRecoveryTime
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TargetRecoveryTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TargetRecoveryTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean TransformNoiseWords
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("TransformNoiseWords");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TransformNoiseWords", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Trustworthy
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Trustworthy");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Trustworthy", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 TwoDigitYearCutoff
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TwoDigitYearCutoff");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TwoDigitYearCutoff", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseUserAccess UserAccess
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)this.Properties.GetValueWithNullReplacement("UserAccess");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UserAccess", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String UserName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("UserName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 Version
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Version");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.String AzureEdition
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AzureEdition");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AzureEdition", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.String AzureServiceObjective
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AzureServiceObjective");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AzureServiceObjective", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase)]
		public System.Boolean IsDbManager
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDbManager");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase)]
		public System.Boolean IsLoginManager
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsLoginManager");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.Boolean IsMaxSizeApplicable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMaxSizeApplicable");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.Boolean IsSqlDwEdition
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSqlDwEdition");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.Double MaxSizeInBytes
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("MaxSizeInBytes");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaxSizeInBytes", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase)]
		public System.Boolean TemporalHistoryRetentionEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("TemporalHistoryRetentionEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TemporalHistoryRetentionEnabled", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "CatalogCollation", "DatabaseSnapshotBaseName", "IsLedger", "RemoteDataArchiveLinkedServer", "RemoteDatabaseName" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "AnsiNullsEnabled":
					return false;
				case "AnsiPaddingEnabled":
					return false;
				case "Collation":
					return "SQL_Latin1_General_CP1_CI_AS";
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}

		public void Deny(DatabasePermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Deny(DatabasePermissionSet permission, System.String[] granteeNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, cascade, null);
		}
		
		public void Grant(DatabasePermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Grant(DatabasePermissionSet permission, System.String[] granteeNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, null);
		}
		
		public void Grant(DatabasePermissionSet permission, System.String[] granteeNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, asRole);
		}
		
		public void Revoke(DatabasePermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Revoke(DatabasePermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(DatabasePermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, asRole);
		}
		

		public void Deny(DatabasePermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Deny(DatabasePermissionSet permission, System.String granteeName, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, cascade, null);
		}
		
		public void Grant(DatabasePermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Grant(DatabasePermissionSet permission, System.String granteeName, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, null);
		}
		
		public void Grant(DatabasePermissionSet permission, System.String granteeName, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, asRole);
		}
		
		public void Revoke(DatabasePermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Revoke(DatabasePermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(DatabasePermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, asRole);
		}
		

		public DatabasePermissionInfo[] EnumDatabasePermissions()
		{
			return (DatabasePermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Database, this, null, null);
		}
		
		public DatabasePermissionInfo[] EnumDatabasePermissions(System.String granteeName)
		{
			return (DatabasePermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Database, this, granteeName, null);
		}
		
		public DatabasePermissionInfo[] EnumDatabasePermissions(DatabasePermissionSet permissions)
		{
			return (DatabasePermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Database, this, null, permissions);
		}
		
		public DatabasePermissionInfo[] EnumDatabasePermissions(System.String granteeName, DatabasePermissionSet permissions)
		{
			return (DatabasePermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Database, this, granteeName, permissions);
		}
		

		public ObjectPermissionInfo[] EnumObjectPermissions()
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, null, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, granteeName, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, null, permissions);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName, ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumAllPermissions(this, granteeName, permissions);
		}
		

      private DatabaseEvents events;
      public DatabaseEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new DatabaseEvents(this);
              }
              return this.events;
          }
      }
    
	}





      public class DatabaseEvents
      {
      internal DatabaseEvents(Database parent)
      {
          this.parent = parent;
      }

      public DatabaseEventSet GetEventSelection()
      {
          InitializeEvents();
          return (DatabaseEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(DatabaseEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(DatabaseEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(DatabaseEventSet events)
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
              serverEventsWorker = new DatabaseEventsWorker(parent);

          }
      }

      private DatabaseEventsWorker serverEventsWorker;
      private Database parent;
      }
    
}
