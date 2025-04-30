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
	/// Instance class encapsulating : Server[@Name='']/JobServer/AlertSystem
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class AlertSystem 
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
						case "FailSafeEmailAddress": return 0;
						case "FailSafeNetSendAddress": return 1;
						case "FailSafeOperator": return 2;
						case "FailSafePagerAddress": return 3;
						case "ForwardingServer": return 4;
						case "ForwardingSeverity": return 5;
						case "IsForwardedAlways": return 6;
						case "NotificationMethod": return 7;
						case "PagerCCTemplate": return 8;
						case "PagerSendSubjectOnly": return 9;
						case "PagerSubjectTemplate": return 10;
						case "PagerToTemplate": return 11;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12 };
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
				new StaticMetadata("FailSafeEmailAddress", false, false, typeof(System.String)),
				new StaticMetadata("FailSafeNetSendAddress", false, false, typeof(System.String)),
				new StaticMetadata("FailSafeOperator", false, false, typeof(System.String)),
				new StaticMetadata("FailSafePagerAddress", false, false, typeof(System.String)),
				new StaticMetadata("ForwardingServer", false, false, typeof(System.String)),
				new StaticMetadata("ForwardingSeverity", false, false, typeof(System.Int32)),
				new StaticMetadata("IsForwardedAlways", false, false, typeof(System.Boolean)),
				new StaticMetadata("NotificationMethod", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.NotifyMethods)),
				new StaticMetadata("PagerCCTemplate", false, false, typeof(System.String)),
				new StaticMetadata("PagerSendSubjectOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("PagerSubjectTemplate", false, false, typeof(System.String)),
				new StaticMetadata("PagerToTemplate", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FailSafeEmailAddress
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FailSafeEmailAddress");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FailSafeEmailAddress", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FailSafeNetSendAddress
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FailSafeNetSendAddress");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FailSafeNetSendAddress", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FailSafeOperator
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FailSafeOperator");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FailSafeOperator", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FailSafePagerAddress
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FailSafePagerAddress");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FailSafePagerAddress", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ForwardingServer
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ForwardingServer");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ForwardingServer", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ForwardingSeverity
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ForwardingSeverity");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ForwardingSeverity", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsForwardedAlways
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsForwardedAlways");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsForwardedAlways", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.NotifyMethods NotificationMethod
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.NotifyMethods)this.Properties.GetValueWithNullReplacement("NotificationMethod");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NotificationMethod", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String PagerCCTemplate
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PagerCCTemplate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PagerCCTemplate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean PagerSendSubjectOnly
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("PagerSendSubjectOnly");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PagerSendSubjectOnly", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String PagerSubjectTemplate
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PagerSubjectTemplate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PagerSubjectTemplate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String PagerToTemplate
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PagerToTemplate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PagerToTemplate", value);
			}
		}
	}
}
