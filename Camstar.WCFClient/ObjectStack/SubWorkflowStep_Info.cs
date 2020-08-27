// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubWorkflowStep_Info
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
  public class SubWorkflowStep_Info : Step_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Xlocation")]
    protected new Info _Xlocation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_PathSelectors")]
    protected new MovePathSelector_Info _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_FirstSpecStep")]
    protected new Info _FirstSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_SchedulingDetail")]
    protected SubWorkflowStepSchedulingDetail_Info _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Sequence")]
    protected new Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Ylocation")]
    protected new Info _Ylocation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_OnDefaultRoute")]
    protected new Info _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_DefaultPath")]
    protected new Info _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Operation")]
    protected new Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_SubWorkflow")]
    protected Info _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_StepType")]
    protected new Info _StepType;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Info_Name")]
    protected new Info _Name;

    public new Info Xlocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Xlocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Xlocation));
      }
    }

    public new MovePathSelector_Info PathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (PathSelectors), (object) value);
      }
      get
      {
        return (MovePathSelector_Info) this.PropertyGet(nameof (PathSelectors));
      }
    }

    public new Info FirstSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstSpecStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstSpecStep));
      }
    }

    public SubWorkflowStepSchedulingDetail_Info SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SubWorkflowStepSchedulingDetail_Info) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public new Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public new Info Ylocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Ylocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Ylocation));
      }
    }

    public new Info OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
      }
    }

    public new Info DefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultPath));
      }
    }

    public new Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubWorkflow));
      }
    }

    public new Info StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepType));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
