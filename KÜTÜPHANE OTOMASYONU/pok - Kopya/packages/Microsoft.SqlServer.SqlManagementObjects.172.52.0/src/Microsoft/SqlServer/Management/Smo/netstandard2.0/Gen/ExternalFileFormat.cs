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
	/// Instance class encapsulating : Server[@Name='']/Database/ExternalFileFormat
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class ExternalFileFormat  : ISfcSupportsDesignMode
	{
		public ExternalFileFormat() : base(){ }
		public ExternalFileFormat(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = database;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		public Database Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Database;
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
							case "DataCompression": return 0;
							case "DateFormat": return 1;
							case "Encoding": return 2;
							case "FieldTerminator": return 3;
							case "FirstRow": return 4;
							case "FormatType": return 5;
							case "ID": return 6;
							case "RowTerminator": return 7;
							case "SerDeMethod": return 8;
							case "StringDelimiter": return 9;
							case "UseTypeDefault": return 10;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "DataCompression": return 0;
							case "DateFormat": return 1;
							case "Encoding": return 2;
							case "FieldTerminator": return 3;
							case "FirstRow": return 4;
							case "FormatType": return 5;
							case "ID": return 6;
							case "RowTerminator": return 7;
							case "SerDeMethod": return 8;
							case "StringDelimiter": return 9;
							case "UseTypeDefault": return 10;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "DataCompression": return 0;
						case "DateFormat": return 1;
						case "Encoding": return 2;
						case "FieldTerminator": return 3;
						case "FormatType": return 4;
						case "ID": return 5;
						case "RowTerminator": return 6;
						case "SerDeMethod": return 7;
						case "StringDelimiter": return 8;
						case "UseTypeDefault": return 9;
						case "FirstRow": return 10;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 11, 11 };
			static int [] cloudVersionCount = new int [] { 0, 0, 11 };
			static int sqlDwPropertyCount = 11;
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
				new StaticMetadata("DataCompression", false, false, typeof(System.String)),
				new StaticMetadata("DateFormat", false, false, typeof(System.String)),
				new StaticMetadata("Encoding", false, true, typeof(System.String)),
				new StaticMetadata("FieldTerminator", false, false, typeof(System.String)),
				new StaticMetadata("FirstRow", false, false, typeof(System.Int32)),
				new StaticMetadata("FormatType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalFileFormatType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("RowTerminator", false, true, typeof(System.String)),
				new StaticMetadata("SerDeMethod", false, false, typeof(System.String)),
				new StaticMetadata("StringDelimiter", false, false, typeof(System.String)),
				new StaticMetadata("UseTypeDefault", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("DataCompression", false, false, typeof(System.String)),
				new StaticMetadata("DateFormat", false, false, typeof(System.String)),
				new StaticMetadata("Encoding", false, true, typeof(System.String)),
				new StaticMetadata("FieldTerminator", false, false, typeof(System.String)),
				new StaticMetadata("FirstRow", false, false, typeof(System.Int32)),
				new StaticMetadata("FormatType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalFileFormatType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("RowTerminator", false, true, typeof(System.String)),
				new StaticMetadata("SerDeMethod", false, false, typeof(System.String)),
				new StaticMetadata("StringDelimiter", false, false, typeof(System.String)),
				new StaticMetadata("UseTypeDefault", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DataCompression", false, false, typeof(System.String)),
				new StaticMetadata("DateFormat", false, false, typeof(System.String)),
				new StaticMetadata("Encoding", false, true, typeof(System.String)),
				new StaticMetadata("FieldTerminator", false, false, typeof(System.String)),
				new StaticMetadata("FormatType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalFileFormatType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("RowTerminator", false, true, typeof(System.String)),
				new StaticMetadata("SerDeMethod", false, false, typeof(System.String)),
				new StaticMetadata("StringDelimiter", false, false, typeof(System.String)),
				new StaticMetadata("UseTypeDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("FirstRow", false, false, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DataCompression
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DataCompression");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DataCompression", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DateFormat
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DateFormat");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DateFormat", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Encoding
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Encoding");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FieldTerminator
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FieldTerminator");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FieldTerminator", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 FirstRow
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("FirstRow");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FirstRow", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalFileFormatType FormatType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalFileFormatType)this.Properties.GetValueWithNullReplacement("FormatType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FormatType", value);
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String RowTerminator
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RowTerminator");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SerDeMethod
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SerDeMethod");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SerDeMethod", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String StringDelimiter
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("StringDelimiter");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("StringDelimiter", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean UseTypeDefault
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("UseTypeDefault");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UseTypeDefault", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "FirstRow" };
		}
	}
}
