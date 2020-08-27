// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubWorkflowStepChanges
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
  public class SubWorkflowStepChanges : StepChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_SchedulingDetail")]
    protected SubWFStepSchedDetailChanges _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_SubWorkflow")]
    protected RevisionedObjectRef _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_StepType")]
    protected new Primitive<int> _StepType;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SubWorkflowStepChanges && object.Equals((object) this._ObjectToChange, (object) ((SubWorkflowStepChanges) obj)._ObjectToChange) && (object.Equals((object) this._SchedulingDetail, (object) ((SubWorkflowStepChanges) obj)._SchedulingDetail) && object.Equals((object) this._SubWorkflow, (object) ((SubWorkflowStepChanges) obj)._SubWorkflow)) && (object.Equals((object) this._StepType, (object) ((SubWorkflowStepChanges) obj)._StepType) && object.Equals((object) this._Name, (object) ((SubWorkflowStepChanges) obj)._Name)) && base.Equals(obj);
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

    public SubWFStepSchedDetailChanges SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SubWFStepSchedDetailChanges) this.PropertyGet(nameof (SchedulingDetail));
      }
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

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
