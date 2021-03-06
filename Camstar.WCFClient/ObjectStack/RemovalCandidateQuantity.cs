﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateQuantity
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
  public class RemovalCandidateQuantity : RemovalCandidate
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateQuantity_RemovalDetail")]
    protected RemovalDetailQuantity _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateQuantity_IssueActualHistory")]
    protected IssueActualsHistoryQuantity _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateQuantity_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;

    public override bool Equals(object obj)
    {
      return obj is RemovalCandidateQuantity && object.Equals((object) this._RemovalDetail, (object) ((RemovalCandidateQuantity) obj)._RemovalDetail) && (object.Equals((object) this._IssueActualHistory, (object) ((RemovalCandidateQuantity) obj)._IssueActualHistory) && object.Equals((object) this._IssueControl, (object) ((RemovalCandidateQuantity) obj)._IssueControl)) && base.Equals(obj);
    }

    public RemovalDetailQuantity RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailQuantity) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public IssueActualsHistoryQuantity IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistoryQuantity) this.PropertyGet(nameof (IssueActualHistory));
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
