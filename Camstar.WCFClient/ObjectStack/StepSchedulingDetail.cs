// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepSchedulingDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SpecStepSchedulingDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SubWorkflowStepSchedulingDetail))]
  [Serializable]
  public class StepSchedulingDetail : SchedulingDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_RunRateOption")]
    protected new Enumeration<RunRateEnum, int> _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_ForwardYield")]
    protected Primitive<double> _ForwardYield;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_UnitsPerHour")]
    protected new Primitive<double> _UnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_StdBatchSize")]
    protected new Primitive<double> _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_SetupTime")]
    protected new Primitive<double> _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_DurationPerUnit")]
    protected new Primitive<double> _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_NormalCycleTime")]
    protected new Primitive<double> _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_FastCycleTime")]
    protected new Primitive<double> _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_ForwardCycleTime")]
    protected Primitive<double> _ForwardCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Yield")]
    protected new Primitive<double> _Yield;

    public override bool Equals(object obj)
    {
      return obj is StepSchedulingDetail && object.Equals((object) this._RunRateOption, (object) ((StepSchedulingDetail) obj)._RunRateOption) && (object.Equals((object) this._ExportImportKey, (object) ((StepSchedulingDetail) obj)._ExportImportKey) && object.Equals((object) this._IsFrozen, (object) ((StepSchedulingDetail) obj)._IsFrozen)) && (object.Equals((object) this._ForwardYield, (object) ((StepSchedulingDetail) obj)._ForwardYield) && object.Equals((object) this._UnitsPerHour, (object) ((StepSchedulingDetail) obj)._UnitsPerHour) && (object.Equals((object) this._StdBatchSize, (object) ((StepSchedulingDetail) obj)._StdBatchSize) && object.Equals((object) this._SetupTime, (object) ((StepSchedulingDetail) obj)._SetupTime))) && (object.Equals((object) this._DurationPerUnit, (object) ((StepSchedulingDetail) obj)._DurationPerUnit) && object.Equals((object) this._NormalCycleTime, (object) ((StepSchedulingDetail) obj)._NormalCycleTime) && (object.Equals((object) this._FastCycleTime, (object) ((StepSchedulingDetail) obj)._FastCycleTime) && object.Equals((object) this._ForwardCycleTime, (object) ((StepSchedulingDetail) obj)._ForwardCycleTime)) && object.Equals((object) this._Yield, (object) ((StepSchedulingDetail) obj)._Yield)) && base.Equals(obj);
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

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Primitive<double> ForwardYield
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

    public Primitive<double> ForwardCycleTime
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
  }
}
