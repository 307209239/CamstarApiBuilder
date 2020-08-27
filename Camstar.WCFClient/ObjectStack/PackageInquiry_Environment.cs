// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageInquiry_Environment
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
  public class PackageInquiry_Environment : ChangePackageInquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051580, false, false, true, null)]
    protected Environment _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackageStatuses")]
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, false, "Integer", 16778128, false, true, true, null)]
    protected Environment _PackageStatuses;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackageWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, false, "RevisionedObjectRef", 16777752, false, false, true, null)]
    protected Environment _PackageWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackageSteps")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 16777356, false, true, true, null)]
    protected Environment _PackageSteps;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_TargetSystem")]
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "NamedObjectRef", 1053228, false, false, true, null)]
    protected Environment _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackageDetails")]
    [Metadata("Details returned.", "PackageInquiryDetail", false, false, false, "PackageInquiryDetail", 16777345, false, true, false, null)]
    protected PackageInquiryDetail_Environment _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackageType")]
    [Metadata("Helps to clarify the type of package.", "PackageType", false, false, false, "NamedObjectRef", 16778882, false, false, true, null)]
    protected Environment _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackagePriorityCode")]
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, false, "NamedObjectRef", 16777355, false, false, true, null)]
    protected Environment _PackagePriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_IsApprover")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777753, false, false, false, "1")]
    protected Environment _IsApprover;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778186, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_IsCollaborator")]
    protected Environment _IsCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_IsOwner")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777754, false, false, false, "1")]
    protected Environment _IsOwner;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777756, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_HasApproverRole")]
    protected Environment _HasApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_HasOwnerRole")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777755, false, false, false, "0")]
    protected Environment _HasOwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_SelectedObjectType")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777343, false, false, true, null)]
    protected Environment _SelectedObjectType;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_IsApprovalCompleted")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777757, false, false, false, "1")]
    protected Environment _IsApprovalCompleted;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052055, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_IsCollaborationCompleted")]
    protected Environment _IsCollaborationCompleted;
    [Metadata("Generic String", "", false, false, false, "String", 16777341, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_SelectedInstance")]
    protected Environment _SelectedInstance;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778187, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_HasCollaboratorRole")]
    protected Environment _HasCollaboratorRole;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Environment_PackageOwner")]
    protected new Environment _PackageOwner;

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

    public Environment PackageStatuses
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatuses), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageStatuses));
      }
    }

    public Environment PackageWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageWorkflow));
      }
    }

    public Environment PackageSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageSteps), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageSteps));
      }
    }

    public Environment TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public PackageInquiryDetail_Environment PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (PackageInquiryDetail_Environment) this.PropertyGet(nameof (PackageDetails));
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

    public Environment IsApprover
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprover), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsApprover));
      }
    }

    public Environment IsCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsCollaborator));
      }
    }

    public Environment IsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsOwner));
      }
    }

    public Environment HasApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasApproverRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasApproverRole));
      }
    }

    public Environment HasOwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasOwnerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasOwnerRole));
      }
    }

    public Environment SelectedObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedObjectType));
      }
    }

    public Environment IsApprovalCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsApprovalCompleted));
      }
    }

    public Environment IsCollaborationCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborationCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsCollaborationCompleted));
      }
    }

    public Environment SelectedInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedInstance));
      }
    }

    public Environment HasCollaboratorRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasCollaboratorRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasCollaboratorRole));
      }
    }

    public new Environment PackageOwner
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
  }
}
