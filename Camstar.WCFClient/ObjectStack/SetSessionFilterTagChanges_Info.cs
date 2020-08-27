// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetSessionFilterTagChanges_Info
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
  public class SetSessionFilterTagChanges_Info : EmployeeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_PrimaryOrganization")]
    protected new Info _PrimaryOrganization;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_ESigRoleGroup")]
    protected new Info _ESigRoleGroup;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_WebMenuDefinition")]
    protected new Info _WebMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_HistoryView")]
    protected new Info _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_SessionValues")]
    protected new SessionValuesChanges_Info _SessionValues;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_MenuDefinition")]
    protected new Info _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_TrainingPlan")]
    protected new Info _TrainingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_EmailAddress")]
    protected new Info _EmailAddress;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_ChangeHistory")]
    protected new ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_TerminologyDictionary")]
    protected new Info _TerminologyDictionary;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_LanguageDictionary")]
    protected new Info _LanguageDictionary;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_DocManagerUser")]
    protected new Info _DocManagerUser;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_DocManagerPassword")]
    protected new Info _DocManagerPassword;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_WebDrillDownMenuDefinition")]
    protected new Info _WebDrillDownMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_UserProfile")]
    protected new UserProfileChanges_Info _UserProfile;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_UIPortalProfile")]
    protected new UIPortalProfileChanges_Info _UIPortalProfile;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_FilterTagAccess")]
    protected new Info _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_FilterTagsSession")]
    protected new Info _FilterTagsSession;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_Roles")]
    protected new EmployeeRoleChanges_Info _Roles;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_AttachDocumentDetails")]
    protected new AttachDocumentDetails_Info _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_PortalMenuDefinition")]
    protected new Info _PortalMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_PortalMobileMenuDefinition")]
    protected new Info _PortalMobileMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_UseROR")]
    protected new Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_IsNDO")]
    protected new Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_IsContainer")]
    protected new Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_AllowOverrideOfSessionValues")]
    protected new Info _AllowOverrideOfSessionValues;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_ModelerAccess")]
    protected new Info _ModelerAccess;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_IsRDO")]
    protected new Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_CanLogin")]
    protected new Info _CanLogin;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_AttachAsRORProxy")]
    protected new Info _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_UseRORProxy")]
    protected new Info _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_FullName")]
    protected new Info _FullName;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_UserComment")]
    protected new Info _UserComment;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_EscalationRecipients")]
    protected new Info _EscalationRecipients;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Info_DomainName")]
    protected new Info _DomainName;

    public new Info PrimaryOrganization
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

    public new Info ESigRoleGroup
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

    public new Info WebMenuDefinition
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

    public new Info HistoryView
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

    public new SessionValuesChanges_Info SessionValues
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

    public new Info MenuDefinition
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

    public new Info TrainingPlan
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

    public new Info EmailAddress
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

    public new Info TerminologyDictionary
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

    public new Info LanguageDictionary
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

    public new Info DocManagerUser
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

    public new Info DocManagerPassword
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

    public new Info WebDrillDownMenuDefinition
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

    public new UserProfileChanges_Info UserProfile
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

    public new UIPortalProfileChanges_Info UIPortalProfile
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

    public new Info FilterTagAccess
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

    public new Info FilterTagsSession
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

    public new EmployeeRoleChanges_Info Roles
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

    public new Info PortalMenuDefinition
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

    public new Info PortalMobileMenuDefinition
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

    public new Info AllowOverrideOfSessionValues
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

    public new Info ModelerAccess
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

    public new Info CanLogin
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

    public new Info FullName
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

    public new Info UserComment
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

    public new Info EscalationRecipients
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

    public new Info DomainName
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
