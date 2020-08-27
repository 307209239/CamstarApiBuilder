// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActuals_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActualsLotStock_Info))]
  [KnownType(typeof (ActualsStock_Info))]
  [KnownType(typeof (ActualsDisplayOnly_Info))]
  [KnownType(typeof (ActualsBulk_Info))]
  [KnownType(typeof (ActualsQuantity_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ActualsSerial_Info))]
  [Serializable]
  public class IssueActuals_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_SubstitutionReason")]
    protected Info _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_Qty2Issued")]
    protected Info _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_IssueReason")]
    protected Info _IssueReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_IssueActualsHistory")]
    protected Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_Scale")]
    protected Info _Scale;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_ManualOverride")]
    protected Info _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_IsAutoWeightEntry")]
    protected Info _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_ToContainer")]
    protected Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_QtyIssued")]
    protected Info _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Info_ProductDescription")]
    protected Info _ProductDescription;

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

    public Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualsHistory));
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
  }
}
