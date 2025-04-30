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
	/// Instance class encapsulating : Server[@Name='']/Database/FileGroup/File
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class DataFile  : ISfcSupportsDesignMode
	{
		public DataFile() : base(){ }
		public DataFile(FileGroup fileGroup, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = fileGroup;
			InitializeDefaults();
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public FileGroup Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as FileGroup;
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
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AvailableSpace": return 0;
						case "FileName": return 1;
						case "Growth": return 2;
						case "GrowthType": return 3;
						case "ID": return 4;
						case "IsPrimaryFile": return 5;
						case "MaxSize": return 6;
						case "Size": return 7;
						case "UsedSpace": return 8;
						case "BytesReadFromDisk": return 9;
						case "BytesWrittenToDisk": return 10;
						case "IsOffline": return 11;
						case "IsReadOnly": return 12;
						case "IsReadOnlyMedia": return 13;
						case "IsSparse": return 14;
						case "NumberOfDiskReads": return 15;
						case "NumberOfDiskWrites": return 16;
						case "PolicyHealthState": return 17;
						case "VolumeFreeSpace": return 18;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 9, 9, 17, 18, 19, 19, 19, 19, 19, 19, 19, 19 };
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
				new StaticMetadata("AvailableSpace", true, true, typeof(System.Double)),
				new StaticMetadata("FileName", false, false, typeof(System.String)),
				new StaticMetadata("Growth", false, false, typeof(System.Double)),
				new StaticMetadata("GrowthType", false, false, typeof(Microsoft.SqlServer.Management.Smo.FileGrowthType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsPrimaryFile", false, false, typeof(System.Boolean)),
				new StaticMetadata("MaxSize", false, false, typeof(System.Double)),
				new StaticMetadata("Size", false, false, typeof(System.Double)),
				new StaticMetadata("UsedSpace", true, true, typeof(System.Double)),
				new StaticMetadata("BytesReadFromDisk", true, true, typeof(System.Int64)),
				new StaticMetadata("BytesWrittenToDisk", true, true, typeof(System.Int64)),
				new StaticMetadata("IsOffline", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsReadOnly", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsReadOnlyMedia", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSparse", false, true, typeof(System.Boolean)),
				new StaticMetadata("NumberOfDiskReads", true, true, typeof(System.Int64)),
				new StaticMetadata("NumberOfDiskWrites", true, true, typeof(System.Int64)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("VolumeFreeSpace", true, true, typeof(System.Int64)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double AvailableSpace
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("AvailableSpace");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 BytesReadFromDisk
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("BytesReadFromDisk");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 BytesWrittenToDisk
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("BytesWrittenToDisk");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.String FileName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Double Growth
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("Growth");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Growth", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.FileGrowthType GrowthType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.FileGrowthType)this.Properties.GetValueWithNullReplacement("GrowthType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("GrowthType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsOffline
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsOffline");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Standalone)]
		public System.Boolean IsPrimaryFile
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPrimaryFile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsPrimaryFile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsReadOnly
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsReadOnly");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsReadOnlyMedia
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsReadOnlyMedia");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSparse
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSparse");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Double MaxSize
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("MaxSize");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaxSize", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 NumberOfDiskReads
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("NumberOfDiskReads");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 NumberOfDiskWrites
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("NumberOfDiskWrites");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Double Size
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("Size");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Size", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Double UsedSpace
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("UsedSpace");
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Standalone)]
		public System.Int64 VolumeFreeSpace
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("VolumeFreeSpace");
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "FileName", "IsPrimaryFile" };
		}
	}
}
