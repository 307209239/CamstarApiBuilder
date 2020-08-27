// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtTxns_Info
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
  public class ChangeMgtTxns_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxns_Info_Services")]
    protected ChangeMgtTxn_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxns_Info_ChangePackages")]
    protected Info _ChangePackages;

    public ChangeMgtTxn_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ChangeMgtTxn_Info) this.PropertyGet(nameof (Services));
      }
    }

    public Info ChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackages));
      }
    }
  }
}
