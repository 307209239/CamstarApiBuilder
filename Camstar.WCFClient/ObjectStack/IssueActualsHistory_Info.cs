// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (IssueActualsHistoryQuantity_Info))]
  [KnownType(typeof (IssueActualsHistoryBulk_Info))]
  [KnownType(typeof (IssueActualsHistoryStock_Info))]
  [KnownType(typeof (IssueActualsHistorySerial_Info))]
  [KnownType(typeof (IssueActualsHistoryLotStock_Info))]
  [Serializable]
  public class IssueActualsHistory_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_IssueReason")]
    protected Info _IssueReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_SubstitutionReason")]
    protected Info _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_Qty2Issued")]
    protected Info _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_ToContainer")]
    protected Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_IssuedFrom")]
    protected Info _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_DefectsRecorded")]
    protected Info _DefectsRecorded;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_ManualOverride")]
    protected Info _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_IsAutoWeightEntry")]
    protected Info _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_QtyIssued")]
    protected Info _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Info_Resource")]
    protected Info _Resource;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public Info IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Info DefectsRecorded
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectsRecorded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefectsRecorded));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
