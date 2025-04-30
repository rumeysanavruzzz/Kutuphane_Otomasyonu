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
	/// Instance class encapsulating : Server[@Name='']/JobServer
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class JobServer 
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
						case "AgentLogLevel": return 0;
						case "AgentShutdownWaitTime": return 1;
						case "ErrorLogFile": return 2;
						case "HostLoginName": return 3;
						case "IdleCpuDuration": return 4;
						case "IdleCpuPercentage": return 5;
						case "IsCpuPollingEnabled": return 6;
						case "JobServerType": return 7;
						case "LocalHostAlias": return 8;
						case "LoginTimeout": return 9;
						case "MaximumHistoryRows": return 10;
						case "MaximumJobHistoryRows": return 11;
						case "MsxAccountName": return 12;
						case "MsxServerName": return 13;
						case "NetSendRecipient": return 14;
						case "SaveInSentFolder": return 15;
						case "SqlAgentAutoStart": return 16;
						case "SqlAgentMailProfile": return 17;
						case "SqlAgentRestart": return 18;
						case "SqlServerRestart": return 19;
						case "SysAdminOnly": return 20;
						case "WriteOemErrorLog": return 21;
						case "AgentMailType": return 22;
						case "DatabaseMailProfile": return 23;
						case "MsxAccountCredentialName": return 24;
						case "ReplaceAlertTokensEnabled": return 25;
						case "ServiceAccount": return 26;
						case "ServiceStartMode": return 27;
						case "AgentDomainGroup": return 28;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 22, 22, 28, 29, 29, 29, 29, 29, 29, 29, 29, 29 };
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
				new StaticMetadata("AgentLogLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.AgentLogLevels)),
				new StaticMetadata("AgentShutdownWaitTime", false, false, typeof(System.Int32)),
				new StaticMetadata("ErrorLogFile", false, false, typeof(System.String)),
				new StaticMetadata("HostLoginName", false, true, typeof(System.String)),
				new StaticMetadata("IdleCpuDuration", false, false, typeof(System.Int32)),
				new StaticMetadata("IdleCpuPercentage", false, false, typeof(System.Int32)),
				new StaticMetadata("IsCpuPollingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("JobServerType", false, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.JobServerType)),
				new StaticMetadata("LocalHostAlias", false, false, typeof(System.String)),
				new StaticMetadata("LoginTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("MaximumHistoryRows", false, false, typeof(System.Int32)),
				new StaticMetadata("MaximumJobHistoryRows", false, false, typeof(System.Int32)),
				new StaticMetadata("MsxAccountName", true, true, typeof(System.String)),
				new StaticMetadata("MsxServerName", false, true, typeof(System.String)),
				new StaticMetadata("NetSendRecipient", false, false, typeof(System.String)),
				new StaticMetadata("SaveInSentFolder", false, false, typeof(System.Boolean)),
				new StaticMetadata("SqlAgentAutoStart", false, false, typeof(System.Boolean)),
				new StaticMetadata("SqlAgentMailProfile", false, false, typeof(System.String)),
				new StaticMetadata("SqlAgentRestart", false, false, typeof(System.Boolean)),
				new StaticMetadata("SqlServerRestart", false, false, typeof(System.Boolean)),
				new StaticMetadata("SysAdminOnly", false, true, typeof(System.Boolean)),
				new StaticMetadata("WriteOemErrorLog", false, false, typeof(System.Boolean)),
				new StaticMetadata("AgentMailType", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.AgentMailType)),
				new StaticMetadata("DatabaseMailProfile", false, false, typeof(System.String)),
				new StaticMetadata("MsxAccountCredentialName", true, true, typeof(System.String)),
				new StaticMetadata("ReplaceAlertTokensEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ServiceAccount", false, true, typeof(System.String)),
				new StaticMetadata("ServiceStartMode", false, true, typeof(Microsoft.SqlServer.Management.Smo.ServiceStartMode)),
				new StaticMetadata("AgentDomainGroup", false, true, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String AgentDomainGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AgentDomainGroup");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.AgentLogLevels AgentLogLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.AgentLogLevels)this.Properties.GetValueWithNullReplacement("AgentLogLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AgentLogLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.AgentMailType AgentMailType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.AgentMailType)this.Properties.GetValueWithNullReplacement("AgentMailType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AgentMailType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 AgentShutdownWaitTime
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("AgentShutdownWaitTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AgentShutdownWaitTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DatabaseMailProfile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DatabaseMailProfile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DatabaseMailProfile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ErrorLogFile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ErrorLogFile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ErrorLogFile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String HostLoginName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("HostLoginName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 IdleCpuDuration
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("IdleCpuDuration");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IdleCpuDuration", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 IdleCpuPercentage
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("IdleCpuPercentage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IdleCpuPercentage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsCpuPollingEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsCpuPollingEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsCpuPollingEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.JobServerType JobServerType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.JobServerType)this.Properties.GetValueWithNullReplacement("JobServerType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String LocalHostAlias
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("LocalHostAlias");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LocalHostAlias", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 LoginTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("LoginTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LoginTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MaximumHistoryRows
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumHistoryRows");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaximumHistoryRows", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MaximumJobHistoryRows
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumJobHistoryRows");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaximumJobHistoryRows", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String MsxAccountCredentialName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MsxAccountCredentialName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.String MsxAccountName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MsxAccountName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String MsxServerName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MsxServerName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String NetSendRecipient
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("NetSendRecipient");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NetSendRecipient", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean ReplaceAlertTokensEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ReplaceAlertTokensEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReplaceAlertTokensEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SaveInSentFolder
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SaveInSentFolder");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SaveInSentFolder", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ServiceAccount
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ServiceAccount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ServiceStartMode ServiceStartMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ServiceStartMode)this.Properties.GetValueWithNullReplacement("ServiceStartMode");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SqlAgentAutoStart
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SqlAgentAutoStart");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SqlAgentAutoStart", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String SqlAgentMailProfile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlAgentMailProfile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SqlAgentMailProfile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SqlAgentRestart
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SqlAgentRestart");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SqlAgentRestart", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SqlServerRestart
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SqlServerRestart");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SqlServerRestart", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean WriteOemErrorLog
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("WriteOemErrorLog");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WriteOemErrorLog", value);
			}
		}
	}
}
