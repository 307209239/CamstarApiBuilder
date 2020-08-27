// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusChange_Environment
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
  public class ContainerStatusChange_Environment : ContainerTxn_Environment
  {
    [Metadata("The user code for container status change reason.", "ChangeStatusReason", false, false, false, "NamedObjectRef", 1049711, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Environment_ChangeStatusReason")]
    protected Environment _ChangeStatusReason;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049124, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Environment_IncludeChildren")]
    protected Environment _IncludeChildren;

    public Environment ChangeStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatusReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangeStatusReason));
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

    public Environment IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
