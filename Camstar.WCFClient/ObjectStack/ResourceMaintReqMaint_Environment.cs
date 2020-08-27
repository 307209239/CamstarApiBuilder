// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceMaintReqMaint_Environment
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
  public class ResourceMaintReqMaint_Environment : AssignedMaintReqMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [Metadata("ResourceMaintReq", "ResourceMaintReq", false, false, false, "SubentityRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("ResourceMaintReqChanges", "ResourceMaintReqChanges", false, false, false, "ResourceMaintReqChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_Environment_ObjectChanges")]
    protected ResourceMaintReqChanges_Environment _ObjectChanges;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_Environment_ParentDataObject")]
    protected new Environment _ParentDataObject;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
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

    public ResourceMaintReqChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ResourceMaintReqChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
