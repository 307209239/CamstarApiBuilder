// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SchedulingDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (StepSchedulingDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SchedulingDetail : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_RunRateOption")]
    protected Enumeration<RunRateEnum, int> _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_SetupTime")]
    protected Primitive<double> _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_StdBatchSize")]
    protected Primitive<double> _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_NormalCycleTime")]
    protected Primitive<double> _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_FastCycleTime")]
    protected Primitive<double> _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_UnitsPerHour")]
    protected Primitive<double> _UnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_DurationPerUnit")]
    protected Primitive<double> _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Yield")]
    protected Primitive<double> _Yield;

    public override bool Equals(object obj)
    {
      return obj is SchedulingDetail && object.Equals((object) this._RunRateOption, (object) ((SchedulingDetail) obj)._RunRateOption) && (object.Equals((object) this._ExportImportKey, (object) ((SchedulingDetail) obj)._ExportImportKey) && object.Equals((object) this._SetupTime, (object) ((SchedulingDetail) obj)._SetupTime)) && (object.Equals((object) this._StdBatchSize, (object) ((SchedulingDetail) obj)._StdBatchSize) && object.Equals((object) this._NormalCycleTime, (object) ((SchedulingDetail) obj)._NormalCycleTime) && (object.Equals((object) this._FastCycleTime, (object) ((SchedulingDetail) obj)._FastCycleTime) && object.Equals((object) this._IsFrozen, (object) ((SchedulingDetail) obj)._IsFrozen))) && (object.Equals((object) this._UnitsPerHour, (object) ((SchedulingDetail) obj)._UnitsPerHour) && object.Equals((object) this._DurationPerUnit, (object) ((SchedulingDetail) obj)._DurationPerUnit) && object.Equals((object) this._Yield, (object) ((SchedulingDetail) obj)._Yield)) && base.Equals(obj);
    }

    public Enumeration<RunRateEnum, int> RunRateOption
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

    public Primitive<double> SetupTime
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

    public Primitive<double> StdBatchSize
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

    public Primitive<double> NormalCycleTime
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

    public Primitive<double> FastCycleTime
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

    public Primitive<bool> IsFrozen
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

    public Primitive<double> UnitsPerHour
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

    public Primitive<double> DurationPerUnit
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

    public Primitive<double> Yield
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
