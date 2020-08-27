// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateSamplingLotHistory
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
  public class UpdateSamplingLotHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_SampleRate")]
    protected Primitive<int> _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is UpdateSamplingLotHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((UpdateSamplingLotHistory) obj)._HistoryDetails) && (object.Equals((object) this._Comments, (object) ((UpdateSamplingLotHistory) obj)._Comments) && object.Equals((object) this._ExportImportKey, (object) ((UpdateSamplingLotHistory) obj)._ExportImportKey)) && (object.Equals((object) this._SamplingLot, (object) ((UpdateSamplingLotHistory) obj)._SamplingLot) && object.Equals((object) this._HistoryId, (object) ((UpdateSamplingLotHistory) obj)._HistoryId) && (object.Equals((object) this._SampleRate, (object) ((UpdateSamplingLotHistory) obj)._SampleRate) && object.Equals((object) this._Qty, (object) ((UpdateSamplingLotHistory) obj)._Qty))) && base.Equals(obj);
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

    public NamedObjectRef SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplingLot));
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

    public Primitive<int> SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
