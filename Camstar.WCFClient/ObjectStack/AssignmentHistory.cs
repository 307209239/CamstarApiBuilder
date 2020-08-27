// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignmentHistory
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
  public class AssignmentHistory : ProcessObjectTxnHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_Employee")]
    protected new NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "AssignmentHistory_Assignee")]
    protected NamedObjectRef _Assignee;

    public override bool Equals(object obj)
    {
      return obj is AssignmentHistory && object.Equals((object) this._ExportImportKey, (object) ((AssignmentHistory) obj)._ExportImportKey) && (object.Equals((object) this._AssigneeRole, (object) ((AssignmentHistory) obj)._AssigneeRole) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((AssignmentHistory) obj)._HistoryDetails)) && (object.Equals((object) this._QualityObject, (object) ((AssignmentHistory) obj)._QualityObject) && object.Equals((object) this._ProcessObject, (object) ((AssignmentHistory) obj)._ProcessObject) && (object.Equals((object) this._HistoryId, (object) ((AssignmentHistory) obj)._HistoryId) && object.Equals((object) this._Employee, (object) ((AssignmentHistory) obj)._Employee))) && object.Equals((object) this._Assignee, (object) ((AssignmentHistory) obj)._Assignee) && base.Equals(obj);
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

    public NamedObjectRef AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
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

    public NamedObjectRef Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
