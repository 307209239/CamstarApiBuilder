// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingLotTxn_Environment
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
  public class SamplingLotTxn_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_SamplingLot")]
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, false, "NamedObjectRef", 16777719, false, false, true, null)]
    protected Environment _SamplingLot;
    [Metadata("Data used to track the current sample data for each sample test required for a SamplingLot.", "LotSampleData", false, false, true, "LotSampleData", 16777727, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_LotSampleData")]
    protected LotSampleData_Environment _LotSampleData;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_SamplingPlan")]
    protected new Environment _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_AllowAdjustToLotSize")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777720, false, false, false, "0")]
    protected Environment _AllowAdjustToLotSize;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_SampleRate")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053107, false, false, false, null)]
    protected Environment _SampleRate;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_Containers")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048623, false, true, false, null)]
    protected Environment _Containers;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "SamplingLotTxn_Environment_LotName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777726, false, false, false, null)]
    protected Environment _LotName;

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public LotSampleData_Environment LotSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleData), (object) value);
      }
      get
      {
        return (LotSampleData_Environment) this.PropertyGet(nameof (LotSampleData));
      }
    }

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

    public Environment AllowAdjustToLotSize
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

    public Environment SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Environment Qty
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

    public Environment Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Containers));
      }
    }

    public Environment Product
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

    public Environment LotName
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
  }
}
