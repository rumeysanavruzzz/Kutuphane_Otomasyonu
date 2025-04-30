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
	/// Instance class encapsulating : Server[@Name='']/JobServer/Job
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class Job 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public JobServer Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as JobServer;
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
						case "Category": return 0;
						case "CategoryID": return 1;
						case "CategoryType": return 2;
						case "CurrentRunRetryAttempt": return 3;
						case "CurrentRunStatus": return 4;
						case "CurrentRunStep": return 5;
						case "DateCreated": return 6;
						case "DateLastModified": return 7;
						case "DeleteLevel": return 8;
						case "Description": return 9;
						case "EmailLevel": return 10;
						case "EventLogLevel": return 11;
						case "HasSchedule": return 12;
						case "HasServer": return 13;
						case "HasStep": return 14;
						case "IsEnabled": return 15;
						case "JobID": return 16;
						case "JobType": return 17;
						case "LastRunDate": return 18;
						case "LastRunOutcome": return 19;
						case "NetSendLevel": return 20;
						case "NextRunDate": return 21;
						case "NextRunScheduleID": return 22;
						case "OperatorToEmail": return 23;
						case "OperatorToNetSend": return 24;
						case "OperatorToPage": return 25;
						case "OriginatingServer": return 26;
						case "OwnerLoginName": return 27;
						case "PageLevel": return 28;
						case "StartStepID": return 29;
						case "VersionNumber": return 30;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31 };
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
				new StaticMetadata("Category", true, false, typeof(System.String)),
				new StaticMetadata("CategoryID", false, false, typeof(System.Int32)),
				new StaticMetadata("CategoryType", true, false, typeof(System.Byte)),
				new StaticMetadata("CurrentRunRetryAttempt", true, true, typeof(System.Int32)),
				new StaticMetadata("CurrentRunStatus", true, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.JobExecutionStatus)),
				new StaticMetadata("CurrentRunStep", true, true, typeof(System.String)),
				new StaticMetadata("DateCreated", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DeleteLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)),
				new StaticMetadata("Description", false, false, typeof(System.String)),
				new StaticMetadata("EmailLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)),
				new StaticMetadata("EventLogLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)),
				new StaticMetadata("HasSchedule", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasServer", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasStep", true, true, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("JobID", false, true, typeof(System.Guid)),
				new StaticMetadata("JobType", true, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.JobType)),
				new StaticMetadata("LastRunDate", true, true, typeof(System.DateTime)),
				new StaticMetadata("LastRunOutcome", true, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionResult)),
				new StaticMetadata("NetSendLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)),
				new StaticMetadata("NextRunDate", true, true, typeof(System.DateTime)),
				new StaticMetadata("NextRunScheduleID", true, true, typeof(System.Int32)),
				new StaticMetadata("OperatorToEmail", true, false, typeof(System.String)),
				new StaticMetadata("OperatorToNetSend", true, false, typeof(System.String)),
				new StaticMetadata("OperatorToPage", true, false, typeof(System.String)),
				new StaticMetadata("OriginatingServer", false, true, typeof(System.String)),
				new StaticMetadata("OwnerLoginName", false, false, typeof(System.String)),
				new StaticMetadata("PageLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)),
				new StaticMetadata("StartStepID", false, false, typeof(System.Int32)),
				new StaticMetadata("VersionNumber", false, true, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String Category
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Category");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Category", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Byte CategoryType
		{
			get
			{
				return (System.Byte)this.Properties.GetValueWithNullReplacement("CategoryType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CategoryType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 CurrentRunRetryAttempt
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CurrentRunRetryAttempt");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.JobExecutionStatus CurrentRunStatus
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.JobExecutionStatus)this.Properties.GetValueWithNullReplacement("CurrentRunStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String CurrentRunStep
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("CurrentRunStep");
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
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionAction DeleteLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)this.Properties.GetValueWithNullReplacement("DeleteLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DeleteLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Description
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Description");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Description", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionAction EmailLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)this.Properties.GetValueWithNullReplacement("EmailLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EmailLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionAction EventLogLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)this.Properties.GetValueWithNullReplacement("EventLogLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EventLogLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean HasSchedule
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasSchedule");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean HasServer
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasServer");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean HasStep
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasStep");
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
		public System.Guid JobID
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("JobID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.JobType JobType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.JobType)this.Properties.GetValueWithNullReplacement("JobType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.DateTime LastRunDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastRunDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionResult LastRunOutcome
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionResult)this.Properties.GetValueWithNullReplacement("LastRunOutcome");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionAction NetSendLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)this.Properties.GetValueWithNullReplacement("NetSendLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NetSendLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.DateTime NextRunDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("NextRunDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int32 NextRunScheduleID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NextRunScheduleID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String OperatorToEmail
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OperatorToEmail");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OperatorToEmail", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String OperatorToNetSend
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OperatorToNetSend");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OperatorToNetSend", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String OperatorToPage
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OperatorToPage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OperatorToPage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String OriginatingServer
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OriginatingServer");
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
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionAction PageLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionAction)this.Properties.GetValueWithNullReplacement("PageLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PageLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 StartStepID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("StartStepID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StartStepID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 VersionNumber
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("VersionNumber");
			}
		}
	}
}
