// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingLotTxn_Info
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
  public class SamplingLotTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_LotSampleData")]
    protected LotSampleData_Info _LotSampleData;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_SamplingPlan")]
    protected new Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_AllowAdjustToLotSize")]
    protected Info _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_SampleRate")]
    protected Info _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_Containers")]
    protected Info _Containers;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Info_LotName")]
    protected Info _LotName;

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

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

    public Info AllowAdjustToLotSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAdjustToLotSize), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowAdjustToLotSize));
      }
    }

    public Info SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Containers));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public Info LotName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotName));
      }
    }
  }
}
