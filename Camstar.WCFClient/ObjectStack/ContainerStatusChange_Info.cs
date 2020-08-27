// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusChange_Info
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
  public class ContainerStatusChange_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Info_ChangeStatusReason")]
    protected Info _ChangeStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Info_IncludeChildren")]
    protected Info _IncludeChildren;

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

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
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
