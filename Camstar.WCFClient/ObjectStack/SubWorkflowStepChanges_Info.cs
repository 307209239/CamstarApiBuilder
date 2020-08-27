// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubWorkflowStepChanges_Info
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
  public class SubWorkflowStepChanges_Info : StepChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Info_SchedulingDetail")]
    protected SubWFStepSchedDetailChanges_Info _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Info_SubWorkflow")]
    protected Info _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Info_StepType")]
    protected new Info _StepType;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public SubWFStepSchedDetailChanges_Info SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SubWFStepSchedDetailChanges_Info) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Info SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubWorkflow));
      }
    }

    public new Info StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepType));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
