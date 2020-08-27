// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalHistoryDetailQuantity))]
  [KnownType(typeof (RemovalHistoryDetailBulk))]
  [KnownType(typeof (RemovalHistoryDetailSerial))]
  [KnownType(typeof (RemovalHistoryDetailStock))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RemovalHistoryDetailLotStock))]
  [Serializable]
  public class RemovalHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_RemoveDifferenceReason")]
    protected NamedObjectRef _RemoveDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_IssueActualsHistory")]
    protected SubentityRef _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Qty2Removed")]
    protected Primitive<double> _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_IssueControl")]
    protected Primitive<int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_RemoveAllQty")]
    protected Primitive<bool> _RemoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_RemovalReason")]
    protected NamedObjectRef _RemovalReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_QtyRemoved")]
    protected Primitive<double> _QtyRemoved;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is RemovalHistoryDetail && object.Equals((object) this._RemoveDifferenceReason, (object) ((RemovalHistoryDetail) obj)._RemoveDifferenceReason) && (object.Equals((object) this._VendorItem, (object) ((RemovalHistoryDetail) obj)._VendorItem) && object.Equals((object) this._UOM2, (object) ((RemovalHistoryDetail) obj)._UOM2)) && (object.Equals((object) this._UOM, (object) ((RemovalHistoryDetail) obj)._UOM) && object.Equals((object) this._IssueActualsHistory, (object) ((RemovalHistoryDetail) obj)._IssueActualsHistory) && (object.Equals((object) this._Qty2Removed, (object) ((RemovalHistoryDetail) obj)._Qty2Removed) && object.Equals((object) this._ExportImportKey, (object) ((RemovalHistoryDetail) obj)._ExportImportKey))) && (object.Equals((object) this._HistoryId, (object) ((RemovalHistoryDetail) obj)._HistoryId) && object.Equals((object) this._IssueControl, (object) ((RemovalHistoryDetail) obj)._IssueControl) && (object.Equals((object) this._ReferenceDesignator, (object) ((RemovalHistoryDetail) obj)._ReferenceDesignator) && object.Equals((object) this._RemoveAllQty, (object) ((RemovalHistoryDetail) obj)._RemoveAllQty)) && (object.Equals((object) this._Notes, (object) ((RemovalHistoryDetail) obj)._Notes) && object.Equals((object) this._RemovalReason, (object) ((RemovalHistoryDetail) obj)._RemovalReason) && (object.Equals((object) this._QtyRemoved, (object) ((RemovalHistoryDetail) obj)._QtyRemoved) && object.Equals((object) this._Product, (object) ((RemovalHistoryDetail) obj)._Product)))) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IssueControl));
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
  }
}
