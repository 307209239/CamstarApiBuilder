// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerHistoryInquiryDetail_Info
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
  public class ContainerHistoryInquiryDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_Histories")]
    protected Info _Histories;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_SelectedHistoryItem")]
    protected Info _SelectedHistoryItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_InquiryDetail")]
    protected ContainerHistoryInquiryDetail_Info _InquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_HistoryDisplayFormatCategory")]
    protected Info _HistoryDisplayFormatCategory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_ShowDetailTypes")]
    protected Info _ShowDetailTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_HistorySummary")]
    protected Info _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_ShowAllDetailTypes")]
    protected Info _ShowAllDetailTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_SelectedHistoryItemIndex")]
    protected Info _SelectedHistoryItemIndex;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_HistoryDisplayTexts")]
    protected Info _HistoryDisplayTexts;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Info_HistorySummaryDisplayText")]
    protected Info _HistorySummaryDisplayText;

    public Info Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Histories));
      }
    }

    public Info SelectedHistoryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistoryItem));
      }
    }

    public ContainerHistoryInquiryDetail_Info InquiryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (InquiryDetail), (object) value);
      }
      get
      {
        return (ContainerHistoryInquiryDetail_Info) this.PropertyGet(nameof (InquiryDetail));
      }
    }

    public Info HistoryDisplayFormatCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDisplayFormatCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryDisplayFormatCategory));
      }
    }

    public Info ShowDetailTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowDetailTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowDetailTypes));
      }
    }

    public Info HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Info ShowAllDetailTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllDetailTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowAllDetailTypes));
      }
    }

    public Info SelectedHistoryItemIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItemIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistoryItemIndex));
      }
    }

    public Info HistoryDisplayTexts
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDisplayTexts), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryDisplayTexts));
      }
    }

    public Info HistorySummaryDisplayText
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummaryDisplayText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistorySummaryDisplayText));
      }
    }
  }
}
