// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryLotStock
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
  public class IssueActualsHistoryLotStock : IssueActualsHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_FromLot")]
    protected Primitive<string> _FromLot;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_FromStockPoint")]
    protected Primitive<string> _FromStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_IssuedFrom")]
    protected new Primitive<string> _IssuedFrom;

    public override bool Equals(object obj)
    {
      return obj is IssueActualsHistoryLotStock && object.Equals((object) this._FromLot, (object) ((IssueActualsHistoryLotStock) obj)._FromLot) && (object.Equals((object) this._FromStockPoint, (object) ((IssueActualsHistoryLotStock) obj)._FromStockPoint) && object.Equals((object) this._IssuedFrom, (object) ((IssueActualsHistoryLotStock) obj)._IssuedFrom)) && base.Equals(obj);
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

    public new Primitive<string> IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedFrom));
      }
    }
  }
}
