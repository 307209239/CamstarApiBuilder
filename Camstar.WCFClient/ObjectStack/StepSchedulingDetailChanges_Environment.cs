// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepSchedulingDetailChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SpecStepSchedulingDetailChanges_Environment))]
  [KnownType(typeof (SubWFStepSchedDetailChanges_Environment))]
  [Serializable]
  public class StepSchedulingDetailChanges_Environment : SchedulingDetailChanges_Environment
  {
    [Metadata("Changes CDO for StepSchedulingDetail.", "StepSchedulingDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_Environment_ObjectToChange")]
    [Metadata("An Operation uses an instance of Scheduling Details to define scheduling information at the most generic level. Each value in the scheduling details can be overridden by a Spec. The values in the Spec can in turn be overridden by a Step. The Maintenance function must provide security for access to Scheduling Details. \r\n\r\nThe calculation for cycle time is:\r\n\r\n( ( (RunTime + SetupTime) / Utilitzation ) + MoveTime + [Fast/Normal]QueueTime ) [/ HoursPerDay]\r\n\r\nThe hierarchy built-in to the application model is that Scheduling details specified at the Operation level can be overridden by a Spec. In turn the values in the Spec can be overridden by each Step that references that Spec. It is also assumed that Scheduling Details will be overridden at the Product or Product Family level. Further, the assumption is that this will be for a few Steps (if any) and that adding user-defined fields to the Product or Product Family definition (and then updating the field overrides) will address it.", "StepSchedulingDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Processing yield (as a percentage).", "", false, false, false, "Fixed", 1049024, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_Environment_ForwardYield")]
    protected Environment _ForwardYield;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048734, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_Environment_NormalCycleTime")]
    protected new Environment _NormalCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_Environment_FastCycleTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048735, false, false, false, null)]
    protected new Environment _FastCycleTime;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049023, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepSchedulingDetailChanges_Environment_ForwardCycleTime")]
    protected Environment _ForwardCycleTime;

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

    public Environment ForwardYield
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

    public Environment ForwardCycleTime
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
  }
}
