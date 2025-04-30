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
	/// Instance class encapsulating : Server[@Name='']/Database/SecurityPolicy/SecurityPredicate
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class SecurityPredicate 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public SecurityPolicy Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SecurityPolicy;
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
							case "PredicateDefinition": return 0;
							case "PredicateOperation": return 1;
							case "PredicateType": return 2;
							case "SecurityPredicateID": return 3;
							case "TargetObjectID": return 4;
							case "TargetObjectName": return 5;
							case "TargetObjectSchema": return 6;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "PredicateDefinition": return 0;
							case "PredicateOperation": return 1;
							case "PredicateType": return 2;
							case "SecurityPredicateID": return 3;
							case "TargetObjectID": return 4;
							case "TargetObjectName": return 5;
							case "TargetObjectSchema": return 6;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "PredicateDefinition": return 0;
						case "PredicateOperation": return 1;
						case "PredicateType": return 2;
						case "SecurityPredicateID": return 3;
						case "TargetObjectID": return 4;
						case "TargetObjectName": return 5;
						case "TargetObjectSchema": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 7, 7, 7, 7, 7 };
			static int [] cloudVersionCount = new int [] { 0, 0, 7 };
			static int sqlDwPropertyCount = 7;
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
				new StaticMetadata("PredicateDefinition", false, false, typeof(System.String)),
				new StaticMetadata("PredicateOperation", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecurityPredicateOperation)),
				new StaticMetadata("PredicateType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecurityPredicateType)),
				new StaticMetadata("SecurityPredicateID", false, false, typeof(System.Int32)),
				new StaticMetadata("TargetObjectID", false, false, typeof(System.Int32)),
				new StaticMetadata("TargetObjectName", false, false, typeof(System.String)),
				new StaticMetadata("TargetObjectSchema", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("PredicateDefinition", false, false, typeof(System.String)),
				new StaticMetadata("PredicateOperation", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecurityPredicateOperation)),
				new StaticMetadata("PredicateType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecurityPredicateType)),
				new StaticMetadata("SecurityPredicateID", false, false, typeof(System.Int32)),
				new StaticMetadata("TargetObjectID", false, false, typeof(System.Int32)),
				new StaticMetadata("TargetObjectName", false, false, typeof(System.String)),
				new StaticMetadata("TargetObjectSchema", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("PredicateDefinition", false, false, typeof(System.String)),
				new StaticMetadata("PredicateOperation", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecurityPredicateOperation)),
				new StaticMetadata("PredicateType", false, false, typeof(Microsoft.SqlServer.Management.Smo.SecurityPredicateType)),
				new StaticMetadata("SecurityPredicateID", false, false, typeof(System.Int32)),
				new StaticMetadata("TargetObjectID", false, false, typeof(System.Int32)),
				new StaticMetadata("TargetObjectName", false, false, typeof(System.String)),
				new StaticMetadata("TargetObjectSchema", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SecurityPredicateOperation PredicateOperation
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SecurityPredicateOperation)this.Properties.GetValueWithNullReplacement("PredicateOperation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PredicateOperation", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SecurityPredicateType PredicateType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SecurityPredicateType)this.Properties.GetValueWithNullReplacement("PredicateType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("PredicateType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 SecurityPredicateID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("SecurityPredicateID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SecurityPredicateID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 TargetObjectID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("TargetObjectID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TargetObjectID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String TargetObjectName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("TargetObjectName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TargetObjectName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String TargetObjectSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("TargetObjectSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TargetObjectSchema", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "PredicateOperation", "PredicateType", "SecurityPredicateID", "TargetObjectID", "TargetObjectName", "TargetObjectSchema" };
		}
	}
}
