// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerDtlChanges
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
  public class ProcessTimerDtlChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_DefaultFailureMode")]
    protected NamedObjectRef _DefaultFailureMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_DefaultPEDescription")]
    protected Primitive<string> _DefaultPEDescription;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ToWorkflowStack")]
    protected NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_TimerAction")]
    protected Enumeration<TimerActionEnum, int> _TimerAction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_BusinessRule")]
    protected NamedObjectRef _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsConfirmation")]
    protected Primitive<bool> _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsBusinessRule")]
    protected Primitive<bool> _IsBusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsProductionEvent")]
    protected Primitive<bool> _IsProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsRework")]
    protected Primitive<bool> _IsRework;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsMoveNonStd")]
    protected Primitive<bool> _IsMoveNonStd;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsHold")]
    protected Primitive<bool> _IsHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ToStepName")]
    protected Primitive<string> _ToStepName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is ProcessTimerDtlChanges && object.Equals((object) this._DefaultFailureMode, (object) ((ProcessTimerDtlChanges) obj)._DefaultFailureMode) && (object.Equals((object) this._ResourceGroup, (object) ((ProcessTimerDtlChanges) obj)._ResourceGroup) && object.Equals((object) this._DefaultPEDescription, (object) ((ProcessTimerDtlChanges) obj)._DefaultPEDescription)) && (this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((ProcessTimerDtlChanges) obj)._ToWorkflowStack) && object.Equals((object) this._HoldReason, (object) ((ProcessTimerDtlChanges) obj)._HoldReason) && (object.Equals((object) this._ESigRequirement, (object) ((ProcessTimerDtlChanges) obj)._ESigRequirement) && object.Equals((object) this._ObjectToChange, (object) ((ProcessTimerDtlChanges) obj)._ObjectToChange))) && (object.Equals((object) this._SubClassification, (object) ((ProcessTimerDtlChanges) obj)._SubClassification) && object.Equals((object) this._TimerAction, (object) ((ProcessTimerDtlChanges) obj)._TimerAction) && (object.Equals((object) this._Classification, (object) ((ProcessTimerDtlChanges) obj)._Classification) && object.Equals((object) this._BusinessRule, (object) ((ProcessTimerDtlChanges) obj)._BusinessRule)) && (object.Equals((object) this._ListItemToChange, (object) ((ProcessTimerDtlChanges) obj)._ListItemToChange) && object.Equals((object) this._IsConfirmation, (object) ((ProcessTimerDtlChanges) obj)._IsConfirmation) && (object.Equals((object) this._IsBusinessRule, (object) ((ProcessTimerDtlChanges) obj)._IsBusinessRule) && object.Equals((object) this._IsProductionEvent, (object) ((ProcessTimerDtlChanges) obj)._IsProductionEvent)))) && (object.Equals((object) this._IsRework, (object) ((ProcessTimerDtlChanges) obj)._IsRework) && object.Equals((object) this._IsMoveNonStd, (object) ((ProcessTimerDtlChanges) obj)._IsMoveNonStd) && (object.Equals((object) this._IsHold, (object) ((ProcessTimerDtlChanges) obj)._IsHold) && object.Equals((object) this._ToWorkflow, (object) ((ProcessTimerDtlChanges) obj)._ToWorkflow)) && (object.Equals((object) this._ToStep, (object) ((ProcessTimerDtlChanges) obj)._ToStep) && object.Equals((object) this._ToStepName, (object) ((ProcessTimerDtlChanges) obj)._ToStepName) && (object.Equals((object) this._ReworkReason, (object) ((ProcessTimerDtlChanges) obj)._ReworkReason) && object.Equals((object) this._IsFrozen, (object) ((ProcessTimerDtlChanges) obj)._IsFrozen))) && object.Equals((object) this._Resource, (object) ((ProcessTimerDtlChanges) obj)._Resource)) && base.Equals(obj);
    }

    public NamedObjectRef DefaultFailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultFailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultFailureMode));
      }
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Primitive<string> DefaultPEDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPEDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultPEDescription));
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

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Enumeration<TimerActionEnum, int> TimerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerAction), (object) value);
      }
      get
      {
        return (Enumeration<TimerActionEnum, int>) this.PropertyGet(nameof (TimerAction));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public NamedObjectRef BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsConfirmation));
      }
    }

    public Primitive<bool> IsBusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsBusinessRule), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsBusinessRule));
      }
    }

    public Primitive<bool> IsProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsProductionEvent), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsProductionEvent));
      }
    }

    public Primitive<bool> IsRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRework), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRework));
      }
    }

    public Primitive<bool> IsMoveNonStd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsMoveNonStd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsMoveNonStd));
      }
    }

    public Primitive<bool> IsHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsHold));
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

    public Primitive<string> ToStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStepName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ToStepName));
      }
    }

    public NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
