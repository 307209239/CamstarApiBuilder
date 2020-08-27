// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SchedulingDetailChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (StepSchedulingDetailChanges_Environment))]
  [KnownType(typeof (SpecSchedulingDetailChanges_Environment))]
  [KnownType(typeof (OperationSchedulingDetailChanges_Environment))]
  [Serializable]
  public class SchedulingDetailChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_ListItemToChange")]
    [Metadata("Scheduling Detail.", "SchedulingDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_RunRateOption")]
    [Metadata("This option determines if run rate is specified as hours per unit or units per hour. The values and their meanings are:\r\n1 = Hours per unit (RunRateTime)\r\n2 = Unites per hour (RunRateQuantity)", "RunRateEnum", false, false, false, "Integer", 1048730, false, false, true, null)]
    protected Environment _RunRateOption;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_DurationPerUnit")]
    protected Environment _DurationPerUnit;
    [Metadata("Operation Scheduling Details\r\n\r\nAn Operation uses an instance of Scheduling Details  to define scheduling information at the most generic level. Each value in the scheduling details can be overridden by a Spec (referencing the Operation). The calculation for cycle time is:\r\n\r\n( ( (RunTime + SetupTime) / Utilitzation ) + MoveTime + [Fast/Normal]QueueTime ) [/ HoursPerDay]\r\n\r\nThe hierarchy built-in to the application model is that Scheduling details specified at the Operation level can be overridden by a Spec. In turn the values in the Spec can be overridden by each Step that references that Spec. It is also assumed that Scheduling Details will be overridden at the Product or Product Family level. Further, the assumption is that this will be for a few Steps (if any) and that adding user-defined fields to the Product or Product Family definition (and then updating the field overrides) will address it.", "SchedulingDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_Yield")]
    [Metadata("Processing yield (as a percentage).", "", false, false, false, "Fixed", 1048733, false, false, false, null)]
    protected Environment _Yield;
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048734, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_NormalCycleTime")]
    protected Environment _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_SetupTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048729, false, false, false, null)]
    protected Environment _SetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_FastCycleTime")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048735, false, false, false, null)]
    protected Environment _FastCycleTime;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048728, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_StdBatchSize")]
    protected Environment _StdBatchSize;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetailChanges_Environment_UnitsPerHour")]
    protected Environment _UnitsPerHour;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment RunRateOption
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

    public Environment DurationPerUnit
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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment Yield
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

    public Environment NormalCycleTime
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

    public Environment SetupTime
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

    public Environment FastCycleTime
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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment StdBatchSize
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

    public Environment UnitsPerHour
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
  }
}
