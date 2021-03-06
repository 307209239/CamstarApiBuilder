﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistHistory_Environment
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
  public class ExecuteChecklistHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Environment_ChecklistInstructions")]
    [Metadata("Comments", "", false, false, true, "String", 1052397, false, false, false, null)]
    protected Environment _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Environment_HistoryDetails")]
    [Metadata("ChecklistEntries, entered by the user, that are recorded.", "ExecuteChecklistHistoryDtl", false, false, true, "ExecuteChecklistHistoryDtl", 1049096, false, true, false, null)]
    protected ExecuteChecklistHistoryDtl_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Environment_Checklist")]
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "Checklist", false, false, true, "NamedSubentityRef", 1052398, false, false, false, null)]
    protected Environment _Checklist;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051062, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Environment_Submit")]
    protected Environment _Submit;

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

    public ExecuteChecklistHistoryDtl_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ExecuteChecklistHistoryDtl_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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
