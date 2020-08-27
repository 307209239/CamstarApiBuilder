// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ParametricDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DataPointHistoryDetail_Info))]
  [KnownType(typeof (DataPointHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ParametricDetail_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Info_HasUserDataCollection")]
    protected Info _HasUserDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_Info_HistoryId")]
    protected new Info _HistoryId;

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

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

    public Info HasUserDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasUserDataCollection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasUserDataCollection));
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
  }
}
