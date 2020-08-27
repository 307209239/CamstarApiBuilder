// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SessionValuesChanges_Environment
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
  public class SessionValuesChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049827, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_ServiceTypeId")]
    protected Environment _ServiceTypeId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_ObjectToChange")]
    [Metadata("Session Values are used to determine default values. An instance is associated with each User defined to the application (that can log-in). At login the values are copied for use by that session. Values can be modified during the session and saved or discarded when the session completes If they are saved, the updated values will be used for initialization at the next log-in (for that User).", "SessionValues", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1049666, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_ServiceTypeName")]
    protected Environment _ServiceTypeName;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, false, "Integer", 1048879, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_LocationIconId")]
    protected Environment _LocationIconId;
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_WorkCenter")]
    protected Environment _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_WorkCenterIconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, false, "Integer", 1048881, false, false, false, null)]
    protected Environment _WorkCenterIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_EnterpriseIconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, false, "Integer", 1048877, false, false, false, null)]
    protected Environment _EnterpriseIconId;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_Workstation")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1050517, false, false, true, null)]
    protected Environment _Workstation;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, false, "Integer", 1048878, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_FactoryIconId")]
    protected Environment _FactoryIconId;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SessionValuesChanges_Environment_Factory")]
    protected Environment _Factory;

    public Environment ServiceTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceTypeId));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceTypeName));
      }
    }

    public Environment LocationIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationIconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LocationIconId));
      }
    }

    public Environment WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Environment WorkCenterIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterIconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenterIconId));
      }
    }

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment EnterpriseIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnterpriseIconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnterpriseIconId));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
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

    public Environment Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workstation));
      }
    }

    public Environment FactoryIconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryIconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryIconId));
      }
    }

    public Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
