// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklistToEventHistory
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
  public class AssignChecklistToEventHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Event")]
    protected NamedObjectRef _Event;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is AssignChecklistToEventHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((AssignChecklistToEventHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((AssignChecklistToEventHistory) obj)._ExportImportKey) && object.Equals((object) this._Event, (object) ((AssignChecklistToEventHistory) obj)._Event)) && (object.Equals((object) this._Comments, (object) ((AssignChecklistToEventHistory) obj)._Comments) && object.Equals((object) this._ChecklistTemplate, (object) ((AssignChecklistToEventHistory) obj)._ChecklistTemplate) && object.Equals((object) this._HistoryId, (object) ((AssignChecklistToEventHistory) obj)._HistoryId)) && base.Equals(obj);
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

    public NamedObjectRef Event
    {
      [param: In] set
      {
        this.PropertySet(nameof (Event), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Event));
      }
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

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
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
