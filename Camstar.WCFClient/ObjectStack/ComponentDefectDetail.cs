// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefectDetail
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
  public class ComponentDefectDetail : DefectDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_ActualComponentIssue")]
    protected IssueActualsHistory _ActualComponentIssue;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_ReasonCode")]
    protected new NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_StockPoint")]
    protected Primitive<string> _StockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_VendorItem")]
    protected Primitive<string> _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is ComponentDefectDetail && object.Equals((object) this._ActualComponentIssue, (object) ((ComponentDefectDetail) obj)._ActualComponentIssue) && (object.Equals((object) this._ReasonCode, (object) ((ComponentDefectDetail) obj)._ReasonCode) && object.Equals((object) this._ReferenceDesignator, (object) ((ComponentDefectDetail) obj)._ReferenceDesignator)) && (object.Equals((object) this._StockPoint, (object) ((ComponentDefectDetail) obj)._StockPoint) && object.Equals((object) this._VendorItem, (object) ((ComponentDefectDetail) obj)._VendorItem) && (object.Equals((object) this._Lot, (object) ((ComponentDefectDetail) obj)._Lot) && object.Equals((object) this._Container, (object) ((ComponentDefectDetail) obj)._Container))) && object.Equals((object) this._Product, (object) ((ComponentDefectDetail) obj)._Product) && base.Equals(obj);
    }

    public IssueActualsHistory ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (IssueActualsHistory) this.PropertyGet(nameof (ActualComponentIssue));
      }
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
