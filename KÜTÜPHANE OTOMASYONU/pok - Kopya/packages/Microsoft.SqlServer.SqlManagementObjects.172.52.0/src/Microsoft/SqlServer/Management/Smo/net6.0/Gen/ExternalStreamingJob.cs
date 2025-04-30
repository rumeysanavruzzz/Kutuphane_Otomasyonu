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
	/// Instance class encapsulating : Server[@Name='']/Database/ExternalStreamingJob
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class ExternalStreamingJob 
	{
		public ExternalStreamingJob() : base(){ }
		public ExternalStreamingJob(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = database;
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
						case "CreateDate": return 0;
						case "ID": return 1;
						case "IsPublished": return 2;
						case "IsSchemaPublished": return 3;
						case "IsSystemObject": return 4;
						case "Statement": return 5;
						case "Status": return 6;
						case "Type": return 7;
						case "TypeDesc": return 8;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 9, 9 };
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
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsPublished", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaPublished", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Statement", false, false, typeof(System.String)),
				new StaticMetadata("Status", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalStreamingJobStatusType)),
				new StaticMetadata("Type", false, true, typeof(System.String)),
				new StaticMetadata("TypeDesc", false, true, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
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
		public System.Boolean IsPublished
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPublished");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSchemaPublished
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSchemaPublished");
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
		public System.String Statement
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Statement");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Statement", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalStreamingJobStatusType Status
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalStreamingJobStatusType)this.Properties.GetValueWithNullReplacement("Status");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Status", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Type
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Type");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String TypeDesc
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("TypeDesc");
			}
		}
	}
}
