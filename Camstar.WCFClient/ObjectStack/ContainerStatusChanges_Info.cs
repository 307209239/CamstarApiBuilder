// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusChanges_Info
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
  public class ContainerStatusChanges_Info : ContainersTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Info_Services")]
    protected ContainerStatusChange_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Info_ChangeStatusReason")]
    protected Info _ChangeStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Info_IncludeChildren")]
    protected Info _IncludeChildren;

    public ContainerStatusChange_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ContainerStatusChange_Info) this.PropertyGet(nameof (Services));
      }
    }

    public Info ChangeStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatusReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangeStatusReason));
      }
    }

    public Info IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
