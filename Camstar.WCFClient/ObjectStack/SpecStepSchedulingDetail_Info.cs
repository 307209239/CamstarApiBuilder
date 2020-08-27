// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStepSchedulingDetail_Info
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
  public class SpecStepSchedulingDetail_Info : StepSchedulingDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_RunRateOption")]
    protected new Info _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_SetupTime")]
    protected new Info _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_StdBatchSize")]
    protected new Info _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_ForwardYield")]
    protected new Info _ForwardYield;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_Yield")]
    protected new Info _Yield;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_NormalCycleTime")]
    protected new Info _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_ForwardCycleTime")]
    protected new Info _ForwardCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_UnitsPerHour")]
    protected new Info _UnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_DurationPerUnit")]
    protected new Info _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetail_Info_FastCycleTime")]
    protected new Info _FastCycleTime;

    public new Info RunRateOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (RunRateOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RunRateOption));
      }
    }

    public new Info SetupTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SetupTime));
      }
    }

    public new Info StdBatchSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdBatchSize), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdBatchSize));
      }
    }

    public new Info ForwardYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardYield), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForwardYield));
      }
    }

    public new Info Yield
    {
      [param: In] set
      {
        this.PropertySet(nameof (Yield), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Yield));
      }
    }

    public new Info NormalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalCycleTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NormalCycleTime));
      }
    }

    public new Info ForwardCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForwardCycleTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForwardCycleTime));
      }
    }

    public new Info UnitsPerHour
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsPerHour), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitsPerHour));
      }
    }

    public new Info DurationPerUnit
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationPerUnit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DurationPerUnit));
      }
    }

    public new Info FastCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastCycleTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FastCycleTime));
      }
    }
  }
}
