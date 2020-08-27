// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeRoleMaint_Environment
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
  public class EmployeeRoleMaint_Environment : SubentityMaintenance_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Environment_Role")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1050342, false, false, true, null)]
    protected Environment _Role;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Environment_Organization")]
    protected Environment _Organization;
    [Metadata("Employee's Role membership in an Organizational context", "EmployeeRoleChanges", false, false, false, "EmployeeRoleChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Environment_ObjectChanges")]
    protected EmployeeRoleChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Environment_ObjectToChange")]
    [Metadata("Employee's Role membership in an Organizational context", "EmployeeRole", false, false, true, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeRoleMaint_Environment_ParentDataObject")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1050488, false, false, true, null)]
    protected new Environment _ParentDataObject;

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public EmployeeRoleChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EmployeeRoleChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

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

    public new Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
