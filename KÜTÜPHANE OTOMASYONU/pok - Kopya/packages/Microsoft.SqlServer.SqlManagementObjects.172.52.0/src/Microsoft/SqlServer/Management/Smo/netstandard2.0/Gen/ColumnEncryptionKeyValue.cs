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
	/// Instance class encapsulating : Server[@Name='']/Database/ColumnEncryptionKey/ColumnEncryptionKeyValue
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class ColumnEncryptionKeyValue 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ColumnEncryptionKey Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ColumnEncryptionKey;
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
						switch(propertyName)
						{
							case "ColumnEncryptionKeyName": return 0;
							case "ColumnMasterKeyID": return 1;
							case "ColumnMasterKeyName": return 2;
							case "EncryptedValue": return 3;
							case "EncryptionAlgorithm": return 4;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ColumnEncryptionKeyName": return 0;
						case "ColumnMasterKeyID": return 1;
						case "ColumnMasterKeyName": return 2;
						case "EncryptedValue": return 3;
						case "EncryptionAlgorithm": return 4;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 5, 5, 5, 5, 5 };
			static int [] cloudVersionCount = new int [] { 0, 0, 5 };
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
				new StaticMetadata("ColumnEncryptionKeyName", false, false, typeof(System.String)),
				new StaticMetadata("ColumnMasterKeyID", false, false, typeof(System.Int32)),
				new StaticMetadata("ColumnMasterKeyName", false, false, typeof(System.String)),
				new StaticMetadata("EncryptedValue", false, false, typeof(System.Byte[])),
				new StaticMetadata("EncryptionAlgorithm", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ColumnEncryptionKeyName", false, false, typeof(System.String)),
				new StaticMetadata("ColumnMasterKeyID", false, false, typeof(System.Int32)),
				new StaticMetadata("ColumnMasterKeyName", false, false, typeof(System.String)),
				new StaticMetadata("EncryptedValue", false, false, typeof(System.Byte[])),
				new StaticMetadata("EncryptionAlgorithm", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ColumnEncryptionKeyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ColumnEncryptionKeyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ColumnEncryptionKeyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ColumnMasterKeyID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ColumnMasterKeyID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ColumnMasterKeyID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ColumnMasterKeyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ColumnMasterKeyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ColumnMasterKeyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte[] EncryptedValue
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("EncryptedValue");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptedValue", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "ColumnEncryptionKeyName", "ColumnMasterKeyID", "ColumnMasterKeyName", "EncryptedValue", "EncryptionAlgorithm" };
		}
	}
}
