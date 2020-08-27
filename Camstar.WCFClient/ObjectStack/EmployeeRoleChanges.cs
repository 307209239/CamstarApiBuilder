// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeRoleChanges
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
  public class EmployeeRoleChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_PropagateToChildOrgs")]
    protected Primitive<bool> _PropagateToChildOrgs;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Employee")]
    protected NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is EmployeeRoleChanges && object.Equals((object) this._Role, (object) ((EmployeeRoleChanges) obj)._Role) && (object.Equals((object) this._ObjectToChange, (object) ((EmployeeRoleChanges) obj)._ObjectToChange) && object.Equals((object) this._Organization, (object) ((EmployeeRoleChanges) obj)._Organization)) && (object.Equals((object) this._ListItemToChange, (object) ((EmployeeRoleChanges) obj)._ListItemToChange) && object.Equals((object) this._PropagateToChildOrgs, (object) ((EmployeeRoleChanges) obj)._PropagateToChildOrgs) && (object.Equals((object) this._IsFrozen, (object) ((EmployeeRoleChanges) obj)._IsFrozen) && object.Equals((object) this._Employee, (object) ((EmployeeRoleChanges) obj)._Employee))) && base.Equals(obj);
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

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> PropagateToChildOrgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PropagateToChildOrgs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PropagateToChildOrgs));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedObjectRef Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Employee));
      }
    }
  }
}
