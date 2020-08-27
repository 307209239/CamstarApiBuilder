// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SchedulingDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (StepSchedulingDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SchedulingDetail_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_RunRateOption")]
    protected Info _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_SetupTime")]
    protected Info _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_StdBatchSize")]
    protected Info _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_NormalCycleTime")]
    protected Info _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_FastCycleTime")]
    protected Info _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_UnitsPerHour")]
    protected Info _UnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_DurationPerUnit")]
    protected Info _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Info_Yield")]
    protected Info _Yield;

    public Info RunRateOption
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

    public Info SetupTime
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

    public Info StdBatchSize
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

    public Info NormalCycleTime
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

    public Info FastCycleTime
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

    public Info IsFrozen
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

    public Info UnitsPerHour
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

    public Info DurationPerUnit
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

    public Info Yield
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
