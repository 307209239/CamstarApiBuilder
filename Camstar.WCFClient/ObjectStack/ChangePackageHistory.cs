// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DeployChangePkgHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (StartChangePkgHistory))]
  [KnownType(typeof (UpdateChangePkgHistory))]
  [KnownType(typeof (ActivateChangePkgHistory))]
  [KnownType(typeof (AssignChangePkgContentHistory))]
  [Serializable]
  public class ChangePackageHistory : TrackableObjectHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_OwnerRole")]
    protected NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Priority")]
    protected NamedObjectRef _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Reason")]
    protected NamedObjectRef _Reason;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_NotifyOwnerAllStateChanges")]
    protected Primitive<bool> _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_ECOECN")]
    protected Primitive<string> _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Locklnstances")]
    protected Primitive<bool> _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_NotifyOwnerRoleAllStateChgs")]
    protected Primitive<bool> _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_ChangePackageName")]
    protected Primitive<string> _ChangePackageName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Owner")]
    protected NamedObjectRef _Owner;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageHistory && object.Equals((object) this._OwnerRole, (object) ((ChangePackageHistory) obj)._OwnerRole) && (object.Equals((object) this._ExportImportKey, (object) ((ChangePackageHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ChangePackageHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Priority, (object) ((ChangePackageHistory) obj)._Priority) && object.Equals((object) this._Reason, (object) ((ChangePackageHistory) obj)._Reason) && (object.Equals((object) this._NotifyOwnerAllStateChanges, (object) ((ChangePackageHistory) obj)._NotifyOwnerAllStateChanges) && object.Equals((object) this._ECOECN, (object) ((ChangePackageHistory) obj)._ECOECN))) && (object.Equals((object) this._Locklnstances, (object) ((ChangePackageHistory) obj)._Locklnstances) && object.Equals((object) this._NotifyOwnerRoleAllStateChgs, (object) ((ChangePackageHistory) obj)._NotifyOwnerRoleAllStateChgs) && (object.Equals((object) this._HistoryId, (object) ((ChangePackageHistory) obj)._HistoryId) && object.Equals((object) this._ChangePackageName, (object) ((ChangePackageHistory) obj)._ChangePackageName)) && object.Equals((object) this._Owner, (object) ((ChangePackageHistory) obj)._Owner)) && base.Equals(obj);
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

    public Primitive<string> ChangePackageName
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
