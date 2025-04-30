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
	/// Instance class encapsulating : Server[@Name='']/Database/FileGroup
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class FileGroup  : ISfcSupportsDesignMode
	{
		public FileGroup() : base(){ }
		public FileGroup(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = database;
			InitializeDefaults();
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "FileGroupType": return 0;
							case "ID": return 1;
							case "IsDefault": return 2;
							case "IsFileStream": return 3;
							case "ReadOnly": return 4;
							case "Size": return 5;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "ID": return 0;
						case "IsDefault": return 1;
						case "ReadOnly": return 2;
						case "Size": return 3;
						case "FileGroupType": return 4;
						case "IsFileStream": return 5;
						case "PolicyHealthState": return 6;
						case "AutogrowAllFiles": return 7;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 4, 4, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8 };
			static int [] cloudVersionCount = new int [] { 0, 0, 6 };
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
				new StaticMetadata("FileGroupType", false, false, typeof(Microsoft.SqlServer.Management.Smo.FileGroupType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsFileStream", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("Size", false, false, typeof(System.Double)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDefault", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("Size", false, true, typeof(System.Double)),
				new StaticMetadata("FileGroupType", false, false, typeof(Microsoft.SqlServer.Management.Smo.FileGroupType)),
				new StaticMetadata("IsFileStream", false, false, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("AutogrowAllFiles", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AutogrowAllFiles
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AutogrowAllFiles");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AutogrowAllFiles", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.FileGroupType FileGroupType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.FileGroupType)this.Properties.GetValueWithNullReplacement("FileGroupType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileGroupType", value);
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
		public System.Boolean IsDefault
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDefault");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsDefault", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFileStream
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFileStream");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsFileStream", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ReadOnly
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ReadOnly");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReadOnly", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Double Size
		{
			get
			{
				return (System.Double)this.Properties.GetValueWithNullReplacement("Size");
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "FileGroupType", "IsFileStream" };
		}
	}
}
