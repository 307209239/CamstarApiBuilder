// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingHistoryDetails_Environment
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
  public class CollectSamplingHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Collect Sampling Test Dtl History", "CollectSamplingTestDtlHistory", false, false, true, "SubentityRef", 1053179, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_CollectSamplingTestDtlHistory")]
    protected Environment _CollectSamplingTestDtlHistory;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_SampleTest")]
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, false, "RevisionedObjectRef", 1053111, false, false, false, null)]
    protected Environment _SampleTest;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053180, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_Rejects")]
    protected Environment _Rejects;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051368, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_Rejected")]
    protected Environment _Rejected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Environment_SampleTestName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053132, false, false, false, null)]
    protected Environment _SampleTestName;

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

    public Environment CollectSamplingTestDtlHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingTestDtlHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollectSamplingTestDtlHistory));
      }
    }

    public Environment SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Environment Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejects));
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

    public Environment Rejected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejected));
      }
    }

    public Environment SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
