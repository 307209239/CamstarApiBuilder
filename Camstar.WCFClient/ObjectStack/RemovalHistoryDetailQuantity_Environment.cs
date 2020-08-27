// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailQuantity_Environment
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
  public class RemovalHistoryDetailQuantity_Environment : RemovalHistoryDetail_Environment
  {
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type quantity only.", "IssueActualsHistoryQuantity", false, false, true, "SubentityRef", 1049765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailQuantity_Environment_IssueActualsHistory")]
    protected new Environment _IssueActualsHistory;

    public new Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }
  }
}
