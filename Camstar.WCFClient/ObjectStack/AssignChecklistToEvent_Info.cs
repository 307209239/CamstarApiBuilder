// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklistToEvent_Info
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
  public class AssignChecklistToEvent_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_Info_AssignChecklist")]
    protected AssignChecklist_Info _AssignChecklist;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEvent_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public AssignChecklist_Info AssignChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignChecklist), (object) value);
      }
      get
      {
        return (AssignChecklist_Info) this.PropertyGet(nameof (AssignChecklist));
      }
    }

    public Info ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }
  }
}
