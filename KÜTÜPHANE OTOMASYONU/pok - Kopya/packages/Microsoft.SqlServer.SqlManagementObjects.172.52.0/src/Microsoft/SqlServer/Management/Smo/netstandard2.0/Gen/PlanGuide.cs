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
	/// Instance class encapsulating : Server[@Name='']/Database/PlanGuide
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class PlanGuide 
	{
		public PlanGuide() : base(){ }
		public PlanGuide(Database database, string name) : base()
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
						switch(propertyName)
						{
							case "Hints": return 0;
							case "ID": return 1;
							case "IsDisabled": return 2;
							case "Parameters": return 3;
							case "ScopeBatch": return 4;
							case "ScopeObjectName": return 5;
							case "ScopeSchemaName": return 6;
							case "ScopeType": return 7;
							case "Statement": return 8;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "Hints": return 0;
						case "ID": return 1;
						case "IsDisabled": return 2;
						case "Parameters": return 3;
						case "ScopeBatch": return 4;
						case "ScopeObjectName": return 5;
						case "ScopeSchemaName": return 6;
						case "ScopeType": return 7;
						case "Statement": return 8;
						case "PolicyHealthState": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
			static int [] cloudVersionCount = new int [] { 0, 0, 9 };
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
				new StaticMetadata("Hints", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDisabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Parameters", false, false, typeof(System.String)),
				new StaticMetadata("ScopeBatch", false, false, typeof(System.String)),
				new StaticMetadata("ScopeObjectName", false, false, typeof(System.String)),
				new StaticMetadata("ScopeSchemaName", false, false, typeof(System.String)),
				new StaticMetadata("ScopeType", false, false, typeof(Microsoft.SqlServer.Management.Smo.PlanGuideType)),
				new StaticMetadata("Statement", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("Hints", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsDisabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("Parameters", false, false, typeof(System.String)),
				new StaticMetadata("ScopeBatch", false, false, typeof(System.String)),
				new StaticMetadata("ScopeObjectName", false, false, typeof(System.String)),
				new StaticMetadata("ScopeSchemaName", false, false, typeof(System.String)),
				new StaticMetadata("ScopeType", false, false, typeof(Microsoft.SqlServer.Management.Smo.PlanGuideType)),
				new StaticMetadata("Statement", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
			};
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Hints
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Hints");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Hints", value);
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
		public System.Boolean IsDisabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDisabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsDisabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Parameters
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Parameters");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Parameters", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ScopeBatch
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ScopeBatch");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ScopeBatch", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ScopeObjectName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ScopeObjectName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ScopeObjectName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ScopeSchemaName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ScopeSchemaName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ScopeSchemaName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.PlanGuideType ScopeType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.PlanGuideType)this.Properties.GetValueWithNullReplacement("ScopeType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ScopeType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "Hints", "Parameters", "ScopeBatch", "ScopeObjectName", "ScopeSchemaName", "ScopeType", "Statement" };
		}
	}
}
