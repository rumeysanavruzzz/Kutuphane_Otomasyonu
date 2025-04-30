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
	/// Instance class encapsulating : Server[@Name='']/CryptographicProvider
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class CryptographicProvider  : ISfcSupportsDesignMode
	{
		public CryptographicProvider() : base(){ }
		public CryptographicProvider(Server server, string name) : base()
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
						case "AsymmetricKeyExportable": return 0;
						case "AsymmetricKeyImportable": return 1;
						case "AsymmetricKeyPersistable": return 2;
						case "AsymmetricKeySupported": return 3;
						case "AuthenticationType": return 4;
						case "DllPath": return 5;
						case "Enabled": return 6;
						case "ID": return 7;
						case "PolicyHealthState": return 8;
						case "ProviderGuid": return 9;
						case "SqlCryptographicVersionString": return 10;
						case "SymmetricKeyExportable": return 11;
						case "SymmetricKeyImportable": return 12;
						case "SymmetricKeyPersistable": return 13;
						case "SymmetricKeySupported": return 14;
						case "VersionString": return 15;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 16, 16, 16, 16, 16, 16, 16, 16, 16 };
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
				new StaticMetadata("AsymmetricKeyExportable", false, true, typeof(System.Boolean)),
				new StaticMetadata("AsymmetricKeyImportable", false, true, typeof(System.Boolean)),
				new StaticMetadata("AsymmetricKeyPersistable", false, true, typeof(System.Boolean)),
				new StaticMetadata("AsymmetricKeySupported", false, true, typeof(System.Boolean)),
				new StaticMetadata("AuthenticationType", false, true, typeof(Microsoft.SqlServer.Management.Smo.ProviderAuthenticationType)),
				new StaticMetadata("DllPath", false, false, typeof(System.String)),
				new StaticMetadata("Enabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("ProviderGuid", false, true, typeof(System.Guid)),
				new StaticMetadata("SqlCryptographicVersionString", false, true, typeof(System.String)),
				new StaticMetadata("SymmetricKeyExportable", false, true, typeof(System.Boolean)),
				new StaticMetadata("SymmetricKeyImportable", false, true, typeof(System.Boolean)),
				new StaticMetadata("SymmetricKeyPersistable", false, true, typeof(System.Boolean)),
				new StaticMetadata("SymmetricKeySupported", false, true, typeof(System.Boolean)),
				new StaticMetadata("VersionString", false, true, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AsymmetricKeyExportable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AsymmetricKeyExportable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AsymmetricKeyImportable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AsymmetricKeyImportable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AsymmetricKeyPersistable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AsymmetricKeyPersistable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean AsymmetricKeySupported
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AsymmetricKeySupported");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ProviderAuthenticationType AuthenticationType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ProviderAuthenticationType)this.Properties.GetValueWithNullReplacement("AuthenticationType");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DllPath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DllPath");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DllPath", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "true")]
		public System.Boolean Enabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Enabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Enabled", value);
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
		public System.Guid ProviderGuid
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("ProviderGuid");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SymmetricKeyExportable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SymmetricKeyExportable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SymmetricKeyImportable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SymmetricKeyImportable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SymmetricKeyPersistable
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SymmetricKeyPersistable");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean SymmetricKeySupported
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("SymmetricKeySupported");
			}
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "Enabled":
					return true;
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
