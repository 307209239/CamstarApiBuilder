// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelHistoryDetail_Environment
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
  public class LabelHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, false, null)]
    protected Environment _PrintQueue;
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1050621, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_TagValue")]
    protected Environment _TagValue;
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, true, "RevisionedObjectRef", 1050616, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_PrinterLabelDefinition")]
    protected Environment _PrinterLabelDefinition;
    [Metadata("Generic String", "", false, false, true, "String", 1050620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_TagName")]
    protected Environment _TagName;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050617, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_LabelCount")]
    protected Environment _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "LabelHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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

    public Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment TagValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TagValue));
      }
    }

    public Environment PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public Environment TagName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TagName));
      }
    }

    public Environment LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelCount));
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
