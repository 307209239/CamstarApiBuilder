// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActuals
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActualsLotStock))]
  [KnownType(typeof (ActualsQuantity))]
  [KnownType(typeof (ActualsSerial))]
  [KnownType(typeof (ActualsStock))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ActualsBulk))]
  [KnownType(typeof (ActualsDisplayOnly))]
  [Serializable]
  public class IssueActuals : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_SubstitutionReason")]
    protected NamedObjectRef _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Qty2Issued")]
    protected Primitive<double> _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_IssueReason")]
    protected NamedObjectRef _IssueReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_IssueActualsHistory")]
    protected SubentityRef _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Scale")]
    protected NamedObjectRef _Scale;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_ManualOverride")]
    protected Primitive<bool> _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_IsAutoWeightEntry")]
    protected Primitive<bool> _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_ToContainer")]
    protected ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_QtyIssued")]
    protected Primitive<double> _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_ProductDescription")]
    protected Primitive<string> _ProductDescription;

    public override bool Equals(object obj)
    {
      return obj is IssueActuals && object.Equals((object) this._SubstitutionReason, (object) ((IssueActuals) obj)._SubstitutionReason) && (object.Equals((object) this._Qty2Issued, (object) ((IssueActuals) obj)._Qty2Issued) && object.Equals((object) this._IssueDifferenceReason, (object) ((IssueActuals) obj)._IssueDifferenceReason)) && (object.Equals((object) this._IssueReason, (object) ((IssueActuals) obj)._IssueReason) && object.Equals((object) this._Comments, (object) ((IssueActuals) obj)._Comments) && (object.Equals((object) this._Vendor, (object) ((IssueActuals) obj)._Vendor) && object.Equals((object) this._VendorItem, (object) ((IssueActuals) obj)._VendorItem))) && (object.Equals((object) this._IssueActualsHistory, (object) ((IssueActuals) obj)._IssueActualsHistory) && object.Equals((object) this._Scale, (object) ((IssueActuals) obj)._Scale) && (object.Equals((object) this._ReferenceDesignator, (object) ((IssueActuals) obj)._ReferenceDesignator) && object.Equals((object) this._ManualOverride, (object) ((IssueActuals) obj)._ManualOverride)) && (object.Equals((object) this._IsAutoWeightEntry, (object) ((IssueActuals) obj)._IsAutoWeightEntry) && object.Equals((object) this._ToContainer, (object) ((IssueActuals) obj)._ToContainer) && (object.Equals((object) this._Product, (object) ((IssueActuals) obj)._Product) && object.Equals((object) this._ToLocation, (object) ((IssueActuals) obj)._ToLocation)))) && (object.Equals((object) this._QtyIssued, (object) ((IssueActuals) obj)._QtyIssued) && object.Equals((object) this._ProductDescription, (object) ((IssueActuals) obj)._ProductDescription)) && base.Equals(obj);
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

    public SubentityRef IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualsHistory));
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
  }
}
