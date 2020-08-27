// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateSamplingLotHistory_Info
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
  public class CreateSamplingLotHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_SampleRate")]
    protected Info _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_AllowAdjustToLotSize")]
    protected Info _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_LotName")]
    protected Info _LotName;
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLotHistory_Info_Product")]
    protected Info _Product;

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
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

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
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

    public Info SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Info AllowAdjustToLotSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAdjustToLotSize), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowAdjustToLotSize));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info LotName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotName));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
