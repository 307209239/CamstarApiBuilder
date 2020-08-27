// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailLotStock
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
  public class RemovalHistoryDetailLotStock : RemovalHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailLotStock_IssueActualsHistory")]
    protected new SubentityRef _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailLotStock_DestinationLot")]
    protected Primitive<string> _DestinationLot;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailLotStock_DestinationStockPoint")]
    protected Primitive<string> _DestinationStockPoint;

    public override bool Equals(object obj)
    {
      return obj is RemovalHistoryDetailLotStock && object.Equals((object) this._IssueActualsHistory, (object) ((RemovalHistoryDetailLotStock) obj)._IssueActualsHistory) && (object.Equals((object) this._DestinationLot, (object) ((RemovalHistoryDetailLotStock) obj)._DestinationLot) && object.Equals((object) this._DestinationStockPoint, (object) ((RemovalHistoryDetailLotStock) obj)._DestinationStockPoint)) && base.Equals(obj);
    }

    public new SubentityRef IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Primitive<string> DestinationLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DestinationLot));
      }
    }

    public Primitive<string> DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }
  }
}
