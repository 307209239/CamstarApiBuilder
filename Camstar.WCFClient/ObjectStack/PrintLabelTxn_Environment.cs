// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelTxn_Environment
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
  public class PrintLabelTxn_Environment : ShopFloor_Environment
  {
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, true, "RevisionedObjectRef", 1050616, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Environment_PrinterLabelDefinition")]
    protected Environment _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Environment_LabelSummaries")]
    [Metadata("When printing labels, the information needed to print as well as the values (details) are resolved and kept here for use later.", "LabelSummary", false, false, true, "LabelSummary", 1050622, false, true, false, null)]
    protected new LabelSummary_Environment _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049097, false, false, false, null)]
    protected Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Environment_LabelCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050617, false, false, false, null)]
    protected Environment _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected new Environment _Factory;

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

    public new LabelSummary_Environment LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (LabelSummary_Environment) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public new Environment PrintQueue
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

    public Environment HistoryId
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

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
