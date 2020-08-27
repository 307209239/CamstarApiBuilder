// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrailHeader_Environment
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
  public class ModelingAuditTrailHeader_Environment : AuditTrailHeader_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_TxnName")]
    [Metadata("TxnName", "", false, false, true, "String", 1048975, false, false, false, null)]
    protected new Environment _TxnName;
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1052249, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ObjectRevisionOrParent")]
    protected Environment _ObjectRevisionOrParent;
    [Metadata("DisplayName", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ObjectName")]
    protected Environment _ObjectName;
    [Metadata("Details of the Audit Trail information captured during maintenance of modeling data objects", "ModelingAuditTrail", false, false, true, "ModelingAuditTrail", 1050769, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_AuditTrail")]
    protected ModelingAuditTrail_Environment _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_MassUpdates")]
    [Metadata("LongString", "", false, false, true, "String", 16779378, false, true, false, null)]
    protected Environment _MassUpdates;
    [Metadata("Generic String", "", false, false, true, "String", 1051795, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ParentInstanceId")]
    protected Environment _ParentInstanceId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050784, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ObjectTypeId")]
    protected new Environment _ObjectTypeId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048863, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_TxnDate")]
    protected new Environment _TxnDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049107, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_SystemDate")]
    protected new Environment _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ExecuteActionId")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050822, false, false, false, null)]
    protected new Environment _ExecuteActionId;
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1050778, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ParentTypeId")]
    protected Environment _ParentTypeId;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic String", "", false, false, true, "String", 1048872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ExecuteAction")]
    protected new Environment _ExecuteAction;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049109, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_TxnDateGMT")]
    protected new Environment _TxnDateGMT;
    [Metadata("Generic String", "", false, false, true, "String", 16777354, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_PackageName")]
    protected Environment _PackageName;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049108, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_SystemDateGMT")]
    protected new Environment _SystemDateGMT;
    [Metadata("Generic String", "", false, false, true, "String", 1050773, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1050776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ObjectTypeName")]
    protected new Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_User")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048864, false, false, false, null)]
    protected new Environment _User;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_EmployeeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049932, false, false, false, null)]
    protected new Environment _EmployeeName;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_Employee")]
    protected new Environment _Employee;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1050777, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_ParentRevision")]
    protected Environment _ParentRevision;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Environment_UserName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049444, false, false, false, null)]
    protected new Environment _UserName;

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

    public Environment ObjectRevisionOrParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevisionOrParent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectRevisionOrParent));
      }
    }

    public Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ModelingAuditTrail_Environment AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrail_Environment) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Environment MassUpdates
    {
      [param: In] set
      {
        this.PropertySet(nameof (MassUpdates), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MassUpdates));
      }
    }

    public Environment ParentInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentInstanceId));
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

    public Environment ParentTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentTypeId));
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

    public Environment PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageName));
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

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
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

    public Environment ParentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentRevision));
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
  }
}
