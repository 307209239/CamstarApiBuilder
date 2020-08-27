// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceActivationDetails_Environment
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
  public class ResourceActivationDetails_Environment : MaintReqActivationDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Environment_ClassActivated")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052729, false, false, false, "0")]
    protected Environment _ClassActivated;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Environment_ResourceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049575, false, false, false, null)]
    protected Environment _ResourceName;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Environment_Resource")]
    protected Environment _Resource;

    public Environment ClassActivated
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassActivated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClassActivated));
      }
    }

    public Environment ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceName));
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
  }
}
