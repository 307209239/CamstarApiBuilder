// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklist_Info
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
  public class AssignChecklist_Info : GenericTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Info_ChecklistInstructions")]
    protected Info _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Info_Checklist")]
    protected Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Info_ServiceDetails")]
    protected ChecklistEntryDetails_Info _ServiceDetails;

    public Info ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistInstructions));
      }
    }

    public Info Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Checklist));
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

    public ChecklistEntryDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChecklistEntryDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
