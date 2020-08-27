// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStepSchedulingDetail
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
  public class SpecStepSchedulingDetail : StepSchedulingDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_RunRateOption")]
    protected new Enumeration<RunRateEnum, int> _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_SetupTime")]
    protected new Primitive<double> _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_StdBatchSize")]
    protected new Primitive<double> _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_ForwardYield")]
    protected new Primitive<double> _ForwardYield;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Yield")]
    protected new Primitive<double> _Yield;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_NormalCycleTime")]
    protected new Primitive<double> _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_ForwardCycleTime")]
    protected new Primitive<double> _ForwardCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_UnitsPerHour")]
    protected new Primitive<double> _UnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_DurationPerUnit")]
    protected new Primitive<double> _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_FastCycleTime")]
    protected new Primitive<double> _FastCycleTime;

    public override bool Equals(object obj)
    {
      return obj is SpecStepSchedulingDetail && object.Equals((object) this._RunRateOption, (object) ((SpecStepSchedulingDetail) obj)._RunRateOption) && (object.Equals((object) this._SetupTime, (object) ((SpecStepSchedulingDetail) obj)._SetupTime) && object.Equals((object) this._StdBatchSize, (object) ((SpecStepSchedulingDetail) obj)._StdBatchSize)) && (object.Equals((object) this._ForwardYield, (object) ((SpecStepSchedulingDetail) obj)._ForwardYield) && object.Equals((object) this._Yield, (object) ((SpecStepSchedulingDetail) obj)._Yield) && (object.Equals((object) this._NormalCycleTime, (object) ((SpecStepSchedulingDetail) obj)._NormalCycleTime) && object.Equals((object) this._ForwardCycleTime, (object) ((SpecStepSchedulingDetail) obj)._ForwardCycleTime))) && (object.Equals((object) this._UnitsPerHour, (object) ((SpecStepSchedulingDetail) obj)._UnitsPerHour) && object.Equals((object) this._DurationPerUnit, (object) ((SpecStepSchedulingDetail) obj)._DurationPerUnit) && object.Equals((object) this._FastCycleTime, (object) ((SpecStepSchedulingDetail) obj)._FastCycleTime)) && base.Equals(obj);
    }

    public new Enumeration<RunRateEnum, int> RunRateOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (RunRateOption), (object) value);
      }
      get
      {
        return (Enumeration<RunRateEnum, int>) this.PropertyGet(nameof (RunRateOption));
      }
    }

    public new Primitive<double> SetupTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (SetupTime));
      }
    }

    public new Primitive<double> StdBatchSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdBatchSize), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdBatchSize));
      }
    }

    public new Primitive<double> ForwardYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardYield), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ForwardYield));
      }
    }

    public new Primitive<double> Yield
    {
      [param: In] set
      {
        this.PropertySet(nameof (Yield), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Yield));
      }
    }

    public new Primitive<double> NormalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NormalCycleTime));
      }
    }

    public new Primitive<double> ForwardCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ForwardCycleTime));
      }
    }

    public new Primitive<double> UnitsPerHour
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsPerHour), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (UnitsPerHour));
      }
    }

    public new Primitive<double> DurationPerUnit
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationPerUnit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (DurationPerUnit));
      }
    }

    public new Primitive<double> FastCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FastCycleTime));
      }
    }
  }
}
