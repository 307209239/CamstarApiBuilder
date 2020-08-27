// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklistToEvent_Environment
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
  public class AssignChecklistToEvent_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_Environment_QualityObject")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;
    [Metadata("Assign Checklist transaction is used to assign checklist to Trackable Object.", "AssignChecklist", false, false, false, "AssignChecklist", 1053003, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_Environment_AssignChecklist")]
    protected AssignChecklist_Environment _AssignChecklist;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052971, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public AssignChecklist_Environment AssignChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignChecklist), (object) value);
      }
      get
      {
        return (AssignChecklist_Environment) this.PropertyGet(nameof (AssignChecklist));
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
  }
}
