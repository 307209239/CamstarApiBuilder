// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailQuantity_Info
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
  public class RemovalHistoryDetailQuantity_Info : RemovalHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailQuantity_Info_IssueActualsHistory")]
    protected new Info _IssueActualsHistory;

    public new Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }
  }
}
