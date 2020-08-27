// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationChanges
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
  public class ComputationChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_ComputationExpression")]
    protected Primitive<string> _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_ResultDataType")]
    protected Enumeration<DataTypeEnum, int> _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_ComputationParamSpecs")]
    protected ComputationParamSpecChanges[] _ComputationParamSpecs;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_AttributeName")]
    protected Primitive<string> _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_MapToContainerAttribute")]
    protected Primitive<bool> _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_DisplayLimits")]
    protected Primitive<bool> _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_IsLimitOverrideAllowed")]
    protected Primitive<bool> _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_ResultName")]
    protected Primitive<string> _ResultName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ComputationChanges && object.Equals((object) this._LowerLimit, (object) ((ComputationChanges) obj)._LowerLimit) && (object.Equals((object) this._UpperLimit, (object) ((ComputationChanges) obj)._UpperLimit) && object.Equals((object) this._ComputationExpression, (object) ((ComputationChanges) obj)._ComputationExpression)) && (object.Equals((object) this._ResultDataType, (object) ((ComputationChanges) obj)._ResultDataType) && this.CompareArrays((Array) this._ComputationParamSpecs, (Array) ((ComputationChanges) obj)._ComputationParamSpecs) && (object.Equals((object) this._ObjectToChange, (object) ((ComputationChanges) obj)._ObjectToChange) && object.Equals((object) this._AttributeName, (object) ((ComputationChanges) obj)._AttributeName))) && (object.Equals((object) this._MapToContainerAttribute, (object) ((ComputationChanges) obj)._MapToContainerAttribute) && object.Equals((object) this._DisplayLimits, (object) ((ComputationChanges) obj)._DisplayLimits) && (object.Equals((object) this._IsLimitOverrideAllowed, (object) ((ComputationChanges) obj)._IsLimitOverrideAllowed) && object.Equals((object) this._ResultName, (object) ((ComputationChanges) obj)._ResultName)) && object.Equals((object) this._Name, (object) ((ComputationChanges) obj)._Name)) && base.Equals(obj);
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

    public Primitive<string> ComputationExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationExpression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ComputationExpression));
      }
    }

    public Enumeration<DataTypeEnum, int> ResultDataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultDataType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (ResultDataType));
      }
    }

    public ComputationParamSpecChanges[] ComputationParamSpecs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParamSpecs), (object) value);
      }
      get
      {
        return (ComputationParamSpecChanges[]) this.PropertyGet(nameof (ComputationParamSpecs));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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

    public Primitive<bool> MapToContainerAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToContainerAttribute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (MapToContainerAttribute));
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

    public Primitive<string> ResultName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResultName));
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
