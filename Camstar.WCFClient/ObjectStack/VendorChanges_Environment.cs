// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VendorChanges_Environment
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
  public class VendorChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItemChanges", false, false, false, "VendorItemChanges", 1049830, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Environment_VendorItemItem")]
    protected VendorItemChanges_Environment _VendorItemItem;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItemChanges", false, false, false, "VendorItemChanges", 1049439, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Environment_VendorItems")]
    protected VendorItemChanges_Environment _VendorItems;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Environment_ObjectToChange")]
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050128, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Environment_Name")]
    protected new Environment _Name;

    public VendorItemChanges_Environment VendorItemItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItemItem), (object) value);
      }
      get
      {
        return (VendorItemChanges_Environment) this.PropertyGet(nameof (VendorItemItem));
      }
    }

    public VendorItemChanges_Environment VendorItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItems), (object) value);
      }
      get
      {
        return (VendorItemChanges_Environment) this.PropertyGet(nameof (VendorItems));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
