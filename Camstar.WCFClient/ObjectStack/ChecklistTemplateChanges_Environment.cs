// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistTemplateChanges_Environment
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
  public class ChecklistTemplateChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1052397, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Environment_ChecklistInstructions")]
    protected Environment _ChecklistInstructions;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplateBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Environment_ObjectToChange")]
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Environment_ChecklistEntries")]
    [Metadata("Defines the response entry within Checklist Configuration.", "ChecklistEntryChanges", false, true, false, "ChecklistEntryChanges", 1052385, false, true, false, null)]
    protected ChecklistEntryChanges_Environment _ChecklistEntries;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052375, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChecklistTemplateChanges_Environment_Name")]
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
