// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateChangePkg
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
  public class UpdateChangePkg : ChangeMgtTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_OwnerRole")]
    protected NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_CollaboratorDetails")]
    protected CollaboratorDetails _CollaboratorDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_PackageCreationTemplate")]
    protected NamedObjectRef _PackageCreationTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_PackageType")]
    protected NamedObjectRef _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_ServiceDetail")]
    protected UpdateChangePkgDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_ApprovalSheetDetails")]
    protected ApprovalSheetDetails _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_ChangePackage")]
    protected new NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Reason")]
    protected NamedObjectRef _Reason;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_RecommendedDeploymentDate")]
    protected Primitive<DateTime> _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_IsUpdateChangePkg")]
    protected Primitive<bool> _IsUpdateChangePkg;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_UseContentCollaborators")]
    protected Primitive<bool> _UseContentCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_NotifyOwnerAllStateChanges")]
    protected Primitive<bool> _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_HasSpecApprovals")]
    protected Primitive<bool> _HasSpecApprovals;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_PreReqChangePkgs")]
    protected Primitive<string>[] _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_NotifyOwnerRoleAllStateChgs")]
    protected Primitive<bool> _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_ECOECN")]
    protected Primitive<string> _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_LockInstances")]
    protected Primitive<bool> _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_WorkflowDescription")]
    protected Primitive<string> _WorkflowDescription;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Owner")]
    protected NamedObjectRef _Owner;

    public override bool Equals(object obj)
    {
      return obj is UpdateChangePkg && object.Equals((object) this._OwnerRole, (object) ((UpdateChangePkg) obj)._OwnerRole) && (object.Equals((object) this._CollaboratorDetails, (object) ((UpdateChangePkg) obj)._CollaboratorDetails) && object.Equals((object) this._PackageCreationTemplate, (object) ((UpdateChangePkg) obj)._PackageCreationTemplate)) && (object.Equals((object) this._PackageType, (object) ((UpdateChangePkg) obj)._PackageType) && object.Equals((object) this._Workflow, (object) ((UpdateChangePkg) obj)._Workflow) && (object.Equals((object) this._ServiceDetail, (object) ((UpdateChangePkg) obj)._ServiceDetail) && object.Equals((object) this._ApprovalSheetTemplate, (object) ((UpdateChangePkg) obj)._ApprovalSheetTemplate))) && (object.Equals((object) this._Priority, (object) ((UpdateChangePkg) obj)._Priority) && object.Equals((object) this._ApprovalSheetDetails, (object) ((UpdateChangePkg) obj)._ApprovalSheetDetails) && (object.Equals((object) this._ChangePackage, (object) ((UpdateChangePkg) obj)._ChangePackage) && object.Equals((object) this._Reason, (object) ((UpdateChangePkg) obj)._Reason)) && (object.Equals((object) this._RecommendedDeploymentDate, (object) ((UpdateChangePkg) obj)._RecommendedDeploymentDate) && object.Equals((object) this._IsUpdateChangePkg, (object) ((UpdateChangePkg) obj)._IsUpdateChangePkg) && (object.Equals((object) this._UseContentCollaborators, (object) ((UpdateChangePkg) obj)._UseContentCollaborators) && object.Equals((object) this._NotifyOwnerAllStateChanges, (object) ((UpdateChangePkg) obj)._NotifyOwnerAllStateChanges)))) && (object.Equals((object) this._HasSpecApprovals, (object) ((UpdateChangePkg) obj)._HasSpecApprovals) && this.CompareArrays((Array) this._PreReqChangePkgs, (Array) ((UpdateChangePkg) obj)._PreReqChangePkgs) && (object.Equals((object) this._NotifyOwnerRoleAllStateChgs, (object) ((UpdateChangePkg) obj)._NotifyOwnerRoleAllStateChgs) && object.Equals((object) this._ECOECN, (object) ((UpdateChangePkg) obj)._ECOECN)) && (object.Equals((object) this._LockInstances, (object) ((UpdateChangePkg) obj)._LockInstances) && object.Equals((object) this._WorkflowDescription, (object) ((UpdateChangePkg) obj)._WorkflowDescription) && object.Equals((object) this._Owner, (object) ((UpdateChangePkg) obj)._Owner))) && base.Equals(obj);
    }

    public NamedObjectRef OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public CollaboratorDetails CollaboratorDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorDetails), (object) value);
      }
      get
      {
        return (CollaboratorDetails) this.PropertyGet(nameof (CollaboratorDetails));
      }
    }

    public NamedObjectRef PackageCreationTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageCreationTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackageCreationTemplate));
      }
    }

    public NamedObjectRef PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackageType));
      }
    }

    public RevisionedObjectRef Workflow
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

    public UpdateChangePkgDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (UpdateChangePkgDetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public NamedObjectRef Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Priority));
      }
    }

    public ApprovalSheetDetails ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public new NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public NamedObjectRef Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Reason));
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

    public Primitive<bool> IsUpdateChangePkg
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsUpdateChangePkg), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsUpdateChangePkg));
      }
    }

    public Primitive<bool> UseContentCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseContentCollaborators), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseContentCollaborators));
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

    public Primitive<bool> HasSpecApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasSpecApprovals), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasSpecApprovals));
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

    public Primitive<bool> LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Primitive<string> WorkflowDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowDescription));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
