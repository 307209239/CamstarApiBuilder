// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualDetail
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
  public class IssueActualDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_SubstitutionReason")]
    protected NamedObjectRef _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Qty2Issued")]
    protected Primitive<double> _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_IssueReason")]
    protected NamedObjectRef _IssueReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Scale")]
    protected NamedObjectRef _Scale;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_FromBatch")]
    protected ContainerRef _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_FromCarrier")]
    protected NamedObjectRef _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_ToContainer")]
    protected ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_UniqueID")]
    protected Primitive<int> _UniqueID;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_ManualOverride")]
    protected Primitive<bool> _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_IsAutoWeightEntry")]
    protected Primitive<bool> _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_FromStockPoint")]
    protected Primitive<string> _FromStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_FromLot")]
    protected Primitive<string> _FromLot;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_QtyIssued")]
    protected Primitive<double> _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_FromLocation")]
    protected NamedSubentityRef _FromLocation;

    public override bool Equals(object obj)
    {
      return obj is IssueActualDetail && object.Equals((object) this._VendorItem, (object) ((IssueActualDetail) obj)._VendorItem) && (object.Equals((object) this._IssueDifferenceReason, (object) ((IssueActualDetail) obj)._IssueDifferenceReason) && object.Equals((object) this._BOMLineItem, (object) ((IssueActualDetail) obj)._BOMLineItem)) && (object.Equals((object) this._Vendor, (object) ((IssueActualDetail) obj)._Vendor) && object.Equals((object) this._SubstitutionReason, (object) ((IssueActualDetail) obj)._SubstitutionReason) && (object.Equals((object) this._Qty2Issued, (object) ((IssueActualDetail) obj)._Qty2Issued) && object.Equals((object) this._Comments, (object) ((IssueActualDetail) obj)._Comments))) && (object.Equals((object) this._IssueReason, (object) ((IssueActualDetail) obj)._IssueReason) && object.Equals((object) this._Scale, (object) ((IssueActualDetail) obj)._Scale) && (object.Equals((object) this._FromBatch, (object) ((IssueActualDetail) obj)._FromBatch) && object.Equals((object) this._FromCarrier, (object) ((IssueActualDetail) obj)._FromCarrier)) && (object.Equals((object) this._ToContainer, (object) ((IssueActualDetail) obj)._ToContainer) && object.Equals((object) this._UniqueID, (object) ((IssueActualDetail) obj)._UniqueID) && (object.Equals((object) this._FromContainer, (object) ((IssueActualDetail) obj)._FromContainer) && object.Equals((object) this._ManualOverride, (object) ((IssueActualDetail) obj)._ManualOverride)))) && (object.Equals((object) this._IsAutoWeightEntry, (object) ((IssueActualDetail) obj)._IsAutoWeightEntry) && object.Equals((object) this._FromStockPoint, (object) ((IssueActualDetail) obj)._FromStockPoint) && (object.Equals((object) this._FromLot, (object) ((IssueActualDetail) obj)._FromLot) && object.Equals((object) this._ReferenceDesignator, (object) ((IssueActualDetail) obj)._ReferenceDesignator)) && (object.Equals((object) this._Product, (object) ((IssueActualDetail) obj)._Product) && object.Equals((object) this._QtyIssued, (object) ((IssueActualDetail) obj)._QtyIssued) && (object.Equals((object) this._ToLocation, (object) ((IssueActualDetail) obj)._ToLocation) && object.Equals((object) this._FromLocation, (object) ((IssueActualDetail) obj)._FromLocation)))) && base.Equals(obj);
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

    public NamedObjectRef IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (IssueDifferenceReason));
      }
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

    public NamedObjectRef IssueReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (IssueReason));
      }
    }

    public NamedObjectRef Scale
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scale), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Scale));
      }
    }

    public ContainerRef FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromBatch));
      }
    }

    public NamedObjectRef FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public ContainerRef ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ToContainer));
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

    public ContainerRef FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Primitive<bool> ManualOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualOverride), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ManualOverride));
      }
    }

    public Primitive<bool> IsAutoWeightEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAutoWeightEntry), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsAutoWeightEntry));
      }
    }

    public Primitive<string> FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromStockPoint));
      }
    }

    public Primitive<string> FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromLot));
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

    public NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }

    public NamedSubentityRef FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}
