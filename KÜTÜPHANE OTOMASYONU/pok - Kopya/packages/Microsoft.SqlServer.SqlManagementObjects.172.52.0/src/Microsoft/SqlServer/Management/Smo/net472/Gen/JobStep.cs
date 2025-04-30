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
	/// Instance class encapsulating : Server[@Name='']/JobServer/Job/Step
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class JobStep 
	{
		public JobStep() : base(){ }
		public JobStep(Job job, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = job;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public Job Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Job;
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
						case "Command": return 0;
						case "CommandExecutionSuccessCode": return 1;
						case "DatabaseName": return 2;
						case "DatabaseUserName": return 3;
						case "ID": return 4;
						case "JobStepFlags": return 5;
						case "LastRunDate": return 6;
						case "LastRunDuration": return 7;
						case "LastRunOutcome": return 8;
						case "LastRunRetries": return 9;
						case "OnFailAction": return 10;
						case "OnFailStep": return 11;
						case "OnSuccessAction": return 12;
						case "OnSuccessStep": return 13;
						case "OSRunPriority": return 14;
						case "OutputFileName": return 15;
						case "RetryAttempts": return 16;
						case "RetryInterval": return 17;
						case "Server": return 18;
						case "SubSystem": return 19;
						case "ProxyName": return 20;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 20, 20, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21 };
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
				new StaticMetadata("Command", false, false, typeof(System.String)),
				new StaticMetadata("CommandExecutionSuccessCode", false, false, typeof(System.Int32)),
				new StaticMetadata("DatabaseName", false, false, typeof(System.String)),
				new StaticMetadata("DatabaseUserName", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, false, typeof(System.Int32)),
				new StaticMetadata("JobStepFlags", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.JobStepFlags)),
				new StaticMetadata("LastRunDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastRunDuration", false, true, typeof(System.Int32)),
				new StaticMetadata("LastRunOutcome", false, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.CompletionResult)),
				new StaticMetadata("LastRunRetries", false, true, typeof(System.Int32)),
				new StaticMetadata("OnFailAction", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.StepCompletionAction)),
				new StaticMetadata("OnFailStep", false, false, typeof(System.Int32)),
				new StaticMetadata("OnSuccessAction", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.StepCompletionAction)),
				new StaticMetadata("OnSuccessStep", false, false, typeof(System.Int32)),
				new StaticMetadata("OSRunPriority", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.OSRunPriority)),
				new StaticMetadata("OutputFileName", false, false, typeof(System.String)),
				new StaticMetadata("RetryAttempts", false, false, typeof(System.Int32)),
				new StaticMetadata("RetryInterval", false, false, typeof(System.Int32)),
				new StaticMetadata("Server", false, false, typeof(System.String)),
				new StaticMetadata("SubSystem", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.AgentSubSystem)),
				new StaticMetadata("ProxyName", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Command
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Command");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Command", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 CommandExecutionSuccessCode
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CommandExecutionSuccessCode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CommandExecutionSuccessCode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DatabaseName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DatabaseName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DatabaseName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DatabaseUserName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DatabaseUserName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DatabaseUserName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.JobStepFlags JobStepFlags
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.JobStepFlags)this.Properties.GetValueWithNullReplacement("JobStepFlags");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("JobStepFlags", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastRunDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastRunDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 LastRunDuration
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("LastRunDuration");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.CompletionResult LastRunOutcome
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.CompletionResult)this.Properties.GetValueWithNullReplacement("LastRunOutcome");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 LastRunRetries
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("LastRunRetries");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.StepCompletionAction OnFailAction
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.StepCompletionAction)this.Properties.GetValueWithNullReplacement("OnFailAction");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OnFailAction", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 OnFailStep
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("OnFailStep");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OnFailStep", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.StepCompletionAction OnSuccessAction
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.StepCompletionAction)this.Properties.GetValueWithNullReplacement("OnSuccessAction");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OnSuccessAction", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 OnSuccessStep
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("OnSuccessStep");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OnSuccessStep", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.OSRunPriority OSRunPriority
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.OSRunPriority)this.Properties.GetValueWithNullReplacement("OSRunPriority");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OSRunPriority", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String OutputFileName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("OutputFileName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("OutputFileName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ProxyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ProxyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ProxyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 RetryAttempts
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("RetryAttempts");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RetryAttempts", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 RetryInterval
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("RetryInterval");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RetryInterval", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Server
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Server");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Server", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.AgentSubSystem SubSystem
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.AgentSubSystem)this.Properties.GetValueWithNullReplacement("SubSystem");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SubSystem", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "ID" };
		}
	}
}
