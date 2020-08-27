// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackage_Info
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
  public class ChangePackage_Info : TrackableObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ChangePackageExportName")]
    protected Info _ChangePackageExportName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_WorkflowNavigator")]
    protected new Info _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ModelingImportFile")]
    protected Info _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ModelingInstanceExportName")]
    protected Info _ModelingInstanceExportName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_CPExportStatus")]
    protected Info _CPExportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Instances")]
    protected CPModelingInstance_Info _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_CPDeployments")]
    protected Info _CPDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_CPImportStatus")]
    protected Info _CPImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Workflow")]
    protected new Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_WorkflowStep")]
    protected new Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_TargetDeployments")]
    protected Info _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ApprovalStatus")]
    protected Info _ApprovalStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_CollaboratorData")]
    protected Info _CollaboratorData;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Spec")]
    protected new Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_MdlTargetDeploymentDetails")]
    protected Info _MdlTargetDeploymentDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ChangePackageTargets")]
    protected ChangePackageTarget_Info _ChangePackageTargets;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ExportRequestDateGMT")]
    protected Info _ExportRequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LastUpdatedDate")]
    protected new Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_PreReqChangePkgs")]
    protected Info _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LockAllModelingInstances")]
    protected Info _LockAllModelingInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LastMoveDate")]
    protected new Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_RecommendedDeploymentDate")]
    protected Info _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LastActivityDate")]
    protected new Info _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LastUpdatedDateGMT")]
    protected new Info _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ExportRequestDate")]
    protected Info _ExportRequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Locklnstances")]
    protected Info _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LastActivityDateGMT")]
    protected new Info _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ECOECN")]
    protected Info _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_NotifyOwnerRoleAllStateChgs")]
    protected Info _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_CreationDateGMT")]
    protected Info _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_LastMoveDateGMT")]
    protected new Info _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_NotifyOwnerAllStateChanges")]
    protected Info _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_AuthorName")]
    protected Info _AuthorName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_PackageTypeName")]
    protected Info _PackageTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_SourceSystemName")]
    protected Info _SourceSystemName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_PriorityName")]
    protected Info _PriorityName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_OwnerName")]
    protected Info _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_ReasonName")]
    protected Info _ReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Info_OwnerRoleName")]
    protected Info _OwnerRoleName;

    public Info ChangePackageExportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageExportName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackageExportName));
      }
    }

    public new Info WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Info ModelingImportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingImportFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingImportFile));
      }
    }

    public Info ModelingInstanceExportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceExportName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceExportName));
      }
    }

    public Info CPExportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPExportStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CPExportStatus));
      }
    }

    public CPModelingInstance_Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstance_Info) this.PropertyGet(nameof (Instances));
      }
    }

    public Info CPDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPDeployments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CPDeployments));
      }
    }

    public Info CPImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPImportStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CPImportStatus));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public new Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public new Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public Info TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public Info ApprovalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalStatus));
      }
    }

    public Info CollaboratorData
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorData));
      }
    }

    public new Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public Info MdlTargetDeploymentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MdlTargetDeploymentDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MdlTargetDeploymentDetails));
      }
    }

    public ChangePackageTarget_Info ChangePackageTargets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageTargets), (object) value);
      }
      get
      {
        return (ChangePackageTarget_Info) this.PropertyGet(nameof (ChangePackageTargets));
      }
    }

    public Info ExportRequestDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportRequestDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportRequestDateGMT));
      }
    }

    public new Info LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Info PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public Info LockAllModelingInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockAllModelingInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LockAllModelingInstances));
      }
    }

    public new Info LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Info RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public new Info LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public new Info LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Info ExportRequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportRequestDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportRequestDate));
      }
    }

    public Info Locklnstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locklnstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Locklnstances));
      }
    }

    public new Info LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Info ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ECOECN));
      }
    }

    public Info NotifyOwnerRoleAllStateChgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerRoleAllStateChgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotifyOwnerRoleAllStateChgs));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Info CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public new Info LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Info NotifyOwnerAllStateChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerAllStateChanges), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotifyOwnerAllStateChanges));
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

    public Info AuthorName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthorName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AuthorName));
      }
    }

    public Info PackageTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageTypeName));
      }
    }

    public Info SourceSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystemName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceSystemName));
      }
    }

    public Info PriorityName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityName));
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

    public Info OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerName));
      }
    }

    public Info ReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonName));
      }
    }

    public Info OwnerRoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRoleName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerRoleName));
      }
    }
  }
}
