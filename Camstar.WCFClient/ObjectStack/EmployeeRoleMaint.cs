// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeRoleMaint
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
  public class EmployeeRoleMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_ObjectChanges")]
    protected EmployeeRoleChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is EmployeeRoleMaint && object.Equals((object) this._Role, (object) ((EmployeeRoleMaint) obj)._Role) && (object.Equals((object) this._Organization, (object) ((EmployeeRoleMaint) obj)._Organization) && object.Equals((object) this._ObjectChanges, (object) ((EmployeeRoleMaint) obj)._ObjectChanges)) && (object.Equals((object) this._ObjectToChange, (object) ((EmployeeRoleMaint) obj)._ObjectToChange) && object.Equals((object) this._ParentDataObject, (object) ((EmployeeRoleMaint) obj)._ParentDataObject)) && base.Equals(obj);
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

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public EmployeeRoleChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
