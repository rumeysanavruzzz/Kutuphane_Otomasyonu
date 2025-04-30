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
	/// Instance class encapsulating : Server[@Name='']/Database/UserDefinedAggregate/Param
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class UserDefinedAggregateParameter  : ISfcSupportsDesignMode
	{
		public UserDefinedAggregateParameter() : base(){ }
		public UserDefinedAggregateParameter(UserDefinedAggregate userDefinedAggregate, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = userDefinedAggregate;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public UserDefinedAggregate Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as UserDefinedAggregate;
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
							case "DataType": return 0;
							case "DataTypeSchema": return 1;
							case "ID": return 2;
							case "IsReadOnly": return 3;
							case "Length": return 4;
							case "NumericPrecision": return 5;
							case "NumericScale": return 6;
							case "SystemType": return 7;
							case "UserType": return 8;
							case "XmlDocumentConstraint": return 9;
							case "XmlSchemaNamespace": return 10;
							case "XmlSchemaNamespaceSchema": return 11;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "DataType": return 0;
						case "DataTypeSchema": return 1;
						case "ID": return 2;
						case "Length": return 3;
						case "NumericPrecision": return 4;
						case "NumericScale": return 5;
						case "SystemType": return 6;
						case "XmlDocumentConstraint": return 7;
						case "XmlSchemaNamespace": return 8;
						case "XmlSchemaNamespaceSchema": return 9;
						case "IsReadOnly": return 10;
						case "UserType": return 11;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 10, 12, 12, 12, 12, 12, 12, 12, 12, 12 };
			static int [] cloudVersionCount = new int [] { 0, 0, 12 };
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
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
	}
}
