// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationHistory
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
  public class ComputationHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_ComputationExpression")]
    protected Primitive<string> _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_ResultDataType")]
    protected Enumeration<DataTypeEnum, int> _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_HistoryDetails")]
    protected ComputationParamHistory[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_ResultValue")]
    protected Primitive<string> _ResultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Computation")]
    protected NamedObjectRef _Computation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_AttributeName")]
    protected Primitive<string> _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_MapToContainerAttribute")]
    protected Primitive<bool> _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_IsLimitOverrideAllowed")]
    protected Primitive<bool> _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_IsLimitOverride")]
    protected Primitive<bool> _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_IsLimitViolation")]
    protected Primitive<bool> _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_ComputationName")]
    protected Primitive<string> _ComputationName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_ResultName")]
    protected Primitive<string> _ResultName;

    public override bool Equals(object obj)
    {
      return obj is ComputationHistory && object.Equals((object) this._ComputationExpression, (object) ((ComputationHistory) obj)._ComputationExpression) && (object.Equals((object) this._ResultDataType, (object) ((ComputationHistory) obj)._ResultDataType) && object.Equals((object) this._ExportImportKey, (object) ((ComputationHistory) obj)._ExportImportKey)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ComputationHistory) obj)._HistoryDetails) && object.Equals((object) this._ResultValue, (object) ((ComputationHistory) obj)._ResultValue) && (object.Equals((object) this._Computation, (object) ((ComputationHistory) obj)._Computation) && object.Equals((object) this._AttributeName, (object) ((ComputationHistory) obj)._AttributeName))) && (object.Equals((object) this._HistoryId, (object) ((ComputationHistory) obj)._HistoryId) && object.Equals((object) this._MapToContainerAttribute, (object) ((ComputationHistory) obj)._MapToContainerAttribute) && (object.Equals((object) this._IsLimitOverrideAllowed, (object) ((ComputationHistory) obj)._IsLimitOverrideAllowed) && object.Equals((object) this._UpperLimit, (object) ((ComputationHistory) obj)._UpperLimit)) && (object.Equals((object) this._LowerLimit, (object) ((ComputationHistory) obj)._LowerLimit) && object.Equals((object) this._IsLimitOverride, (object) ((ComputationHistory) obj)._IsLimitOverride) && (object.Equals((object) this._IsLimitViolation, (object) ((ComputationHistory) obj)._IsLimitViolation) && object.Equals((object) this._ComputationName, (object) ((ComputationHistory) obj)._ComputationName)))) && object.Equals((object) this._ResultName, (object) ((ComputationHistory) obj)._ResultName) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ComputationParamHistory[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ComputationParamHistory[]) this.PropertyGet(nameof (HistoryDetails));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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
  }
}
