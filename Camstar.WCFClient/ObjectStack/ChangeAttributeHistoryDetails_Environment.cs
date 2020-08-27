// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeHistoryDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgTimeStampHistoryDetails_Environment))]
  [KnownType(typeof (ChgFloatHistoryDetails_Environment))]
  [KnownType(typeof (ChgBooleanListHistoryDetails_Environment))]
  [KnownType(typeof (ChgDurationHistoryDetails_Environment))]
  [KnownType(typeof (ChgTimeStampListHistoryDetails_Environment))]
  [KnownType(typeof (ChgIntegerListHistoryDetails_Environment))]
  [KnownType(typeof (ChgFixedListHistoryDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgObjectHistoryDetails_Environment))]
  [KnownType(typeof (ChgBooleanHistoryDetails_Environment))]
  [KnownType(typeof (ChgFloatListHistoryDetails_Environment))]
  [KnownType(typeof (ChgIntegerHistoryDetails_Environment))]
  [KnownType(typeof (ChgDurationListHistoryDetails_Environment))]
  [KnownType(typeof (ChgStringHistoryDetails_Environment))]
  [KnownType(typeof (ChgObjectListHistoryDetails_Environment))]
  [KnownType(typeof (ChgStringListHistoryDetails_Environment))]
  [KnownType(typeof (ChgFixedHistoryDetails_Environment))]
  [Serializable]
  public class ChangeAttributeHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Field Expression.", "", false, false, true, "String", 1049129, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Environment_FieldName")]
    protected Environment _FieldName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Environment_OldDisplayValue")]
    [Metadata("DisplayName", "", false, false, true, "String", 1049725, false, false, false, null)]
    protected Environment _OldDisplayValue;
    [Metadata("DisplayName", "", false, false, true, "String", 1049724, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Environment_NewDisplayValue")]
    protected Environment _NewDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_Environment_FieldID")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049723, false, false, false, null)]
    protected Environment _FieldID;

    public Environment FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldName));
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

    public Environment OldDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDisplayValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldDisplayValue));
      }
    }

    public Environment NewDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDisplayValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewDisplayValue));
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

    public Environment FieldID
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldID));
      }
    }
  }
}
