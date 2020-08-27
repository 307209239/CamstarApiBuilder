// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Step
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SubWorkflowStep))]
  [Serializable]
  public class Step : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "Step_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "Step_WIPMsgLabel")]
    protected Primitive<string> _WIPMsgLabel;
    [DataMember(EmitDefaultValue = false, Name = "Step_ReworkPathSelectors")]
    protected ReworkPathSelector[] _ReworkPathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "Step_ReworkPaths")]
    protected ReworkPath[] _ReworkPaths;
    [DataMember(EmitDefaultValue = false, Name = "Step_PathSelectors")]
    protected MovePathSelector[] _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "Step_Xlocation")]
    protected Primitive<int> _Xlocation;
    [DataMember(EmitDefaultValue = false, Name = "Step_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Step_SchedulingDetail")]
    protected StepSchedulingDetail _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "Step_Ylocation")]
    protected Primitive<int> _Ylocation;
    [DataMember(EmitDefaultValue = false, Name = "Step_Bins")]
    protected Bin[] _Bins;
    [DataMember(EmitDefaultValue = false, Name = "Step_RouteStep")]
    protected NamedSubentityRef _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_IsLastStep")]
    protected Primitive<bool> _IsLastStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_OnDefaultRoute")]
    protected Primitive<bool> _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "Step_IsFirstStep")]
    protected Primitive<bool> _IsFirstStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Step_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Step_StepType")]
    protected Primitive<int> _StepType;
    [DataMember(EmitDefaultValue = false, Name = "Step_Paths")]
    protected MovePath[] _Paths;
    [DataMember(EmitDefaultValue = false, Name = "Step_DefaultPath")]
    protected NamedSubentityRef _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "Step_Gates")]
    protected NamedSubentityRef[] _Gates;
    [DataMember(EmitDefaultValue = false, Name = "Step_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "Step_FirstSpecStep")]
    protected NamedSubentityRef _FirstSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "Step_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Step_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Step_ToSteps")]
    protected NamedSubentityRef[] _ToSteps;
    [DataMember(EmitDefaultValue = false, Name = "Step_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is Step && object.Equals((object) this._Sequence, (object) ((Step) obj)._Sequence) && (object.Equals((object) this._WIPMsgLabel, (object) ((Step) obj)._WIPMsgLabel) && this.CompareArrays((Array) this._ReworkPathSelectors, (Array) ((Step) obj)._ReworkPathSelectors)) && (this.CompareArrays((Array) this._ReworkPaths, (Array) ((Step) obj)._ReworkPaths) && this.CompareArrays((Array) this._PathSelectors, (Array) ((Step) obj)._PathSelectors) && (object.Equals((object) this._Xlocation, (object) ((Step) obj)._Xlocation) && object.Equals((object) this._ExportImportKey, (object) ((Step) obj)._ExportImportKey))) && (object.Equals((object) this._SchedulingDetail, (object) ((Step) obj)._SchedulingDetail) && object.Equals((object) this._Ylocation, (object) ((Step) obj)._Ylocation) && (this.CompareArrays((Array) this._Bins, (Array) ((Step) obj)._Bins) && object.Equals((object) this._RouteStep, (object) ((Step) obj)._RouteStep)) && (object.Equals((object) this._IsLastStep, (object) ((Step) obj)._IsLastStep) && object.Equals((object) this._OnDefaultRoute, (object) ((Step) obj)._OnDefaultRoute) && (object.Equals((object) this._IsFirstStep, (object) ((Step) obj)._IsFirstStep) && object.Equals((object) this._Operation, (object) ((Step) obj)._Operation)))) && (object.Equals((object) this._IsFrozen, (object) ((Step) obj)._IsFrozen) && object.Equals((object) this._StepType, (object) ((Step) obj)._StepType) && (this.CompareArrays((Array) this._Paths, (Array) ((Step) obj)._Paths) && object.Equals((object) this._DefaultPath, (object) ((Step) obj)._DefaultPath)) && (this.CompareArrays((Array) this._Gates, (Array) ((Step) obj)._Gates) && object.Equals((object) this._Workflow, (object) ((Step) obj)._Workflow) && (object.Equals((object) this._FirstSpecStep, (object) ((Step) obj)._FirstSpecStep) && object.Equals((object) this._IconId, (object) ((Step) obj)._IconId))) && (object.Equals((object) this._Notes, (object) ((Step) obj)._Notes) && object.Equals((object) this._Name, (object) ((Step) obj)._Name) && (this.CompareArrays((Array) this._ToSteps, (Array) ((Step) obj)._ToSteps) && object.Equals((object) this._Description, (object) ((Step) obj)._Description)))) && base.Equals(obj);
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

    public ReworkPathSelector[] ReworkPathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPathSelectors), (object) value);
      }
      get
      {
        return (ReworkPathSelector[]) this.PropertyGet(nameof (ReworkPathSelectors));
      }
    }

    public ReworkPath[] ReworkPaths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPaths), (object) value);
      }
      get
      {
        return (ReworkPath[]) this.PropertyGet(nameof (ReworkPaths));
      }
    }

    public MovePathSelector[] PathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (PathSelectors), (object) value);
      }
      get
      {
        return (MovePathSelector[]) this.PropertyGet(nameof (PathSelectors));
      }
    }

    public Primitive<int> Xlocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Xlocation), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Xlocation));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public StepSchedulingDetail SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (StepSchedulingDetail) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Primitive<int> Ylocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Ylocation), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Ylocation));
      }
    }

    public Bin[] Bins
    {
      [param: In] set
      {
        this.PropertySet(nameof (Bins), (object) value);
      }
      get
      {
        return (Bin[]) this.PropertyGet(nameof (Bins));
      }
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

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public new Primitive<bool> IsFrozen
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

    public MovePath[] Paths
    {
      [param: In] set
      {
        this.PropertySet(nameof (Paths), (object) value);
      }
      get
      {
        return (MovePath[]) this.PropertyGet(nameof (Paths));
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

    public NamedSubentityRef[] Gates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gates), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (Gates));
      }
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public NamedSubentityRef FirstSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstSpecStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FirstSpecStep));
      }
    }

    public Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
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

    public NamedSubentityRef[] ToSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSteps), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ToSteps));
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
  }
}
