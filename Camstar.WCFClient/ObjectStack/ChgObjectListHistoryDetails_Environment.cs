// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectListHistoryDetails_Environment
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
  public class ChgObjectListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("DisplayName", "", false, false, true, "String", 1049724, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_NewDisplayValue")]
    protected new Environment _NewDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_NewObjects")]
    [Metadata("NewObject is ChgAttributeHistoryObject with overriden table name", "NewObject", false, false, true, "NewObject", 1049754, false, true, false, null)]
    protected NewObject_Environment _NewObjects;
    [Metadata("OldObjects is ChgAttributeHistoryObject with overriden table name", "OldObject", false, false, true, "OldObject", 1049755, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_OldObjects")]
    protected OldObject_Environment _OldObjects;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("DisplayName", "", false, false, true, "String", 1049725, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_OldDisplayValue")]
    protected new Environment _OldDisplayValue;
    [Metadata("Field Expression.", "", false, false, true, "String", 1049129, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_FieldName")]
    protected new Environment _FieldName;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049723, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_FieldID")]
    protected new Environment _FieldID;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

    public new Environment NewDisplayValue
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

    public NewObject_Environment NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (NewObject_Environment) this.PropertyGet(nameof (NewObjects));
      }
    }

    public OldObject_Environment OldObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldObjects), (object) value);
      }
      get
      {
        return (OldObject_Environment) this.PropertyGet(nameof (OldObjects));
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

    public new Environment OldDisplayValue
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

    public new Environment FieldName
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

    public new Environment FieldID
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
  }
}
