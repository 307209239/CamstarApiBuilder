// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeStatusTxns
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
  public class ChangeStatusTxns : ChangeMgtTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxns_Services")]
    protected ChangeStatusTxn[] _Services;

    public override bool Equals(object obj)
    {
      return obj is ChangeStatusTxns && this.CompareArrays((Array) this._Services, (Array) ((ChangeStatusTxns) obj)._Services) && base.Equals(obj);
    }

    public ChangeStatusTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ChangeStatusTxn[]) this.PropertyGet(nameof (Services));
      }
    }
  }
}
