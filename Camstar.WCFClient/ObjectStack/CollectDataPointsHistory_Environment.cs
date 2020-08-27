// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectDataPointsHistory_Environment
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
  public class CollectDataPointsHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollection", false, false, true, "NamedSubentityRef", 1052416, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_Environment_DataPointCollection")]
    protected Environment _DataPointCollection;
    [Metadata("The history contains collection data points with data point samples.", "DPCollectionGroupHistory", false, false, false, "DPCollectionGroupHistory", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_Environment_HistoryDetails")]
    protected DPCollectionGroupHistory_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectDataPointsHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
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

    public Environment DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public DPCollectionGroupHistory_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DPCollectionGroupHistory_Environment) this.PropertyGet(nameof (HistoryDetails));
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
