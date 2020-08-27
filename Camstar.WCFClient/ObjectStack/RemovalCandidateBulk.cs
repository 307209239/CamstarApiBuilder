// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateBulk
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
  public class RemovalCandidateBulk : RemovalCandidate
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateBulk_IssueActualHistory")]
    protected IssueActualsHistoryBulk _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateBulk_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateBulk_RemovalDetail")]
    protected RemovalDetailBulk _RemovalDetail;

    public override bool Equals(object obj)
    {
      return obj is RemovalCandidateBulk && object.Equals((object) this._IssueActualHistory, (object) ((RemovalCandidateBulk) obj)._IssueActualHistory) && (object.Equals((object) this._IssueControl, (object) ((RemovalCandidateBulk) obj)._IssueControl) && object.Equals((object) this._RemovalDetail, (object) ((RemovalCandidateBulk) obj)._RemovalDetail)) && base.Equals(obj);
    }

    public IssueActualsHistoryBulk IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryBulk) this.PropertyGet(nameof (IssueActualHistory));
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

    public RemovalDetailBulk RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailBulk) this.PropertyGet(nameof (RemovalDetail));
      }
    }
  }
}
