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
	/// Instance class encapsulating : Server[@Name='']/Language
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Language 
	{
		[SfcObject(SfcObjectRelationship.ParentObject)]
		public Server Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as Server;
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
							case "Alias": return 0;
							case "DateFormat": return 1;
							case "Days": return 2;
							case "FirstDayOfWeek": return 3;
							case "LangID": return 4;
							case "LocaleID": return 5;
							case "Months": return 6;
							case "MsgLangID": return 7;
							case "ShortMonths": return 8;
							case "Upgrade": return 9;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "Alias": return 0;
						case "DateFormat": return 1;
						case "Days": return 2;
						case "FirstDayOfWeek": return 3;
						case "LangID": return 4;
						case "LocaleID": return 5;
						case "Months": return 6;
						case "MsgLangID": return 7;
						case "ShortMonths": return 8;
						case "Upgrade": return 9;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
			static int [] cloudVersionCount = new int [] { 0, 0, 10 };
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
				new StaticMetadata("Alias", false, true, typeof(System.String)),
				new StaticMetadata("DateFormat", false, true, typeof(System.String)),
				new StaticMetadata("Days", false, true, typeof(System.String)),
				new StaticMetadata("FirstDayOfWeek", false, true, typeof(System.Byte)),
				new StaticMetadata("LangID", false, true, typeof(System.Int16)),
				new StaticMetadata("LocaleID", false, true, typeof(System.Int32)),
				new StaticMetadata("Months", false, true, typeof(System.String)),
				new StaticMetadata("MsgLangID", false, true, typeof(System.Int16)),
				new StaticMetadata("ShortMonths", false, true, typeof(System.String)),
				new StaticMetadata("Upgrade", false, true, typeof(System.Int32)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("Alias", false, true, typeof(System.String)),
				new StaticMetadata("DateFormat", false, true, typeof(System.String)),
				new StaticMetadata("Days", false, true, typeof(System.String)),
				new StaticMetadata("FirstDayOfWeek", false, true, typeof(System.Byte)),
				new StaticMetadata("LangID", false, true, typeof(System.Int16)),
				new StaticMetadata("LocaleID", false, true, typeof(System.Int32)),
				new StaticMetadata("Months", false, true, typeof(System.String)),
				new StaticMetadata("MsgLangID", false, true, typeof(System.Int16)),
				new StaticMetadata("ShortMonths", false, true, typeof(System.String)),
				new StaticMetadata("Upgrade", false, true, typeof(System.Int32)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Alias
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Alias");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String DateFormat
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("DateFormat");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Days
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Days");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Byte FirstDayOfWeek
		{
			get
			{
				return (System.Byte)this.Properties.GetValueWithNullReplacement("FirstDayOfWeek");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int16 LangID
		{
			get
			{
				return (System.Int16)this.Properties.GetValueWithNullReplacement("LangID");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 LocaleID
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("LocaleID");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String Months
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("Months");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int16 MsgLangID
		{
			get
			{
				return (System.Int16)this.Properties.GetValueWithNullReplacement("MsgLangID");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ShortMonths
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ShortMonths");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Int32 Upgrade
		{
			get
			{
				return (System.Int32)this.Properties.GetValueWithNullReplacement("Upgrade");
			}
		}
	}
}
