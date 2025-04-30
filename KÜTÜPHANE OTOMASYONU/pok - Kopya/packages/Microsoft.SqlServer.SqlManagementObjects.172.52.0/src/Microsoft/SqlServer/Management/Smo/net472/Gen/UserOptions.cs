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
	/// Instance class encapsulating : Server[@Name='']/UserOption
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class UserOptions  : ISfcSupportsDesignMode
	{
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
						switch(propertyName)
						{
							case "AbortOnArithmeticErrors": return 0;
							case "AbortTransactionOnError": return 1;
							case "AnsiNullDefaultOff": return 2;
							case "AnsiNullDefaultOn": return 3;
							case "AnsiNulls": return 4;
							case "AnsiPadding": return 5;
							case "AnsiWarnings": return 6;
							case "ConcatenateNullYieldsNull": return 7;
							case "CursorCloseOnCommit": return 8;
							case "DisableDefaultConstraintCheck": return 9;
							case "IgnoreArithmeticErrors": return 10;
							case "ImplicitTransactions": return 11;
							case "NoCount": return 12;
							case "NumericRoundAbort": return 13;
							case "QuotedIdentifier": return 14;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AbortOnArithmeticErrors": return 0;
						case "AbortTransactionOnError": return 1;
						case "AnsiNullDefaultOff": return 2;
						case "AnsiNullDefaultOn": return 3;
						case "AnsiNulls": return 4;
						case "AnsiPadding": return 5;
						case "AnsiWarnings": return 6;
						case "ConcatenateNullYieldsNull": return 7;
						case "CursorCloseOnCommit": return 8;
						case "DisableDefaultConstraintCheck": return 9;
						case "IgnoreArithmeticErrors": return 10;
						case "ImplicitTransactions": return 11;
						case "NoCount": return 12;
						case "NumericRoundAbort": return 13;
						case "QuotedIdentifier": return 14;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15 };
			static int [] cloudVersionCount = new int [] { 0, 0, 15 };
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
				new StaticMetadata("AbortOnArithmeticErrors", false, false, typeof(System.Boolean)),
				new StaticMetadata("AbortTransactionOnError", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullDefaultOff", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullDefaultOn", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNulls", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiPadding", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarnings", false, false, typeof(System.Boolean)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("CursorCloseOnCommit", false, false, typeof(System.Boolean)),
				new StaticMetadata("DisableDefaultConstraintCheck", false, false, typeof(System.Boolean)),
				new StaticMetadata("IgnoreArithmeticErrors", false, false, typeof(System.Boolean)),
				new StaticMetadata("ImplicitTransactions", false, false, typeof(System.Boolean)),
				new StaticMetadata("NoCount", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericRoundAbort", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifier", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AbortOnArithmeticErrors", false, false, typeof(System.Boolean)),
				new StaticMetadata("AbortTransactionOnError", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullDefaultOff", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNullDefaultOn", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiNulls", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiPadding", false, false, typeof(System.Boolean)),
				new StaticMetadata("AnsiWarnings", false, false, typeof(System.Boolean)),
				new StaticMetadata("ConcatenateNullYieldsNull", false, false, typeof(System.Boolean)),
				new StaticMetadata("CursorCloseOnCommit", false, false, typeof(System.Boolean)),
				new StaticMetadata("DisableDefaultConstraintCheck", false, false, typeof(System.Boolean)),
				new StaticMetadata("IgnoreArithmeticErrors", false, false, typeof(System.Boolean)),
				new StaticMetadata("ImplicitTransactions", false, false, typeof(System.Boolean)),
				new StaticMetadata("NoCount", false, false, typeof(System.Boolean)),
				new StaticMetadata("NumericRoundAbort", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifier", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean AbortOnArithmeticErrors
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AbortOnArithmeticErrors");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AbortOnArithmeticErrors", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean AbortTransactionOnError
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AbortTransactionOnError");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AbortTransactionOnError", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean AnsiNullDefaultOff
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullDefaultOff");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullDefaultOff", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean AnsiNullDefaultOn
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullDefaultOn");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullDefaultOn", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean AnsiNulls
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNulls");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNulls", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean AnsiPadding
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiPadding");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiPadding", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean AnsiWarnings
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiWarnings");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiWarnings", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean ConcatenateNullYieldsNull
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ConcatenateNullYieldsNull");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ConcatenateNullYieldsNull", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean CursorCloseOnCommit
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("CursorCloseOnCommit");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("CursorCloseOnCommit", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean DisableDefaultConstraintCheck
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("DisableDefaultConstraintCheck");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DisableDefaultConstraintCheck", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean IgnoreArithmeticErrors
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IgnoreArithmeticErrors");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IgnoreArithmeticErrors", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean ImplicitTransactions
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("ImplicitTransactions");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ImplicitTransactions", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean NoCount
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NoCount");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NoCount", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "false")]
		public System.Boolean NumericRoundAbort
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NumericRoundAbort");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NumericRoundAbort", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone, "true")]
		public System.Boolean QuotedIdentifier
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("QuotedIdentifier");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QuotedIdentifier", value);
			}
		}
		internal override object GetPropertyDefaultValue(string propname)
		{
			switch (propname)
			{
				case "AbortOnArithmeticErrors":
					return false;
				case "AbortTransactionOnError":
					return false;
				case "AnsiNullDefaultOff":
					return false;
				case "AnsiNullDefaultOn":
					return true;
				case "AnsiNulls":
					return true;
				case "AnsiPadding":
					return true;
				case "AnsiWarnings":
					return true;
				case "ConcatenateNullYieldsNull":
					return true;
				case "CursorCloseOnCommit":
					return false;
				case "DisableDefaultConstraintCheck":
					return false;
				case "IgnoreArithmeticErrors":
					return false;
				case "ImplicitTransactions":
					return true;
				case "NoCount":
					return false;
				case "NumericRoundAbort":
					return false;
				case "QuotedIdentifier":
					return true;
				default:
					return base.GetPropertyDefaultValue(propname);
			}
		}
	}
}
