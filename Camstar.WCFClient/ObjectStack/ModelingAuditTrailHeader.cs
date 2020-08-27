// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrailHeader
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
  public class ModelingAuditTrailHeader : AuditTrailHeader
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_TxnName")]
    protected new Primitive<string> _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ObjectRevisionOrParent")]
    protected Primitive<string> _ObjectRevisionOrParent;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_AuditTrail")]
    protected ModelingAuditTrail[] _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_MassUpdates")]
    protected Primitive<string>[] _MassUpdates;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ParentInstanceId")]
    protected Primitive<string> _ParentInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ObjectTypeId")]
    protected new Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_TxnDate")]
    protected new Primitive<DateTime> _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_SystemDate")]
    protected new Primitive<DateTime> _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ExecuteActionId")]
    protected new Primitive<int> _ExecuteActionId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ParentTypeId")]
    protected Primitive<int> _ParentTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ExecuteAction")]
    protected new Primitive<string> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_TxnDateGMT")]
    protected new Primitive<DateTime> _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_PackageName")]
    protected Primitive<string> _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_SystemDateGMT")]
    protected new Primitive<DateTime> _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ObjectTypeName")]
    protected new Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_User")]
    protected new NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_EmployeeName")]
    protected new Primitive<string> _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Employee")]
    protected new NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_ParentRevision")]
    protected Primitive<string> _ParentRevision;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_UserName")]
    protected new Primitive<string> _UserName;

    public override bool Equals(object obj)
    {
      return obj is ModelingAuditTrailHeader && object.Equals((object) this._ExportImportKey, (object) ((ModelingAuditTrailHeader) obj)._ExportImportKey) && (object.Equals((object) this._Comments, (object) ((ModelingAuditTrailHeader) obj)._Comments) && object.Equals((object) this._TxnName, (object) ((ModelingAuditTrailHeader) obj)._TxnName)) && (object.Equals((object) this._ObjectRevisionOrParent, (object) ((ModelingAuditTrailHeader) obj)._ObjectRevisionOrParent) && object.Equals((object) this._ObjectName, (object) ((ModelingAuditTrailHeader) obj)._ObjectName) && (this.CompareArrays((Array) this._AuditTrail, (Array) ((ModelingAuditTrailHeader) obj)._AuditTrail) && this.CompareArrays((Array) this._MassUpdates, (Array) ((ModelingAuditTrailHeader) obj)._MassUpdates))) && (object.Equals((object) this._ParentInstanceId, (object) ((ModelingAuditTrailHeader) obj)._ParentInstanceId) && object.Equals((object) this._ObjectTypeId, (object) ((ModelingAuditTrailHeader) obj)._ObjectTypeId) && (object.Equals((object) this._TxnDate, (object) ((ModelingAuditTrailHeader) obj)._TxnDate) && object.Equals((object) this._SystemDate, (object) ((ModelingAuditTrailHeader) obj)._SystemDate)) && (object.Equals((object) this._ExecuteActionId, (object) ((ModelingAuditTrailHeader) obj)._ExecuteActionId) && object.Equals((object) this._ParentTypeId, (object) ((ModelingAuditTrailHeader) obj)._ParentTypeId) && (object.Equals((object) this._HistoryId, (object) ((ModelingAuditTrailHeader) obj)._HistoryId) && object.Equals((object) this._ExecuteAction, (object) ((ModelingAuditTrailHeader) obj)._ExecuteAction)))) && (object.Equals((object) this._TxnDateGMT, (object) ((ModelingAuditTrailHeader) obj)._TxnDateGMT) && object.Equals((object) this._PackageName, (object) ((ModelingAuditTrailHeader) obj)._PackageName) && (object.Equals((object) this._SystemDateGMT, (object) ((ModelingAuditTrailHeader) obj)._SystemDateGMT) && object.Equals((object) this._ObjectInstanceId, (object) ((ModelingAuditTrailHeader) obj)._ObjectInstanceId)) && (object.Equals((object) this._ObjectTypeName, (object) ((ModelingAuditTrailHeader) obj)._ObjectTypeName) && object.Equals((object) this._User, (object) ((ModelingAuditTrailHeader) obj)._User) && (object.Equals((object) this._EmployeeName, (object) ((ModelingAuditTrailHeader) obj)._EmployeeName) && object.Equals((object) this._Employee, (object) ((ModelingAuditTrailHeader) obj)._Employee))) && (object.Equals((object) this._ParentRevision, (object) ((ModelingAuditTrailHeader) obj)._ParentRevision) && object.Equals((object) this._UserName, (object) ((ModelingAuditTrailHeader) obj)._UserName))) && base.Equals(obj);
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

    public Primitive<string> ObjectRevisionOrParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevisionOrParent), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectRevisionOrParent));
      }
    }

    public Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ModelingAuditTrail[] AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrail[]) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Primitive<string>[] MassUpdates
    {
      [param: In] set
      {
        this.PropertySet(nameof (MassUpdates), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (MassUpdates));
      }
    }

    public Primitive<string> ParentInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentInstanceId));
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

    public Primitive<int> ParentTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ParentTypeId));
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

    public Primitive<string> PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageName));
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

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
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

    public Primitive<string> ParentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentRevision));
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
  }
}
