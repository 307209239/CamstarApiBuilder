// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStepSchedulingDetailChanges_Environment
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
  public class SpecStepSchedulingDetailChanges_Environment : StepSchedulingDetailChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetailChanges_Environment_ObjectToChange")]
    [Metadata("An Operation uses an instance of Scheduling Details to define scheduling information at the most generic level. Each value in the scheduling details can be overridden by a Spec. The Maintenance function must provide security for access to Scheduling Details. \r\n\r\nThe calculation for cycle time is:\r\n\r\n( ( (RunTime + SetupTime) / Utilitzation ) + MoveTime + [Fast/Normal]QueueTime ) [/ HoursPerDay]\r\n\r\nThe hierarchy built-in to the application model is that Scheduling details specified at the Operation level can be overridden by a Spec. In turn the values in the Spec can be overridden by each Step that references that Spec. It is also assumed that Scheduling Details will be overridden at the Product or Product Family level. Further, the assumption is that this will be for a few Steps (if any) and that adding user-defined fields to the Product or Product Family definition (and then updating the field overrides) will address it.", "SpecStepSchedulingDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Allows maintenance of the scheduling details for a spec step.", "SpecStepSchedulingDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetailChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;

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
  }
}
