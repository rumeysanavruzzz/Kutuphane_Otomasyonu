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
	/// Instance class encapsulating : Server[@Name='']/Database/Table/Trigger
	/// </summary>
	/// <inheritdoc/>
	[SfcElement( SfcElementFlags.Standalone | SfcElementFlags.SqlAzureDatabase )]
	public sealed partial class Trigger  : ISfcSupportsDesignMode
	{
		public Trigger() : base(){ }
		public Trigger(SqlSmoObject parent, string name) : base()
		{
			ValidateName(name);
			this.key = new SimpleObjectKey(name);
			this.Parent = parent;
		}
		[SfcObject(SfcObjectRelationship.ParentObject, SfcObjectFlags.Design)]
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
						return -1;
					}
					else
					{
						switch(propertyName)
						{
							case "AnsiNullsStatus": return 0;
							case "BodyStartIndex": return 1;
							case "CreateDate": return 2;
							case "DateLastModified": return 3;
							case "Delete": return 4;
							case "DeleteOrder": return 5;
							case "ExecutionContext": return 6;
							case "ExecutionContextPrincipal": return 7;
							case "ID": return 8;
							case "ImplementationType": return 9;
							case "Insert": return 10;
							case "InsertOrder": return 11;
							case "InsteadOf": return 12;
							case "IsEnabled": return 13;
							case "IsEncrypted": return 14;
							case "IsSystemObject": return 15;
							case "NotForReplication": return 16;
							case "QuotedIdentifierStatus": return 17;
							case "Text": return 18;
							case "Update": return 19;
							case "UpdateOrder": return 20;
							case "AssemblyName": return 21;
							case "ClassName": return 22;
							case "MethodName": return 23;
						}
						return -1;
					}
				}
				else
				{
					switch(propertyName)
					{
						case "AnsiNullsStatus": return 0;
						case "BodyStartIndex": return 1;
						case "CreateDate": return 2;
						case "Delete": return 3;
						case "DeleteOrder": return 4;
						case "ID": return 5;
						case "ImplementationType": return 6;
						case "Insert": return 7;
						case "InsertOrder": return 8;
						case "InsteadOf": return 9;
						case "IsEnabled": return 10;
						case "IsEncrypted": return 11;
						case "IsSystemObject": return 12;
						case "NotForReplication": return 13;
						case "QuotedIdentifierStatus": return 14;
						case "Text": return 15;
						case "Update": return 16;
						case "UpdateOrder": return 17;
						case "AssemblyName": return 18;
						case "ClassName": return 19;
						case "DateLastModified": return 20;
						case "ExecutionContext": return 21;
						case "ExecutionContextPrincipal": return 22;
						case "MethodName": return 23;
						case "PolicyHealthState": return 24;
						case "IsNativelyCompiled": return 25;
						case "IsSchemaBound": return 26;
					}
					return -1;
				}
			}
			static int [] versionCount = new int [] { 18, 18, 24, 25, 25, 25, 25, 27, 27, 27, 27, 27 };
			static int [] cloudVersionCount = new int [] { 21, 21, 24 };
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
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("Delete", false, false, typeof(System.Boolean)),
				new StaticMetadata("DeleteOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("Insert", false, false, typeof(System.Boolean)),
				new StaticMetadata("InsertOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)),
				new StaticMetadata("InsteadOf", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("Update", false, false, typeof(System.Boolean)),
				new StaticMetadata("UpdateOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
			};
			internal static StaticMetadata [] staticMetadata = 
			{
				new StaticMetadata("AnsiNullsStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("BodyStartIndex", true, true, typeof(System.Int32)),
				new StaticMetadata("CreateDate", false, true, typeof(System.DateTime)),
				new StaticMetadata("Delete", false, false, typeof(System.Boolean)),
				new StaticMetadata("DeleteOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)),
				new StaticMetadata("ID", false, true, typeof(System.Int32)),
				new StaticMetadata("ImplementationType", false, false, typeof(Microsoft.SqlServer.Management.Smo.ImplementationType)),
				new StaticMetadata("Insert", false, false, typeof(System.Boolean)),
				new StaticMetadata("InsertOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)),
				new StaticMetadata("InsteadOf", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEnabled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsEncrypted", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSystemObject", false, true, typeof(System.Boolean)),
				new StaticMetadata("NotForReplication", false, false, typeof(System.Boolean)),
				new StaticMetadata("QuotedIdentifierStatus", false, false, typeof(System.Boolean)),
				new StaticMetadata("Text", true, true, typeof(System.String)),
				new StaticMetadata("Update", false, false, typeof(System.Boolean)),
				new StaticMetadata("UpdateOrder", false, false, typeof(Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)),
				new StaticMetadata("AssemblyName", false, false, typeof(System.String)),
				new StaticMetadata("ClassName", false, false, typeof(System.String)),
				new StaticMetadata("DateLastModified", false, true, typeof(System.DateTime)),
				new StaticMetadata("ExecutionContext", false, false, typeof(Microsoft.SqlServer.Management.Smo.ExecutionContext)),
				new StaticMetadata("ExecutionContextPrincipal", false, false, typeof(System.String)),
				new StaticMetadata("MethodName", false, false, typeof(System.String)),
				new StaticMetadata("PolicyHealthState", true, false, typeof(Microsoft.SqlServer.Management.Dmf.PolicyHealthState)),
				new StaticMetadata("IsNativelyCompiled", false, false, typeof(System.Boolean)),
				new StaticMetadata("IsSchemaBound", false, false, typeof(System.Boolean)),
			};
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean AnsiNullsStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("AnsiNullsStatus");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AnsiNullsStatus", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(SqlAssembly),"Server[@Name = '{0}']/Database[@Name = '{1}']/SqlAssembly[@Name = '{2}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","AssemblyName")]
		[CLSCompliant(false)]
		public System.String AssemblyName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("AssemblyName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("AssemblyName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String ClassName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ClassName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ClassName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime CreateDate
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("CreateDate");
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.DateTime DateLastModified
		{
			get
			{
				return (System.DateTime)this.Properties.GetValueWithNullReplacement("DateLastModified");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Delete
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Delete");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Delete", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder DeleteOrder
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)this.Properties.GetValueWithNullReplacement("DeleteOrder");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("DeleteOrder", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.ExecutionContext ExecutionContext
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ExecutionContext)this.Properties.GetValueWithNullReplacement("ExecutionContext");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContext", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		[SfcReference(typeof(User),"Server[@Name = '{0}']/Database[@Name = '{1}']/User[@Name = '{2}']","Parent.Parent.Parent.ConnectionContext.TrueName","Parent.Parent.Name","ExecutionContextPrincipal")]
		[CLSCompliant(false)]
		public System.String ExecutionContextPrincipal
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("ExecutionContextPrincipal");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ExecutionContextPrincipal", value);
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
		public Microsoft.SqlServer.Management.Smo.ImplementationType ImplementationType
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.ImplementationType)this.Properties.GetValueWithNullReplacement("ImplementationType");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("ImplementationType", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Insert
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Insert");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Insert", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder InsertOrder
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)this.Properties.GetValueWithNullReplacement("InsertOrder");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("InsertOrder", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean InsteadOf
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("InsteadOf");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("InsteadOf", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
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
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsEncrypted
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsEncrypted");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsEncrypted", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsNativelyCompiled
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsNativelyCompiled");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsNativelyCompiled", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Standalone)]
		public System.Boolean IsSchemaBound
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSchemaBound");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("IsSchemaBound", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean IsSystemObject
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("IsSystemObject");
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.String MethodName
		{
			get
			{
				return (System.String)this.Properties.GetValueWithNullReplacement("MethodName");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("MethodName", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Deploy |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean NotForReplication
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("NotForReplication");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("NotForReplication", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean QuotedIdentifierStatus
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("QuotedIdentifierStatus");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("QuotedIdentifierStatus", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public System.Boolean Update
		{
			get
			{
				return (System.Boolean)this.Properties.GetValueWithNullReplacement("Update");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("Update", value);
			}
		}
		[SfcProperty(SfcPropertyFlags.Design |SfcPropertyFlags.SqlAzureDatabase |SfcPropertyFlags.Standalone)]
		public Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder UpdateOrder
		{
			get
			{
				return (Microsoft.SqlServer.Management.Smo.Agent.ActivationOrder)this.Properties.GetValueWithNullReplacement("UpdateOrder");
			}
			set
			{
				Properties.SetValueWithConsistencyCheck("UpdateOrder", value);
			}
		}

      private TriggerEvents events;
      public TriggerEvents Events
      {
          [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
          get
          {
              if(Microsoft.SqlServer.Server.SqlContext.IsAvailable)
                  throw new SmoException(ExceptionTemplates.SmoSQLCLRUnAvailable);
              if (null == this.events)
              {
                  this.events = new TriggerEvents(this);
              }
              return this.events;
          }
      }
    
	}

      public class TriggerEvents
      {
      internal TriggerEvents(Trigger parent)
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
      private Trigger parent;
      }
    
}
