// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPSubWorkflowStepChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChangeMgtSubWFStepChanges))]
  [Serializable]
  public class BPSubWorkflowStepChanges : StepChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_SubWorkflow")]
    protected RevisionedObjectRef _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_StepType")]
    protected new Primitive<int> _StepType;

    public override bool Equals(object obj)
    {
      return obj is BPSubWorkflowStepChanges && object.Equals((object) this._SubWorkflow, (object) ((BPSubWorkflowStepChanges) obj)._SubWorkflow) && (object.Equals((object) this._ObjectToChange, (object) ((BPSubWorkflowStepChanges) obj)._ObjectToChange) && object.Equals((object) this._StepType, (object) ((BPSubWorkflowStepChanges) obj)._StepType)) && base.Equals(obj);
    }

    public RevisionedObjectRef SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SubWorkflow));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<int> StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (StepType));
      }
    }
  }
}
