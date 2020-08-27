// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerHistoryInquiry_Info
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
  public class ContainerHistoryInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_Histories")]
    protected HistoryMainline_Info _Histories;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_HistoryDetailsRef")]
    protected HistoryDetails_Info _HistoryDetailsRef;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_SelectedHistoryItem")]
    protected HistoryMainline_Info _SelectedHistoryItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_HistoryDisplayFormatCategory")]
    protected Info _HistoryDisplayFormatCategory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_InquiryDetail")]
    protected ContainerHistoryInquiryDetail_Info _InquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_HistoryView")]
    protected HistoryView_Info _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_UIPreference")]
    protected UIPreference_Info _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_RecordType")]
    protected Info _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_StartDate")]
    protected Info _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ShowAllTxnTypes")]
    protected Info _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_SortAscending")]
    protected Info _SortAscending;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ShowFullHistory")]
    protected Info _ShowFullHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ShowReversalInfo")]
    protected Info _ShowReversalInfo;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ShowTxnTypes")]
    protected Info _ShowTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_SelectedHistoryItemIndex")]
    protected Info _SelectedHistoryItemIndex;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_EndDate")]
    protected Info _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ResultsetSizeLimit")]
    protected Info _ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ResultsetStartRow")]
    protected Info _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_HistoryDisplayTexts")]
    protected Info _HistoryDisplayTexts;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ContainerName")]
    protected Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Info_ContainerLevel")]
    protected Info _ContainerLevel;

    public HistoryMainline_Info Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (HistoryMainline_Info) this.PropertyGet(nameof (Histories));
      }
    }

    public HistoryDetails_Info HistoryDetailsRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetailsRef), (object) value);
      }
      get
      {
        return (HistoryDetails_Info) this.PropertyGet(nameof (HistoryDetailsRef));
      }
    }

    public HistoryMainline_Info SelectedHistoryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItem), (object) value);
      }
      get
      {
        return (HistoryMainline_Info) this.PropertyGet(nameof (SelectedHistoryItem));
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

    public HistoryView_Info HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (HistoryView_Info) this.PropertyGet(nameof (HistoryView));
      }
    }

    public UIPreference_Info UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference_Info) this.PropertyGet(nameof (UIPreference));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordType));
      }
    }

    public Info StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartDate));
      }
    }

    public Info ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public Info SortAscending
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortAscending), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SortAscending));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info ShowFullHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowFullHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowFullHistory));
      }
    }

    public Info ShowReversalInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowReversalInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowReversalInfo));
      }
    }

    public Info ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowTxnTypes));
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

    public Info EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDate));
      }
    }

    public Info ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }

    public Info ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultsetStartRow));
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

    public Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Info ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevel));
      }
    }
  }
}
