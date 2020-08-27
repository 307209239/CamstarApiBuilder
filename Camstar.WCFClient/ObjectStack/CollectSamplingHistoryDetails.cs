// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingHistoryDetails
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
  public class CollectSamplingHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_CollectSamplingTestDtlHistory")]
    protected SubentityRef[] _CollectSamplingTestDtlHistory;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Rejects")]
    protected Primitive<int> _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_Rejected")]
    protected Primitive<bool> _Rejected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingHistoryDetails_SampleTestName")]
    protected Primitive<string> _SampleTestName;

    public override bool Equals(object obj)
    {
      return obj is CollectSamplingHistoryDetails && object.Equals((object) this._ExportImportKey, (object) ((CollectSamplingHistoryDetails) obj)._ExportImportKey) && (this.CompareArrays((Array) this._CollectSamplingTestDtlHistory, (Array) ((CollectSamplingHistoryDetails) obj)._CollectSamplingTestDtlHistory) && object.Equals((object) this._SampleTest, (object) ((CollectSamplingHistoryDetails) obj)._SampleTest)) && (object.Equals((object) this._Rejects, (object) ((CollectSamplingHistoryDetails) obj)._Rejects) && object.Equals((object) this._HistoryId, (object) ((CollectSamplingHistoryDetails) obj)._HistoryId) && (object.Equals((object) this._Rejected, (object) ((CollectSamplingHistoryDetails) obj)._Rejected) && object.Equals((object) this._SampleTestName, (object) ((CollectSamplingHistoryDetails) obj)._SampleTestName))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public SubentityRef[] CollectSamplingTestDtlHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingTestDtlHistory), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (CollectSamplingTestDtlHistory));
      }
    }

    public RevisionedObjectRef SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Primitive<int> Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Rejects));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<bool> Rejected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejected), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Rejected));
      }
    }

    public Primitive<string> SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
