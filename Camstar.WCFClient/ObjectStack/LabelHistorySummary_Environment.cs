// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelHistorySummary_Environment
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
  public class LabelHistorySummary_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelHistorySummary_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, false, null)]
    protected Environment _PrintQueue;
    [Metadata("History Detail information for every label printed.  One History Detail record will be created for every printed label.", "LabelHistoryDetail", false, false, false, "LabelHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistorySummary_Environment_HistoryDetails")]
    protected LabelHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "LabelHistorySummary_Environment_PrinterLabelDefinition")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, true, "RevisionedObjectRef", 1050616, false, false, false, null)]
    protected Environment _PrinterLabelDefinition;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistorySummary_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050617, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistorySummary_Environment_LabelCount")]
    protected Environment _LabelCount;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelHistorySummary_Environment_HistoryId")]
    protected new Environment _HistoryId;

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

    public LabelHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (LabelHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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
