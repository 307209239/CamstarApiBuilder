// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeChanges
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
  public class EmployeeChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_ChangeHistory")]
    protected new ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_SessionValues")]
    protected SessionValuesChanges _SessionValues;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_DocManagerUser")]
    protected Primitive<string> _DocManagerUser;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_LanguageDictionary")]
    protected NamedObjectRef _LanguageDictionary;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_ESigRoleGroup")]
    protected NamedObjectRef _ESigRoleGroup;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_TerminologyDictionary")]
    protected NamedObjectRef _TerminologyDictionary;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_EmailAddress")]
    protected Primitive<string> _EmailAddress;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_MenuDefinition")]
    protected NamedObjectRef _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_WebDrillDownMenuDefinition")]
    protected NamedObjectRef _WebDrillDownMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_WebMenuDefinition")]
    protected NamedObjectRef _WebMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_DocManagerPassword")]
    protected PasswordFieldType _DocManagerPassword;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_HistoryView")]
    protected NamedObjectRef _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_TrainingPlan")]
    protected NamedObjectRef _TrainingPlan;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_PortalMenuDefinition")]
    protected NamedObjectRef _PortalMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_UserProfile")]
    protected UserProfileChanges _UserProfile;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_AttachDocumentDetails")]
    protected new Camstar.WCF.ObjectStack.AttachDocumentDetails[] _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Roles")]
    protected EmployeeRoleChanges[] _Roles;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_EmployeeLoginInfo")]
    protected EmployeeLoginInfoChanges _EmployeeLoginInfo;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_FilterTagAccess")]
    protected Enumeration<FilterTagAccessEnum, int> _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_PortalMobileMenuDefinition")]
    protected NamedObjectRef _PortalMobileMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_UIPortalProfile")]
    protected UIPortalProfileChanges _UIPortalProfile;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_PrimaryOrganization")]
    protected NamedObjectRef _PrimaryOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_FilterTagsSession")]
    protected Primitive<string> _FilterTagsSession;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_ModelerAccess")]
    protected Primitive<bool> _ModelerAccess;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_CanLogin")]
    protected Primitive<bool> _CanLogin;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_UseROR")]
    protected new Primitive<bool>[] _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_AttachAsRORProxy")]
    protected new Primitive<bool>[] _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_IsContainer")]
    protected new Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_UseRORProxy")]
    protected new Primitive<bool>[] _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_IsRDO")]
    protected new Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_IsNDO")]
    protected new Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_AllowOverrideOfSessionValues")]
    protected Primitive<bool> _AllowOverrideOfSessionValues;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_FullName")]
    protected Primitive<string> _FullName;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_EscalationRecipients")]
    protected NamedObjectRef[] _EscalationRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_UserComment")]
    protected Primitive<string> _UserComment;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeChanges_DomainName")]
    protected Primitive<string> _DomainName;

    public override bool Equals(object obj)
    {
      return obj is EmployeeChanges && object.Equals((object) this._ChangeHistory, (object) ((EmployeeChanges) obj)._ChangeHistory) && (object.Equals((object) this._SessionValues, (object) ((EmployeeChanges) obj)._SessionValues) && object.Equals((object) this._DocManagerUser, (object) ((EmployeeChanges) obj)._DocManagerUser)) && (object.Equals((object) this._LanguageDictionary, (object) ((EmployeeChanges) obj)._LanguageDictionary) && object.Equals((object) this._ESigRoleGroup, (object) ((EmployeeChanges) obj)._ESigRoleGroup) && (object.Equals((object) this._TerminologyDictionary, (object) ((EmployeeChanges) obj)._TerminologyDictionary) && object.Equals((object) this._EmailAddress, (object) ((EmployeeChanges) obj)._EmailAddress))) && (object.Equals((object) this._MenuDefinition, (object) ((EmployeeChanges) obj)._MenuDefinition) && object.Equals((object) this._WebDrillDownMenuDefinition, (object) ((EmployeeChanges) obj)._WebDrillDownMenuDefinition) && (object.Equals((object) this._WebMenuDefinition, (object) ((EmployeeChanges) obj)._WebMenuDefinition) && object.Equals((object) this._DocManagerPassword, (object) ((EmployeeChanges) obj)._DocManagerPassword)) && (object.Equals((object) this._HistoryView, (object) ((EmployeeChanges) obj)._HistoryView) && object.Equals((object) this._TrainingPlan, (object) ((EmployeeChanges) obj)._TrainingPlan) && (object.Equals((object) this._PortalMenuDefinition, (object) ((EmployeeChanges) obj)._PortalMenuDefinition) && object.Equals((object) this._FilterTags, (object) ((EmployeeChanges) obj)._FilterTags)))) && (object.Equals((object) this._UserProfile, (object) ((EmployeeChanges) obj)._UserProfile) && this.CompareArrays((Array) this._AttachDocumentDetails, (Array) ((EmployeeChanges) obj)._AttachDocumentDetails) && (this.CompareArrays((Array) this._Roles, (Array) ((EmployeeChanges) obj)._Roles) && object.Equals((object) this._EmployeeLoginInfo, (object) ((EmployeeChanges) obj)._EmployeeLoginInfo)) && (object.Equals((object) this._FilterTagAccess, (object) ((EmployeeChanges) obj)._FilterTagAccess) && object.Equals((object) this._PortalMobileMenuDefinition, (object) ((EmployeeChanges) obj)._PortalMobileMenuDefinition) && (object.Equals((object) this._UIPortalProfile, (object) ((EmployeeChanges) obj)._UIPortalProfile) && object.Equals((object) this._PrimaryOrganization, (object) ((EmployeeChanges) obj)._PrimaryOrganization))) && (object.Equals((object) this._FilterTagsSession, (object) ((EmployeeChanges) obj)._FilterTagsSession) && object.Equals((object) this._ModelerAccess, (object) ((EmployeeChanges) obj)._ModelerAccess) && (object.Equals((object) this._InstanceLocked, (object) ((EmployeeChanges) obj)._InstanceLocked) && object.Equals((object) this._CanLogin, (object) ((EmployeeChanges) obj)._CanLogin)) && (this.CompareArrays((Array) this._UseROR, (Array) ((EmployeeChanges) obj)._UseROR) && this.CompareArrays((Array) this._AttachAsRORProxy, (Array) ((EmployeeChanges) obj)._AttachAsRORProxy) && (object.Equals((object) this._IsContainer, (object) ((EmployeeChanges) obj)._IsContainer) && this.CompareArrays((Array) this._UseRORProxy, (Array) ((EmployeeChanges) obj)._UseRORProxy))))) && (object.Equals((object) this._IsRDO, (object) ((EmployeeChanges) obj)._IsRDO) && object.Equals((object) this._AssociatedPackages, (object) ((EmployeeChanges) obj)._AssociatedPackages) && (object.Equals((object) this._IsNDO, (object) ((EmployeeChanges) obj)._IsNDO) && object.Equals((object) this._AllowOverrideOfSessionValues, (object) ((EmployeeChanges) obj)._AllowOverrideOfSessionValues)) && (object.Equals((object) this._Name, (object) ((EmployeeChanges) obj)._Name) && object.Equals((object) this._ObjectToChange, (object) ((EmployeeChanges) obj)._ObjectToChange) && (object.Equals((object) this._Notes, (object) ((EmployeeChanges) obj)._Notes) && object.Equals((object) this._IconId, (object) ((EmployeeChanges) obj)._IconId))) && (object.Equals((object) this._IsFrozen, (object) ((EmployeeChanges) obj)._IsFrozen) && object.Equals((object) this._FullName, (object) ((EmployeeChanges) obj)._FullName) && (this.CompareArrays((Array) this._EscalationRecipients, (Array) ((EmployeeChanges) obj)._EscalationRecipients) && object.Equals((object) this._UserComment, (object) ((EmployeeChanges) obj)._UserComment)) && (object.Equals((object) this._Description, (object) ((EmployeeChanges) obj)._Description) && object.Equals((object) this._DomainName, (object) ((EmployeeChanges) obj)._DomainName)))) && base.Equals(obj);
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

    public SessionValuesChanges SessionValues
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

    public Primitive<string> DocManagerUser
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

    public NamedObjectRef LanguageDictionary
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

    public NamedObjectRef ESigRoleGroup
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

    public NamedObjectRef TerminologyDictionary
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

    public Primitive<string> EmailAddress
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

    public NamedObjectRef MenuDefinition
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

    public NamedObjectRef WebDrillDownMenuDefinition
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

    public NamedObjectRef WebMenuDefinition
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

    public PasswordFieldType DocManagerPassword
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

    public NamedObjectRef HistoryView
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

    public NamedObjectRef TrainingPlan
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

    public NamedObjectRef PortalMenuDefinition
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

    public UserProfileChanges UserProfile
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

    public EmployeeRoleChanges[] Roles
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

    public EmployeeLoginInfoChanges EmployeeLoginInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeLoginInfo), (object) value);
      }
      get
      {
        return (EmployeeLoginInfoChanges) this.PropertyGet(nameof (EmployeeLoginInfo));
      }
    }

    public Enumeration<FilterTagAccessEnum, int> FilterTagAccess
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

    public NamedObjectRef PortalMobileMenuDefinition
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

    public UIPortalProfileChanges UIPortalProfile
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

    public NamedObjectRef PrimaryOrganization
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

    public Primitive<string> FilterTagsSession
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

    public Primitive<bool> ModelerAccess
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

    public Primitive<bool> CanLogin
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

    public Primitive<bool> AllowOverrideOfSessionValues
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

    public Primitive<string> FullName
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

    public NamedObjectRef[] EscalationRecipients
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

    public Primitive<string> UserComment
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

    public Primitive<string> DomainName
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
