// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackage_Environment
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
  public class ChangePackage_Environment : TrackableObject_Environment
  {
    [Metadata("ExportImportName", "", false, false, true, "String", 16777339, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ChangePackageExportName")]
    protected Environment _ChangePackageExportName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_WorkflowNavigator")]
    [Metadata("Navigate through a workflow, including subworkflows and rework information.", "WorkflowNavigator", false, false, true, "SubentityRef", 1049790, false, false, false, null)]
    protected new Environment _WorkflowNavigator;
    [Metadata("URL", "", false, false, true, "String", 16777340, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ModelingImportFile")]
    protected Environment _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ModelingInstanceExportName")]
    [Metadata("ExportImportName", "", false, false, true, "String", 16777337, false, false, false, null)]
    protected Environment _ModelingInstanceExportName;
    [Metadata("ExportImportStatusType", "ExportImportStatusEnum", false, false, true, "Integer", 16777394, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_CPExportStatus")]
    protected Environment _CPExportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Instances")]
    [Metadata("CPModelingInstance", "CPModelingInstance", false, false, true, "CPModelingInstance", 1053260, false, true, false, null)]
    protected CPModelingInstance_Environment _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_CPDeployments")]
    [Metadata("A listing of all exports requested for a change package.  It is used to track that all exports completed and if they were successful or failed.  One failure means the change package deployment failed.", "CPDeployment", false, false, true, "SubentityRef", 16777414, false, true, false, null)]
    protected Environment _CPDeployments;
    [Metadata("ChangePackageImportStatus", "ChangePackageImportStatusEnum", false, false, true, "Integer", 16777369, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_CPImportStatus")]
    protected Environment _CPImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Status")]
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    protected Environment _Status;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Workflow")]
    protected new Environment _Workflow;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, true, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ApprovalSheet")]
    protected Environment _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_WorkflowStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "ChangeMgtSpecStep", false, false, true, "NamedSubentityRef", 1048855, false, false, false, null)]
    protected new Environment _WorkflowStep;
    [Metadata("Target Deployment", "TargetDeployment", false, false, true, "SubentityRef", 1053268, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_TargetDeployments")]
    protected Environment _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ApprovalStatus")]
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1051625, false, false, false, null)]
    protected Environment _ApprovalStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_CollaboratorData")]
    [Metadata("Collaborator data contains list of Collaborator Entries and email messages. Could be assigned to a Tracking Object", "CollaboratorData", false, false, true, "SubentityRef", 16778086, false, false, false, null)]
    protected Environment _CollaboratorData;
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Spec")]
    protected new Environment _Spec;
    [Metadata("Target Deployment Detail", "TargetDeploymentDetail", false, false, true, "SubentityRef", 16777416, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_MdlTargetDeploymentDetails")]
    protected Environment _MdlTargetDeploymentDetails;
    [Metadata("Target systems associated with a change package", "ChangePackageTarget", false, false, true, "ChangePackageTarget", 1053228, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ChangePackageTargets")]
    protected ChangePackageTarget_Environment _ChangePackageTargets;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ExportRequestDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16777403, false, false, false, null)]
    protected Environment _ExportRequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LastUpdatedDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    protected new Environment _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_PreReqChangePkgs")]
    [Metadata("Generic String", "", false, false, true, "String", 16778970, false, true, false, null)]
    protected Environment _PreReqChangePkgs;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777681, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LockAllModelingInstances")]
    protected Environment _LockAllModelingInstances;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LastMoveDate")]
    protected new Environment _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_RecommendedDeploymentDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778131, false, false, false, null)]
    protected Environment _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LastActivityDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048803, false, false, false, null)]
    protected new Environment _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LastUpdatedDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    protected new Environment _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ExportRequestDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16777403, false, false, false, null)]
    protected Environment _ExportRequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Locklnstances")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053237, false, false, false, "0")]
    protected Environment _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LastActivityDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048804, false, false, false, null)]
    protected new Environment _LastActivityDateGMT;
    [Metadata("Generic String", "", false, false, true, "String", 1053236, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ECOECN")]
    protected Environment _ECOECN;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_NotifyOwnerRoleAllStateChgs")]
    protected Environment _NotifyOwnerRoleAllStateChgs;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049059, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_CreationDate")]
    protected Environment _CreationDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_CreationDateGMT")]
    protected Environment _CreationDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048808, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_LastMoveDateGMT")]
    protected new Environment _LastMoveDateGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053238, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_NotifyOwnerAllStateChanges")]
    protected Environment _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16777630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_AuthorName")]
    protected Environment _AuthorName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778882, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_PackageTypeName")]
    protected Environment _PackageTypeName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16777418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_SourceSystemName")]
    protected Environment _SourceSystemName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_PriorityName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050120, false, false, false, null)]
    protected Environment _PriorityName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1053234, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_OwnerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050120, false, false, false, null)]
    protected Environment _OwnerName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050120, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_ReasonName")]
    protected Environment _ReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Environment_OwnerRoleName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050120, false, false, false, null)]
    protected Environment _OwnerRoleName;

    public Environment ChangePackageExportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageExportName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackageExportName));
      }
    }

    public new Environment WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Environment ModelingImportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingImportFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingImportFile));
      }
    }

    public Environment ModelingInstanceExportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceExportName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingInstanceExportName));
      }
    }

    public Environment CPExportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPExportStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CPExportStatus));
      }
    }

    public CPModelingInstance_Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstance_Environment) this.PropertyGet(nameof (Instances));
      }
    }

    public Environment CPDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPDeployments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CPDeployments));
      }
    }

    public Environment CPImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPImportStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CPImportStatus));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
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

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public new Environment WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public Environment TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public Environment ApprovalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalStatus));
      }
    }

    public Environment CollaboratorData
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollaboratorData));
      }
    }

    public new Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public Environment MdlTargetDeploymentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MdlTargetDeploymentDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MdlTargetDeploymentDetails));
      }
    }

    public ChangePackageTarget_Environment ChangePackageTargets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageTargets), (object) value);
      }
      get
      {
        return (ChangePackageTarget_Environment) this.PropertyGet(nameof (ChangePackageTargets));
      }
    }

    public Environment ExportRequestDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportRequestDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportRequestDateGMT));
      }
    }

    public new Environment LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDate));
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

    public Environment LockAllModelingInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockAllModelingInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LockAllModelingInstances));
      }
    }

    public new Environment LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDate));
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

    public new Environment LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public new Environment LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Environment ExportRequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportRequestDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportRequestDate));
      }
    }

    public Environment Locklnstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locklnstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Locklnstances));
      }
    }

    public new Environment LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDateGMT));
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

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Environment CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public new Environment LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDateGMT));
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

    public Environment AuthorName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthorName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AuthorName));
      }
    }

    public Environment PackageTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageTypeName));
      }
    }

    public Environment SourceSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystemName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceSystemName));
      }
    }

    public Environment PriorityName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityName));
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

    public Environment OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerName));
      }
    }

    public Environment ReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReasonName));
      }
    }

    public Environment OwnerRoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRoleName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerRoleName));
      }
    }
  }
}
