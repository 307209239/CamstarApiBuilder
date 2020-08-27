// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerStartDetails_Info
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
  public class MaterialContainerStartDetails_Info : StartDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_PlannedQtyUOM")]
    protected new Info _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_StartReason")]
    protected new Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Customer")]
    protected new Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Batch")]
    protected Info _Batch;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_RecipeList")]
    protected Info _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_DueDate")]
    protected new Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_PlannedProduct")]
    protected new Info _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_PriorityCode")]
    protected new Info _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_MfgOrder")]
    protected new Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_PlannedQty")]
    protected new Info _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_ContainerName")]
    protected new Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Info_Level")]
    protected new Info _Level;

    public new Info PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public new Info StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartReason));
      }
    }

    public new Info UOM
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

    public new Info Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Customer));
      }
    }

    public new Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public Info Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Batch));
      }
    }

    public Info RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeList));
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

    public new Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
      }
    }

    public new Info PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedProduct));
      }
    }

    public new Info PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public new Info Product
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

    public new Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public new Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public new Info PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public new Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new Info Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Level));
      }
    }
  }
}
