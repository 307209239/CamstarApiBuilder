// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailHeader
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (V4_SecurityAuditTrailHeader))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ModelingAuditTrailHeader))]
  [Serializable]
  public class AuditTrailHeader : HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_AuditTrail")]
    protected Camstar.WCF.ObjectStack.AuditTrail[] _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_TxnName")]
    protected Primitive<string> _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_TxnDate")]
    protected Primitive<DateTime> _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_ExecuteActionId")]
    protected Primitive<int> _ExecuteActionId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_ExecuteAction")]
    protected Primitive<string> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_TxnDateGMT")]
    protected Primitive<DateTime> _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_SystemDate")]
    protected Primitive<DateTime> _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_SystemDateGMT")]
    protected Primitive<DateTime> _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_EmployeeName")]
    protected Primitive<string> _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_User")]
    protected NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_UserName")]
    protected Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_Employee")]
    protected NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailHeader_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailHeader && object.Equals((object) this._Comments, (object) ((AuditTrailHeader) obj)._Comments) && (this.CompareArrays((Array) this._AuditTrail, (Array) ((AuditTrailHeader) obj)._AuditTrail) && object.Equals((object) this._TxnName, (object) ((AuditTrailHeader) obj)._TxnName)) && (object.Equals((object) this._ExportImportKey, (object) ((AuditTrailHeader) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((AuditTrailHeader) obj)._HistoryId) && (object.Equals((object) this._TxnDate, (object) ((AuditTrailHeader) obj)._TxnDate) && object.Equals((object) this._ExecuteActionId, (object) ((AuditTrailHeader) obj)._ExecuteActionId))) && (object.Equals((object) this._ExecuteAction, (object) ((AuditTrailHeader) obj)._ExecuteAction) && object.Equals((object) this._ObjectTypeId, (object) ((AuditTrailHeader) obj)._ObjectTypeId) && (object.Equals((object) this._TxnDateGMT, (object) ((AuditTrailHeader) obj)._TxnDateGMT) && object.Equals((object) this._SystemDate, (object) ((AuditTrailHeader) obj)._SystemDate)) && (object.Equals((object) this._SystemDateGMT, (object) ((AuditTrailHeader) obj)._SystemDateGMT) && object.Equals((object) this._EmployeeName, (object) ((AuditTrailHeader) obj)._EmployeeName) && (object.Equals((object) this._User, (object) ((AuditTrailHeader) obj)._User) && object.Equals((object) this._UserName, (object) ((AuditTrailHeader) obj)._UserName)))) && (object.Equals((object) this._Employee, (object) ((AuditTrailHeader) obj)._Employee) && object.Equals((object) this._ObjectTypeName, (object) ((AuditTrailHeader) obj)._ObjectTypeName)) && base.Equals(obj);
    }

    public Primitive<string> Comments
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

    public Camstar.WCF.ObjectStack.AuditTrail[] AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.AuditTrail[]) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Primitive<string> TxnName
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

    public Primitive<DateTime> TxnDate
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

    public Primitive<int> ExecuteActionId
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

    public Primitive<string> ExecuteAction
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

    public Primitive<int> ObjectTypeId
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

    public Primitive<DateTime> TxnDateGMT
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

    public Primitive<DateTime> SystemDate
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

    public Primitive<DateTime> SystemDateGMT
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

    public Primitive<string> EmployeeName
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

    public NamedObjectRef User
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

    public Primitive<string> UserName
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

    public NamedObjectRef Employee
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

    public Primitive<string> ObjectTypeName
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
  }
}
