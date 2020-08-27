// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueHistoryDetail
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
  public class IssueHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Actuals")]
    protected IssueActualsHistory[] _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Qty2Required")]
    protected Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_ActualQty2Issued")]
    protected Primitive<double> _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_IssueControl")]
    protected Primitive<int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_AllowManualWeighOverride")]
    protected Primitive<bool> _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_IsManualReadingOnly")]
    protected Primitive<bool> _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_CloseWhenEmpty")]
    protected Primitive<bool> _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_ActualQtyIssued")]
    protected Primitive<double> _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_QtyUpperLimit")]
    protected Primitive<double> _QtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_QtyLowerLimit")]
    protected Primitive<double> _QtyLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_QtyRequired")]
    protected Primitive<double> _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Notes")]
    protected Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is IssueHistoryDetail && object.Equals((object) this._BOMLineItem, (object) ((IssueHistoryDetail) obj)._BOMLineItem) && (this.CompareArrays((Array) this._Actuals, (Array) ((IssueHistoryDetail) obj)._Actuals) && object.Equals((object) this._ExportImportKey, (object) ((IssueHistoryDetail) obj)._ExportImportKey)) && (object.Equals((object) this._UOM, (object) ((IssueHistoryDetail) obj)._UOM) && object.Equals((object) this._UOM2, (object) ((IssueHistoryDetail) obj)._UOM2) && (object.Equals((object) this._IssueDifferenceReason, (object) ((IssueHistoryDetail) obj)._IssueDifferenceReason) && object.Equals((object) this._Qty2Required, (object) ((IssueHistoryDetail) obj)._Qty2Required))) && (object.Equals((object) this._ActualQty2Issued, (object) ((IssueHistoryDetail) obj)._ActualQty2Issued) && object.Equals((object) this._ReferenceDesignator, (object) ((IssueHistoryDetail) obj)._ReferenceDesignator) && (object.Equals((object) this._IssueControl, (object) ((IssueHistoryDetail) obj)._IssueControl) && object.Equals((object) this._HistoryId, (object) ((IssueHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._AllowManualWeighOverride, (object) ((IssueHistoryDetail) obj)._AllowManualWeighOverride) && object.Equals((object) this._IsManualReadingOnly, (object) ((IssueHistoryDetail) obj)._IsManualReadingOnly) && (object.Equals((object) this._CloseWhenEmpty, (object) ((IssueHistoryDetail) obj)._CloseWhenEmpty) && object.Equals((object) this._Product, (object) ((IssueHistoryDetail) obj)._Product)))) && (object.Equals((object) this._ActualQtyIssued, (object) ((IssueHistoryDetail) obj)._ActualQtyIssued) && object.Equals((object) this._QtyUpperLimit, (object) ((IssueHistoryDetail) obj)._QtyUpperLimit) && (object.Equals((object) this._QtyLowerLimit, (object) ((IssueHistoryDetail) obj)._QtyLowerLimit) && object.Equals((object) this._QtyRequired, (object) ((IssueHistoryDetail) obj)._QtyRequired)) && object.Equals((object) this._Notes, (object) ((IssueHistoryDetail) obj)._Notes)) && base.Equals(obj);
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

    public Primitive<bool> AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Primitive<bool> IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsManualReadingOnly));
      }
    }

    public Primitive<bool> CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenEmpty));
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

    public Primitive<double> QtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyUpperLimit));
      }
    }

    public Primitive<double> QtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyLowerLimit));
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
