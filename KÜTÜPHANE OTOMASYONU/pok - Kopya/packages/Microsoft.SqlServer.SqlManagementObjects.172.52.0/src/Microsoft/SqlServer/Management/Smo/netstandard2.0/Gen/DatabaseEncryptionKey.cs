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
	/// Instance class encapsulating : Server[@Name='']/Database/DatabaseEncryptionKey
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class DatabaseEncryptionKey 
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
						case "CreateDate": return 0;
						case "EncryptionAlgorithm": return 1;
						case "EncryptionState": return 2;
						case "EncryptionType": return 3;
						case "EncryptorName": return 4;
						case "ModifyDate": return 5;
						case "OpenedDate": return 6;
						case "RegenerateDate": return 7;
						case "SetDate": return 8;
						case "Thumbprint": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
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
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("EncryptionAlgorithm", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseEncryptionAlgorithm)),
				new StaticMetadata("EncryptionState", false, true, typeof(Microsoft.SqlServer.Management.Smo.DatabaseEncryptionState)),
				new StaticMetadata("EncryptionType", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseEncryptionType)),
				new StaticMetadata("EncryptorName", false, false, typeof(System.String)),
				new StaticMetadata("ModifyDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("OpenedDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("RegenerateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("SetDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("Thumbprint", false, true, typeof(System.Byte[])),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseEncryptionAlgorithm EncryptionAlgorithm
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseEncryptionAlgorithm)this.Properties.GetValueWithNullReplacement("EncryptionAlgorithm");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptionAlgorithm", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseEncryptionState EncryptionState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseEncryptionState)this.Properties.GetValueWithNullReplacement("EncryptionState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseEncryptionType EncryptionType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseEncryptionType)this.Properties.GetValueWithNullReplacement("EncryptionType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptionType", value);
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
		public System.DateTime ModifyDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("ModifyDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime OpenedDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("OpenedDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime RegenerateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("RegenerateDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime SetDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("SetDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Byte[] Thumbprint
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("Thumbprint");
			}
		}
	}
}
