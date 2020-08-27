// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RoleChanges_Environment
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
  public class RoleChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_ObjectToChange")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Role Types:\r\n1. Shopfloor\r\n2. Quality\r\n3. Change Management", "RoleTypeEnum", false, false, false, "Integer", 16778922, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_RoleType")]
    protected Environment _RoleType;
    [Metadata("RBAC Permission Type", "PermissionTypeEnum", false, false, false, "Integer", 1051573, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_PermissionType")]
    protected Environment _PermissionType;
    [Metadata("A permission is a positive authorization to perform an action, for example the permission to create an object.", "RolePermissionChanges", false, false, false, "RolePermissionChanges", 1051570, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_Permissions")]
    protected RolePermissionChanges_Environment _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_FilteredPermissions")]
    [Metadata("A permission is a positive authorization to perform an action, for example the permission to create an object.", "RolePermissionChanges", false, false, true, "RolePermissionChanges", 1051570, false, true, true, null)]
    protected RolePermissionChanges_Environment _FilteredPermissions;
    [Metadata("Employee's Role membership in an Organizational context", "EmployeeRoleChanges", false, false, false, "EmployeeRoleChanges", 1051563, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_Members")]
    protected EmployeeRoleChanges_Environment _Members;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051555, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RoleChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment RoleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RoleType));
      }
    }

    public Environment PermissionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PermissionType));
      }
    }

    public RolePermissionChanges_Environment Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (RolePermissionChanges_Environment) this.PropertyGet(nameof (Permissions));
      }
    }

    public RolePermissionChanges_Environment FilteredPermissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilteredPermissions), (object) value);
      }
      get
      {
        return (RolePermissionChanges_Environment) this.PropertyGet(nameof (FilteredPermissions));
      }
    }

    public EmployeeRoleChanges_Environment Members
    {
      [param: In] set
      {
        this.PropertySet(nameof (Members), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges_Environment) this.PropertyGet(nameof (Members));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
