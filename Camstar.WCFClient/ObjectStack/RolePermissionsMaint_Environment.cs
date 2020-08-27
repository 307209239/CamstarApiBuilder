// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RolePermissionsMaint_Environment
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
  public class RolePermissionsMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Environment_ObjectToChange")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Environment_ObjectListInquiry")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("RBAC Permission Type", "PermissionTypeEnum", false, true, false, "Integer", 1051556, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Environment_PermissionType")]
    protected Environment _PermissionType;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.", "RoleChangesWithPermissions", false, false, false, "RoleChangesWithPermissions", 1048873, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Environment_ObjectChanges")]
    protected RoleChangesWithPermissions_Environment _ObjectChanges;
    [Metadata("RBAC Permission Mode", "", false, false, true, "Integer", 1051560, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_Environment_PermissionMode")]
    protected Environment _PermissionMode;

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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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

    public RoleChangesWithPermissions_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RoleChangesWithPermissions_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment PermissionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PermissionMode));
      }
    }
  }
}
