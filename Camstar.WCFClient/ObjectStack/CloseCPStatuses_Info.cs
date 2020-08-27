// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseCPStatuses_Info
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
  public class CloseCPStatuses_Info : ChangeStatusTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CloseCPStatuses_Info_Services")]
    protected CloseCPStatus_Info _Services;

    public CloseCPStatus_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (CloseCPStatus_Info) this.PropertyGet(nameof (Services));
      }
    }
  }
}
