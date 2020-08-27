// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrinterLabelDefinitionChanges
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
  public class PrinterLabelDefinitionChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_LabelTags")]
    protected LabelTagChanges[] _LabelTags;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_BeginDelimiter")]
    protected Primitive<string> _BeginDelimiter;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_EndDelimiter")]
    protected Primitive<string> _EndDelimiter;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinitionChanges_LabelTemplate")]
    protected Primitive<string> _LabelTemplate;

    public override bool Equals(object obj)
    {
      return obj is PrinterLabelDefinitionChanges && object.Equals((object) this._ObjectToChange, (object) ((PrinterLabelDefinitionChanges) obj)._ObjectToChange) && (object.Equals((object) this._Base, (object) ((PrinterLabelDefinitionChanges) obj)._Base) && this.CompareArrays((Array) this._LabelTags, (Array) ((PrinterLabelDefinitionChanges) obj)._LabelTags)) && (object.Equals((object) this._BeginDelimiter, (object) ((PrinterLabelDefinitionChanges) obj)._BeginDelimiter) && object.Equals((object) this._EndDelimiter, (object) ((PrinterLabelDefinitionChanges) obj)._EndDelimiter) && (object.Equals((object) this._Name, (object) ((PrinterLabelDefinitionChanges) obj)._Name) && object.Equals((object) this._LabelTemplate, (object) ((PrinterLabelDefinitionChanges) obj)._LabelTemplate))) && base.Equals(obj);
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public LabelTagChanges[] LabelTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTags), (object) value);
      }
      get
      {
        return (LabelTagChanges[]) this.PropertyGet(nameof (LabelTags));
      }
    }

    public Primitive<string> BeginDelimiter
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginDelimiter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BeginDelimiter));
      }
    }

    public Primitive<string> EndDelimiter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDelimiter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EndDelimiter));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> LabelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTemplate), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelTemplate));
      }
    }
  }
}
