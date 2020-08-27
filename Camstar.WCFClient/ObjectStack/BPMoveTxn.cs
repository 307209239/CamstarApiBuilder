// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveTxn
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
  public class BPMoveTxn : BusinessProcessTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_WorkflowNavigator")]
    protected SubentityRef _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_NavigationMode")]
    protected Enumeration<WorkflowNavigationModeEnum, int> _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_ToSpecStep")]
    protected NamedSubentityRef _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_ToWorkflowStack")]
    protected NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_ClearToWorkflowStack")]
    protected Primitive<bool> _ClearToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_FromStep")]
    protected NamedSubentityRef _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_ToStep")]
    protected NamedSubentityRef _ToStep;

    public override bool Equals(object obj)
    {
      return obj is BPMoveTxn && object.Equals((object) this._WorkflowNavigator, (object) ((BPMoveTxn) obj)._WorkflowNavigator) && (object.Equals((object) this._NavigationMode, (object) ((BPMoveTxn) obj)._NavigationMode) && object.Equals((object) this._Comments, (object) ((BPMoveTxn) obj)._Comments)) && (object.Equals((object) this._Path, (object) ((BPMoveTxn) obj)._Path) && object.Equals((object) this._ToSpecStep, (object) ((BPMoveTxn) obj)._ToSpecStep) && (this.CompareArrays((Array) this._WorkflowStack, (Array) ((BPMoveTxn) obj)._WorkflowStack) && object.Equals((object) this._Step, (object) ((BPMoveTxn) obj)._Step))) && (this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((BPMoveTxn) obj)._ToWorkflowStack) && object.Equals((object) this._Spec, (object) ((BPMoveTxn) obj)._Spec) && (object.Equals((object) this._ToWorkflow, (object) ((BPMoveTxn) obj)._ToWorkflow) && object.Equals((object) this._TrackableObject, (object) ((BPMoveTxn) obj)._TrackableObject)) && (object.Equals((object) this._ClearToWorkflowStack, (object) ((BPMoveTxn) obj)._ClearToWorkflowStack) && object.Equals((object) this._FromStep, (object) ((BPMoveTxn) obj)._FromStep) && object.Equals((object) this._ToStep, (object) ((BPMoveTxn) obj)._ToStep))) && base.Equals(obj);
    }

    public SubentityRef WorkflowNavigator
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

    public Enumeration<WorkflowNavigationModeEnum, int> NavigationMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NavigationMode), (object) value);
      }
      get
      {
        return (Enumeration<WorkflowNavigationModeEnum, int>) this.PropertyGet(nameof (NavigationMode));
      }
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

    public NamedSubentityRef Path
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

    public NamedSubentityRef ToSpecStep
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

    public NamedSubentityRef[] WorkflowStack
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

    public NamedSubentityRef Step
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

    public NamedSubentityRef[] ToWorkflowStack
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

    public RevisionedObjectRef Spec
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

    public RevisionedObjectRef ToWorkflow
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

    public Primitive<bool> ClearToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearToWorkflowStack), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ClearToWorkflowStack));
      }
    }

    public NamedSubentityRef FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromStep));
      }
    }

    public NamedSubentityRef ToStep
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
  }
}
