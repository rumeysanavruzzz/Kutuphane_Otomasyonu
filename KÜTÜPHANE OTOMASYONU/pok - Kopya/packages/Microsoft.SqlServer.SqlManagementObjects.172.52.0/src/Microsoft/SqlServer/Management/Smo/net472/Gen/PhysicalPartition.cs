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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/PhysicalPartition
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class PhysicalPartition  : IPropertyDataDispatch
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		[SfcParent("Table")]
		[SfcParent("Index")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
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
							case "PartitionNumber": return 1;
							case "RangeType": return 2;
							case "RightBoundaryValue": return 3;
							case "RowCount": return 4;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "DataCompression": return 0;
							case "FileGroupName": return 1;
							case "PartitionNumber": return 2;
							case "RangeType": return 3;
							case "RightBoundaryValue": return 4;
							case "RowCount": return 5;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "FileGroupName": return 0;
						case "PartitionNumber": return 1;
						case "RangeType": return 2;
						case "RightBoundaryValue": return 3;
						case "RowCount": return 4;
						case "DataCompression": return 5;
						case "XmlCompression": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 5, 6, 6, 6, 6, 6, 6, 6, 7, 7 };
			static int [] cloudVersionCount = new int [] { 0, 0, 6 };
			static int sqlDwPropertyCount = 5;
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
				new StaticMetadata("DataCompression", false, false, typeof(Microsoft.SqlServer.Management.Smo.DataCompressionType)),
				new StaticMetadata("PartitionNumber", false, false, typeof(System.Int32)),
				new StaticMetadata("RangeType", false, false, typeof(Microsoft.SqlServer.Management.Smo.RangeType)),
				new StaticMetadata("RightBoundaryValue", false, false, typeof(System.Object)),
				new StaticMetadata("RowCount", false, true, typeof(System.Double)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("DataCompression", false, false, typeof(Microsoft.SqlServer.Management.Smo.DataCompressionType)),
				new StaticMetadata("FileGroupName", false, false, typeof(System.String)),
				new StaticMetadata("PartitionNumber", false, false, typeof(System.Int32)),
				new StaticMetadata("RangeType", false, false, typeof(Microsoft.SqlServer.Management.Smo.RangeType)),
				new StaticMetadata("RightBoundaryValue", false, false, typeof(System.Object)),
				new StaticMetadata("RowCount", false, true, typeof(System.Double)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("FileGroupName", false, false, typeof(System.String)),
				new StaticMetadata("PartitionNumber", false, false, typeof(System.Int32)),
				new StaticMetadata("RangeType", false, false, typeof(Microsoft.SqlServer.Management.Smo.RangeType)),
				new StaticMetadata("RightBoundaryValue", false, false, typeof(System.Object)),
				new StaticMetadata("RowCount", false, true, typeof(System.Double)),
				new StaticMetadata("DataCompression", false, false, typeof(Microsoft.SqlServer.Management.Smo.DataCompressionType)),
				new StaticMetadata("XmlCompression", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlCompressionType)),
			};
		}
		private sealed class XSchemaProps
		{
			private Microsoft.SqlServer.Management.Smo.DataCompressionType _DataCompression;
			internal Microsoft.SqlServer.Management.Smo.DataCompressionType DataCompression { get{ return _DataCompression; } set{ _DataCompression=value; } }

			private System.String _FileGroupName;
			internal System.String FileGroupName { get{ return _FileGroupName; } set{ _FileGroupName=value; } }

			private System.Int32 _PartitionNumber;
			internal System.Int32 PartitionNumber { get{ return _PartitionNumber; } set{ _PartitionNumber=value; } }

			private System.Object _RightBoundaryValue;
			internal System.Object RightBoundaryValue { get{ return _RightBoundaryValue; } set{ _RightBoundaryValue=value; } }

			private System.Double _RowCount;
			internal System.Double RowCount { get{ return _RowCount; } set{ _RowCount=value; } }

			private Microsoft.SqlServer.Management.Smo.XmlCompressionType _XmlCompression;
			internal Microsoft.SqlServer.Management.Smo.XmlCompressionType XmlCompression { get{ return _XmlCompression; } set{ _XmlCompression=value; } }

		}

		private sealed class XRuntimeProps
		{
			private Microsoft.SqlServer.Management.Smo.RangeType _RangeType;
			internal Microsoft.SqlServer.Management.Smo.RangeType RangeType { get{ return _RangeType; } set{ _RangeType=value; } }

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
						value = this.XSchema.DataCompression;
						break;
						case 1:
						value = this.XSchema.PartitionNumber;
						break;
						case 2:
						value = this.XRuntime.RangeType;
						break;
						case 3:
						value = this.XSchema.RightBoundaryValue;
						break;
						case 4:
						value = this.XSchema.RowCount;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						value = this.XSchema.DataCompression;
						break;
						case 1:
						value = this.XSchema.FileGroupName;
						break;
						case 2:
						value = this.XSchema.PartitionNumber;
						break;
						case 3:
						value = this.XRuntime.RangeType;
						break;
						case 4:
						value = this.XSchema.RightBoundaryValue;
						break;
						case 5:
						value = this.XSchema.RowCount;
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
					case 5:
					value = this.XSchema.DataCompression;
					break;
					case 0:
					value = this.XSchema.FileGroupName;
					break;
					case 1:
					value = this.XSchema.PartitionNumber;
					break;
					case 2:
					value = this.XRuntime.RangeType;
					break;
					case 3:
					value = this.XSchema.RightBoundaryValue;
					break;
					case 4:
					value = this.XSchema.RowCount;
					break;
					case 6:
					value = this.XSchema.XmlCompression;
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
						this.XSchema.DataCompression = (Microsoft.SqlServer.Management.Smo.DataCompressionType)value;
						break;
						case 1:
						this.XSchema.PartitionNumber = (System.Int32)value;
						break;
						case 2:
						this.XRuntime.RangeType = (Microsoft.SqlServer.Management.Smo.RangeType)value;
						break;
						case 3:
						this.XSchema.RightBoundaryValue = (System.Object)value;
						break;
						case 4:
						this.XSchema.RowCount = (System.Double)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						this.XSchema.DataCompression = (Microsoft.SqlServer.Management.Smo.DataCompressionType)value;
						break;
						case 1:
						this.XSchema.FileGroupName = (System.String)value;
						break;
						case 2:
						this.XSchema.PartitionNumber = (System.Int32)value;
						break;
						case 3:
						this.XRuntime.RangeType = (Microsoft.SqlServer.Management.Smo.RangeType)value;
						break;
						case 4:
						this.XSchema.RightBoundaryValue = (System.Object)value;
						break;
						case 5:
						this.XSchema.RowCount = (System.Double)value;
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
					case 5:
					this.XSchema.DataCompression = (Microsoft.SqlServer.Management.Smo.DataCompressionType)value;
					break;
					case 0:
					this.XSchema.FileGroupName = (System.String)value;
					break;
					case 1:
					this.XSchema.PartitionNumber = (System.Int32)value;
					break;
					case 2:
					this.XRuntime.RangeType = (Microsoft.SqlServer.Management.Smo.RangeType)value;
					break;
					case 3:
					this.XSchema.RightBoundaryValue = (System.Object)value;
					break;
					case 4:
					this.XSchema.RowCount = (System.Double)value;
					break;
					case 6:
					this.XSchema.XmlCompression = (Microsoft.SqlServer.Management.Smo.XmlCompressionType)value;
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
		public System.String FileGroupName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileGroupName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileGroupName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 PartitionNumber
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("PartitionNumber");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PartitionNumber", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double RowCount
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("RowCount");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.XmlCompressionType XmlCompression
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.XmlCompressionType)this.Properties.GetValueWithNullReplacement("XmlCompression");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("XmlCompression", value);
			}
		}
	}
}
