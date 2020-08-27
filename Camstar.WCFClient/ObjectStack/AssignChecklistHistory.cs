// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklistHistory
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
  public class AssignChecklistHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistHistory_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistHistory_HistoryDetails")]
    protected ChecklistEntryHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistHistory_Checklist")]
    protected NamedSubentityRef _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is AssignChecklistHistory && object.Equals((object) this._ExportImportKey, (object) ((AssignChecklistHistory) obj)._ExportImportKey) && (object.Equals((object) this._ChecklistInstructions, (object) ((AssignChecklistHistory) obj)._ChecklistInstructions) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((AssignChecklistHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Checklist, (object) ((AssignChecklistHistory) obj)._Checklist) && object.Equals((object) this._HistoryId, (object) ((AssignChecklistHistory) obj)._HistoryId)) && base.Equals(obj);
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

    public ChecklistEntryHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ChecklistEntryHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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
  }
}
