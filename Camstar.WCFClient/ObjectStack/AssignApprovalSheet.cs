// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignApprovalSheet
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
  public class AssignApprovalSheet : RouteApprovalSheet
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_ApprovalSheetDetails")]
    protected ApprovalSheetDetails _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_ResolutionAction")]
    protected Enumeration<ResolutionActionEnum, int> _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_CloseDescription")]
    protected Primitive<string> _CloseDescription;

    public override bool Equals(object obj)
    {
      return obj is AssignApprovalSheet && object.Equals((object) this._ApprovalSheetDetails, (object) ((AssignApprovalSheet) obj)._ApprovalSheetDetails) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((AssignApprovalSheet) obj)._ApprovalSheetTemplate) && object.Equals((object) this._QualityResolutionCode, (object) ((AssignApprovalSheet) obj)._QualityResolutionCode)) && (object.Equals((object) this._ResolutionAction, (object) ((AssignApprovalSheet) obj)._ResolutionAction) && object.Equals((object) this._CloseDescription, (object) ((AssignApprovalSheet) obj)._CloseDescription)) && base.Equals(obj);
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

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Enumeration<ResolutionActionEnum, int> ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<ResolutionActionEnum, int>) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
