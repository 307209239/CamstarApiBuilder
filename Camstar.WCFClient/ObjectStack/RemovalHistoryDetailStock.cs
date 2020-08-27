// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailStock
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
  public class RemovalHistoryDetailStock : RemovalHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailStock_IssueActualsHistory")]
    protected new SubentityRef _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailStock_DestinationStockPoint")]
    protected Primitive<string> _DestinationStockPoint;

    public override bool Equals(object obj)
    {
      return obj is RemovalHistoryDetailStock && object.Equals((object) this._IssueActualsHistory, (object) ((RemovalHistoryDetailStock) obj)._IssueActualsHistory) && object.Equals((object) this._DestinationStockPoint, (object) ((RemovalHistoryDetailStock) obj)._DestinationStockPoint) && base.Equals(obj);
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
