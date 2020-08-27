// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationHistory_Environment
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
  public class ComputationHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_ComputationExpression")]
    [Metadata("ComputationExpression", "", false, false, true, "String", 1051007, false, false, false, null)]
    protected Environment _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_ResultDataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    protected Environment _ResultDataType;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_HistoryDetails")]
    [Metadata("History params of the Computation", "ComputationParamHistory", false, false, false, "ComputationParamHistory", 1049096, false, true, false, null)]
    protected ComputationParamHistory_Environment _HistoryDetails;
    [Metadata("ComputationValue", "", false, false, true, "String", 1051022, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_ResultValue")]
    protected Environment _ResultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_Computation")]
    [Metadata("Computation CDO allows to define computational expressions.", "Computation", false, false, true, "NamedObjectRef", 1051017, false, false, false, null)]
    protected Environment _Computation;
    [Metadata("A unique name for an attribute of a object.", "", false, false, true, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_AttributeName")]
    protected Environment _AttributeName;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_MapToContainerAttribute")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052103, false, false, false, "0")]
    protected Environment _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_IsLimitOverrideAllowed")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050544, false, false, false, "0")]
    protected Environment _IsLimitOverrideAllowed;
    [Metadata("Generic String", "", false, false, false, "String", 1050532, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_UpperLimit")]
    protected Environment _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_LowerLimit")]
    [Metadata("Generic String", "", false, false, false, "String", 1050533, false, false, false, null)]
    protected Environment _LowerLimit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053039, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_IsLimitOverride")]
    protected Environment _IsLimitOverride;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050540, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_IsLimitViolation")]
    protected Environment _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_ComputationName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected Environment _ComputationName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051008, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Environment_ResultName")]
    protected Environment _ResultName;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ComputationParamHistory_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ComputationParamHistory_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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
  }
}
