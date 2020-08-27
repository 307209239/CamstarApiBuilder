// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectLotSamplingData
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
  public class CollectLotSamplingData : CollectSamplingData
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_LotSampleDataItem")]
    protected SubentityRef _LotSampleDataItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_SamplingStatus")]
    protected new Enumeration<SampleStatusEnum, string> _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_LotSampleData")]
    protected Camstar.WCF.ObjectStack.LotSampleData[] _LotSampleData;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_SamplingPlan")]
    protected new RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_SamplingLotQty")]
    protected Primitive<double> _SamplingLotQty;

    public override bool Equals(object obj)
    {
      return obj is CollectLotSamplingData && object.Equals((object) this._SamplingLot, (object) ((CollectLotSamplingData) obj)._SamplingLot) && (object.Equals((object) this._LotSampleDataItem, (object) ((CollectLotSamplingData) obj)._LotSampleDataItem) && object.Equals((object) this._SamplingStatus, (object) ((CollectLotSamplingData) obj)._SamplingStatus)) && (this.CompareArrays((Array) this._LotSampleData, (Array) ((CollectLotSamplingData) obj)._LotSampleData) && object.Equals((object) this._SamplingPlan, (object) ((CollectLotSamplingData) obj)._SamplingPlan) && object.Equals((object) this._SamplingLotQty, (object) ((CollectLotSamplingData) obj)._SamplingLotQty)) && base.Equals(obj);
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

    public SubentityRef LotSampleDataItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleDataItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LotSampleDataItem));
      }
    }

    public new Enumeration<SampleStatusEnum, string> SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Enumeration<SampleStatusEnum, string>) this.PropertyGet(nameof (SamplingStatus));
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

    public Primitive<double> SamplingLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLotQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (SamplingLotQty));
      }
    }
  }
}
