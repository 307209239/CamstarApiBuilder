// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Step_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SubWorkflowStep_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Step_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_WIPMsgLabel")]
    protected Info _WIPMsgLabel;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_ReworkPathSelectors")]
    protected ReworkPathSelector_Info _ReworkPathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_ReworkPaths")]
    protected ReworkPath_Info _ReworkPaths;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_PathSelectors")]
    protected MovePathSelector_Info _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Xlocation")]
    protected Info _Xlocation;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_SchedulingDetail")]
    protected StepSchedulingDetail_Info _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Ylocation")]
    protected Info _Ylocation;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Bins")]
    protected Bin_Info _Bins;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_RouteStep")]
    protected Info _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_IsLastStep")]
    protected Info _IsLastStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_OnDefaultRoute")]
    protected Info _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_IsFirstStep")]
    protected Info _IsFirstStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_StepType")]
    protected Info _StepType;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Paths")]
    protected MovePath_Info _Paths;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_DefaultPath")]
    protected Info _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Gates")]
    protected Info _Gates;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_FirstSpecStep")]
    protected Info _FirstSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_IconId")]
    protected Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_ToSteps")]
    protected Info _ToSteps;
    [DataMember(EmitDefaultValue = false, Name = "Step_Info_Description")]
    protected Info _Description;

    public Info Sequence
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

    public Info WIPMsgLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgLabel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgLabel));
      }
    }

    public ReworkPathSelector_Info ReworkPathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPathSelectors), (object) value);
      }
      get
      {
        return (ReworkPathSelector_Info) this.PropertyGet(nameof (ReworkPathSelectors));
      }
    }

    public ReworkPath_Info ReworkPaths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPaths), (object) value);
      }
      get
      {
        return (ReworkPath_Info) this.PropertyGet(nameof (ReworkPaths));
      }
    }

    public MovePathSelector_Info PathSelectors
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

    public Info Xlocation
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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public StepSchedulingDetail_Info SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (StepSchedulingDetail_Info) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Info Ylocation
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

    public Bin_Info Bins
    {
      [param: In] set
      {
        this.PropertySet(nameof (Bins), (object) value);
      }
      get
      {
        return (Bin_Info) this.PropertyGet(nameof (Bins));
      }
    }

    public Info RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteStep));
      }
    }

    public Info IsLastStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLastStep));
      }
    }

    public Info OnDefaultRoute
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

    public Info IsFirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFirstStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFirstStep));
      }
    }

    public Info Operation
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

    public new Info IsFrozen
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

    public Info StepType
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

    public MovePath_Info Paths
    {
      [param: In] set
      {
        this.PropertySet(nameof (Paths), (object) value);
      }
      get
      {
        return (MovePath_Info) this.PropertyGet(nameof (Paths));
      }
    }

    public Info DefaultPath
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

    public Info Gates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gates), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Gates));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info FirstSpecStep
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

    public Info IconId
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

    public Info Notes
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

    public Info ToSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSteps), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToSteps));
      }
    }

    public Info Description
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
  }
}
