// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignApprovalSheet_Environment
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
  public class AssignApprovalSheet_Environment : RouteApprovalSheet_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_Environment_ApprovalSheetDetails")]
    [Metadata("Used to update an ApprovalSheet for a parent object", "ApprovalSheetDetails", false, false, false, "ApprovalSheetDetails", 1051619, false, false, false, null)]
    protected ApprovalSheetDetails_Environment _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051645, false, false, true, null)]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_Environment_QualityResolutionCode")]
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, false, "NamedObjectRef", 1050494, false, false, true, null)]
    protected Environment _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_Environment_ResolutionAction")]
    [Metadata("Enumeration for the Resolution Action:\r\n1 = Close", "ResolutionActionEnum", false, false, false, "Integer", 1051644, false, false, true, "1")]
    protected Environment _ResolutionAction;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignApprovalSheet_Environment_CloseDescription")]
    protected Environment _CloseDescription;

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

    public Environment QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Environment ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Environment CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
