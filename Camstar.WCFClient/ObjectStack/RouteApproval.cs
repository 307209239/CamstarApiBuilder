// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteApproval
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
  public class RouteApproval : ApprovalTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_ApprovalSheetDetails")]
    protected ApprovalSheetDetails _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "RouteApproval_HasSpecApprovals")]
    protected Primitive<bool> _HasSpecApprovals;

    public override bool Equals(object obj)
    {
      return obj is RouteApproval && object.Equals((object) this._ApprovalSheetTemplate, (object) ((RouteApproval) obj)._ApprovalSheetTemplate) && (object.Equals((object) this._ApprovalSheetDetails, (object) ((RouteApproval) obj)._ApprovalSheetDetails) && object.Equals((object) this._HasSpecApprovals, (object) ((RouteApproval) obj)._HasSpecApprovals)) && base.Equals(obj);
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public ApprovalSheetDetails ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public Primitive<bool> HasSpecApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasSpecApprovals), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasSpecApprovals));
      }
    }
  }
}
