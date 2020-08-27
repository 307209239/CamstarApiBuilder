// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerDtlChanges_Info
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
  public class ProcessTimerDtlChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_DefaultFailureMode")]
    protected Info _DefaultFailureMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_DefaultPEDescription")]
    protected Info _DefaultPEDescription;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ToWorkflowStack")]
    protected Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_TimerAction")]
    protected Info _TimerAction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_BusinessRule")]
    protected Info _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsConfirmation")]
    protected Info _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsBusinessRule")]
    protected Info _IsBusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsProductionEvent")]
    protected Info _IsProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsRework")]
    protected Info _IsRework;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsMoveNonStd")]
    protected Info _IsMoveNonStd;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsHold")]
    protected Info _IsHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ToWorkflow")]
    protected Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ToStepName")]
    protected Info _ToStepName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtlChanges_Info_Resource")]
    protected Info _Resource;

    public Info DefaultFailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultFailureMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultFailureMode));
      }
    }

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Info DefaultPEDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPEDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultPEDescription));
      }
    }

    public Info ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
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

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Info TimerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerAction));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public Info BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsConfirmation));
      }
    }

    public Info IsBusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsBusinessRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsBusinessRule));
      }
    }

    public Info IsProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsProductionEvent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsProductionEvent));
      }
    }

    public Info IsRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRework), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRework));
      }
    }

    public Info IsMoveNonStd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsMoveNonStd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsMoveNonStd));
      }
    }

    public Info IsHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsHold));
      }
    }

    public Info ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
      }
    }

    public Info ToStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStepName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStepName));
      }
    }

    public Info ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
