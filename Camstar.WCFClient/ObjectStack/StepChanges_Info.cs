// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SpecStepChanges_Info))]
  [KnownType(typeof (SubWorkflowStepChanges_Info))]
  [KnownType(typeof (BPSubWorkflowStepChanges_Info))]
  [KnownType(typeof (BusinessProcessSpecStepChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StepChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_RouteStep")]
    protected Info _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_Paths")]
    protected MovePathChanges_Info _Paths;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_SchedulingDetail")]
    protected StepSchedulingDetailChanges_Info _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_XLocation")]
    protected Info _XLocation;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_DefaultPath")]
    protected Info _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_YLocation")]
    protected Info _YLocation;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_PathSelectors")]
    protected MovePathSelectorChanges_Info _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_ReworkPaths")]
    protected ReworkPathChanges_Info _ReworkPaths;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_WIPMsgLabel")]
    protected Info _WIPMsgLabel;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_ReworkPathSelectors")]
    protected ReworkPathSelectorChanges_Info _ReworkPathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_IsLastStep")]
    protected Info _IsLastStep;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_IsFirstStep")]
    protected Info _IsFirstStep;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_OnDefaultRoute")]
    protected Info _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_StepType")]
    protected Info _StepType;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

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

    public MovePathChanges_Info Paths
    {
      [param: In] set
      {
        this.PropertySet(nameof (Paths), (object) value);
      }
      get
      {
        return (MovePathChanges_Info) this.PropertyGet(nameof (Paths));
      }
    }

    public StepSchedulingDetailChanges_Info SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (StepSchedulingDetailChanges_Info) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

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

    public Info XLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (XLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (XLocation));
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

    public Info YLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (YLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (YLocation));
      }
    }

    public MovePathSelectorChanges_Info PathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (PathSelectors), (object) value);
      }
      get
      {
        return (MovePathSelectorChanges_Info) this.PropertyGet(nameof (PathSelectors));
      }
    }

    public ReworkPathChanges_Info ReworkPaths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPaths), (object) value);
      }
      get
      {
        return (ReworkPathChanges_Info) this.PropertyGet(nameof (ReworkPaths));
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

    public ReworkPathSelectorChanges_Info ReworkPathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPathSelectors), (object) value);
      }
      get
      {
        return (ReworkPathSelectorChanges_Info) this.PropertyGet(nameof (ReworkPathSelectors));
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
  }
}
