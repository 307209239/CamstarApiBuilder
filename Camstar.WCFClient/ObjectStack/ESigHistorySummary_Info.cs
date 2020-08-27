// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigHistorySummary_Info
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
  public class ESigHistorySummary_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_HistoryDetails")]
    protected ESigHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_CosignerRole")]
    protected Info _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_ESigReqDetail")]
    protected Info _ESigReqDetail;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_VerificationMethod")]
    protected Info _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_Meaning")]
    protected Info _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Info_SignatureCount")]
    protected Info _SignatureCount;

    public ESigHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ESigHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Info CosignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignerRole));
      }
    }

    public Info ESigReqDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigReqDetail));
      }
    }

    public Info VerificationMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (VerificationMethod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VerificationMethod));
      }
    }

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info Meaning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Meaning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Meaning));
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

    public Info SignatureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignatureCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignatureCount));
      }
    }
  }
}
