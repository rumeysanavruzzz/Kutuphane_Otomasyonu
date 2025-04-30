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
	/// Instance class encapsulating : Server[@Name='']/SmartAdmin
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class SmartAdmin  : ISfcSupportsDesignMode
	{
		/// <summary>
		/// This object extend ISfcSupportsDesignMode.
		/// </summary>
		bool ISfcSupportsDesignMode.IsDesignMode
		{
			get
			{
				// call the base class 
				return IsDesignMode;
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
						case "BackupEnabled": return 0;
						case "BackupRetentionPeriodInDays": return 1;
						case "CredentialName": return 2;
						case "EncryptionAlgorithm": return 3;
						case "EncryptorName": return 4;
						case "EncryptorType": return 5;
						case "MasterSwitch": return 6;
						case "StorageUrl": return 7;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 8, 8, 8, 8, 8, 8 };
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
				new StaticMetadata("BackupEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("BackupRetentionPeriodInDays", false, false, typeof(System.Int32)),
				new StaticMetadata("CredentialName", false, false, typeof(System.String)),
				new StaticMetadata("EncryptionAlgorithm", false, false, typeof(System.String)),
				new StaticMetadata("EncryptorName", false, false, typeof(System.String)),
				new StaticMetadata("EncryptorType", false, false, typeof(System.String)),
				new StaticMetadata("MasterSwitch", false, false, typeof(System.Boolean)),
				new StaticMetadata("StorageUrl", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean BackupEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("BackupEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BackupEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 BackupRetentionPeriodInDays
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("BackupRetentionPeriodInDays");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BackupRetentionPeriodInDays", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String CredentialName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("CredentialName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CredentialName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String EncryptionAlgorithm
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EncryptionAlgorithm");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptionAlgorithm", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String EncryptorName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EncryptorName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptorName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String EncryptorType
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EncryptorType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptorType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean MasterSwitch
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("MasterSwitch");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MasterSwitch", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String StorageUrl
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("StorageUrl");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StorageUrl", value);
			}
		}
	}
}
