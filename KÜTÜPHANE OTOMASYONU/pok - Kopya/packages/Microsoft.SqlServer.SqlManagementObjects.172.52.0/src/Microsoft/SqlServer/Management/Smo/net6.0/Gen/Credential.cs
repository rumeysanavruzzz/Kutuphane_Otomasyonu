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
	/// Instance class encapsulating : Server[@Name='']/Credential
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class Credential  : ISfcSupportsDesignMode
	{
		public Credential() : base(){ }
		public Credential(Server server, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = server;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public Server Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Server;
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
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "CreateDate": return 0;
						case "DateLastModified": return 1;
						case "ID": return 2;
						case "Identity": return 3;
						case "MappedClassType": return 4;
						case "PolicyHealthState": return 5;
						case "ProviderName": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
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
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("Identity", false, false, typeof(System.String)),
				new StaticMetadata("MappedClassType", false, false, typeof(Microsoft.SqlServer.Management.Smo.MappedClassType)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("ProviderName", false, false, typeof(System.String)),
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
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
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
		public System.String Identity
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Identity");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Identity", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "None")]
		public Microsoft.SqlServer.Management.Smo.MappedClassType MappedClassType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.MappedClassType)this.Properties.GetValueWithNullReplacement("MappedClassType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MappedClassType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "string.empty")]
		[SfcReference(typeof(CryptographicProvider),"Server[@Name = '{0}']/CryptographicProvider[@Name = '{1}']","Parent.ConnectionContext.TrueName","ProviderName")]
		[CLSCompliant(false)]
		public System.String ProviderName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ProviderName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ProviderName", value);
			}
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "MappedClassType":
					return MappedClassType.None;
				case "ProviderName":
					return "string.empty";
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
