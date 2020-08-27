// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventHistory
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
  public class UpdateEventHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_HistoryDetails")]
    protected EventHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_QualityCrossRefHistories")]
    protected QualityCrossRefHistory[] _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Submit")]
    protected Primitive<bool> _Submit;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((UpdateEventHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((UpdateEventHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._QualityCrossRefHistories, (Array) ((UpdateEventHistory) obj)._QualityCrossRefHistories)) && (object.Equals((object) this._Submit, (object) ((UpdateEventHistory) obj)._Submit) && object.Equals((object) this._HistoryId, (object) ((UpdateEventHistory) obj)._HistoryId)) && base.Equals(obj);
    }

    public EventHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (EventHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public QualityCrossRefHistory[] QualityCrossRefHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefHistories), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory[]) this.PropertyGet(nameof (QualityCrossRefHistories));
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
