// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeStatusTxns_Info
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
  public class ChangeStatusTxns_Info : ChangeMgtTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxns_Info_Services")]
    protected ChangeStatusTxn_Info _Services;

    public ChangeStatusTxn_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ChangeStatusTxn_Info) this.PropertyGet(nameof (Services));
      }
    }
  }
}
