// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteApproval_Info
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
  public class RouteApproval_Info : ApprovalTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_Info_ApprovalSheetDetails")]
    protected ApprovalSheetDetails_Info _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_Info_HasSpecApprovals")]
    protected Info _HasSpecApprovals;

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public ApprovalSheetDetails_Info ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Info) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Info HasSpecApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasSpecApprovals), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasSpecApprovals));
      }
    }
  }
}
