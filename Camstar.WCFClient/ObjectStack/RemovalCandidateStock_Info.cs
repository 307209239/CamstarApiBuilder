// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateStock_Info
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
  public class RemovalCandidateStock_Info : RemovalCandidate_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_Info_RemovalDetail")]
    protected RemovalDetailStock_Info _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_Info_IssueActualHistory")]
    protected IssueActualsHistoryStock_Info _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_Info_IssueControl")]
    protected new Info _IssueControl;

    public RemovalDetailStock_Info RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailStock_Info) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public IssueActualsHistoryStock_Info IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryStock_Info) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public new Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
