// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RoleChanges
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
  public class RoleChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_RoleType")]
    protected Enumeration<RoleTypeEnum, int> _RoleType;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_PermissionType")]
    protected Enumeration<PermissionTypeEnum, int> _PermissionType;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Permissions")]
    protected RolePermissionChanges[] _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_FilteredPermissions")]
    protected RolePermissionChanges[] _FilteredPermissions;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Members")]
    protected EmployeeRoleChanges[] _Members;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is RoleChanges && object.Equals((object) this._ObjectToChange, (object) ((RoleChanges) obj)._ObjectToChange) && (object.Equals((object) this._RoleType, (object) ((RoleChanges) obj)._RoleType) && object.Equals((object) this._PermissionType, (object) ((RoleChanges) obj)._PermissionType)) && (this.CompareArrays((Array) this._Permissions, (Array) ((RoleChanges) obj)._Permissions) && this.CompareArrays((Array) this._FilteredPermissions, (Array) ((RoleChanges) obj)._FilteredPermissions) && (this.CompareArrays((Array) this._Members, (Array) ((RoleChanges) obj)._Members) && object.Equals((object) this._Name, (object) ((RoleChanges) obj)._Name))) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<RoleTypeEnum, int> RoleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleType), (object) value);
      }
      get
      {
        return (Enumeration<RoleTypeEnum, int>) this.PropertyGet(nameof (RoleType));
      }
    }

    public Enumeration<PermissionTypeEnum, int> PermissionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionType), (object) value);
      }
      get
      {
        return (Enumeration<PermissionTypeEnum, int>) this.PropertyGet(nameof (PermissionType));
      }
    }

    public RolePermissionChanges[] Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (RolePermissionChanges[]) this.PropertyGet(nameof (Permissions));
      }
    }

    public RolePermissionChanges[] FilteredPermissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilteredPermissions), (object) value);
      }
      get
      {
        return (RolePermissionChanges[]) this.PropertyGet(nameof (FilteredPermissions));
      }
    }

    public EmployeeRoleChanges[] Members
    {
      [param: In] set
      {
        this.PropertySet(nameof (Members), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges[]) this.PropertyGet(nameof (Members));
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
  }
}
