// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateSamplingLot_Info
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
  public class CreateSamplingLot_Info : SamplingLotTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Info_SamplingPlan")]
    protected new Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Info_AllowAdjustToLotSize")]
    protected new Info _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Info_LotName")]
    protected new Info _LotName;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Info_Product")]
    protected new Info _Product;

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

    public new Info AllowAdjustToLotSize
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

    public new Info LotName
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

    public new Info Qty
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

    public new Info Product
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
  }
}
