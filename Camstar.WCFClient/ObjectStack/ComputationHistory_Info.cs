// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationHistory_Info
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
  public class ComputationHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_ComputationExpression")]
    protected Info _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_ResultDataType")]
    protected Info _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_HistoryDetails")]
    protected ComputationParamHistory_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_ResultValue")]
    protected Info _ResultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_Computation")]
    protected Info _Computation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_AttributeName")]
    protected Info _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_MapToContainerAttribute")]
    protected Info _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_IsLimitOverrideAllowed")]
    protected Info _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_IsLimitOverride")]
    protected Info _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_IsLimitViolation")]
    protected Info _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_ComputationName")]
    protected Info _ComputationName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationHistory_Info_ResultName")]
    protected Info _ResultName;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ComputationParamHistory_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ComputationParamHistory_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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
  }
}
