// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerStartDetails
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
  public class MaterialContainerStartDetails : StartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_PlannedQtyUOM")]
    protected new NamedObjectRef _PlannedQtyUOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_StartReason")]
    protected new NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Customer")]
    protected new NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Batch")]
    protected ContainerRef _Batch;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_RecipeList")]
    protected RevisionedObjectRef _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_DueDate")]
    protected new Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_PlannedProduct")]
    protected new RevisionedObjectRef _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_PriorityCode")]
    protected new NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_PlannedQty")]
    protected new Primitive<double> _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_ContainerName")]
    protected new Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStartDetails_Level")]
    protected new NamedObjectRef _Level;

    public override bool Equals(object obj)
    {
      return obj is MaterialContainerStartDetails && object.Equals((object) this._PlannedQtyUOM, (object) ((MaterialContainerStartDetails) obj)._PlannedQtyUOM) && (object.Equals((object) this._StartReason, (object) ((MaterialContainerStartDetails) obj)._StartReason) && object.Equals((object) this._UOM, (object) ((MaterialContainerStartDetails) obj)._UOM)) && (object.Equals((object) this._Customer, (object) ((MaterialContainerStartDetails) obj)._Customer) && object.Equals((object) this._Qty2, (object) ((MaterialContainerStartDetails) obj)._Qty2) && (object.Equals((object) this._Batch, (object) ((MaterialContainerStartDetails) obj)._Batch) && object.Equals((object) this._RecipeList, (object) ((MaterialContainerStartDetails) obj)._RecipeList))) && (object.Equals((object) this._Container, (object) ((MaterialContainerStartDetails) obj)._Container) && object.Equals((object) this._DueDate, (object) ((MaterialContainerStartDetails) obj)._DueDate) && (object.Equals((object) this._PlannedProduct, (object) ((MaterialContainerStartDetails) obj)._PlannedProduct) && object.Equals((object) this._PriorityCode, (object) ((MaterialContainerStartDetails) obj)._PriorityCode)) && (object.Equals((object) this._Owner, (object) ((MaterialContainerStartDetails) obj)._Owner) && object.Equals((object) this._Product, (object) ((MaterialContainerStartDetails) obj)._Product) && (object.Equals((object) this._Qty, (object) ((MaterialContainerStartDetails) obj)._Qty) && object.Equals((object) this._MfgOrder, (object) ((MaterialContainerStartDetails) obj)._MfgOrder)))) && (object.Equals((object) this._PlannedQty, (object) ((MaterialContainerStartDetails) obj)._PlannedQty) && object.Equals((object) this._ContainerName, (object) ((MaterialContainerStartDetails) obj)._ContainerName) && object.Equals((object) this._Level, (object) ((MaterialContainerStartDetails) obj)._Level)) && base.Equals(obj);
    }

    public new NamedObjectRef PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public new NamedObjectRef StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartReason));
      }
    }

    public new NamedObjectRef UOM
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

    public new NamedObjectRef Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Customer));
      }
    }

    public new Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public ContainerRef Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Batch));
      }
    }

    public RevisionedObjectRef RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RecipeList));
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

    public new Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public new RevisionedObjectRef PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PlannedProduct));
      }
    }

    public new NamedObjectRef PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public new RevisionedObjectRef Product
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

    public new Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public new NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public new Primitive<double> PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public new Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new NamedObjectRef Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Level));
      }
    }
  }
}
