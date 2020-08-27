// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceHistoryDetail
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
  public class ComponentReplaceHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_RemovalDetails")]
    protected SubentityRef _RemovalDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Actuals")]
    protected IssueActualsHistory[] _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Qty2Required")]
    protected Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_SubstitutionReason")]
    protected NamedObjectRef _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_IssueDetails")]
    protected SubentityRef _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_VendorItem")]
    protected NamedSubentityRef _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Qty2Removed")]
    protected Primitive<double> _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_ReplaceReason")]
    protected NamedObjectRef _ReplaceReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_IsScrapReplaced")]
    protected Primitive<bool> _IsScrapReplaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_ActualQty2Issued")]
    protected Primitive<double> _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_ActualQtyIssued")]
    protected Primitive<double> _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_IssueControl")]
    protected Primitive<int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_QtyRemoved")]
    protected Primitive<double> _QtyRemoved;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_QtyRequired")]
    protected Primitive<double> _QtyRequired;

    public override bool Equals(object obj)
    {
      return obj is ComponentReplaceHistoryDetail && object.Equals((object) this._UOM2, (object) ((ComponentReplaceHistoryDetail) obj)._UOM2) && (object.Equals((object) this._RemovalDetails, (object) ((ComponentReplaceHistoryDetail) obj)._RemovalDetails) && this.CompareArrays((Array) this._Actuals, (Array) ((ComponentReplaceHistoryDetail) obj)._Actuals)) && (object.Equals((object) this._Qty2Required, (object) ((ComponentReplaceHistoryDetail) obj)._Qty2Required) && object.Equals((object) this._BOMLineItem, (object) ((ComponentReplaceHistoryDetail) obj)._BOMLineItem) && (object.Equals((object) this._SubstitutionReason, (object) ((ComponentReplaceHistoryDetail) obj)._SubstitutionReason) && object.Equals((object) this._ExportImportKey, (object) ((ComponentReplaceHistoryDetail) obj)._ExportImportKey))) && (object.Equals((object) this._IssueDetails, (object) ((ComponentReplaceHistoryDetail) obj)._IssueDetails) && object.Equals((object) this._UOM, (object) ((ComponentReplaceHistoryDetail) obj)._UOM) && (object.Equals((object) this._VendorItem, (object) ((ComponentReplaceHistoryDetail) obj)._VendorItem) && object.Equals((object) this._Qty2Removed, (object) ((ComponentReplaceHistoryDetail) obj)._Qty2Removed)) && (object.Equals((object) this._ReplaceReason, (object) ((ComponentReplaceHistoryDetail) obj)._ReplaceReason) && object.Equals((object) this._IsScrapReplaced, (object) ((ComponentReplaceHistoryDetail) obj)._IsScrapReplaced) && (object.Equals((object) this._ReferenceDesignator, (object) ((ComponentReplaceHistoryDetail) obj)._ReferenceDesignator) && object.Equals((object) this._ActualQty2Issued, (object) ((ComponentReplaceHistoryDetail) obj)._ActualQty2Issued)))) && (object.Equals((object) this._ActualQtyIssued, (object) ((ComponentReplaceHistoryDetail) obj)._ActualQtyIssued) && object.Equals((object) this._IssueControl, (object) ((ComponentReplaceHistoryDetail) obj)._IssueControl) && (object.Equals((object) this._HistoryId, (object) ((ComponentReplaceHistoryDetail) obj)._HistoryId) && object.Equals((object) this._QtyRemoved, (object) ((ComponentReplaceHistoryDetail) obj)._QtyRemoved)) && (object.Equals((object) this._Notes, (object) ((ComponentReplaceHistoryDetail) obj)._Notes) && object.Equals((object) this._Product, (object) ((ComponentReplaceHistoryDetail) obj)._Product) && object.Equals((object) this._QtyRequired, (object) ((ComponentReplaceHistoryDetail) obj)._QtyRequired))) && base.Equals(obj);
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

    public SubentityRef RemovalDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetails), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (RemovalDetails));
      }
    }

    public IssueActualsHistory[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActualsHistory[]) this.PropertyGet(nameof (Actuals));
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

    public SubentityRef IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueDetails));
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

    public Primitive<double> ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public Primitive<double> ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQtyIssued));
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
  }
}
