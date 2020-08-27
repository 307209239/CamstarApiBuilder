// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartChangePkgHistory
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
  public class StartChangePkgHistory : ChangePackageHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_OwnerRole")]
    protected new NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_Priority")]
    protected new NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_PackageType")]
    protected NamedObjectRef _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_Reason")]
    protected new NamedObjectRef _Reason;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_TargetSystems")]
    protected SubentityRef[] _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_Instances")]
    protected SubentityRef[] _Instances;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_NotifyOwnerAllStateChanges")]
    protected new Primitive<bool> _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_NotifyOwnerRoleAllStateChgs")]
    protected new Primitive<bool> _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_Locklnstances")]
    protected new Primitive<bool> _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_ECOECN")]
    protected new Primitive<string> _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_RecommendedDeploymentDate")]
    protected Primitive<DateTime> _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkgHistory_ChangePackageName")]
    protected new Primitive<string> _ChangePackageName;

    public override bool Equals(object obj)
    {
      return obj is StartChangePkgHistory && object.Equals((object) this._ExportImportKey, (object) ((StartChangePkgHistory) obj)._ExportImportKey) && (object.Equals((object) this._OwnerRole, (object) ((StartChangePkgHistory) obj)._OwnerRole) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((StartChangePkgHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Priority, (object) ((StartChangePkgHistory) obj)._Priority) && object.Equals((object) this._PackageType, (object) ((StartChangePkgHistory) obj)._PackageType) && (object.Equals((object) this._Reason, (object) ((StartChangePkgHistory) obj)._Reason) && this.CompareArrays((Array) this._TargetSystems, (Array) ((StartChangePkgHistory) obj)._TargetSystems))) && (this.CompareArrays((Array) this._Instances, (Array) ((StartChangePkgHistory) obj)._Instances) && object.Equals((object) this._Workflow, (object) ((StartChangePkgHistory) obj)._Workflow) && (object.Equals((object) this._NotifyOwnerAllStateChanges, (object) ((StartChangePkgHistory) obj)._NotifyOwnerAllStateChanges) && object.Equals((object) this._NotifyOwnerRoleAllStateChgs, (object) ((StartChangePkgHistory) obj)._NotifyOwnerRoleAllStateChgs)) && (object.Equals((object) this._Locklnstances, (object) ((StartChangePkgHistory) obj)._Locklnstances) && object.Equals((object) this._ECOECN, (object) ((StartChangePkgHistory) obj)._ECOECN) && (object.Equals((object) this._HistoryId, (object) ((StartChangePkgHistory) obj)._HistoryId) && object.Equals((object) this._RecommendedDeploymentDate, (object) ((StartChangePkgHistory) obj)._RecommendedDeploymentDate)))) && (object.Equals((object) this._Owner, (object) ((StartChangePkgHistory) obj)._Owner) && object.Equals((object) this._ChangePackageName, (object) ((StartChangePkgHistory) obj)._ChangePackageName)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new NamedObjectRef OwnerRole
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

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new NamedObjectRef Priority
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

    public new NamedObjectRef Reason
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

    public SubentityRef[] TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public SubentityRef[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (Instances));
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

    public new Primitive<bool> NotifyOwnerAllStateChanges
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

    public new Primitive<bool> NotifyOwnerRoleAllStateChgs
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

    public new Primitive<bool> Locklnstances
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

    public new Primitive<string> ECOECN
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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

    public new NamedObjectRef Owner
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

    public new Primitive<string> ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
