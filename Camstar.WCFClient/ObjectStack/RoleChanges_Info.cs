// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RoleChanges_Info
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
  public class RoleChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_RoleType")]
    protected Info _RoleType;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_PermissionType")]
    protected Info _PermissionType;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_Permissions")]
    protected RolePermissionChanges_Info _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_FilteredPermissions")]
    protected RolePermissionChanges_Info _FilteredPermissions;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_Members")]
    protected EmployeeRoleChanges_Info _Members;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info RoleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RoleType));
      }
    }

    public Info PermissionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PermissionType));
      }
    }

    public RolePermissionChanges_Info Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (RolePermissionChanges_Info) this.PropertyGet(nameof (Permissions));
      }
    }

    public RolePermissionChanges_Info FilteredPermissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilteredPermissions), (object) value);
      }
      get
      {
        return (RolePermissionChanges_Info) this.PropertyGet(nameof (FilteredPermissions));
      }
    }

    public EmployeeRoleChanges_Info Members
    {
      [param: In] set
      {
        this.PropertySet(nameof (Members), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges_Info) this.PropertyGet(nameof (Members));
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
  }
}
