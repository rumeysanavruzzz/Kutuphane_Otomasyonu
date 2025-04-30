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
	/// Instance class encapsulating : Server[@Name='']/SystemDataType
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class SystemDataType  : ISfcSupportsDesignMode
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public Server Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Server;
			}
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
							case "AllowIdentity": return 0;
							case "AllowLength": return 1;
							case "AllowNulls": return 2;
							case "Collation": return 3;
							case "ID": return 4;
							case "MaximumLength": return 5;
							case "Numeric": return 6;
							case "NumericPrecision": return 7;
							case "NumericScale": return 8;
							case "VariableLength": return 9;
							case "VariableMaxLength": return 10;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AllowIdentity": return 0;
							case "AllowLength": return 1;
							case "AllowNulls": return 2;
							case "Collation": return 3;
							case "ID": return 4;
							case "MaximumLength": return 5;
							case "Numeric": return 6;
							case "NumericPrecision": return 7;
							case "NumericScale": return 8;
							case "VariableLength": return 9;
							case "VariableMaxLength": return 10;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AllowIdentity": return 0;
						case "AllowLength": return 1;
						case "AllowNulls": return 2;
						case "MaximumLength": return 3;
						case "Numeric": return 4;
						case "NumericPrecision": return 5;
						case "NumericScale": return 6;
						case "VariableLength": return 7;
						case "VariableMaxLength": return 8;
						case "Collation": return 9;
						case "ID": return 10;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 9, 10, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11 };
			static int [] cloudVersionCount = new int [] { 11, 11, 11 };
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
				new StaticMetadata("AllowIdentity", false, true, typeof(System.Boolean)),
				new StaticMetadata("AllowLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("AllowNulls", false, true, typeof(System.Boolean)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("MaximumLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Numeric", false, true, typeof(System.Boolean)),
				new StaticMetadata("NumericPrecision", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, true, typeof(System.Int32)),
				new StaticMetadata("VariableLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("VariableMaxLength", false, true, typeof(System.Int32)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AllowIdentity", false, true, typeof(System.Boolean)),
				new StaticMetadata("AllowLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("AllowNulls", false, true, typeof(System.Boolean)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("MaximumLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Numeric", false, true, typeof(System.Boolean)),
				new StaticMetadata("NumericPrecision", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, true, typeof(System.Int32)),
				new StaticMetadata("VariableLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("VariableMaxLength", false, true, typeof(System.Int32)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AllowIdentity", false, true, typeof(System.Boolean)),
				new StaticMetadata("AllowLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("AllowNulls", false, true, typeof(System.Boolean)),
				new StaticMetadata("MaximumLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Numeric", false, true, typeof(System.Boolean)),
				new StaticMetadata("NumericPrecision", false, true, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, true, typeof(System.Int32)),
				new StaticMetadata("VariableLength", false, true, typeof(System.Boolean)),
				new StaticMetadata("VariableMaxLength", false, true, typeof(System.Int32)),
				new StaticMetadata("Collation", false, true, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AllowIdentity
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AllowIdentity");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AllowLength
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AllowLength");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AllowNulls
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AllowNulls");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Collation
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Collation");
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
		public System.Int32 MaximumLength
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MaximumLength");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumericPrecision
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumericPrecision");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 NumericScale
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("NumericScale");
			}
		}
	}
}
