// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessSpecStepChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChangeMgtSpecStepChanges))]
  [Serializable]
  public class BusinessProcessSpecStepChanges : StepChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_OnDefaultRoute")]
    protected new Primitive<bool> _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_StepType")]
    protected new Primitive<int> _StepType;

    public override bool Equals(object obj)
    {
      return obj is BusinessProcessSpecStepChanges && object.Equals((object) this._Sequence, (object) ((BusinessProcessSpecStepChanges) obj)._Sequence) && (object.Equals((object) this._ObjectToChange, (object) ((BusinessProcessSpecStepChanges) obj)._ObjectToChange) && object.Equals((object) this._Spec, (object) ((BusinessProcessSpecStepChanges) obj)._Spec)) && (object.Equals((object) this._OnDefaultRoute, (object) ((BusinessProcessSpecStepChanges) obj)._OnDefaultRoute) && object.Equals((object) this._Name, (object) ((BusinessProcessSpecStepChanges) obj)._Name) && object.Equals((object) this._StepType, (object) ((BusinessProcessSpecStepChanges) obj)._StepType)) && base.Equals(obj);
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
  }
}
