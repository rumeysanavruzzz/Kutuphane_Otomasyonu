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
	/// Instance class encapsulating : Server[@Name='']/Endpoint/Http
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class HttpProtocol 
	{
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
						case "AuthenticationRealm": return 0;
						case "ClearPort": return 1;
						case "DefaultLogonDomain": return 2;
						case "HttpAuthenticationModes": return 3;
						case "HttpPortTypes": return 4;
						case "IsCompressionEnabled": return 5;
						case "IsSystemObject": return 6;
						case "SslPort": return 7;
						case "WebSite": return 8;
						case "WebSiteUrlPath": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
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
				new StaticMetadata("AuthenticationRealm", false, false, typeof(System.String)),
				new StaticMetadata("ClearPort", false, false, typeof(System.Int32)),
				new StaticMetadata("DefaultLogonDomain", false, false, typeof(System.String)),
				new StaticMetadata("HttpAuthenticationModes", false, false, typeof(Microsoft.SqlServer.Management.Smo.HttpAuthenticationModes)),
				new StaticMetadata("HttpPortTypes", false, false, typeof(Microsoft.SqlServer.Management.Smo.HttpPortTypes)),
				new StaticMetadata("IsCompressionEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("SslPort", false, false, typeof(System.Int32)),
				new StaticMetadata("WebSite", false, false, typeof(System.String)),
				new StaticMetadata("WebSiteUrlPath", false, false, typeof(System.String)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String AuthenticationRealm
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AuthenticationRealm");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AuthenticationRealm", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 ClearPort
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ClearPort");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ClearPort", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String DefaultLogonDomain
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultLogonDomain");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultLogonDomain", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.HttpAuthenticationModes HttpAuthenticationModes
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.HttpAuthenticationModes)this.Properties.GetValueWithNullReplacement("HttpAuthenticationModes");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HttpAuthenticationModes", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.HttpPortTypes HttpPortTypes
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.HttpPortTypes)this.Properties.GetValueWithNullReplacement("HttpPortTypes");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("HttpPortTypes", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsCompressionEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsCompressionEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsCompressionEnabled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 SslPort
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("SslPort");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("SslPort", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String WebSite
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WebSite");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WebSite", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String WebSiteUrlPath
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("WebSiteUrlPath");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("WebSiteUrlPath", value);
			}
		}
	}
}
