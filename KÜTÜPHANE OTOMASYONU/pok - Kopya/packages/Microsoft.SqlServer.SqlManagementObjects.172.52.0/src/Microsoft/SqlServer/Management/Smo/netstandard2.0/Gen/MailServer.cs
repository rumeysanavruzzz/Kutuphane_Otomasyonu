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

namespace Microsoft.SqlServer.Management.Smo.Mail
{
	/// <summary>
	/// Instance class encapsulating : Server[@Name='']/Mail/MailAccount/MailServer
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class MailServer 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public MailAccount Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as MailAccount;
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
						case "EnableSsl": return 0;
						case "Port": return 1;
						case "ServerType": return 2;
						case "UseDefaultCredentials": return 3;
						case "UserName": return 4;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
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
				new StaticMetadata("EnableSsl", false, false, typeof(System.Boolean)),
				new StaticMetadata("Port", false, false, typeof(System.Int32)),
				new StaticMetadata("ServerType", false, true, typeof(System.String)),
				new StaticMetadata("UseDefaultCredentials", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserName", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean EnableSsl
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("EnableSsl");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EnableSsl", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 Port
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Port");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Port", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ServerType
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ServerType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean UseDefaultCredentials
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("UseDefaultCredentials");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UseDefaultCredentials", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String UserName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("UserName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UserName", value);
			}
		}
	}
}
