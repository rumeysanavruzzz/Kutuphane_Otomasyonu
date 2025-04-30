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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Index
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Index  : ISfcSupportsDesignMode, IPropertyDataDispatch
	{
		public Index() : base(){ }
		public Index(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		[SfcParent("Table")]
		[SfcParent("UserDefinedTableType")]
		[SfcParent("UserDefinedFunction")]
		[SfcParent("View")]
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
							case "DisallowPageLocks": return 0;
							case "DisallowRowLocks": return 1;
							case "FileGroup": return 2;
							case "FillFactor": return 3;
							case "FilterDefinition": return 4;
							case "HasCompressedPartitions": return 5;
							case "HasFilter": return 6;
							case "HasSparseColumn": return 7;
							case "ID": return 8;
							case "IgnoreDuplicateKeys": return 9;
							case "IndexKeyType": return 10;
							case "IndexType": return 11;
							case "IsClustered": return 12;
							case "IsDisabled": return 13;
							case "IsFullTextKey": return 14;
							case "IsPartitioned": return 15;
							case "IsSystemNamed": return 16;
							case "IsSystemObject": return 17;
							case "IsUnique": return 18;
							case "IsXmlIndex": return 19;
							case "NoAutomaticRecomputation": return 20;
							case "PadIndex": return 21;
							case "PartitionScheme": return 22;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "BoundingBoxXMax": return 0;
							case "BoundingBoxXMin": return 1;
							case "BoundingBoxYMax": return 2;
							case "BoundingBoxYMin": return 3;
							case "CellsPerObject": return 4;
							case "DisallowPageLocks": return 5;
							case "DisallowRowLocks": return 6;
							case "FillFactor": return 7;
							case "FilterDefinition": return 8;
							case "HasFilter": return 9;
							case "HasSparseColumn": return 10;
							case "ID": return 11;
							case "IgnoreDuplicateKeys": return 12;
							case "IndexKeyType": return 13;
							case "IndexType": return 14;
							case "IsClustered": return 15;
							case "IsDisabled": return 16;
							case "IsFullTextKey": return 17;
							case "IsSpatialIndex": return 18;
							case "IsSystemNamed": return 19;
							case "IsSystemObject": return 20;
							case "IsUnique": return 21;
							case "IsXmlIndex": return 22;
							case "Level1Grid": return 23;
							case "Level2Grid": return 24;
							case "Level3Grid": return 25;
							case "Level4Grid": return 26;
							case "NoAutomaticRecomputation": return 27;
							case "PadIndex": return 28;
							case "SpatialIndexType": return 29;
							case "BucketCount": return 30;
							case "CompressionDelay": return 31;
							case "FileGroup": return 32;
							case "FileStreamFileGroup": return 33;
							case "FileStreamPartitionScheme": return 34;
							case "HasCompressedPartitions": return 35;
							case "IndexedXmlPathName": return 36;
							case "IsMemoryOptimized": return 37;
							case "IsOptimizedForSequentialKey": return 38;
							case "IsPartitioned": return 39;
							case "ParentXmlIndex": return 40;
							case "PartitionScheme": return 41;
							case "ResumableOperationState": return 42;
							case "SecondaryXmlIndexType": return 43;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "DisallowPageLocks": return 0;
						case "DisallowRowLocks": return 1;
						case "FileGroup": return 2;
						case "FillFactor": return 3;
						case "HasSparseColumn": return 4;
						case "ID": return 5;
						case "IgnoreDuplicateKeys": return 6;
						case "IndexKeyType": return 7;
						case "IndexType": return 8;
						case "IsClustered": return 9;
						case "IsFullTextKey": return 10;
						case "IsSystemNamed": return 11;
						case "IsSystemObject": return 12;
						case "IsUnique": return 13;
						case "NoAutomaticRecomputation": return 14;
						case "PadIndex": return 15;
						case "SpaceUsed": return 16;
						case "IsDisabled": return 17;
						case "IsPartitioned": return 18;
						case "IsXmlIndex": return 19;
						case "ParentXmlIndex": return 20;
						case "PartitionScheme": return 21;
						case "SecondaryXmlIndexType": return 22;
						case "BoundingBoxXMax": return 23;
						case "BoundingBoxXMin": return 24;
						case "BoundingBoxYMax": return 25;
						case "BoundingBoxYMin": return 26;
						case "CellsPerObject": return 27;
						case "FileStreamFileGroup": return 28;
						case "FileStreamPartitionScheme": return 29;
						case "FilterDefinition": return 30;
						case "HasCompressedPartitions": return 31;
						case "HasFilter": return 32;
						case "IsSpatialIndex": return 33;
						case "Level1Grid": return 34;
						case "Level2Grid": return 35;
						case "Level3Grid": return 36;
						case "Level4Grid": return 37;
						case "PolicyHealthState": return 38;
						case "SpatialIndexType": return 39;
						case "IndexedXmlPathName": return 40;
						case "IsFileTableDefined": return 41;
						case "BucketCount": return 42;
						case "IsMemoryOptimized": return 43;
						case "CompressionDelay": return 44;
						case "ResumableOperationState": return 45;
						case "IsOptimizedForSequentialKey": return 46;
						case "HasXmlCompressedPartitions": return 47;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 17, 17, 23, 40, 40, 42, 44, 45, 46, 47, 48, 48 };
			static int [] cloudVersionCount = new int [] { 30, 30, 44 };
			static int sqlDwPropertyCount = 23;
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
				new StaticMetadata("DisallowPageLocks", false, false, typeof(System.Boolean)),
				new StaticMetadata("DisallowRowLocks", false, false, typeof(System.Boolean)),
				new StaticMetadata("FileGroup", true, false, typeof(System.String)),
				new StaticMetadata("FillFactor", false, false, typeof(System.Byte)),
				new StaticMetadata("FilterDefinition", false, false, typeof(System.String)),
				new StaticMetadata("HasCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasFilter", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSparseColumn", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IgnoreDuplicateKeys", false, false, typeof(System.Boolean)),
				new StaticMetadata("IndexKeyType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexKeyType)),
				new StaticMetadata("IndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexType)),
				new StaticMetadata("IsClustered", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDisabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextKey", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPartitioned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsUnique", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsXmlIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("NoAutomaticRecomputation", false, false, typeof(System.Boolean)),
				new StaticMetadata("PadIndex", false, false, typeof(System.Boolean)),
				new StaticMetadata("PartitionScheme", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("BoundingBoxXMax", false, false, typeof(System.Double)),
				new StaticMetadata("BoundingBoxXMin", false, false, typeof(System.Double)),
				new StaticMetadata("BoundingBoxYMax", false, false, typeof(System.Double)),
				new StaticMetadata("BoundingBoxYMin", false, false, typeof(System.Double)),
				new StaticMetadata("CellsPerObject", false, false, typeof(System.Int32)),
				new StaticMetadata("DisallowPageLocks", false, false, typeof(System.Boolean)),
				new StaticMetadata("DisallowRowLocks", false, false, typeof(System.Boolean)),
				new StaticMetadata("FillFactor", false, false, typeof(System.Byte)),
				new StaticMetadata("FilterDefinition", false, false, typeof(System.String)),
				new StaticMetadata("HasFilter", false, true, typeof(System.Boolean)),
				new StaticMetadata("HasSparseColumn", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IgnoreDuplicateKeys", false, false, typeof(System.Boolean)),
				new StaticMetadata("IndexKeyType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexKeyType)),
				new StaticMetadata("IndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexType)),
				new StaticMetadata("IsClustered", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDisabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextKey", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSpatialIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsUnique", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsXmlIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("Level1Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("Level2Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("Level3Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("Level4Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("NoAutomaticRecomputation", false, false, typeof(System.Boolean)),
				new StaticMetadata("PadIndex", false, false, typeof(System.Boolean)),
				new StaticMetadata("SpatialIndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialIndexType)),
				new StaticMetadata("BucketCount", false, false, typeof(System.Int32)),
				new StaticMetadata("CompressionDelay", false, false, typeof(System.Int32)),
				new StaticMetadata("FileGroup", true, false, typeof(System.String)),
				new StaticMetadata("FileStreamFileGroup", false, false, typeof(System.String)),
				new StaticMetadata("FileStreamPartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("HasCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("IndexedXmlPathName", false, false, typeof(System.String)),
				new StaticMetadata("IsMemoryOptimized", true, false, typeof(System.Boolean)),
				new StaticMetadata("IsOptimizedForSequentialKey", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPartitioned", false, true, typeof(System.Boolean)),
				new StaticMetadata("ParentXmlIndex", false, false, typeof(System.String)),
				new StaticMetadata("PartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("ResumableOperationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)),
				new StaticMetadata("SecondaryXmlIndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DisallowPageLocks", false, false, typeof(System.Boolean)),
				new StaticMetadata("DisallowRowLocks", false, false, typeof(System.Boolean)),
				new StaticMetadata("FileGroup", true, false, typeof(System.String)),
				new StaticMetadata("FillFactor", false, false, typeof(System.Byte)),
				new StaticMetadata("HasSparseColumn", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IgnoreDuplicateKeys", false, false, typeof(System.Boolean)),
				new StaticMetadata("IndexKeyType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexKeyType)),
				new StaticMetadata("IndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.IndexType)),
				new StaticMetadata("IsClustered", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextKey", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsUnique", false, false, typeof(System.Boolean)),
				new StaticMetadata("NoAutomaticRecomputation", false, false, typeof(System.Boolean)),
				new StaticMetadata("PadIndex", false, false, typeof(System.Boolean)),
				new StaticMetadata("SpaceUsed", true, true, typeof(System.Double)),
				new StaticMetadata("IsDisabled", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsPartitioned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsXmlIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("ParentXmlIndex", false, false, typeof(System.String)),
				new StaticMetadata("PartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("SecondaryXmlIndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType)),
				new StaticMetadata("BoundingBoxXMax", false, false, typeof(System.Double)),
				new StaticMetadata("BoundingBoxXMin", false, false, typeof(System.Double)),
				new StaticMetadata("BoundingBoxYMax", false, false, typeof(System.Double)),
				new StaticMetadata("BoundingBoxYMin", false, false, typeof(System.Double)),
				new StaticMetadata("CellsPerObject", false, false, typeof(System.Int32)),
				new StaticMetadata("FileStreamFileGroup", false, false, typeof(System.String)),
				new StaticMetadata("FileStreamPartitionScheme", false, false, typeof(System.String)),
				new StaticMetadata("FilterDefinition", false, false, typeof(System.String)),
				new StaticMetadata("HasCompressedPartitions", true, true, typeof(System.Boolean)),
				new StaticMetadata("HasFilter", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSpatialIndex", false, true, typeof(System.Boolean)),
				new StaticMetadata("Level1Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("Level2Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("Level3Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("Level4Grid", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("SpatialIndexType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SpatialIndexType)),
				new StaticMetadata("IndexedXmlPathName", false, false, typeof(System.String)),
				new StaticMetadata("IsFileTableDefined", false, true, typeof(System.Boolean)),
				new StaticMetadata("BucketCount", false, false, typeof(System.Int32)),
				new StaticMetadata("IsMemoryOptimized", true, false, typeof(System.Boolean)),
				new StaticMetadata("CompressionDelay", false, false, typeof(System.Int32)),
				new StaticMetadata("ResumableOperationState", false, true, typeof(Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)),
				new StaticMetadata("IsOptimizedForSequentialKey", false, false, typeof(System.Boolean)),
				new StaticMetadata("HasXmlCompressedPartitions", true, true, typeof(System.Boolean)),
			};
		}
		private sealed class XSchemaProps
		{
			private System.Double _BoundingBoxXMax;
			internal System.Double BoundingBoxXMax { get{ return _BoundingBoxXMax; } set{ _BoundingBoxXMax=value; } }

			private System.Double _BoundingBoxXMin;
			internal System.Double BoundingBoxXMin { get{ return _BoundingBoxXMin; } set{ _BoundingBoxXMin=value; } }

			private System.Double _BoundingBoxYMax;
			internal System.Double BoundingBoxYMax { get{ return _BoundingBoxYMax; } set{ _BoundingBoxYMax=value; } }

			private System.Double _BoundingBoxYMin;
			internal System.Double BoundingBoxYMin { get{ return _BoundingBoxYMin; } set{ _BoundingBoxYMin=value; } }

			private System.Int32 _CellsPerObject;
			internal System.Int32 CellsPerObject { get{ return _CellsPerObject; } set{ _CellsPerObject=value; } }

			private System.String _FileGroup;
			internal System.String FileGroup { get{ return _FileGroup; } set{ _FileGroup=value; } }

			private System.String _FileStreamFileGroup;
			internal System.String FileStreamFileGroup { get{ return _FileStreamFileGroup; } set{ _FileStreamFileGroup=value; } }

			private System.String _FileStreamPartitionScheme;
			internal System.String FileStreamPartitionScheme { get{ return _FileStreamPartitionScheme; } set{ _FileStreamPartitionScheme=value; } }

			private System.Byte _FillFactor;
			internal System.Byte FillFactor { get{ return _FillFactor; } set{ _FillFactor=value; } }

			private System.Boolean _IgnoreDuplicateKeys;
			internal System.Boolean IgnoreDuplicateKeys { get{ return _IgnoreDuplicateKeys; } set{ _IgnoreDuplicateKeys=value; } }

			private System.String _IndexedXmlPathName;
			internal System.String IndexedXmlPathName { get{ return _IndexedXmlPathName; } set{ _IndexedXmlPathName=value; } }

			private Microsoft.SqlServer.Management.Smo.IndexKeyType _IndexKeyType;
			internal Microsoft.SqlServer.Management.Smo.IndexKeyType IndexKeyType { get{ return _IndexKeyType; } set{ _IndexKeyType=value; } }

			private Microsoft.SqlServer.Management.Smo.IndexType _IndexType;
			internal Microsoft.SqlServer.Management.Smo.IndexType IndexType { get{ return _IndexType; } set{ _IndexType=value; } }

			private System.Boolean _IsClustered;
			internal System.Boolean IsClustered { get{ return _IsClustered; } set{ _IsClustered=value; } }

			private System.Boolean _IsSpatialIndex;
			internal System.Boolean IsSpatialIndex { get{ return _IsSpatialIndex; } set{ _IsSpatialIndex=value; } }

			private System.Boolean _IsSystemNamed;
			internal System.Boolean IsSystemNamed { get{ return _IsSystemNamed; } set{ _IsSystemNamed=value; } }

			private System.Boolean _IsUnique;
			internal System.Boolean IsUnique { get{ return _IsUnique; } set{ _IsUnique=value; } }

			private System.Boolean _IsXmlIndex;
			internal System.Boolean IsXmlIndex { get{ return _IsXmlIndex; } set{ _IsXmlIndex=value; } }

			private Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize _Level1Grid;
			internal Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level1Grid { get{ return _Level1Grid; } set{ _Level1Grid=value; } }

			private Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize _Level2Grid;
			internal Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level2Grid { get{ return _Level2Grid; } set{ _Level2Grid=value; } }

			private Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize _Level3Grid;
			internal Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level3Grid { get{ return _Level3Grid; } set{ _Level3Grid=value; } }

			private Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize _Level4Grid;
			internal Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level4Grid { get{ return _Level4Grid; } set{ _Level4Grid=value; } }

			private System.Boolean _PadIndex;
			internal System.Boolean PadIndex { get{ return _PadIndex; } set{ _PadIndex=value; } }

			private System.String _PartitionScheme;
			internal System.String PartitionScheme { get{ return _PartitionScheme; } set{ _PartitionScheme=value; } }

			private Microsoft.SqlServer.Management.Smo.ResumableOperationStateType _ResumableOperationState;
			internal Microsoft.SqlServer.Management.Smo.ResumableOperationStateType ResumableOperationState { get{ return _ResumableOperationState; } set{ _ResumableOperationState=value; } }

			private Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType _SecondaryXmlIndexType;
			internal Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType SecondaryXmlIndexType { get{ return _SecondaryXmlIndexType; } set{ _SecondaryXmlIndexType=value; } }

			private Microsoft.SqlServer.Management.Smo.SpatialIndexType _SpatialIndexType;
			internal Microsoft.SqlServer.Management.Smo.SpatialIndexType SpatialIndexType { get{ return _SpatialIndexType; } set{ _SpatialIndexType=value; } }

		}

		private sealed class XRuntimeProps
		{
			private System.Int32 _BucketCount;
			internal System.Int32 BucketCount { get{ return _BucketCount; } set{ _BucketCount=value; } }

			private System.Int32 _CompressionDelay;
			internal System.Int32 CompressionDelay { get{ return _CompressionDelay; } set{ _CompressionDelay=value; } }

			private System.Boolean _DisallowPageLocks;
			internal System.Boolean DisallowPageLocks { get{ return _DisallowPageLocks; } set{ _DisallowPageLocks=value; } }

			private System.Boolean _DisallowRowLocks;
			internal System.Boolean DisallowRowLocks { get{ return _DisallowRowLocks; } set{ _DisallowRowLocks=value; } }

			private System.String _FilterDefinition;
			internal System.String FilterDefinition { get{ return _FilterDefinition; } set{ _FilterDefinition=value; } }

			private System.Boolean _HasCompressedPartitions;
			internal System.Boolean HasCompressedPartitions { get{ return _HasCompressedPartitions; } set{ _HasCompressedPartitions=value; } }

			private System.Boolean _HasFilter;
			internal System.Boolean HasFilter { get{ return _HasFilter; } set{ _HasFilter=value; } }

			private System.Boolean _HasSparseColumn;
			internal System.Boolean HasSparseColumn { get{ return _HasSparseColumn; } set{ _HasSparseColumn=value; } }

			private System.Boolean _HasXmlCompressedPartitions;
			internal System.Boolean HasXmlCompressedPartitions { get{ return _HasXmlCompressedPartitions; } set{ _HasXmlCompressedPartitions=value; } }

			private System.Int32 _ID;
			internal System.Int32 ID { get{ return _ID; } set{ _ID=value; } }

			private System.Boolean _IsDisabled;
			internal System.Boolean IsDisabled { get{ return _IsDisabled; } set{ _IsDisabled=value; } }

			private System.Boolean _IsFileTableDefined;
			internal System.Boolean IsFileTableDefined { get{ return _IsFileTableDefined; } set{ _IsFileTableDefined=value; } }

			private System.Boolean _IsFullTextKey;
			internal System.Boolean IsFullTextKey { get{ return _IsFullTextKey; } set{ _IsFullTextKey=value; } }

			private System.Boolean _IsMemoryOptimized;
			internal System.Boolean IsMemoryOptimized { get{ return _IsMemoryOptimized; } set{ _IsMemoryOptimized=value; } }

			private System.Boolean _IsOptimizedForSequentialKey;
			internal System.Boolean IsOptimizedForSequentialKey { get{ return _IsOptimizedForSequentialKey; } set{ _IsOptimizedForSequentialKey=value; } }

			private System.Boolean _IsPartitioned;
			internal System.Boolean IsPartitioned { get{ return _IsPartitioned; } set{ _IsPartitioned=value; } }

			private System.Boolean _IsSystemObject;
			internal System.Boolean IsSystemObject { get{ return _IsSystemObject; } set{ _IsSystemObject=value; } }

			private System.Boolean _NoAutomaticRecomputation;
			internal System.Boolean NoAutomaticRecomputation { get{ return _NoAutomaticRecomputation; } set{ _NoAutomaticRecomputation=value; } }

			private System.String _ParentXmlIndex;
			internal System.String ParentXmlIndex { get{ return _ParentXmlIndex; } set{ _ParentXmlIndex=value; } }

			private Microsoft.SqlServer.Management.Dmf.PolicyHealthState _PolicyHealthState;
			internal Microsoft.SqlServer.Management.Dmf.PolicyHealthState PolicyHealthState { get{ return _PolicyHealthState; } set{ _PolicyHealthState=value; } }

			private System.Double _SpaceUsed;
			internal System.Double SpaceUsed { get{ return _SpaceUsed; } set{ _SpaceUsed=value; } }

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
						value = this.XRuntime.DisallowPageLocks;
						break;
						case 1:
						value = this.XRuntime.DisallowRowLocks;
						break;
						case 2:
						value = this.XSchema.FileGroup;
						break;
						case 3:
						value = this.XSchema.FillFactor;
						break;
						case 4:
						value = this.XRuntime.FilterDefinition;
						break;
						case 5:
						value = this.XRuntime.HasCompressedPartitions;
						break;
						case 6:
						value = this.XRuntime.HasFilter;
						break;
						case 7:
						value = this.XRuntime.HasSparseColumn;
						break;
						case 8:
						value = this.XRuntime.ID;
						break;
						case 9:
						value = this.XSchema.IgnoreDuplicateKeys;
						break;
						case 10:
						value = this.XSchema.IndexKeyType;
						break;
						case 11:
						value = this.XSchema.IndexType;
						break;
						case 12:
						value = this.XSchema.IsClustered;
						break;
						case 13:
						value = this.XRuntime.IsDisabled;
						break;
						case 14:
						value = this.XRuntime.IsFullTextKey;
						break;
						case 15:
						value = this.XRuntime.IsPartitioned;
						break;
						case 16:
						value = this.XSchema.IsSystemNamed;
						break;
						case 17:
						value = this.XRuntime.IsSystemObject;
						break;
						case 18:
						value = this.XSchema.IsUnique;
						break;
						case 19:
						value = this.XSchema.IsXmlIndex;
						break;
						case 20:
						value = this.XRuntime.NoAutomaticRecomputation;
						break;
						case 21:
						value = this.XSchema.PadIndex;
						break;
						case 22:
						value = this.XSchema.PartitionScheme;
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
						value = this.XSchema.BoundingBoxXMax;
						break;
						case 1:
						value = this.XSchema.BoundingBoxXMin;
						break;
						case 2:
						value = this.XSchema.BoundingBoxYMax;
						break;
						case 3:
						value = this.XSchema.BoundingBoxYMin;
						break;
						case 30:
						value = this.XRuntime.BucketCount;
						break;
						case 4:
						value = this.XSchema.CellsPerObject;
						break;
						case 31:
						value = this.XRuntime.CompressionDelay;
						break;
						case 5:
						value = this.XRuntime.DisallowPageLocks;
						break;
						case 6:
						value = this.XRuntime.DisallowRowLocks;
						break;
						case 32:
						value = this.XSchema.FileGroup;
						break;
						case 33:
						value = this.XSchema.FileStreamFileGroup;
						break;
						case 34:
						value = this.XSchema.FileStreamPartitionScheme;
						break;
						case 7:
						value = this.XSchema.FillFactor;
						break;
						case 8:
						value = this.XRuntime.FilterDefinition;
						break;
						case 35:
						value = this.XRuntime.HasCompressedPartitions;
						break;
						case 9:
						value = this.XRuntime.HasFilter;
						break;
						case 10:
						value = this.XRuntime.HasSparseColumn;
						break;
						case 11:
						value = this.XRuntime.ID;
						break;
						case 12:
						value = this.XSchema.IgnoreDuplicateKeys;
						break;
						case 36:
						value = this.XSchema.IndexedXmlPathName;
						break;
						case 13:
						value = this.XSchema.IndexKeyType;
						break;
						case 14:
						value = this.XSchema.IndexType;
						break;
						case 15:
						value = this.XSchema.IsClustered;
						break;
						case 16:
						value = this.XRuntime.IsDisabled;
						break;
						case 17:
						value = this.XRuntime.IsFullTextKey;
						break;
						case 37:
						value = this.XRuntime.IsMemoryOptimized;
						break;
						case 38:
						value = this.XRuntime.IsOptimizedForSequentialKey;
						break;
						case 39:
						value = this.XRuntime.IsPartitioned;
						break;
						case 18:
						value = this.XSchema.IsSpatialIndex;
						break;
						case 19:
						value = this.XSchema.IsSystemNamed;
						break;
						case 20:
						value = this.XRuntime.IsSystemObject;
						break;
						case 21:
						value = this.XSchema.IsUnique;
						break;
						case 22:
						value = this.XSchema.IsXmlIndex;
						break;
						case 23:
						value = this.XSchema.Level1Grid;
						break;
						case 24:
						value = this.XSchema.Level2Grid;
						break;
						case 25:
						value = this.XSchema.Level3Grid;
						break;
						case 26:
						value = this.XSchema.Level4Grid;
						break;
						case 27:
						value = this.XRuntime.NoAutomaticRecomputation;
						break;
						case 28:
						value = this.XSchema.PadIndex;
						break;
						case 40:
						value = this.XRuntime.ParentXmlIndex;
						break;
						case 41:
						value = this.XSchema.PartitionScheme;
						break;
						case 42:
						value = this.XSchema.ResumableOperationState;
						break;
						case 43:
						value = this.XSchema.SecondaryXmlIndexType;
						break;
						case 29:
						value = this.XSchema.SpatialIndexType;
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
					case 23:
					value = this.XSchema.BoundingBoxXMax;
					break;
					case 24:
					value = this.XSchema.BoundingBoxXMin;
					break;
					case 25:
					value = this.XSchema.BoundingBoxYMax;
					break;
					case 26:
					value = this.XSchema.BoundingBoxYMin;
					break;
					case 42:
					value = this.XRuntime.BucketCount;
					break;
					case 27:
					value = this.XSchema.CellsPerObject;
					break;
					case 44:
					value = this.XRuntime.CompressionDelay;
					break;
					case 0:
					value = this.XRuntime.DisallowPageLocks;
					break;
					case 1:
					value = this.XRuntime.DisallowRowLocks;
					break;
					case 2:
					value = this.XSchema.FileGroup;
					break;
					case 28:
					value = this.XSchema.FileStreamFileGroup;
					break;
					case 29:
					value = this.XSchema.FileStreamPartitionScheme;
					break;
					case 3:
					value = this.XSchema.FillFactor;
					break;
					case 30:
					value = this.XRuntime.FilterDefinition;
					break;
					case 31:
					value = this.XRuntime.HasCompressedPartitions;
					break;
					case 32:
					value = this.XRuntime.HasFilter;
					break;
					case 4:
					value = this.XRuntime.HasSparseColumn;
					break;
					case 47:
					value = this.XRuntime.HasXmlCompressedPartitions;
					break;
					case 5:
					value = this.XRuntime.ID;
					break;
					case 6:
					value = this.XSchema.IgnoreDuplicateKeys;
					break;
					case 40:
					value = this.XSchema.IndexedXmlPathName;
					break;
					case 7:
					value = this.XSchema.IndexKeyType;
					break;
					case 8:
					value = this.XSchema.IndexType;
					break;
					case 9:
					value = this.XSchema.IsClustered;
					break;
					case 17:
					value = this.XRuntime.IsDisabled;
					break;
					case 41:
					value = this.XRuntime.IsFileTableDefined;
					break;
					case 10:
					value = this.XRuntime.IsFullTextKey;
					break;
					case 43:
					value = this.XRuntime.IsMemoryOptimized;
					break;
					case 46:
					value = this.XRuntime.IsOptimizedForSequentialKey;
					break;
					case 18:
					value = this.XRuntime.IsPartitioned;
					break;
					case 33:
					value = this.XSchema.IsSpatialIndex;
					break;
					case 11:
					value = this.XSchema.IsSystemNamed;
					break;
					case 12:
					value = this.XRuntime.IsSystemObject;
					break;
					case 13:
					value = this.XSchema.IsUnique;
					break;
					case 19:
					value = this.XSchema.IsXmlIndex;
					break;
					case 34:
					value = this.XSchema.Level1Grid;
					break;
					case 35:
					value = this.XSchema.Level2Grid;
					break;
					case 36:
					value = this.XSchema.Level3Grid;
					break;
					case 37:
					value = this.XSchema.Level4Grid;
					break;
					case 14:
					value = this.XRuntime.NoAutomaticRecomputation;
					break;
					case 15:
					value = this.XSchema.PadIndex;
					break;
					case 20:
					value = this.XRuntime.ParentXmlIndex;
					break;
					case 21:
					value = this.XSchema.PartitionScheme;
					break;
					case 38:
					value = this.XRuntime.PolicyHealthState;
					break;
					case 45:
					value = this.XSchema.ResumableOperationState;
					break;
					case 22:
					value = this.XSchema.SecondaryXmlIndexType;
					break;
					case 16:
					value = this.XRuntime.SpaceUsed;
					break;
					case 39:
					value = this.XSchema.SpatialIndexType;
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
						this.XRuntime.DisallowPageLocks = (System.Boolean)value;
						break;
						case 1:
						this.XRuntime.DisallowRowLocks = (System.Boolean)value;
						break;
						case 2:
						this.XSchema.FileGroup = (System.String)value;
						break;
						case 3:
						this.XSchema.FillFactor = (System.Byte)value;
						break;
						case 4:
						this.XRuntime.FilterDefinition = (System.String)value;
						break;
						case 5:
						this.XRuntime.HasCompressedPartitions = (System.Boolean)value;
						break;
						case 6:
						this.XRuntime.HasFilter = (System.Boolean)value;
						break;
						case 7:
						this.XRuntime.HasSparseColumn = (System.Boolean)value;
						break;
						case 8:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 9:
						this.XSchema.IgnoreDuplicateKeys = (System.Boolean)value;
						break;
						case 10:
						this.XSchema.IndexKeyType = (Microsoft.SqlServer.Management.Smo.IndexKeyType)value;
						break;
						case 11:
						this.XSchema.IndexType = (Microsoft.SqlServer.Management.Smo.IndexType)value;
						break;
						case 12:
						this.XSchema.IsClustered = (System.Boolean)value;
						break;
						case 13:
						this.XRuntime.IsDisabled = (System.Boolean)value;
						break;
						case 14:
						this.XRuntime.IsFullTextKey = (System.Boolean)value;
						break;
						case 15:
						this.XRuntime.IsPartitioned = (System.Boolean)value;
						break;
						case 16:
						this.XSchema.IsSystemNamed = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.IsSystemObject = (System.Boolean)value;
						break;
						case 18:
						this.XSchema.IsUnique = (System.Boolean)value;
						break;
						case 19:
						this.XSchema.IsXmlIndex = (System.Boolean)value;
						break;
						case 20:
						this.XRuntime.NoAutomaticRecomputation = (System.Boolean)value;
						break;
						case 21:
						this.XSchema.PadIndex = (System.Boolean)value;
						break;
						case 22:
						this.XSchema.PartitionScheme = (System.String)value;
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
						this.XSchema.BoundingBoxXMax = (System.Double)value;
						break;
						case 1:
						this.XSchema.BoundingBoxXMin = (System.Double)value;
						break;
						case 2:
						this.XSchema.BoundingBoxYMax = (System.Double)value;
						break;
						case 3:
						this.XSchema.BoundingBoxYMin = (System.Double)value;
						break;
						case 30:
						this.XRuntime.BucketCount = (System.Int32)value;
						break;
						case 4:
						this.XSchema.CellsPerObject = (System.Int32)value;
						break;
						case 31:
						this.XRuntime.CompressionDelay = (System.Int32)value;
						break;
						case 5:
						this.XRuntime.DisallowPageLocks = (System.Boolean)value;
						break;
						case 6:
						this.XRuntime.DisallowRowLocks = (System.Boolean)value;
						break;
						case 32:
						this.XSchema.FileGroup = (System.String)value;
						break;
						case 33:
						this.XSchema.FileStreamFileGroup = (System.String)value;
						break;
						case 34:
						this.XSchema.FileStreamPartitionScheme = (System.String)value;
						break;
						case 7:
						this.XSchema.FillFactor = (System.Byte)value;
						break;
						case 8:
						this.XRuntime.FilterDefinition = (System.String)value;
						break;
						case 35:
						this.XRuntime.HasCompressedPartitions = (System.Boolean)value;
						break;
						case 9:
						this.XRuntime.HasFilter = (System.Boolean)value;
						break;
						case 10:
						this.XRuntime.HasSparseColumn = (System.Boolean)value;
						break;
						case 11:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 12:
						this.XSchema.IgnoreDuplicateKeys = (System.Boolean)value;
						break;
						case 36:
						this.XSchema.IndexedXmlPathName = (System.String)value;
						break;
						case 13:
						this.XSchema.IndexKeyType = (Microsoft.SqlServer.Management.Smo.IndexKeyType)value;
						break;
						case 14:
						this.XSchema.IndexType = (Microsoft.SqlServer.Management.Smo.IndexType)value;
						break;
						case 15:
						this.XSchema.IsClustered = (System.Boolean)value;
						break;
						case 16:
						this.XRuntime.IsDisabled = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.IsFullTextKey = (System.Boolean)value;
						break;
						case 37:
						this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
						break;
						case 38:
						this.XRuntime.IsOptimizedForSequentialKey = (System.Boolean)value;
						break;
						case 39:
						this.XRuntime.IsPartitioned = (System.Boolean)value;
						break;
						case 18:
						this.XSchema.IsSpatialIndex = (System.Boolean)value;
						break;
						case 19:
						this.XSchema.IsSystemNamed = (System.Boolean)value;
						break;
						case 20:
						this.XRuntime.IsSystemObject = (System.Boolean)value;
						break;
						case 21:
						this.XSchema.IsUnique = (System.Boolean)value;
						break;
						case 22:
						this.XSchema.IsXmlIndex = (System.Boolean)value;
						break;
						case 23:
						this.XSchema.Level1Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
						break;
						case 24:
						this.XSchema.Level2Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
						break;
						case 25:
						this.XSchema.Level3Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
						break;
						case 26:
						this.XSchema.Level4Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
						break;
						case 27:
						this.XRuntime.NoAutomaticRecomputation = (System.Boolean)value;
						break;
						case 28:
						this.XSchema.PadIndex = (System.Boolean)value;
						break;
						case 40:
						this.XRuntime.ParentXmlIndex = (System.String)value;
						break;
						case 41:
						this.XSchema.PartitionScheme = (System.String)value;
						break;
						case 42:
						this.XSchema.ResumableOperationState = (Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)value;
						break;
						case 43:
						this.XSchema.SecondaryXmlIndexType = (Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType)value;
						break;
						case 29:
						this.XSchema.SpatialIndexType = (Microsoft.SqlServer.Management.Smo.SpatialIndexType)value;
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
					case 23:
					this.XSchema.BoundingBoxXMax = (System.Double)value;
					break;
					case 24:
					this.XSchema.BoundingBoxXMin = (System.Double)value;
					break;
					case 25:
					this.XSchema.BoundingBoxYMax = (System.Double)value;
					break;
					case 26:
					this.XSchema.BoundingBoxYMin = (System.Double)value;
					break;
					case 42:
					this.XRuntime.BucketCount = (System.Int32)value;
					break;
					case 27:
					this.XSchema.CellsPerObject = (System.Int32)value;
					break;
					case 44:
					this.XRuntime.CompressionDelay = (System.Int32)value;
					break;
					case 0:
					this.XRuntime.DisallowPageLocks = (System.Boolean)value;
					break;
					case 1:
					this.XRuntime.DisallowRowLocks = (System.Boolean)value;
					break;
					case 2:
					this.XSchema.FileGroup = (System.String)value;
					break;
					case 28:
					this.XSchema.FileStreamFileGroup = (System.String)value;
					break;
					case 29:
					this.XSchema.FileStreamPartitionScheme = (System.String)value;
					break;
					case 3:
					this.XSchema.FillFactor = (System.Byte)value;
					break;
					case 30:
					this.XRuntime.FilterDefinition = (System.String)value;
					break;
					case 31:
					this.XRuntime.HasCompressedPartitions = (System.Boolean)value;
					break;
					case 32:
					this.XRuntime.HasFilter = (System.Boolean)value;
					break;
					case 4:
					this.XRuntime.HasSparseColumn = (System.Boolean)value;
					break;
					case 47:
					this.XRuntime.HasXmlCompressedPartitions = (System.Boolean)value;
					break;
					case 5:
					this.XRuntime.ID = (System.Int32)value;
					break;
					case 6:
					this.XSchema.IgnoreDuplicateKeys = (System.Boolean)value;
					break;
					case 40:
					this.XSchema.IndexedXmlPathName = (System.String)value;
					break;
					case 7:
					this.XSchema.IndexKeyType = (Microsoft.SqlServer.Management.Smo.IndexKeyType)value;
					break;
					case 8:
					this.XSchema.IndexType = (Microsoft.SqlServer.Management.Smo.IndexType)value;
					break;
					case 9:
					this.XSchema.IsClustered = (System.Boolean)value;
					break;
					case 17:
					this.XRuntime.IsDisabled = (System.Boolean)value;
					break;
					case 41:
					this.XRuntime.IsFileTableDefined = (System.Boolean)value;
					break;
					case 10:
					this.XRuntime.IsFullTextKey = (System.Boolean)value;
					break;
					case 43:
					this.XRuntime.IsMemoryOptimized = (System.Boolean)value;
					break;
					case 46:
					this.XRuntime.IsOptimizedForSequentialKey = (System.Boolean)value;
					break;
					case 18:
					this.XRuntime.IsPartitioned = (System.Boolean)value;
					break;
					case 33:
					this.XSchema.IsSpatialIndex = (System.Boolean)value;
					break;
					case 11:
					this.XSchema.IsSystemNamed = (System.Boolean)value;
					break;
					case 12:
					this.XRuntime.IsSystemObject = (System.Boolean)value;
					break;
					case 13:
					this.XSchema.IsUnique = (System.Boolean)value;
					break;
					case 19:
					this.XSchema.IsXmlIndex = (System.Boolean)value;
					break;
					case 34:
					this.XSchema.Level1Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
					break;
					case 35:
					this.XSchema.Level2Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
					break;
					case 36:
					this.XSchema.Level3Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
					break;
					case 37:
					this.XSchema.Level4Grid = (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)value;
					break;
					case 14:
					this.XRuntime.NoAutomaticRecomputation = (System.Boolean)value;
					break;
					case 15:
					this.XSchema.PadIndex = (System.Boolean)value;
					break;
					case 20:
					this.XRuntime.ParentXmlIndex = (System.String)value;
					break;
					case 21:
					this.XSchema.PartitionScheme = (System.String)value;
					break;
					case 38:
					this.XRuntime.PolicyHealthState = (Microsoft.SqlServer.Management.Dmf.PolicyHealthState)value;
					break;
					case 45:
					this.XSchema.ResumableOperationState = (Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)value;
					break;
					case 22:
					this.XSchema.SecondaryXmlIndexType = (Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType)value;
					break;
					case 16:
					this.XRuntime.SpaceUsed = (System.Double)value;
					break;
					case 39:
					this.XSchema.SpatialIndexType = (Microsoft.SqlServer.Management.Smo.SpatialIndexType)value;
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

		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double BoundingBoxXMax
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("BoundingBoxXMax");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BoundingBoxXMax", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double BoundingBoxXMin
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("BoundingBoxXMin");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BoundingBoxXMin", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double BoundingBoxYMax
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("BoundingBoxYMax");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BoundingBoxYMax", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double BoundingBoxYMin
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("BoundingBoxYMin");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BoundingBoxYMin", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 BucketCount
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("BucketCount");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("BucketCount", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 CellsPerObject
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("CellsPerObject");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CellsPerObject", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean DisallowPageLocks
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DisallowPageLocks");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DisallowPageLocks", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean DisallowRowLocks
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DisallowRowLocks");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DisallowRowLocks", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileStreamFileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileStreamFileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileStreamFileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(PartitionScheme),"Server[@Name='{0}']/Database[@Name='{1}']/PartitionScheme[@Name='{2}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","FileStreamPartitionScheme")]
		[CLSCompliant(false)]
		public System.String FileStreamPartitionScheme
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileStreamPartitionScheme");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileStreamPartitionScheme", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte FillFactor
		{
			get
			{
				return (System.Byte)this.Properties.GetValueWithNullReplacement("FillFactor");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FillFactor", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FilterDefinition
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FilterDefinition");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FilterDefinition", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasCompressedPartitions
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasCompressedPartitions");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasFilter
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasFilter");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasSparseColumn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasSparseColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Boolean HasXmlCompressedPartitions
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasXmlCompressedPartitions");
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IgnoreDuplicateKeys
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IgnoreDuplicateKeys");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IgnoreDuplicateKeys", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String IndexedXmlPathName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("IndexedXmlPathName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IndexedXmlPathName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.IndexKeyType IndexKeyType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.IndexKeyType)this.Properties.GetValueWithNullReplacement("IndexKeyType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IndexKeyType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.IndexType IndexType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.IndexType)this.Properties.GetValueWithNullReplacement("IndexType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IndexType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsClustered
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsClustered");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsClustered", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDisabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDisabled");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFullTextKey
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFullTextKey");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsFullTextKey", value);
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsOptimizedForSequentialKey
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsOptimizedForSequentialKey");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsOptimizedForSequentialKey", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsPartitioned
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPartitioned");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSpatialIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSpatialIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsUnique
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsUnique");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsUnique", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsXmlIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsXmlIndex");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level1Grid
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)this.Properties.GetValueWithNullReplacement("Level1Grid");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Level1Grid", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level2Grid
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)this.Properties.GetValueWithNullReplacement("Level2Grid");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Level2Grid", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level3Grid
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)this.Properties.GetValueWithNullReplacement("Level3Grid");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Level3Grid", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize Level4Grid
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SpatialGeoLevelSize)this.Properties.GetValueWithNullReplacement("Level4Grid");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Level4Grid", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean NoAutomaticRecomputation
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NoAutomaticRecomputation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NoAutomaticRecomputation", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean PadIndex
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("PadIndex");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PadIndex", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ParentXmlIndex
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ParentXmlIndex");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ParentXmlIndex", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(PartitionScheme),"Server[@Name='{0}']/Database[@Name='{1}']/PartitionScheme[@Name='{2}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","PartitionScheme")]
		[CLSCompliant(false)]
		public System.String PartitionScheme
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("PartitionScheme");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PartitionScheme", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ResumableOperationStateType ResumableOperationState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ResumableOperationStateType)this.Properties.GetValueWithNullReplacement("ResumableOperationState");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType SecondaryXmlIndexType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SecondaryXmlIndexType)this.Properties.GetValueWithNullReplacement("SecondaryXmlIndexType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SecondaryXmlIndexType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double SpaceUsed
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("SpaceUsed");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SpatialIndexType SpatialIndexType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SpatialIndexType)this.Properties.GetValueWithNullReplacement("SpatialIndexType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SpatialIndexType", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "BoundingBoxXMax", "BoundingBoxXMin", "BoundingBoxYMax", "BoundingBoxYMin", "BucketCount", "CellsPerObject", "FileGroup", "FileStreamFileGroup", "FileStreamPartitionScheme", "FillFactor", "FilterDefinition", "IndexedXmlPathName", "IndexKeyType", "IndexType", "IsClustered", "IsMemoryOptimized", "IsUnique", "Level1Grid", "Level2Grid", "Level3Grid", "Level4Grid", "PadIndex", "ParentXmlIndex", "PartitionScheme", "SecondaryXmlIndexType", "SpatialIndexType" };
		}

      private IndexEvents events;
      public IndexEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new IndexEvents(this);
              }
              return this.events;
          }
      }
    
	}

      public class IndexEvents
      {
      internal IndexEvents(Index parent)
      {
          this.parent = parent;
      }

      public ObjectEventSet GetEventSelection()
      {
          InitializeEvents();
          return (ObjectEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(ObjectEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(ObjectEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(ObjectEventSet events)
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.UnsubscribeFromEvents(events);
          }
      }

      public void UnsubscribeAllEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.Dispose();
              this.serverEventsWorker = null;
          }
      }

      public void StartEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StartEvents();
          }
      }

      public void StopEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StopEvents();
          }
      }

      public event ServerEventHandler ServerEvent
      {
          add
          {
              InitializeEvents();
              this.serverEventsWorker.AddDefaultEventHandler(value);
          }

          remove
          {
              if (null != this.serverEventsWorker)
              {
                  this.serverEventsWorker.RemoveDefaultEventHandler(value);
              }
          }
      }

      private void InitializeEvents()
      {
          if (null == serverEventsWorker)
          {
              serverEventsWorker = new ObjectEventsWorker(parent);

          }
      }

      private ObjectEventsWorker serverEventsWorker;
      private Index parent;
      }
    
}
