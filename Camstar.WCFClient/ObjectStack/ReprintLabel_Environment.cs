// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintLabel_Environment
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
  public class ReprintLabel_Environment : PrintLabelTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_LabelHistorySummary")]
    [Metadata("History Summary information for every label printed.  One History Summary record will be created for every printed label.", "LabelHistorySummary", false, true, false, "SubentityRef", 1050626, false, false, true, null)]
    protected Environment _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_SelectedHistoryMainline")]
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, false, "BaseObjectRef", 1050628, false, false, false, null)]
    protected Environment _SelectedHistoryMainline;
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, true, "RevisionedObjectRef", 1050616, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_PrinterLabelDefinition")]
    protected new Environment _PrinterLabelDefinition;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050617, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_LabelCount")]
    protected new Environment _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Environment_Factory")]
    protected new Environment _Factory;

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

    public Environment LabelHistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelHistorySummary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelHistorySummary));
      }
    }

    public Environment SelectedHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainline), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistoryMainline));
      }
    }

    public new Environment PrinterLabelDefinition
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

    public new Environment LabelCount
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
