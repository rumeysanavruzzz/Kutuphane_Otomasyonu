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
	/// Instance class encapsulating : ManagedComputer[@Name='']/ClientProtocol
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class ClientProtocol 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ManagedComputer Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ManagedComputer;
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
					case "IsEnabled": return 1;
					case "NetworkLibrary": return 2;
					case "Order": return 3;
				}
				return -1;
			}
			public override int Count
			{
				get { return 4; }
			}
			public override StaticMetadata GetStaticMetadata(int id)
			{
				return staticMetadata[id];
			}
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("DisplayName", false, true, typeof(System.String)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("NetworkLibrary", false, true, typeof(System.String)),
				new StaticMetadata("Order", false, false, typeof(System.Int32)),
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String NetworkLibrary
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("NetworkLibrary");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 Order
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Order");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Order", value);
			}
		}
	}
}
