// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklist_Environment
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
  public class AssignChecklist_Environment : GenericTxn_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1052397, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Environment_ChecklistInstructions")]
    protected Environment _ChecklistInstructions;
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "Checklist", false, false, false, "NamedSubentityRef", 1052398, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Environment_Checklist")]
    protected Environment _Checklist;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052971, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Environment_ServiceDetails")]
    [Metadata("Used to maintain the entries in an checklist for a tracking object", "ChecklistEntryDetails", false, false, false, "ChecklistEntryDetails", 1053002, false, true, false, null)]
    protected ChecklistEntryDetails_Environment _ServiceDetails;

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

    public Environment Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Checklist));
      }
    }

    public Environment ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public ChecklistEntryDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChecklistEntryDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
