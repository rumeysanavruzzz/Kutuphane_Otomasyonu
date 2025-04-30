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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/ResumableIndex
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class ResumableIndex 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		[SfcParent("Table")]
		[SfcParent("View")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
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
							case "ID": return 0;
							case "LastPauseTime": return 1;
							case "MaxDOP": return 2;
							case "PageCount": return 3;
							case "PartitionNumber": return 4;
							case "PercentComplete": return 5;
							case "ResumableOperationState": return 6;
							case "SqlText": return 7;
							case "StartTime": return 8;
							case "TotalExecutionTime": return 9;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ID": return 0;
						case "LastPauseTime": return 1;
						case "MaxDOP": return 2;
						case "PageCount": return 3;
						case "PartitionNumber": return 4;
						case "PercentComplete": return 5;
						case "ResumableOperationState": return 6;
						case "SqlText": return 7;
						case "StartTime": return 8;
						case "TotalExecutionTime": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 10 };
			static int [] cloudVersionCount = new int [] { 0, 0, 10 };
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
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("LastPauseTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("MaxDOP", false, false, typeof(System.Int16)),
				new StaticMetadata("PageCount", false, true, typeof(System.Int64)),
				new StaticMetadata("PartitionNumber", false, true, typeof(System.Int32)),
				new StaticMetadata("PercentComplete", false, true, typeof(System.Double)),
				new StaticMetadata("ResumableOperationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)),
				new StaticMetadata("SqlText", false, true, typeof(System.String)),
				new StaticMetadata("StartTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("TotalExecutionTime", false, true, typeof(System.Int32)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("LastPauseTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("MaxDOP", false, false, typeof(System.Int16)),
				new StaticMetadata("PageCount", false, true, typeof(System.Int64)),
				new StaticMetadata("PartitionNumber", false, true, typeof(System.Int32)),
				new StaticMetadata("PercentComplete", false, true, typeof(System.Double)),
				new StaticMetadata("ResumableOperationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)),
				new StaticMetadata("SqlText", false, true, typeof(System.String)),
				new StaticMetadata("StartTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("TotalExecutionTime", false, true, typeof(System.Int32)),
			};
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
		public System.DateTime LastPauseTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastPauseTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int16 MaxDOP
		{
			get
			{
				return (System.Int16)this.Properties.GetValueWithNullReplacement("MaxDOP");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaxDOP", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 PageCount
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("PageCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 PartitionNumber
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PartitionNumber");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double PercentComplete
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("PercentComplete");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ResumableOperationStateType ResumableOperationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)this.Properties.GetValueWithNullReplacement("ResumableOperationState");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SqlText
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlText");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime StartTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("StartTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 TotalExecutionTime
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TotalExecutionTime");
			}
		}
	}
}
