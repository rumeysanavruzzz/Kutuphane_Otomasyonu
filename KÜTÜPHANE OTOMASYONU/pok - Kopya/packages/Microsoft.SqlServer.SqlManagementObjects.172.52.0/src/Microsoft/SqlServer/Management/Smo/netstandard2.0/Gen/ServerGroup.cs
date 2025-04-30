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

namespace Microsoft.SqlServer.Management.Smo.RegisteredServers
{
	/// <summary>
	/// Instance class encapsulating : ServerType[@ServerType='8c91a03d-f9b4-46c0-a305-b5dcc79ff907']/ServerGroup[@Path='']
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class ServerGroup 
	{
		public ServerGroup() : base(){ }
		public ServerGroup(ServerGroup serverGroup, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = serverGroup;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ServerGroup Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ServerGroup;
			}
			set{SetParentImpl(value);}
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
					case "Description": return 0;
					case "Path": return 1;
					case "ServerType": return 2;
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
				new StaticMetadata("Description", false, false, typeof(System.String)),
				new StaticMetadata("Path", false, true, typeof(System.String)),
				new StaticMetadata("ServerType", false, true, typeof(System.Guid)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Description
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Description");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Description", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Path
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Path");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Guid ServerType
		{
			get
			{
				return (System.Guid)this.Properties.GetValueWithNullReplacement("ServerType");
			}
		}
	}
}
