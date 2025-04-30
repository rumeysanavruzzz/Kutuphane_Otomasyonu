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
	/// Instance class encapsulating : Server[@Name='']/Database/ExternalLanguage/ExternalLanguageFile
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class ExternalLanguageFile  : ISfcSupportsDesignMode
	{
		public ExternalLanguageFile() : base(){ }
		public ExternalLanguageFile(ExternalLanguage externalLanguage, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = externalLanguage;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ExternalLanguage Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ExternalLanguage;
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
						case "ContentFromBinary": return 0;
						case "ContentFromFile": return 1;
						case "EnvironmentVariables": return 2;
						case "FileName": return 3;
						case "IsSystemNamed": return 4;
						case "Parameters": return 5;
						case "Platform": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 7 };
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
				new StaticMetadata("ContentFromBinary", false, false, typeof(System.Byte[])),
				new StaticMetadata("ContentFromFile", false, false, typeof(System.String)),
				new StaticMetadata("EnvironmentVariables", false, true, typeof(System.String)),
				new StaticMetadata("FileName", false, false, typeof(System.String)),
				new StaticMetadata("IsSystemNamed", false, true, typeof(System.Boolean)),
				new StaticMetadata("Parameters", false, true, typeof(System.String)),
				new StaticMetadata("Platform", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExternalLanguageFilePlatform)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Byte[] ContentFromBinary
		{
			get
			{
				return (System.Byte[])this.Properties.GetValueWithNullReplacement("ContentFromBinary");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ContentFromBinary", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String ContentFromFile
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ContentFromFile");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ContentFromFile", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String EnvironmentVariables
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("EnvironmentVariables");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String FileName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemNamed
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemNamed");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Parameters
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Parameters");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExternalLanguageFilePlatform Platform
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExternalLanguageFilePlatform)this.Properties.GetValueWithNullReplacement("Platform");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Platform", value);
			}
		}
	}
}
