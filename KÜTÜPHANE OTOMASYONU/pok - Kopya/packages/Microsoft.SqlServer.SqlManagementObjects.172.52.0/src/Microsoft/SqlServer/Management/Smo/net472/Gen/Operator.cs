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
	/// Instance class encapsulating : Server[@Name='']/JobServer/Operator
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class Operator 
	{
		public Operator() : base(){ }
		public Operator(JobServer jobServer, string name) : base()
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
						case "CategoryName": return 0;
						case "EmailAddress": return 1;
						case "Enabled": return 2;
						case "ID": return 3;
						case "LastEmailDate": return 4;
						case "LastNetSendDate": return 5;
						case "LastPagerDate": return 6;
						case "NetSendAddress": return 7;
						case "PagerAddress": return 8;
						case "PagerDays": return 9;
						case "SaturdayPagerEndTime": return 10;
						case "SaturdayPagerStartTime": return 11;
						case "SundayPagerEndTime": return 12;
						case "SundayPagerStartTime": return 13;
						case "WeekdayPagerEndTime": return 14;
						case "WeekdayPagerStartTime": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
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
				new StaticMetadata("CategoryName", false, false, typeof(System.String)),
				new StaticMetadata("EmailAddress", false, false, typeof(System.String)),
				new StaticMetadata("Enabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("LastEmailDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastNetSendDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("LastPagerDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("NetSendAddress", false, false, typeof(System.String)),
				new StaticMetadata("PagerAddress", false, false, typeof(System.String)),
				new StaticMetadata("PagerDays", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.WeekDays)),
				new StaticMetadata("SaturdayPagerEndTime", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("SaturdayPagerStartTime", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("SundayPagerEndTime", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("SundayPagerStartTime", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("WeekdayPagerEndTime", false, false, typeof(System.TimeSpan)),
				new StaticMetadata("WeekdayPagerStartTime", false, false, typeof(System.TimeSpan)),
			};
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
		public System.String EmailAddress
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EmailAddress");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EmailAddress", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean Enabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Enabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Enabled", value);
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
		public System.DateTime LastEmailDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastEmailDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastNetSendDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastNetSendDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime LastPagerDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastPagerDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String NetSendAddress
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("NetSendAddress");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NetSendAddress", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String PagerAddress
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PagerAddress");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PagerAddress", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.WeekDays PagerDays
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.WeekDays)this.Properties.GetValueWithNullReplacement("PagerDays");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PagerDays", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan SaturdayPagerEndTime
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("SaturdayPagerEndTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SaturdayPagerEndTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan SaturdayPagerStartTime
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("SaturdayPagerStartTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SaturdayPagerStartTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan SundayPagerEndTime
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("SundayPagerEndTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SundayPagerEndTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan SundayPagerStartTime
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("SundayPagerStartTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SundayPagerStartTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan WeekdayPagerEndTime
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("WeekdayPagerEndTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WeekdayPagerEndTime", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.TimeSpan WeekdayPagerStartTime
		{
			get
			{
				return (System.TimeSpan)this.Properties.GetValueWithNullReplacement("WeekdayPagerStartTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WeekdayPagerStartTime", value);
			}
		}
	}
}
