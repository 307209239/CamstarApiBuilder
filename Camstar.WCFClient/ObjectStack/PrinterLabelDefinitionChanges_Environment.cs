// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrinterLabelDefinitionChanges_Environment
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
  public class PrinterLabelDefinitionChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_ObjectToChange")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinitionBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("Values that will be substituted into a label template (label printer flat file) at runtime.", "LabelTagChanges", false, false, false, "LabelTagChanges", 1050614, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_LabelTags")]
    protected LabelTagChanges_Environment _LabelTags;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_BeginDelimiter")]
    [Metadata("Generic String", "", false, false, false, "String", 1050612, false, false, false, null)]
    protected Environment _BeginDelimiter;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_EndDelimiter")]
    [Metadata("Generic String", "", false, false, false, "String", 1050613, false, false, false, null)]
    protected Environment _EndDelimiter;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050610, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("External identifier for a document (Path and file name, URL, etc.)", "", false, true, false, "String", 1050611, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Environment_LabelTemplate")]
    protected Environment _LabelTemplate;

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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public LabelTagChanges_Environment LabelTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTags), (object) value);
      }
      get
      {
        return (LabelTagChanges_Environment) this.PropertyGet(nameof (LabelTags));
      }
    }

    public Environment BeginDelimiter
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginDelimiter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BeginDelimiter));
      }
    }

    public Environment EndDelimiter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDelimiter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDelimiter));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment LabelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelTemplate));
      }
    }
  }
}
