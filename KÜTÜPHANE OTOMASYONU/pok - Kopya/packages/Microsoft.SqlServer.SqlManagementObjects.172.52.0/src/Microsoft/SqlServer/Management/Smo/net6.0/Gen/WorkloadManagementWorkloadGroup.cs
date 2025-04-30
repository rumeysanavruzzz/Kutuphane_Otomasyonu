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
	/// Instance class encapsulating : Server[@Name='']/Database/WorkloadManagementWorkloadGroup
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class WorkloadManagementWorkloadGroup  : ISfcSupportsDesignMode
	{
		public WorkloadManagementWorkloadGroup() : base(){ }
		public WorkloadManagementWorkloadGroup(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
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
							case "CapPercentageResource": return 0;
							case "GroupId": return 1;
							case "HasClassifier": return 2;
							case "Importance": return 3;
							case "IsSystemObject": return 4;
							case "MinPercentageResource": return 5;
							case "QueryExecutionTimeoutSec": return 6;
							case "RequestMaxResourceGrantPercent": return 7;
							case "RequestMinResourceGrantPercent": return 8;
						}
						return -1;
					}
					else
					{
						return -1;
					}
				}
				else
				{
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			static int [] cloudVersionCount = new int [] { 0, 0, 0 };
			static int sqlDwPropertyCount = 9;
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
				new StaticMetadata("CapPercentageResource", false, false, typeof(System.Int32)),
				new StaticMetadata("GroupId", false, false, typeof(System.Int32)),
				new StaticMetadata("HasClassifier", true, false, typeof(System.Boolean)),
				new StaticMetadata("Importance", false, false, typeof(Microsoft.SqlServer.Management.Smo.WorkloadManagementImportance)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MinPercentageResource", false, false, typeof(System.Int32)),
				new StaticMetadata("QueryExecutionTimeoutSec", false, false, typeof(System.Int32)),
				new StaticMetadata("RequestMaxResourceGrantPercent", false, false, typeof(System.Double)),
				new StaticMetadata("RequestMinResourceGrantPercent", false, false, typeof(System.Double)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
			};
			internal static StaticMetadata [] staticMetadata = 
			{
			};
		}
		[SfcProperty]
		public System.Int32 CapPercentageResource
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CapPercentageResource");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CapPercentageResource", value);
			}
		}
		[SfcProperty]
		public System.Int32 GroupId
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("GroupId");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("GroupId", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive)]
		public System.Boolean HasClassifier
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasClassifier");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HasClassifier", value);
			}
		}
		[SfcProperty]
		public Microsoft.SqlServer.Management.Smo.WorkloadManagementImportance Importance
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.WorkloadManagementImportance)this.Properties.GetValueWithNullReplacement("Importance");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Importance", value);
			}
		}
		[SfcProperty]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty]
		public System.Int32 MinPercentageResource
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MinPercentageResource");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MinPercentageResource", value);
			}
		}
		[SfcProperty]
		public System.Int32 QueryExecutionTimeoutSec
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("QueryExecutionTimeoutSec");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QueryExecutionTimeoutSec", value);
			}
		}
		[SfcProperty]
		public System.Double RequestMaxResourceGrantPercent
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("RequestMaxResourceGrantPercent");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequestMaxResourceGrantPercent", value);
			}
		}
		[SfcProperty]
		public System.Double RequestMinResourceGrantPercent
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("RequestMinResourceGrantPercent");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequestMinResourceGrantPercent", value);
			}
		}
	}
}
