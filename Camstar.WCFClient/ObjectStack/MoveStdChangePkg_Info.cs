// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveStdChangePkg_Info
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
  public class MoveStdChangePkg_Info : BPMoveStd_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_WorkflowNavigator")]
    protected new Info _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_Step")]
    protected new Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_WorkflowStack")]
    protected new Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_ToSpecStep")]
    protected new Info _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_Spec")]
    protected new Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_ToWorkflow")]
    protected new Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_ToWorkflowStack")]
    protected new Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Info_ChangePackageHeader")]
    protected ChangePackageHeader_Info _ChangePackageHeader;

    public new Info WorkflowNavigator
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

    public ChangePackageHeader_Info ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Info) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }
  }
}
