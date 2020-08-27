// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationDetail_Environment
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
  public class ComputationDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("ComputationExpression", "", false, false, true, "String", 1051007, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_ComputationExpression")]
    protected Environment _ComputationExpression;
    [Metadata("ComputationValue", "", false, false, true, "String", 1051027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_ResultValue")]
    protected Environment _ResultValue;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_ResultDataType")]
    protected Environment _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_Computation")]
    [Metadata("Computation CDO allows to define computational expressions.", "Computation", false, false, false, "NamedObjectRef", 1051017, false, false, false, null)]
    protected Environment _Computation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_ComputationParamDetails")]
    [Metadata("Params Details of the Computation", "ComputationParamDetail", false, false, false, "ComputationParamDetail", 1051023, false, true, false, null)]
    protected ComputationParamDetail_Environment _ComputationParamDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_RangeColor")]
    [Metadata("Enumeration for the Data Point Collection Range Color:\r\n-2 = BelowOuter\r\n-1 = BelowInner\r\n0  = WithinInner\r\n1  = AboveInner\r\n2  = AboveOuter", "DPCollectionRangeColorEnum", false, false, false, "Integer", 1053044, false, false, false, null)]
    protected Environment _RangeColor;
    [Metadata("A unique name for an attribute of a object.", "", false, false, false, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_AttributeName")]
    protected Environment _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_MapToContainerAttribute")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052103, false, false, false, "0")]
    protected Environment _MapToContainerAttribute;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050535, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_DisplayLimits")]
    protected Environment _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_IsLimitOverrideAllowed")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050544, false, false, false, "0")]
    protected Environment _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_UpperLimit")]
    [Metadata("Generic String", "", false, false, false, "String", 1050532, false, false, false, null)]
    protected Environment _UpperLimit;
    [Metadata("Generic String", "", false, false, false, "String", 1050533, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_LowerLimit")]
    protected Environment _LowerLimit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053039, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_IsLimitOverride")]
    protected Environment _IsLimitOverride;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050540, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_IsLimitViolation")]
    protected Environment _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_OverrideLimits")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053040, false, false, false, "0")]
    protected Environment _OverrideLimits;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051008, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_ResultName")]
    protected Environment _ResultName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051017, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Environment_ComputationName")]
    protected Environment _ComputationName;

    public Environment ComputationExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ComputationExpression));
      }
    }

    public Environment ResultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultValue));
      }
    }

    public Environment ResultDataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultDataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultDataType));
      }
    }

    public Environment Computation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Computation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Computation));
      }
    }

    public ComputationParamDetail_Environment ComputationParamDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParamDetails), (object) value);
      }
      get
      {
        return (ComputationParamDetail_Environment) this.PropertyGet(nameof (ComputationParamDetails));
      }
    }

    public Environment RangeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (RangeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RangeColor));
      }
    }

    public Environment AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeName));
      }
    }

    public Environment MapToContainerAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToContainerAttribute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MapToContainerAttribute));
      }
    }

    public Environment DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Environment IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }

    public Environment UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Environment LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Environment IsLimitOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverride), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitOverride));
      }
    }

    public Environment IsLimitViolation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitViolation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLimitViolation));
      }
    }

    public Environment OverrideLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideLimits), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OverrideLimits));
      }
    }

    public Environment ResultName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultName));
      }
    }

    public Environment ComputationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ComputationName));
      }
    }
  }
}
