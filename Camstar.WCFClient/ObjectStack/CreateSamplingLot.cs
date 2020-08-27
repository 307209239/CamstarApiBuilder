// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateSamplingLot
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
  public class CreateSamplingLot : SamplingLotTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_SamplingPlan")]
    protected new RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_AllowAdjustToLotSize")]
    protected new Primitive<bool> _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_LotName")]
    protected new Primitive<string> _LotName;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Product")]
    protected new RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is CreateSamplingLot && object.Equals((object) this._SamplingPlan, (object) ((CreateSamplingLot) obj)._SamplingPlan) && (object.Equals((object) this._AllowAdjustToLotSize, (object) ((CreateSamplingLot) obj)._AllowAdjustToLotSize) && object.Equals((object) this._LotName, (object) ((CreateSamplingLot) obj)._LotName)) && (object.Equals((object) this._Qty, (object) ((CreateSamplingLot) obj)._Qty) && object.Equals((object) this._Product, (object) ((CreateSamplingLot) obj)._Product)) && base.Equals(obj);
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

    public new Primitive<bool> AllowAdjustToLotSize
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

    public new Primitive<string> LotName
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

    public new Primitive<double> Qty
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

    public new RevisionedObjectRef Product
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
