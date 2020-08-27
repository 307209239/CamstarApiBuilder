// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusChanges_Environment
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
  public class ContainerStatusChanges_Environment : ContainersTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Environment_Services")]
    [Metadata("The service used to change the status of the container", "ContainerStatusChange", false, false, false, "ContainerStatusChange", 1052702, false, true, false, null)]
    protected ContainerStatusChange_Environment _Services;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Environment_ChangeStatusReason")]
    [Metadata("The user code for container status change reason.", "ChangeStatusReason", false, false, false, "NamedObjectRef", 1049711, false, false, true, null)]
    protected Environment _ChangeStatusReason;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049124, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Environment_IncludeChildren")]
    protected Environment _IncludeChildren;

    public ContainerStatusChange_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ContainerStatusChange_Environment) this.PropertyGet(nameof (Services));
      }
    }

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
