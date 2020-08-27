// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMessageEntityInquiry_Info
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
  public class WIPMessageEntityInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Info_ProductFamily")]
    protected Info _ProductFamily;
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "WIPMessageEntityInquiry_Info_Product")]
    protected Info _Product;

    public Info Container
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

    public Info ProductFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFamily), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductFamily));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
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
