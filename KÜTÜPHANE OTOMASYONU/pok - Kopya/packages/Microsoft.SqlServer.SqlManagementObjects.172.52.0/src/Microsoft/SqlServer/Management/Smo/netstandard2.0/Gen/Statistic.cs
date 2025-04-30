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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Statistic
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Statistic  : ISfcSupportsDesignMode
	{
		public Statistic() : base(){ }
		public Statistic(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject)]
		[SfcParent("Table")]
		[SfcParent("View")]
		public SqlSmoObject Parent
		{
			get
			{
				CheckObjectState();
				return base.ParentColl.ParentInstance as SqlSmoObject;
			}
			set{SetParentImpl(value);}
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
						switch(propertyName)
						{
							case "FileGroup": return 0;
							case "FilterDefinition": return 1;
							case "HasFilter": return 2;
							case "ID": return 3;
							case "IsAutoCreated": return 4;
							case "IsFromIndexCreation": return 5;
							case "LastUpdated": return 6;
							case "NoAutomaticRecomputation": return 7;
						}
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "FileGroup": return 0;
							case "FilterDefinition": return 1;
							case "HasFilter": return 2;
							case "ID": return 3;
							case "IsAutoCreated": return 4;
							case "IsFromIndexCreation": return 5;
							case "LastUpdated": return 6;
							case "NoAutomaticRecomputation": return 7;
							case "Stream": return 8;
							case "IsAutoDropped": return 9;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "FileGroup": return 0;
						case "ID": return 1;
						case "IsAutoCreated": return 2;
						case "IsFromIndexCreation": return 3;
						case "LastUpdated": return 4;
						case "NoAutomaticRecomputation": return 5;
						case "Stream": return 6;
						case "FilterDefinition": return 7;
						case "HasFilter": return 8;
						case "PolicyHealthState": return 9;
						case "IsTemporary": return 10;
						case "IsAutoDropped": return 11;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 6, 6, 7, 10, 10, 11, 11, 11, 11, 11, 12, 12 };
			static int [] cloudVersionCount = new int [] { 9, 9, 10 };
			static int sqlDwPropertyCount = 8;
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
				new StaticMetadata("FileGroup", false, false, typeof(System.String)),
				new StaticMetadata("FilterDefinition", false, false, typeof(System.String)),
				new StaticMetadata("HasFilter", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsAutoCreated", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFromIndexCreation", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastUpdated", false, true, typeof(System.DateTime)),
				new StaticMetadata("NoAutomaticRecomputation", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] cloudStaticMetadata = 
			{
				new StaticMetadata("FileGroup", false, false, typeof(System.String)),
				new StaticMetadata("FilterDefinition", false, false, typeof(System.String)),
				new StaticMetadata("HasFilter", false, true, typeof(System.Boolean)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsAutoCreated", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFromIndexCreation", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastUpdated", false, true, typeof(System.DateTime)),
				new StaticMetadata("NoAutomaticRecomputation", false, false, typeof(System.Boolean)),
				new StaticMetadata("Stream", true, true, typeof(System.Byte[])),
				new StaticMetadata("IsAutoDropped", false, false, typeof(System.Boolean)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("FileGroup", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("IsAutoCreated", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsFromIndexCreation", false, true, typeof(System.Boolean)),
				new StaticMetadata("LastUpdated", false, true, typeof(System.DateTime)),
				new StaticMetadata("NoAutomaticRecomputation", false, false, typeof(System.Boolean)),
				new StaticMetadata("Stream", true, true, typeof(System.Byte[])),
				new StaticMetadata("FilterDefinition", false, false, typeof(System.String)),
				new StaticMetadata("HasFilter", false, true, typeof(System.Boolean)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("IsTemporary", false, true, typeof(System.Boolean)),
				new StaticMetadata("IsAutoDropped", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FileGroup
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FileGroup");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FileGroup", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String FilterDefinition
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("FilterDefinition");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("FilterDefinition", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean HasFilter
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("HasFilter");
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
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsAutoCreated
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsAutoCreated");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsAutoDropped
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsAutoDropped");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsAutoDropped", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsFromIndexCreation
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsFromIndexCreation");
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsTemporary
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsTemporary");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime LastUpdated
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("LastUpdated");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean NoAutomaticRecomputation
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NoAutomaticRecomputation");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NoAutomaticRecomputation", value);
			}
		}

      private StatisticEvents events;
      public StatisticEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new StatisticEvents(this);
              }
              return this.events;
          }
      }
    
	}

      public class StatisticEvents
      {
      internal StatisticEvents(Statistic parent)
      {
          this.parent = parent;
      }

      public ObjectEventSet GetEventSelection()
      {
          InitializeEvents();
          return (ObjectEventSet) this.serverEventsWorker.GetEventSelection();
      }

      public void SubscribeToEvents(ObjectEventSet events)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, null);
      }

      public void SubscribeToEvents(ObjectEventSet events, ServerEventHandler eventHandler)
      {
          InitializeEvents();
          this.serverEventsWorker.SubscribeToEvents(events, eventHandler);
      }

      public void UnsubscribeFromEvents(ObjectEventSet events)
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.UnsubscribeFromEvents(events);
          }
      }

      public void UnsubscribeAllEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.Dispose();
              this.serverEventsWorker = null;
          }
      }

      public void StartEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StartEvents();
          }
      }

      public void StopEvents()
      {
          if (null != this.serverEventsWorker)
          {
              this.serverEventsWorker.StopEvents();
          }
      }

      public event ServerEventHandler ServerEvent
      {
          add
          {
              InitializeEvents();
              this.serverEventsWorker.AddDefaultEventHandler(value);
          }

          remove
          {
              if (null != this.serverEventsWorker)
              {
                  this.serverEventsWorker.RemoveDefaultEventHandler(value);
              }
          }
      }

      private void InitializeEvents()
      {
          if (null == serverEventsWorker)
          {
              serverEventsWorker = new ObjectEventsWorker(parent);

          }
      }

      private ObjectEventsWorker serverEventsWorker;
      private Statistic parent;
      }
    
}
