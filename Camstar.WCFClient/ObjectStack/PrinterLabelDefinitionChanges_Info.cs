// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrinterLabelDefinitionChanges_Info
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
  public class PrinterLabelDefinitionChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_LabelTags")]
    protected LabelTagChanges_Info _LabelTags;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_BeginDelimiter")]
    protected Info _BeginDelimiter;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_EndDelimiter")]
    protected Info _EndDelimiter;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Info_LabelTemplate")]
    protected Info _LabelTemplate;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public LabelTagChanges_Info LabelTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTags), (object) value);
      }
      get
      {
        return (LabelTagChanges_Info) this.PropertyGet(nameof (LabelTags));
      }
    }

    public Info BeginDelimiter
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginDelimiter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BeginDelimiter));
      }
    }

    public Info EndDelimiter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDelimiter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDelimiter));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info LabelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelTemplate));
      }
    }
  }
}
