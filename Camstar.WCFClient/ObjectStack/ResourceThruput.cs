// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceThruput
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
  public class ResourceThruput : ResourceTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_Run")]
    protected Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ResourceThruput_Setup")]
    protected RevisionedObjectRef _Setup;

    public override bool Equals(object obj)
    {
      return obj is ResourceThruput && object.Equals((object) this._ResourceGroup, (object) ((ResourceThruput) obj)._ResourceGroup) && (object.Equals((object) this._UOM2, (object) ((ResourceThruput) obj)._UOM2) && object.Equals((object) this._Qty2, (object) ((ResourceThruput) obj)._Qty2)) && (object.Equals((object) this._UOM, (object) ((ResourceThruput) obj)._UOM) && object.Equals((object) this._MfgOrder, (object) ((ResourceThruput) obj)._MfgOrder) && (object.Equals((object) this._Resource, (object) ((ResourceThruput) obj)._Resource) && object.Equals((object) this._Product, (object) ((ResourceThruput) obj)._Product))) && (object.Equals((object) this._Run, (object) ((ResourceThruput) obj)._Run) && object.Equals((object) this._Qty, (object) ((ResourceThruput) obj)._Qty) && object.Equals((object) this._Setup, (object) ((ResourceThruput) obj)._Setup)) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
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

    public Primitive<double> Qty2
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

    public new NamedObjectRef Resource
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

    public Primitive<string> Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Run));
      }
    }

    public Primitive<double> Qty
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

    public RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }
  }
}
