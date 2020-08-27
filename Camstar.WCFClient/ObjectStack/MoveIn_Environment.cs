// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveIn_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MoveIn_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Environment_WIPMsgMgr")]
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgr", false, false, false, "WIPMsgMgr", 1048865, true, false, false, null)]
    protected new WIPMsgMgr_Environment _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Environment_ClearLocation")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049145, false, false, false, "0")]
    protected Environment _ClearLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Environment_UseDispatch")]
    protected new Environment _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Environment_Location")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    protected Environment _Location;

    public new WIPMsgMgr_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public Environment ClearLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClearLocation));
      }
    }

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public new Environment UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }
  }
}
