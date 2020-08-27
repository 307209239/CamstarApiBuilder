// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubWorkflowStep
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
  public class SubWorkflowStep : Step
  {
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Xlocation")]
    protected new Primitive<int> _Xlocation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_PathSelectors")]
    protected new MovePathSelector[] _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_FirstSpecStep")]
    protected new NamedSubentityRef _FirstSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_SchedulingDetail")]
    protected SubWorkflowStepSchedulingDetail _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Ylocation")]
    protected new Primitive<int> _Ylocation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_OnDefaultRoute")]
    protected new Primitive<bool> _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_DefaultPath")]
    protected new NamedSubentityRef _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Operation")]
    protected new NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_SubWorkflow")]
    protected RevisionedObjectRef _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_StepType")]
    protected new Primitive<int> _StepType;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SubWorkflowStep && object.Equals((object) this._Xlocation, (object) ((SubWorkflowStep) obj)._Xlocation) && (this.CompareArrays((Array) this._PathSelectors, (Array) ((SubWorkflowStep) obj)._PathSelectors) && object.Equals((object) this._FirstSpecStep, (object) ((SubWorkflowStep) obj)._FirstSpecStep)) && (object.Equals((object) this._SchedulingDetail, (object) ((SubWorkflowStep) obj)._SchedulingDetail) && object.Equals((object) this._Sequence, (object) ((SubWorkflowStep) obj)._Sequence) && (object.Equals((object) this._Ylocation, (object) ((SubWorkflowStep) obj)._Ylocation) && object.Equals((object) this._OnDefaultRoute, (object) ((SubWorkflowStep) obj)._OnDefaultRoute))) && (object.Equals((object) this._IconId, (object) ((SubWorkflowStep) obj)._IconId) && object.Equals((object) this._DefaultPath, (object) ((SubWorkflowStep) obj)._DefaultPath) && (object.Equals((object) this._Operation, (object) ((SubWorkflowStep) obj)._Operation) && object.Equals((object) this._Notes, (object) ((SubWorkflowStep) obj)._Notes)) && (object.Equals((object) this._Description, (object) ((SubWorkflowStep) obj)._Description) && object.Equals((object) this._SubWorkflow, (object) ((SubWorkflowStep) obj)._SubWorkflow) && (object.Equals((object) this._StepType, (object) ((SubWorkflowStep) obj)._StepType) && object.Equals((object) this._Name, (object) ((SubWorkflowStep) obj)._Name)))) && base.Equals(obj);
    }

    public new Primitive<int> Xlocation
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

    public new MovePathSelector[] PathSelectors
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

    public new NamedSubentityRef FirstSpecStep
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

    public SubWorkflowStepSchedulingDetail SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SubWorkflowStepSchedulingDetail) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public new Primitive<int> Sequence
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

    public new Primitive<int> Ylocation
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

    public new Primitive<bool> OnDefaultRoute
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

    public new Primitive<int> IconId
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

    public new NamedSubentityRef DefaultPath
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

    public new NamedObjectRef Operation
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

    public new Primitive<string> Notes
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

    public new Primitive<string> Description
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

    public RevisionedObjectRef SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SubWorkflow));
      }
    }

    public new Primitive<int> StepType
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
  }
}
