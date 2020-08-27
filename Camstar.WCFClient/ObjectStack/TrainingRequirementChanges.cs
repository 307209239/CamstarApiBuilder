// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRequirementChanges
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
  public class TrainingRequirementChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_ExpirationPeriod")]
    protected Primitive<int> _ExpirationPeriod;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Trainers")]
    protected NamedObjectRef[] _Trainers;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_SOPDoc")]
    protected RevisionedObjectRef _SOPDoc;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TrainingRequirementChanges && object.Equals((object) this._Base, (object) ((TrainingRequirementChanges) obj)._Base) && (object.Equals((object) this._ObjectToChange, (object) ((TrainingRequirementChanges) obj)._ObjectToChange) && object.Equals((object) this._EffectiveFromDate, (object) ((TrainingRequirementChanges) obj)._EffectiveFromDate)) && (object.Equals((object) this._EffectiveThruDate, (object) ((TrainingRequirementChanges) obj)._EffectiveThruDate) && object.Equals((object) this._ExpirationDate, (object) ((TrainingRequirementChanges) obj)._ExpirationDate) && (object.Equals((object) this._ExpirationPeriod, (object) ((TrainingRequirementChanges) obj)._ExpirationPeriod) && this.CompareArrays((Array) this._Trainers, (Array) ((TrainingRequirementChanges) obj)._Trainers))) && (object.Equals((object) this._SOPDoc, (object) ((TrainingRequirementChanges) obj)._SOPDoc) && object.Equals((object) this._Name, (object) ((TrainingRequirementChanges) obj)._Name)) && base.Equals(obj);
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<DateTime> EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Primitive<DateTime> EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Primitive<DateTime> ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Primitive<int> ExpirationPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationPeriod), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExpirationPeriod));
      }
    }

    public NamedObjectRef[] Trainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Trainers), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Trainers));
      }
    }

    public RevisionedObjectRef SOPDoc
    {
      [param: In] set
      {
        this.PropertySet(nameof (SOPDoc), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SOPDoc));
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
