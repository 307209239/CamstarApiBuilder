// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RolePermissionChanges
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
  public class RolePermissionChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_PermissionType")]
    protected Enumeration<PermissionTypeEnum, int> _PermissionType;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_Modes")]
    protected Primitive<int>[] _Modes;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_ObjectMetaId")]
    protected Primitive<int> _ObjectMetaId;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_ObjectInstanceIdString")]
    protected Primitive<string> _ObjectInstanceIdString;
    [DataMember(EmitDefaultValue = false, Name = "RolePermissionChanges_ObjectInstanceId")]
    protected BaseObjectRef _ObjectInstanceId;

    public override bool Equals(object obj)
    {
      return obj is RolePermissionChanges && object.Equals((object) this._Name, (object) ((RolePermissionChanges) obj)._Name) && (object.Equals((object) this._DisplayName, (object) ((RolePermissionChanges) obj)._DisplayName) && object.Equals((object) this._ObjectToChange, (object) ((RolePermissionChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ListItemToChange, (object) ((RolePermissionChanges) obj)._ListItemToChange) && object.Equals((object) this._PermissionType, (object) ((RolePermissionChanges) obj)._PermissionType) && (this.CompareArrays((Array) this._Modes, (Array) ((RolePermissionChanges) obj)._Modes) && object.Equals((object) this._ObjectMetaId, (object) ((RolePermissionChanges) obj)._ObjectMetaId))) && (object.Equals((object) this._ObjectInstanceIdString, (object) ((RolePermissionChanges) obj)._ObjectInstanceIdString) && object.Equals((object) this._ObjectInstanceId, (object) ((RolePermissionChanges) obj)._ObjectInstanceId)) && base.Equals(obj);
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

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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

    public Primitive<int> ObjectMetaId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectMetaId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectMetaId));
      }
    }

    public Primitive<string> ObjectInstanceIdString
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceIdString), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceIdString));
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
