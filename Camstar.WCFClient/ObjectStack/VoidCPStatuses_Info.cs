// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VoidCPStatuses_Info
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
  public class VoidCPStatuses_Info : ChangeStatusTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "VoidCPStatuses_Info_Services")]
    protected VoidCPStatus_Info _Services;

    public VoidCPStatus_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (VoidCPStatus_Info) this.PropertyGet(nameof (Services));
      }
    }
  }
}
