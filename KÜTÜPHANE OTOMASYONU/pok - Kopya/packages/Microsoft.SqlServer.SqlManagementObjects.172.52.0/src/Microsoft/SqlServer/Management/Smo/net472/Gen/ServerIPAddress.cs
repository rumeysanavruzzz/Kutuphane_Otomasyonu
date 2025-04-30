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
	/// Instance class encapsulating : ManagedComputer[@Name='']/ServerInstance/ServerProtocol/IPAddress
	/// </summary>
	/// <inheritdoc/>
	public sealed partial class ServerIPAddress 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public ServerProtocol Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as ServerProtocol;
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
				return -1;
			}
			public override int Count
			{
				get { return 0; }
			}
			public override StaticMetadata GetStaticMetadata(int id)
			{
				return staticMetadata[id];
			}
			internal static StaticMetadata [] staticMetadata = 
			{
			};
		}
	}
}
