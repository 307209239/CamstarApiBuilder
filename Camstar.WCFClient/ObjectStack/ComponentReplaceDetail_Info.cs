// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceDetail_Info
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
  public class ComponentReplaceDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_BOMLineItem")]
    protected Info _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueDetails")]
    protected IssueDetails_Info _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Qty2Required")]
    protected Info _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Qty2Issued")]
    protected Info _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_NetQty2Issued")]
    protected Info _NetQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_NetQty2Required")]
    protected Info _NetQty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_RemovalCandidate")]
    protected RemovalCandidate_Info _RemovalCandidate;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_SubstitutionReason")]
    protected Info _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Qty2Replaced")]
    protected Info _Qty2Replaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_ToWorkflowStack")]
    protected Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueActualHistory")]
    protected Info _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueCarrier")]
    protected Info _IssueCarrier;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueBatch")]
    protected Info _IssueBatch;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_ReplaceReason")]
    protected Info _ReplaceReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_DestinationStockPoint")]
    protected Info _DestinationStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_DestinationLot")]
    protected Info _DestinationLot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueStockPoint")]
    protected Info _IssueStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueLot")]
    protected Info _IssueLot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueControlName")]
    protected Info _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_RemoveContainer")]
    protected Info _RemoveContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_OpenClosedContainer")]
    protected Info _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueContainer")]
    protected Info _IssueContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IsScrapReplaced")]
    protected Info _IsScrapReplaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_UniqueID")]
    protected Info _UniqueID;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_DestinationContainer")]
    protected Info _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_IssueLocation")]
    protected Info _IssueLocation;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_QtyRequired")]
    protected Info _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_DestinationLocation")]
    protected Info _DestinationLocation;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_NetQtyIssued")]
    protected Info _NetQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_NetQtyRequired")]
    protected Info _NetQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_QtyIssued")]
    protected Info _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_ToWorkflow")]
    protected Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Info_QtyReplaced")]
    protected Info _QtyReplaced;

    public Info BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BOMLineItem));
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

    public Info Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Vendor));
      }
    }

    public IssueDetails_Info IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Info) this.PropertyGet(nameof (IssueDetails));
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

    public Info Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Info Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public Info NetQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQty2Issued));
      }
    }

    public Info NetQty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Required), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQty2Required));
      }
    }

    public RemovalCandidate_Info RemovalCandidate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalCandidate), (object) value);
      }
      get
      {
        return (RemovalCandidate_Info) this.PropertyGet(nameof (RemovalCandidate));
      }
    }

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

    public Info SubstitutionReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstitutionReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubstitutionReason));
      }
    }

    public Info Qty2Replaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Replaced), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Replaced));
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

    public Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public Info IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Info IssueCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueCarrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueCarrier));
      }
    }

    public Info IssueBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueBatch));
      }
    }

    public Info ReplaceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReplaceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReplaceReason));
      }
    }

    public Info DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }

    public Info DestinationLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationLot));
      }
    }

    public Info ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Info IssueStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueStockPoint));
      }
    }

    public Info IssueLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueLot));
      }
    }

    public Info IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Info RemoveContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemoveContainer));
      }
    }

    public Info OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public Info IssueContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueContainer));
      }
    }

    public Info IsScrapReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsScrapReplaced), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsScrapReplaced));
      }
    }

    public Info UniqueID
    {
      [param: In] set
      {
        this.PropertySet(nameof (UniqueID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UniqueID));
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

    public Info DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public Info ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Info IssueLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueLocation));
      }
    }

    public Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
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

    public Info QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public Info DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DestinationLocation));
      }
    }

    public Info NetQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQtyIssued));
      }
    }

    public Info NetQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQtyRequired));
      }
    }

    public Info QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyIssued));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public Info QtyReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyReplaced), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyReplaced));
      }
    }
  }
}
