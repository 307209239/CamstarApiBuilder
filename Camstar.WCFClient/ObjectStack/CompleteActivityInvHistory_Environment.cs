// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityInvHistory_Environment
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
  public class CompleteActivityInvHistory_Environment : CompleteActivityHistory_Environment
  {
    [Metadata("FailureData History Details", "FailureDataHistoryDetails", false, false, false, "FailureDataHistoryDetails", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvHistory_Environment_HistoryDetails")]
    protected FailureDataHistoryDetails_Environment _HistoryDetails;

    public FailureDataHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (FailureDataHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
