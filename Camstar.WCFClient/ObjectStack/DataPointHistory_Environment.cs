// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointHistory_Environment
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
  public class DataPointHistory_Environment : ParametricDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistory_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    protected new Environment _DataCollectionDef;
    [Metadata("The history of the DataPoints collected for a DataPointCollectionDef.", "DataPointHistoryDetail", false, false, true, "DataPointHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistory_Environment_HistoryDetails")]
    protected DataPointHistoryDetail_Environment _HistoryDetails;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointHistory_Environment_HistoryId")]
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

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public DataPointHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DataPointHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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
