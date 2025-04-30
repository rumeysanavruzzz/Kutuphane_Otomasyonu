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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Index/IndexedColumn
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class IndexedColumn  : ISfcSupportsDesignMode, IPropertyDataDispatch
	{
		public IndexedColumn() : base(){ }
		public IndexedColumn(Index index, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = index;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design | SfcObjectFlags.Deploy)]
		public Index Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Index;
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
							case "ColumnStoreOrderOrdinal": return 0;
							case "Descending": return 1;
							case "ID": return 2;
							case "IsIncluded": return 3;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "Descending": return 0;
							case "ID": return 1;
							case "IsComputed": return 2;
							case "IsIncluded": return 3;
							case "ColumnStoreOrderOrdinal": return 4;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ID": return 0;
						case "IsComputed": return 1;
						case "Descending": return 2;
						case "IsIncluded": return 3;
						case "ColumnStoreOrderOrdinal": return 4;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 2, 3, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5 };
			static int [] cloudVersionCount = new int [] { 4, 4, 5 };
			static int sqlDwPropertyCount = 4;
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
				new StaticMetadata("ColumnStoreOrderOrdinal", false, true, typeof(System.Int32)),
				new StaticMetadata("Descending", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsIncluded", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("Descending", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsComputed", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsIncluded", false, false, typeof(System.Boolean)),
				new StaticMetadata("ColumnStoreOrderOrdinal", false, true, typeof(System.Int32)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsComputed", false, true, typeof(System.Boolean)),
				new StaticMetadata("Descending", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsIncluded", false, false, typeof(System.Boolean)),
				new StaticMetadata("ColumnStoreOrderOrdinal", false, true, typeof(System.Int32)),
			};
		}
		private sealed class XSchemaProps
		{
			private System.Int32 _ColumnStoreOrderOrdinal;
			internal System.Int32 ColumnStoreOrderOrdinal { get{ return _ColumnStoreOrderOrdinal; } set{ _ColumnStoreOrderOrdinal=value; } }

			private System.Boolean _Descending;
			internal System.Boolean Descending { get{ return _Descending; } set{ _Descending=value; } }

			private System.Boolean _IsComputed;
			internal System.Boolean IsComputed { get{ return _IsComputed; } set{ _IsComputed=value; } }

			private System.Boolean _IsIncluded;
			internal System.Boolean IsIncluded { get{ return _IsIncluded; } set{ _IsIncluded=value; } }

		}

		private sealed class XRuntimeProps
		{
			private System.Int32 _ID;
			internal System.Int32 ID { get{ return _ID; } set{ _ID=value; } }

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
						case 0:
						value = this.XSchema.ColumnStoreOrderOrdinal;
						break;
						case 1:
						value = this.XSchema.Descending;
						break;
						case 2:
						value = this.XRuntime.ID;
						break;
						case 3:
						value = this.XSchema.IsIncluded;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 4:
						value = this.XSchema.ColumnStoreOrderOrdinal;
						break;
						case 0:
						value = this.XSchema.Descending;
						break;
						case 1:
						value = this.XRuntime.ID;
						break;
						case 2:
						value = this.XSchema.IsComputed;
						break;
						case 3:
						value = this.XSchema.IsIncluded;
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
					case 4:
					value = this.XSchema.ColumnStoreOrderOrdinal;
					break;
					case 2:
					value = this.XSchema.Descending;
					break;
					case 0:
					value = this.XRuntime.ID;
					break;
					case 1:
					value = this.XSchema.IsComputed;
					break;
					case 3:
					value = this.XSchema.IsIncluded;
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
						case 0:
						this.XSchema.ColumnStoreOrderOrdinal = (System.Int32)value;
						break;
						case 1:
						this.XSchema.Descending = (System.Boolean)value;
						break;
						case 2:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 3:
						this.XSchema.IsIncluded = (System.Boolean)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 4:
						this.XSchema.ColumnStoreOrderOrdinal = (System.Int32)value;
						break;
						case 0:
						this.XSchema.Descending = (System.Boolean)value;
						break;
						case 1:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 2:
						this.XSchema.IsComputed = (System.Boolean)value;
						break;
						case 3:
						this.XSchema.IsIncluded = (System.Boolean)value;
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
					case 4:
					this.XSchema.ColumnStoreOrderOrdinal = (System.Int32)value;
					break;
					case 2:
					this.XSchema.Descending = (System.Boolean)value;
					break;
					case 0:
					this.XRuntime.ID = (System.Int32)value;
					break;
					case 1:
					this.XSchema.IsComputed = (System.Boolean)value;
					break;
					case 3:
					this.XSchema.IsIncluded = (System.Boolean)value;
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
		public System.Int32 ColumnStoreOrderOrdinal
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ColumnStoreOrderOrdinal");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Descending
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Descending");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Descending", value);
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
		public System.Boolean IsComputed
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsComputed");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsIncluded
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsIncluded");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsIncluded", value);
			}
		}
	}
}
