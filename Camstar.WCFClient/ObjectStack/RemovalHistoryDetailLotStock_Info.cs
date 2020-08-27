// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailLotStock_Info
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
  public class RemovalHistoryDetailLotStock_Info : RemovalHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailLotStock_Info_IssueActualsHistory")]
    protected new Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailLotStock_Info_DestinationLot")]
    protected Info _DestinationLot;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailLotStock_Info_DestinationStockPoint")]
    protected Info _DestinationStockPoint;

    public new Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Info DestinationLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationLot));
      }
    }

    public Info DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }
  }
}
