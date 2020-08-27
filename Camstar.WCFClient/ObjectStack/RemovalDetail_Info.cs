// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalDetailSerial_Info))]
  [KnownType(typeof (RemovalDetailStock_Info))]
  [KnownType(typeof (RemovalDetailBulk_Info))]
  [KnownType(typeof (RemovalDetailQuantity_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RemovalDetailLotStock_Info))]
  [Serializable]
  public class RemovalDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_RemovalReason")]
    protected Info _RemovalReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_RemoveDifferenceReason")]
    protected Info _RemoveDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_Qty2Removed")]
    protected Info _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_IssueActualHistory")]
    protected Info _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_RemoveAllQty")]
    protected Info _RemoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_QtyRemoved")]
    protected Info _QtyRemoved;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Info_Notes")]
    protected Info _Notes;

    public Info RemovalReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemovalReason));
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

    public Info RemoveDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveDifferenceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemoveDifferenceReason));
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

    public Info Qty2Removed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Removed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Removed));
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

    public Info RemoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemoveAllQty));
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

    public Info QtyRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemoved), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRemoved));
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

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
