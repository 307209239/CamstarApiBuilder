// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartChangePkg_Environment
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
  public class StartChangePkg_Environment : BPStartTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051580, false, false, true, null)]
    protected Environment _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_Priority")]
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, false, "NamedObjectRef", 16777355, false, false, true, null)]
    protected Environment _Priority;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, true, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_Workflow")]
    protected new Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_PackageCreationTemplate")]
    [Metadata("Package Creation Template", "PackageCreationTemplate", false, false, false, "NamedObjectRef", 16778458, false, false, true, null)]
    protected Environment _PackageCreationTemplate;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [Metadata("Various reasons for creating a change package.", "ChangePackageReason", false, false, false, "NamedObjectRef", 1053247, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_Reason")]
    protected Environment _Reason;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_PackageType")]
    [Metadata("Helps to clarify the type of package.", "PackageType", false, false, false, "NamedObjectRef", 16778882, false, false, true, null)]
    protected Environment _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_ServiceDetail")]
    [Metadata("Details to start a change package.", "StartChangePkgDetail", false, false, false, "StartChangePkgDetail", 1051158, false, false, false, null)]
    protected StartChangePkgDetail_Environment _ServiceDetail;
    [Metadata("Curernt status details for a change package", "ChangePkgCurrentStatusStartDtl", false, false, false, "SubentityRef", 1049869, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_CurrentStatusDetails")]
    protected Environment _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_RecommendedDeploymentDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778132, false, false, false, null)]
    protected Environment _RecommendedDeploymentDate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053245, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_LockInstances")]
    protected Environment _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_NotifyOwnerAllStateChanges")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053238, false, false, false, "0")]
    protected Environment _NotifyOwnerAllStateChanges;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_NotifyOwnerRoleAllStateChgs")]
    protected Environment _NotifyOwnerRoleAllStateChgs;
    [Metadata("Generic String", "", false, false, false, "String", 1053236, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_ECOECN")]
    protected Environment _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_PreReqChangePkgs")]
    [Metadata("Generic String", "", false, false, false, "String", 16778970, false, true, false, null)]
    protected Environment _PreReqChangePkgs;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_WorkflowDescription")]
    protected Environment _WorkflowDescription;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_Owner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Environment_TrackableName")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    protected new Environment _TrackableName;

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

    public new Environment Workflow
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

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
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

    public StartChangePkgDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (StartChangePkgDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public Environment CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentStatusDetails));
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

    public new Environment TrackableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableName));
      }
    }
  }
}
