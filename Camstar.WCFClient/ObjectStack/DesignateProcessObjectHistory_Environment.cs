﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DesignateProcessObjectHistory_Environment
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
  public class DesignateProcessObjectHistory_Environment : ProcessObjectTxnHistory_Environment
  {
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_QualityObject")]
    protected new Environment _QualityObject;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1052058, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_FromRole")]
    protected Environment _FromRole;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1052060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_ToRole")]
    protected Environment _ToRole;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_ProcessObject")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1051396, false, false, false, null)]
    protected new Environment _ProcessObject;
    [Metadata("Enumeration for the Assignee Option:\r\n1 = Assignee\r\n2 = Owner\r\n3 = Collaborator", "AssigneeOptionEnum", false, false, true, "Integer", 1052123, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_AssigneeOption")]
    protected Environment _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_Employee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    protected new Environment _Employee;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_FromUser")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052219, false, false, false, null)]
    protected Environment _FromUser;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052220, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Environment_ToUser")]
    protected Environment _ToUser;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment FromRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromRole));
      }
    }

    public Environment ToRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToRole));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Environment AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Environment Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Employee));
      }
    }

    public Environment FromUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromUser), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromUser));
      }
    }

    public Environment ToUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToUser), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToUser));
      }
    }
  }
}
