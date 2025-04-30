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
	/// Instance class encapsulating : Server[@Name='']/Setting
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class Settings 
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
						case "AuditLevel": return 0;
						case "BackupDirectory": return 1;
						case "DefaultFile": return 2;
						case "DefaultLog": return 3;
						case "LoginMode": return 4;
						case "MailProfile": return 5;
						case "NumberOfLogFiles": return 6;
						case "PerfMonMode": return 7;
						case "TapeLoadWaitTime": return 8;
						case "ErrorLogSizeKb": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10 };
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
				new StaticMetadata("AuditLevel", false, false, typeof(Microsoft.SqlServer.Management.Smo.AuditLevel)),
				new StaticMetadata("BackupDirectory", false, false, typeof(System.String)),
				new StaticMetadata("DefaultFile", false, false, typeof(System.String)),
				new StaticMetadata("DefaultLog", false, false, typeof(System.String)),
				new StaticMetadata("LoginMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.ServerLoginMode)),
				new StaticMetadata("MailProfile", false, false, typeof(System.String)),
				new StaticMetadata("NumberOfLogFiles", false, false, typeof(System.Int32)),
				new StaticMetadata("PerfMonMode", false, false, typeof(Microsoft.SqlServer.Management.Smo.PerfMonMode)),
				new StaticMetadata("TapeLoadWaitTime", false, false, typeof(System.Int32)),
				new StaticMetadata("ErrorLogSizeKb", false, false, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AuditLevel AuditLevel
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AuditLevel)this.Properties.GetValueWithNullReplacement("AuditLevel");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AuditLevel", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String BackupDirectory
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("BackupDirectory");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BackupDirectory", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultFile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultFile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultFile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultLog
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultLog");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultLog", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ErrorLogSizeKb
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ErrorLogSizeKb");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ErrorLogSizeKb", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ServerLoginMode LoginMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ServerLoginMode)this.Properties.GetValueWithNullReplacement("LoginMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LoginMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String MailProfile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MailProfile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MailProfile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 NumberOfLogFiles
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumberOfLogFiles");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NumberOfLogFiles", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.PerfMonMode PerfMonMode
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.PerfMonMode)this.Properties.GetValueWithNullReplacement("PerfMonMode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PerfMonMode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 TapeLoadWaitTime
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TapeLoadWaitTime");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TapeLoadWaitTime", value);
			}
		}
	}
}
