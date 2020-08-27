// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrailHeader
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
  public class V4_SecurityAuditTrailHeader : AuditTrailHeader
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_TxnName")]
    protected new Primitive<string> _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_AuditTrail")]
    protected V4_SecurityAuditTrail[] _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_TxnDateGMT")]
    protected new Primitive<DateTime> _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_SystemDate")]
    protected new Primitive<DateTime> _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_SystemDateGMT")]
    protected new Primitive<DateTime> _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_TxnDate")]
    protected new Primitive<DateTime> _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_ExecuteActionId")]
    protected new Primitive<int> _ExecuteActionId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_ObjectTypeId")]
    protected new Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_ExecuteAction")]
    protected new Primitive<string> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_UserName")]
    protected new Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_CopyFromServiceName")]
    protected Primitive<string> _CopyFromServiceName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_ObjectTypeName")]
    protected new Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_EmployeeName")]
    protected new Primitive<string> _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_User")]
    protected new NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailHeader_Employee")]
    protected new NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is V4_SecurityAuditTrailHeader && object.Equals((object) this._ExportImportKey, (object) ((V4_SecurityAuditTrailHeader) obj)._ExportImportKey) && (object.Equals((object) this._TxnName, (object) ((V4_SecurityAuditTrailHeader) obj)._TxnName) && object.Equals((object) this._Comments, (object) ((V4_SecurityAuditTrailHeader) obj)._Comments)) && (this.CompareArrays((Array) this._AuditTrail, (Array) ((V4_SecurityAuditTrailHeader) obj)._AuditTrail) && object.Equals((object) this._TxnDateGMT, (object) ((V4_SecurityAuditTrailHeader) obj)._TxnDateGMT) && (object.Equals((object) this._SystemDate, (object) ((V4_SecurityAuditTrailHeader) obj)._SystemDate) && object.Equals((object) this._SystemDateGMT, (object) ((V4_SecurityAuditTrailHeader) obj)._SystemDateGMT))) && (object.Equals((object) this._TxnDate, (object) ((V4_SecurityAuditTrailHeader) obj)._TxnDate) && object.Equals((object) this._HistoryId, (object) ((V4_SecurityAuditTrailHeader) obj)._HistoryId) && (object.Equals((object) this._ExecuteActionId, (object) ((V4_SecurityAuditTrailHeader) obj)._ExecuteActionId) && object.Equals((object) this._ObjectTypeId, (object) ((V4_SecurityAuditTrailHeader) obj)._ObjectTypeId)) && (object.Equals((object) this._ExecuteAction, (object) ((V4_SecurityAuditTrailHeader) obj)._ExecuteAction) && object.Equals((object) this._UserName, (object) ((V4_SecurityAuditTrailHeader) obj)._UserName) && (object.Equals((object) this._CopyFromServiceName, (object) ((V4_SecurityAuditTrailHeader) obj)._CopyFromServiceName) && object.Equals((object) this._ObjectTypeName, (object) ((V4_SecurityAuditTrailHeader) obj)._ObjectTypeName)))) && (object.Equals((object) this._EmployeeName, (object) ((V4_SecurityAuditTrailHeader) obj)._EmployeeName) && object.Equals((object) this._User, (object) ((V4_SecurityAuditTrailHeader) obj)._User) && object.Equals((object) this._Employee, (object) ((V4_SecurityAuditTrailHeader) obj)._Employee)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Primitive<string> TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TxnName));
      }
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public V4_SecurityAuditTrail[] AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrail[]) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public new Primitive<DateTime> TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public new Primitive<DateTime> SystemDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SystemDate));
      }
    }

    public new Primitive<DateTime> SystemDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SystemDateGMT));
      }
    }

    public new Primitive<DateTime> TxnDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnDate));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Primitive<int> ExecuteActionId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteActionId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecuteActionId));
      }
    }

    public new Primitive<int> ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public new Primitive<string> ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public new Primitive<string> UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserName));
      }
    }

    public Primitive<string> CopyFromServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CopyFromServiceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CopyFromServiceName));
      }
    }

    public new Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Primitive<string> EmployeeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EmployeeName));
      }
    }

    public new NamedObjectRef User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (User));
      }
    }

    public new NamedObjectRef Employee
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
