// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabel_Environment
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
  public class PrintPELabel_Environment : PrintLabelTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_HistoryId")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1052906, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_ProductionEvent")]
    protected Environment _ProductionEvent;
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_PrintQueue")]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_PrinterLabelDefinition")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, false, "RevisionedObjectRef", 1050616, false, false, true, null)]
    protected new Environment _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050617, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_LabelCount")]
    protected new Environment _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_PETxn")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1052912, false, false, true, null)]
    protected Environment _PETxn;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Environment_Factory")]
    protected new Environment _Factory;

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

    public Environment ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductionEvent));
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

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
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

    public Environment PETxn
    {
      [param: In] set
      {
        this.PropertySet(nameof (PETxn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PETxn));
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
