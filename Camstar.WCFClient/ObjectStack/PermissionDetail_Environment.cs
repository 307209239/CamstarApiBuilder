// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDetail_Environment
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
  public class PermissionDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Environment_RoleMaint")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "RoleMaint", false, false, false, "RoleMaint", 1052441, false, false, false, null)]
    protected RoleMaint_Environment _RoleMaint;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Environment_Role")]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Environment_Modes")]
    [Metadata("RBAC Permission Mode", "", false, false, false, "Integer", 1052440, false, true, false, null)]
    protected Environment _Modes;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1048872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Environment_ExecuteAction")]
    protected Environment _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Environment_ObjectInstanceId")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050799, false, false, false, null)]
    protected Environment _ObjectInstanceId;

    public RoleMaint_Environment RoleMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleMaint), (object) value);
      }
      get
      {
        return (RoleMaint_Environment) this.PropertyGet(nameof (RoleMaint));
      }
    }

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment Modes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Modes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Modes));
      }
    }

    public Environment ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteAction));
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
  }
}
