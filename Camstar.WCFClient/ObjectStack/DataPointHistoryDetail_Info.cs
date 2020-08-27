// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointHistoryDetail_Info
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
  public class DataPointHistoryDetail_Info : ParametricDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_DecimalValue")]
    protected Info _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_DataPoint")]
    protected Info _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_AttributeName")]
    protected Info _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_RDOValue")]
    protected Info _RDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_IntegerValue")]
    protected Info _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_TimestampValue")]
    protected Info _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_BooleanValue")]
    protected Info _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_MapToUserAttribute")]
    protected Info _MapToUserAttribute;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_IsRequired")]
    protected Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_DataValue")]
    protected Info _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_IsLimitOverrideAllowed")]
    protected Info _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_IsLimitOverride")]
    protected Info _IsLimitOverride;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_NDOValue")]
    protected Info _NDOValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_EnumerationValue")]
    protected Info _EnumerationValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_FloatValue")]
    protected Info _FloatValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_IsLimitViolation")]
    protected Info _IsLimitViolation;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_FixedValue")]
    protected Info _FixedValue;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_DataName")]
    protected Info _DataName;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistoryDetail_Info_Comments")]
    protected Info _Comments;

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Info DecimalValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecimalValue));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
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

    public Info DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPoint));
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

    public Info RDOValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (RDOValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RDOValue));
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

    public Info IntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IntegerValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IntegerValue));
      }
    }

    public Info TimestampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimestampValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimestampValue));
      }
    }

    public Info BooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BooleanValue));
      }
    }

    public Info MapToUserAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToUserAttribute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MapToUserAttribute));
      }
    }

    public Info IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Info DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataValue));
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

    public Info NDOValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NDOValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NDOValue));
      }
    }

    public Info EnumerationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnumerationValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnumerationValue));
      }
    }

    public Info FloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FloatValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FloatValue));
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

    public Info FixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FixedValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FixedValue));
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

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Info DataName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataName));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
