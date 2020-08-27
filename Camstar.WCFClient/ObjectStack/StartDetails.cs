// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BatchStartDetails))]
  [KnownType(typeof (GroupStartDetails))]
  [KnownType(typeof (SerializedStartDetails))]
  [KnownType(typeof (UnitStartDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MaterialContainerStartDetails))]
  [Serializable]
  public class StartDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachedFileName")]
    protected Primitive<string> _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_BOM")]
    protected RevisionedObjectRef _BOM;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PlannedQtyUOM2")]
    protected NamedObjectRef _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachedFileExtension")]
    protected Primitive<string> _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ChildContainers")]
    protected StartDetails[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_StartReason")]
    protected NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_FilePath")]
    protected Primitive<string> _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PlannedQty2")]
    protected Primitive<double> _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Status")]
    protected Enumeration<ContainerStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PlannedQtyUOM")]
    protected NamedObjectRef _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DefaultChildQty2")]
    protected Primitive<double> _DefaultChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachDocument")]
    protected AttachDocument _AttachDocument;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AutoNumberRule")]
    protected NamedObjectRef _AutoNumberRule;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttributeDetails")]
    protected StartContainerAttributeDetail[] _AttributeDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachmentType")]
    protected Enumeration<AttachmentTypeEnum, int> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ContainerInstance")]
    protected ContainerRef _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_SamplingRequired")]
    protected Primitive<bool> _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttributeSources")]
    protected BaseObjectRef[] _AttributeSources;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AutoNumber")]
    protected Primitive<bool> _AutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_InQualityControl")]
    protected Primitive<int> _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ChildAutoNumber")]
    protected Primitive<bool> _ChildAutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachmentIsROR")]
    protected Primitive<bool> _AttachmentIsROR;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_UsingAttributes")]
    protected Primitive<bool> _UsingAttributes;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_LastSequence")]
    protected Primitive<int>[] _LastSequence;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_RequestDate")]
    protected Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_OriginalContainer")]
    protected ContainerRef _OriginalContainer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PlannedStartDate")]
    protected Primitive<DateTime> _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachAsROR")]
    protected Primitive<bool> _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ChildIndex")]
    protected Primitive<int> _ChildIndex;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ObjectTypeId")]
    protected Primitive<int> _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DefaultChildQty")]
    protected Primitive<double> _DefaultChildQty;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DocumentRevision")]
    protected Primitive<string> _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DocumentDescription")]
    protected Primitive<string> _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_MfgOrder")]
    protected NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_NumberingRuleQryResult")]
    protected Primitive<string> _NumberingRuleQryResult;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_AttachedDocument")]
    protected RevisionedObjectRef _AttachedDocument;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_OriginalFactory")]
    protected NamedObjectRef _OriginalFactory;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ContainerName")]
    protected Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Identifier")]
    protected Primitive<string> _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DocumentName")]
    protected Primitive<string> _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Level")]
    protected NamedObjectRef _Level;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_DefaultChildLevel")]
    protected NamedObjectRef _DefaultChildLevel;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PlannedProduct")]
    protected RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_ContainerComment")]
    protected Primitive<string> _ContainerComment;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_SalesOrder")]
    protected NamedObjectRef _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PriorityCode")]
    protected NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_PlannedQty")]
    protected Primitive<double> _PlannedQty;

    public override bool Equals(object obj)
    {
      return obj is StartDetails && object.Equals((object) this._UOM2, (object) ((StartDetails) obj)._UOM2) && (object.Equals((object) this._AttachedFileName, (object) ((StartDetails) obj)._AttachedFileName) && object.Equals((object) this._Qty2, (object) ((StartDetails) obj)._Qty2)) && (object.Equals((object) this._BOM, (object) ((StartDetails) obj)._BOM) && object.Equals((object) this._PlannedQtyUOM2, (object) ((StartDetails) obj)._PlannedQtyUOM2) && (object.Equals((object) this._VendorItem, (object) ((StartDetails) obj)._VendorItem) && object.Equals((object) this._BillOfProcess, (object) ((StartDetails) obj)._BillOfProcess))) && (object.Equals((object) this._Customer, (object) ((StartDetails) obj)._Customer) && object.Equals((object) this._AttachedFileExtension, (object) ((StartDetails) obj)._AttachedFileExtension) && (object.Equals((object) this._UOM, (object) ((StartDetails) obj)._UOM) && this.CompareArrays((Array) this._ChildContainers, (Array) ((StartDetails) obj)._ChildContainers)) && (object.Equals((object) this._StartReason, (object) ((StartDetails) obj)._StartReason) && object.Equals((object) this._FilePath, (object) ((StartDetails) obj)._FilePath) && (object.Equals((object) this._PlannedQty2, (object) ((StartDetails) obj)._PlannedQty2) && object.Equals((object) this._Status, (object) ((StartDetails) obj)._Status)))) && (object.Equals((object) this._PlannedQtyUOM, (object) ((StartDetails) obj)._PlannedQtyUOM) && object.Equals((object) this._DefaultChildQty2, (object) ((StartDetails) obj)._DefaultChildQty2) && (object.Equals((object) this._AttachDocument, (object) ((StartDetails) obj)._AttachDocument) && object.Equals((object) this._SamplingLot, (object) ((StartDetails) obj)._SamplingLot)) && (object.Equals((object) this._AutoNumberRule, (object) ((StartDetails) obj)._AutoNumberRule) && this.CompareArrays((Array) this._AttributeDetails, (Array) ((StartDetails) obj)._AttributeDetails) && (object.Equals((object) this._AttachmentType, (object) ((StartDetails) obj)._AttachmentType) && object.Equals((object) this._ContainerInstance, (object) ((StartDetails) obj)._ContainerInstance))) && (object.Equals((object) this._ExpirationDate, (object) ((StartDetails) obj)._ExpirationDate) && object.Equals((object) this._SamplingRequired, (object) ((StartDetails) obj)._SamplingRequired) && (this.CompareArrays((Array) this._AttributeSources, (Array) ((StartDetails) obj)._AttributeSources) && object.Equals((object) this._Container, (object) ((StartDetails) obj)._Container)) && (object.Equals((object) this._AutoNumber, (object) ((StartDetails) obj)._AutoNumber) && object.Equals((object) this._InQualityControl, (object) ((StartDetails) obj)._InQualityControl) && (object.Equals((object) this._ChildAutoNumber, (object) ((StartDetails) obj)._ChildAutoNumber) && object.Equals((object) this._UnitCount, (object) ((StartDetails) obj)._UnitCount))))) && (object.Equals((object) this._ChildCount, (object) ((StartDetails) obj)._ChildCount) && object.Equals((object) this._AttachmentIsROR, (object) ((StartDetails) obj)._AttachmentIsROR) && (object.Equals((object) this._UsingAttributes, (object) ((StartDetails) obj)._UsingAttributes) && this.CompareArrays((Array) this._LastSequence, (Array) ((StartDetails) obj)._LastSequence)) && (object.Equals((object) this._IsContainer, (object) ((StartDetails) obj)._IsContainer) && object.Equals((object) this._RequestDate, (object) ((StartDetails) obj)._RequestDate) && (object.Equals((object) this._OriginalContainer, (object) ((StartDetails) obj)._OriginalContainer) && object.Equals((object) this._PlannedStartDate, (object) ((StartDetails) obj)._PlannedStartDate))) && (object.Equals((object) this._AttachAsROR, (object) ((StartDetails) obj)._AttachAsROR) && object.Equals((object) this._DueDate, (object) ((StartDetails) obj)._DueDate) && (object.Equals((object) this._ChildIndex, (object) ((StartDetails) obj)._ChildIndex) && object.Equals((object) this._ObjectTypeId, (object) ((StartDetails) obj)._ObjectTypeId)) && (object.Equals((object) this._DefaultChildQty, (object) ((StartDetails) obj)._DefaultChildQty) && object.Equals((object) this._Owner, (object) ((StartDetails) obj)._Owner) && (object.Equals((object) this._DocumentRevision, (object) ((StartDetails) obj)._DocumentRevision) && object.Equals((object) this._Qty, (object) ((StartDetails) obj)._Qty)))) && (object.Equals((object) this._DocumentDescription, (object) ((StartDetails) obj)._DocumentDescription) && object.Equals((object) this._MfgOrder, (object) ((StartDetails) obj)._MfgOrder) && (object.Equals((object) this._Workstation, (object) ((StartDetails) obj)._Workstation) && object.Equals((object) this._NumberingRuleQryResult, (object) ((StartDetails) obj)._NumberingRuleQryResult)) && (object.Equals((object) this._Product, (object) ((StartDetails) obj)._Product) && object.Equals((object) this._AttachedDocument, (object) ((StartDetails) obj)._AttachedDocument) && (object.Equals((object) this._OriginalFactory, (object) ((StartDetails) obj)._OriginalFactory) && object.Equals((object) this._ContainerName, (object) ((StartDetails) obj)._ContainerName))) && (object.Equals((object) this._Identifier, (object) ((StartDetails) obj)._Identifier) && object.Equals((object) this._DocumentName, (object) ((StartDetails) obj)._DocumentName) && (object.Equals((object) this._Level, (object) ((StartDetails) obj)._Level) && object.Equals((object) this._DefaultChildLevel, (object) ((StartDetails) obj)._DefaultChildLevel)) && (object.Equals((object) this._PlannedProduct, (object) ((StartDetails) obj)._PlannedProduct) && object.Equals((object) this._ContainerComment, (object) ((StartDetails) obj)._ContainerComment) && (object.Equals((object) this._SalesOrder, (object) ((StartDetails) obj)._SalesOrder) && object.Equals((object) this._PriorityCode, (object) ((StartDetails) obj)._PriorityCode)))))) && object.Equals((object) this._PlannedQty, (object) ((StartDetails) obj)._PlannedQty) && base.Equals(obj);
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public Primitive<string> AttachedFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachedFileName));
      }
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public RevisionedObjectRef BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BOM));
      }
    }

    public NamedObjectRef PlannedQtyUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedQtyUOM2));
      }
    }

    public NamedSubentityRef VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (VendorItem));
      }
    }

    public RevisionedObjectRef BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public NamedObjectRef Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Customer));
      }
    }

    public Primitive<string> AttachedFileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileExtension), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachedFileExtension));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public StartDetails[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (StartDetails[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public NamedObjectRef StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartReason));
      }
    }

    public Primitive<string> FilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilePath), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilePath));
      }
    }

    public Primitive<double> PlannedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedQty2));
      }
    }

    public Enumeration<ContainerStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ContainerStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public NamedObjectRef PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public Primitive<double> DefaultChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (DefaultChildQty2));
      }
    }

    public AttachDocument AttachDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocument), (object) value);
      }
      get
      {
        return (AttachDocument) this.PropertyGet(nameof (AttachDocument));
      }
    }

    public NamedObjectRef SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public NamedObjectRef AutoNumberRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumberRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AutoNumberRule));
      }
    }

    public StartContainerAttributeDetail[] AttributeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeDetails), (object) value);
      }
      get
      {
        return (StartContainerAttributeDetail[]) this.PropertyGet(nameof (AttributeDetails));
      }
    }

    public Enumeration<AttachmentTypeEnum, int> AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Enumeration<AttachmentTypeEnum, int>) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public ContainerRef ContainerInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInstance), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ContainerInstance));
      }
    }

    public Primitive<DateTime> ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Primitive<bool> SamplingRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SamplingRequired));
      }
    }

    public BaseObjectRef[] AttributeSources
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeSources), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (AttributeSources));
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

    public Primitive<bool> AutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumber), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoNumber));
      }
    }

    public Primitive<int> InQualityControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (InQualityControl), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (InQualityControl));
      }
    }

    public Primitive<bool> ChildAutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildAutoNumber), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ChildAutoNumber));
      }
    }

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Primitive<bool> AttachmentIsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentIsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AttachmentIsROR));
      }
    }

    public Primitive<bool> UsingAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (UsingAttributes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UsingAttributes));
      }
    }

    public Primitive<int>[] LastSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastSequence), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (LastSequence));
      }
    }

    public Primitive<bool> IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Primitive<DateTime> RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RequestDate));
      }
    }

    public ContainerRef OriginalContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (OriginalContainer));
      }
    }

    public Primitive<DateTime> PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Primitive<bool> AttachAsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AttachAsROR));
      }
    }

    public Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public Primitive<int> ChildIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildIndex));
      }
    }

    public Primitive<int> ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Primitive<double> DefaultChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (DefaultChildQty));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<string> DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentRevision));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public Primitive<string> DocumentDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentDescription));
      }
    }

    public NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
      }
    }

    public Primitive<string> NumberingRuleQryResult
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleQryResult), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NumberingRuleQryResult));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public RevisionedObjectRef AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (AttachedDocument));
      }
    }

    public NamedObjectRef OriginalFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OriginalFactory));
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

    public Primitive<string> Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Identifier));
      }
    }

    public Primitive<string> DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentName));
      }
    }

    public NamedObjectRef Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Level));
      }
    }

    public NamedObjectRef DefaultChildLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultChildLevel));
      }
    }

    public RevisionedObjectRef PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PlannedProduct));
      }
    }

    public Primitive<string> ContainerComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerComment));
      }
    }

    public NamedObjectRef SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SalesOrder));
      }
    }

    public NamedObjectRef PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public Primitive<double> PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedQty));
      }
    }
  }
}
