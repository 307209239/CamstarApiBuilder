// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklistToEvent
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
  public class AssignChecklistToEvent : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_AssignChecklist")]
    protected AssignChecklist _AssignChecklist;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;

    public override bool Equals(object obj)
    {
      return obj is AssignChecklistToEvent && object.Equals((object) this._QualityObject, (object) ((AssignChecklistToEvent) obj)._QualityObject) && (object.Equals((object) this._AssignChecklist, (object) ((AssignChecklistToEvent) obj)._AssignChecklist) && object.Equals((object) this._ChecklistTemplate, (object) ((AssignChecklistToEvent) obj)._ChecklistTemplate)) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public AssignChecklist AssignChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignChecklist), (object) value);
      }
      get
      {
        return (AssignChecklist) this.PropertyGet(nameof (AssignChecklist));
      }
    }

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }
  }
}
