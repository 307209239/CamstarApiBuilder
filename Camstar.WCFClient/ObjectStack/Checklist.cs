// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Checklist
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
  public class Checklist : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "Checklist_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "Checklist_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Checklist_ChecklistEntries")]
    protected ChecklistEntry[] _ChecklistEntries;
    [DataMember(EmitDefaultValue = false, Name = "Checklist_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Checklist_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is Checklist && object.Equals((object) this._ChecklistInstructions, (object) ((Checklist) obj)._ChecklistInstructions) && (object.Equals((object) this._ExportImportKey, (object) ((Checklist) obj)._ExportImportKey) && this.CompareArrays((Array) this._ChecklistEntries, (Array) ((Checklist) obj)._ChecklistEntries)) && (object.Equals((object) this._Name, (object) ((Checklist) obj)._Name) && object.Equals((object) this._IsFrozen, (object) ((Checklist) obj)._IsFrozen)) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ChecklistEntry[] ChecklistEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntries), (object) value);
      }
      get
      {
        return (ChecklistEntry[]) this.PropertyGet(nameof (ChecklistEntries));
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

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
