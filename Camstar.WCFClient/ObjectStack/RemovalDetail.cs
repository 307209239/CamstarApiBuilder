// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalDetailSerial))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RemovalDetailQuantity))]
  [KnownType(typeof (RemovalDetailLotStock))]
  [KnownType(typeof (RemovalDetailBulk))]
  [KnownType(typeof (RemovalDetailStock))]
  [Serializable]
  public class RemovalDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_RemovalReason")]
    protected NamedObjectRef _RemovalReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_IssueControl")]
    protected Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_RemoveDifferenceReason")]
    protected NamedObjectRef _RemoveDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Qty2Removed")]
    protected Primitive<double> _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_IssueActualHistory")]
    protected SubentityRef _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_RemoveAllQty")]
    protected Primitive<bool> _RemoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_QtyRemoved")]
    protected Primitive<double> _QtyRemoved;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Notes")]
    protected Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is RemovalDetail && object.Equals((object) this._RemovalReason, (object) ((RemovalDetail) obj)._RemovalReason) && (object.Equals((object) this._IssueControl, (object) ((RemovalDetail) obj)._IssueControl) && object.Equals((object) this._UOM, (object) ((RemovalDetail) obj)._UOM)) && (object.Equals((object) this._RemoveDifferenceReason, (object) ((RemovalDetail) obj)._RemoveDifferenceReason) && object.Equals((object) this._UOM2, (object) ((RemovalDetail) obj)._UOM2) && (object.Equals((object) this._Qty2Removed, (object) ((RemovalDetail) obj)._Qty2Removed) && object.Equals((object) this._VendorItem, (object) ((RemovalDetail) obj)._VendorItem))) && (object.Equals((object) this._IssueActualHistory, (object) ((RemovalDetail) obj)._IssueActualHistory) && object.Equals((object) this._RemoveAllQty, (object) ((RemovalDetail) obj)._RemoveAllQty) && (object.Equals((object) this._ReferenceDesignator, (object) ((RemovalDetail) obj)._ReferenceDesignator) && object.Equals((object) this._QtyRemoved, (object) ((RemovalDetail) obj)._QtyRemoved)) && (object.Equals((object) this._Product, (object) ((RemovalDetail) obj)._Product) && object.Equals((object) this._Notes, (object) ((RemovalDetail) obj)._Notes))) && base.Equals(obj);
    }

    public NamedObjectRef RemovalReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RemovalReason));
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

    public NamedObjectRef RemoveDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveDifferenceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RemoveDifferenceReason));
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

    public Primitive<double> Qty2Removed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Removed), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Removed));
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

    public Primitive<bool> RemoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RemoveAllQty));
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

    public Primitive<double> QtyRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemoved), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRemoved));
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

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
