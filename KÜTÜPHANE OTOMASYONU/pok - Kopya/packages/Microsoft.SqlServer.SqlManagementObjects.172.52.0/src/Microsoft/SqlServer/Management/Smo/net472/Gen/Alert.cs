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
	/// Instance class encapsulating : Server[@Name='']/JobServer/Alert
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class Alert 
	{
		public Alert() : base(){ }
		public Alert(JobServer jobServer, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = jobServer;
		}
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
						case "AlertType": return 0;
						case "CategoryName": return 1;
						case "CountResetDate": return 2;
						case "DatabaseName": return 3;
						case "DelayBetweenResponses": return 4;
						case "EventDescriptionKeyword": return 5;
						case "EventSource": return 6;
						case "HasNotification": return 7;
						case "ID": return 8;
						case "IncludeEventDescription": return 9;
						case "IsEnabled": return 10;
						case "JobID": return 11;
						case "JobName": return 12;
						case "LastOccurrenceDate": return 13;
						case "LastResponseDate": return 14;
						case "MessageID": return 15;
						case "NotificationMessage": return 16;
						case "OccurrenceCount": return 17;
						case "PerformanceCondition": return 18;
						case "Severity": return 19;
						case "WmiEventNamespace": return 20;
						case "WmiEventQuery": return 21;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 20, 20, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22 };
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
				new StaticMetadata("AlertType", false, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.AlertType)),
				new StaticMetadata("CategoryName", false, false, typeof(System.String)),
				new StaticMetadata("CountResetDate", false, false, typeof(System.DateTime)),
				new StaticMetadata("DatabaseName", false, false, typeof(System.String)),
				new StaticMetadata("DelayBetweenResponses", false, false, typeof(System.Int32)),
				new StaticMetadata("EventDescriptionKeyword", false, false, typeof(System.String)),
				new StaticMetadata("EventSource", false, true, typeof(System.String)),
				new StaticMetadata("HasNotification", false, true, typeof(System.Int32)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IncludeEventDescription", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.NotifyMethods)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("JobID", false, false, typeof(System.Guid)),
				new StaticMetadata("JobName", false, true, typeof(System.String)),
				new StaticMetadata("LastOccurrenceDate", false, false, typeof(System.DateTime)),
				new StaticMetadata("LastResponseDate", false, false, typeof(System.DateTime)),
				new StaticMetadata("MessageID", false, false, typeof(System.Int32)),
				new StaticMetadata("NotificationMessage", false, false, typeof(System.String)),
				new StaticMetadata("OccurrenceCount", false, true, typeof(System.Int32)),
				new StaticMetadata("PerformanceCondition", false, false, typeof(System.String)),
				new StaticMetadata("Severity", false, false, typeof(System.Int32)),
				new StaticMetadata("WmiEventNamespace", false, false, typeof(System.String)),
				new StaticMetadata("WmiEventQuery", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.AlertType AlertType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.AlertType)this.Properties.GetValueWithNullReplacement("AlertType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String CategoryName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("CategoryName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CategoryName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime CountResetDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CountResetDate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CountResetDate", value);
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
		public System.Int32 DelayBetweenResponses
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("DelayBetweenResponses");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DelayBetweenResponses", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String EventDescriptionKeyword
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EventDescriptionKeyword");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EventDescriptionKeyword", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String EventSource
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EventSource");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 HasNotification
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("HasNotification");
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
		public Microsoft.SqlServer.Management.Smo.Agent.NotifyMethods IncludeEventDescription
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.NotifyMethods)this.Properties.GetValueWithNullReplacement("IncludeEventDescription");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IncludeEventDescription", value);
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
			set
			{
				Properties.SetValueWithConsistencyCheck("JobID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String JobName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("JobName");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastOccurrenceDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastOccurrenceDate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LastOccurrenceDate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastResponseDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastResponseDate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LastResponseDate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 MessageID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MessageID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MessageID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String NotificationMessage
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("NotificationMessage");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NotificationMessage", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 OccurrenceCount
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("OccurrenceCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String PerformanceCondition
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PerformanceCondition");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PerformanceCondition", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 Severity
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Severity");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Severity", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String WmiEventNamespace
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WmiEventNamespace");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WmiEventNamespace", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String WmiEventQuery
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WmiEventQuery");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WmiEventQuery", value);
			}
		}
	}
}
