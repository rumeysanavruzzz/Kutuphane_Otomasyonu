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

namespace Microsoft.SqlServer.Management.Smo.Agent
{
	/// <summary>
	/// Instance class encapsulating : Server[@Name='']/JobServer/Job/Schedule
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class JobSchedule 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		[SfcParent("Job")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
			}
			set{SetParentImpl(value);}
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
						case "ActiveEndDate": return 0;
						case "ActiveEndTimeOfDay": return 1;
						case "ActiveStartDate": return 2;
						case "ActiveStartTimeOfDay": return 3;
						case "DateCreated": return 4;
						case "FrequencyInterval": return 5;
						case "FrequencyRecurrenceFactor": return 6;
						case "FrequencyRelativeIntervals": return 7;
						case "FrequencySubDayInterval": return 8;
						case "FrequencySubDayTypes": return 9;
						case "FrequencyTypes": return 10;
						case "ID": return 11;
						case "IsEnabled": return 12;
						case "JobCount": return 13;
						case "OwnerLoginName": return 14;
						case "ScheduleUid": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
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
				new StaticMetadata("ActiveEndDate", false, false, typeof(System.DateTime)),
				new StaticMetadata("ActiveEndTimeOfDay", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("ActiveStartDate", false, false, typeof(System.DateTime)),
				new StaticMetadata("ActiveStartTimeOfDay", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("DateCreated", false, true, typeof(System.DateTime)),
				new StaticMetadata("FrequencyInterval", false, false, typeof(System.Int32)),
				new StaticMetadata("FrequencyRecurrenceFactor", false, false, typeof(System.Int32)),
				new StaticMetadata("FrequencyRelativeIntervals", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.FrequencyRelativeIntervals)),
				new StaticMetadata("FrequencySubDayInterval", false, false, typeof(System.Int32)),
				new StaticMetadata("FrequencySubDayTypes", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.FrequencySubDayTypes)),
				new StaticMetadata("FrequencyTypes", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.FrequencyTypes)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("JobCount", false, true, typeof(System.Int32)),
				new StaticMetadata("OwnerLoginName", false, false, typeof(System.String)),
				new StaticMetadata("ScheduleUid", false, false, typeof(System.Guid)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime ActiveEndDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("ActiveEndDate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ActiveEndDate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan ActiveEndTimeOfDay
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("ActiveEndTimeOfDay");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ActiveEndTimeOfDay", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime ActiveStartDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("ActiveStartDate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ActiveStartDate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan ActiveStartTimeOfDay
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("ActiveStartTimeOfDay");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ActiveStartTimeOfDay", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime DateCreated
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateCreated");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 FrequencyInterval
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("FrequencyInterval");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FrequencyInterval", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 FrequencyRecurrenceFactor
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("FrequencyRecurrenceFactor");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FrequencyRecurrenceFactor", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.FrequencyRelativeIntervals FrequencyRelativeIntervals
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.FrequencyRelativeIntervals)this.Properties.GetValueWithNullReplacement("FrequencyRelativeIntervals");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FrequencyRelativeIntervals", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 FrequencySubDayInterval
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("FrequencySubDayInterval");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FrequencySubDayInterval", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.FrequencySubDayTypes FrequencySubDayTypes
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.FrequencySubDayTypes)this.Properties.GetValueWithNullReplacement("FrequencySubDayTypes");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FrequencySubDayTypes", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.FrequencyTypes FrequencyTypes
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.FrequencyTypes)this.Properties.GetValueWithNullReplacement("FrequencyTypes");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FrequencyTypes", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 JobCount
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("JobCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String OwnerLoginName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OwnerLoginName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OwnerLoginName", value);
			}
		}
	}
}
