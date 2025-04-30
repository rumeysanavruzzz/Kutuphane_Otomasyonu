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
	/// Instance class encapsulating : Server[@Name='']/Endpoint/Soap
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class SoapPayload 
	{
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
						case "DefaultDatabase": return 0;
						case "DefaultNamespace": return 1;
						case "IsSessionEnabled": return 2;
						case "IsSqlBatchesEnabled": return 3;
						case "IsSystemObject": return 4;
						case "SessionNeverTimesOut": return 5;
						case "SessionTimeout": return 6;
						case "WsdlGeneratorOption": return 7;
						case "WsdlGeneratorProcedure": return 8;
						case "XmlFormatOption": return 9;
						case "XsdSchemaOption": return 10;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11 };
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
				new StaticMetadata("DefaultDatabase", false, false, typeof(System.String)),
				new StaticMetadata("DefaultNamespace", false, false, typeof(System.String)),
				new StaticMetadata("IsSessionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSqlBatchesEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("SessionNeverTimesOut", false, false, typeof(System.Boolean)),
				new StaticMetadata("SessionTimeout", false, false, typeof(System.Int32)),
				new StaticMetadata("WsdlGeneratorOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.WsdlGeneratorOption)),
				new StaticMetadata("WsdlGeneratorProcedure", false, false, typeof(System.String)),
				new StaticMetadata("XmlFormatOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlFormatOption)),
				new StaticMetadata("XsdSchemaOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.XsdSchemaOption)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultDatabase
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultDatabase");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultDatabase", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultNamespace
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultNamespace");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultNamespace", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSessionEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSessionEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSessionEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSqlBatchesEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSqlBatchesEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSqlBatchesEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SessionNeverTimesOut
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SessionNeverTimesOut");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SessionNeverTimesOut", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 SessionTimeout
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("SessionTimeout");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SessionTimeout", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.WsdlGeneratorOption WsdlGeneratorOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.WsdlGeneratorOption)this.Properties.GetValueWithNullReplacement("WsdlGeneratorOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WsdlGeneratorOption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String WsdlGeneratorProcedure
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WsdlGeneratorProcedure");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WsdlGeneratorProcedure", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.XmlFormatOption XmlFormatOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.XmlFormatOption)this.Properties.GetValueWithNullReplacement("XmlFormatOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("XmlFormatOption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.XsdSchemaOption XsdSchemaOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.XsdSchemaOption)this.Properties.GetValueWithNullReplacement("XsdSchemaOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("XsdSchemaOption", value);
			}
		}
	}
}
