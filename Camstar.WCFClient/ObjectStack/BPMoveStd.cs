// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveStd
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
  public class BPMoveStd : BPMoveTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_WorkflowNavigator")]
    protected new SubentityRef _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_ToWorkflow")]
    protected new RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_ToStep")]
    protected new NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_Path")]
    protected new NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_ToSpecStep")]
    protected new NamedSubentityRef _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_WorkflowStack")]
    protected new NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_ToWorkflowStack")]
    protected new NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveStd_Step")]
    protected new NamedSubentityRef _Step;

    public override bool Equals(object obj)
    {
      return obj is BPMoveStd && object.Equals((object) this._WorkflowNavigator, (object) ((BPMoveStd) obj)._WorkflowNavigator) && (object.Equals((object) this._ToWorkflow, (object) ((BPMoveStd) obj)._ToWorkflow) && object.Equals((object) this._ToStep, (object) ((BPMoveStd) obj)._ToStep)) && (object.Equals((object) this._Spec, (object) ((BPMoveStd) obj)._Spec) && object.Equals((object) this._TrackableObject, (object) ((BPMoveStd) obj)._TrackableObject) && (object.Equals((object) this._Path, (object) ((BPMoveStd) obj)._Path) && object.Equals((object) this._ToSpecStep, (object) ((BPMoveStd) obj)._ToSpecStep))) && (this.CompareArrays((Array) this._WorkflowStack, (Array) ((BPMoveStd) obj)._WorkflowStack) && this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((BPMoveStd) obj)._ToWorkflowStack) && object.Equals((object) this._Step, (object) ((BPMoveStd) obj)._Step)) && base.Equals(obj);
    }

    public new SubentityRef WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WorkflowNavigator));
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
  }
}
