// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrailHeader_Environment
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
  public class V4_SecurityAuditTrailHeader_Environment : AuditTrailHeader_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("TxnName", "", false, false, true, "String", 1048975, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_TxnName")]
    protected new Environment _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [Metadata("Details of the Audit Trail information captured during maintenance of InSite Security", "V4_SecurityAuditTrail", false, false, true, "V4_SecurityAuditTrail", 1050769, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_AuditTrail")]
    protected V4_SecurityAuditTrail_Environment _AuditTrail;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049109, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_TxnDateGMT")]
    protected new Environment _TxnDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049107, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_SystemDate")]
    protected new Environment _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_SystemDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049108, false, false, false, null)]
    protected new Environment _SystemDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048863, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_TxnDate")]
    protected new Environment _TxnDate;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050822, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_ExecuteActionId")]
    protected new Environment _ExecuteActionId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050784, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_ObjectTypeId")]
    protected new Environment _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_ExecuteAction")]
    [Metadata("Generic String", "", false, false, true, "String", 1048872, false, false, false, null)]
    protected new Environment _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_UserName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049444, false, false, false, null)]
    protected new Environment _UserName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_CopyFromServiceName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049826, false, false, false, null)]
    protected Environment _CopyFromServiceName;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1050776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_ObjectTypeName")]
    protected new Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_EmployeeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049932, false, false, false, null)]
    protected new Environment _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_User")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048864, false, false, false, null)]
    protected new Environment _User;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Environment_Employee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    protected new Environment _Employee;

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

    public new Environment TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnName));
      }
    }

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public V4_SecurityAuditTrail_Environment AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrail_Environment) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public new Environment TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public new Environment SystemDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SystemDate));
      }
    }

    public new Environment SystemDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SystemDateGMT));
      }
    }

    public new Environment TxnDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnDate));
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

    public new Environment ExecuteActionId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteActionId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteActionId));
      }
    }

    public new Environment ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public new Environment ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public new Environment UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserName));
      }
    }

    public Environment CopyFromServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CopyFromServiceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CopyFromServiceName));
      }
    }

    public new Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Environment EmployeeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeName));
      }
    }

    public new Environment User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (User));
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
  }
}
