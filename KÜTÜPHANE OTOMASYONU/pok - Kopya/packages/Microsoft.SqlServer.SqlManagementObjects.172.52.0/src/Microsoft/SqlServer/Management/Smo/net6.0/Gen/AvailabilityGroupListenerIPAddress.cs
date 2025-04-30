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
	/// Instance class encapsulating : Server[@Name='']/AvailabilityGroup/AvailabilityGroupListener/AvailabilityGroupListenerIPAddress
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone )]
	public sealed partial class AvailabilityGroupListenerIPAddress 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public AvailabilityGroupListener Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as AvailabilityGroupListener;
			}
			set{SetParentImpl(value);}
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
						case "IPAddress": return 0;
						case "IPAddressState": return 1;
						case "IPAddressStateDescription": return 2;
						case "IsDHCP": return 3;
						case "SubnetIP": return 4;
						case "SubnetIPv4Mask": return 5;
						case "SubnetMask": return 6;
						case "SubnetPrefixLength": return 7;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 0, 0, 0, 0, 0, 8, 8, 8, 8, 8, 8, 8 };
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
				new StaticMetadata("IPAddress", false, false, typeof(System.String)),
				new StaticMetadata("IPAddressState", false, true, typeof(Microsoft.SqlServer.Management.Smo.AvailabilityGroupListenerIPState)),
				new StaticMetadata("IPAddressStateDescription", false, true, typeof(System.String)),
				new StaticMetadata("IsDHCP", false, false, typeof(System.Boolean)),
				new StaticMetadata("SubnetIP", false, false, typeof(System.String)),
				new StaticMetadata("SubnetIPv4Mask", false, true, typeof(System.String)),
				new StaticMetadata("SubnetMask", false, false, typeof(System.String)),
				new StaticMetadata("SubnetPrefixLength", false, true, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.AvailabilityGroupListenerIPState IPAddressState
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.AvailabilityGroupListenerIPState)this.Properties.GetValueWithNullReplacement("IPAddressState");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.String IPAddressStateDescription
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("IPAddressStateDescription");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IsDHCP
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsDHCP");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsDHCP", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone, "string.empty")]
		public System.String SubnetIPv4Mask
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("SubnetIPv4Mask");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Int32 SubnetPrefixLength
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("SubnetPrefixLength");
			}
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "IsDHCP":
					return false;
				case "SubnetIP":
					return "string.empty";
				case "SubnetIPv4Mask":
					return "string.empty";
				case "SubnetMask":
					return "string.empty";
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
