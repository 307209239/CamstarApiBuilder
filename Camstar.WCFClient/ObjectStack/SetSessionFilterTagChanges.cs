// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetSessionFilterTagChanges
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
  public class SetSessionFilterTagChanges : EmployeeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_PrimaryOrganization")]
    protected new NamedObjectRef _PrimaryOrganization;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_ESigRoleGroup")]
    protected new NamedObjectRef _ESigRoleGroup;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_WebMenuDefinition")]
    protected new NamedObjectRef _WebMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_HistoryView")]
    protected new NamedObjectRef _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_SessionValues")]
    protected new SessionValuesChanges _SessionValues;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_MenuDefinition")]
    protected new NamedObjectRef _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_TrainingPlan")]
    protected new NamedObjectRef _TrainingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_EmailAddress")]
    protected new Primitive<string> _EmailAddress;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_ChangeHistory")]
    protected new ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_TerminologyDictionary")]
    protected new NamedObjectRef _TerminologyDictionary;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_LanguageDictionary")]
    protected new NamedObjectRef _LanguageDictionary;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_DocManagerUser")]
    protected new Primitive<string> _DocManagerUser;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_DocManagerPassword")]
    protected new PasswordFieldType _DocManagerPassword;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_WebDrillDownMenuDefinition")]
    protected new NamedObjectRef _WebDrillDownMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_UserProfile")]
    protected new UserProfileChanges _UserProfile;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_UIPortalProfile")]
    protected new UIPortalProfileChanges _UIPortalProfile;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_FilterTagAccess")]
    protected new Enumeration<FilterTagAccessEnum, int> _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_FilterTagsSession")]
    protected new Primitive<string> _FilterTagsSession;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Roles")]
    protected new EmployeeRoleChanges[] _Roles;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_AttachDocumentDetails")]
    protected new Camstar.WCF.ObjectStack.AttachDocumentDetails[] _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_PortalMenuDefinition")]
    protected new NamedObjectRef _PortalMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_PortalMobileMenuDefinition")]
    protected new NamedObjectRef _PortalMobileMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_UseROR")]
    protected new Primitive<bool>[] _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_IsNDO")]
    protected new Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_IsContainer")]
    protected new Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_AllowOverrideOfSessionValues")]
    protected new Primitive<bool> _AllowOverrideOfSessionValues;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_ModelerAccess")]
    protected new Primitive<bool> _ModelerAccess;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_IsRDO")]
    protected new Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_CanLogin")]
    protected new Primitive<bool> _CanLogin;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_AttachAsRORProxy")]
    protected new Primitive<bool>[] _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_UseRORProxy")]
    protected new Primitive<bool>[] _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_FullName")]
    protected new Primitive<string> _FullName;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_UserComment")]
    protected new Primitive<string> _UserComment;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_EscalationRecipients")]
    protected new NamedObjectRef[] _EscalationRecipients;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_DomainName")]
    protected new Primitive<string> _DomainName;

    public override bool Equals(object obj)
    {
      return obj is SetSessionFilterTagChanges && object.Equals((object) this._PrimaryOrganization, (object) ((SetSessionFilterTagChanges) obj)._PrimaryOrganization) && (object.Equals((object) this._ESigRoleGroup, (object) ((SetSessionFilterTagChanges) obj)._ESigRoleGroup) && object.Equals((object) this._WebMenuDefinition, (object) ((SetSessionFilterTagChanges) obj)._WebMenuDefinition)) && (object.Equals((object) this._HistoryView, (object) ((SetSessionFilterTagChanges) obj)._HistoryView) && object.Equals((object) this._SessionValues, (object) ((SetSessionFilterTagChanges) obj)._SessionValues) && (object.Equals((object) this._MenuDefinition, (object) ((SetSessionFilterTagChanges) obj)._MenuDefinition) && object.Equals((object) this._TrainingPlan, (object) ((SetSessionFilterTagChanges) obj)._TrainingPlan))) && (object.Equals((object) this._EmailAddress, (object) ((SetSessionFilterTagChanges) obj)._EmailAddress) && object.Equals((object) this._ChangeHistory, (object) ((SetSessionFilterTagChanges) obj)._ChangeHistory) && (object.Equals((object) this._TerminologyDictionary, (object) ((SetSessionFilterTagChanges) obj)._TerminologyDictionary) && object.Equals((object) this._LanguageDictionary, (object) ((SetSessionFilterTagChanges) obj)._LanguageDictionary)) && (object.Equals((object) this._DocManagerUser, (object) ((SetSessionFilterTagChanges) obj)._DocManagerUser) && object.Equals((object) this._DocManagerPassword, (object) ((SetSessionFilterTagChanges) obj)._DocManagerPassword) && (object.Equals((object) this._WebDrillDownMenuDefinition, (object) ((SetSessionFilterTagChanges) obj)._WebDrillDownMenuDefinition) && object.Equals((object) this._UserProfile, (object) ((SetSessionFilterTagChanges) obj)._UserProfile)))) && (object.Equals((object) this._UIPortalProfile, (object) ((SetSessionFilterTagChanges) obj)._UIPortalProfile) && object.Equals((object) this._FilterTagAccess, (object) ((SetSessionFilterTagChanges) obj)._FilterTagAccess) && (object.Equals((object) this._FilterTagsSession, (object) ((SetSessionFilterTagChanges) obj)._FilterTagsSession) && this.CompareArrays((Array) this._Roles, (Array) ((SetSessionFilterTagChanges) obj)._Roles)) && (object.Equals((object) this._FilterTags, (object) ((SetSessionFilterTagChanges) obj)._FilterTags) && this.CompareArrays((Array) this._AttachDocumentDetails, (Array) ((SetSessionFilterTagChanges) obj)._AttachDocumentDetails) && (object.Equals((object) this._PortalMenuDefinition, (object) ((SetSessionFilterTagChanges) obj)._PortalMenuDefinition) && object.Equals((object) this._PortalMobileMenuDefinition, (object) ((SetSessionFilterTagChanges) obj)._PortalMobileMenuDefinition))) && (this.CompareArrays((Array) this._UseROR, (Array) ((SetSessionFilterTagChanges) obj)._UseROR) && object.Equals((object) this._IsNDO, (object) ((SetSessionFilterTagChanges) obj)._IsNDO) && (object.Equals((object) this._IsContainer, (object) ((SetSessionFilterTagChanges) obj)._IsContainer) && object.Equals((object) this._AllowOverrideOfSessionValues, (object) ((SetSessionFilterTagChanges) obj)._AllowOverrideOfSessionValues)) && (object.Equals((object) this._InstanceLocked, (object) ((SetSessionFilterTagChanges) obj)._InstanceLocked) && object.Equals((object) this._ModelerAccess, (object) ((SetSessionFilterTagChanges) obj)._ModelerAccess) && (object.Equals((object) this._IsRDO, (object) ((SetSessionFilterTagChanges) obj)._IsRDO) && object.Equals((object) this._CanLogin, (object) ((SetSessionFilterTagChanges) obj)._CanLogin))))) && (this.CompareArrays((Array) this._AttachAsRORProxy, (Array) ((SetSessionFilterTagChanges) obj)._AttachAsRORProxy) && object.Equals((object) this._AssociatedPackages, (object) ((SetSessionFilterTagChanges) obj)._AssociatedPackages) && (this.CompareArrays((Array) this._UseRORProxy, (Array) ((SetSessionFilterTagChanges) obj)._UseRORProxy) && object.Equals((object) this._Description, (object) ((SetSessionFilterTagChanges) obj)._Description)) && (object.Equals((object) this._IsFrozen, (object) ((SetSessionFilterTagChanges) obj)._IsFrozen) && object.Equals((object) this._FullName, (object) ((SetSessionFilterTagChanges) obj)._FullName) && (object.Equals((object) this._Notes, (object) ((SetSessionFilterTagChanges) obj)._Notes) && object.Equals((object) this._ObjectToChange, (object) ((SetSessionFilterTagChanges) obj)._ObjectToChange))) && (object.Equals((object) this._UserComment, (object) ((SetSessionFilterTagChanges) obj)._UserComment) && object.Equals((object) this._IconId, (object) ((SetSessionFilterTagChanges) obj)._IconId) && (this.CompareArrays((Array) this._EscalationRecipients, (Array) ((SetSessionFilterTagChanges) obj)._EscalationRecipients) && object.Equals((object) this._Name, (object) ((SetSessionFilterTagChanges) obj)._Name)) && object.Equals((object) this._DomainName, (object) ((SetSessionFilterTagChanges) obj)._DomainName))) && base.Equals(obj);
    }

    public new NamedObjectRef PrimaryOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrimaryOrganization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrimaryOrganization));
      }
    }

    public new NamedObjectRef ESigRoleGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRoleGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRoleGroup));
      }
    }

    public new NamedObjectRef WebMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebMenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WebMenuDefinition));
      }
    }

    public new NamedObjectRef HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HistoryView));
      }
    }

    public new SessionValuesChanges SessionValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (SessionValues), (object) value);
      }
      get
      {
        return (SessionValuesChanges) this.PropertyGet(nameof (SessionValues));
      }
    }

    public new NamedObjectRef MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public new NamedObjectRef TrainingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingPlan), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingPlan));
      }
    }

    public new Primitive<string> EmailAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailAddress), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EmailAddress));
      }
    }

    public new ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new NamedObjectRef TerminologyDictionary
    {
      [param: In] set
      {
        this.PropertySet(nameof (TerminologyDictionary), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TerminologyDictionary));
      }
    }

    public new NamedObjectRef LanguageDictionary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LanguageDictionary), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LanguageDictionary));
      }
    }

    public new Primitive<string> DocManagerUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocManagerUser), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocManagerUser));
      }
    }

    public new PasswordFieldType DocManagerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocManagerPassword), (object) value);
      }
      get
      {
        return (PasswordFieldType) this.PropertyGet(nameof (DocManagerPassword));
      }
    }

    public new NamedObjectRef WebDrillDownMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebDrillDownMenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WebDrillDownMenuDefinition));
      }
    }

    public new UserProfileChanges UserProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserProfile), (object) value);
      }
      get
      {
        return (UserProfileChanges) this.PropertyGet(nameof (UserProfile));
      }
    }

    public new UIPortalProfileChanges UIPortalProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPortalProfile), (object) value);
      }
      get
      {
        return (UIPortalProfileChanges) this.PropertyGet(nameof (UIPortalProfile));
      }
    }

    public new Enumeration<FilterTagAccessEnum, int> FilterTagAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagAccess), (object) value);
      }
      get
      {
        return (Enumeration<FilterTagAccessEnum, int>) this.PropertyGet(nameof (FilterTagAccess));
      }
    }

    public new Primitive<string> FilterTagsSession
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagsSession), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTagsSession));
      }
    }

    public new EmployeeRoleChanges[] Roles
    {
      [param: In] set
      {
        this.PropertySet(nameof (Roles), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges[]) this.PropertyGet(nameof (Roles));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Camstar.WCF.ObjectStack.AttachDocumentDetails[] AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.AttachDocumentDetails[]) this.PropertyGet(nameof (AttachDocumentDetails));
      }
    }

    public new NamedObjectRef PortalMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalMenuDefinition));
      }
    }

    public new NamedObjectRef PortalMobileMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMobileMenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalMobileMenuDefinition));
      }
    }

    public new Primitive<bool>[] UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (UseROR));
      }
    }

    public new Primitive<bool> IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsNDO));
      }
    }

    public new Primitive<bool> IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsContainer));
      }
    }

    public new Primitive<bool> AllowOverrideOfSessionValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverrideOfSessionValues), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowOverrideOfSessionValues));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Primitive<bool> ModelerAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelerAccess), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ModelerAccess));
      }
    }

    public new Primitive<bool> IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRDO));
      }
    }

    public new Primitive<bool> CanLogin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CanLogin), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CanLogin));
      }
    }

    public new Primitive<bool>[] AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Primitive<bool>[] UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<string> FullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FullName));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> UserComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserComment));
      }
    }

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public new NamedObjectRef[] EscalationRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationRecipients), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (EscalationRecipients));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<string> DomainName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DomainName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DomainName));
      }
    }
  }
}
