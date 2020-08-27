// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageModelingInquiry_Environment
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
  public class ChangePackageModelingInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_AssociatedChangePackages")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 16777948, false, false, true, null)]
    protected Environment _AssociatedChangePackages;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 16777949, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_ChangePackagesToRemove")]
    protected Environment _ChangePackagesToRemove;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_AvailableChangePackages")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 16777947, false, false, true, null)]
    protected Environment _AvailableChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_IsChangeMgtSave")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778045, false, false, false, "0")]
    protected Environment _IsChangeMgtSave;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_AssociatedPackagesCount")]
    protected Environment _AssociatedPackagesCount;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778031, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_MaintenanceTypeID")]
    protected Environment _MaintenanceTypeID;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_IsLockInstance")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    protected Environment _IsLockInstance;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_ObjectInstanceId")]
    [Metadata("Generic String", "", false, false, false, "String", 1050773, false, false, false, null)]
    protected Environment _ObjectInstanceId;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageModelingInquiry_Environment_HasChangePackage")]
    protected Environment _HasChangePackage;

    public Environment AssociatedChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedChangePackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedChangePackages));
      }
    }

    public Environment ChangePackagesToRemove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackagesToRemove), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackagesToRemove));
      }
    }

    public Environment AvailableChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableChangePackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AvailableChangePackages));
      }
    }

    public Environment IsChangeMgtSave
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsChangeMgtSave), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsChangeMgtSave));
      }
    }

    public Environment AssociatedPackagesCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackagesCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedPackagesCount));
      }
    }

    public Environment MaintenanceTypeID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceTypeID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceTypeID));
      }
    }

    public Environment IsLockInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLockInstance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLockInstance));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Environment HasChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasChangePackage));
      }
    }
  }
}
