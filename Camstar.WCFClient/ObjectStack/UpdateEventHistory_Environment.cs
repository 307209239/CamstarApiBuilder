// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventHistory_Environment
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
  public class UpdateEventHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Associated history object to record the values from the EventDetail service detail", "EventHistoryDetail", false, false, false, "EventHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Environment_HistoryDetails")]
    protected EventHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Environment_QualityCrossRefHistories")]
    [Metadata("QualityCrossRefHistory", "QualityCrossRefHistory", false, false, true, "QualityCrossRefHistory", 1051490, false, true, false, null)]
    protected QualityCrossRefHistory_Environment _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Environment_Submit")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    protected Environment _Submit;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;

    public EventHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (EventHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public QualityCrossRefHistory_Environment QualityCrossRefHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefHistories), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory_Environment) this.PropertyGet(nameof (QualityCrossRefHistories));
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
