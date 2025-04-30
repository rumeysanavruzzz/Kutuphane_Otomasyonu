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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/ForeignKey
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class ForeignKey  : ISfcSupportsDesignMode, IPropertyDataDispatch
	{
		public ForeignKey() : base(){ }
		public ForeignKey(Table table, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = table;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		public Table Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Table;
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "CreateDate": return 0;
							case "DateLastModified": return 1;
							case "DeleteAction": return 2;
							case "ID": return 3;
							case "IsChecked": return 4;
							case "IsEnabled": return 5;
							case "IsSystemNamed": return 6;
							case "NotForReplication": return 7;
							case "ReferencedKey": return 8;
							case "ReferencedTable": return 9;
							case "ReferencedTableSchema": return 10;
							case "UpdateAction": return 11;
							case "IsMemoryOptimized": return 12;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "CreateDate": return 0;
						case "DeleteAction": return 1;
						case "ID": return 2;
						case "IsChecked": return 3;
						case "IsEnabled": return 4;
						case "IsSystemNamed": return 5;
						case "NotForReplication": return 6;
						case "ReferencedKey": return 7;
						case "ReferencedTable": return 8;
						case "ReferencedTableSchema": return 9;
						case "UpdateAction": return 10;
						case "DateLastModified": return 11;
						case "IsFileTableDefined": return 12;
						case "IsMemoryOptimized": return 13;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 11, 11, 12, 12, 12, 13, 14, 14, 14, 14, 14, 14 };
			static int [] cloudVersionCount = new int [] { 12, 12, 13 };
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
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DeleteAction", false, false, typeof(Microsoft.SqlServer.Management.Smo.ForeignKeyAction)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsChecked", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReferencedKey", false, true, typeof(System.String)),
				new StaticMetadata("ReferencedTable", false, false, typeof(System.String)),
				new StaticMetadata("ReferencedTableSchema", false, false, typeof(System.String)),
				new StaticMetadata("UpdateAction", false, false, typeof(Microsoft.SqlServer.Management.Smo.ForeignKeyAction)),
				new StaticMetadata("IsMemoryOptimized", true, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DeleteAction", false, false, typeof(Microsoft.SqlServer.Management.Smo.ForeignKeyAction)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsChecked", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReferencedKey", false, true, typeof(System.String)),
				new StaticMetadata("ReferencedTable", false, false, typeof(System.String)),
				new StaticMetadata("ReferencedTableSchema", false, false, typeof(System.String)),
				new StaticMetadata("UpdateAction", false, false, typeof(Microsoft.SqlServer.Management.Smo.ForeignKeyAction)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("IsFileTableDefined", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsMemoryOptimized", true, false, typeof(System.Boolean)),
			};
		}
		private sealed class XSchemaProps
		{
			private Microsoft.SqlServer.Management.Smo.ForeignKeyAction _DeleteAction;
			internal Microsoft.SqlServer.Management.Smo.ForeignKeyAction DeleteAction { get{ return _DeleteAction; } set{ _DeleteAction=value; } }

			private System.Boolean _IsChecked;
			internal System.Boolean IsChecked { get{ return _IsChecked; } set{ _IsChecked=value; } }

			private System.Boolean _IsEnabled;
			internal System.Boolean IsEnabled { get{ return _IsEnabled; } set{ _IsEnabled=value; } }

			private System.Boolean _IsSystemNamed;
			internal System.Boolean IsSystemNamed { get{ return _IsSystemNamed; } set{ _IsSystemNamed=value; } }

			private System.Boolean _NotForReplication;
			internal System.Boolean NotForReplication { get{ return _NotForReplication; } set{ _NotForReplication=value; } }

			private System.String _ReferencedTable;
			internal System.String ReferencedTable { get{ return _ReferencedTable; } set{ _ReferencedTable=value; } }

			private System.String _ReferencedTableSchema;
			internal System.String ReferencedTableSchema { get{ return _ReferencedTableSchema; } set{ _ReferencedTableSchema=value; } }

			private Microsoft.SqlServer.Management.Smo.ForeignKeyAction _UpdateAction;
			internal Microsoft.SqlServer.Management.Smo.ForeignKeyAction UpdateAction { get{ return _UpdateAction; } set{ _UpdateAction=value; } }

		}

		private sealed class XRuntimeProps
		{
			private System.DateTime _CreateDate;
			internal System.DateTime CreateDate { get{ return _CreateDate; } set{ _CreateDate=value; } }

			private System.DateTime _DateLastModified;
			internal System.DateTime DateLastModified { get{ return _DateLastModified; } set{ _DateLastModified=value; } }

			private System.Int32 _ID;
			internal System.Int32 ID { get{ return _ID; } set{ _ID=value; } }

			private System.Boolean _IsFileTableDefined;
			internal System.Boolean IsFileTableDefined { get{ return _IsFileTableDefined; } set{ _IsFileTableDefined=value; } }

			private System.Boolean _IsMemoryOptimized;
			internal System.Boolean IsMemoryOptimized { get{ return _IsMemoryOptimized; } set{ _IsMemoryOptimized=value; } }

			private System.String _ReferencedKey;
			internal System.String ReferencedKey { get{ return _ReferencedKey; } set{ _ReferencedKey=value; } }

		}

		object IPropertyDataDispatch.GetPropertyValue( int index )
		{
			object value;
			if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
			{
				if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
				{
					switch(index)
					{
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						value = this.XRuntime.CreateDate;
						break;
						case 1:
						value = this.XRuntime.DateLastModified;
						break;
						case 2:
						value = this.XSchema.DeleteAction;
						break;
						case 3:
						value = this.XRuntime.ID;
						break;
						case 4:
						value = this.XSchema.IsChecked;
						break;
						case 5:
						value = this.XSchema.IsEnabled;
						break;
						case 12:
						value = this.XRuntime.IsMemoryOptimized;
						break;
						case 6:
						value = this.XSchema.IsSystemNamed;
						break;
						case 7:
						value = this.XSchema.NotForReplication;
						break;
						case 8:
						value = this.XRuntime.ReferencedKey;
						break;
						case 9:
						value = this.XSchema.ReferencedTable;
						break;
						case 10:
						value = this.XSchema.ReferencedTableSchema;
						break;
						case 11:
						value = this.XSchema.UpdateAction;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
			}
			else
			{
				switch(index)
				{
					case 0:
					value = this.XRuntime.CreateDate;
					break;
					case 11:
					value = this.XRuntime.DateLastModified;
					break;
					case 1:
					value = this.XSchema.DeleteAction;
					break;
					case 2:
					value = this.XRuntime.ID;
					break;
					case 3:
					value = this.XSchema.IsChecked;
					break;
					case 4:
					value = this.XSchema.IsEnabled;
					break;
					case 12:
					value = this.XRuntime.IsFileTableDefined;
					break;
					case 13:
					value = this.XRuntime.IsMemoryOptimized;
					break;
					case 5:
					value = this.XSchema.IsSystemNamed;
					break;
					case 6:
					value = this.XSchema.NotForReplication;
					break;
					case 7:
					value = this.XRuntime.ReferencedKey;
					break;
					case 8:
					value = this.XSchema.ReferencedTable;
					break;
					case 9:
					value = this.XSchema.ReferencedTableSchema;
					break;
					case 10:
					value = this.XSchema.UpdateAction;
					break;
					default:
					throw new IndexOutOfRangeException();
				}
			}
			return value;
		}
		void IPropertyDataDispatch.SetPropertyValue( int index, object value )
		{
			if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
			{
				if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
				{
					switch(index)
					{
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						this.XRuntime.CreateDate = (System.DateTime)value;
						break;
						case 1:
						this.XRuntime.DateLastModified = (System.DateTime)value;
						break;
						case 2:
						this.XSchema.DeleteAction = (Microsoft.SqlServer.Management.Smo.ForeignKeyAction)value;
						break;
						case 3:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 4:
						this.XSchema.IsChecked = (System.Boolean)value;
						break;
						case 5:
						this.XSchema.IsEnabled = (System.Boolean)value;
						break;
						case 12:
						this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
						break;
						case 6:
						this.XSchema.IsSystemNamed = (System.Boolean)value;
						break;
						case 7:
						this.XSchema.NotForReplication = (System.Boolean)value;
						break;
						case 8:
						this.XRuntime.ReferencedKey = (System.String)value;
						break;
						case 9:
						this.XSchema.ReferencedTable = (System.String)value;
						break;
						case 10:
						this.XSchema.ReferencedTableSchema = (System.String)value;
						break;
						case 11:
						this.XSchema.UpdateAction = (Microsoft.SqlServer.Management.Smo.ForeignKeyAction)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
			}
			else
			{
				switch(index)
				{
					case 0:
					this.XRuntime.CreateDate = (System.DateTime)value;
					break;
					case 11:
					this.XRuntime.DateLastModified = (System.DateTime)value;
					break;
					case 1:
					this.XSchema.DeleteAction = (Microsoft.SqlServer.Management.Smo.ForeignKeyAction)value;
					break;
					case 2:
					this.XRuntime.ID = (System.Int32)value;
					break;
					case 3:
					this.XSchema.IsChecked = (System.Boolean)value;
					break;
					case 4:
					this.XSchema.IsEnabled = (System.Boolean)value;
					break;
					case 12:
					this.XRuntime.IsFileTableDefined = (System.Boolean)value;
					break;
					case 13:
					this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
					break;
					case 5:
					this.XSchema.IsSystemNamed = (System.Boolean)value;
					break;
					case 6:
					this.XSchema.NotForReplication = (System.Boolean)value;
					break;
					case 7:
					this.XRuntime.ReferencedKey = (System.String)value;
					break;
					case 8:
					this.XSchema.ReferencedTable = (System.String)value;
					break;
					case 9:
					this.XSchema.ReferencedTableSchema = (System.String)value;
					break;
					case 10:
					this.XSchema.UpdateAction = (Microsoft.SqlServer.Management.Smo.ForeignKeyAction)value;
					break;
					default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		XSchemaProps _XSchema;
		XSchemaProps XSchema 
		{
			get
			{
				if( _XSchema == null )
				{
					_XSchema = new XSchemaProps();
				}
				return _XSchema; 
			}
		}
		XRuntimeProps _XRuntime;
		XRuntimeProps XRuntime
		{
			get
			{
				if( _XRuntime == null )
				{
					_XRuntime = new XRuntimeProps();
				}
				return _XRuntime;
			}
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ForeignKeyAction DeleteAction
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ForeignKeyAction)this.Properties.GetValueWithNullReplacement("DeleteAction");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DeleteAction", value);
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsMemoryOptimized
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMemoryOptimized");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsMemoryOptimized", value);
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ReferencedKey
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReferencedKey");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Table),"Server[@Name='{0}']/Database[@Name='{1}']/Table[@Name='{2}' and @Schema='{3}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","ReferencedTable","ReferencedTableSchema")]
		[CLSCompliant(false)]
		public System.String ReferencedTable
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReferencedTable");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReferencedTable", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ReferencedTableSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ReferencedTableSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReferencedTableSchema", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ForeignKeyAction UpdateAction
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ForeignKeyAction)this.Properties.GetValueWithNullReplacement("UpdateAction");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UpdateAction", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "DeleteAction", "IsChecked", "IsMemoryOptimized", "NotForReplication", "UpdateAction" };
		}
	}
}
