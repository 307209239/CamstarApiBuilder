// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualDetail_Info
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
  public class IssueActualDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_BOMLineItem")]
    protected Info _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_SubstitutionReason")]
    protected Info _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_Qty2Issued")]
    protected Info _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_IssueReason")]
    protected Info _IssueReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_Scale")]
    protected Info _Scale;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_FromBatch")]
    protected Info _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_FromCarrier")]
    protected Info _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_ToContainer")]
    protected Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_UniqueID")]
    protected Info _UniqueID;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_FromContainer")]
    protected Info _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_ManualOverride")]
    protected Info _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_IsAutoWeightEntry")]
    protected Info _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_FromStockPoint")]
    protected Info _FromStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_FromLot")]
    protected Info _FromLot;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_QtyIssued")]
    protected Info _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualDetail_Info_FromLocation")]
    protected Info _FromLocation;

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

    public Info IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

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

    public Info IssueReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueReason));
      }
    }

    public Info Scale
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scale), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Scale));
      }
    }

    public Info FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromBatch));
      }
    }

    public Info FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public Info ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainer));
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

    public Info FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Info ManualOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualOverride), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ManualOverride));
      }
    }

    public Info IsAutoWeightEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAutoWeightEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsAutoWeightEntry));
      }
    }

    public Info FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStockPoint));
      }
    }

    public Info FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLot));
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

    public Info ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToLocation));
      }
    }

    public Info FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}
