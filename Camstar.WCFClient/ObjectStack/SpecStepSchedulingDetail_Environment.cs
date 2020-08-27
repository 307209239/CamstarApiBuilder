// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStepSchedulingDetail_Environment
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
  public class SpecStepSchedulingDetail_Environment : StepSchedulingDetail_Environment
  {
    [Metadata("This option determines if run rate is specified as hours per unit or units per hour. The values and their meanings are:\r\n1 = Hours per unit (RunRateTime)\r\n2 = Unites per hour (RunRateQuantity)", "RunRateEnum", false, false, true, "Integer", 1048730, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_RunRateOption")]
    protected new Environment _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_SetupTime")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048729, false, false, false, null)]
    protected new Environment _SetupTime;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048973, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_StdBatchSize")]
    protected new Environment _StdBatchSize;
    [Metadata("Processing yield (as a percentage).", "", false, false, true, "Fixed", 1049024, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_ForwardYield")]
    protected new Environment _ForwardYield;
    [Metadata("Processing yield (as a percentage).", "", false, false, true, "Fixed", 1048733, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_Yield")]
    protected new Environment _Yield;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_NormalCycleTime")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048734, false, false, false, null)]
    protected new Environment _NormalCycleTime;
    [Metadata("Time as a duration", "", false, false, true, "Float", 1049023, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_ForwardCycleTime")]
    protected new Environment _ForwardCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_UnitsPerHour")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049625, false, false, false, null)]
    protected new Environment _UnitsPerHour;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_DurationPerUnit")]
    protected new Environment _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Environment_FastCycleTime")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048735, false, false, false, null)]
    protected new Environment _FastCycleTime;

    public new Environment RunRateOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (RunRateOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RunRateOption));
      }
    }

    public new Environment SetupTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SetupTime));
      }
    }

    public new Environment StdBatchSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdBatchSize), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdBatchSize));
      }
    }

    public new Environment ForwardYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardYield), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ForwardYield));
      }
    }

    public new Environment Yield
    {
      [param: In] set
      {
        this.PropertySet(nameof (Yield), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Yield));
      }
    }

    public new Environment NormalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalCycleTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NormalCycleTime));
      }
    }

    public new Environment ForwardCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardCycleTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ForwardCycleTime));
      }
    }

    public new Environment UnitsPerHour
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsPerHour), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitsPerHour));
      }
    }

    public new Environment DurationPerUnit
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationPerUnit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DurationPerUnit));
      }
    }

    public new Environment FastCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastCycleTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FastCycleTime));
      }
    }
  }
}
