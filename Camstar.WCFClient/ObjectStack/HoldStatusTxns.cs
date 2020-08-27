// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldStatusTxns
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
  public class HoldStatusTxns : ContainersTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxns_Services")]
    protected HoldStatusTxn[] _Services;

    public override bool Equals(object obj)
    {
      return obj is HoldStatusTxns && this.CompareArrays((Array) this._Services, (Array) ((HoldStatusTxns) obj)._Services) && base.Equals(obj);
    }

    public HoldStatusTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (HoldStatusTxn[]) this.PropertyGet(nameof (Services));
      }
    }
  }
}
