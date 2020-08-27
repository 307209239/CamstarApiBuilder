// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelSummary_Environment
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
  public class LabelSummary_Environment : ServiceDetails_Environment
  {
    [Metadata("When a label tag and label value are evaluated (unified expression or a constant) the resolved matching value is placed here for use later.", "LabelDetails", false, false, false, "LabelDetails", 1050623, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_Environment_LabelDetails")]
    protected LabelDetails_Environment _LabelDetails;
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, false, "RevisionedObjectRef", 1050616, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_Environment_PrinterLabelDefinition")]
    protected Environment _PrinterLabelDefinition;
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_Environment_PrintQueue")]
    protected Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_Environment_LabelCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050617, false, false, false, null)]
    protected Environment _LabelCount;

    public LabelDetails_Environment LabelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelDetails), (object) value);
      }
      get
      {
        return (LabelDetails_Environment) this.PropertyGet(nameof (LabelDetails));
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
  }
}
