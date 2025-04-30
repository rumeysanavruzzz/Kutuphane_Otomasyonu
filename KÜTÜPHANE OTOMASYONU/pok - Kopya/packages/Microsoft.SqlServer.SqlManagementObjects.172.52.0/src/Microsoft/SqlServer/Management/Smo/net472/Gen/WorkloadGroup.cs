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
	/// Instance class encapsulating : Server[@Name='']/ResourceGovernor/ResourcePool/WorkloadGroup
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class WorkloadGroup  : ISfcSupportsDesignMode
	{
		public WorkloadGroup() : base(){ }
		public WorkloadGroup(ResourcePool resourcePool, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = resourcePool;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ResourcePool Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ResourcePool;
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
						return -1;
					}
					else
					{
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "GroupMaximumRequests": return 0;
						case "ID": return 1;
						case "Importance": return 2;
						case "IsSystemObject": return 3;
						case "MaximumDegreeOfParallelism": return 4;
						case "PolicyHealthState": return 5;
						case "RequestMaximumCpuTimeInSeconds": return 6;
						case "RequestMaximumMemoryGrantPercentage": return 7;
						case "RequestMemoryGrantTimeoutInSeconds": return 8;
						case "ExternalResourcePoolName": return 9;
						case "RequestMaximumMemoryGrantPercentageAsDouble": return 10;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 9, 9, 9, 9, 10, 10, 11, 11, 11 };
			static int [] cloudVersionCount = new int [] { 0, 0, 0 };
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
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("GroupMaximumRequests", false, false, typeof(System.Int32)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Importance", false, false, typeof(Microsoft.SqlServer.Management.Smo.WorkloadGroupImportance)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MaximumDegreeOfParallelism", false, false, typeof(System.Int32)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("RequestMaximumCpuTimeInSeconds", false, false, typeof(System.Int32)),
				new StaticMetadata("RequestMaximumMemoryGrantPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("RequestMemoryGrantTimeoutInSeconds", false, false, typeof(System.Int32)),
				new StaticMetadata("ExternalResourcePoolName", false, false, typeof(System.String)),
				new StaticMetadata("RequestMaximumMemoryGrantPercentageAsDouble", false, false, typeof(System.Double)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ExternalResourcePoolName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ExternalResourcePoolName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExternalResourcePoolName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 GroupMaximumRequests
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("GroupMaximumRequests");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("GroupMaximumRequests", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.WorkloadGroupImportance Importance
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.WorkloadGroupImportance)this.Properties.GetValueWithNullReplacement("Importance");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Importance", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MaximumDegreeOfParallelism
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumDegreeOfParallelism");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaximumDegreeOfParallelism", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 RequestMaximumCpuTimeInSeconds
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("RequestMaximumCpuTimeInSeconds");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequestMaximumCpuTimeInSeconds", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 RequestMaximumMemoryGrantPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("RequestMaximumMemoryGrantPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequestMaximumMemoryGrantPercentage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Double RequestMaximumMemoryGrantPercentageAsDouble
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("RequestMaximumMemoryGrantPercentageAsDouble");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequestMaximumMemoryGrantPercentageAsDouble", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 RequestMemoryGrantTimeoutInSeconds
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("RequestMemoryGrantTimeoutInSeconds");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RequestMemoryGrantTimeoutInSeconds", value);
			}
		}
	}
}
