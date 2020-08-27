// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ValueDataPointChanges
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
  public class ValueDataPointChanges : DataPointChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_DataType")]
    protected new Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_AttributeName")]
    protected Primitive<string> _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_MapToUserAttribute")]
    protected Primitive<bool> _MapToUserAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_BooleanTrue")]
    protected Primitive<string> _BooleanTrue;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_DisplayLimits")]
    protected Primitive<bool> _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_BooleanFalse")]
    protected Primitive<string> _BooleanFalse;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_IsLimitOverrideAllowed")]
    protected Primitive<bool> _IsLimitOverrideAllowed;

    public override bool Equals(object obj)
    {
      return obj is ValueDataPointChanges && object.Equals((object) this._UpperLimit, (object) ((ValueDataPointChanges) obj)._UpperLimit) && (object.Equals((object) this._UOM, (object) ((ValueDataPointChanges) obj)._UOM) && object.Equals((object) this._ObjectToChange, (object) ((ValueDataPointChanges) obj)._ObjectToChange)) && (object.Equals((object) this._DataType, (object) ((ValueDataPointChanges) obj)._DataType) && object.Equals((object) this._LowerLimit, (object) ((ValueDataPointChanges) obj)._LowerLimit) && (object.Equals((object) this._ListItemToChange, (object) ((ValueDataPointChanges) obj)._ListItemToChange) && object.Equals((object) this._AttributeName, (object) ((ValueDataPointChanges) obj)._AttributeName))) && (object.Equals((object) this._MapToUserAttribute, (object) ((ValueDataPointChanges) obj)._MapToUserAttribute) && object.Equals((object) this._BooleanTrue, (object) ((ValueDataPointChanges) obj)._BooleanTrue) && (object.Equals((object) this._DisplayLimits, (object) ((ValueDataPointChanges) obj)._DisplayLimits) && object.Equals((object) this._BooleanFalse, (object) ((ValueDataPointChanges) obj)._BooleanFalse)) && object.Equals((object) this._IsLimitOverrideAllowed, (object) ((ValueDataPointChanges) obj)._IsLimitOverrideAllowed)) && base.Equals(obj);
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

    public new Enumeration<DataTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (DataType));
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

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<string> AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeName));
      }
    }

    public Primitive<bool> MapToUserAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToUserAttribute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (MapToUserAttribute));
      }
    }

    public Primitive<string> BooleanTrue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanTrue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BooleanTrue));
      }
    }

    public Primitive<bool> DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Primitive<string> BooleanFalse
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanFalse), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BooleanFalse));
      }
    }

    public Primitive<bool> IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }
  }
}
