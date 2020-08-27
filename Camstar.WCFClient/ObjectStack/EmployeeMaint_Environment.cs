// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeMaint_Environment
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
  public class EmployeeMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Changes CDO for Employee.", "EmployeeChanges", false, false, false, "EmployeeChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_Environment_ObjectChanges")]
    protected EmployeeChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_Environment_SyncName")]
    [Metadata("Generic String", "", false, false, false, "String", 1050975, false, false, false, null)]
    protected new Environment _SyncName;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public EmployeeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EmployeeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SyncName));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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
  }
}
