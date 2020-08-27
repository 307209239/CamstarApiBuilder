// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignPermissions
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
  public class AssignPermissions : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_ObjectInstanceId")]
    protected NamedObjectRef _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_ServiceDetails")]
    protected PermissionDetail[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is AssignPermissions && object.Equals((object) this._Role, (object) ((AssignPermissions) obj)._Role) && (object.Equals((object) this._ObjectInstanceId, (object) ((AssignPermissions) obj)._ObjectInstanceId) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((AssignPermissions) obj)._ServiceDetails)) && base.Equals(obj);
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public NamedObjectRef ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public PermissionDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PermissionDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
