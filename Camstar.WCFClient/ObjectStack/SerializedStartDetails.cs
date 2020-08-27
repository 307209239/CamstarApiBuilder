// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializedStartDetails
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
  public class SerializedStartDetails : StartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Customer")]
    protected new NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_BOM")]
    protected new RevisionedObjectRef _BOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_StartReason")]
    protected new NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Qty2")]
    protected new Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_RequestDate")]
    protected new Primitive<DateTime> _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_DueDate")]
    protected new Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Qty")]
    protected new Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_PriorityCode")]
    protected new NamedObjectRef _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_ContainerName")]
    protected new Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_ContainerComment")]
    protected new Primitive<string> _ContainerComment;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Level")]
    protected new NamedObjectRef _Level;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "SerializedStartDetails_SalesOrder")]
    protected new NamedObjectRef _SalesOrder;

    public override bool Equals(object obj)
    {
      return obj is SerializedStartDetails && object.Equals((object) this._Customer, (object) ((SerializedStartDetails) obj)._Customer) && (object.Equals((object) this._BOM, (object) ((SerializedStartDetails) obj)._BOM) && object.Equals((object) this._UOM2, (object) ((SerializedStartDetails) obj)._UOM2)) && (object.Equals((object) this._UOM, (object) ((SerializedStartDetails) obj)._UOM) && object.Equals((object) this._StartReason, (object) ((SerializedStartDetails) obj)._StartReason) && (object.Equals((object) this._Qty2, (object) ((SerializedStartDetails) obj)._Qty2) && object.Equals((object) this._RequestDate, (object) ((SerializedStartDetails) obj)._RequestDate))) && (object.Equals((object) this._DueDate, (object) ((SerializedStartDetails) obj)._DueDate) && object.Equals((object) this._Qty, (object) ((SerializedStartDetails) obj)._Qty) && (object.Equals((object) this._PriorityCode, (object) ((SerializedStartDetails) obj)._PriorityCode) && object.Equals((object) this._ContainerName, (object) ((SerializedStartDetails) obj)._ContainerName)) && (object.Equals((object) this._Owner, (object) ((SerializedStartDetails) obj)._Owner) && object.Equals((object) this._MfgOrder, (object) ((SerializedStartDetails) obj)._MfgOrder) && (object.Equals((object) this._ContainerComment, (object) ((SerializedStartDetails) obj)._ContainerComment) && object.Equals((object) this._Level, (object) ((SerializedStartDetails) obj)._Level)))) && (object.Equals((object) this._Product, (object) ((SerializedStartDetails) obj)._Product) && object.Equals((object) this._SalesOrder, (object) ((SerializedStartDetails) obj)._SalesOrder)) && base.Equals(obj);
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

    public new RevisionedObjectRef BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BOM));
      }
    }

    public new NamedObjectRef UOM2
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

    public new Primitive<DateTime> RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RequestDate));
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

    public new Primitive<string> ContainerComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerComment));
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

    public new NamedObjectRef SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SalesOrder));
      }
    }
  }
}
