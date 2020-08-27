// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SchedulingDetailChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (OperationSchedulingDetailChanges))]
  [KnownType(typeof (SpecSchedulingDetailChanges))]
  [KnownType(typeof (StepSchedulingDetailChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SchedulingDetailChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_RunRateOption")]
    protected Enumeration<RunRateEnum, int> _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_DurationPerUnit")]
    protected Primitive<double> _DurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Yield")]
    protected Primitive<double> _Yield;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_NormalCycleTime")]
    protected Primitive<double> _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_SetupTime")]
    protected Primitive<double> _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_FastCycleTime")]
    protected Primitive<double> _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_StdBatchSize")]
    protected Primitive<double> _StdBatchSize;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_UnitsPerHour")]
    protected Primitive<double> _UnitsPerHour;

    public override bool Equals(object obj)
    {
      return obj is SchedulingDetailChanges && object.Equals((object) this._ListItemToChange, (object) ((SchedulingDetailChanges) obj)._ListItemToChange) && (object.Equals((object) this._RunRateOption, (object) ((SchedulingDetailChanges) obj)._RunRateOption) && object.Equals((object) this._DurationPerUnit, (object) ((SchedulingDetailChanges) obj)._DurationPerUnit)) && (object.Equals((object) this._ObjectToChange, (object) ((SchedulingDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._Yield, (object) ((SchedulingDetailChanges) obj)._Yield) && (object.Equals((object) this._NormalCycleTime, (object) ((SchedulingDetailChanges) obj)._NormalCycleTime) && object.Equals((object) this._SetupTime, (object) ((SchedulingDetailChanges) obj)._SetupTime))) && (object.Equals((object) this._FastCycleTime, (object) ((SchedulingDetailChanges) obj)._FastCycleTime) && object.Equals((object) this._IsFrozen, (object) ((SchedulingDetailChanges) obj)._IsFrozen) && (object.Equals((object) this._StdBatchSize, (object) ((SchedulingDetailChanges) obj)._StdBatchSize) && object.Equals((object) this._UnitsPerHour, (object) ((SchedulingDetailChanges) obj)._UnitsPerHour))) && base.Equals(obj);
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
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

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
