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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Check
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Check  : ISfcSupportsDesignMode
	{
		public Check() : base(){ }
		public Check(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		[SfcParent("Table")]
		[SfcParent("UserDefinedTableType")]
		[SfcParent("UserDefinedFunction")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
			}
			set{SetParentImpl(value);}
		}
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
						switch(propertyName)
						{
							case "CreateDate": return 0;
							case "DateLastModified": return 1;
							case "ID": return 2;
							case "IsChecked": return 3;
							case "IsEnabled": return 4;
							case "IsSystemNamed": return 5;
							case "NotForReplication": return 6;
							case "Text": return 7;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "CreateDate": return 0;
							case "DateLastModified": return 1;
							case "ID": return 2;
							case "IsChecked": return 3;
							case "IsEnabled": return 4;
							case "IsSystemNamed": return 5;
							case "NotForReplication": return 6;
							case "Text": return 7;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "CreateDate": return 0;
						case "ID": return 1;
						case "IsChecked": return 2;
						case "IsEnabled": return 3;
						case "IsSystemNamed": return 4;
						case "NotForReplication": return 5;
						case "Text": return 6;
						case "DateLastModified": return 7;
						case "IsFileTableDefined": return 8;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 7, 7, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9 };
			static int [] cloudVersionCount = new int [] { 8, 8, 8 };
			static int sqlDwPropertyCount = 8;
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
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsChecked", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, false, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsChecked", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsChecked", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("IsFileTableDefined", false, true, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsChecked
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsChecked");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsChecked", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsFileTableDefined
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFileTableDefined");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean NotForReplication
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NotForReplication");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NotForReplication", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Text
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Text");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Text", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "IsChecked", "NotForReplication", "Text" };
		}
	}
}
