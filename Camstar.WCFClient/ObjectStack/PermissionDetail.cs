// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PermissionDetail
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
  public class PermissionDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_RoleMaint")]
    protected RoleMaint _RoleMaint;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_Modes")]
    protected Primitive<int>[] _Modes;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_ExecuteAction")]
    protected Primitive<int> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "PermissionDetail_ObjectInstanceId")]
    protected BaseObjectRef _ObjectInstanceId;

    public override bool Equals(object obj)
    {
      return obj is PermissionDetail && object.Equals((object) this._RoleMaint, (object) ((PermissionDetail) obj)._RoleMaint) && (object.Equals((object) this._Role, (object) ((PermissionDetail) obj)._Role) && this.CompareArrays((Array) this._Modes, (Array) ((PermissionDetail) obj)._Modes)) && (object.Equals((object) this._ExecuteAction, (object) ((PermissionDetail) obj)._ExecuteAction) && object.Equals((object) this._ObjectInstanceId, (object) ((PermissionDetail) obj)._ObjectInstanceId)) && base.Equals(obj);
    }

    public RoleMaint RoleMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleMaint), (object) value);
      }
      get
      {
        return (RoleMaint) this.PropertyGet(nameof (RoleMaint));
      }
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

    public Primitive<int>[] Modes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Modes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (Modes));
      }
    }

    public Primitive<int> ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public BaseObjectRef ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }
  }
}
