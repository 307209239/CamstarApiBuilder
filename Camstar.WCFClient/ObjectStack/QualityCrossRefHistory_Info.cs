// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossRefHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ResolveCARRefHistory_Info))]
  [Serializable]
  public class QualityCrossRefHistory_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_TrackingId")]
    protected Info _TrackingId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_CrossReference")]
    protected Info _CrossReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_QualityResolutionCode")]
    protected Info _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_CloseReference")]
    protected Info _CloseReference;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_ExecuteAction")]
    protected Info _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Info_CloseDescription")]
    protected Info _CloseDescription;

    public Info TrackingId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackingId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackingId));
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

    public Info CrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CrossReference));
      }
    }

    public Info QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Info CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseReference));
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

    public Info ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Info CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
