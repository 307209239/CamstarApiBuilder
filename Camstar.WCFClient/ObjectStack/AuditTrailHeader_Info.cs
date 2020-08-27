// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailHeader_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (V4_SecurityAuditTrailHeader_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ModelingAuditTrailHeader_Info))]
  [Serializable]
  public class AuditTrailHeader_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_AuditTrail")]
    protected AuditTrail_Info _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_TxnName")]
    protected Info _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_TxnDate")]
    protected Info _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_ExecuteActionId")]
    protected Info _ExecuteActionId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_ExecuteAction")]
    protected Info _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_TxnDateGMT")]
    protected Info _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_SystemDate")]
    protected Info _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_SystemDateGMT")]
    protected Info _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_EmployeeName")]
    protected Info _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_User")]
    protected Info _User;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_UserName")]
    protected Info _UserName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_Employee")]
    protected Info _Employee;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public AuditTrail_Info AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (AuditTrail_Info) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Info TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnName));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info TxnDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnDate));
      }
    }

    public Info ExecuteActionId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteActionId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecuteActionId));
      }
    }

    public Info ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Info ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Info TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Info SystemDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SystemDate));
      }
    }

    public Info SystemDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SystemDateGMT));
      }
    }

    public Info EmployeeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeName));
      }
    }

    public Info User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (User));
      }
    }

    public Info UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserName));
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

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
