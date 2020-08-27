// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeRoleChanges_Info
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
  public class EmployeeRoleChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_PropagateToChildOrgs")]
    protected Info _PropagateToChildOrgs;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleChanges_Info_Employee")]
    protected Info _Employee;

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info PropagateToChildOrgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PropagateToChildOrgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PropagateToChildOrgs));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Employee));
      }
    }
  }
}
