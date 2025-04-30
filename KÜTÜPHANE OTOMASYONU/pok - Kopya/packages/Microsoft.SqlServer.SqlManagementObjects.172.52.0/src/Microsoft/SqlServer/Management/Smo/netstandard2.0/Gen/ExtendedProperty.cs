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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/ExtendedProperty
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class ExtendedProperty 
	{
		public ExtendedProperty() : base(){ }
		public ExtendedProperty(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		[SfcParent("Database")]
		[SfcParent("SqlAssembly")]
		[SfcParent("UserDefinedAggregate")]
		[SfcParent("UserDefinedAggregateParameter")]
		[SfcParent("UserDefinedType")]
		[SfcParent("PlanGuide")]
		[SfcParent("User")]
		[SfcParent("Schema")]
		[SfcParent("DatabaseRole")]
		[SfcParent("ApplicationRole")]
		[SfcParent("Table")]
		[SfcParent("Column")]
		[SfcParent("Trigger")]
		[SfcParent("Check")]
		[SfcParent("Index")]
		[SfcParent("ForeignKey")]
		[SfcParent("Default")]
		[SfcParent("Rule")]
		[SfcParent("Synonym")]
		[SfcParent("Sequence")]
		[SfcParent("StoredProcedure")]
		[SfcParent("StoredProcedureParameter")]
		[SfcParent("NumberedStoredProcedureParameter")]
		[SfcParent("ExtendedStoredProcedure")]
		[SfcParent("UserDefinedDataType")]
		[SfcParent("UserDefinedTableType")]
		[SfcParent("UserDefinedFunction")]
		[SfcParent("UserDefinedFunctionParameter")]
		[SfcParent("View")]
		[SfcParent("XmlSchemaCollection")]
		[SfcParent("PartitionFunction")]
		[SfcParent("PartitionScheme")]
		[SfcParent("DatabaseDdlTrigger")]
		[SfcParent("SecurityPolicy")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
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
						switch(propertyName)
						{
							case "Value": return 0;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "Value": return 0;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
			static int [] cloudVersionCount = new int [] { 0, 0, 1 };
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
				new StaticMetadata("Value", false, false, typeof(System.Object)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("Value", false, false, typeof(System.Object)),
			};
		}
	}
}
