// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteApproval_Environment
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
  public class RouteApproval_Environment : ApprovalTxn_Environment
  {
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051618, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_Environment_ApprovalSheetTemplate")]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_Environment_ApprovalSheetDetails")]
    [Metadata("Used to update an ApprovalSheet for a parent object", "ApprovalSheetDetails", false, false, false, "ApprovalSheetDetails", 1051619, false, false, false, null)]
    protected ApprovalSheetDetails_Environment _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_Environment_HasSpecApprovals")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777607, false, false, false, "0")]
    protected Environment _HasSpecApprovals;

    public Environment ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public ApprovalSheetDetails_Environment ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Environment) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Environment HasSpecApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasSpecApprovals), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasSpecApprovals));
      }
    }
  }
}
