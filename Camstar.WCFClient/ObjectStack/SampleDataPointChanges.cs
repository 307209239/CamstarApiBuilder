// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleDataPointChanges
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
  public class SampleDataPointChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_DefaultValue")]
    protected Primitive<string> _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_ShowLimits")]
    protected Primitive<bool> _ShowLimits;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SampleDataPointChanges && object.Equals((object) this._UOM, (object) ((SampleDataPointChanges) obj)._UOM) && (object.Equals((object) this._Base, (object) ((SampleDataPointChanges) obj)._Base) && object.Equals((object) this._ObjectToChange, (object) ((SampleDataPointChanges) obj)._ObjectToChange)) && (object.Equals((object) this._DataType, (object) ((SampleDataPointChanges) obj)._DataType) && object.Equals((object) this._DefaultValue, (object) ((SampleDataPointChanges) obj)._DefaultValue) && (object.Equals((object) this._UpperLimit, (object) ((SampleDataPointChanges) obj)._UpperLimit) && object.Equals((object) this._LowerLimit, (object) ((SampleDataPointChanges) obj)._LowerLimit))) && (object.Equals((object) this._ShowLimits, (object) ((SampleDataPointChanges) obj)._ShowLimits) && object.Equals((object) this._Name, (object) ((SampleDataPointChanges) obj)._Name)) && base.Equals(obj);
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
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

    public Enumeration<TrivialTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public Primitive<string> DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public Primitive<string> UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Primitive<string> LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Primitive<bool> ShowLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowLimits));
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
