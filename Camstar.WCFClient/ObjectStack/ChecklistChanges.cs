// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistChanges
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
  public class ChecklistChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistChanges_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistChanges_ChecklistEntries")]
    protected ChecklistEntryChanges[] _ChecklistEntries;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChecklistChanges && object.Equals((object) this._ChecklistInstructions, (object) ((ChecklistChanges) obj)._ChecklistInstructions) && (this.CompareArrays((Array) this._ChecklistEntries, (Array) ((ChecklistChanges) obj)._ChecklistEntries) && object.Equals((object) this._Name, (object) ((ChecklistChanges) obj)._Name)) && base.Equals(obj);
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
