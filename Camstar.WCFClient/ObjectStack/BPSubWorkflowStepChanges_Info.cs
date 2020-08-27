// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPSubWorkflowStepChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangeMgtSubWFStepChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class BPSubWorkflowStepChanges_Info : StepChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_Info_SubWorkflow")]
    protected Info _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_Info_StepType")]
    protected new Info _StepType;

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
  }
}
