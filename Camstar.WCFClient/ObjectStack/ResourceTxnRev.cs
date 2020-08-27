// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceTxnRev
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
  public class ResourceTxnRev : ResourceTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxnRev_HistoryCDOs")]
    protected BaseObjectRef[] _HistoryCDOs;

    public override bool Equals(object obj)
    {
      return obj is ResourceTxnRev && this.CompareArrays((Array) this._HistoryCDOs, (Array) ((ResourceTxnRev) obj)._HistoryCDOs) && base.Equals(obj);
    }

    public BaseObjectRef[] HistoryCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryCDOs), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (HistoryCDOs));
      }
    }
  }
}
