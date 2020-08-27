// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageModelingInquiry_Info
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
  public class ChangePackageModelingInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_AssociatedChangePackages")]
    protected Info _AssociatedChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_ChangePackagesToRemove")]
    protected Info _ChangePackagesToRemove;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_AvailableChangePackages")]
    protected Info _AvailableChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_IsChangeMgtSave")]
    protected Info _IsChangeMgtSave;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_AssociatedPackagesCount")]
    protected Info _AssociatedPackagesCount;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_MaintenanceTypeID")]
    protected Info _MaintenanceTypeID;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_IsLockInstance")]
    protected Info _IsLockInstance;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Info_HasChangePackage")]
    protected Info _HasChangePackage;

    public Info AssociatedChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedChangePackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedChangePackages));
      }
    }

    public Info ChangePackagesToRemove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackagesToRemove), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackagesToRemove));
      }
    }

    public Info AvailableChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableChangePackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AvailableChangePackages));
      }
    }

    public Info IsChangeMgtSave
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsChangeMgtSave), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsChangeMgtSave));
      }
    }

    public Info AssociatedPackagesCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackagesCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackagesCount));
      }
    }

    public Info MaintenanceTypeID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceTypeID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceTypeID));
      }
    }

    public Info IsLockInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLockInstance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLockInstance));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Info HasChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasChangePackage));
      }
    }
  }
}
