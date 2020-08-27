// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelsTxn_Environment
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
  public class PrintLabelsTxn_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Environment_Services")]
    [Metadata("Standalone services provided to print Container and NCR labels.", "PrintLabelTxn", false, false, false, "PrintLabelTxn", 1052702, false, true, false, null)]
    protected PrintLabelTxn_Environment _Services;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected new Environment _PrintQueue;
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, false, "RevisionedObjectRef", 1050616, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Environment_PrinterLabelDefinition")]
    protected Environment _PrinterLabelDefinition;
    [Metadata("Details to print", "PrintLabelDetails", false, false, false, "PrintLabelDetails", 1049843, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Environment_ServiceDetails")]
    protected PrintLabelDetails_Environment _ServiceDetails;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050617, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Environment_LabelCount")]
    protected Environment _LabelCount;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Environment_Factory")]
    protected new Environment _Factory;

    public PrintLabelTxn_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (PrintLabelTxn_Environment) this.PropertyGet(nameof (Services));
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

    public PrintLabelDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PrintLabelDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
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
