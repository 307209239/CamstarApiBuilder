// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SchedulingDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (StepSchedulingDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SchedulingDetail_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_RunRateOption")]
    [Metadata("This option determines if run rate is specified as hours per unit or units per hour. The values and their meanings are:\r\n1 = Hours per unit (RunRateTime)\r\n2 = Unites per hour (RunRateQuantity)", "RunRateEnum", false, false, true, "Integer", 1048730, false, false, false, null)]
    protected Environment _RunRateOption;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_SetupTime")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048729, false, false, false, null)]
    protected Environment _SetupTime;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048973, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_StdBatchSize")]
    protected Environment _StdBatchSize;
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048734, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_NormalCycleTime")]
    protected Environment _NormalCycleTime;
    [Metadata("Time as a duration", "", false, false, true, "Float", 1048735, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_FastCycleTime")]
    protected Environment _FastCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_UnitsPerHour")]
    protected Environment _UnitsPerHour;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_DurationPerUnit")]
    protected Environment _DurationPerUnit;
    [Metadata("Processing yield (as a percentage).", "", false, false, true, "Fixed", 1048733, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SchedulingDetail_Environment_Yield")]
    protected Environment _Yield;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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
  }
}
