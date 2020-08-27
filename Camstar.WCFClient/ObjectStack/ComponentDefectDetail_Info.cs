// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefectDetail_Info
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
  public class ComponentDefectDetail_Info : DefectDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_ActualComponentIssue")]
    protected IssueActualsHistory_Info _ActualComponentIssue;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_ReasonCode")]
    protected new Info _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_StockPoint")]
    protected Info _StockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Info_Product")]
    protected Info _Product;

    public IssueActualsHistory_Info ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Info) this.PropertyGet(nameof (ActualComponentIssue));
      }
    }

    public new Info ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCode));
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

    public Info StockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (StockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StockPoint));
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

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
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
  }
}
