// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerHistoryInquiry
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
  public class ContainerHistoryInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Histories")]
    protected HistoryMainline[] _Histories;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_HistoryDetailsRef")]
    protected HistoryDetails _HistoryDetailsRef;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_SelectedHistoryItem")]
    protected HistoryMainline _SelectedHistoryItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_HistoryDisplayFormatCategory")]
    protected Primitive<int> _HistoryDisplayFormatCategory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_InquiryDetail")]
    protected ContainerHistoryInquiryDetail _InquiryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_HistoryView")]
    protected HistoryView _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_UIPreference")]
    protected UIPreference _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_RecordType")]
    protected Enumeration<HistoryRecordTypeEnum, int> _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_StartDate")]
    protected Primitive<DateTime> _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ShowAllTxnTypes")]
    protected Primitive<bool> _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_SortAscending")]
    protected Primitive<bool> _SortAscending;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ShowFullHistory")]
    protected Primitive<bool> _ShowFullHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ShowReversalInfo")]
    protected Primitive<bool> _ShowReversalInfo;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ShowTxnTypes")]
    protected Primitive<int>[] _ShowTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_SelectedHistoryItemIndex")]
    protected Primitive<int> _SelectedHistoryItemIndex;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_EndDate")]
    protected Primitive<DateTime> _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ResultsetSizeLimit")]
    protected Primitive<int> _ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ResultsetStartRow")]
    protected Primitive<int> _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_HistoryDisplayTexts")]
    protected Primitive<string>[] _HistoryDisplayTexts;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ContainerName")]
    protected Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_ContainerLevel")]
    protected NamedObjectRef _ContainerLevel;

    public override bool Equals(object obj)
    {
      return obj is ContainerHistoryInquiry && this.CompareArrays((Array) this._Histories, (Array) ((ContainerHistoryInquiry) obj)._Histories) && (object.Equals((object) this._HistoryDetailsRef, (object) ((ContainerHistoryInquiry) obj)._HistoryDetailsRef) && object.Equals((object) this._SelectedHistoryItem, (object) ((ContainerHistoryInquiry) obj)._SelectedHistoryItem)) && (object.Equals((object) this._HistoryDisplayFormatCategory, (object) ((ContainerHistoryInquiry) obj)._HistoryDisplayFormatCategory) && object.Equals((object) this._InquiryDetail, (object) ((ContainerHistoryInquiry) obj)._InquiryDetail) && (object.Equals((object) this._HistoryView, (object) ((ContainerHistoryInquiry) obj)._HistoryView) && object.Equals((object) this._UIPreference, (object) ((ContainerHistoryInquiry) obj)._UIPreference))) && (object.Equals((object) this._Carrier, (object) ((ContainerHistoryInquiry) obj)._Carrier) && object.Equals((object) this._RecordType, (object) ((ContainerHistoryInquiry) obj)._RecordType) && (object.Equals((object) this._StartDate, (object) ((ContainerHistoryInquiry) obj)._StartDate) && object.Equals((object) this._ShowAllTxnTypes, (object) ((ContainerHistoryInquiry) obj)._ShowAllTxnTypes)) && (object.Equals((object) this._SortAscending, (object) ((ContainerHistoryInquiry) obj)._SortAscending) && object.Equals((object) this._Container, (object) ((ContainerHistoryInquiry) obj)._Container) && (object.Equals((object) this._ShowFullHistory, (object) ((ContainerHistoryInquiry) obj)._ShowFullHistory) && object.Equals((object) this._ShowReversalInfo, (object) ((ContainerHistoryInquiry) obj)._ShowReversalInfo)))) && (this.CompareArrays((Array) this._ShowTxnTypes, (Array) ((ContainerHistoryInquiry) obj)._ShowTxnTypes) && object.Equals((object) this._SelectedHistoryItemIndex, (object) ((ContainerHistoryInquiry) obj)._SelectedHistoryItemIndex) && (object.Equals((object) this._EndDate, (object) ((ContainerHistoryInquiry) obj)._EndDate) && object.Equals((object) this._ResultsetSizeLimit, (object) ((ContainerHistoryInquiry) obj)._ResultsetSizeLimit)) && (object.Equals((object) this._ResultsetStartRow, (object) ((ContainerHistoryInquiry) obj)._ResultsetStartRow) && this.CompareArrays((Array) this._HistoryDisplayTexts, (Array) ((ContainerHistoryInquiry) obj)._HistoryDisplayTexts) && (object.Equals((object) this._ContainerName, (object) ((ContainerHistoryInquiry) obj)._ContainerName) && object.Equals((object) this._ContainerLevel, (object) ((ContainerHistoryInquiry) obj)._ContainerLevel)))) && base.Equals(obj);
    }

    public HistoryMainline[] Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (HistoryMainline[]) this.PropertyGet(nameof (Histories));
      }
    }

    public HistoryDetails HistoryDetailsRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetailsRef), (object) value);
      }
      get
      {
        return (HistoryDetails) this.PropertyGet(nameof (HistoryDetailsRef));
      }
    }

    public HistoryMainline SelectedHistoryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItem), (object) value);
      }
      get
      {
        return (HistoryMainline) this.PropertyGet(nameof (SelectedHistoryItem));
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

    public HistoryView HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (HistoryView) this.PropertyGet(nameof (HistoryView));
      }
    }

    public UIPreference UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference) this.PropertyGet(nameof (UIPreference));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public Enumeration<HistoryRecordTypeEnum, int> RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Enumeration<HistoryRecordTypeEnum, int>) this.PropertyGet(nameof (RecordType));
      }
    }

    public Primitive<DateTime> StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDate));
      }
    }

    public Primitive<bool> ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public Primitive<bool> SortAscending
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortAscending), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SortAscending));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<bool> ShowFullHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowFullHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowFullHistory));
      }
    }

    public Primitive<bool> ShowReversalInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowReversalInfo), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowReversalInfo));
      }
    }

    public Primitive<int>[] ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (ShowTxnTypes));
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

    public Primitive<DateTime> EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDate));
      }
    }

    public Primitive<int> ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }

    public Primitive<int> ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResultsetStartRow));
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

    public Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public NamedObjectRef ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerLevel));
      }
    }
  }
}
