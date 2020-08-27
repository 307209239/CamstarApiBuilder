// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStepChanges
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
  public class SpecStepChanges : StepChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStepChanges_SchedulingDetail")]
    protected SpecStepSchedulingDetailChanges _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepChanges_StepType")]
    protected new Primitive<int> _StepType;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepChanges_Operation")]
    protected NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is SpecStepChanges && object.Equals((object) this._SchedulingDetail, (object) ((SpecStepChanges) obj)._SchedulingDetail) && (object.Equals((object) this._ObjectToChange, (object) ((SpecStepChanges) obj)._ObjectToChange) && object.Equals((object) this._Spec, (object) ((SpecStepChanges) obj)._Spec)) && (object.Equals((object) this._Name, (object) ((SpecStepChanges) obj)._Name) && object.Equals((object) this._StepType, (object) ((SpecStepChanges) obj)._StepType) && object.Equals((object) this._Operation, (object) ((SpecStepChanges) obj)._Operation)) && base.Equals(obj);
    }

    public SpecStepSchedulingDetailChanges SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SpecStepSchedulingDetailChanges) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public new NamedSubentityRef ObjectToChange
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

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
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
  }
}
