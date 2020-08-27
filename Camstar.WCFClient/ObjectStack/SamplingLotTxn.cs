// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingLotTxn
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
  public class SamplingLotTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_LotSampleData")]
    protected Camstar.WCF.ObjectStack.LotSampleData[] _LotSampleData;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_SamplingPlan")]
    protected new RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_AllowAdjustToLotSize")]
    protected Primitive<bool> _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_SampleRate")]
    protected Primitive<int> _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Containers")]
    protected Primitive<string>[] _Containers;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_LotName")]
    protected Primitive<string> _LotName;

    public override bool Equals(object obj)
    {
      return obj is SamplingLotTxn && object.Equals((object) this._UOM, (object) ((SamplingLotTxn) obj)._UOM) && (object.Equals((object) this._SamplingLot, (object) ((SamplingLotTxn) obj)._SamplingLot) && this.CompareArrays((Array) this._LotSampleData, (Array) ((SamplingLotTxn) obj)._LotSampleData)) && (object.Equals((object) this._SamplingPlan, (object) ((SamplingLotTxn) obj)._SamplingPlan) && object.Equals((object) this._AllowAdjustToLotSize, (object) ((SamplingLotTxn) obj)._AllowAdjustToLotSize) && (object.Equals((object) this._SampleRate, (object) ((SamplingLotTxn) obj)._SampleRate) && object.Equals((object) this._Qty, (object) ((SamplingLotTxn) obj)._Qty))) && (this.CompareArrays((Array) this._Containers, (Array) ((SamplingLotTxn) obj)._Containers) && object.Equals((object) this._Product, (object) ((SamplingLotTxn) obj)._Product) && object.Equals((object) this._LotName, (object) ((SamplingLotTxn) obj)._LotName)) && base.Equals(obj);
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

    public Camstar.WCF.ObjectStack.LotSampleData[] LotSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleData), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.LotSampleData[]) this.PropertyGet(nameof (LotSampleData));
      }
    }

    public new RevisionedObjectRef SamplingPlan
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

    public Primitive<string>[] Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (Containers));
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
  }
}
