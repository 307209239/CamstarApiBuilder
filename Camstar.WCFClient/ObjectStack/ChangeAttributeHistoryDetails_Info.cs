// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeHistoryDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgObjectHistoryDetails_Info))]
  [KnownType(typeof (ChgFixedHistoryDetails_Info))]
  [KnownType(typeof (ChgBooleanListHistoryDetails_Info))]
  [KnownType(typeof (ChgIntegerListHistoryDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgDurationHistoryDetails_Info))]
  [KnownType(typeof (ChgStringListHistoryDetails_Info))]
  [KnownType(typeof (ChgFloatHistoryDetails_Info))]
  [KnownType(typeof (ChgFloatListHistoryDetails_Info))]
  [KnownType(typeof (ChgObjectListHistoryDetails_Info))]
  [KnownType(typeof (ChgFixedListHistoryDetails_Info))]
  [KnownType(typeof (ChgBooleanHistoryDetails_Info))]
  [KnownType(typeof (ChgStringHistoryDetails_Info))]
  [KnownType(typeof (ChgIntegerHistoryDetails_Info))]
  [KnownType(typeof (ChgTimeStampListHistoryDetails_Info))]
  [KnownType(typeof (ChgDurationListHistoryDetails_Info))]
  [KnownType(typeof (ChgTimeStampHistoryDetails_Info))]
  [Serializable]
  public class ChangeAttributeHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Info_FieldName")]
    protected Info _FieldName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Info_OldDisplayValue")]
    protected Info _OldDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Info_NewDisplayValue")]
    protected Info _NewDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Info_FieldID")]
    protected Info _FieldID;

    public Info FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldName));
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

    public Info OldDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDisplayValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldDisplayValue));
      }
    }

    public Info NewDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDisplayValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewDisplayValue));
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

    public Info FieldID
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldID));
      }
    }
  }
}
