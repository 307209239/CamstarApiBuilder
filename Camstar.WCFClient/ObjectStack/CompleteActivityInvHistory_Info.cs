// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityInvHistory_Info
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
  public class CompleteActivityInvHistory_Info : CompleteActivityHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvHistory_Info_HistoryDetails")]
    protected FailureDataHistoryDetails_Info _HistoryDetails;

    public FailureDataHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (FailureDataHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
