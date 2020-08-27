// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceMaintReqChanges_Environment
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
  public class ResourceMaintReqChanges_Environment : AssignedMaintReqChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqChanges_Environment_ListItemToChange")]
    [Metadata("ResourceMaintReqChanges", "ResourceMaintReqChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("ResourceMaintReq", "ResourceMaintReq", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048825, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqChanges_Environment_Parent")]
    protected new Environment _Parent;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }
  }
}
