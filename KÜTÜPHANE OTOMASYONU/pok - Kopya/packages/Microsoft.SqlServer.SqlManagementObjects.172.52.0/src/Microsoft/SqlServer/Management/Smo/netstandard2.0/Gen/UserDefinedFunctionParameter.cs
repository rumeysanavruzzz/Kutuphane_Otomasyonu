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
	/// Instance class encapsulating : Server[@Name='']/Database/UserDefinedFunction/Param
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class UserDefinedFunctionParameter  : ISfcSupportsDesignMode
	{
		public UserDefinedFunctionParameter() : base(){ }
		public UserDefinedFunctionParameter(UserDefinedFunction userDefinedFunction, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = userDefinedFunction;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		public UserDefinedFunction Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as UserDefinedFunction;
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
						switch(propertyName)
						{
							case "DataType": return 0;
							case "DataTypeSchema": return 1;
							case "DefaultValue": return 2;
							case "HasDefaultValue": return 3;
							case "ID": return 4;
							case "IsReadOnly": return 5;
							case "Length": return 6;
							case "NumericPrecision": return 7;
							case "NumericScale": return 8;
							case "SystemType": return 9;
							case "UserType": return 10;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "DataType": return 0;
							case "DataTypeSchema": return 1;
							case "DefaultValue": return 2;
							case "HasDefaultValue": return 3;
							case "ID": return 4;
							case "IsReadOnly": return 5;
							case "Length": return 6;
							case "NumericPrecision": return 7;
							case "NumericScale": return 8;
							case "SystemType": return 9;
							case "UserType": return 10;
							case "XmlDocumentConstraint": return 11;
							case "XmlSchemaNamespace": return 12;
							case "XmlSchemaNamespaceSchema": return 13;
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
						case "DefaultValue": return 2;
						case "ID": return 3;
						case "Length": return 4;
						case "NumericPrecision": return 5;
						case "NumericScale": return 6;
						case "SystemType": return 7;
						case "HasDefaultValue": return 8;
						case "XmlDocumentConstraint": return 9;
						case "XmlSchemaNamespace": return 10;
						case "XmlSchemaNamespaceSchema": return 11;
						case "IsReadOnly": return 12;
						case "UserType": return 13;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 8, 8, 12, 14, 14, 14, 14, 14, 14, 14, 14, 14 };
			static int [] cloudVersionCount = new int [] { 14, 14, 14 };
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
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DefaultValue", false, false, typeof(System.String)),
				new StaticMetadata("HasDefaultValue", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DefaultValue", false, false, typeof(System.String)),
				new StaticMetadata("HasDefaultValue", false, false, typeof(System.Boolean)),
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
				new StaticMetadata("DefaultValue", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("HasDefaultValue", false, false, typeof(System.Boolean)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
				new StaticMetadata("IsReadOnly", false, false, typeof(System.Boolean)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
		}

		public UserDefinedFunctionParameter(UserDefinedFunction userDefinedFunction, System.String name, DataType dataType)
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = userDefinedFunction;
			this.DataType = dataType;
		}
		
	}

}
