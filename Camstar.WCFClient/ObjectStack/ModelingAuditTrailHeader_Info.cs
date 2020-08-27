// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrailHeader_Info
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
  public class ModelingAuditTrailHeader_Info : AuditTrailHeader_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_TxnName")]
    protected new Info _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ObjectRevisionOrParent")]
    protected Info _ObjectRevisionOrParent;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ObjectName")]
    protected Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_AuditTrail")]
    protected ModelingAuditTrail_Info _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_MassUpdates")]
    protected Info _MassUpdates;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ParentInstanceId")]
    protected Info _ParentInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ObjectTypeId")]
    protected new Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_TxnDate")]
    protected new Info _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_SystemDate")]
    protected new Info _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ExecuteActionId")]
    protected new Info _ExecuteActionId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ParentTypeId")]
    protected Info _ParentTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ExecuteAction")]
    protected new Info _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_TxnDateGMT")]
    protected new Info _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_PackageName")]
    protected Info _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_SystemDateGMT")]
    protected new Info _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ObjectTypeName")]
    protected new Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_User")]
    protected new Info _User;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_EmployeeName")]
    protected new Info _EmployeeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_Employee")]
    protected new Info _Employee;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_ParentRevision")]
    protected Info _ParentRevision;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailHeader_Info_UserName")]
    protected new Info _UserName;

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

    public new Info Comments
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

    public new Info TxnName
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

    public Info ObjectRevisionOrParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevisionOrParent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectRevisionOrParent));
      }
    }

    public Info ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ModelingAuditTrail_Info AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrail_Info) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Info MassUpdates
    {
      [param: In] set
      {
        this.PropertySet(nameof (MassUpdates), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MassUpdates));
      }
    }

    public Info ParentInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentInstanceId));
      }
    }

    public new Info ObjectTypeId
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

    public new Info TxnDate
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

    public new Info SystemDate
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

    public new Info ExecuteActionId
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

    public Info ParentTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentTypeId));
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

    public new Info ExecuteAction
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

    public new Info TxnDateGMT
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

    public Info PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageName));
      }
    }

    public new Info SystemDateGMT
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

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public new Info ObjectTypeName
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

    public new Info User
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

    public new Info EmployeeName
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

    public new Info Employee
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

    public Info ParentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentRevision));
      }
    }

    public new Info UserName
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
  }
}
