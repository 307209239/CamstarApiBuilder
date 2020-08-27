// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductChanges_Info
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
  public class ProductChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ERPRoute")]
    protected Info _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_VendorItemsInquiry")]
    protected Info _VendorItemsInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_BillOfProcess")]
    protected Info _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_VendorItems")]
    protected Info _VendorItems;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_StdStartUOM")]
    protected Info _StdStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ERPBOM")]
    protected Info _ERPBOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_VendorInquiry")]
    protected Info _VendorInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_FEFOOverrideESigRequirement")]
    protected Info _FEFOOverrideESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_StdStartQty2")]
    protected Info _StdStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_BOM")]
    protected Info _BOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_StdStartUOM2")]
    protected Info _StdStartUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_Attributes")]
    protected UserAttributeChanges_Info _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ContainerNumberingRule")]
    protected Info _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_FEFOEnforce")]
    protected Info _FEFOEnforce;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_SerialControlled")]
    protected Info _SerialControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_LotControlled")]
    protected Info _LotControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_DeviceType")]
    protected Info _DeviceType;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_IsPhantom")]
    protected Info _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_InventoryControlled")]
    protected Info _InventoryControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_InspectAll")]
    protected Info _InspectAll;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_StockPointControlled")]
    protected Info _StockPointControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_TargetUnitsPerHour")]
    protected Info _TargetUnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ConcomitantProductNumber")]
    protected Info _ConcomitantProductNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ModelNumber")]
    protected Info _ModelNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_CatalogNumber")]
    protected Info _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_BrandName")]
    protected Info _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ProductVariation")]
    protected Info _ProductVariation;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ExternallyControlled")]
    protected Info _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ProductFamily")]
    protected Info _ProductFamily;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_StdStartQty")]
    protected Info _StdStartQty;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_TargetRolledThroughputYield")]
    protected Info _TargetRolledThroughputYield;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_TargetFinalYield")]
    protected Info _TargetFinalYield;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_SubFactory")]
    protected Info _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_Substitutes")]
    protected Info _Substitutes;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_TargetDurationPerUnit")]
    protected Info _TargetDurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_ProductType")]
    protected Info _ProductType;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_PlannedCost")]
    protected Info _PlannedCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_TargetCycleTime")]
    protected Info _TargetCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_CustomerProductNumber")]
    protected Info _CustomerProductNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_CurrentCost")]
    protected Info _CurrentCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_GLEntity")]
    protected Info _GLEntity;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Info_StdCost")]
    protected Info _StdCost;

    public Info ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public Info VendorItemsInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItemsInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorItemsInquiry));
      }
    }

    public Info BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public Info VendorItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItems), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorItems));
      }
    }

    public Info StdStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartUOM));
      }
    }

    public Info ERPBOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPBOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPBOM));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info VendorInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorInquiry));
      }
    }

    public Info FEFOOverrideESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOOverrideESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FEFOOverrideESigRequirement));
      }
    }

    public Info StdStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartQty2));
      }
    }

    public Info BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BOM));
      }
    }

    public Info Customer
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

    public Info StdStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartUOM2));
      }
    }

    public Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public UserAttributeChanges_Info Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges_Info) this.PropertyGet(nameof (Attributes));
      }
    }

    public Info ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Info FEFOEnforce
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOEnforce), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FEFOEnforce));
      }
    }

    public Info SerialControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (SerialControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SerialControlled));
      }
    }

    public Info LotControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotControlled));
      }
    }

    public Info DeviceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceType));
      }
    }

    public Info IsPhantom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPhantom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsPhantom));
      }
    }

    public Info InventoryControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (InventoryControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InventoryControlled));
      }
    }

    public Info InspectAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAll), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectAll));
      }
    }

    public Info StockPointControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (StockPointControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StockPointControlled));
      }
    }

    public Info TargetUnitsPerHour
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetUnitsPerHour), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetUnitsPerHour));
      }
    }

    public Info ConcomitantProductNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConcomitantProductNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ConcomitantProductNumber));
      }
    }

    public Info ModelNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelNumber));
      }
    }

    public Info CatalogNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatalogNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CatalogNumber));
      }
    }

    public Info BrandName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrandName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BrandName));
      }
    }

    public Info ProductVariation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductVariation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductVariation));
      }
    }

    public Info ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
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

    public Info StdStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartQty));
      }
    }

    public Info TargetRolledThroughputYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetRolledThroughputYield), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetRolledThroughputYield));
      }
    }

    public Info TargetFinalYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetFinalYield), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetFinalYield));
      }
    }

    public Info SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubFactory));
      }
    }

    public Info Substitutes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Substitutes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Substitutes));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info TargetDurationPerUnit
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDurationPerUnit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetDurationPerUnit));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info ProductType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductType));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info PlannedCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedCost));
      }
    }

    public Info TargetCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetCycleTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetCycleTime));
      }
    }

    public Info CustomerProductNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerProductNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerProductNumber));
      }
    }

    public Info CurrentCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentCost));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info GLEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (GLEntity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GLEntity));
      }
    }

    public Info StdCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdCost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdCost));
      }
    }
  }
}
