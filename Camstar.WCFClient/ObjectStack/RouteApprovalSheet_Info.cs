// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteApprovalSheet_Info
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
  public class RouteApprovalSheet_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteApprovalSheet_Info_ProcessObjectDetails")]
    protected ProcessObject_Info _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "RouteApprovalSheet_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;

    public ProcessObject_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
      }
    }
  }
}
