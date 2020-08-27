// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RoleChangesWithPermissions_Environment
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
  public class RoleChangesWithPermissions_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RoleChangesWithPermissions_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RoleChangesWithPermissions_Environment_Permissions")]
    [Metadata("A permission is a positive authorization to perform an action, for example the permission to create an object.", "RolePermissionChanges", false, false, false, "RolePermissionChanges", 1050786, false, true, false, null)]
    protected RolePermissionChanges_Environment _Permissions;

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
  }
}
