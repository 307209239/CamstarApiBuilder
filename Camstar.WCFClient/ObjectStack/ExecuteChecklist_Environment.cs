// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklist_Environment
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
  public class ExecuteChecklist_Environment : GenericTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_Environment_ChecklistInstructions")]
    [Metadata("Comments", "", false, false, false, "String", 1052397, false, false, false, null)]
    protected Environment _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_Environment_Checklist")]
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "Checklist", false, false, false, "NamedSubentityRef", 1052398, false, false, false, null)]
    protected Environment _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_Environment_ServiceDetails")]
    [Metadata("ChecklistEntries, entered by the user, that are to be recorded.", "ExecuteChecklistDetail", false, false, false, "ExecuteChecklistDetail", 1049843, false, true, false, null)]
    protected ExecuteChecklistDetail_Environment _ServiceDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_Environment_Submit")]
    protected Environment _Submit;

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

    public ExecuteChecklistDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ExecuteChecklistDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
      }
    }
  }
}
