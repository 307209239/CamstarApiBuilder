// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RoleChangesWithPermissions
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
  public class RoleChangesWithPermissions : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RoleChangesWithPermissions_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RoleChangesWithPermissions_Permissions")]
    protected RolePermissionChanges[] _Permissions;

    public override bool Equals(object obj)
    {
      return obj is RoleChangesWithPermissions && object.Equals((object) this._ObjectToChange, (object) ((RoleChangesWithPermissions) obj)._ObjectToChange) && this.CompareArrays((Array) this._Permissions, (Array) ((RoleChangesWithPermissions) obj)._Permissions) && base.Equals(obj);
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
  }
}
