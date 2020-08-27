// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeRoleMaint_Info
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
  public class EmployeeRoleMaint_Info : SubentityMaintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Info_ObjectChanges")]
    protected EmployeeRoleChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Info_ParentDataObject")]
    protected new Info _ParentDataObject;

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

    public EmployeeRoleChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges_Info) this.PropertyGet(nameof (ObjectChanges));
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

    public new Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
