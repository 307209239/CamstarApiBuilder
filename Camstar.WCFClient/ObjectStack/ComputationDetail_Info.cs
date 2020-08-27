// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationDetail_Info
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
  public class ComputationDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_ComputationExpression")]
    protected Info _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_ResultValue")]
    protected Info _ResultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_ResultDataType")]
    protected Info _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_Computation")]
    protected Info _Computation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_ComputationParamDetails")]
    protected ComputationParamDetail_Info _ComputationParamDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_RangeColor")]
    protected Info _RangeColor;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_AttributeName")]
    protected Info _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_MapToContainerAttribute")]
    protected Info _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_DisplayLimits")]
    protected Info _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_IsLimitOverrideAllowed")]
    protected Info _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_IsLimitOverride")]
    protected Info _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_IsLimitViolation")]
    protected Info _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_OverrideLimits")]
    protected Info _OverrideLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_ResultName")]
    protected Info _ResultName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationDetail_Info_ComputationName")]
    protected Info _ComputationName;

    public Info ComputationExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ComputationExpression));
      }
    }

    public Info ResultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultValue));
      }
    }

    public Info ResultDataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultDataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultDataType));
      }
    }

    public Info Computation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Computation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Computation));
      }
    }

    public ComputationParamDetail_Info ComputationParamDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParamDetails), (object) value);
      }
      get
      {
        return (ComputationParamDetail_Info) this.PropertyGet(nameof (ComputationParamDetails));
      }
    }

    public Info RangeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (RangeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RangeColor));
      }
    }

    public Info AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeName));
      }
    }

    public Info MapToContainerAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToContainerAttribute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MapToContainerAttribute));
      }
    }

    public Info DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Info IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }

    public Info UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Info LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Info IsLimitOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverride), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLimitOverride));
      }
    }

    public Info IsLimitViolation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitViolation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLimitViolation));
      }
    }

    public Info OverrideLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideLimits), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OverrideLimits));
      }
    }

    public Info ResultName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultName));
      }
    }

    public Info ComputationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ComputationName));
      }
    }
  }
}
