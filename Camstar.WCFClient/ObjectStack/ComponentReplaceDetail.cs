// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceDetail
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
  public class ComponentReplaceDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueDetails")]
    protected IssueDetails _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Qty2Required")]
    protected Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Qty2Issued")]
    protected Primitive<double> _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_NetQty2Issued")]
    protected Primitive<double> _NetQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_NetQty2Required")]
    protected Primitive<double> _NetQty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_RemovalCandidate")]
    protected RemovalCandidate _RemovalCandidate;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_SubstitutionReason")]
    protected NamedObjectRef _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Qty2Replaced")]
    protected Primitive<double> _Qty2Replaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueControl")]
    protected Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_ToWorkflowStack")]
    protected NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueActualHistory")]
    protected SubentityRef _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueCarrier")]
    protected NamedObjectRef _IssueCarrier;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueBatch")]
    protected ContainerRef _IssueBatch;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_ReplaceReason")]
    protected NamedObjectRef _ReplaceReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_DestinationStockPoint")]
    protected Primitive<string> _DestinationStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_DestinationLot")]
    protected Primitive<string> _DestinationLot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueStockPoint")]
    protected Primitive<string> _IssueStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueLot")]
    protected Primitive<string> _IssueLot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueControlName")]
    protected Primitive<string> _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_RemoveContainer")]
    protected Primitive<string> _RemoveContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_OpenClosedContainer")]
    protected Primitive<bool> _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueContainer")]
    protected ContainerRef _IssueContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IsScrapReplaced")]
    protected Primitive<bool> _IsScrapReplaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_UniqueID")]
    protected Primitive<int> _UniqueID;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_DestinationContainer")]
    protected ContainerRef _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_IssueLocation")]
    protected NamedSubentityRef _IssueLocation;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_QtyRequired")]
    protected Primitive<double> _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_DestinationLocation")]
    protected NamedSubentityRef _DestinationLocation;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_NetQtyIssued")]
    protected Primitive<double> _NetQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_NetQtyRequired")]
    protected Primitive<double> _NetQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_QtyIssued")]
    protected Primitive<double> _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_QtyReplaced")]
    protected Primitive<double> _QtyReplaced;

    public override bool Equals(object obj)
    {
      return obj is ComponentReplaceDetail && object.Equals((object) this._BOMLineItem, (object) ((ComponentReplaceDetail) obj)._BOMLineItem) && (object.Equals((object) this._VendorItem, (object) ((ComponentReplaceDetail) obj)._VendorItem) && object.Equals((object) this._Vendor, (object) ((ComponentReplaceDetail) obj)._Vendor)) && (object.Equals((object) this._IssueDetails, (object) ((ComponentReplaceDetail) obj)._IssueDetails) && object.Equals((object) this._UOM, (object) ((ComponentReplaceDetail) obj)._UOM) && (object.Equals((object) this._Qty2Required, (object) ((ComponentReplaceDetail) obj)._Qty2Required) && object.Equals((object) this._Qty2Issued, (object) ((ComponentReplaceDetail) obj)._Qty2Issued))) && (object.Equals((object) this._NetQty2Issued, (object) ((ComponentReplaceDetail) obj)._NetQty2Issued) && object.Equals((object) this._NetQty2Required, (object) ((ComponentReplaceDetail) obj)._NetQty2Required) && (object.Equals((object) this._RemovalCandidate, (object) ((ComponentReplaceDetail) obj)._RemovalCandidate) && object.Equals((object) this._UOM2, (object) ((ComponentReplaceDetail) obj)._UOM2)) && (object.Equals((object) this._SubstitutionReason, (object) ((ComponentReplaceDetail) obj)._SubstitutionReason) && object.Equals((object) this._Qty2Replaced, (object) ((ComponentReplaceDetail) obj)._Qty2Replaced) && (object.Equals((object) this._Comments, (object) ((ComponentReplaceDetail) obj)._Comments) && object.Equals((object) this._IssueControl, (object) ((ComponentReplaceDetail) obj)._IssueControl)))) && (this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((ComponentReplaceDetail) obj)._ToWorkflowStack) && object.Equals((object) this._IssueActualHistory, (object) ((ComponentReplaceDetail) obj)._IssueActualHistory) && (object.Equals((object) this._IssueCarrier, (object) ((ComponentReplaceDetail) obj)._IssueCarrier) && object.Equals((object) this._IssueBatch, (object) ((ComponentReplaceDetail) obj)._IssueBatch)) && (object.Equals((object) this._ReplaceReason, (object) ((ComponentReplaceDetail) obj)._ReplaceReason) && object.Equals((object) this._DestinationStockPoint, (object) ((ComponentReplaceDetail) obj)._DestinationStockPoint) && (object.Equals((object) this._DestinationLot, (object) ((ComponentReplaceDetail) obj)._DestinationLot) && object.Equals((object) this._ReferenceDesignator, (object) ((ComponentReplaceDetail) obj)._ReferenceDesignator))) && (object.Equals((object) this._IssueStockPoint, (object) ((ComponentReplaceDetail) obj)._IssueStockPoint) && object.Equals((object) this._IssueLot, (object) ((ComponentReplaceDetail) obj)._IssueLot) && (object.Equals((object) this._IssueControlName, (object) ((ComponentReplaceDetail) obj)._IssueControlName) && object.Equals((object) this._RemoveContainer, (object) ((ComponentReplaceDetail) obj)._RemoveContainer)) && (object.Equals((object) this._OpenClosedContainer, (object) ((ComponentReplaceDetail) obj)._OpenClosedContainer) && object.Equals((object) this._IssueContainer, (object) ((ComponentReplaceDetail) obj)._IssueContainer) && (object.Equals((object) this._IsScrapReplaced, (object) ((ComponentReplaceDetail) obj)._IsScrapReplaced) && object.Equals((object) this._UniqueID, (object) ((ComponentReplaceDetail) obj)._UniqueID))))) && (object.Equals((object) this._Container, (object) ((ComponentReplaceDetail) obj)._Container) && object.Equals((object) this._DestinationContainer, (object) ((ComponentReplaceDetail) obj)._DestinationContainer) && (object.Equals((object) this._ProductDescription, (object) ((ComponentReplaceDetail) obj)._ProductDescription) && object.Equals((object) this._IssueLocation, (object) ((ComponentReplaceDetail) obj)._IssueLocation)) && (object.Equals((object) this._ToStep, (object) ((ComponentReplaceDetail) obj)._ToStep) && object.Equals((object) this._Product, (object) ((ComponentReplaceDetail) obj)._Product) && (object.Equals((object) this._QtyRequired, (object) ((ComponentReplaceDetail) obj)._QtyRequired) && object.Equals((object) this._DestinationLocation, (object) ((ComponentReplaceDetail) obj)._DestinationLocation))) && (object.Equals((object) this._NetQtyIssued, (object) ((ComponentReplaceDetail) obj)._NetQtyIssued) && object.Equals((object) this._NetQtyRequired, (object) ((ComponentReplaceDetail) obj)._NetQtyRequired) && (object.Equals((object) this._QtyIssued, (object) ((ComponentReplaceDetail) obj)._QtyIssued) && object.Equals((object) this._Location, (object) ((ComponentReplaceDetail) obj)._Location)) && (object.Equals((object) this._ToWorkflow, (object) ((ComponentReplaceDetail) obj)._ToWorkflow) && object.Equals((object) this._QtyReplaced, (object) ((ComponentReplaceDetail) obj)._QtyReplaced)))) && base.Equals(obj);
    }

    public NamedSubentityRef BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (BOMLineItem));
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

    public NamedObjectRef Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Vendor));
      }
    }

    public IssueDetails IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails) this.PropertyGet(nameof (IssueDetails));
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

    public Primitive<double> Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Primitive<double> Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public Primitive<double> NetQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQty2Issued));
      }
    }

    public Primitive<double> NetQty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Required), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQty2Required));
      }
    }

    public RemovalCandidate RemovalCandidate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalCandidate), (object) value);
      }
      get
      {
        return (RemovalCandidate) this.PropertyGet(nameof (RemovalCandidate));
      }
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

    public NamedObjectRef SubstitutionReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstitutionReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubstitutionReason));
      }
    }

    public Primitive<double> Qty2Replaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Replaced), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Replaced));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public NamedSubentityRef[] ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public SubentityRef IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public NamedObjectRef IssueCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueCarrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (IssueCarrier));
      }
    }

    public ContainerRef IssueBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueBatch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (IssueBatch));
      }
    }

    public NamedObjectRef ReplaceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReplaceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReplaceReason));
      }
    }

    public Primitive<string> DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }

    public Primitive<string> DestinationLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DestinationLot));
      }
    }

    public Primitive<string> ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Primitive<string> IssueStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssueStockPoint));
      }
    }

    public Primitive<string> IssueLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssueLot));
      }
    }

    public Primitive<string> IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Primitive<string> RemoveContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveContainer), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RemoveContainer));
      }
    }

    public Primitive<bool> OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public ContainerRef IssueContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (IssueContainer));
      }
    }

    public Primitive<bool> IsScrapReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsScrapReplaced), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsScrapReplaced));
      }
    }

    public Primitive<int> UniqueID
    {
      [param: In] set
      {
        this.PropertySet(nameof (UniqueID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UniqueID));
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

    public ContainerRef DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public Primitive<string> ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public NamedSubentityRef IssueLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (IssueLocation));
      }
    }

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
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

    public Primitive<double> QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public NamedSubentityRef DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (DestinationLocation));
      }
    }

    public Primitive<double> NetQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQtyIssued));
      }
    }

    public Primitive<double> NetQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyRequired), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQtyRequired));
      }
    }

    public Primitive<double> QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyIssued));
      }
    }

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }

    public RevisionedObjectRef ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public Primitive<double> QtyReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyReplaced), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyReplaced));
      }
    }
  }
}
