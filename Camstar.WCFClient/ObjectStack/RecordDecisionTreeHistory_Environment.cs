// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordDecisionTreeHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CreateRegulatoryReportHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RecordDecisionTreeHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Comments", "", false, false, true, "String", 1051730, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Environment_Result")]
    protected Environment _Result;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Environment_DecisionTree")]
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, true, "NamedObjectRef", 1051719, false, false, false, null)]
    protected Environment _DecisionTree;
    [Metadata("Decision Tree History Detail", "DecisionTreeHistoryDetail", false, false, true, "DecisionTreeHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Environment_HistoryDetails")]
    protected DecisionTreeHistoryDetail_Environment _HistoryDetails;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;

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

    public Environment Result
    {
      [param: In] set
      {
        this.PropertySet(nameof (Result), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Result));
      }
    }

    public Environment DecisionTree
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTree), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionTree));
      }
    }

    public DecisionTreeHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DecisionTreeHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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
