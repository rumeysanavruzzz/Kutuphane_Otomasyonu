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
	/// Instance class encapsulating : Server[@Name='']/Database/PartitionFunction/PartitionFunctionParameter
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class PartitionFunctionParameter  : ISfcSupportsDesignMode
	{
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
							case "Collation": return 0;
							case "ID": return 1;
							case "Length": return 2;
							case "NumericPrecision": return 3;
							case "NumericScale": return 4;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "Collation": return 0;
							case "ID": return 1;
							case "Length": return 2;
							case "NumericPrecision": return 3;
							case "NumericScale": return 4;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "Collation": return 0;
						case "ID": return 1;
						case "Length": return 2;
						case "NumericPrecision": return 3;
						case "NumericScale": return 4;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
			static int [] cloudVersionCount = new int [] { 0, 0, 5 };
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
				new StaticMetadata("Collation", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("Collation", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("Collation", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Collation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Collation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Collation", value);
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 Length
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Length");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Length", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumericPrecision
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumericPrecision");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NumericPrecision", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumericScale
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumericScale");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NumericScale", value);
			}
		}
	}
}
