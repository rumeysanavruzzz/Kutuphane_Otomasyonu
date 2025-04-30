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
	/// Instance class encapsulating : Server[@Name='']/Database/UserDefinedFunction
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class UserDefinedFunction  : ISfcSupportsDesignMode, IObjectPermission, IColumnPermission
	{
		public UserDefinedFunction() : base(){ }
		public UserDefinedFunction(Database database, string name) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, null);
			this.Parent = database;
		}
		public UserDefinedFunction(Database database, string name, string schema) : base()
		{
			ValidateName(name);
			this.key = new SchemaObjectKey(name, schema);
			this.Parent = database;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
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
		/// This object supports permissions.
		/// </summary>
		internal override UserPermissionCollection Permissions
		{
			get
			{
				// call the base class 
				return GetUserPermissions();
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
							case "AnsiNullsStatus": return 0;
							case "AssemblyName": return 1;
							case "BodyStartIndex": return 2;
							case "ClassName": return 3;
							case "CreateDate": return 4;
							case "DataType": return 5;
							case "DataTypeSchema": return 6;
							case "DateLastModified": return 7;
							case "ExecutionContext": return 8;
							case "ExecutionContextPrincipal": return 9;
							case "FunctionType": return 10;
							case "ID": return 11;
							case "ImplementationType": return 12;
							case "InlineType": return 13;
							case "IsDeterministic": return 14;
							case "IsEncrypted": return 15;
							case "IsInlineable": return 16;
							case "IsNativelyCompiled": return 17;
							case "IsSchemaBound": return 18;
							case "IsSchemaOwned": return 19;
							case "IsSystemObject": return 20;
							case "Length": return 21;
							case "MethodName": return 22;
							case "NumericPrecision": return 23;
							case "NumericScale": return 24;
							case "Owner": return 25;
							case "QuotedIdentifierStatus": return 26;
							case "ReturnsNullOnNullInput": return 27;
							case "SystemType": return 28;
							case "TableVariableName": return 29;
							case "Text": return 30;
							case "UserType": return 31;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiNullsStatus": return 0;
							case "AssemblyName": return 1;
							case "BodyStartIndex": return 2;
							case "ClassName": return 3;
							case "CreateDate": return 4;
							case "DataType": return 5;
							case "DataTypeSchema": return 6;
							case "DateLastModified": return 7;
							case "ExecutionContext": return 8;
							case "ExecutionContextPrincipal": return 9;
							case "FunctionType": return 10;
							case "ID": return 11;
							case "ImplementationType": return 12;
							case "InlineType": return 13;
							case "IsDeterministic": return 14;
							case "IsEncrypted": return 15;
							case "IsInlineable": return 16;
							case "IsNativelyCompiled": return 17;
							case "IsSchemaBound": return 18;
							case "IsSchemaOwned": return 19;
							case "IsSystemObject": return 20;
							case "Length": return 21;
							case "MethodName": return 22;
							case "NumericPrecision": return 23;
							case "NumericScale": return 24;
							case "Owner": return 25;
							case "QuotedIdentifierStatus": return 26;
							case "ReturnsNullOnNullInput": return 27;
							case "SystemType": return 28;
							case "TableVariableName": return 29;
							case "Text": return 30;
							case "UserType": return 31;
							case "XmlDocumentConstraint": return 32;
							case "XmlSchemaNamespace": return 33;
							case "XmlSchemaNamespaceSchema": return 34;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AnsiNullsStatus": return 0;
						case "BodyStartIndex": return 1;
						case "CreateDate": return 2;
						case "DataType": return 3;
						case "DataTypeSchema": return 4;
						case "FunctionType": return 5;
						case "ID": return 6;
						case "ImplementationType": return 7;
						case "IsDeterministic": return 8;
						case "IsEncrypted": return 9;
						case "IsInlineable": return 10;
						case "IsSchemaBound": return 11;
						case "IsSystemObject": return 12;
						case "Length": return 13;
						case "NumericPrecision": return 14;
						case "NumericScale": return 15;
						case "Owner": return 16;
						case "QuotedIdentifierStatus": return 17;
						case "SystemType": return 18;
						case "TableVariableName": return 19;
						case "Text": return 20;
						case "AssemblyName": return 21;
						case "ClassName": return 22;
						case "DateLastModified": return 23;
						case "ExecutionContext": return 24;
						case "ExecutionContextPrincipal": return 25;
						case "IsSchemaOwned": return 26;
						case "MethodName": return 27;
						case "ReturnsNullOnNullInput": return 28;
						case "XmlDocumentConstraint": return 29;
						case "XmlSchemaNamespace": return 30;
						case "XmlSchemaNamespaceSchema": return 31;
						case "PolicyHealthState": return 32;
						case "UserType": return 33;
						case "IsNativelyCompiled": return 34;
						case "InlineType": return 35;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 21, 32, 34, 34, 34, 34, 35, 35, 36, 36, 36 };
			static int [] cloudVersionCount = new int [] { 0, 0, 35 };
			static int sqlDwPropertyCount = 32;
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
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("FunctionType", false, false, typeof(Microsoft.SqlServer.Management.Smo.UserDefinedFunctionType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("InlineType", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDeterministic", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsInlineable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReturnsNullOnNullInput", false, false, typeof(System.Boolean)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("TableVariableName", false, false, typeof(System.String)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("FunctionType", false, false, typeof(Microsoft.SqlServer.Management.Smo.UserDefinedFunctionType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("InlineType", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDeterministic", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsInlineable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("ReturnsNullOnNullInput", false, false, typeof(System.Boolean)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("TableVariableName", false, false, typeof(System.String)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("FunctionType", false, false, typeof(Microsoft.SqlServer.Management.Smo.UserDefinedFunctionType)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("IsDeterministic", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsInlineable", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("Owner", false, false, typeof(System.String)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("TableVariableName", false, false, typeof(System.String)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("IsSchemaOwned", false, true, typeof(System.Boolean)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("ReturnsNullOnNullInput", false, false, typeof(System.Boolean)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
				new StaticMetadata("InlineType", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AnsiNullsStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullsStatus");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullsStatus", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(SqlAssembly),"Server[@Name = '{0}']/Database[@Name = '{1}']/SqlAssembly[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","AssemblyName")]
		[CLSCompliant(false)]
		public System.String AssemblyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AssemblyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AssemblyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ClassName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ClassName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ClassName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
			}
		}
		[DmfIgnoreProperty]
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExecutionContext ExecutionContext
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExecutionContext)this.Properties.GetValueWithNullReplacement("ExecutionContext");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContext", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","ExecutionContextPrincipal")]
		[CLSCompliant(false)]
		public System.String ExecutionContextPrincipal
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ExecutionContextPrincipal");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContextPrincipal", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.UserDefinedFunctionType FunctionType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.UserDefinedFunctionType)this.Properties.GetValueWithNullReplacement("FunctionType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FunctionType", value);
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "TransactSql")]
		public Microsoft.SqlServer.Management.Smo.ImplementationType ImplementationType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ImplementationType)this.Properties.GetValueWithNullReplacement("ImplementationType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ImplementationType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean InlineType
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("InlineType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("InlineType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDeterministic
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDeterministic");
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsEncrypted
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEncrypted");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsEncrypted", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsInlineable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsInlineable");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsNativelyCompiled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsNativelyCompiled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsNativelyCompiled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSchemaBound
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSchemaBound");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSchemaBound", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSchemaOwned
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSchemaOwned");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String MethodName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MethodName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MethodName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
		[SfcReference(typeof(DatabaseRole),"Server[@Name = '{0}']/Database[@Name = '{1}']/Role[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
		[SfcReference(typeof(ApplicationRole),"Server[@Name = '{0}']/Database[@Name = '{1}']/ApplicationRole[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","Owner")]
		[CLSCompliant(false)]
		public System.String Owner
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Owner");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Owner", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean QuotedIdentifierStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("QuotedIdentifierStatus");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QuotedIdentifierStatus", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean ReturnsNullOnNullInput
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ReturnsNullOnNullInput");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ReturnsNullOnNullInput", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String TableVariableName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("TableVariableName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("TableVariableName", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "InlineType", "IsNativelyCompiled" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "ImplementationType":
					return ImplementationType.TransactSql;
				case "IsEncrypted":
					return false;
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}

		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, null, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, null, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, null, revokeGrant, cascade, asRole);
		}
		

		public void Deny(ObjectPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String granteeName, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, null, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, null, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, null, revokeGrant, cascade, asRole);
		}
		

		public ObjectPermissionInfo[] EnumObjectPermissions()
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, null, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, granteeName, null);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, null, permissions);
		}
		
		public ObjectPermissionInfo[] EnumObjectPermissions(System.String granteeName, ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Object, this, granteeName, permissions);
		}
		

		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, columnNames, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, granteeNames, columnNames, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, columnNames, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, columnNames, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, granteeNames, columnNames, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, columnNames, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, columnNames, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String[] granteeNames, System.String[] columnNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, granteeNames, columnNames, revokeGrant, cascade, asRole);
		}
		

		public void Deny(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, columnNames, false, false, null);
		}
		
		public void Deny(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Deny, this, permission, new String [] { granteeName }, columnNames, false, cascade, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, columnNames, false, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool grantGrant)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, columnNames, grantGrant, false, null);
		}
		
		public void Grant(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool grantGrant, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Grant, this, permission, new String [] { granteeName }, columnNames, grantGrant, false, asRole);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, columnNames, false, false, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool revokeGrant, bool cascade)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, columnNames, revokeGrant, cascade, null);
		}
		
		public void Revoke(ObjectPermissionSet permission, System.String granteeName, System.String[] columnNames, bool revokeGrant, bool cascade, System.String asRole)
		{
			PermissionWorker.Execute(PermissionState.Revoke, this, permission, new String [] { granteeName }, columnNames, revokeGrant, cascade, asRole);
		}
		

		public ObjectPermissionInfo[] EnumColumnPermissions()
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, null, null);
		}
		
		public ObjectPermissionInfo[] EnumColumnPermissions(System.String granteeName)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, granteeName, null);
		}
		
		public ObjectPermissionInfo[] EnumColumnPermissions(ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, null, permissions);
		}
		
		public ObjectPermissionInfo[] EnumColumnPermissions(System.String granteeName, ObjectPermissionSet permissions)
		{
			return (ObjectPermissionInfo [])PermissionWorker.EnumPermissions(PermissionWorker.PermissionEnumKind.Column, this, granteeName, permissions);
		}
		

      private UserDefinedFunctionEvents events;
      public UserDefinedFunctionEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new UserDefinedFunctionEvents(this);
              }
              return this.events;
          }
      }
    
	}







      public class UserDefinedFunctionEvents
      {
      internal UserDefinedFunctionEvents(UserDefinedFunction parent)
      {
          this.parent = parent;
      }

      public UserDefinedFunctionEventSet GetEventSelection()
      {
          InitializeEvents();
          return (UserDefinedFunctionEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(UserDefinedFunctionEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(UserDefinedFunctionEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(UserDefinedFunctionEventSet events)
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.UnsubscribeFromEvents(events);
          }
      }

      public void UnsubscribeAllEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.Dispose();
              this.serverEventsWorker = null;
          }
      }

      public void StartEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StartEvents();
          }
      }

      public void StopEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StopEvents();
          }
      }

      public event ServerEventHandler ServerEvent
      {
          add
          {
              InitializeEvents();
              this.serverEventsWorker.AddDefaultEventHandler(value);
          }

          remove
          {
              if (null != this.serverEventsWorker)
              {
                  this.serverEventsWorker.RemoveDefaultEventHandler(value);
              }
          }
      }

      private void InitializeEvents()
      {
          if (null == serverEventsWorker)
          {
              serverEventsWorker = new UserDefinedFunctionEventsWorker(parent);

          }
      }

      private UserDefinedFunctionEventsWorker serverEventsWorker;
      private UserDefinedFunction parent;
      }
    
}
