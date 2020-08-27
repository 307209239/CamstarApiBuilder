// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteApprovalSheet
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
  public class RouteApprovalSheet : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteApprovalSheet_ProcessObjectDetails")]
    protected ProcessObject _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "RouteApprovalSheet_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;

    public override bool Equals(object obj)
    {
      return obj is RouteApprovalSheet && object.Equals((object) this._ProcessObjectDetails, (object) ((RouteApprovalSheet) obj)._ProcessObjectDetails) && object.Equals((object) this._ApprovalSheet, (object) ((RouteApprovalSheet) obj)._ApprovalSheet) && base.Equals(obj);
    }

    public ProcessObject ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }
  }
}
