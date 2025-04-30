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
	/// Instance class encapsulating : Server[@Name='']/Database/WorkloadManagementWorkloadClassifier
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class WorkloadManagementWorkloadClassifier  : ISfcSupportsDesignMode
	{
		public WorkloadManagementWorkloadClassifier() : base(){ }
		public WorkloadManagementWorkloadClassifier(Database database, string name) : base()
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
							case "EndTime": return 0;
							case "GroupName": return 1;
							case "Id": return 2;
							case "Importance": return 3;
							case "MemberName": return 4;
							case "StartTime": return 5;
							case "WlmContext": return 6;
							case "WlmLabel": return 7;
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
			static int sqlDwPropertyCount = 8;
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
				new StaticMetadata("EndTime", false, false, typeof(System.String)),
				new StaticMetadata("GroupName", false, false, typeof(System.String)),
				new StaticMetadata("Id", false, false, typeof(System.Int32)),
				new StaticMetadata("Importance", false, false, typeof(Microsoft.SqlServer.Management.Smo.WorkloadManagementImportance)),
				new StaticMetadata("MemberName", false, false, typeof(System.String)),
				new StaticMetadata("StartTime", false, false, typeof(System.String)),
				new StaticMetadata("WlmContext", false, false, typeof(System.String)),
				new StaticMetadata("WlmLabel", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
			};
			internal static StaticMetadata [] staticMetadata = 
			{
			};
		}
		[SfcProperty]
		public System.String EndTime
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EndTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EndTime", value);
			}
		}
		[SfcProperty]
		public System.String GroupName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("GroupName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("GroupName", value);
			}
		}
		[SfcProperty]
		public System.Int32 Id
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Id");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Id", value);
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
		public System.String MemberName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MemberName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MemberName", value);
			}
		}
		[SfcProperty]
		public System.String StartTime
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("StartTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StartTime", value);
			}
		}
		[SfcProperty]
		public System.String WlmContext
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WlmContext");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WlmContext", value);
			}
		}
		[SfcProperty]
		public System.String WlmLabel
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WlmLabel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WlmLabel", value);
			}
		}
	}
}
