// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveTxn_Info
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
  public class BPMoveTxn_Info : BusinessProcessTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_WorkflowNavigator")]
    protected Info _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_NavigationMode")]
    protected Info _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_ToSpecStep")]
    protected Info _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_ToWorkflowStack")]
    protected Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_ToWorkflow")]
    protected Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_ClearToWorkflowStack")]
    protected Info _ClearToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_FromStep")]
    protected Info _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Info_ToStep")]
    protected Info _ToStep;

    public Info WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Info NavigationMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NavigationMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NavigationMode));
      }
    }

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
      }
    }

    public Info ToSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSpecStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToSpecStep));
      }
    }

    public Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
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

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
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

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Info ClearToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearToWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClearToWorkflowStack));
      }
    }

    public Info FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStep));
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
  }
}
