// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefectHistoryDetail
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
  public class ComponentDefectHistoryDetail : DefectHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_ReasonCode")]
    protected new NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_ActualComponentIssue")]
    protected SubentityRef _ActualComponentIssue;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_StockPoint")]
    protected Primitive<string> _StockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_VendorItem")]
    protected Primitive<string> _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_DefectCount")]
    protected new Primitive<int> _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Comment")]
    protected new Primitive<string> _Comment;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is ComponentDefectHistoryDetail && object.Equals((object) this._ReasonCode, (object) ((ComponentDefectHistoryDetail) obj)._ReasonCode) && (object.Equals((object) this._ExportImportKey, (object) ((ComponentDefectHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._ActualComponentIssue, (object) ((ComponentDefectHistoryDetail) obj)._ActualComponentIssue)) && (object.Equals((object) this._StockPoint, (object) ((ComponentDefectHistoryDetail) obj)._StockPoint) && object.Equals((object) this._ReferenceDesignator, (object) ((ComponentDefectHistoryDetail) obj)._ReferenceDesignator) && (object.Equals((object) this._VendorItem, (object) ((ComponentDefectHistoryDetail) obj)._VendorItem) && object.Equals((object) this._HistoryId, (object) ((ComponentDefectHistoryDetail) obj)._HistoryId))) && (object.Equals((object) this._Lot, (object) ((ComponentDefectHistoryDetail) obj)._Lot) && object.Equals((object) this._DefectCount, (object) ((ComponentDefectHistoryDetail) obj)._DefectCount) && (object.Equals((object) this._Container, (object) ((ComponentDefectHistoryDetail) obj)._Container) && object.Equals((object) this._Comment, (object) ((ComponentDefectHistoryDetail) obj)._Comment)) && object.Equals((object) this._Product, (object) ((ComponentDefectHistoryDetail) obj)._Product)) && base.Equals(obj);
    }

    public new NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
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

    public SubentityRef ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ActualComponentIssue));
      }
    }

    public Primitive<string> StockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (StockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StockPoint));
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

    public Primitive<string> VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (VendorItem));
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

    public Primitive<string> Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Lot));
      }
    }

    public new Primitive<int> DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DefectCount));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public new Primitive<string> Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comment));
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
