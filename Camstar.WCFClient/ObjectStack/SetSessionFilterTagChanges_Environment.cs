// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetSessionFilterTagChanges_Environment
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
  public class SetSessionFilterTagChanges_Environment : EmployeeChanges_Environment
  {
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051569, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_PrimaryOrganization")]
    protected new Environment _PrimaryOrganization;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_ESigRoleGroup")]
    [Metadata("The grouping mechanism used to assign multiple Roles  to an Employee.", "ESigRoleGroup", false, false, true, "NamedObjectRef", 1050333, false, false, true, null)]
    protected new Environment _ESigRoleGroup;
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface. Menu Definitions consist of a collection of predefined commands. Through the use of Menu Definitions the needs of different groups of employees can be met in a factory. For example, employees in an operation might be responsible for moving containers and collecting container parametric data, while employees in another operation might be responsible for starting and grouping containers. In both cases, they should see a different menu and therefore they would have a different Menu Definition.", "MenuDefinition", false, false, true, "NamedObjectRef", 1049667, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_WebMenuDefinition")]
    protected new Environment _WebMenuDefinition;
    [Metadata("The History View object is used to store a user configured view of the History objects.  This object is used by the Live Manufacturing Audit Trail application.", "HistoryView", false, false, true, "NamedObjectRef", 1050022, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_HistoryView")]
    protected new Environment _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_SessionValues")]
    [Metadata("Changes CDO for SessionValues.", "SessionValuesChanges", false, false, true, "SessionValuesChanges", 1048620, true, false, false, null)]
    protected new SessionValuesChanges_Environment _SessionValues;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_MenuDefinition")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface. Menu Definitions consist of a collection of predefined commands. Through the use of Menu Definitions the needs of different groups of employees can be met in a factory. For example, employees in an operation might be responsible for moving containers and collecting container parametric data, while employees in another operation might be responsible for starting and grouping containers. In both cases, they should see a different menu and therefore they would have a different Menu Definition.", "MenuDefinition", false, false, true, "NamedObjectRef", 1049393, false, false, true, null)]
    protected new Environment _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_TrainingPlan")]
    [Metadata("A training plan defines a schedule of training requirements (certifications) and target dates for when employees should be trained on the listed requirement.  Training plans can also be used as components in larger training plans.", "TrainingPlan", false, false, true, "NamedObjectRef", 1050487, false, false, true, null)]
    protected new Environment _TrainingPlan;
    [Metadata("E-mail Address", "", false, false, true, "String", 1051167, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_EmailAddress")]
    protected new Environment _EmailAddress;
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, true, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_ChangeHistory")]
    protected new ChangeHistoryChanges_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_TerminologyDictionary")]
    [Metadata("Used to store dictionary information including international language and terminology.\r\n", "Dictionary", false, false, true, "NamedObjectRef", 1049514, false, false, true, null)]
    protected new Environment _TerminologyDictionary;
    [Metadata("Used to store dictionary information including international language and terminology.\r\n", "Dictionary", false, false, true, "NamedObjectRef", 1049513, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_LanguageDictionary")]
    protected new Environment _LanguageDictionary;
    [Metadata("User Name", "", false, false, true, "String", 1049444, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_DocManagerUser")]
    protected new Environment _DocManagerUser;
    [Metadata("Password", "", false, false, true, "PasswordFieldType", 1048862, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_DocManagerPassword")]
    protected new Environment _DocManagerPassword;
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface. Menu Definitions consist of a collection of predefined commands. Through the use of Menu Definitions the needs of different groups of employees can be met in a factory. For example, employees in an operation might be responsible for moving containers and collecting container parametric data, while employees in another operation might be responsible for starting and grouping containers. In both cases, they should see a different menu and therefore they would have a different Menu Definition.", "MenuDefinition", false, false, true, "NamedObjectRef", 1049673, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_WebDrillDownMenuDefinition")]
    protected new Environment _WebDrillDownMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_UserProfile")]
    [Metadata("Session information for an employee", "UserProfileChanges", false, false, true, "UserProfileChanges", 1052561, true, false, false, null)]
    protected new UserProfileChanges_Environment _UserProfile;
    [Metadata("User preferences for Camstar Portal UI", "UIPortalProfileChanges", false, false, true, "UIPortalProfileChanges", 1051553, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_UIPortalProfile")]
    protected new UIPortalProfileChanges_Environment _UIPortalProfile;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_FilterTagAccess")]
    [Metadata("Enumeration for FilterAccessType\r\n1 = All\r\n2 = Tagged and Untagged Access\r\n3 = Tagged Access Only", "FilterTagAccessEnum", false, false, true, "Integer", 16779322, false, false, true, null)]
    protected new Environment _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_FilterTagsSession")]
    [Metadata("FilterTagsSession", "", false, false, false, "String", 16779323, false, false, false, null)]
    protected new Environment _FilterTagsSession;
    [Metadata("Employee's Role membership in an Organizational context", "EmployeeRoleChanges", false, false, true, "EmployeeRoleChanges", 1051554, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_Roles")]
    protected new EmployeeRoleChanges_Environment _Roles;
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_FilterTags")]
    protected new Environment _FilterTags;
    [Metadata("The details used to display the attached documents.", "AttachDocumentDetails", false, false, true, "AttachDocumentDetails", 16777527, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_AttachDocumentDetails")]
    protected new AttachDocumentDetails_Environment _AttachDocumentDetails;
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, true, "NamedObjectRef", 1051632, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_PortalMenuDefinition")]
    protected new Environment _PortalMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_PortalMobileMenuDefinition")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, true, "NamedObjectRef", 1051632, false, false, true, null)]
    protected new Environment _PortalMobileMenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_UseROR")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777532, false, true, false, "0")]
    protected new Environment _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_IsNDO")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777529, false, false, false, "1")]
    protected new Environment _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_IsContainer")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777528, false, false, false, "0")]
    protected new Environment _IsContainer;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049796, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_AllowOverrideOfSessionValues")]
    protected new Environment _AllowOverrideOfSessionValues;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_InstanceLocked")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    protected new Environment _InstanceLocked;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049515, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_ModelerAccess")]
    protected new Environment _ModelerAccess;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777530, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_IsRDO")]
    protected new Environment _IsRDO;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048616, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_CanLogin")]
    protected new Environment _CanLogin;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777531, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_AttachAsRORProxy")]
    protected new Environment _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_AssociatedPackages")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    protected new Environment _AssociatedPackages;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777533, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_UseRORProxy")]
    protected new Environment _UseRORProxy;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_Description")]
    protected new Environment _Description;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048617, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_FullName")]
    protected new Environment _FullName;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_Notes")]
    protected new Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_ObjectToChange")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_UserComment")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048621, false, false, false, null)]
    protected new Environment _UserComment;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_IconId")]
    protected new Environment _IconId;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778428, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_EscalationRecipients")]
    protected new Environment _EscalationRecipients;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, true, "String", 1049932, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagChanges_Environment_DomainName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049713, false, false, false, null)]
    protected new Environment _DomainName;

    public new Environment PrimaryOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrimaryOrganization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrimaryOrganization));
      }
    }

    public new Environment ESigRoleGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRoleGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRoleGroup));
      }
    }

    public new Environment WebMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebMenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WebMenuDefinition));
      }
    }

    public new Environment HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryView));
      }
    }

    public new SessionValuesChanges_Environment SessionValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (SessionValues), (object) value);
      }
      get
      {
        return (SessionValuesChanges_Environment) this.PropertyGet(nameof (SessionValues));
      }
    }

    public new Environment MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public new Environment TrainingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingPlan));
      }
    }

    public new Environment EmailAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailAddress), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmailAddress));
      }
    }

    public new ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Environment TerminologyDictionary
    {
      [param: In] set
      {
        this.PropertySet(nameof (TerminologyDictionary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TerminologyDictionary));
      }
    }

    public new Environment LanguageDictionary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LanguageDictionary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LanguageDictionary));
      }
    }

    public new Environment DocManagerUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocManagerUser), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocManagerUser));
      }
    }

    public new Environment DocManagerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocManagerPassword), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocManagerPassword));
      }
    }

    public new Environment WebDrillDownMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebDrillDownMenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WebDrillDownMenuDefinition));
      }
    }

    public new UserProfileChanges_Environment UserProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserProfile), (object) value);
      }
      get
      {
        return (UserProfileChanges_Environment) this.PropertyGet(nameof (UserProfile));
      }
    }

    public new UIPortalProfileChanges_Environment UIPortalProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPortalProfile), (object) value);
      }
      get
      {
        return (UIPortalProfileChanges_Environment) this.PropertyGet(nameof (UIPortalProfile));
      }
    }

    public new Environment FilterTagAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagAccess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTagAccess));
      }
    }

    public new Environment FilterTagsSession
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagsSession), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTagsSession));
      }
    }

    public new EmployeeRoleChanges_Environment Roles
    {
      [param: In] set
      {
        this.PropertySet(nameof (Roles), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges_Environment) this.PropertyGet(nameof (Roles));
      }
    }

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new AttachDocumentDetails_Environment AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (AttachDocumentDetails_Environment) this.PropertyGet(nameof (AttachDocumentDetails));
      }
    }

    public new Environment PortalMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalMenuDefinition));
      }
    }

    public new Environment PortalMobileMenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMobileMenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalMobileMenuDefinition));
      }
    }

    public new Environment UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseROR));
      }
    }

    public new Environment IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsNDO));
      }
    }

    public new Environment IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsContainer));
      }
    }

    public new Environment AllowOverrideOfSessionValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverrideOfSessionValues), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowOverrideOfSessionValues));
      }
    }

    public new Environment InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Environment ModelerAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelerAccess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelerAccess));
      }
    }

    public new Environment IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRDO));
      }
    }

    public new Environment CanLogin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CanLogin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CanLogin));
      }
    }

    public new Environment AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public new Environment AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Environment UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Environment FullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FullName));
      }
    }

    public new Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment UserComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserComment));
      }
    }

    public new Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public new Environment EscalationRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationRecipients), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalationRecipients));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public new Environment DomainName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DomainName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DomainName));
      }
    }
  }
}
