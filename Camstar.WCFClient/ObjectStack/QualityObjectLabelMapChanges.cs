// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectLabelMapChanges
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
  public class QualityObjectLabelMapChanges : LabelTxnMapChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectLabelMapChanges_TxnType")]
    protected new Primitive<int> _TxnType;

    public override bool Equals(object obj)
    {
      return obj is QualityObjectLabelMapChanges && object.Equals((object) this._TxnType, (object) ((QualityObjectLabelMapChanges) obj)._TxnType) && base.Equals(obj);
    }

    public new Primitive<int> TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnType));
      }
    }
  }
}
