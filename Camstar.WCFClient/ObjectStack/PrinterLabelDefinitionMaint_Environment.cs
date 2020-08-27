// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrinterLabelDefinitionMaint_Environment
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
  public class PrinterLabelDefinitionMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinitionBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionMaint_Environment_ObjectListInquiry")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinitionBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionMaint_Environment_ObjectChanges")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinitionChanges", false, false, false, "PrinterLabelDefinitionChanges", 1048873, true, false, false, null)]
    protected PrinterLabelDefinitionChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionMaint_Environment_ObjectToChange")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public PrinterLabelDefinitionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PrinterLabelDefinitionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
