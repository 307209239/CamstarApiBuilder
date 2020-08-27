// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateStock
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
  public class RemovalCandidateStock : RemovalCandidate
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_RemovalDetail")]
    protected RemovalDetailStock _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_IssueActualHistory")]
    protected IssueActualsHistoryStock _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateStock_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;

    public override bool Equals(object obj)
    {
      return obj is RemovalCandidateStock && object.Equals((object) this._RemovalDetail, (object) ((RemovalCandidateStock) obj)._RemovalDetail) && (object.Equals((object) this._IssueActualHistory, (object) ((RemovalCandidateStock) obj)._IssueActualHistory) && object.Equals((object) this._IssueControl, (object) ((RemovalCandidateStock) obj)._IssueControl)) && base.Equals(obj);
    }

    public RemovalDetailStock RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailStock) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public IssueActualsHistoryStock IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryStock) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
