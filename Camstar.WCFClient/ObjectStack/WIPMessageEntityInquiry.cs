// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMessageEntityInquiry
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
  public class WIPMessageEntityInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_ProductFamily")]
    protected NamedObjectRef _ProductFamily;
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is WIPMessageEntityInquiry && object.Equals((object) this._Container, (object) ((WIPMessageEntityInquiry) obj)._Container) && (object.Equals((object) this._ProductFamily, (object) ((WIPMessageEntityInquiry) obj)._ProductFamily) && object.Equals((object) this._Resource, (object) ((WIPMessageEntityInquiry) obj)._Resource)) && object.Equals((object) this._Product, (object) ((WIPMessageEntityInquiry) obj)._Product) && base.Equals(obj);
    }

    public ContainerRef Container
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

    public NamedObjectRef ProductFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFamily), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ProductFamily));
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
