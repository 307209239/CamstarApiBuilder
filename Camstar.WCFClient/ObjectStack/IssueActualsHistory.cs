// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (IssueActualsHistoryBulk))]
  [KnownType(typeof (IssueActualsHistoryQuantity))]
  [KnownType(typeof (IssueActualsHistorySerial))]
  [KnownType(typeof (IssueActualsHistoryLotStock))]
  [KnownType(typeof (IssueActualsHistoryStock))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class IssueActualsHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_IssueReason")]
    protected NamedObjectRef _IssueReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_SubstitutionReason")]
    protected NamedObjectRef _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Qty2Issued")]
    protected Primitive<double> _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_ToContainer")]
    protected ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_IssuedFrom")]
    protected Primitive<string> _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_DefectsRecorded")]
    protected Primitive<bool> _DefectsRecorded;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_ManualOverride")]
    protected Primitive<bool> _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_IsAutoWeightEntry")]
    protected Primitive<bool> _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_QtyIssued")]
    protected Primitive<double> _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is IssueActualsHistory && object.Equals((object) this._IssueDifferenceReason, (object) ((IssueActualsHistory) obj)._IssueDifferenceReason) && (object.Equals((object) this._VendorItem, (object) ((IssueActualsHistory) obj)._VendorItem) && object.Equals((object) this._IssueReason, (object) ((IssueActualsHistory) obj)._IssueReason)) && (object.Equals((object) this._ExportImportKey, (object) ((IssueActualsHistory) obj)._ExportImportKey) && object.Equals((object) this._SubstitutionReason, (object) ((IssueActualsHistory) obj)._SubstitutionReason) && (object.Equals((object) this._Qty2Issued, (object) ((IssueActualsHistory) obj)._Qty2Issued) && object.Equals((object) this._ReferenceDesignator, (object) ((IssueActualsHistory) obj)._ReferenceDesignator))) && (object.Equals((object) this._ToContainer, (object) ((IssueActualsHistory) obj)._ToContainer) && object.Equals((object) this._IssuedFrom, (object) ((IssueActualsHistory) obj)._IssuedFrom) && (object.Equals((object) this._DefectsRecorded, (object) ((IssueActualsHistory) obj)._DefectsRecorded) && object.Equals((object) this._HistoryId, (object) ((IssueActualsHistory) obj)._HistoryId)) && (object.Equals((object) this._ManualOverride, (object) ((IssueActualsHistory) obj)._ManualOverride) && object.Equals((object) this._IsAutoWeightEntry, (object) ((IssueActualsHistory) obj)._IsAutoWeightEntry) && (object.Equals((object) this._ToLocation, (object) ((IssueActualsHistory) obj)._ToLocation) && object.Equals((object) this._Notes, (object) ((IssueActualsHistory) obj)._Notes)))) && (object.Equals((object) this._ProductDescription, (object) ((IssueActualsHistory) obj)._ProductDescription) && object.Equals((object) this._Product, (object) ((IssueActualsHistory) obj)._Product) && (object.Equals((object) this._QtyIssued, (object) ((IssueActualsHistory) obj)._QtyIssued) && object.Equals((object) this._Resource, (object) ((IssueActualsHistory) obj)._Resource))) && base.Equals(obj);
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

    public Primitive<string> IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Primitive<bool> DefectsRecorded
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectsRecorded), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DefectsRecorded));
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

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
