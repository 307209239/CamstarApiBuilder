// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeChanges_Info
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
  public class EmployeeChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_ChangeHistory")]
    protected new ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_SessionValues")]
    protected SessionValuesChanges_Info _SessionValues;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_DocManagerUser")]
    protected Info _DocManagerUser;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_LanguageDictionary")]
    protected Info _LanguageDictionary;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_ESigRoleGroup")]
    protected Info _ESigRoleGroup;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_TerminologyDictionary")]
    protected Info _TerminologyDictionary;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_EmailAddress")]
    protected Info _EmailAddress;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_MenuDefinition")]
    protected Info _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_WebDrillDownMenuDefinition")]
    protected Info _WebDrillDownMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_WebMenuDefinition")]
    protected Info _WebMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_DocManagerPassword")]
    protected Info _DocManagerPassword;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_HistoryView")]
    protected Info _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_TrainingPlan")]
    protected Info _TrainingPlan;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_PortalMenuDefinition")]
    protected Info _PortalMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_UserProfile")]
    protected UserProfileChanges_Info _UserProfile;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_AttachDocumentDetails")]
    protected new AttachDocumentDetails_Info _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_Roles")]
    protected EmployeeRoleChanges_Info _Roles;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_EmployeeLoginInfo")]
    protected EmployeeLoginInfoChanges_Info _EmployeeLoginInfo;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_FilterTagAccess")]
    protected Info _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_PortalMobileMenuDefinition")]
    protected Info _PortalMobileMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_UIPortalProfile")]
    protected UIPortalProfileChanges_Info _UIPortalProfile;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_PrimaryOrganization")]
    protected Info _PrimaryOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_FilterTagsSession")]
    protected Info _FilterTagsSession;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_ModelerAccess")]
    protected Info _ModelerAccess;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_CanLogin")]
    protected Info _CanLogin;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_UseROR")]
    protected new Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_AttachAsRORProxy")]
    protected new Info _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_IsContainer")]
    protected new Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_UseRORProxy")]
    protected new Info _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_IsRDO")]
    protected new Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_IsNDO")]
    protected new Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_AllowOverrideOfSessionValues")]
    protected Info _AllowOverrideOfSessionValues;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_FullName")]
    protected Info _FullName;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_EscalationRecipients")]
    protected Info _EscalationRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_UserComment")]
    protected Info _UserComment;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Info_DomainName")]
    protected Info _DomainName;

    public new ChangeHistoryChanges_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public SessionValuesChanges_Info SessionValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (SessionValues), (object) value);
      }
      get
      {
        return (SessionValuesChanges_Info) this.PropertyGet(nameof (SessionValues));
      }
    }

    public Info DocManagerUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocManagerUser), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocManagerUser));
      }
    }

    public Info LanguageDictionary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LanguageDictionary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LanguageDictionary));
      }
    }

    public Info ESigRoleGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRoleGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRoleGroup));
      }
    }

    public Info TerminologyDictionary
    {
      [param: In] set
      {
        this.PropertySet(nameof (TerminologyDictionary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TerminologyDictionary));
      }
    }

    public Info EmailAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailAddress), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmailAddress));
      }
    }

    public Info MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public Info WebDrillDownMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebDrillDownMenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WebDrillDownMenuDefinition));
      }
    }

    public Info WebMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebMenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WebMenuDefinition));
      }
    }

    public Info DocManagerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocManagerPassword), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocManagerPassword));
      }
    }

    public Info HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryView));
      }
    }

    public Info TrainingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingPlan));
      }
    }

    public Info PortalMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalMenuDefinition));
      }
    }

    public new Info FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTags));
      }
    }

    public UserProfileChanges_Info UserProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserProfile), (object) value);
      }
      get
      {
        return (UserProfileChanges_Info) this.PropertyGet(nameof (UserProfile));
      }
    }

    public new AttachDocumentDetails_Info AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (AttachDocumentDetails_Info) this.PropertyGet(nameof (AttachDocumentDetails));
      }
    }

    public EmployeeRoleChanges_Info Roles
    {
      [param: In] set
      {
        this.PropertySet(nameof (Roles), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges_Info) this.PropertyGet(nameof (Roles));
      }
    }

    public EmployeeLoginInfoChanges_Info EmployeeLoginInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeLoginInfo), (object) value);
      }
      get
      {
        return (EmployeeLoginInfoChanges_Info) this.PropertyGet(nameof (EmployeeLoginInfo));
      }
    }

    public Info FilterTagAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagAccess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTagAccess));
      }
    }

    public Info PortalMobileMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMobileMenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalMobileMenuDefinition));
      }
    }

    public UIPortalProfileChanges_Info UIPortalProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPortalProfile), (object) value);
      }
      get
      {
        return (UIPortalProfileChanges_Info) this.PropertyGet(nameof (UIPortalProfile));
      }
    }

    public Info PrimaryOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrimaryOrganization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrimaryOrganization));
      }
    }

    public Info FilterTagsSession
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagsSession), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTagsSession));
      }
    }

    public Info ModelerAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelerAccess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelerAccess));
      }
    }

    public new Info InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public Info CanLogin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CanLogin), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CanLogin));
      }
    }

    public new Info UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseROR));
      }
    }

    public new Info AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public new Info IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsContainer));
      }
    }

    public new Info UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public new Info IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRDO));
      }
    }

    public new Info AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Info IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsNDO));
      }
    }

    public Info AllowOverrideOfSessionValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverrideOfSessionValues), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowOverrideOfSessionValues));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info FullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FullName));
      }
    }

    public Info EscalationRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationRecipients), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalationRecipients));
      }
    }

    public Info UserComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserComment));
      }
    }

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info DomainName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DomainName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DomainName));
      }
    }
  }
}
