// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ParametricDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DataPointHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointHistoryDetail_Environment))]
  [Serializable]
  public class ParametricDetail_Environment : HistoryDetails_Environment
  {
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, true, "RevisionedObjectRef", 1048868, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Environment_DataCollectionDef")]
    protected Environment _DataCollectionDef;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050869, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Environment_HasUserDataCollection")]
    protected Environment _HasUserDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

    public Environment DataCollectionDef
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

    public Environment HasUserDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasUserDataCollection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasUserDataCollection));
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
