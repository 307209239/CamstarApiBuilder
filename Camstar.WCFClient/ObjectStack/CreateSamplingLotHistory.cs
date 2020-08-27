// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateSamplingLotHistory
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
  public class CreateSamplingLotHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_SampleRate")]
    protected Primitive<int> _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_AllowAdjustToLotSize")]
    protected Primitive<bool> _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_LotName")]
    protected Primitive<string> _LotName;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is CreateSamplingLotHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CreateSamplingLotHistory) obj)._HistoryDetails) && (object.Equals((object) this._UOM, (object) ((CreateSamplingLotHistory) obj)._UOM) && object.Equals((object) this._ExportImportKey, (object) ((CreateSamplingLotHistory) obj)._ExportImportKey)) && (object.Equals((object) this._Comments, (object) ((CreateSamplingLotHistory) obj)._Comments) && object.Equals((object) this._SamplingPlan, (object) ((CreateSamplingLotHistory) obj)._SamplingPlan) && (object.Equals((object) this._HistoryId, (object) ((CreateSamplingLotHistory) obj)._HistoryId) && object.Equals((object) this._SampleRate, (object) ((CreateSamplingLotHistory) obj)._SampleRate))) && (object.Equals((object) this._CreationDate, (object) ((CreateSamplingLotHistory) obj)._CreationDate) && object.Equals((object) this._AllowAdjustToLotSize, (object) ((CreateSamplingLotHistory) obj)._AllowAdjustToLotSize) && (object.Equals((object) this._Qty, (object) ((CreateSamplingLotHistory) obj)._Qty) && object.Equals((object) this._LotName, (object) ((CreateSamplingLotHistory) obj)._LotName)) && object.Equals((object) this._Product, (object) ((CreateSamplingLotHistory) obj)._Product)) && base.Equals(obj);
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

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
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

    public RevisionedObjectRef SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SamplingPlan));
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

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Primitive<bool> AllowAdjustToLotSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAdjustToLotSize), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowAdjustToLotSize));
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

    public Primitive<string> LotName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LotName));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }
  }
}
