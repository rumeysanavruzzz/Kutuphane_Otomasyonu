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
	/// Instance class encapsulating : Server[@Name='']/Database/DdlTrigger
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class DatabaseDdlTrigger  : ISfcSupportsDesignMode
	{
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
							case "AnsiNullsStatus": return 0;
							case "BodyStartIndex": return 1;
							case "CreateDate": return 2;
							case "DateLastModified": return 3;
							case "DdlTriggerEvents": return 4;
							case "ExecutionContext": return 5;
							case "ExecutionContextUser": return 6;
							case "ID": return 7;
							case "ImplementationType": return 8;
							case "IsEnabled": return 9;
							case "IsEncrypted": return 10;
							case "IsSystemObject": return 11;
							case "NotForReplication": return 12;
							case "QuotedIdentifierStatus": return 13;
							case "Text": return 14;
							case "AssemblyName": return 15;
							case "ClassName": return 16;
							case "MethodName": return 17;
						}
						return -1;
					}
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
						case "DateLastModified": return 5;
						case "DdlTriggerEvents": return 6;
						case "ExecutionContext": return 7;
						case "ExecutionContextUser": return 8;
						case "ID": return 9;
						case "ImplementationType": return 10;
						case "IsEnabled": return 11;
						case "IsEncrypted": return 12;
						case "IsSystemObject": return 13;
						case "MethodName": return 14;
						case "NotForReplication": return 15;
						case "QuotedIdentifierStatus": return 16;
						case "Text": return 17;
						case "PolicyHealthState": return 18;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 18, 19, 19, 19, 19, 19, 19, 19, 19, 19 };
			static int [] cloudVersionCount = new int [] { 15, 15, 18 };
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
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DdlTriggerEvents", true, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseDdlTriggerEventSet)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseDdlTriggerExecutionContext)),
				new StaticMetadata("ExecutionContextUser", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("DdlTriggerEvents", true, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseDdlTriggerEventSet)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.DatabaseDdlTriggerExecutionContext)),
				new StaticMetadata("ExecutionContextUser", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 BodyStartIndex
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("BodyStartIndex");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.DatabaseDdlTriggerExecutionContext ExecutionContext
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.DatabaseDdlTriggerExecutionContext)this.Properties.GetValueWithNullReplacement("ExecutionContext");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContext", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.ConnectionContext.TrueName","Parent.Name","ExecutionContextUser")]
		[CLSCompliant(false)]
		public System.String ExecutionContextUser
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ExecutionContextUser");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContextUser", value);
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Expensive |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Text
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Text");
			}
		}
	}
}
