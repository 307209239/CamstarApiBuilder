// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailQuantity
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
  public class RemovalHistoryDetailQuantity : RemovalHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailQuantity_IssueActualsHistory")]
    protected new SubentityRef _IssueActualsHistory;

    public override bool Equals(object obj)
    {
      return obj is RemovalHistoryDetailQuantity && object.Equals((object) this._IssueActualsHistory, (object) ((RemovalHistoryDetailQuantity) obj)._IssueActualsHistory) && base.Equals(obj);
    }

    public new SubentityRef IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }
  }
}
