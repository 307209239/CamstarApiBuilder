// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageCreationTemplateChanges_Environment
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
  public class PackageCreationTemplateChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 16777408, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_PackageDescription")]
    protected Environment _PackageDescription;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_PackageType1")]
    [Metadata("Enumeration for the after commit event status codes.\r\n\r\nValue\tName\t                Meaning\r\n1\tACESuccess\tafter commit event completed successfully\r\n2\tACEFSuccess\tan unhandled error in the after commit event was caught and after commit event failure event completed successfully\r\n3\tACEFFail\t                an unhandled error in the after commit event was caught and another unhandled error was raised in the after commit event failure event\r\n> 99\t<custom status>\tUser specific status codes (Designer based)\r\n", "ACEStatusEnum", false, false, false, "String", 16778882, false, false, false, null)]
    protected Environment _PackageType1;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051580, false, false, true, null)]
    protected Environment _OwnerRole;
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "NamedObjectRef", 16777320, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_SourceSystem")]
    protected Environment _SourceSystem;
    [Metadata("Helps to clarify the type of package.", "PackageType", false, false, false, "NamedObjectRef", 16778882, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_PackageType")]
    protected Environment _PackageType;
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "NamedObjectRef", 1053270, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_TargetSystems")]
    protected Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_PackageCreationReason")]
    [Metadata("Various reasons for creating a change package.", "ChangePackageReason", false, false, false, "NamedObjectRef", 16778459, false, false, true, null)]
    protected Environment _PackageCreationReason;
    [Metadata("The template is used to pre-define the collaborators that will be attached to the object.", "CollaboratorTemplate", false, false, false, "NamedObjectRef", 16778076, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_CollaboratorTemplate")]
    protected Environment _CollaboratorTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_ObjectToChange")]
    [Metadata("Package Creation Template", "PackageCreationTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, false, "NamedObjectRef", 16777355, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_PackagePriorityCode")]
    protected Environment _PackagePriorityCode;
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051645, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_ApprovalTemplate")]
    protected Environment _ApprovalTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, false, "RevisionedObjectRef", 16778460, false, false, true, null)]
    protected Environment _Workflow;
    [Metadata("Generic String", "", false, false, false, "String", 1053236, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_ECOECN")]
    protected Environment _ECOECN;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778087, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_UseContentCollaborators")]
    protected Environment _UseContentCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_WorkflowAssignApprovers")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777605, false, false, false, "0")]
    protected Environment _WorkflowAssignApprovers;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16777353, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_PackageOwner")]
    protected Environment _PackageOwner;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16778458, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 16778461, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Environment_WorkflowDescription")]
    protected Environment _WorkflowDescription;

    public Environment PackageDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageDescription));
      }
    }

    public Environment PackageType1
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType1), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageType1));
      }
    }

    public Environment OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Environment SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Environment PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageType));
      }
    }

    public Environment TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Environment PackageCreationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageCreationReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageCreationReason));
      }
    }

    public Environment CollaboratorTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollaboratorTemplate));
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

    public Environment PackagePriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackagePriorityCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackagePriorityCode));
      }
    }

    public Environment ApprovalTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalTemplate));
      }
    }

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public Environment ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ECOECN));
      }
    }

    public Environment UseContentCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseContentCollaborators), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseContentCollaborators));
      }
    }

    public Environment WorkflowAssignApprovers
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowAssignApprovers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowAssignApprovers));
      }
    }

    public Environment PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageOwner));
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

    public Environment WorkflowDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowDescription));
      }
    }
  }
}
