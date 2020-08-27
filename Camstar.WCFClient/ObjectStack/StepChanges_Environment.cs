// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SubWorkflowStepChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BusinessProcessSpecStepChanges_Environment))]
  [KnownType(typeof (SpecStepChanges_Environment))]
  [KnownType(typeof (BPSubWorkflowStepChanges_Environment))]
  [Serializable]
  public class StepChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_RouteStep")]
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, false, "NamedSubentityRef", 1049917, false, false, true, null)]
    protected Environment _RouteStep;
    [Metadata("Changes CDO for Path.", "MovePathChanges", false, false, false, "MovePathChanges", 1048914, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_Paths")]
    protected MovePathChanges_Environment _Paths;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_SchedulingDetail")]
    [Metadata("Changes CDO for StepSchedulingDetail.", "StepSchedulingDetailChanges", false, false, false, "StepSchedulingDetailChanges", 1050045, true, false, false, null)]
    protected StepSchedulingDetailChanges_Environment _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, "0")]
    protected Environment _Sequence;
    [Metadata("X-Y axis coordinate for drawing a Workflow Step", "", false, false, false, "Integer", 1050046, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_XLocation")]
    protected Environment _XLocation;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_DefaultPath")]
    [Metadata("Changes CDO for Path.", "MovePathChanges", false, false, false, "NamedSubentityRef", 1048911, false, false, false, null)]
    protected Environment _DefaultPath;
    [Metadata("X-Y axis coordinate for drawing a Workflow Step", "", false, false, false, "Integer", 1050047, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_YLocation")]
    protected Environment _YLocation;
    [Metadata("MovePathSelectorChanges", "MovePathSelectorChanges", false, false, false, "MovePathSelectorChanges", 1048915, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_PathSelectors")]
    protected MovePathSelectorChanges_Environment _PathSelectors;
    [Metadata("ReworkPathChanges", "ReworkPathChanges", false, false, false, "ReworkPathChanges", 1050300, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_ReworkPaths")]
    protected ReworkPathChanges_Environment _ReworkPaths;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_WIPMsgLabel")]
    [Metadata("Identifier for relating a WIP Message to one or more Steps. WIP Messages defined for all Modeling Entities except a Step or Operation can be qualified with a WIP Message Label. This allows the same message to be associated with multiple Steps.", "", false, false, false, "String", 1050049, false, false, false, null)]
    protected Environment _WIPMsgLabel;
    [Metadata("ReworkPathSelectorChanges", "ReworkPathSelectorChanges", false, false, false, "ReworkPathSelectorChanges", 1050301, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_ReworkPathSelectors")]
    protected ReworkPathSelectorChanges_Environment _ReworkPathSelectors;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052989, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_IsLastStep")]
    protected Environment _IsLastStep;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050279, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_IsFirstStep")]
    protected Environment _IsFirstStep;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048913, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_OnDefaultRoute")]
    protected Environment _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1048918, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_StepType")]
    protected Environment _StepType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049579, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Environment_ObjectToChange")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public Environment RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteStep));
      }
    }

    public MovePathChanges_Environment Paths
    {
      [param: In] set
      {
        this.PropertySet(nameof (Paths), (object) value);
      }
      get
      {
        return (MovePathChanges_Environment) this.PropertyGet(nameof (Paths));
      }
    }

    public StepSchedulingDetailChanges_Environment SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (StepSchedulingDetailChanges_Environment) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment XLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (XLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (XLocation));
      }
    }

    public Environment DefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultPath));
      }
    }

    public Environment YLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (YLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (YLocation));
      }
    }

    public MovePathSelectorChanges_Environment PathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (PathSelectors), (object) value);
      }
      get
      {
        return (MovePathSelectorChanges_Environment) this.PropertyGet(nameof (PathSelectors));
      }
    }

    public ReworkPathChanges_Environment ReworkPaths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPaths), (object) value);
      }
      get
      {
        return (ReworkPathChanges_Environment) this.PropertyGet(nameof (ReworkPaths));
      }
    }

    public Environment WIPMsgLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgLabel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgLabel));
      }
    }

    public ReworkPathSelectorChanges_Environment ReworkPathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPathSelectors), (object) value);
      }
      get
      {
        return (ReworkPathSelectorChanges_Environment) this.PropertyGet(nameof (ReworkPathSelectors));
      }
    }

    public Environment IsLastStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLastStep));
      }
    }

    public Environment IsFirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFirstStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFirstStep));
      }
    }

    public Environment OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public Environment StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepType));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
