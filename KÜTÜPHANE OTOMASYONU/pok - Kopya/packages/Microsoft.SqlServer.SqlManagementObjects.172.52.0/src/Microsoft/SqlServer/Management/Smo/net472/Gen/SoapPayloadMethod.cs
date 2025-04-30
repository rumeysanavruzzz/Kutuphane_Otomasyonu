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
	/// Instance class encapsulating : Server[@Name='']/Endpoint/Soap/Method
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class SoapPayloadMethod 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public SoapPayload Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SoapPayload;
			}
			set{SetParentImpl(value);}
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
						case "IsSystemObject": return 0;
						case "MethodLoginType": return 1;
						case "MethodXsdSchemaOption": return 2;
						case "Namespace": return 3;
						case "ResultFormat": return 4;
						case "SqlMethod": return 5;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
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
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MethodLoginType", false, false, typeof(Microsoft.SqlServer.Management.Smo.MethodLoginType)),
				new StaticMetadata("MethodXsdSchemaOption", false, false, typeof(Microsoft.SqlServer.Management.Smo.MethodXsdSchemaOption)),
				new StaticMetadata("Namespace", false, false, typeof(System.String)),
				new StaticMetadata("ResultFormat", false, false, typeof(Microsoft.SqlServer.Management.Smo.ResultFormat)),
				new StaticMetadata("SqlMethod", false, true, typeof(System.String)),
			};
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
		public Microsoft.SqlServer.Management.Smo.MethodLoginType MethodLoginType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.MethodLoginType)this.Properties.GetValueWithNullReplacement("MethodLoginType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MethodLoginType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.MethodXsdSchemaOption MethodXsdSchemaOption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.MethodXsdSchemaOption)this.Properties.GetValueWithNullReplacement("MethodXsdSchemaOption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MethodXsdSchemaOption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ResultFormat ResultFormat
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ResultFormat)this.Properties.GetValueWithNullReplacement("ResultFormat");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ResultFormat", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String SqlMethod
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SqlMethod");
			}
		}
	}
}
