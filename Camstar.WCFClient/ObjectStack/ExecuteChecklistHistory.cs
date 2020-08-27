// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistHistory
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
  public class ExecuteChecklistHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_HistoryDetails")]
    protected ExecuteChecklistHistoryDtl[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Checklist")]
    protected NamedSubentityRef _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Submit")]
    protected Primitive<bool> _Submit;

    public override bool Equals(object obj)
    {
      return obj is ExecuteChecklistHistory && object.Equals((object) this._ExportImportKey, (object) ((ExecuteChecklistHistory) obj)._ExportImportKey) && (object.Equals((object) this._ChecklistInstructions, (object) ((ExecuteChecklistHistory) obj)._ChecklistInstructions) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ExecuteChecklistHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Checklist, (object) ((ExecuteChecklistHistory) obj)._Checklist) && object.Equals((object) this._HistoryId, (object) ((ExecuteChecklistHistory) obj)._HistoryId) && object.Equals((object) this._Submit, (object) ((ExecuteChecklistHistory) obj)._Submit)) && base.Equals(obj);
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

    public Primitive<string> ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChecklistInstructions));
      }
    }

    public ExecuteChecklistHistoryDtl[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ExecuteChecklistHistoryDtl[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public NamedSubentityRef Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Checklist));
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

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }
  }
}
