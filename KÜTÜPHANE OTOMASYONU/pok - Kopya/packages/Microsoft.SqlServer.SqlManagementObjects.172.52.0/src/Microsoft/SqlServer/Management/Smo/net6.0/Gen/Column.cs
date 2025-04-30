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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Column
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Column  : ISfcSupportsDesignMode, IPropertyDataDispatch
	{
		public Column() : base(){ }
		public Column(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
		[SfcParent("Table")]
		[SfcParent("Statistic")]
		[SfcParent("ForeignKey")]
		[SfcParent("UserDefinedTableType")]
		[SfcParent("UserDefinedFunction")]
		[SfcParent("View")]
		[SfcParent("Rule")]
		[SfcParent("Default")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
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
							case "AnsiPaddingStatus": return 0;
							case "Collation": return 1;
							case "Computed": return 2;
							case "ComputedText": return 3;
							case "DataType": return 4;
							case "DataTypeSchema": return 5;
							case "Default": return 6;
							case "DefaultConstraintName": return 7;
							case "DefaultSchema": return 8;
							case "DistributionColumnName": return 9;
							case "ID": return 10;
							case "Identity": return 11;
							case "IdentityIncrement": return 12;
							case "IdentityIncrementAsDecimal": return 13;
							case "IdentitySeed": return 14;
							case "IdentitySeedAsDecimal": return 15;
							case "InPrimaryKey": return 16;
							case "IsClassified": return 17;
							case "IsColumnSet": return 18;
							case "IsDistributedColumn": return 19;
							case "IsDroppedLedgerColumn": return 20;
							case "IsFileStream": return 21;
							case "IsForeignKey": return 22;
							case "IsMasked": return 23;
							case "IsPersisted": return 24;
							case "IsSparse": return 25;
							case "Length": return 26;
							case "MaskingFunction": return 27;
							case "NotForReplication": return 28;
							case "Nullable": return 29;
							case "NumericPrecision": return 30;
							case "NumericScale": return 31;
							case "RowGuidCol": return 32;
							case "Rule": return 33;
							case "RuleSchema": return 34;
							case "SensitivityInformationTypeId": return 35;
							case "SensitivityInformationTypeName": return 36;
							case "SensitivityLabelId": return 37;
							case "SensitivityLabelName": return 38;
							case "SensitivityRank": return 39;
							case "SystemType": return 40;
							case "UserType": return 41;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiPaddingStatus": return 0;
							case "Collation": return 1;
							case "Computed": return 2;
							case "ComputedText": return 3;
							case "DataType": return 4;
							case "DataTypeSchema": return 5;
							case "Default": return 6;
							case "DefaultConstraintName": return 7;
							case "DefaultSchema": return 8;
							case "ID": return 9;
							case "Identity": return 10;
							case "IdentityIncrement": return 11;
							case "IdentityIncrementAsDecimal": return 12;
							case "IdentitySeed": return 13;
							case "IdentitySeedAsDecimal": return 14;
							case "InPrimaryKey": return 15;
							case "IsColumnSet": return 16;
							case "IsDeterministic": return 17;
							case "IsFileStream": return 18;
							case "IsForeignKey": return 19;
							case "IsFullTextIndexed": return 20;
							case "IsPersisted": return 21;
							case "IsPrecise": return 22;
							case "IsSparse": return 23;
							case "Length": return 24;
							case "NotForReplication": return 25;
							case "Nullable": return 26;
							case "NumericPrecision": return 27;
							case "NumericScale": return 28;
							case "RowGuidCol": return 29;
							case "Rule": return 30;
							case "RuleSchema": return 31;
							case "SystemType": return 32;
							case "UserType": return 33;
							case "XmlDocumentConstraint": return 34;
							case "XmlSchemaNamespace": return 35;
							case "XmlSchemaNamespaceSchema": return 36;
							case "ColumnEncryptionKeyID": return 37;
							case "ColumnEncryptionKeyName": return 38;
							case "EncryptionAlgorithm": return 39;
							case "EncryptionType": return 40;
							case "GeneratedAlwaysType": return 41;
							case "GraphType": return 42;
							case "IsClassified": return 43;
							case "IsDroppedLedgerColumn": return 44;
							case "IsHidden": return 45;
							case "IsMasked": return 46;
							case "MaskingFunction": return 47;
							case "SensitivityInformationTypeId": return 48;
							case "SensitivityInformationTypeName": return 49;
							case "SensitivityLabelId": return 50;
							case "SensitivityLabelName": return 51;
							case "SensitivityRank": return 52;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AnsiPaddingStatus": return 0;
						case "Computed": return 1;
						case "ComputedText": return 2;
						case "DataType": return 3;
						case "DataTypeSchema": return 4;
						case "Default": return 5;
						case "DefaultConstraintName": return 6;
						case "DefaultSchema": return 7;
						case "ID": return 8;
						case "Identity": return 9;
						case "IdentityIncrement": return 10;
						case "IdentityIncrementAsDecimal": return 11;
						case "IdentitySeed": return 12;
						case "IdentitySeedAsDecimal": return 13;
						case "InPrimaryKey": return 14;
						case "IsDroppedLedgerColumn": return 15;
						case "IsForeignKey": return 16;
						case "IsFullTextIndexed": return 17;
						case "Length": return 18;
						case "NotForReplication": return 19;
						case "Nullable": return 20;
						case "NumericPrecision": return 21;
						case "NumericScale": return 22;
						case "RowGuidCol": return 23;
						case "Rule": return 24;
						case "RuleSchema": return 25;
						case "SystemType": return 26;
						case "Collation": return 27;
						case "IsDeterministic": return 28;
						case "IsPersisted": return 29;
						case "IsPrecise": return 30;
						case "XmlDocumentConstraint": return 31;
						case "XmlSchemaNamespace": return 32;
						case "XmlSchemaNamespaceSchema": return 33;
						case "IsClassified": return 34;
						case "IsColumnSet": return 35;
						case "IsFileStream": return 36;
						case "IsSparse": return 37;
						case "SensitivityInformationTypeId": return 38;
						case "SensitivityInformationTypeName": return 39;
						case "SensitivityLabelId": return 40;
						case "SensitivityLabelName": return 41;
						case "UserType": return 42;
						case "StatisticalSemantics": return 43;
						case "ColumnEncryptionKeyID": return 44;
						case "ColumnEncryptionKeyName": return 45;
						case "EncryptionAlgorithm": return 46;
						case "EncryptionType": return 47;
						case "GeneratedAlwaysType": return 48;
						case "IsHidden": return 49;
						case "IsMasked": return 50;
						case "MaskingFunction": return 51;
						case "GraphType": return 52;
						case "SensitivityRank": return 53;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 27, 28, 34, 43, 43, 44, 44, 52, 53, 54, 54, 54 };
			static int [] cloudVersionCount = new int [] { 37, 37, 53 };
			static int sqlDwPropertyCount = 42;
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
				new StaticMetadata("AnsiPaddingStatus", false, true, typeof(System.Boolean)),
				new StaticMetadata("Collation", false, false, typeof(System.String)),
				new StaticMetadata("Computed", false, false, typeof(System.Boolean)),
				new StaticMetadata("ComputedText", true, false, typeof(System.String)),
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("Default", false, false, typeof(System.String)),
				new StaticMetadata("DefaultConstraintName", false, false, typeof(System.String)),
				new StaticMetadata("DefaultSchema", false, false, typeof(System.String)),
				new StaticMetadata("DistributionColumnName", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Identity", false, false, typeof(System.Boolean)),
				new StaticMetadata("IdentityIncrement", true, false, typeof(System.Int64)),
				new StaticMetadata("IdentityIncrementAsDecimal", false, false, typeof(System.Decimal)),
				new StaticMetadata("IdentitySeed", true, false, typeof(System.Int64)),
				new StaticMetadata("IdentitySeedAsDecimal", false, false, typeof(System.Decimal)),
				new StaticMetadata("InPrimaryKey", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsClassified", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsColumnSet", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDistributedColumn", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDroppedLedgerColumn", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFileStream", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsForeignKey", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsMasked", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPersisted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSparse", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("MaskingFunction", true, false, typeof(System.String)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("Nullable", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("RowGuidCol", false, false, typeof(System.Boolean)),
				new StaticMetadata("Rule", false, false, typeof(System.String)),
				new StaticMetadata("RuleSchema", false, false, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeId", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeName", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityLabelId", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityLabelName", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityRank", true, false, typeof(Microsoft.SqlServer.Management.Smo.SensitivityRank)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("AnsiPaddingStatus", false, true, typeof(System.Boolean)),
				new StaticMetadata("Collation", false, false, typeof(System.String)),
				new StaticMetadata("Computed", false, false, typeof(System.Boolean)),
				new StaticMetadata("ComputedText", true, false, typeof(System.String)),
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("Default", false, false, typeof(System.String)),
				new StaticMetadata("DefaultConstraintName", false, false, typeof(System.String)),
				new StaticMetadata("DefaultSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Identity", false, false, typeof(System.Boolean)),
				new StaticMetadata("IdentityIncrement", true, false, typeof(System.Int64)),
				new StaticMetadata("IdentityIncrementAsDecimal", false, false, typeof(System.Decimal)),
				new StaticMetadata("IdentitySeed", true, false, typeof(System.Int64)),
				new StaticMetadata("IdentitySeedAsDecimal", false, false, typeof(System.Decimal)),
				new StaticMetadata("InPrimaryKey", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsColumnSet", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsDeterministic", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFileStream", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsForeignKey", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextIndexed", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsPersisted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPrecise", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsSparse", false, false, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("Nullable", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("RowGuidCol", false, false, typeof(System.Boolean)),
				new StaticMetadata("Rule", false, false, typeof(System.String)),
				new StaticMetadata("RuleSchema", false, false, typeof(System.String)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
				new StaticMetadata("ColumnEncryptionKeyID", false, false, typeof(System.Int32)),
				new StaticMetadata("ColumnEncryptionKeyName", false, false, typeof(System.String)),
				new StaticMetadata("EncryptionAlgorithm", false, false, typeof(System.String)),
				new StaticMetadata("EncryptionType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ColumnEncryptionType)),
				new StaticMetadata("GeneratedAlwaysType", false, false, typeof(Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType)),
				new StaticMetadata("GraphType", false, false, typeof(Microsoft.SqlServer.Management.Smo.GraphType)),
				new StaticMetadata("IsClassified", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDroppedLedgerColumn", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsHidden", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsMasked", false, false, typeof(System.Boolean)),
				new StaticMetadata("MaskingFunction", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeId", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeName", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityLabelId", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityLabelName", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityRank", true, false, typeof(Microsoft.SqlServer.Management.Smo.SensitivityRank)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiPaddingStatus", false, true, typeof(System.Boolean)),
				new StaticMetadata("Computed", false, false, typeof(System.Boolean)),
				new StaticMetadata("ComputedText", true, false, typeof(System.String)),
				new StaticMetadata("DataType", false, false, typeof(System.String)),
				new StaticMetadata("DataTypeSchema", false, false, typeof(System.String)),
				new StaticMetadata("Default", false, false, typeof(System.String)),
				new StaticMetadata("DefaultConstraintName", false, false, typeof(System.String)),
				new StaticMetadata("DefaultSchema", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Identity", false, false, typeof(System.Boolean)),
				new StaticMetadata("IdentityIncrement", true, false, typeof(System.Int64)),
				new StaticMetadata("IdentityIncrementAsDecimal", false, false, typeof(System.Decimal)),
				new StaticMetadata("IdentitySeed", true, false, typeof(System.Int64)),
				new StaticMetadata("IdentitySeedAsDecimal", false, false, typeof(System.Decimal)),
				new StaticMetadata("InPrimaryKey", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsDroppedLedgerColumn", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsForeignKey", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFullTextIndexed", false, true, typeof(System.Boolean)),
				new StaticMetadata("Length", false, false, typeof(System.Int32)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("Nullable", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericPrecision", false, false, typeof(System.Int32)),
				new StaticMetadata("NumericScale", false, false, typeof(System.Int32)),
				new StaticMetadata("RowGuidCol", false, false, typeof(System.Boolean)),
				new StaticMetadata("Rule", false, false, typeof(System.String)),
				new StaticMetadata("RuleSchema", false, false, typeof(System.String)),
				new StaticMetadata("SystemType", false, true, typeof(System.String)),
				new StaticMetadata("Collation", false, false, typeof(System.String)),
				new StaticMetadata("IsDeterministic", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsPersisted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsPrecise", false, true, typeof(System.Boolean)),
				new StaticMetadata("XmlDocumentConstraint", false, false, typeof(Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)),
				new StaticMetadata("XmlSchemaNamespace", false, false, typeof(System.String)),
				new StaticMetadata("XmlSchemaNamespaceSchema", false, false, typeof(System.String)),
				new StaticMetadata("IsClassified", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsColumnSet", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsFileStream", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSparse", false, false, typeof(System.Boolean)),
				new StaticMetadata("SensitivityInformationTypeId", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityInformationTypeName", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityLabelId", true, false, typeof(System.String)),
				new StaticMetadata("SensitivityLabelName", true, false, typeof(System.String)),
				new StaticMetadata("UserType", false, true, typeof(System.String)),
				new StaticMetadata("StatisticalSemantics", false, true, typeof(System.Int32)),
				new StaticMetadata("ColumnEncryptionKeyID", false, false, typeof(System.Int32)),
				new StaticMetadata("ColumnEncryptionKeyName", false, false, typeof(System.String)),
				new StaticMetadata("EncryptionAlgorithm", false, false, typeof(System.String)),
				new StaticMetadata("EncryptionType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ColumnEncryptionType)),
				new StaticMetadata("GeneratedAlwaysType", false, false, typeof(Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType)),
				new StaticMetadata("IsHidden", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsMasked", false, false, typeof(System.Boolean)),
				new StaticMetadata("MaskingFunction", true, false, typeof(System.String)),
				new StaticMetadata("GraphType", false, false, typeof(Microsoft.SqlServer.Management.Smo.GraphType)),
				new StaticMetadata("SensitivityRank", true, false, typeof(Microsoft.SqlServer.Management.Smo.SensitivityRank)),
			};
		}
		private sealed class XSchemaProps
		{
			private System.Boolean _AnsiPaddingStatus;
			internal System.Boolean AnsiPaddingStatus { get{ return _AnsiPaddingStatus; } set{ _AnsiPaddingStatus=value; } }

			private System.String _Collation;
			internal System.String Collation { get{ return _Collation; } set{ _Collation=value; } }

			private System.Boolean _Computed;
			internal System.Boolean Computed { get{ return _Computed; } set{ _Computed=value; } }

			private System.String _ComputedText;
			internal System.String ComputedText { get{ return _ComputedText; } set{ _ComputedText=value; } }

			private System.String _DataType;
			internal System.String DataType { get{ return _DataType; } set{ _DataType=value; } }

			private System.String _DataTypeSchema;
			internal System.String DataTypeSchema { get{ return _DataTypeSchema; } set{ _DataTypeSchema=value; } }

			private System.String _Default;
			internal System.String Default { get{ return _Default; } set{ _Default=value; } }

			private System.String _DefaultSchema;
			internal System.String DefaultSchema { get{ return _DefaultSchema; } set{ _DefaultSchema=value; } }

			private System.Boolean _Identity;
			internal System.Boolean Identity { get{ return _Identity; } set{ _Identity=value; } }

			private System.Int64 _IdentityIncrement;
			internal System.Int64 IdentityIncrement { get{ return _IdentityIncrement; } set{ _IdentityIncrement=value; } }

			private System.Decimal _IdentityIncrementAsDecimal;
			internal System.Decimal IdentityIncrementAsDecimal { get{ return _IdentityIncrementAsDecimal; } set{ _IdentityIncrementAsDecimal=value; } }

			private System.Int64 _IdentitySeed;
			internal System.Int64 IdentitySeed { get{ return _IdentitySeed; } set{ _IdentitySeed=value; } }

			private System.Decimal _IdentitySeedAsDecimal;
			internal System.Decimal IdentitySeedAsDecimal { get{ return _IdentitySeedAsDecimal; } set{ _IdentitySeedAsDecimal=value; } }

			private System.Boolean _IsColumnSet;
			internal System.Boolean IsColumnSet { get{ return _IsColumnSet; } set{ _IsColumnSet=value; } }

			private System.Boolean _IsPersisted;
			internal System.Boolean IsPersisted { get{ return _IsPersisted; } set{ _IsPersisted=value; } }

			private System.Boolean _IsSparse;
			internal System.Boolean IsSparse { get{ return _IsSparse; } set{ _IsSparse=value; } }

			private System.Int32 _Length;
			internal System.Int32 Length { get{ return _Length; } set{ _Length=value; } }

			private System.Boolean _NotForReplication;
			internal System.Boolean NotForReplication { get{ return _NotForReplication; } set{ _NotForReplication=value; } }

			private System.Boolean _Nullable;
			internal System.Boolean Nullable { get{ return _Nullable; } set{ _Nullable=value; } }

			private System.Int32 _NumericPrecision;
			internal System.Int32 NumericPrecision { get{ return _NumericPrecision; } set{ _NumericPrecision=value; } }

			private System.Int32 _NumericScale;
			internal System.Int32 NumericScale { get{ return _NumericScale; } set{ _NumericScale=value; } }

			private System.Boolean _RowGuidCol;
			internal System.Boolean RowGuidCol { get{ return _RowGuidCol; } set{ _RowGuidCol=value; } }

			private System.String _Rule;
			internal System.String Rule { get{ return _Rule; } set{ _Rule=value; } }

			private System.String _RuleSchema;
			internal System.String RuleSchema { get{ return _RuleSchema; } set{ _RuleSchema=value; } }

			private System.String _SystemType;
			internal System.String SystemType { get{ return _SystemType; } set{ _SystemType=value; } }

			private System.String _UserType;
			internal System.String UserType { get{ return _UserType; } set{ _UserType=value; } }

			private Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint _XmlDocumentConstraint;
			internal Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint XmlDocumentConstraint { get{ return _XmlDocumentConstraint; } set{ _XmlDocumentConstraint=value; } }

			private System.String _XmlSchemaNamespace;
			internal System.String XmlSchemaNamespace { get{ return _XmlSchemaNamespace; } set{ _XmlSchemaNamespace=value; } }

			private System.String _XmlSchemaNamespaceSchema;
			internal System.String XmlSchemaNamespaceSchema { get{ return _XmlSchemaNamespaceSchema; } set{ _XmlSchemaNamespaceSchema=value; } }

			private System.String _DistributionColumnName;
			internal System.String DistributionColumnName { get{ return _DistributionColumnName; } set{ _DistributionColumnName=value; } }

			private System.Boolean _IsDistributedColumn;
			internal System.Boolean IsDistributedColumn { get{ return _IsDistributedColumn; } set{ _IsDistributedColumn=value; } }

		}

		private sealed class XRuntimeProps
		{
			private System.Int32 _ColumnEncryptionKeyID;
			internal System.Int32 ColumnEncryptionKeyID { get{ return _ColumnEncryptionKeyID; } set{ _ColumnEncryptionKeyID=value; } }

			private System.String _ColumnEncryptionKeyName;
			internal System.String ColumnEncryptionKeyName { get{ return _ColumnEncryptionKeyName; } set{ _ColumnEncryptionKeyName=value; } }

			private System.String _DefaultConstraintName;
			internal System.String DefaultConstraintName { get{ return _DefaultConstraintName; } set{ _DefaultConstraintName=value; } }

			private System.String _EncryptionAlgorithm;
			internal System.String EncryptionAlgorithm { get{ return _EncryptionAlgorithm; } set{ _EncryptionAlgorithm=value; } }

			private Microsoft.SqlServer.Management.Smo.ColumnEncryptionType _EncryptionType;
			internal Microsoft.SqlServer.Management.Smo.ColumnEncryptionType EncryptionType { get{ return _EncryptionType; } set{ _EncryptionType=value; } }

			private Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType _GeneratedAlwaysType;
			internal Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType GeneratedAlwaysType { get{ return _GeneratedAlwaysType; } set{ _GeneratedAlwaysType=value; } }

			private Microsoft.SqlServer.Management.Smo.GraphType _GraphType;
			internal Microsoft.SqlServer.Management.Smo.GraphType GraphType { get{ return _GraphType; } set{ _GraphType=value; } }

			private System.Int32 _ID;
			internal System.Int32 ID { get{ return _ID; } set{ _ID=value; } }

			private System.Boolean _InPrimaryKey;
			internal System.Boolean InPrimaryKey { get{ return _InPrimaryKey; } set{ _InPrimaryKey=value; } }

			private System.Boolean _IsClassified;
			internal System.Boolean IsClassified { get{ return _IsClassified; } set{ _IsClassified=value; } }

			private System.Boolean _IsDeterministic;
			internal System.Boolean IsDeterministic { get{ return _IsDeterministic; } set{ _IsDeterministic=value; } }

			private System.Boolean _IsDroppedLedgerColumn;
			internal System.Boolean IsDroppedLedgerColumn { get{ return _IsDroppedLedgerColumn; } set{ _IsDroppedLedgerColumn=value; } }

			private System.Boolean _IsFileStream;
			internal System.Boolean IsFileStream { get{ return _IsFileStream; } set{ _IsFileStream=value; } }

			private System.Boolean _IsForeignKey;
			internal System.Boolean IsForeignKey { get{ return _IsForeignKey; } set{ _IsForeignKey=value; } }

			private System.Boolean _IsFullTextIndexed;
			internal System.Boolean IsFullTextIndexed { get{ return _IsFullTextIndexed; } set{ _IsFullTextIndexed=value; } }

			private System.Boolean _IsHidden;
			internal System.Boolean IsHidden { get{ return _IsHidden; } set{ _IsHidden=value; } }

			private System.Boolean _IsMasked;
			internal System.Boolean IsMasked { get{ return _IsMasked; } set{ _IsMasked=value; } }

			private System.Boolean _IsPrecise;
			internal System.Boolean IsPrecise { get{ return _IsPrecise; } set{ _IsPrecise=value; } }

			private System.String _MaskingFunction;
			internal System.String MaskingFunction { get{ return _MaskingFunction; } set{ _MaskingFunction=value; } }

			private System.String _SensitivityInformationTypeId;
			internal System.String SensitivityInformationTypeId { get{ return _SensitivityInformationTypeId; } set{ _SensitivityInformationTypeId=value; } }

			private System.String _SensitivityInformationTypeName;
			internal System.String SensitivityInformationTypeName { get{ return _SensitivityInformationTypeName; } set{ _SensitivityInformationTypeName=value; } }

			private System.String _SensitivityLabelId;
			internal System.String SensitivityLabelId { get{ return _SensitivityLabelId; } set{ _SensitivityLabelId=value; } }

			private System.String _SensitivityLabelName;
			internal System.String SensitivityLabelName { get{ return _SensitivityLabelName; } set{ _SensitivityLabelName=value; } }

			private Microsoft.SqlServer.Management.Smo.SensitivityRank _SensitivityRank;
			internal Microsoft.SqlServer.Management.Smo.SensitivityRank SensitivityRank { get{ return _SensitivityRank; } set{ _SensitivityRank=value; } }

			private System.Int32 _StatisticalSemantics;
			internal System.Int32 StatisticalSemantics { get{ return _StatisticalSemantics; } set{ _StatisticalSemantics=value; } }

		}

		object IPropertyDataDispatch.GetPropertyValue( int index )
		{
			object value;
			if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
			{
				if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
				{
					switch(index)
					{
						case 0:
						value = this.XSchema.AnsiPaddingStatus;
						break;
						case 1:
						value = this.XSchema.Collation;
						break;
						case 2:
						value = this.XSchema.Computed;
						break;
						case 3:
						value = this.XSchema.ComputedText;
						break;
						case 4:
						value = this.XSchema.DataType;
						break;
						case 5:
						value = this.XSchema.DataTypeSchema;
						break;
						case 6:
						value = this.XSchema.Default;
						break;
						case 7:
						value = this.XRuntime.DefaultConstraintName;
						break;
						case 8:
						value = this.XSchema.DefaultSchema;
						break;
						case 9:
						value = this.XSchema.DistributionColumnName;
						break;
						case 10:
						value = this.XRuntime.ID;
						break;
						case 11:
						value = this.XSchema.Identity;
						break;
						case 12:
						value = this.XSchema.IdentityIncrement;
						break;
						case 13:
						value = this.XSchema.IdentityIncrementAsDecimal;
						break;
						case 14:
						value = this.XSchema.IdentitySeed;
						break;
						case 15:
						value = this.XSchema.IdentitySeedAsDecimal;
						break;
						case 16:
						value = this.XRuntime.InPrimaryKey;
						break;
						case 17:
						value = this.XRuntime.IsClassified;
						break;
						case 18:
						value = this.XSchema.IsColumnSet;
						break;
						case 19:
						value = this.XSchema.IsDistributedColumn;
						break;
						case 20:
						value = this.XRuntime.IsDroppedLedgerColumn;
						break;
						case 21:
						value = this.XRuntime.IsFileStream;
						break;
						case 22:
						value = this.XRuntime.IsForeignKey;
						break;
						case 23:
						value = this.XRuntime.IsMasked;
						break;
						case 24:
						value = this.XSchema.IsPersisted;
						break;
						case 25:
						value = this.XSchema.IsSparse;
						break;
						case 26:
						value = this.XSchema.Length;
						break;
						case 27:
						value = this.XRuntime.MaskingFunction;
						break;
						case 28:
						value = this.XSchema.NotForReplication;
						break;
						case 29:
						value = this.XSchema.Nullable;
						break;
						case 30:
						value = this.XSchema.NumericPrecision;
						break;
						case 31:
						value = this.XSchema.NumericScale;
						break;
						case 32:
						value = this.XSchema.RowGuidCol;
						break;
						case 33:
						value = this.XSchema.Rule;
						break;
						case 34:
						value = this.XSchema.RuleSchema;
						break;
						case 35:
						value = this.XRuntime.SensitivityInformationTypeId;
						break;
						case 36:
						value = this.XRuntime.SensitivityInformationTypeName;
						break;
						case 37:
						value = this.XRuntime.SensitivityLabelId;
						break;
						case 38:
						value = this.XRuntime.SensitivityLabelName;
						break;
						case 39:
						value = this.XRuntime.SensitivityRank;
						break;
						case 40:
						value = this.XSchema.SystemType;
						break;
						case 41:
						value = this.XSchema.UserType;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						value = this.XSchema.AnsiPaddingStatus;
						break;
						case 1:
						value = this.XSchema.Collation;
						break;
						case 37:
						value = this.XRuntime.ColumnEncryptionKeyID;
						break;
						case 38:
						value = this.XRuntime.ColumnEncryptionKeyName;
						break;
						case 2:
						value = this.XSchema.Computed;
						break;
						case 3:
						value = this.XSchema.ComputedText;
						break;
						case 4:
						value = this.XSchema.DataType;
						break;
						case 5:
						value = this.XSchema.DataTypeSchema;
						break;
						case 6:
						value = this.XSchema.Default;
						break;
						case 7:
						value = this.XRuntime.DefaultConstraintName;
						break;
						case 8:
						value = this.XSchema.DefaultSchema;
						break;
						case 39:
						value = this.XRuntime.EncryptionAlgorithm;
						break;
						case 40:
						value = this.XRuntime.EncryptionType;
						break;
						case 41:
						value = this.XRuntime.GeneratedAlwaysType;
						break;
						case 42:
						value = this.XRuntime.GraphType;
						break;
						case 9:
						value = this.XRuntime.ID;
						break;
						case 10:
						value = this.XSchema.Identity;
						break;
						case 11:
						value = this.XSchema.IdentityIncrement;
						break;
						case 12:
						value = this.XSchema.IdentityIncrementAsDecimal;
						break;
						case 13:
						value = this.XSchema.IdentitySeed;
						break;
						case 14:
						value = this.XSchema.IdentitySeedAsDecimal;
						break;
						case 15:
						value = this.XRuntime.InPrimaryKey;
						break;
						case 43:
						value = this.XRuntime.IsClassified;
						break;
						case 16:
						value = this.XSchema.IsColumnSet;
						break;
						case 17:
						value = this.XRuntime.IsDeterministic;
						break;
						case 44:
						value = this.XRuntime.IsDroppedLedgerColumn;
						break;
						case 18:
						value = this.XRuntime.IsFileStream;
						break;
						case 19:
						value = this.XRuntime.IsForeignKey;
						break;
						case 20:
						value = this.XRuntime.IsFullTextIndexed;
						break;
						case 45:
						value = this.XRuntime.IsHidden;
						break;
						case 46:
						value = this.XRuntime.IsMasked;
						break;
						case 21:
						value = this.XSchema.IsPersisted;
						break;
						case 22:
						value = this.XRuntime.IsPrecise;
						break;
						case 23:
						value = this.XSchema.IsSparse;
						break;
						case 24:
						value = this.XSchema.Length;
						break;
						case 47:
						value = this.XRuntime.MaskingFunction;
						break;
						case 25:
						value = this.XSchema.NotForReplication;
						break;
						case 26:
						value = this.XSchema.Nullable;
						break;
						case 27:
						value = this.XSchema.NumericPrecision;
						break;
						case 28:
						value = this.XSchema.NumericScale;
						break;
						case 29:
						value = this.XSchema.RowGuidCol;
						break;
						case 30:
						value = this.XSchema.Rule;
						break;
						case 31:
						value = this.XSchema.RuleSchema;
						break;
						case 48:
						value = this.XRuntime.SensitivityInformationTypeId;
						break;
						case 49:
						value = this.XRuntime.SensitivityInformationTypeName;
						break;
						case 50:
						value = this.XRuntime.SensitivityLabelId;
						break;
						case 51:
						value = this.XRuntime.SensitivityLabelName;
						break;
						case 52:
						value = this.XRuntime.SensitivityRank;
						break;
						case 32:
						value = this.XSchema.SystemType;
						break;
						case 33:
						value = this.XSchema.UserType;
						break;
						case 34:
						value = this.XSchema.XmlDocumentConstraint;
						break;
						case 35:
						value = this.XSchema.XmlSchemaNamespace;
						break;
						case 36:
						value = this.XSchema.XmlSchemaNamespaceSchema;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
			}
			else
			{
				switch(index)
				{
					case 0:
					value = this.XSchema.AnsiPaddingStatus;
					break;
					case 27:
					value = this.XSchema.Collation;
					break;
					case 44:
					value = this.XRuntime.ColumnEncryptionKeyID;
					break;
					case 45:
					value = this.XRuntime.ColumnEncryptionKeyName;
					break;
					case 1:
					value = this.XSchema.Computed;
					break;
					case 2:
					value = this.XSchema.ComputedText;
					break;
					case 3:
					value = this.XSchema.DataType;
					break;
					case 4:
					value = this.XSchema.DataTypeSchema;
					break;
					case 5:
					value = this.XSchema.Default;
					break;
					case 6:
					value = this.XRuntime.DefaultConstraintName;
					break;
					case 7:
					value = this.XSchema.DefaultSchema;
					break;
					case 46:
					value = this.XRuntime.EncryptionAlgorithm;
					break;
					case 47:
					value = this.XRuntime.EncryptionType;
					break;
					case 48:
					value = this.XRuntime.GeneratedAlwaysType;
					break;
					case 52:
					value = this.XRuntime.GraphType;
					break;
					case 8:
					value = this.XRuntime.ID;
					break;
					case 9:
					value = this.XSchema.Identity;
					break;
					case 10:
					value = this.XSchema.IdentityIncrement;
					break;
					case 11:
					value = this.XSchema.IdentityIncrementAsDecimal;
					break;
					case 12:
					value = this.XSchema.IdentitySeed;
					break;
					case 13:
					value = this.XSchema.IdentitySeedAsDecimal;
					break;
					case 14:
					value = this.XRuntime.InPrimaryKey;
					break;
					case 34:
					value = this.XRuntime.IsClassified;
					break;
					case 35:
					value = this.XSchema.IsColumnSet;
					break;
					case 28:
					value = this.XRuntime.IsDeterministic;
					break;
					case 15:
					value = this.XRuntime.IsDroppedLedgerColumn;
					break;
					case 36:
					value = this.XRuntime.IsFileStream;
					break;
					case 16:
					value = this.XRuntime.IsForeignKey;
					break;
					case 17:
					value = this.XRuntime.IsFullTextIndexed;
					break;
					case 49:
					value = this.XRuntime.IsHidden;
					break;
					case 50:
					value = this.XRuntime.IsMasked;
					break;
					case 29:
					value = this.XSchema.IsPersisted;
					break;
					case 30:
					value = this.XRuntime.IsPrecise;
					break;
					case 37:
					value = this.XSchema.IsSparse;
					break;
					case 18:
					value = this.XSchema.Length;
					break;
					case 51:
					value = this.XRuntime.MaskingFunction;
					break;
					case 19:
					value = this.XSchema.NotForReplication;
					break;
					case 20:
					value = this.XSchema.Nullable;
					break;
					case 21:
					value = this.XSchema.NumericPrecision;
					break;
					case 22:
					value = this.XSchema.NumericScale;
					break;
					case 23:
					value = this.XSchema.RowGuidCol;
					break;
					case 24:
					value = this.XSchema.Rule;
					break;
					case 25:
					value = this.XSchema.RuleSchema;
					break;
					case 38:
					value = this.XRuntime.SensitivityInformationTypeId;
					break;
					case 39:
					value = this.XRuntime.SensitivityInformationTypeName;
					break;
					case 40:
					value = this.XRuntime.SensitivityLabelId;
					break;
					case 41:
					value = this.XRuntime.SensitivityLabelName;
					break;
					case 53:
					value = this.XRuntime.SensitivityRank;
					break;
					case 43:
					value = this.XRuntime.StatisticalSemantics;
					break;
					case 26:
					value = this.XSchema.SystemType;
					break;
					case 42:
					value = this.XSchema.UserType;
					break;
					case 31:
					value = this.XSchema.XmlDocumentConstraint;
					break;
					case 32:
					value = this.XSchema.XmlSchemaNamespace;
					break;
					case 33:
					value = this.XSchema.XmlSchemaNamespaceSchema;
					break;
					default:
					throw new IndexOutOfRangeException();
				}
			}
			return value;
		}
		void IPropertyDataDispatch.SetPropertyValue( int index, object value )
		{
			if(this.DatabaseEngineType == DatabaseEngineType.SqlAzureDatabase)
			{
				if(this.DatabaseEngineEdition == DatabaseEngineEdition.SqlDataWarehouse)
				{
					switch(index)
					{
						case 0:
						this.XSchema.AnsiPaddingStatus = (System.Boolean)value;
						break;
						case 1:
						this.XSchema.Collation = (System.String)value;
						break;
						case 2:
						this.XSchema.Computed = (System.Boolean)value;
						break;
						case 3:
						this.XSchema.ComputedText = (System.String)value;
						break;
						case 4:
						this.XSchema.DataType = (System.String)value;
						break;
						case 5:
						this.XSchema.DataTypeSchema = (System.String)value;
						break;
						case 6:
						this.XSchema.Default = (System.String)value;
						break;
						case 7:
						this.XRuntime.DefaultConstraintName = (System.String)value;
						break;
						case 8:
						this.XSchema.DefaultSchema = (System.String)value;
						break;
						case 9:
						this.XSchema.DistributionColumnName = (System.String)value;
						break;
						case 10:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 11:
						this.XSchema.Identity = (System.Boolean)value;
						break;
						case 12:
						this.XSchema.IdentityIncrement = (System.Int64)value;
						break;
						case 13:
						this.XSchema.IdentityIncrementAsDecimal = (System.Decimal)value;
						break;
						case 14:
						this.XSchema.IdentitySeed = (System.Int64)value;
						break;
						case 15:
						this.XSchema.IdentitySeedAsDecimal = (System.Decimal)value;
						break;
						case 16:
						this.XRuntime.InPrimaryKey = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.IsClassified = (System.Boolean)value;
						break;
						case 18:
						this.XSchema.IsColumnSet = (System.Boolean)value;
						break;
						case 19:
						this.XSchema.IsDistributedColumn = (System.Boolean)value;
						break;
						case 20:
						this.XRuntime.IsDroppedLedgerColumn = (System.Boolean)value;
						break;
						case 21:
						this.XRuntime.IsFileStream = (System.Boolean)value;
						break;
						case 22:
						this.XRuntime.IsForeignKey = (System.Boolean)value;
						break;
						case 23:
						this.XRuntime.IsMasked = (System.Boolean)value;
						break;
						case 24:
						this.XSchema.IsPersisted = (System.Boolean)value;
						break;
						case 25:
						this.XSchema.IsSparse = (System.Boolean)value;
						break;
						case 26:
						this.XSchema.Length = (System.Int32)value;
						break;
						case 27:
						this.XRuntime.MaskingFunction = (System.String)value;
						break;
						case 28:
						this.XSchema.NotForReplication = (System.Boolean)value;
						break;
						case 29:
						this.XSchema.Nullable = (System.Boolean)value;
						break;
						case 30:
						this.XSchema.NumericPrecision = (System.Int32)value;
						break;
						case 31:
						this.XSchema.NumericScale = (System.Int32)value;
						break;
						case 32:
						this.XSchema.RowGuidCol = (System.Boolean)value;
						break;
						case 33:
						this.XSchema.Rule = (System.String)value;
						break;
						case 34:
						this.XSchema.RuleSchema = (System.String)value;
						break;
						case 35:
						this.XRuntime.SensitivityInformationTypeId = (System.String)value;
						break;
						case 36:
						this.XRuntime.SensitivityInformationTypeName = (System.String)value;
						break;
						case 37:
						this.XRuntime.SensitivityLabelId = (System.String)value;
						break;
						case 38:
						this.XRuntime.SensitivityLabelName = (System.String)value;
						break;
						case 39:
						this.XRuntime.SensitivityRank = (Microsoft.SqlServer.Management.Smo.SensitivityRank)value;
						break;
						case 40:
						this.XSchema.SystemType = (System.String)value;
						break;
						case 41:
						this.XSchema.UserType = (System.String)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
				else
				{
					switch(index)
					{
						case 0:
						this.XSchema.AnsiPaddingStatus = (System.Boolean)value;
						break;
						case 1:
						this.XSchema.Collation = (System.String)value;
						break;
						case 37:
						this.XRuntime.ColumnEncryptionKeyID = (System.Int32)value;
						break;
						case 38:
						this.XRuntime.ColumnEncryptionKeyName = (System.String)value;
						break;
						case 2:
						this.XSchema.Computed = (System.Boolean)value;
						break;
						case 3:
						this.XSchema.ComputedText = (System.String)value;
						break;
						case 4:
						this.XSchema.DataType = (System.String)value;
						break;
						case 5:
						this.XSchema.DataTypeSchema = (System.String)value;
						break;
						case 6:
						this.XSchema.Default = (System.String)value;
						break;
						case 7:
						this.XRuntime.DefaultConstraintName = (System.String)value;
						break;
						case 8:
						this.XSchema.DefaultSchema = (System.String)value;
						break;
						case 39:
						this.XRuntime.EncryptionAlgorithm = (System.String)value;
						break;
						case 40:
						this.XRuntime.EncryptionType = (Microsoft.SqlServer.Management.Smo.ColumnEncryptionType)value;
						break;
						case 41:
						this.XRuntime.GeneratedAlwaysType = (Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType)value;
						break;
						case 42:
						this.XRuntime.GraphType = (Microsoft.SqlServer.Management.Smo.GraphType)value;
						break;
						case 9:
						this.XRuntime.ID = (System.Int32)value;
						break;
						case 10:
						this.XSchema.Identity = (System.Boolean)value;
						break;
						case 11:
						this.XSchema.IdentityIncrement = (System.Int64)value;
						break;
						case 12:
						this.XSchema.IdentityIncrementAsDecimal = (System.Decimal)value;
						break;
						case 13:
						this.XSchema.IdentitySeed = (System.Int64)value;
						break;
						case 14:
						this.XSchema.IdentitySeedAsDecimal = (System.Decimal)value;
						break;
						case 15:
						this.XRuntime.InPrimaryKey = (System.Boolean)value;
						break;
						case 43:
						this.XRuntime.IsClassified = (System.Boolean)value;
						break;
						case 16:
						this.XSchema.IsColumnSet = (System.Boolean)value;
						break;
						case 17:
						this.XRuntime.IsDeterministic = (System.Boolean)value;
						break;
						case 44:
						this.XRuntime.IsDroppedLedgerColumn = (System.Boolean)value;
						break;
						case 18:
						this.XRuntime.IsFileStream = (System.Boolean)value;
						break;
						case 19:
						this.XRuntime.IsForeignKey = (System.Boolean)value;
						break;
						case 20:
						this.XRuntime.IsFullTextIndexed = (System.Boolean)value;
						break;
						case 45:
						this.XRuntime.IsHidden = (System.Boolean)value;
						break;
						case 46:
						this.XRuntime.IsMasked = (System.Boolean)value;
						break;
						case 21:
						this.XSchema.IsPersisted = (System.Boolean)value;
						break;
						case 22:
						this.XRuntime.IsPrecise = (System.Boolean)value;
						break;
						case 23:
						this.XSchema.IsSparse = (System.Boolean)value;
						break;
						case 24:
						this.XSchema.Length = (System.Int32)value;
						break;
						case 47:
						this.XRuntime.MaskingFunction = (System.String)value;
						break;
						case 25:
						this.XSchema.NotForReplication = (System.Boolean)value;
						break;
						case 26:
						this.XSchema.Nullable = (System.Boolean)value;
						break;
						case 27:
						this.XSchema.NumericPrecision = (System.Int32)value;
						break;
						case 28:
						this.XSchema.NumericScale = (System.Int32)value;
						break;
						case 29:
						this.XSchema.RowGuidCol = (System.Boolean)value;
						break;
						case 30:
						this.XSchema.Rule = (System.String)value;
						break;
						case 31:
						this.XSchema.RuleSchema = (System.String)value;
						break;
						case 48:
						this.XRuntime.SensitivityInformationTypeId = (System.String)value;
						break;
						case 49:
						this.XRuntime.SensitivityInformationTypeName = (System.String)value;
						break;
						case 50:
						this.XRuntime.SensitivityLabelId = (System.String)value;
						break;
						case 51:
						this.XRuntime.SensitivityLabelName = (System.String)value;
						break;
						case 52:
						this.XRuntime.SensitivityRank = (Microsoft.SqlServer.Management.Smo.SensitivityRank)value;
						break;
						case 32:
						this.XSchema.SystemType = (System.String)value;
						break;
						case 33:
						this.XSchema.UserType = (System.String)value;
						break;
						case 34:
						this.XSchema.XmlDocumentConstraint = (Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)value;
						break;
						case 35:
						this.XSchema.XmlSchemaNamespace = (System.String)value;
						break;
						case 36:
						this.XSchema.XmlSchemaNamespaceSchema = (System.String)value;
						break;
						default:
						throw new IndexOutOfRangeException();
					}
				}
			}
			else
			{
				switch(index)
				{
					case 0:
					this.XSchema.AnsiPaddingStatus = (System.Boolean)value;
					break;
					case 27:
					this.XSchema.Collation = (System.String)value;
					break;
					case 44:
					this.XRuntime.ColumnEncryptionKeyID = (System.Int32)value;
					break;
					case 45:
					this.XRuntime.ColumnEncryptionKeyName = (System.String)value;
					break;
					case 1:
					this.XSchema.Computed = (System.Boolean)value;
					break;
					case 2:
					this.XSchema.ComputedText = (System.String)value;
					break;
					case 3:
					this.XSchema.DataType = (System.String)value;
					break;
					case 4:
					this.XSchema.DataTypeSchema = (System.String)value;
					break;
					case 5:
					this.XSchema.Default = (System.String)value;
					break;
					case 6:
					this.XRuntime.DefaultConstraintName = (System.String)value;
					break;
					case 7:
					this.XSchema.DefaultSchema = (System.String)value;
					break;
					case 46:
					this.XRuntime.EncryptionAlgorithm = (System.String)value;
					break;
					case 47:
					this.XRuntime.EncryptionType = (Microsoft.SqlServer.Management.Smo.ColumnEncryptionType)value;
					break;
					case 48:
					this.XRuntime.GeneratedAlwaysType = (Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType)value;
					break;
					case 52:
					this.XRuntime.GraphType = (Microsoft.SqlServer.Management.Smo.GraphType)value;
					break;
					case 8:
					this.XRuntime.ID = (System.Int32)value;
					break;
					case 9:
					this.XSchema.Identity = (System.Boolean)value;
					break;
					case 10:
					this.XSchema.IdentityIncrement = (System.Int64)value;
					break;
					case 11:
					this.XSchema.IdentityIncrementAsDecimal = (System.Decimal)value;
					break;
					case 12:
					this.XSchema.IdentitySeed = (System.Int64)value;
					break;
					case 13:
					this.XSchema.IdentitySeedAsDecimal = (System.Decimal)value;
					break;
					case 14:
					this.XRuntime.InPrimaryKey = (System.Boolean)value;
					break;
					case 34:
					this.XRuntime.IsClassified = (System.Boolean)value;
					break;
					case 35:
					this.XSchema.IsColumnSet = (System.Boolean)value;
					break;
					case 28:
					this.XRuntime.IsDeterministic = (System.Boolean)value;
					break;
					case 15:
					this.XRuntime.IsDroppedLedgerColumn = (System.Boolean)value;
					break;
					case 36:
					this.XRuntime.IsFileStream = (System.Boolean)value;
					break;
					case 16:
					this.XRuntime.IsForeignKey = (System.Boolean)value;
					break;
					case 17:
					this.XRuntime.IsFullTextIndexed = (System.Boolean)value;
					break;
					case 49:
					this.XRuntime.IsHidden = (System.Boolean)value;
					break;
					case 50:
					this.XRuntime.IsMasked = (System.Boolean)value;
					break;
					case 29:
					this.XSchema.IsPersisted = (System.Boolean)value;
					break;
					case 30:
					this.XRuntime.IsPrecise = (System.Boolean)value;
					break;
					case 37:
					this.XSchema.IsSparse = (System.Boolean)value;
					break;
					case 18:
					this.XSchema.Length = (System.Int32)value;
					break;
					case 51:
					this.XRuntime.MaskingFunction = (System.String)value;
					break;
					case 19:
					this.XSchema.NotForReplication = (System.Boolean)value;
					break;
					case 20:
					this.XSchema.Nullable = (System.Boolean)value;
					break;
					case 21:
					this.XSchema.NumericPrecision = (System.Int32)value;
					break;
					case 22:
					this.XSchema.NumericScale = (System.Int32)value;
					break;
					case 23:
					this.XSchema.RowGuidCol = (System.Boolean)value;
					break;
					case 24:
					this.XSchema.Rule = (System.String)value;
					break;
					case 25:
					this.XSchema.RuleSchema = (System.String)value;
					break;
					case 38:
					this.XRuntime.SensitivityInformationTypeId = (System.String)value;
					break;
					case 39:
					this.XRuntime.SensitivityInformationTypeName = (System.String)value;
					break;
					case 40:
					this.XRuntime.SensitivityLabelId = (System.String)value;
					break;
					case 41:
					this.XRuntime.SensitivityLabelName = (System.String)value;
					break;
					case 53:
					this.XRuntime.SensitivityRank = (Microsoft.SqlServer.Management.Smo.SensitivityRank)value;
					break;
					case 43:
					this.XRuntime.StatisticalSemantics = (System.Int32)value;
					break;
					case 26:
					this.XSchema.SystemType = (System.String)value;
					break;
					case 42:
					this.XSchema.UserType = (System.String)value;
					break;
					case 31:
					this.XSchema.XmlDocumentConstraint = (Microsoft.SqlServer.Management.Smo.XmlDocumentConstraint)value;
					break;
					case 32:
					this.XSchema.XmlSchemaNamespace = (System.String)value;
					break;
					case 33:
					this.XSchema.XmlSchemaNamespaceSchema = (System.String)value;
					break;
					default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		XSchemaProps _XSchema;
		XSchemaProps XSchema 
		{
			get
			{
				if( _XSchema == null )
				{
					_XSchema = new XSchemaProps();
				}
				return _XSchema; 
			}
		}
		XRuntimeProps _XRuntime;
		XRuntimeProps XRuntime
		{
			get
			{
				if( _XRuntime == null )
				{
					_XRuntime = new XRuntimeProps();
				}
				return _XRuntime;
			}
		}

		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AnsiPaddingStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiPaddingStatus");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ColumnEncryptionKeyID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ColumnEncryptionKeyID");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ColumnEncryptionKeyID", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ColumnEncryptionKeyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ColumnEncryptionKeyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ColumnEncryptionKeyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Computed
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Computed");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Computed", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ComputedText
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ComputedText");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ComputedText", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Default),"Server[@Name = '{0}']/Database[@Name = '{1}']/Default[@Name='{2}' and @Schema='{3}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","Default","DefaultSchema")]
		[CLSCompliant(false)]
		public System.String Default
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Default");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Default", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DefaultConstraintName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultConstraintName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultConstraintName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "dbo")]
		public System.String DefaultSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultSchema", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String EncryptionAlgorithm
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EncryptionAlgorithm");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptionAlgorithm", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ColumnEncryptionType EncryptionType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ColumnEncryptionType)this.Properties.GetValueWithNullReplacement("EncryptionType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EncryptionType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType GeneratedAlwaysType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.GeneratedAlwaysType)this.Properties.GetValueWithNullReplacement("GeneratedAlwaysType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("GeneratedAlwaysType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.GraphType GraphType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.GraphType)this.Properties.GetValueWithNullReplacement("GraphType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("GraphType", value);
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
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Identity
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Identity");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Identity", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 IdentityIncrement
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("IdentityIncrement");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IdentityIncrement", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Decimal IdentityIncrementAsDecimal
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("IdentityIncrementAsDecimal");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IdentityIncrementAsDecimal", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int64 IdentitySeed
		{
			get
			{
				return (System.Int64)this.Properties.GetValueWithNullReplacement("IdentitySeed");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IdentitySeed", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Decimal IdentitySeedAsDecimal
		{
			get
			{
				return (System.Decimal)this.Properties.GetValueWithNullReplacement("IdentitySeedAsDecimal");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IdentitySeedAsDecimal", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean InPrimaryKey
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("InPrimaryKey");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsClassified
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsClassified");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsColumnSet
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsColumnSet");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsColumnSet", value);
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsDroppedLedgerColumn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDroppedLedgerColumn");
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFileStream
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFileStream");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsFileStream", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsForeignKey
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsForeignKey");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFullTextIndexed
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFullTextIndexed");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsHidden
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsHidden");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsHidden", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsMasked
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMasked");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsMasked", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsPersisted
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPersisted");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsPersisted", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsPrecise
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsPrecise");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSparse
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSparse");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSparse", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String MaskingFunction
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MaskingFunction");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MaskingFunction", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean NotForReplication
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NotForReplication");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NotForReplication", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Nullable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Nullable");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Nullable", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean RowGuidCol
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("RowGuidCol");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RowGuidCol", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(Rule),"Server[@Name = '{0}']/Database[@Name = '{1}']/Rule[@Name='{2}' and @Schema='{3}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","Rule","RuleSchema")]
		[CLSCompliant(false)]
		public System.String Rule
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Rule");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Rule", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.ReadOnlyAfterCreation |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "dbo")]
		public System.String RuleSchema
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("RuleSchema");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("RuleSchema", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityInformationTypeId
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityInformationTypeId");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SensitivityInformationTypeId", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityInformationTypeName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityInformationTypeName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SensitivityInformationTypeName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityLabelId
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityLabelId");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SensitivityLabelId", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String SensitivityLabelName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SensitivityLabelName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SensitivityLabelName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.SensitivityRank SensitivityRank
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.SensitivityRank)this.Properties.GetValueWithNullReplacement("SensitivityRank");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SensitivityRank", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 StatisticalSemantics
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("StatisticalSemantics");
			}
		}
		[SfcProperty]
		public System.String DistributionColumnName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DistributionColumnName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DistributionColumnName", value);
			}
		}
		[SfcProperty]
		public System.Boolean IsDistributedColumn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDistributedColumn");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsDistributedColumn", value);
			}
		}
		internal override string[] GetNonAlterableProperties()
		{
			return new string[] { "ColumnEncryptionKeyID", "ColumnEncryptionKeyName", "Computed", "ComputedText", "Default", "DefaultConstraintName", "DefaultSchema", "EncryptionAlgorithm", "EncryptionType", "Identity", "IdentityIncrement", "IdentityIncrementAsDecimal", "IdentitySeed", "IdentitySeedAsDecimal", "IsColumnSet", "IsFileStream", "NotForReplication", "Rule", "RuleSchema" };
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "DefaultSchema":
					return "dbo";
				case "RuleSchema":
					return "dbo";
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
