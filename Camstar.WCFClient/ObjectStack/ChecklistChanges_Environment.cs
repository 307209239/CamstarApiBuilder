// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistChanges_Environment
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
  public class ChecklistChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1052397, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistChanges_Environment_ChecklistInstructions")]
    protected Environment _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistChanges_Environment_ChecklistEntries")]
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntryChanges", false, false, false, "ChecklistEntryChanges", 1052412, false, true, false, null)]
    protected ChecklistEntryChanges_Environment _ChecklistEntries;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    protected new Environment _Name;

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

    public ChecklistEntryChanges_Environment ChecklistEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntries), (object) value);
      }
      get
      {
        return (ChecklistEntryChanges_Environment) this.PropertyGet(nameof (ChecklistEntries));
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
  }
}
