// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateChangePkg_Environment
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
  public class UpdateChangePkg_Environment : ChangeMgtTxn_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051580, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_OwnerRole")]
    protected Environment _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_CollaboratorDetails")]
    [Metadata("Service Details to load and save Collaborator Data", "CollaboratorDetails", false, false, false, "CollaboratorDetails", 16778078, false, false, false, null)]
    protected CollaboratorDetails_Environment _CollaboratorDetails;
    [Metadata("Package Creation Template", "PackageCreationTemplate", false, false, true, "NamedObjectRef", 16778458, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_PackageCreationTemplate")]
    protected Environment _PackageCreationTemplate;
    [Metadata("Helps to clarify the type of package.", "PackageType", false, false, false, "NamedObjectRef", 16778882, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_PackageType")]
    protected Environment _PackageType;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_Workflow")]
    protected Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_ServiceDetail")]
    [Metadata("Update details for a change package.", "UpdateChangePkgDetail", false, false, false, "UpdateChangePkgDetail", 1051158, false, false, false, null)]
    protected UpdateChangePkgDetail_Environment _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051645, false, false, true, null)]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_Priority")]
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, false, "NamedObjectRef", 16777355, false, false, true, null)]
    protected Environment _Priority;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_ApprovalSheetDetails")]
    [Metadata("Used to update an ApprovalSheet for a parent object", "ApprovalSheetDetails", false, false, false, "ApprovalSheetDetails", 1051619, false, false, false, null)]
    protected ApprovalSheetDetails_Environment _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_ChangePackage")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1053240, false, false, true, null)]
    protected new Environment _ChangePackage;
    [Metadata("Various reasons for creating a change package.", "ChangePackageReason", false, false, false, "NamedObjectRef", 1053247, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_Reason")]
    protected Environment _Reason;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_RecommendedDeploymentDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778133, false, false, false, null)]
    protected Environment _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_IsUpdateChangePkg")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777740, false, false, false, "0")]
    protected Environment _IsUpdateChangePkg;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778087, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_UseContentCollaborators")]
    protected Environment _UseContentCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_NotifyOwnerAllStateChanges")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053238, false, false, false, "0")]
    protected Environment _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_HasSpecApprovals")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777607, false, false, false, "0")]
    protected Environment _HasSpecApprovals;
    [Metadata("Generic String", "", false, false, false, "String", 16778970, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_PreReqChangePkgs")]
    protected Environment _PreReqChangePkgs;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_NotifyOwnerRoleAllStateChgs")]
    protected Environment _NotifyOwnerRoleAllStateChgs;
    [Metadata("Generic String", "", false, false, false, "String", 1053236, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_ECOECN")]
    protected Environment _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_LockInstances")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053245, false, false, false, "0")]
    protected Environment _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_WorkflowDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 16777468, false, false, false, null)]
    protected Environment _WorkflowDescription;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16777353, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Environment_Owner")]
    protected Environment _Owner;

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

    public CollaboratorDetails_Environment CollaboratorDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorDetails), (object) value);
      }
      get
      {
        return (CollaboratorDetails_Environment) this.PropertyGet(nameof (CollaboratorDetails));
      }
    }

    public Environment PackageCreationTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageCreationTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageCreationTemplate));
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

    public UpdateChangePkgDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (UpdateChangePkgDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
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

    public Environment Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Priority));
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

    public new Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Environment Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Reason));
      }
    }

    public Environment RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Environment IsUpdateChangePkg
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsUpdateChangePkg), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsUpdateChangePkg));
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

    public Environment NotifyOwnerAllStateChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerAllStateChanges), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotifyOwnerAllStateChanges));
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

    public Environment PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public Environment NotifyOwnerRoleAllStateChgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerRoleAllStateChgs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotifyOwnerRoleAllStateChgs));
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

    public Environment LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LockInstances));
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

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
