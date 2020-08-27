// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateLotStock_Environment
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
  public class RemovalCandidateLotStock_Environment : RemovalCandidate_Environment
  {
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type LotStock.", "IssueActualsHistoryLotStock", false, false, false, "IssueActualsHistoryLotStock", 1049872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateLotStock_Environment_IssueActualHistory")]
    protected IssueActualsHistoryLotStock_Environment _IssueActualHistory;
    [Metadata("Specifies the lot and stock point to which the removed components are returned.", "RemovalDetailLotStock", false, false, false, "RemovalDetailLotStock", 1049873, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateLotStock_Environment_RemovalDetail")]
    protected RemovalDetailLotStock_Environment _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateLotStock_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, true, "3")]
    protected new Environment _IssueControl;

    public IssueActualsHistoryLotStock_Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryLotStock_Environment) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public RemovalDetailLotStock_Environment RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailLotStock_Environment) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
