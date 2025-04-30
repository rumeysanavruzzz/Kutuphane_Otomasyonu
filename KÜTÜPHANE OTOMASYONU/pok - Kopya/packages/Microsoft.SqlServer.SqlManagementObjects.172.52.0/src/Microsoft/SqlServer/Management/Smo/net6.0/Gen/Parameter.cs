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
	/// Instance class encapsulating : Server[@Name='']/Database/UserDefinedFunction/Param
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public   class Parameter  : ParameterBase, ISfcSupportsDesignMode
	{
		internal Parameter(AbstractCollectionBase parent, ObjectKeyBase key, SqlSmoState state) :
		base(parent, key, state)
		{
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
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DefaultValue
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DefaultValue");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DefaultValue", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 ID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("ID");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsReadOnly
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsReadOnly");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsReadOnly", value);
			}
		}

		protected Parameter() : 
			base() 
		{
		}
		
	}

}
