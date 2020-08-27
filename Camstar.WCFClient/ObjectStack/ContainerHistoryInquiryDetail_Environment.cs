// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerHistoryInquiryDetail_Environment
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
  public class ContainerHistoryInquiryDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Describes history details.", "HistoryDetails", false, false, true, "SubentityRef", 1049791, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_Histories")]
    protected Environment _Histories;
    [Metadata("Describes history details.", "HistoryDetails", false, false, false, "SubentityRef", 1049595, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_SelectedHistoryItem")]
    protected Environment _SelectedHistoryItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_InquiryDetail")]
    [Metadata("ContainerHistoryInquiryDetail is used to produce more detailed history report for selected history record.", "ContainerHistoryInquiryDetail", false, false, true, "ContainerHistoryInquiryDetail", 1049586, false, false, false, null)]
    protected ContainerHistoryInquiryDetail_Environment _InquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_HistoryDisplayFormatCategory")]
    [Metadata("LabelCategoryId", "", false, false, false, "Integer", 1049584, false, false, false, null)]
    protected Environment _HistoryDisplayFormatCategory;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049597, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_ShowDetailTypes")]
    protected Environment _ShowDetailTypes;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049593, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_HistorySummary")]
    protected Environment _HistorySummary;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049596, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_ShowAllDetailTypes")]
    protected Environment _ShowAllDetailTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_SelectedHistoryItemIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049928, false, false, false, "-1")]
    protected Environment _SelectedHistoryItemIndex;
    [Metadata("Message text.", "", false, false, true, "String", 1049592, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_HistoryDisplayTexts")]
    protected Environment _HistoryDisplayTexts;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Environment_HistorySummaryDisplayText")]
    [Metadata("Message text.", "", false, false, true, "String", 1049594, false, false, false, null)]
    protected Environment _HistorySummaryDisplayText;

    public Environment Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Histories));
      }
    }

    public Environment SelectedHistoryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistoryItem));
      }
    }

    public ContainerHistoryInquiryDetail_Environment InquiryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (InquiryDetail), (object) value);
      }
      get
      {
        return (ContainerHistoryInquiryDetail_Environment) this.PropertyGet(nameof (InquiryDetail));
      }
    }

    public Environment HistoryDisplayFormatCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDisplayFormatCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryDisplayFormatCategory));
      }
    }

    public Environment ShowDetailTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowDetailTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowDetailTypes));
      }
    }

    public Environment HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Environment ShowAllDetailTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllDetailTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAllDetailTypes));
      }
    }

    public Environment SelectedHistoryItemIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItemIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistoryItemIndex));
      }
    }

    public Environment HistoryDisplayTexts
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDisplayTexts), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryDisplayTexts));
      }
    }

    public Environment HistorySummaryDisplayText
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummaryDisplayText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistorySummaryDisplayText));
      }
    }
  }
}
