// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveNonStd_Info
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
  public class BPMoveNonStd_Info : BPMoveTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_Path")]
    protected new Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_ToStep")]
    protected new Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_ToWorkflow")]
    protected new Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_Spec")]
    protected new Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_Step")]
    protected new Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_WorkflowStack")]
    protected new Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_ToWorkflowStack")]
    protected new Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Info_ToSpecStep")]
    protected new Info _ToSpecStep;

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

    public new Info Path
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

    public new Info ToStep
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

    public new Info ToWorkflow
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

    public new Info Spec
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

    public new Info Step
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

    public new Info WorkflowStack
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

    public new Info ToWorkflowStack
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

    public new Info ToSpecStep
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
  }
}
