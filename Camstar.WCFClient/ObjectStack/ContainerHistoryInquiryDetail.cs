// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerHistoryInquiryDetail
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
  public class ContainerHistoryInquiryDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_Histories")]
    protected SubentityRef[] _Histories;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_SelectedHistoryItem")]
    protected SubentityRef _SelectedHistoryItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_InquiryDetail")]
    protected ContainerHistoryInquiryDetail _InquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_HistoryDisplayFormatCategory")]
    protected Primitive<int> _HistoryDisplayFormatCategory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_ShowDetailTypes")]
    protected Primitive<int>[] _ShowDetailTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_HistorySummary")]
    protected BaseObjectRef _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_ShowAllDetailTypes")]
    protected Primitive<bool> _ShowAllDetailTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_SelectedHistoryItemIndex")]
    protected Primitive<int> _SelectedHistoryItemIndex;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_HistoryDisplayTexts")]
    protected Primitive<string>[] _HistoryDisplayTexts;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiryDetail_HistorySummaryDisplayText")]
    protected Primitive<string> _HistorySummaryDisplayText;

    public override bool Equals(object obj)
    {
      return obj is ContainerHistoryInquiryDetail && this.CompareArrays((Array) this._Histories, (Array) ((ContainerHistoryInquiryDetail) obj)._Histories) && (object.Equals((object) this._SelectedHistoryItem, (object) ((ContainerHistoryInquiryDetail) obj)._SelectedHistoryItem) && object.Equals((object) this._InquiryDetail, (object) ((ContainerHistoryInquiryDetail) obj)._InquiryDetail)) && (object.Equals((object) this._HistoryDisplayFormatCategory, (object) ((ContainerHistoryInquiryDetail) obj)._HistoryDisplayFormatCategory) && this.CompareArrays((Array) this._ShowDetailTypes, (Array) ((ContainerHistoryInquiryDetail) obj)._ShowDetailTypes) && (object.Equals((object) this._HistorySummary, (object) ((ContainerHistoryInquiryDetail) obj)._HistorySummary) && object.Equals((object) this._ShowAllDetailTypes, (object) ((ContainerHistoryInquiryDetail) obj)._ShowAllDetailTypes))) && (object.Equals((object) this._SelectedHistoryItemIndex, (object) ((ContainerHistoryInquiryDetail) obj)._SelectedHistoryItemIndex) && this.CompareArrays((Array) this._HistoryDisplayTexts, (Array) ((ContainerHistoryInquiryDetail) obj)._HistoryDisplayTexts) && object.Equals((object) this._HistorySummaryDisplayText, (object) ((ContainerHistoryInquiryDetail) obj)._HistorySummaryDisplayText)) && base.Equals(obj);
    }

    public SubentityRef[] Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (Histories));
      }
    }

    public SubentityRef SelectedHistoryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (SelectedHistoryItem));
      }
    }

    public ContainerHistoryInquiryDetail InquiryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (InquiryDetail), (object) value);
      }
      get
      {
        return (ContainerHistoryInquiryDetail) this.PropertyGet(nameof (InquiryDetail));
      }
    }

    public Primitive<int> HistoryDisplayFormatCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDisplayFormatCategory), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (HistoryDisplayFormatCategory));
      }
    }

    public Primitive<int>[] ShowDetailTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowDetailTypes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (ShowDetailTypes));
      }
    }

    public BaseObjectRef HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Primitive<bool> ShowAllDetailTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllDetailTypes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAllDetailTypes));
      }
    }

    public Primitive<int> SelectedHistoryItemIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItemIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedHistoryItemIndex));
      }
    }

    public Primitive<string>[] HistoryDisplayTexts
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDisplayTexts), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (HistoryDisplayTexts));
      }
    }

    public Primitive<string> HistorySummaryDisplayText
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummaryDisplayText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HistorySummaryDisplayText));
      }
    }
  }
}
