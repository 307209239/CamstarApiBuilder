// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsLotStock
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
  public class ActualsLotStock : IssueActuals
  {
    [DataMember(EmitDefaultValue = false, Name = "ActualsLotStock_FromStockPoint")]
    protected Primitive<string> _FromStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ActualsLotStock_FromLot")]
    protected Primitive<string> _FromLot;

    public override bool Equals(object obj)
    {
      return obj is ActualsLotStock && object.Equals((object) this._FromStockPoint, (object) ((ActualsLotStock) obj)._FromStockPoint) && object.Equals((object) this._FromLot, (object) ((ActualsLotStock) obj)._FromLot) && base.Equals(obj);
    }

    public Primitive<string> FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromStockPoint));
      }
    }

    public Primitive<string> FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromLot));
      }
    }
  }
}
