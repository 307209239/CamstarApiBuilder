// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageModelingInquiry
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
  public class ChangePackageModelingInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_AssociatedChangePackages")]
    protected NamedObjectRef _AssociatedChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_ChangePackagesToRemove")]
    protected NamedObjectRef _ChangePackagesToRemove;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_AvailableChangePackages")]
    protected NamedObjectRef _AvailableChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_IsChangeMgtSave")]
    protected Primitive<bool> _IsChangeMgtSave;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_AssociatedPackagesCount")]
    protected Primitive<int> _AssociatedPackagesCount;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_MaintenanceTypeID")]
    protected Primitive<int> _MaintenanceTypeID;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_IsLockInstance")]
    protected Primitive<bool> _IsLockInstance;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_HasChangePackage")]
    protected Primitive<bool> _HasChangePackage;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageModelingInquiry && object.Equals((object) this._AssociatedChangePackages, (object) ((ChangePackageModelingInquiry) obj)._AssociatedChangePackages) && (object.Equals((object) this._ChangePackagesToRemove, (object) ((ChangePackageModelingInquiry) obj)._ChangePackagesToRemove) && object.Equals((object) this._AvailableChangePackages, (object) ((ChangePackageModelingInquiry) obj)._AvailableChangePackages)) && (object.Equals((object) this._IsChangeMgtSave, (object) ((ChangePackageModelingInquiry) obj)._IsChangeMgtSave) && object.Equals((object) this._AssociatedPackagesCount, (object) ((ChangePackageModelingInquiry) obj)._AssociatedPackagesCount) && (object.Equals((object) this._MaintenanceTypeID, (object) ((ChangePackageModelingInquiry) obj)._MaintenanceTypeID) && object.Equals((object) this._IsLockInstance, (object) ((ChangePackageModelingInquiry) obj)._IsLockInstance))) && (object.Equals((object) this._ObjectInstanceId, (object) ((ChangePackageModelingInquiry) obj)._ObjectInstanceId) && object.Equals((object) this._HasChangePackage, (object) ((ChangePackageModelingInquiry) obj)._HasChangePackage)) && base.Equals(obj);
    }

    public NamedObjectRef AssociatedChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedChangePackages), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssociatedChangePackages));
      }
    }

    public NamedObjectRef ChangePackagesToRemove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackagesToRemove), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackagesToRemove));
      }
    }

    public NamedObjectRef AvailableChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableChangePackages), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AvailableChangePackages));
      }
    }

    public Primitive<bool> IsChangeMgtSave
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsChangeMgtSave), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsChangeMgtSave));
      }
    }

    public Primitive<int> AssociatedPackagesCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackagesCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackagesCount));
      }
    }

    public Primitive<int> MaintenanceTypeID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceTypeID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaintenanceTypeID));
      }
    }

    public Primitive<bool> IsLockInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLockInstance), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLockInstance));
      }
    }

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Primitive<bool> HasChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasChangePackage), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasChangePackage));
      }
    }
  }
}
