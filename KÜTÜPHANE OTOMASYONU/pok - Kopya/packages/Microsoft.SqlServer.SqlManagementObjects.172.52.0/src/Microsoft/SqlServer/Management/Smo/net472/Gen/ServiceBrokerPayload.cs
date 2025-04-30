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
	/// Instance class encapsulating : Server[@Name='']/Endpoint/ServiceBroker
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class ServiceBrokerPayload 
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
						case "Certificate": return 0;
						case "EndpointAuthenticationOrder": return 1;
						case "EndpointEncryption": return 2;
						case "EndpointEncryptionAlgorithm": return 3;
						case "IsMessageForwardingEnabled": return 4;
						case "IsSystemObject": return 5;
						case "MessageForwardingSize": return 6;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
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
				new StaticMetadata("Certificate", false, false, typeof(System.String)),
				new StaticMetadata("EndpointAuthenticationOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.EndpointAuthenticationOrder)),
				new StaticMetadata("EndpointEncryption", false, false, typeof(Microsoft.SqlServer.Management.Smo.EndpointEncryption)),
				new StaticMetadata("EndpointEncryptionAlgorithm", false, false, typeof(Microsoft.SqlServer.Management.Smo.EndpointEncryptionAlgorithm)),
				new StaticMetadata("IsMessageForwardingEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("MessageForwardingSize", false, false, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String Certificate
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Certificate");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Certificate", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.EndpointAuthenticationOrder EndpointAuthenticationOrder
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.EndpointAuthenticationOrder)this.Properties.GetValueWithNullReplacement("EndpointAuthenticationOrder");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EndpointAuthenticationOrder", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.EndpointEncryption EndpointEncryption
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.EndpointEncryption)this.Properties.GetValueWithNullReplacement("EndpointEncryption");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EndpointEncryption", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.EndpointEncryptionAlgorithm EndpointEncryptionAlgorithm
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.EndpointEncryptionAlgorithm)this.Properties.GetValueWithNullReplacement("EndpointEncryptionAlgorithm");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("EndpointEncryptionAlgorithm", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsMessageForwardingEnabled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsMessageForwardingEnabled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsMessageForwardingEnabled", value);
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
		public System.Int32 MessageForwardingSize
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("MessageForwardingSize");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MessageForwardingSize", value);
			}
		}
	}
}
