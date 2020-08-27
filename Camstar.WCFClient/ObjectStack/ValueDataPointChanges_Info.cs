// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ValueDataPointChanges_Info
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
  public class ValueDataPointChanges_Info : DataPointChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_DataType")]
    protected new Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_AttributeName")]
    protected Info _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_MapToUserAttribute")]
    protected Info _MapToUserAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_BooleanTrue")]
    protected Info _BooleanTrue;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_DisplayLimits")]
    protected Info _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_BooleanFalse")]
    protected Info _BooleanFalse;
    [DataMember(EmitDefaultValue = false, Name = "ValueDataPointChanges_Info_IsLimitOverrideAllowed")]
    protected Info _IsLimitOverrideAllowed;

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

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info DataType
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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info BooleanTrue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanTrue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BooleanTrue));
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

    public Info BooleanFalse
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanFalse), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BooleanFalse));
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
  }
}
