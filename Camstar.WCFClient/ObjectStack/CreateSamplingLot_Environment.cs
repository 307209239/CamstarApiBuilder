// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateSamplingLot_Environment
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
  public class CreateSamplingLot_Environment : SamplingLotTxn_Environment
  {
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Environment_SamplingPlan")]
    protected new Environment _SamplingPlan;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777734, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Environment_AllowAdjustToLotSize")]
    protected new Environment _AllowAdjustToLotSize;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16777726, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Environment_LotName")]
    protected new Environment _LotName;
    [Metadata("Material quantity (individual)", "", false, true, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Environment_Qty")]
    protected new Environment _Qty;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, true, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateSamplingLot_Environment_Product")]
    protected new Environment _Product;

    public new Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public new Environment AllowAdjustToLotSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAdjustToLotSize), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowAdjustToLotSize));
      }
    }

    public new Environment LotName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotName));
      }
    }

    public new Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public new Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }
  }
}
