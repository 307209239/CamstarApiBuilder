// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveNonStd
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
  public class BPMoveNonStd : BPMoveTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Path")]
    protected new NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_ToStep")]
    protected new NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_ToWorkflow")]
    protected new RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Step")]
    protected new NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_WorkflowStack")]
    protected new NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_ToWorkflowStack")]
    protected new NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_ToSpecStep")]
    protected new NamedSubentityRef _ToSpecStep;

    public override bool Equals(object obj)
    {
      return obj is BPMoveNonStd && object.Equals((object) this._Comments, (object) ((BPMoveNonStd) obj)._Comments) && (object.Equals((object) this._Path, (object) ((BPMoveNonStd) obj)._Path) && object.Equals((object) this._ToStep, (object) ((BPMoveNonStd) obj)._ToStep)) && (object.Equals((object) this._ToWorkflow, (object) ((BPMoveNonStd) obj)._ToWorkflow) && object.Equals((object) this._Spec, (object) ((BPMoveNonStd) obj)._Spec) && (object.Equals((object) this._Step, (object) ((BPMoveNonStd) obj)._Step) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((BPMoveNonStd) obj)._WorkflowStack))) && (this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((BPMoveNonStd) obj)._ToWorkflowStack) && object.Equals((object) this._TrackableObject, (object) ((BPMoveNonStd) obj)._TrackableObject) && object.Equals((object) this._ToSpecStep, (object) ((BPMoveNonStd) obj)._ToSpecStep)) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public new NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
      }
    }

    public new NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }

    public new RevisionedObjectRef ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public new RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }

    public new NamedSubentityRef[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public new NamedSubentityRef[] ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new NamedSubentityRef ToSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSpecStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToSpecStep));
      }
    }
  }
}
