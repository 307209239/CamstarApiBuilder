// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateEventHistory_Environment
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
  public class CreateEventHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Associated history object to record the values from the EventDetail service detail", "EventHistoryDetail", false, false, false, "EventHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_HistoryDetails")]
    protected EventHistoryDetail_Environment _HistoryDetails;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, true, "NamedObjectRef", 1051300, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_SubClassification")]
    protected Environment _SubClassification;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_Organization")]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_Classification")]
    [Metadata("Used to classify QualityObjects", "Classification", false, false, true, "NamedObjectRef", 1051055, false, false, false, null)]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Environment_Submit")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051062, false, false, false, "0")]
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

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
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
