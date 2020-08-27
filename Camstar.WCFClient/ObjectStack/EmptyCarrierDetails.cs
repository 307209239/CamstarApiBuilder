// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrierDetails
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
  public class EmptyCarrierDetails : LossDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierDetails_RecordAllQty")]
    protected new Primitive<bool> _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierDetails_TypeSortOrder")]
    protected new Primitive<int> _TypeSortOrder;

    public override bool Equals(object obj)
    {
      return obj is EmptyCarrierDetails && object.Equals((object) this._RecordAllQty, (object) ((EmptyCarrierDetails) obj)._RecordAllQty) && object.Equals((object) this._TypeSortOrder, (object) ((EmptyCarrierDetails) obj)._TypeSortOrder) && base.Equals(obj);
    }

    public new Primitive<bool> RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public new Primitive<int> TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TypeSortOrder));
      }
    }
  }
}
