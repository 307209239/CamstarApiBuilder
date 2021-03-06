﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklistToEventHistory_Environment
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
  public class AssignChecklistToEventHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Environment_Event")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, true, "NamedObjectRef", 1051042, false, false, false, null)]
    protected Environment _Event;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, true, "RevisionedObjectRef", 1052971, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklistToEventHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public Environment Event
    {
      [param: In] set
      {
        this.PropertySet(nameof (Event), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Event));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
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
  }
}
