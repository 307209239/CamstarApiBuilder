// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectDataPointsHistory
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
  public class CollectDataPointsHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_DataPointCollection")]
    protected NamedSubentityRef _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_HistoryDetails")]
    protected DPCollectionGroupHistory[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is CollectDataPointsHistory && object.Equals((object) this._ExportImportKey, (object) ((CollectDataPointsHistory) obj)._ExportImportKey) && (object.Equals((object) this._DataPointCollection, (object) ((CollectDataPointsHistory) obj)._DataPointCollection) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CollectDataPointsHistory) obj)._HistoryDetails)) && object.Equals((object) this._HistoryId, (object) ((CollectDataPointsHistory) obj)._HistoryId) && base.Equals(obj);
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

    public NamedSubentityRef DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public DPCollectionGroupHistory[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DPCollectionGroupHistory[]) this.PropertyGet(nameof (HistoryDetails));
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
