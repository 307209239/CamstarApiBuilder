// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateStock_Environment
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
  public class RemovalCandidateStock_Environment : RemovalCandidate_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_Environment_RemovalDetail")]
    [Metadata("Specifies the stock point to which the removed components are returned.", "RemovalDetailStock", false, false, false, "RemovalDetailStock", 1049873, false, false, false, null)]
    protected RemovalDetailStock_Environment _RemovalDetail;
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type stock.", "IssueActualsHistoryStock", false, false, false, "IssueActualsHistoryStock", 1049872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_Environment_IssueActualHistory")]
    protected IssueActualsHistoryStock_Environment _IssueActualHistory;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, true, "4")]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_Environment_IssueControl")]
    protected new Environment _IssueControl;

    public RemovalDetailStock_Environment RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailStock_Environment) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public IssueActualsHistoryStock_Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryStock_Environment) this.PropertyGet(nameof (IssueActualHistory));
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
