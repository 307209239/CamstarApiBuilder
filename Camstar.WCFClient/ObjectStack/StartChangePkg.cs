// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartChangePkg
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
  public class StartChangePkg : BPStartTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_OwnerRole")]
    protected NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Workflow")]
    protected new RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_PackageCreationTemplate")]
    protected NamedObjectRef _PackageCreationTemplate;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_TrackableObject")]
    protected NamedObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Reason")]
    protected NamedObjectRef _Reason;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_PackageType")]
    protected NamedObjectRef _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_ServiceDetail")]
    protected StartChangePkgDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_CurrentStatusDetails")]
    protected SubentityRef _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_RecommendedDeploymentDate")]
    protected Primitive<DateTime> _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_LockInstances")]
    protected Primitive<bool> _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_NotifyOwnerAllStateChanges")]
    protected Primitive<bool> _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_NotifyOwnerRoleAllStateChgs")]
    protected Primitive<bool> _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_ECOECN")]
    protected Primitive<string> _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_PreReqChangePkgs")]
    protected Primitive<string>[] _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_WorkflowDescription")]
    protected Primitive<string> _WorkflowDescription;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_TrackableName")]
    protected new Primitive<string> _TrackableName;

    public override bool Equals(object obj)
    {
      return obj is StartChangePkg && object.Equals((object) this._OwnerRole, (object) ((StartChangePkg) obj)._OwnerRole) && (object.Equals((object) this._Priority, (object) ((StartChangePkg) obj)._Priority) && object.Equals((object) this._Workflow, (object) ((StartChangePkg) obj)._Workflow)) && (object.Equals((object) this._PackageCreationTemplate, (object) ((StartChangePkg) obj)._PackageCreationTemplate) && object.Equals((object) this._TrackableObject, (object) ((StartChangePkg) obj)._TrackableObject) && (object.Equals((object) this._Reason, (object) ((StartChangePkg) obj)._Reason) && object.Equals((object) this._PackageType, (object) ((StartChangePkg) obj)._PackageType))) && (object.Equals((object) this._ServiceDetail, (object) ((StartChangePkg) obj)._ServiceDetail) && object.Equals((object) this._CurrentStatusDetails, (object) ((StartChangePkg) obj)._CurrentStatusDetails) && (object.Equals((object) this._RecommendedDeploymentDate, (object) ((StartChangePkg) obj)._RecommendedDeploymentDate) && object.Equals((object) this._LockInstances, (object) ((StartChangePkg) obj)._LockInstances)) && (object.Equals((object) this._NotifyOwnerAllStateChanges, (object) ((StartChangePkg) obj)._NotifyOwnerAllStateChanges) && object.Equals((object) this._NotifyOwnerRoleAllStateChgs, (object) ((StartChangePkg) obj)._NotifyOwnerRoleAllStateChgs) && (object.Equals((object) this._ECOECN, (object) ((StartChangePkg) obj)._ECOECN) && this.CompareArrays((Array) this._PreReqChangePkgs, (Array) ((StartChangePkg) obj)._PreReqChangePkgs)))) && (object.Equals((object) this._WorkflowDescription, (object) ((StartChangePkg) obj)._WorkflowDescription) && object.Equals((object) this._Owner, (object) ((StartChangePkg) obj)._Owner) && object.Equals((object) this._TrackableName, (object) ((StartChangePkg) obj)._TrackableName)) && base.Equals(obj);
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

    public NamedObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrackableObject));
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

    public StartChangePkgDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (StartChangePkgDetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public SubentityRef CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CurrentStatusDetails));
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

    public new Primitive<string> TrackableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TrackableName));
      }
    }
  }
}
