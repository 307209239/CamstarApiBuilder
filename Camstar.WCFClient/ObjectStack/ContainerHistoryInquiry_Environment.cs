// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerHistoryInquiry_Environment
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
  public class ContainerHistoryInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_Histories")]
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, true, "HistoryMainline", 1049583, false, true, false, null)]
    protected HistoryMainline_Environment _Histories;
    [Metadata("Describes history details.", "HistoryDetails", true, false, false, "HistoryDetails", 1049096, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_HistoryDetailsRef")]
    protected HistoryDetails_Environment _HistoryDetailsRef;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_SelectedHistoryItem")]
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, false, "HistoryMainline", 1049587, false, false, false, null)]
    protected HistoryMainline_Environment _SelectedHistoryItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_HistoryDisplayFormatCategory")]
    [Metadata("LabelCategoryId", "", false, false, false, "Integer", 1049584, false, false, false, null)]
    protected Environment _HistoryDisplayFormatCategory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_InquiryDetail")]
    [Metadata("ContainerHistoryInquiryDetail is used to produce more detailed history report for selected history record.", "ContainerHistoryInquiryDetail", false, false, true, "ContainerHistoryInquiryDetail", 1049586, false, false, false, null)]
    protected ContainerHistoryInquiryDetail_Environment _InquiryDetail;
    [Metadata("The History View object is used to store a user configured view of the History objects.  This object is used by the Live Manufacturing Audit Trail application.", "HistoryView", true, false, false, "HistoryView", 1050028, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_HistoryView")]
    protected HistoryView_Environment _HistoryView;
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", true, false, false, "UIPreference", 1050029, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_UIPreference")]
    protected UIPreference_Environment _UIPreference;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_Carrier")]
    protected Environment _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_RecordType")]
    [Metadata("Enumeration for the History Record Type:\r\n1 = Event\r\n2 = CAR\r\n3 = CAPA\r\n4 = Container\r\n5 = ContainerInCarrier", "HistoryRecordTypeEnum", false, false, true, "Integer", 1051578, false, false, true, "4")]
    protected Environment _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_StartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049313, false, false, false, null)]
    protected Environment _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ShowAllTxnTypes")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049588, false, false, false, "1")]
    protected Environment _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_SortAscending")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049312, false, false, false, "0")]
    protected Environment _SortAscending;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ShowFullHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049589, false, false, false, "1")]
    protected Environment _ShowFullHistory;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049590, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ShowReversalInfo")]
    protected Environment _ShowReversalInfo;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049591, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ShowTxnTypes")]
    protected Environment _ShowTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_SelectedHistoryItemIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049928, false, false, false, "-1")]
    protected Environment _SelectedHistoryItemIndex;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_EndDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049310, false, false, false, null)]
    protected Environment _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ResultsetSizeLimit")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050019, false, false, false, "-1")]
    protected Environment _ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ResultsetStartRow")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050020, false, false, false, "1")]
    protected Environment _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_HistoryDisplayTexts")]
    [Metadata("Message text.", "", false, false, true, "String", 1049585, false, true, false, null)]
    protected Environment _HistoryDisplayTexts;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ContainerName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049088, false, false, false, null)]
    protected Environment _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerHistoryInquiry_Environment_ContainerLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1049278, false, false, true, null)]
    protected Environment _ContainerLevel;

    public HistoryMainline_Environment Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (HistoryMainline_Environment) this.PropertyGet(nameof (Histories));
      }
    }

    public HistoryDetails_Environment HistoryDetailsRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetailsRef), (object) value);
      }
      get
      {
        return (HistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetailsRef));
      }
    }

    public HistoryMainline_Environment SelectedHistoryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryItem), (object) value);
      }
      get
      {
        return (HistoryMainline_Environment) this.PropertyGet(nameof (SelectedHistoryItem));
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

    public HistoryView_Environment HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (HistoryView_Environment) this.PropertyGet(nameof (HistoryView));
      }
    }

    public UIPreference_Environment UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference_Environment) this.PropertyGet(nameof (UIPreference));
      }
    }

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public Environment RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordType));
      }
    }

    public Environment StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDate));
      }
    }

    public Environment ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public Environment SortAscending
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortAscending), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SortAscending));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment ShowFullHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowFullHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowFullHistory));
      }
    }

    public Environment ShowReversalInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowReversalInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowReversalInfo));
      }
    }

    public Environment ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowTxnTypes));
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

    public Environment EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDate));
      }
    }

    public Environment ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }

    public Environment ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultsetStartRow));
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

    public Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Environment ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevel));
      }
    }
  }
}
