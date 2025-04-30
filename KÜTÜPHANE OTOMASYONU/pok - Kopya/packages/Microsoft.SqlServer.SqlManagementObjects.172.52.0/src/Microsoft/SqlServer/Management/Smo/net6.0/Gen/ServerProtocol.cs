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

namespace Microsoft.SqlServer.Management.Smo.Wmi
{
	/// <summary>
	/// Instance class encapsulating : ManagedComputer[@Name='']/ServerInstance/ServerProtocol
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class ServerProtocol 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ServerInstance Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ServerInstance;
			}
		}
		internal override Smo.PropertyMetadataProvider GetPropertyMetadataProvider()
		{
			return new PropertyMetadataProvider();
		}
		internal class PropertyMetadataProvider : Smo.PropertyMetadataProvider
		{
			public override int PropertyNameToIDLookup(string propertyName)
			{
				switch(propertyName)
				{
					case "DisplayName": return 0;
					case "HasMultiIPAddresses": return 1;
					case "IsEnabled": return 2;
				}
				return -1;
			}
			public override int Count
			{
				get { return 3; }
			}
			public override StaticMetadata GetStaticMetadata(int id)
			{
				return staticMetadata[id];
			}
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DisplayName", false, true, typeof(System.String)),
				new StaticMetadata("HasMultiIPAddresses", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DisplayName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DisplayName");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasMultiIPAddresses
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasMultiIPAddresses");
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
	}
}
