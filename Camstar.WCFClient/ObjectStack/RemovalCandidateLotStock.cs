// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateLotStock
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
  public class RemovalCandidateLotStock : RemovalCandidate
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateLotStock_IssueActualHistory")]
    protected IssueActualsHistoryLotStock _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateLotStock_RemovalDetail")]
    protected RemovalDetailLotStock _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateLotStock_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;

    public override bool Equals(object obj)
    {
      return obj is RemovalCandidateLotStock && object.Equals((object) this._IssueActualHistory, (object) ((RemovalCandidateLotStock) obj)._IssueActualHistory) && (object.Equals((object) this._RemovalDetail, (object) ((RemovalCandidateLotStock) obj)._RemovalDetail) && object.Equals((object) this._IssueControl, (object) ((RemovalCandidateLotStock) obj)._IssueControl)) && base.Equals(obj);
    }

    public IssueActualsHistoryLotStock IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryLotStock) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public RemovalDetailLotStock RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailLotStock) this.PropertyGet(nameof (RemovalDetail));
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
