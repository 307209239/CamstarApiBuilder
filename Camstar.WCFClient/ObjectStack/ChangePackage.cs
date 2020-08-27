// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackage
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
  public class ChangePackage : TrackableObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ChangePackageExportName")]
    protected Primitive<string> _ChangePackageExportName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_WorkflowNavigator")]
    protected new SubentityRef _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ModelingImportFile")]
    protected Primitive<string> _ModelingImportFile;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ModelingInstanceExportName")]
    protected Primitive<string> _ModelingInstanceExportName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_CPExportStatus")]
    protected Enumeration<ExportImportStatusEnum, int> _CPExportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Instances")]
    protected CPModelingInstance[] _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_CPDeployments")]
    protected SubentityRef[] _CPDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_CPImportStatus")]
    protected Enumeration<ChangePackageImportStatusEnum, int> _CPImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Status")]
    protected Enumeration<PackageStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Workflow")]
    protected new RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_WorkflowStep")]
    protected new NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_TargetDeployments")]
    protected SubentityRef[] _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ApprovalStatus")]
    protected Enumeration<ApprovalStatusEnum, int> _ApprovalStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_CollaboratorData")]
    protected SubentityRef _CollaboratorData;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_MdlTargetDeploymentDetails")]
    protected SubentityRef[] _MdlTargetDeploymentDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ChangePackageTargets")]
    protected ChangePackageTarget[] _ChangePackageTargets;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ExportRequestDateGMT")]
    protected Primitive<DateTime> _ExportRequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LastUpdatedDate")]
    protected new Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_PreReqChangePkgs")]
    protected Primitive<string>[] _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LockAllModelingInstances")]
    protected Primitive<bool> _LockAllModelingInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LastMoveDate")]
    protected new Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_RecommendedDeploymentDate")]
    protected Primitive<DateTime> _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LastActivityDate")]
    protected new Primitive<DateTime> _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LastUpdatedDateGMT")]
    protected new Primitive<DateTime> _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ExportRequestDate")]
    protected Primitive<DateTime> _ExportRequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Locklnstances")]
    protected Primitive<bool> _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LastActivityDateGMT")]
    protected new Primitive<DateTime> _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ECOECN")]
    protected Primitive<string> _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_NotifyOwnerRoleAllStateChgs")]
    protected Primitive<bool> _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_LastMoveDateGMT")]
    protected new Primitive<DateTime> _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_NotifyOwnerAllStateChanges")]
    protected Primitive<bool> _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_AuthorName")]
    protected Primitive<string> _AuthorName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_PackageTypeName")]
    protected Primitive<string> _PackageTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_SourceSystemName")]
    protected Primitive<string> _SourceSystemName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_PriorityName")]
    protected Primitive<string> _PriorityName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_OwnerName")]
    protected Primitive<string> _OwnerName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_ReasonName")]
    protected Primitive<string> _ReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackage_OwnerRoleName")]
    protected Primitive<string> _OwnerRoleName;

    public override bool Equals(object obj)
    {
      return obj is ChangePackage && object.Equals((object) this._ChangePackageExportName, (object) ((ChangePackage) obj)._ChangePackageExportName) && (object.Equals((object) this._WorkflowNavigator, (object) ((ChangePackage) obj)._WorkflowNavigator) && object.Equals((object) this._ModelingImportFile, (object) ((ChangePackage) obj)._ModelingImportFile)) && (object.Equals((object) this._ModelingInstanceExportName, (object) ((ChangePackage) obj)._ModelingInstanceExportName) && object.Equals((object) this._CPExportStatus, (object) ((ChangePackage) obj)._CPExportStatus) && (this.CompareArrays((Array) this._Instances, (Array) ((ChangePackage) obj)._Instances) && this.CompareArrays((Array) this._CPDeployments, (Array) ((ChangePackage) obj)._CPDeployments))) && (object.Equals((object) this._CPImportStatus, (object) ((ChangePackage) obj)._CPImportStatus) && object.Equals((object) this._Status, (object) ((ChangePackage) obj)._Status) && (object.Equals((object) this._Workflow, (object) ((ChangePackage) obj)._Workflow) && object.Equals((object) this._ApprovalSheet, (object) ((ChangePackage) obj)._ApprovalSheet)) && (object.Equals((object) this._WorkflowStep, (object) ((ChangePackage) obj)._WorkflowStep) && this.CompareArrays((Array) this._TargetDeployments, (Array) ((ChangePackage) obj)._TargetDeployments) && (object.Equals((object) this._ApprovalStatus, (object) ((ChangePackage) obj)._ApprovalStatus) && object.Equals((object) this._CollaboratorData, (object) ((ChangePackage) obj)._CollaboratorData)))) && (object.Equals((object) this._Spec, (object) ((ChangePackage) obj)._Spec) && this.CompareArrays((Array) this._MdlTargetDeploymentDetails, (Array) ((ChangePackage) obj)._MdlTargetDeploymentDetails) && (this.CompareArrays((Array) this._ChangePackageTargets, (Array) ((ChangePackage) obj)._ChangePackageTargets) && object.Equals((object) this._ExportRequestDateGMT, (object) ((ChangePackage) obj)._ExportRequestDateGMT)) && (object.Equals((object) this._LastUpdatedDate, (object) ((ChangePackage) obj)._LastUpdatedDate) && this.CompareArrays((Array) this._PreReqChangePkgs, (Array) ((ChangePackage) obj)._PreReqChangePkgs) && (object.Equals((object) this._LockAllModelingInstances, (object) ((ChangePackage) obj)._LockAllModelingInstances) && object.Equals((object) this._LastMoveDate, (object) ((ChangePackage) obj)._LastMoveDate))) && (object.Equals((object) this._RecommendedDeploymentDate, (object) ((ChangePackage) obj)._RecommendedDeploymentDate) && object.Equals((object) this._LastActivityDate, (object) ((ChangePackage) obj)._LastActivityDate) && (object.Equals((object) this._LastUpdatedDateGMT, (object) ((ChangePackage) obj)._LastUpdatedDateGMT) && object.Equals((object) this._ExportRequestDate, (object) ((ChangePackage) obj)._ExportRequestDate)) && (object.Equals((object) this._Locklnstances, (object) ((ChangePackage) obj)._Locklnstances) && object.Equals((object) this._LastActivityDateGMT, (object) ((ChangePackage) obj)._LastActivityDateGMT) && (object.Equals((object) this._ECOECN, (object) ((ChangePackage) obj)._ECOECN) && object.Equals((object) this._NotifyOwnerRoleAllStateChgs, (object) ((ChangePackage) obj)._NotifyOwnerRoleAllStateChgs))))) && (object.Equals((object) this._CreationDate, (object) ((ChangePackage) obj)._CreationDate) && object.Equals((object) this._CreationDateGMT, (object) ((ChangePackage) obj)._CreationDateGMT) && (object.Equals((object) this._LastMoveDateGMT, (object) ((ChangePackage) obj)._LastMoveDateGMT) && object.Equals((object) this._NotifyOwnerAllStateChanges, (object) ((ChangePackage) obj)._NotifyOwnerAllStateChanges)) && (object.Equals((object) this._Description, (object) ((ChangePackage) obj)._Description) && object.Equals((object) this._AuthorName, (object) ((ChangePackage) obj)._AuthorName) && (object.Equals((object) this._PackageTypeName, (object) ((ChangePackage) obj)._PackageTypeName) && object.Equals((object) this._SourceSystemName, (object) ((ChangePackage) obj)._SourceSystemName))) && (object.Equals((object) this._PriorityName, (object) ((ChangePackage) obj)._PriorityName) && object.Equals((object) this._Name, (object) ((ChangePackage) obj)._Name) && (object.Equals((object) this._OwnerName, (object) ((ChangePackage) obj)._OwnerName) && object.Equals((object) this._ReasonName, (object) ((ChangePackage) obj)._ReasonName)) && object.Equals((object) this._OwnerRoleName, (object) ((ChangePackage) obj)._OwnerRoleName))) && base.Equals(obj);
    }

    public Primitive<string> ChangePackageExportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageExportName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChangePackageExportName));
      }
    }

    public new SubentityRef WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Primitive<string> ModelingImportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingImportFile), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ModelingImportFile));
      }
    }

    public Primitive<string> ModelingInstanceExportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceExportName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ModelingInstanceExportName));
      }
    }

    public Enumeration<ExportImportStatusEnum, int> CPExportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPExportStatus), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportStatusEnum, int>) this.PropertyGet(nameof (CPExportStatus));
      }
    }

    public CPModelingInstance[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstance[]) this.PropertyGet(nameof (Instances));
      }
    }

    public SubentityRef[] CPDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPDeployments), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (CPDeployments));
      }
    }

    public Enumeration<ChangePackageImportStatusEnum, int> CPImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPImportStatus), (object) value);
      }
      get
      {
        return (Enumeration<ChangePackageImportStatusEnum, int>) this.PropertyGet(nameof (CPImportStatus));
      }
    }

    public Enumeration<PackageStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public new RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public new NamedSubentityRef WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public SubentityRef[] TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (TargetDeployments));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> ApprovalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalStatus), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (ApprovalStatus));
      }
    }

    public SubentityRef CollaboratorData
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CollaboratorData));
      }
    }

    public new RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public SubentityRef[] MdlTargetDeploymentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MdlTargetDeploymentDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (MdlTargetDeploymentDetails));
      }
    }

    public ChangePackageTarget[] ChangePackageTargets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageTargets), (object) value);
      }
      get
      {
        return (ChangePackageTarget[]) this.PropertyGet(nameof (ChangePackageTargets));
      }
    }

    public Primitive<DateTime> ExportRequestDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportRequestDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExportRequestDateGMT));
      }
    }

    public new Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<string>[] PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public Primitive<bool> LockAllModelingInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockAllModelingInstances), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LockAllModelingInstances));
      }
    }

    public new Primitive<DateTime> LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Primitive<DateTime> RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public new Primitive<DateTime> LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public new Primitive<DateTime> LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Primitive<DateTime> ExportRequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportRequestDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExportRequestDate));
      }
    }

    public Primitive<bool> Locklnstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locklnstances), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Locklnstances));
      }
    }

    public new Primitive<DateTime> LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Primitive<string> ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ECOECN));
      }
    }

    public Primitive<bool> NotifyOwnerRoleAllStateChgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerRoleAllStateChgs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (NotifyOwnerRoleAllStateChgs));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Primitive<DateTime> CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public new Primitive<DateTime> LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Primitive<bool> NotifyOwnerAllStateChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerAllStateChanges), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (NotifyOwnerAllStateChanges));
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

    public Primitive<string> AuthorName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthorName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AuthorName));
      }
    }

    public Primitive<string> PackageTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageTypeName));
      }
    }

    public Primitive<string> SourceSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceSystemName));
      }
    }

    public Primitive<string> PriorityName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PriorityName));
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

    public Primitive<string> OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerName));
      }
    }

    public Primitive<string> ReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReasonName));
      }
    }

    public Primitive<string> OwnerRoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRoleName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerRoleName));
      }
    }
  }
}
