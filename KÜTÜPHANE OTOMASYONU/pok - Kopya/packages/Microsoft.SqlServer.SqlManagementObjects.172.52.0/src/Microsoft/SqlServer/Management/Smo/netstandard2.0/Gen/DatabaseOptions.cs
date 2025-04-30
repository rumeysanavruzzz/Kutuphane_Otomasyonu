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
	/// Instance class encapsulating : Server[@Name='']/Database/Option
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class DatabaseOptions 
	{
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
							case "AutoClose": return 5;
							case "AutoCreateStatistics": return 6;
							case "AutoShrink": return 7;
							case "AutoUpdateStatistics": return 8;
							case "AutoUpdateStatisticsAsync": return 9;
							case "BrokerEnabled": return 10;
							case "CloseCursorsOnCommitEnabled": return 11;
							case "ConcatenateNullYieldsNull": return 12;
							case "DatabaseOwnershipChaining": return 13;
							case "DateCorrelationOptimization": return 14;
							case "IsParameterizationForced": return 15;
							case "LocalCursorsDefault": return 16;
							case "NumericRoundAbortEnabled": return 17;
							case "PageVerify": return 18;
							case "QuotedIdentifiersEnabled": return 19;
							case "ReadOnly": return 20;
							case "RecoveryModel": return 21;
							case "RecursiveTriggersEnabled": return 22;
							case "SnapshotIsolationState": return 23;
							case "Trustworthy": return 24;
							case "UserAccess": return 25;
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
							case "AutoClose": return 5;
							case "AutoCreateStatistics": return 6;
							case "AutoShrink": return 7;
							case "AutoUpdateStatistics": return 8;
							case "AutoUpdateStatisticsAsync": return 9;
							case "BrokerEnabled": return 10;
							case "CloseCursorsOnCommitEnabled": return 11;
							case "ConcatenateNullYieldsNull": return 12;
							case "DatabaseOwnershipChaining": return 13;
							case "DateCorrelationOptimization": return 14;
							case "IsParameterizationForced": return 15;
							case "LocalCursorsDefault": return 16;
							case "NumericRoundAbortEnabled": return 17;
							case "PageVerify": return 18;
							case "QuotedIdentifiersEnabled": return 19;
							case "ReadOnly": return 20;
							case "RecoveryModel": return 21;
							case "RecursiveTriggersEnabled": return 22;
							case "SnapshotIsolationState": return 23;
							case "Trustworthy": return 24;
							case "UserAccess": return 25;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AnsiNullDefault": return 0;
						case "AnsiNullsEnabled": return 1;
						case "AnsiWarningsEnabled": return 2;
						case "AutoClose": return 3;
						case "AutoCreateStatistics": return 4;
						case "AutoShrink": return 5;
						case "AutoUpdateStatistics": return 6;
						case "CloseCursorsOnCommitEnabled": return 7;
						case "LocalCursorsDefault": return 8;
						case "QuotedIdentifiersEnabled": return 9;
						case "RecoveryModel": return 10;
						case "RecursiveTriggersEnabled": return 11;
						case "UserAccess": return 12;
						case "AnsiPaddingEnabled": return 13;
						case "ArithmeticAbortEnabled": return 14;
						case "ConcatenateNullYieldsNull": return 15;
						case "DatabaseOwnershipChaining": return 16;
						case "NumericRoundAbortEnabled": return 17;
						case "PageVerify": return 18;
						case "ReadOnly": return 19;
						case "AutoUpdateStatisticsAsync": return 20;
						case "BrokerEnabled": return 21;
						case "DateCorrelationOptimization": return 22;
						case "IsParameterizationForced": return 23;
						case "MirroringRedoQueueMaxSize": return 24;
						case "MirroringTimeout": return 25;
						case "SnapshotIsolationState": return 26;
						case "Trustworthy": return 27;
						case "AutoCreateStatisticsIncremental": return 28;
						case "DataRetentionEnabled": return 29;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 13, 20, 28, 28, 28, 28, 29, 29, 29, 30, 30, 30 };
			static int [] cloudVersionCount = new int [] { 26, 26, 26 };
			static int sqlDwPropertyCount = 26;
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
				new StaticMetadata("AutoClose", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatistics", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoShrink", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatistics", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsAsync", false, false, typeof(System.Boolean)),
				new StaticMetadata("BrokerEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("CloseCursorsOnCommitEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseOwnershipChaining", false, false, typeof(System.Boolean)),
				new StaticMetadata("DateCorrelationOptimization", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsParameterizationForced", false, false, typeof(System.Boolean)),
				new StaticMetadata("LocalCursorsDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericRoundAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PageVerify", false, false, typeof(Microsoft.SqlServer.Management.Smo.PageVerify)),
				new StaticMetadata("QuotedIdentifiersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("RecoveryModel", false, false, typeof(Microsoft.SqlServer.Management.Smo.RecoveryModel)),
				new StaticMetadata("RecursiveTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("SnapshotIsolationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)),
				new StaticMetadata("Trustworthy", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiNullDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiPaddingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarningsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ArithmeticAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoClose", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatistics", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoShrink", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatistics", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsAsync", false, false, typeof(System.Boolean)),
				new StaticMetadata("BrokerEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("CloseCursorsOnCommitEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseOwnershipChaining", false, false, typeof(System.Boolean)),
				new StaticMetadata("DateCorrelationOptimization", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsParameterizationForced", false, false, typeof(System.Boolean)),
				new StaticMetadata("LocalCursorsDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericRoundAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PageVerify", false, false, typeof(Microsoft.SqlServer.Management.Smo.PageVerify)),
				new StaticMetadata("QuotedIdentifiersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("RecoveryModel", false, false, typeof(Microsoft.SqlServer.Management.Smo.RecoveryModel)),
				new StaticMetadata("RecursiveTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("SnapshotIsolationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)),
				new StaticMetadata("Trustworthy", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiNullDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarningsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoClose", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatistics", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoShrink", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatistics", false, false, typeof(System.Boolean)),
				new StaticMetadata("CloseCursorsOnCommitEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("LocalCursorsDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifiersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("RecoveryModel", false, false, typeof(Microsoft.SqlServer.Management.Smo.RecoveryModel)),
				new StaticMetadata("RecursiveTriggersEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserAccess", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseUserAccess)),
				new StaticMetadata("AnsiPaddingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ArithmeticAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("DatabaseOwnershipChaining", true, false, typeof(System.Boolean)),
				new StaticMetadata("NumericRoundAbortEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("PageVerify", false, false, typeof(Microsoft.SqlServer.Management.Smo.PageVerify)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoUpdateStatisticsAsync", false, false, typeof(System.Boolean)),
				new StaticMetadata("BrokerEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("DateCorrelationOptimization", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsParameterizationForced", false, false, typeof(System.Boolean)),
				new StaticMetadata("MirroringRedoQueueMaxSize", false, true, typeof(System.Int32)),
				new StaticMetadata("MirroringTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("SnapshotIsolationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.SnapshotIsolationState)),
				new StaticMetadata("Trustworthy", false, false, typeof(System.Boolean)),
				new StaticMetadata("AutoCreateStatisticsIncremental", false, false, typeof(System.Boolean)),
				new StaticMetadata("DataRetentionEnabled", false, false, typeof(System.Boolean)),
			};
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
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "AnsiNullsEnabled":
					return false;
				case "AnsiPaddingEnabled":
					return false;
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
