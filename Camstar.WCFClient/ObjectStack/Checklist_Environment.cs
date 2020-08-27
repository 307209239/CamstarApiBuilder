// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Checklist_Environment
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
  public class Checklist_Environment : NamedSubentity_Environment
  {
    [Metadata("Comments", "", false, false, true, "String", 1052397, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Checklist_Environment_ChecklistInstructions")]
    protected Environment _ChecklistInstructions;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Checklist_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntry", false, false, true, "ChecklistEntry", 1052412, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Checklist_Environment_ChecklistEntries")]
    protected ChecklistEntry_Environment _ChecklistEntries;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Checklist_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Checklist_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

    public Environment ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistInstructions));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ChecklistEntry_Environment ChecklistEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntries), (object) value);
      }
      get
      {
        return (ChecklistEntry_Environment) this.PropertyGet(nameof (ChecklistEntries));
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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
