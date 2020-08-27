// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepSchedulingDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SpecStepSchedulingDetail_Info))]
  [KnownType(typeof (SubWorkflowStepSchedulingDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StepSchedulingDetail_Info : SchedulingDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_RunRateOption")]
    protected new Info _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_ForwardYield")]
    protected Info _ForwardYield;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_UnitsPerHour")]
    protected new Info _UnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_StdBatchSize")]
    protected new Info _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_SetupTime")]
    protected new Info _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_DurationPerUnit")]
    protected new Info _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_NormalCycleTime")]
    protected new Info _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_FastCycleTime")]
    protected new Info _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_ForwardCycleTime")]
    protected Info _ForwardCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetail_Info_Yield")]
    protected new Info _Yield;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info ForwardYield
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

    public Info ForwardCycleTime
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
  }
}
