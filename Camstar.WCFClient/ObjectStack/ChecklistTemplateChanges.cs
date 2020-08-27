// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistTemplateChanges
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
  public class ChecklistTemplateChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_ChecklistEntries")]
    protected ChecklistEntryChanges[] _ChecklistEntries;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChecklistTemplateChanges && object.Equals((object) this._ChecklistInstructions, (object) ((ChecklistTemplateChanges) obj)._ChecklistInstructions) && (object.Equals((object) this._Base, (object) ((ChecklistTemplateChanges) obj)._Base) && object.Equals((object) this._ObjectToChange, (object) ((ChecklistTemplateChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._ChecklistEntries, (Array) ((ChecklistTemplateChanges) obj)._ChecklistEntries) && object.Equals((object) this._Name, (object) ((ChecklistTemplateChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChecklistInstructions));
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

    public ChecklistEntryChanges[] ChecklistEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntries), (object) value);
      }
      get
      {
        return (ChecklistEntryChanges[]) this.PropertyGet(nameof (ChecklistEntries));
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
  }
}
