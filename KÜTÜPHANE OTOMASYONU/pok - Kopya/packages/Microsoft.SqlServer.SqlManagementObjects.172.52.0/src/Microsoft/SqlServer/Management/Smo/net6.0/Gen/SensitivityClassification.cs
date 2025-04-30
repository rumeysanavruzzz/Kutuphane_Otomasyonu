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
	/// Instance class encapsulating : Server[@Name='']/Database/SensitivityClassification
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class SensitivityClassification 
	{
		public SensitivityClassification() : base(){ }
		public SensitivityClassification(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
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
							case "ReferencedColumn": return 0;
							case "ReferencedTable": return 1;
							case "ReferencedTableSchema": return 2;
							case "SensitivityInformationTypeId": return 3;
							case "SensitivityInformationTypeName": return 4;
							case "SensitivityLabelId": return 5;
							case "SensitivityLabelName": return 6;
							case "SensitivityRank": return 7;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ReferencedColumn": return 0;
						case "ReferencedTable": return 1;
						case "ReferencedTableSchema": return 2;
						case "SensitivityInformationTypeId": return 3;
						case "SensitivityInformationTypeName": return 4;
						case "SensitivityLabelId": return 5;
						case "SensitivityLabelName": return 6;
						case "SensitivityRank": return 7;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 7, 7, 7, 7, 7, 7, 8, 8, 8 };
			static int [] cloudVersionCount = new int [] { 0, 0, 8 };
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
				new StaticMetadata("ReferencedColumn", false, true, typeof(System.String)),
				new StaticMetadata("ReferencedTable", false, true, typeof(System.String)),
				new StaticMetadata("ReferencedTableSchema", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeId", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeName", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityLabelId", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityLabelName", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityRank", false, true, typeof(Microsoft.SqlServer.Management.Smo.SensitivityRank)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ReferencedColumn", false, true, typeof(System.String)),
				new StaticMetadata("ReferencedTable", false, true, typeof(System.String)),
				new StaticMetadata("ReferencedTableSchema", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeId", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeName", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityLabelId", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityLabelName", false, true, typeof(System.String)),
				new StaticMetadata("SensitivityRank", false, true, typeof(Microsoft.SqlServer.Management.Smo.SensitivityRank)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Column),"Server[@Name = '{0}']/Database[@Name = '{1}']/Table[@Name = '{2}' and @Schema = '{3}']/Column[@Name = '{4}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","ReferencedTable","ReferencedTableSchema","ReferencedColumn")]
		[CLSCompliant(false)]
		public System.String ReferencedColumn
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReferencedColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Table),"Server[@Name = '{0}']/Database[@Name = '{1}']/Table[@Name = '{2}' and @Schema = '{3}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","ReferencedTable","ReferencedTableSchema")]
		[CLSCompliant(false)]
		public System.String ReferencedTable
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReferencedTable");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Schema),"Server[@Name = '{0}']/Database[@Name = '{1}']/Schema[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","ReferencedTableSchema")]
		[CLSCompliant(false)]
		public System.String ReferencedTableSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReferencedTableSchema");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityInformationTypeId
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityInformationTypeId");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityInformationTypeName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityInformationTypeName");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityLabelId
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityLabelId");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityLabelName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityLabelName");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SensitivityRank SensitivityRank
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SensitivityRank)this.Properties.GetValueWithNullReplacement("SensitivityRank");
			}
		}
	}
}
