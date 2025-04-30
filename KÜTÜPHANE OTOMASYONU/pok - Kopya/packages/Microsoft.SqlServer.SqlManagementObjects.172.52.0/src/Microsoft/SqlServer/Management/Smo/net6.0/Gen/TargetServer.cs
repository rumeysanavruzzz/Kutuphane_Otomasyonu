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
	/// Instance class encapsulating : Server[@Name='']/JobServer/TargetServer
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class TargetServer 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public JobServer Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as JobServer;
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
						case "EnlistDate": return 0;
						case "ID": return 1;
						case "LastPollDate": return 2;
						case "LocalTime": return 3;
						case "Location": return 4;
						case "PendingInstructions": return 5;
						case "PollingInterval": return 6;
						case "Status": return 7;
						case "TimeZoneAdjustment": return 8;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
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
				new StaticMetadata("EnlistDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("LastPollDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("LocalTime", false, true, typeof(System.DateTime)),
				new StaticMetadata("Location", false, true, typeof(System.String)),
				new StaticMetadata("PendingInstructions", false, true, typeof(System.Int32)),
				new StaticMetadata("PollingInterval", false, true, typeof(System.Int32)),
				new StaticMetadata("Status", false, true, typeof(Microsoft.SqlServer.Management.Smo.Agent.TargetServerStatus)),
				new StaticMetadata("TimeZoneAdjustment", false, true, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime EnlistDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("EnlistDate");
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
		public System.DateTime LastPollDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastPollDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LocalTime
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LocalTime");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Location
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Location");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 PendingInstructions
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PendingInstructions");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 PollingInterval
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PollingInterval");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.TargetServerStatus Status
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.TargetServerStatus)this.Properties.GetValueWithNullReplacement("Status");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 TimeZoneAdjustment
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TimeZoneAdjustment");
			}
		}
	}
}
