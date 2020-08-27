// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SpecStepChanges))]
  [KnownType(typeof (BPSubWorkflowStepChanges))]
  [KnownType(typeof (SubWorkflowStepChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BusinessProcessSpecStepChanges))]
  [Serializable]
  public class StepChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_RouteStep")]
    protected NamedSubentityRef _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Paths")]
    protected MovePathChanges[] _Paths;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_SchedulingDetail")]
    protected StepSchedulingDetailChanges _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_XLocation")]
    protected Primitive<int> _XLocation;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_DefaultPath")]
    protected NamedSubentityRef _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_YLocation")]
    protected Primitive<int> _YLocation;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_PathSelectors")]
    protected MovePathSelectorChanges[] _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_ReworkPaths")]
    protected ReworkPathChanges[] _ReworkPaths;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_WIPMsgLabel")]
    protected Primitive<string> _WIPMsgLabel;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_ReworkPathSelectors")]
    protected ReworkPathSelectorChanges[] _ReworkPathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_IsLastStep")]
    protected Primitive<bool> _IsLastStep;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_IsFirstStep")]
    protected Primitive<bool> _IsFirstStep;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_OnDefaultRoute")]
    protected Primitive<bool> _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_StepType")]
    protected Primitive<int> _StepType;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "StepChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is StepChanges && object.Equals((object) this._RouteStep, (object) ((StepChanges) obj)._RouteStep) && (this.CompareArrays((Array) this._Paths, (Array) ((StepChanges) obj)._Paths) && object.Equals((object) this._SchedulingDetail, (object) ((StepChanges) obj)._SchedulingDetail)) && (object.Equals((object) this._Sequence, (object) ((StepChanges) obj)._Sequence) && object.Equals((object) this._XLocation, (object) ((StepChanges) obj)._XLocation) && (object.Equals((object) this._DefaultPath, (object) ((StepChanges) obj)._DefaultPath) && object.Equals((object) this._YLocation, (object) ((StepChanges) obj)._YLocation))) && (this.CompareArrays((Array) this._PathSelectors, (Array) ((StepChanges) obj)._PathSelectors) && this.CompareArrays((Array) this._ReworkPaths, (Array) ((StepChanges) obj)._ReworkPaths) && (object.Equals((object) this._WIPMsgLabel, (object) ((StepChanges) obj)._WIPMsgLabel) && this.CompareArrays((Array) this._ReworkPathSelectors, (Array) ((StepChanges) obj)._ReworkPathSelectors)) && (object.Equals((object) this._IsLastStep, (object) ((StepChanges) obj)._IsLastStep) && object.Equals((object) this._IsFirstStep, (object) ((StepChanges) obj)._IsFirstStep) && (object.Equals((object) this._OnDefaultRoute, (object) ((StepChanges) obj)._OnDefaultRoute) && object.Equals((object) this._Notes, (object) ((StepChanges) obj)._Notes)))) && (object.Equals((object) this._StepType, (object) ((StepChanges) obj)._StepType) && object.Equals((object) this._Name, (object) ((StepChanges) obj)._Name) && (object.Equals((object) this._Description, (object) ((StepChanges) obj)._Description) && object.Equals((object) this._ObjectToChange, (object) ((StepChanges) obj)._ObjectToChange))) && base.Equals(obj);
    }

    public NamedSubentityRef RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (RouteStep));
      }
    }

    public MovePathChanges[] Paths
    {
      [param: In] set
      {
        this.PropertySet(nameof (Paths), (object) value);
      }
      get
      {
        return (MovePathChanges[]) this.PropertyGet(nameof (Paths));
      }
    }

    public StepSchedulingDetailChanges SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (StepSchedulingDetailChanges) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<int> XLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (XLocation), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (XLocation));
      }
    }

    public NamedSubentityRef DefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPath), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DefaultPath));
      }
    }

    public Primitive<int> YLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (YLocation), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (YLocation));
      }
    }

    public MovePathSelectorChanges[] PathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (PathSelectors), (object) value);
      }
      get
      {
        return (MovePathSelectorChanges[]) this.PropertyGet(nameof (PathSelectors));
      }
    }

    public ReworkPathChanges[] ReworkPaths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPaths), (object) value);
      }
      get
      {
        return (ReworkPathChanges[]) this.PropertyGet(nameof (ReworkPaths));
      }
    }

    public Primitive<string> WIPMsgLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgLabel), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WIPMsgLabel));
      }
    }

    public ReworkPathSelectorChanges[] ReworkPathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPathSelectors), (object) value);
      }
      get
      {
        return (ReworkPathSelectorChanges[]) this.PropertyGet(nameof (ReworkPathSelectors));
      }
    }

    public Primitive<bool> IsLastStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastStep), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLastStep));
      }
    }

    public Primitive<bool> IsFirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFirstStep), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFirstStep));
      }
    }

    public Primitive<bool> OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public Primitive<int> StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (StepType));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
