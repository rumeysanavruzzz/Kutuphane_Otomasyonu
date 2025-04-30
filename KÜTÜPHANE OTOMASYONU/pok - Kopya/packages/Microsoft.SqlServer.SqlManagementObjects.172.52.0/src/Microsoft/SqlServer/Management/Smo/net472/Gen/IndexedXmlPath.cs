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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Index/IndexedXmlPath
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class IndexedXmlPath  : ISfcSupportsDesignMode, IPropertyDataDispatch
	{
		public IndexedXmlPath() : base(){ }
		public IndexedXmlPath(Index index, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = index;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "DataType": return 0;
							case "DataTypeSchema": return 1;
							case "ID": return 2;
							case "IsNode": return 3;
							case "IsSingleton": return 4;
							case "IsXQueryMaxlengthInferred": return 5;
							case "IsXQueryTypeInferred": return 6;
							case "Length": return 7;
							case "NumericPrecision": return 8;
							case "NumericScale": return 9;
							case "Path": return 10;
							case "PathType": return 11;
							case "PathTypeDesc": return 12;
							case "SqlTypeCollationName": return 13;
							case "SystemType": return 14;
							case "XmlComponentID": return 15;
							case "XQueryMaxLength": return 16;
							case "XQueryTypeDescription": return 17;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "DataType": return 0;
						case "DataTypeSchema": return 1;
						case "ID": return 2;
						case "IsNode": return 3;
						case "IsSingleton": return 4;
						case "IsXQueryMaxlengthInferred": return 5;
						case "IsXQueryTypeInferred": return 6;
						case "Length": return 7;
						case "NumericPrecision": return 8;
						case "NumericScale": return 9;
						case "Path": return 10;
						case "PathType": return 11;
						case "PathTypeDesc": return 12;
						case "SqlTypeCollationName": return 13;
						case "SystemType": return 14;
						case "XmlComponentID": return 15;
						case "XQueryMaxLength": return 16;
						case "XQueryTypeDescription": return 17;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 18, 18, 18, 18, 18, 18, 18 };
			static int [] cloudVersionCount = new int [] { 0, 0, 18 };
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
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsNode", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSingleton", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsXQueryMaxlengthInferred", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXQueryTypeInferred", false, true, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("Path", false, false, typeof(System.String)),
				new StaticMetadata("PathType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexedXmlPathType)),
				new StaticMetadata("PathTypeDesc", false, false, typeof(System.String)),
				new StaticMetadata("SqlTypeCollationName", false, false, typeof(System.String)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("XmlComponentID", false, false, typeof(System.Int32)),
				new StaticMetadata("XQueryMaxLength", false, false, typeof(System.Int32)),
				new StaticMetadata("XQueryTypeDescription", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsNode", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSingleton", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsXQueryMaxlengthInferred", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXQueryTypeInferred", false, true, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("Path", false, false, typeof(System.String)),
				new StaticMetadata("PathType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexedXmlPathType)),
				new StaticMetadata("PathTypeDesc", false, false, typeof(System.String)),
				new StaticMetadata("SqlTypeCollationName", false, false, typeof(System.String)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("XmlComponentID", false, false, typeof(System.Int32)),
				new StaticMetadata("XQueryMaxLength", false, false, typeof(System.Int32)),
				new StaticMetadata("XQueryTypeDescription", false, false, typeof(System.String)),
			};
		}
		private sealed class XSchemaProps
		{
			private System.String _DataType;
			internal System.String DataType { get{ return _DataType; } set{ _DataType=value; } }

			private System.String _DataTypeSchema;
			internal System.String DataTypeSchema { get{ return _DataTypeSchema; } set{ _DataTypeSchema=value; } }

			private System.Boolean _IsNode;
			internal System.Boolean IsNode { get{ return _IsNode; } set{ _IsNode=value; } }

			private System.Boolean _IsSingleton;
			internal System.Boolean IsSingleton { get{ return _IsSingleton; } set{ _IsSingleton=value; } }

			private System.Boolean _IsXQueryMaxlengthInferred;
			internal System.Boolean IsXQueryMaxlengthInferred { get{ return _IsXQueryMaxlengthInferred; } set{ _IsXQueryMaxlengthInferred=value; } }

			private System.Boolean _IsXQueryTypeInferred;
			internal System.Boolean IsXQueryTypeInferred { get{ return _IsXQueryTypeInferred; } set{ _IsXQueryTypeInferred=value; } }

			private System.Int32 _Length;
			internal System.Int32 Length { get{ return _Length; } set{ _Length=value; } }

			private System.Int32 _NumericPrecision;
			internal System.Int32 NumericPrecision { get{ return _NumericPrecision; } set{ _NumericPrecision=value; } }

			private System.Int32 _NumericScale;
			internal System.Int32 NumericScale { get{ return _NumericScale; } set{ _NumericScale=value; } }

			private System.String _Path;
			internal System.String Path { get{ return _Path; } set{ _Path=value; } }

			private Microsoft.SqlServer.Management.Smo.IndexedXmlPathType _PathType;
			internal Microsoft.SqlServer.Management.Smo.IndexedXmlPathType PathType { get{ return _PathType; } set{ _PathType=value; } }

			private System.String _PathTypeDesc;
			internal System.String PathTypeDesc { get{ return _PathTypeDesc; } set{ _PathTypeDesc=value; } }

			private System.String _SqlTypeCollationName;
			internal System.String SqlTypeCollationName { get{ return _SqlTypeCollationName; } set{ _SqlTypeCollationName=value; } }

			private System.String _SystemType;
			internal System.String SystemType { get{ return _SystemType; } set{ _SystemType=value; } }

			private System.Int32 _XmlComponentID;
			internal System.Int32 XmlComponentID { get{ return _XmlComponentID; } set{ _XmlComponentID=value; } }

			private System.Int32 _XQueryMaxLength;
			internal System.Int32 XQueryMaxLength { get{ return _XQueryMaxLength; } set{ _XQueryMaxLength=value; } }

			private System.String _XQueryTypeDescription;
			internal System.String XQueryTypeDescription { get{ return _XQueryTypeDescription; } set{ _XQueryTypeDescription=value; } }

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
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						value = this.XSchema.DataType;
						break;
						case 1:
						value = this.XSchema.DataTypeSchema;
						break;
						case 2:
						value = this.XRuntime.ID;
						break;
						case 3:
						value = this.XSchema.IsNode;
						break;
						case 4:
						value = this.XSchema.IsSingleton;
						break;
						case 5:
						value = this.XSchema.IsXQueryMaxlengthInferred;
						break;
						case 6:
						value = this.XSchema.IsXQueryTypeInferred;
						break;
						case 7:
						value = this.XSchema.Length;
						break;
						case 8:
						value = this.XSchema.NumericPrecision;
						break;
						case 9:
						value = this.XSchema.NumericScale;
						break;
						case 10:
						value = this.XSchema.Path;
						break;
						case 11:
						value = this.XSchema.PathType;
						break;
						case 12:
						value = this.XSchema.PathTypeDesc;
						break;
						case 13:
						value = this.XSchema.SqlTypeCollationName;
						break;
						case 14:
						value = this.XSchema.SystemType;
						break;
						case 15:
						value = this.XSchema.XmlComponentID;
						break;
						case 16:
						value = this.XSchema.XQueryMaxLength;
						break;
						case 17:
						value = this.XSchema.XQueryTypeDescription;
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
					value = this.XSchema.DataType;
					break;
					case 1:
					value = this.XSchema.DataTypeSchema;
					break;
					case 2:
					value = this.XRuntime.ID;
					break;
					case 3:
					value = this.XSchema.IsNode;
					break;
					case 4:
					value = this.XSchema.IsSingleton;
					break;
					case 5:
					value = this.XSchema.IsXQueryMaxlengthInferred;
					break;
					case 6:
					value = this.XSchema.IsXQueryTypeInferred;
					break;
					case 7:
					value = this.XSchema.Length;
					break;
					case 8:
					value = this.XSchema.NumericPrecision;
					break;
					case 9:
					value = this.XSchema.NumericScale;
					break;
					case 10:
					value = this.XSchema.Path;
					break;
					case 11:
					value = this.XSchema.PathType;
					break;
					case 12:
					value = this.XSchema.PathTypeDesc;
					break;
					case 13:
					value = this.XSchema.SqlTypeCollationName;
					break;
					case 14:
					value = this.XSchema.SystemType;
					break;
					case 15:
					value = this.XSchema.XmlComponentID;
					break;
					case 16:
					value = this.XSchema.XQueryMaxLength;
					break;
					case 17:
					value = this.XSchema.XQueryTypeDescription;
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
						this.XSchema.DataType = (System.String)value;
						break;
						case 1:
						this.XSchema.DataTypeSchema = (System.String)value;
						break;
						case 2:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 3:
						this.XSchema.IsNode = (System.Boolean)value;
						break;
						case 4:
						this.XSchema.IsSingleton = (System.Boolean)value;
						break;
						case 5:
						this.XSchema.IsXQueryMaxlengthInferred = (System.Boolean)value;
						break;
						case 6:
						this.XSchema.IsXQueryTypeInferred = (System.Boolean)value;
						break;
						case 7:
						this.XSchema.Length = (System.Int32)value;
						break;
						case 8:
						this.XSchema.NumericPrecision = (System.Int32)value;
						break;
						case 9:
						this.XSchema.NumericScale = (System.Int32)value;
						break;
						case 10:
						this.XSchema.Path = (System.String)value;
						break;
						case 11:
						this.XSchema.PathType = (Microsoft.SqlServer.Management.Smo.IndexedXmlPathType)value;
						break;
						case 12:
						this.XSchema.PathTypeDesc = (System.String)value;
						break;
						case 13:
						this.XSchema.SqlTypeCollationName = (System.String)value;
						break;
						case 14:
						this.XSchema.SystemType = (System.String)value;
						break;
						case 15:
						this.XSchema.XmlComponentID = (System.Int32)value;
						break;
						case 16:
						this.XSchema.XQueryMaxLength = (System.Int32)value;
						break;
						case 17:
						this.XSchema.XQueryTypeDescription = (System.String)value;
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
					this.XSchema.DataType = (System.String)value;
					break;
					case 1:
					this.XSchema.DataTypeSchema = (System.String)value;
					break;
					case 2:
					this.XRuntime.ID = (System.Int32)value;
					break;
					case 3:
					this.XSchema.IsNode = (System.Boolean)value;
					break;
					case 4:
					this.XSchema.IsSingleton = (System.Boolean)value;
					break;
					case 5:
					this.XSchema.IsXQueryMaxlengthInferred = (System.Boolean)value;
					break;
					case 6:
					this.XSchema.IsXQueryTypeInferred = (System.Boolean)value;
					break;
					case 7:
					this.XSchema.Length = (System.Int32)value;
					break;
					case 8:
					this.XSchema.NumericPrecision = (System.Int32)value;
					break;
					case 9:
					this.XSchema.NumericScale = (System.Int32)value;
					break;
					case 10:
					this.XSchema.Path = (System.String)value;
					break;
					case 11:
					this.XSchema.PathType = (Microsoft.SqlServer.Management.Smo.IndexedXmlPathType)value;
					break;
					case 12:
					this.XSchema.PathTypeDesc = (System.String)value;
					break;
					case 13:
					this.XSchema.SqlTypeCollationName = (System.String)value;
					break;
					case 14:
					this.XSchema.SystemType = (System.String)value;
					break;
					case 15:
					this.XSchema.XmlComponentID = (System.Int32)value;
					break;
					case 16:
					this.XSchema.XQueryMaxLength = (System.Int32)value;
					break;
					case 17:
					this.XSchema.XQueryTypeDescription = (System.String)value;
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
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsNode
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsNode");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsNode", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSingleton
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSingleton");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSingleton", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsXQueryMaxlengthInferred
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsXQueryMaxlengthInferred");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsXQueryTypeInferred
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsXQueryTypeInferred");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Path
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Path");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Path", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "XQuery")]
		public Microsoft.SqlServer.Management.Smo.IndexedXmlPathType PathType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.IndexedXmlPathType)this.Properties.GetValueWithNullReplacement("PathType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PathType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String PathTypeDesc
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PathTypeDesc");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PathTypeDesc", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SqlTypeCollationName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlTypeCollationName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SqlTypeCollationName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 XmlComponentID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("XmlComponentID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("XmlComponentID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 XQueryMaxLength
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("XQueryMaxLength");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("XQueryMaxLength", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String XQueryTypeDescription
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("XQueryTypeDescription");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("XQueryTypeDescription", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "DataType", "DataTypeSchema", "IsNode", "IsSingleton", "Length", "NumericPrecision", "NumericScale", "Path", "PathType", "PathTypeDesc", "SqlTypeCollationName", "SystemType", "XmlComponentID", "XQueryMaxLength", "XQueryTypeDescription" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "PathType":
					return IndexedXmlPathType.XQuery;
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
