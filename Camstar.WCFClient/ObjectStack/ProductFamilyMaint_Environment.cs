// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductFamilyMaint_Environment
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
  public class ProductFamilyMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Changes CDO for ProductFamily.", "ProductFamilyChanges", false, false, false, "ProductFamilyChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyMaint_Environment_ObjectChanges")]
    protected ProductFamilyChanges_Environment _ObjectChanges;
    [Metadata("A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Each Product can belong to a Product Family. Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.\r\n\r\nProduct Families are a slightly different concept from object groups. Grouping (Product bases, Operations, Resources, etc.) is done for validation and reporting. Groups are more free form and the application has less concrete knowledge of Groups (than Product Families). Another differentiation is that one object can belong to multiple Groups, but a product can only belong to one Product Family. Finally, Groups can contain other (sub-) Groups. Product Families can only contain Products.", "ProductFamily", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Each Product can belong to a Product Family. Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.\r\n\r\nProduct Families are a slightly different concept from object groups. Grouping (Product bases, Operations, Resources, etc.) is done for validation and reporting. Groups are more free form and the application has less concrete knowledge of Groups (than Product Families). Another differentiation is that one object can belong to multiple Groups, but a product can only belong to one Product Family. Finally, Groups can contain other (sub-) Groups. Product Families can only contain Products.", "ProductFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public ProductFamilyChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProductFamilyChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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
  }
}
