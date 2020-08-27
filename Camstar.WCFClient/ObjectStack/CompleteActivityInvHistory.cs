// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityInvHistory
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
  public class CompleteActivityInvHistory : CompleteActivityHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvHistory_HistoryDetails")]
    protected FailureDataHistoryDetails[] _HistoryDetails;

    public override bool Equals(object obj)
    {
      return obj is CompleteActivityInvHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CompleteActivityInvHistory) obj)._HistoryDetails) && base.Equals(obj);
    }

    public FailureDataHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (FailureDataHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
