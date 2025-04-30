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
	/// Instance class encapsulating : Server[@Name='']/Database/QueryStoreOptions
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class QueryStoreOptions  : ISfcSupportsDesignMode
	{
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
							case "ActualState": return 0;
							case "CurrentStorageSizeInMB": return 1;
							case "DataFlushIntervalInSeconds": return 2;
							case "DesiredState": return 3;
							case "MaxPlansPerQuery": return 4;
							case "MaxStorageSizeInMB": return 5;
							case "QueryCaptureMode": return 6;
							case "ReadOnlyReason": return 7;
							case "SizeBasedCleanupMode": return 8;
							case "StaleQueryThresholdInDays": return 9;
							case "StatisticsCollectionIntervalInMinutes": return 10;
							case "WaitStatsCaptureMode": return 11;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ActualState": return 0;
						case "CurrentStorageSizeInMB": return 1;
						case "DataFlushIntervalInSeconds": return 2;
						case "DesiredState": return 3;
						case "MaxPlansPerQuery": return 4;
						case "MaxStorageSizeInMB": return 5;
						case "QueryCaptureMode": return 6;
						case "ReadOnlyReason": return 7;
						case "SizeBasedCleanupMode": return 8;
						case "StaleQueryThresholdInDays": return 9;
						case "StatisticsCollectionIntervalInMinutes": return 10;
						case "WaitStatsCaptureMode": return 11;
						case "CapturePolicyExecutionCount": return 12;
						case "CapturePolicyStaleThresholdInHrs": return 13;
						case "CapturePolicyTotalCompileCpuTimeInMS": return 14;
						case "CapturePolicyTotalExecutionCpuTimeInMS": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 11, 12, 16, 16, 16 };
			static int [] cloudVersionCount = new int [] { 0, 0, 12 };
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
				new StaticMetadata("ActualState", false, true, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode)),
				new StaticMetadata("CurrentStorageSizeInMB", false, false, typeof(System.Int64)),
				new StaticMetadata("DataFlushIntervalInSeconds", false, false, typeof(System.Int64)),
				new StaticMetadata("DesiredState", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode)),
				new StaticMetadata("MaxPlansPerQuery", false, false, typeof(System.Int64)),
				new StaticMetadata("MaxStorageSizeInMB", false, false, typeof(System.Int64)),
				new StaticMetadata("QueryCaptureMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreCaptureMode)),
				new StaticMetadata("ReadOnlyReason", false, false, typeof(System.Int32)),
				new StaticMetadata("SizeBasedCleanupMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreSizeBasedCleanupMode)),
				new StaticMetadata("StaleQueryThresholdInDays", false, false, typeof(System.Int64)),
				new StaticMetadata("StatisticsCollectionIntervalInMinutes", false, false, typeof(System.Int64)),
				new StaticMetadata("WaitStatsCaptureMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreWaitStatsCaptureMode)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ActualState", false, true, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode)),
				new StaticMetadata("CurrentStorageSizeInMB", false, false, typeof(System.Int64)),
				new StaticMetadata("DataFlushIntervalInSeconds", false, false, typeof(System.Int64)),
				new StaticMetadata("DesiredState", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode)),
				new StaticMetadata("MaxPlansPerQuery", false, false, typeof(System.Int64)),
				new StaticMetadata("MaxStorageSizeInMB", false, false, typeof(System.Int64)),
				new StaticMetadata("QueryCaptureMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreCaptureMode)),
				new StaticMetadata("ReadOnlyReason", false, false, typeof(System.Int32)),
				new StaticMetadata("SizeBasedCleanupMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreSizeBasedCleanupMode)),
				new StaticMetadata("StaleQueryThresholdInDays", false, false, typeof(System.Int64)),
				new StaticMetadata("StatisticsCollectionIntervalInMinutes", false, false, typeof(System.Int64)),
				new StaticMetadata("WaitStatsCaptureMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.QueryStoreWaitStatsCaptureMode)),
				new StaticMetadata("CapturePolicyExecutionCount", false, false, typeof(System.Int32)),
				new StaticMetadata("CapturePolicyStaleThresholdInHrs", false, false, typeof(System.Int32)),
				new StaticMetadata("CapturePolicyTotalCompileCpuTimeInMS", false, false, typeof(System.Int64)),
				new StaticMetadata("CapturePolicyTotalExecutionCpuTimeInMS", false, false, typeof(System.Int64)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode ActualState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode)this.Properties.GetValueWithNullReplacement("ActualState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public System.Int32 CapturePolicyExecutionCount
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CapturePolicyExecutionCount");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CapturePolicyExecutionCount", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public System.Int32 CapturePolicyStaleThresholdInHrs
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CapturePolicyStaleThresholdInHrs");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CapturePolicyStaleThresholdInHrs", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public System.Int64 CapturePolicyTotalCompileCpuTimeInMS
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("CapturePolicyTotalCompileCpuTimeInMS");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CapturePolicyTotalCompileCpuTimeInMS", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.Standalone)]
		public System.Int64 CapturePolicyTotalExecutionCpuTimeInMS
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("CapturePolicyTotalExecutionCpuTimeInMS");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CapturePolicyTotalExecutionCpuTimeInMS", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 CurrentStorageSizeInMB
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("CurrentStorageSizeInMB");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CurrentStorageSizeInMB", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 DataFlushIntervalInSeconds
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("DataFlushIntervalInSeconds");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataFlushIntervalInSeconds", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode DesiredState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.QueryStoreOperationMode)this.Properties.GetValueWithNullReplacement("DesiredState");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DesiredState", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 MaxPlansPerQuery
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("MaxPlansPerQuery");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaxPlansPerQuery", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 MaxStorageSizeInMB
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("MaxStorageSizeInMB");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaxStorageSizeInMB", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.QueryStoreCaptureMode QueryCaptureMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.QueryStoreCaptureMode)this.Properties.GetValueWithNullReplacement("QueryCaptureMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QueryCaptureMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ReadOnlyReason
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ReadOnlyReason");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReadOnlyReason", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.QueryStoreSizeBasedCleanupMode SizeBasedCleanupMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.QueryStoreSizeBasedCleanupMode)this.Properties.GetValueWithNullReplacement("SizeBasedCleanupMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SizeBasedCleanupMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 StaleQueryThresholdInDays
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("StaleQueryThresholdInDays");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StaleQueryThresholdInDays", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 StatisticsCollectionIntervalInMinutes
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("StatisticsCollectionIntervalInMinutes");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StatisticsCollectionIntervalInMinutes", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.QueryStoreWaitStatsCaptureMode WaitStatsCaptureMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.QueryStoreWaitStatsCaptureMode)this.Properties.GetValueWithNullReplacement("WaitStatsCaptureMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WaitStatsCaptureMode", value);
			}
		}
	}
}
