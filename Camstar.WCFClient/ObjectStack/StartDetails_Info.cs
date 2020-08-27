// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SerializedStartDetails_Info))]
  [KnownType(typeof (GroupStartDetails_Info))]
  [KnownType(typeof (BatchStartDetails_Info))]
  [KnownType(typeof (MaterialContainerStartDetails_Info))]
  [KnownType(typeof (UnitStartDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StartDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachedFileName")]
    protected Info _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_BOM")]
    protected Info _BOM;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PlannedQtyUOM2")]
    protected Info _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_BillOfProcess")]
    protected Info _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachedFileExtension")]
    protected Info _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ChildContainers")]
    protected StartDetails_Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_StartReason")]
    protected Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_FilePath")]
    protected Info _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PlannedQty2")]
    protected Info _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PlannedQtyUOM")]
    protected Info _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DefaultChildQty2")]
    protected Info _DefaultChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachDocument")]
    protected AttachDocument_Info _AttachDocument;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AutoNumberRule")]
    protected Info _AutoNumberRule;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttributeDetails")]
    protected StartContainerAttributeDetail_Info _AttributeDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachmentType")]
    protected Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ContainerInstance")]
    protected Info _ContainerInstance;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_SamplingRequired")]
    protected Info _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttributeSources")]
    protected Info _AttributeSources;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AutoNumber")]
    protected Info _AutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_InQualityControl")]
    protected Info _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ChildAutoNumber")]
    protected Info _ChildAutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachmentIsROR")]
    protected Info _AttachmentIsROR;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_UsingAttributes")]
    protected Info _UsingAttributes;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_LastSequence")]
    protected Info _LastSequence;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_RequestDate")]
    protected Info _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_OriginalContainer")]
    protected Info _OriginalContainer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PlannedStartDate")]
    protected Info _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachAsROR")]
    protected Info _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ChildIndex")]
    protected Info _ChildIndex;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ObjectTypeId")]
    protected Info _ObjectTypeId;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DefaultChildQty")]
    protected Info _DefaultChildQty;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DocumentRevision")]
    protected Info _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DocumentDescription")]
    protected Info _DocumentDescription;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_MfgOrder")]
    protected Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_NumberingRuleQryResult")]
    protected Info _NumberingRuleQryResult;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_AttachedDocument")]
    protected Info _AttachedDocument;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_OriginalFactory")]
    protected Info _OriginalFactory;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ContainerName")]
    protected Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Identifier")]
    protected Info _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DocumentName")]
    protected Info _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_Level")]
    protected Info _Level;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_DefaultChildLevel")]
    protected Info _DefaultChildLevel;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PlannedProduct")]
    protected Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_ContainerComment")]
    protected Info _ContainerComment;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_SalesOrder")]
    protected Info _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PriorityCode")]
    protected Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Info_PlannedQty")]
    protected Info _PlannedQty;

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
      }
    }

    public Info AttachedFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedFileName));
      }
    }

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public Info BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BOM));
      }
    }

    public Info PlannedQtyUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQtyUOM2));
      }
    }

    public Info VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorItem));
      }
    }

    public Info BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public Info Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Customer));
      }
    }

    public Info AttachedFileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileExtension), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedFileExtension));
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

    public StartDetails_Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (StartDetails_Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Info StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartReason));
      }
    }

    public Info FilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilePath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilePath));
      }
    }

    public Info PlannedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQty2));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public Info DefaultChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultChildQty2));
      }
    }

    public AttachDocument_Info AttachDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocument), (object) value);
      }
      get
      {
        return (AttachDocument_Info) this.PropertyGet(nameof (AttachDocument));
      }
    }

    public Info SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Info AutoNumberRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumberRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoNumberRule));
      }
    }

    public StartContainerAttributeDetail_Info AttributeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeDetails), (object) value);
      }
      get
      {
        return (StartContainerAttributeDetail_Info) this.PropertyGet(nameof (AttributeDetails));
      }
    }

    public Info AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public Info ContainerInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInstance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerInstance));
      }
    }

    public Info ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Info SamplingRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingRequired));
      }
    }

    public Info AttributeSources
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeSources), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeSources));
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

    public Info AutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoNumber));
      }
    }

    public Info InQualityControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (InQualityControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InQualityControl));
      }
    }

    public Info ChildAutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildAutoNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildAutoNumber));
      }
    }

    public Info UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Info ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Info AttachmentIsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentIsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentIsROR));
      }
    }

    public Info UsingAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (UsingAttributes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UsingAttributes));
      }
    }

    public Info LastSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastSequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastSequence));
      }
    }

    public Info IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Info RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequestDate));
      }
    }

    public Info OriginalContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalContainer));
      }
    }

    public Info PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Info AttachAsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachAsROR));
      }
    }

    public Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
      }
    }

    public Info ChildIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildIndex));
      }
    }

    public Info ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Info DefaultChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultChildQty));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentRevision));
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

    public Info DocumentDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentDescription));
      }
    }

    public Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Info Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workstation));
      }
    }

    public Info NumberingRuleQryResult
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleQryResult), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NumberingRuleQryResult));
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

    public Info AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedDocument));
      }
    }

    public Info OriginalFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalFactory));
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

    public Info Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Identifier));
      }
    }

    public Info DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentName));
      }
    }

    public Info Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Level));
      }
    }

    public Info DefaultChildLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultChildLevel));
      }
    }

    public Info PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedProduct));
      }
    }

    public Info ContainerComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerComment));
      }
    }

    public Info SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SalesOrder));
      }
    }

    public Info PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public Info PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQty));
      }
    }
  }
}
