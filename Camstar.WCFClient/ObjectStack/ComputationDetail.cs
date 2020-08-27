// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationDetail
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
  public class ComputationDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_ComputationExpression")]
    protected Primitive<string> _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_ResultValue")]
    protected Primitive<string> _ResultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_ResultDataType")]
    protected Enumeration<DataTypeEnum, int> _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Computation")]
    protected NamedObjectRef _Computation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_ComputationParamDetails")]
    protected ComputationParamDetail[] _ComputationParamDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_RangeColor")]
    protected Enumeration<DPCollectionRangeColorEnum, int> _RangeColor;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_AttributeName")]
    protected Primitive<string> _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_MapToContainerAttribute")]
    protected Primitive<bool> _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_DisplayLimits")]
    protected Primitive<bool> _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_IsLimitOverrideAllowed")]
    protected Primitive<bool> _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_IsLimitOverride")]
    protected Primitive<bool> _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_IsLimitViolation")]
    protected Primitive<bool> _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_OverrideLimits")]
    protected Primitive<bool> _OverrideLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_ResultName")]
    protected Primitive<string> _ResultName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_ComputationName")]
    protected Primitive<string> _ComputationName;

    public override bool Equals(object obj)
    {
      return obj is ComputationDetail && object.Equals((object) this._ComputationExpression, (object) ((ComputationDetail) obj)._ComputationExpression) && (object.Equals((object) this._ResultValue, (object) ((ComputationDetail) obj)._ResultValue) && object.Equals((object) this._ResultDataType, (object) ((ComputationDetail) obj)._ResultDataType)) && (object.Equals((object) this._Computation, (object) ((ComputationDetail) obj)._Computation) && this.CompareArrays((Array) this._ComputationParamDetails, (Array) ((ComputationDetail) obj)._ComputationParamDetails) && (object.Equals((object) this._RangeColor, (object) ((ComputationDetail) obj)._RangeColor) && object.Equals((object) this._AttributeName, (object) ((ComputationDetail) obj)._AttributeName))) && (object.Equals((object) this._MapToContainerAttribute, (object) ((ComputationDetail) obj)._MapToContainerAttribute) && object.Equals((object) this._DisplayLimits, (object) ((ComputationDetail) obj)._DisplayLimits) && (object.Equals((object) this._IsLimitOverrideAllowed, (object) ((ComputationDetail) obj)._IsLimitOverrideAllowed) && object.Equals((object) this._UpperLimit, (object) ((ComputationDetail) obj)._UpperLimit)) && (object.Equals((object) this._LowerLimit, (object) ((ComputationDetail) obj)._LowerLimit) && object.Equals((object) this._IsLimitOverride, (object) ((ComputationDetail) obj)._IsLimitOverride) && (object.Equals((object) this._IsLimitViolation, (object) ((ComputationDetail) obj)._IsLimitViolation) && object.Equals((object) this._OverrideLimits, (object) ((ComputationDetail) obj)._OverrideLimits)))) && (object.Equals((object) this._ResultName, (object) ((ComputationDetail) obj)._ResultName) && object.Equals((object) this._ComputationName, (object) ((ComputationDetail) obj)._ComputationName)) && base.Equals(obj);
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

    public Primitive<string> ResultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResultValue));
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

    public NamedObjectRef Computation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Computation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Computation));
      }
    }

    public ComputationParamDetail[] ComputationParamDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParamDetails), (object) value);
      }
      get
      {
        return (ComputationParamDetail[]) this.PropertyGet(nameof (ComputationParamDetails));
      }
    }

    public Enumeration<DPCollectionRangeColorEnum, int> RangeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (RangeColor), (object) value);
      }
      get
      {
        return (Enumeration<DPCollectionRangeColorEnum, int>) this.PropertyGet(nameof (RangeColor));
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

    public Primitive<bool> IsLimitOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverride), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLimitOverride));
      }
    }

    public Primitive<bool> IsLimitViolation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitViolation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLimitViolation));
      }
    }

    public Primitive<bool> OverrideLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OverrideLimits));
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

    public Primitive<string> ComputationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ComputationName));
      }
    }
  }
}
