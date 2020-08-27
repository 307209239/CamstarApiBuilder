// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Assignment_Environment
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
  public class Assignment_Environment : ProcessObjectTxn_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1052050, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Environment_CurrentRole")]
    protected Environment _CurrentRole;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1052214, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Environment_AssigneeRole")]
    protected Environment _AssigneeRole;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052087, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Environment_CurrentAssignee")]
    protected Environment _CurrentAssignee;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052213, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Environment_Assignee")]
    protected Environment _Assignee;

    public Environment CurrentRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentRole));
      }
    }

    public Environment AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Environment CurrentAssignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentAssignee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentAssignee));
      }
    }

    public Environment Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
