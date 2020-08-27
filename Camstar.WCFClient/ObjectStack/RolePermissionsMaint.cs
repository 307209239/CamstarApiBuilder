// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RolePermissionsMaint
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
  public class RolePermissionsMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_PermissionType")]
    protected Enumeration<PermissionTypeEnum, int> _PermissionType;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_ObjectChanges")]
    protected RoleChangesWithPermissions _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionsMaint_PermissionMode")]
    protected Primitive<int> _PermissionMode;

    public override bool Equals(object obj)
    {
      return obj is RolePermissionsMaint && object.Equals((object) this._ObjectToChange, (object) ((RolePermissionsMaint) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((RolePermissionsMaint) obj)._ObjectListInquiry) && object.Equals((object) this._PermissionType, (object) ((RolePermissionsMaint) obj)._PermissionType)) && (object.Equals((object) this._ObjectChanges, (object) ((RolePermissionsMaint) obj)._ObjectChanges) && object.Equals((object) this._PermissionMode, (object) ((RolePermissionsMaint) obj)._PermissionMode)) && base.Equals(obj);
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

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
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

    public RoleChangesWithPermissions ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RoleChangesWithPermissions) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<int> PermissionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PermissionMode), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (PermissionMode));
      }
    }
  }
}
