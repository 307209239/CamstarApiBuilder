// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingHistoryDetails_Info
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
  public class CollectSamplingHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_CollectSamplingTestDtlHistory")]
    protected Info _CollectSamplingTestDtlHistory;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_SampleTest")]
    protected Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_Rejects")]
    protected Info _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_Rejected")]
    protected Info _Rejected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Info_SampleTestName")]
    protected Info _SampleTestName;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info CollectSamplingTestDtlHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingTestDtlHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollectSamplingTestDtlHistory));
      }
    }

    public Info SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Info Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejects));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info Rejected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejected));
      }
    }

    public Info SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
