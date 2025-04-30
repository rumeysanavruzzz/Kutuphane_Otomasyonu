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
	/// Instance class encapsulating : Server[@Name='']/Setting/OleDbProviderSetting
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class OleDbProviderSettings 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public Settings Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Settings;
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
						case "AllowInProcess": return 0;
						case "Description": return 1;
						case "DisallowAdHocAccess": return 2;
						case "DynamicParameters": return 3;
						case "IndexAsAccessPath": return 4;
						case "LevelZeroOnly": return 5;
						case "NestedQueries": return 6;
						case "NonTransactedUpdates": return 7;
						case "SqlServerLike": return 8;
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
				new StaticMetadata("AllowInProcess", false, false, typeof(System.Boolean)),
				new StaticMetadata("Description", false, true, typeof(System.String)),
				new StaticMetadata("DisallowAdHocAccess", false, false, typeof(System.Boolean)),
				new StaticMetadata("DynamicParameters", false, false, typeof(System.Boolean)),
				new StaticMetadata("IndexAsAccessPath", false, false, typeof(System.Boolean)),
				new StaticMetadata("LevelZeroOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("NestedQueries", false, false, typeof(System.Boolean)),
				new StaticMetadata("NonTransactedUpdates", false, false, typeof(System.Boolean)),
				new StaticMetadata("SqlServerLike", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AllowInProcess
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AllowInProcess");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AllowInProcess", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Description
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Description");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean DisallowAdHocAccess
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DisallowAdHocAccess");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DisallowAdHocAccess", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean DynamicParameters
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DynamicParameters");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DynamicParameters", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IndexAsAccessPath
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IndexAsAccessPath");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IndexAsAccessPath", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean LevelZeroOnly
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("LevelZeroOnly");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("LevelZeroOnly", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean NestedQueries
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NestedQueries");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NestedQueries", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean NonTransactedUpdates
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NonTransactedUpdates");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NonTransactedUpdates", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SqlServerLike
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SqlServerLike");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SqlServerLike", value);
			}
		}
	}
}
