// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectLotSamplingData_Info
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
  public class CollectLotSamplingData_Info : CollectSamplingData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Info_LotSampleDataItem")]
    protected Info _LotSampleDataItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Info_SamplingStatus")]
    protected new Info _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Info_LotSampleData")]
    protected LotSampleData_Info _LotSampleData;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Info_SamplingPlan")]
    protected new Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Info_SamplingLotQty")]
    protected Info _SamplingLotQty;

    public Info SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Info LotSampleDataItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleDataItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotSampleDataItem));
      }
    }

    public new Info SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public LotSampleData_Info LotSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleData), (object) value);
      }
      get
      {
        return (LotSampleData_Info) this.PropertyGet(nameof (LotSampleData));
      }
    }

    public new Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Info SamplingLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLotQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLotQty));
      }
    }
  }
}
