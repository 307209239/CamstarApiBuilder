// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductChanges
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
  public class ProductChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ERPRoute")]
    protected RevisionedObjectRef _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_VendorItemsInquiry")]
    protected NamedSubentityRef[] _VendorItemsInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_BillOfProcess")]
    protected RevisionedObjectRef _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_VendorItems")]
    protected NamedSubentityRef[] _VendorItems;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_StdStartUOM")]
    protected NamedObjectRef _StdStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ERPBOM")]
    protected RevisionedObjectRef _ERPBOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_VendorInquiry")]
    protected NamedObjectRef _VendorInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_FEFOOverrideESigRequirement")]
    protected NamedObjectRef _FEFOOverrideESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_StdStartQty2")]
    protected Primitive<double> _StdStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_BOM")]
    protected RevisionedObjectRef _BOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_StdStartUOM2")]
    protected NamedObjectRef _StdStartUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Attributes")]
    protected UserAttributeChanges[] _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ContainerNumberingRule")]
    protected NamedObjectRef _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_FEFOEnforce")]
    protected Enumeration<FEFOEnum, int> _FEFOEnforce;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_SerialControlled")]
    protected Primitive<bool> _SerialControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_LotControlled")]
    protected Primitive<bool> _LotControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_DeviceType")]
    protected Primitive<string> _DeviceType;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_IsPhantom")]
    protected Primitive<bool> _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_InventoryControlled")]
    protected Primitive<bool> _InventoryControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_InspectAll")]
    protected Primitive<bool> _InspectAll;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_StockPointControlled")]
    protected Primitive<bool> _StockPointControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_TargetUnitsPerHour")]
    protected Primitive<double> _TargetUnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ConcomitantProductNumber")]
    protected Primitive<string> _ConcomitantProductNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ModelNumber")]
    protected Primitive<string> _ModelNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_CatalogNumber")]
    protected Primitive<string> _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_BrandName")]
    protected Primitive<string> _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ProductVariation")]
    protected Primitive<string> _ProductVariation;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ExternallyControlled")]
    protected Primitive<bool> _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ProductFamily")]
    protected NamedObjectRef _ProductFamily;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_StdStartQty")]
    protected Primitive<double> _StdStartQty;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_TargetRolledThroughputYield")]
    protected Primitive<double> _TargetRolledThroughputYield;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_TargetFinalYield")]
    protected Primitive<double> _TargetFinalYield;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_SubFactory")]
    protected Primitive<string> _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Substitutes")]
    protected RevisionedObjectRef[] _Substitutes;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_TargetDurationPerUnit")]
    protected Primitive<double> _TargetDurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_ProductType")]
    protected NamedObjectRef _ProductType;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_PlannedCost")]
    protected Primitive<double> _PlannedCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_TargetCycleTime")]
    protected Primitive<double> _TargetCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_CustomerProductNumber")]
    protected Primitive<string> _CustomerProductNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_CurrentCost")]
    protected Primitive<double> _CurrentCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_GLEntity")]
    protected Primitive<string> _GLEntity;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_StdCost")]
    protected Primitive<double> _StdCost;

    public override bool Equals(object obj)
    {
      return obj is ProductChanges && object.Equals((object) this._ERPRoute, (object) ((ProductChanges) obj)._ERPRoute) && (this.CompareArrays((Array) this._VendorItemsInquiry, (Array) ((ProductChanges) obj)._VendorItemsInquiry) && object.Equals((object) this._BillOfProcess, (object) ((ProductChanges) obj)._BillOfProcess)) && (this.CompareArrays((Array) this._VendorItems, (Array) ((ProductChanges) obj)._VendorItems) && object.Equals((object) this._StdStartUOM, (object) ((ProductChanges) obj)._StdStartUOM) && (object.Equals((object) this._ERPBOM, (object) ((ProductChanges) obj)._ERPBOM) && object.Equals((object) this._TrainingReqGroup, (object) ((ProductChanges) obj)._TrainingReqGroup))) && (object.Equals((object) this._VendorInquiry, (object) ((ProductChanges) obj)._VendorInquiry) && object.Equals((object) this._FEFOOverrideESigRequirement, (object) ((ProductChanges) obj)._FEFOOverrideESigRequirement) && (object.Equals((object) this._StdStartQty2, (object) ((ProductChanges) obj)._StdStartQty2) && object.Equals((object) this._BOM, (object) ((ProductChanges) obj)._BOM)) && (object.Equals((object) this._Customer, (object) ((ProductChanges) obj)._Customer) && object.Equals((object) this._StdStartUOM2, (object) ((ProductChanges) obj)._StdStartUOM2) && (object.Equals((object) this._SamplingPlan, (object) ((ProductChanges) obj)._SamplingPlan) && this.CompareArrays((Array) this._Attributes, (Array) ((ProductChanges) obj)._Attributes)))) && (object.Equals((object) this._ContainerNumberingRule, (object) ((ProductChanges) obj)._ContainerNumberingRule) && object.Equals((object) this._FEFOEnforce, (object) ((ProductChanges) obj)._FEFOEnforce) && (object.Equals((object) this._SerialControlled, (object) ((ProductChanges) obj)._SerialControlled) && object.Equals((object) this._LotControlled, (object) ((ProductChanges) obj)._LotControlled)) && (object.Equals((object) this._DeviceType, (object) ((ProductChanges) obj)._DeviceType) && object.Equals((object) this._IsPhantom, (object) ((ProductChanges) obj)._IsPhantom) && (object.Equals((object) this._InventoryControlled, (object) ((ProductChanges) obj)._InventoryControlled) && object.Equals((object) this._InspectAll, (object) ((ProductChanges) obj)._InspectAll))) && (object.Equals((object) this._StockPointControlled, (object) ((ProductChanges) obj)._StockPointControlled) && object.Equals((object) this._TargetUnitsPerHour, (object) ((ProductChanges) obj)._TargetUnitsPerHour) && (object.Equals((object) this._ConcomitantProductNumber, (object) ((ProductChanges) obj)._ConcomitantProductNumber) && object.Equals((object) this._ModelNumber, (object) ((ProductChanges) obj)._ModelNumber)) && (object.Equals((object) this._CatalogNumber, (object) ((ProductChanges) obj)._CatalogNumber) && object.Equals((object) this._BrandName, (object) ((ProductChanges) obj)._BrandName) && (object.Equals((object) this._ProductVariation, (object) ((ProductChanges) obj)._ProductVariation) && object.Equals((object) this._ExternallyControlled, (object) ((ProductChanges) obj)._ExternallyControlled))))) && (object.Equals((object) this._Workflow, (object) ((ProductChanges) obj)._Workflow) && object.Equals((object) this._ProductFamily, (object) ((ProductChanges) obj)._ProductFamily) && (object.Equals((object) this._StdStartQty, (object) ((ProductChanges) obj)._StdStartQty) && object.Equals((object) this._TargetRolledThroughputYield, (object) ((ProductChanges) obj)._TargetRolledThroughputYield)) && (object.Equals((object) this._TargetFinalYield, (object) ((ProductChanges) obj)._TargetFinalYield) && object.Equals((object) this._SubFactory, (object) ((ProductChanges) obj)._SubFactory) && (this.CompareArrays((Array) this._Substitutes, (Array) ((ProductChanges) obj)._Substitutes) && object.Equals((object) this._DocumentSet, (object) ((ProductChanges) obj)._DocumentSet))) && (object.Equals((object) this._ObjectToChange, (object) ((ProductChanges) obj)._ObjectToChange) && object.Equals((object) this._TargetDurationPerUnit, (object) ((ProductChanges) obj)._TargetDurationPerUnit) && (object.Equals((object) this._IsFrozen, (object) ((ProductChanges) obj)._IsFrozen) && object.Equals((object) this._ProductType, (object) ((ProductChanges) obj)._ProductType)) && (object.Equals((object) this._Name, (object) ((ProductChanges) obj)._Name) && object.Equals((object) this._PlannedCost, (object) ((ProductChanges) obj)._PlannedCost) && (object.Equals((object) this._TargetCycleTime, (object) ((ProductChanges) obj)._TargetCycleTime) && object.Equals((object) this._CustomerProductNumber, (object) ((ProductChanges) obj)._CustomerProductNumber)))) && (object.Equals((object) this._CurrentCost, (object) ((ProductChanges) obj)._CurrentCost) && object.Equals((object) this._Base, (object) ((ProductChanges) obj)._Base) && (object.Equals((object) this._GLEntity, (object) ((ProductChanges) obj)._GLEntity) && object.Equals((object) this._StdCost, (object) ((ProductChanges) obj)._StdCost)))) && base.Equals(obj);
    }

    public RevisionedObjectRef ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public NamedSubentityRef[] VendorItemsInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItemsInquiry), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (VendorItemsInquiry));
      }
    }

    public RevisionedObjectRef BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public NamedSubentityRef[] VendorItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItems), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (VendorItems));
      }
    }

    public NamedObjectRef StdStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StdStartUOM));
      }
    }

    public RevisionedObjectRef ERPBOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPBOM), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ERPBOM));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NamedObjectRef VendorInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (VendorInquiry));
      }
    }

    public NamedObjectRef FEFOOverrideESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOOverrideESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FEFOOverrideESigRequirement));
      }
    }

    public Primitive<double> StdStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdStartQty2));
      }
    }

    public RevisionedObjectRef BOM
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

    public NamedObjectRef Customer
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

    public NamedObjectRef StdStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StdStartUOM2));
      }
    }

    public RevisionedObjectRef SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public UserAttributeChanges[] Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges[]) this.PropertyGet(nameof (Attributes));
      }
    }

    public NamedObjectRef ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Enumeration<FEFOEnum, int> FEFOEnforce
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOEnforce), (object) value);
      }
      get
      {
        return (Enumeration<FEFOEnum, int>) this.PropertyGet(nameof (FEFOEnforce));
      }
    }

    public Primitive<bool> SerialControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (SerialControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SerialControlled));
      }
    }

    public Primitive<bool> LotControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LotControlled));
      }
    }

    public Primitive<string> DeviceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DeviceType));
      }
    }

    public Primitive<bool> IsPhantom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPhantom), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPhantom));
      }
    }

    public Primitive<bool> InventoryControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (InventoryControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InventoryControlled));
      }
    }

    public Primitive<bool> InspectAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAll), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InspectAll));
      }
    }

    public Primitive<bool> StockPointControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (StockPointControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (StockPointControlled));
      }
    }

    public Primitive<double> TargetUnitsPerHour
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetUnitsPerHour), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TargetUnitsPerHour));
      }
    }

    public Primitive<string> ConcomitantProductNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConcomitantProductNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ConcomitantProductNumber));
      }
    }

    public Primitive<string> ModelNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ModelNumber));
      }
    }

    public Primitive<string> CatalogNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatalogNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CatalogNumber));
      }
    }

    public Primitive<string> BrandName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrandName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BrandName));
      }
    }

    public Primitive<string> ProductVariation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductVariation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductVariation));
      }
    }

    public Primitive<bool> ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
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

    public Primitive<double> StdStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdStartQty));
      }
    }

    public Primitive<double> TargetRolledThroughputYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetRolledThroughputYield), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TargetRolledThroughputYield));
      }
    }

    public Primitive<double> TargetFinalYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetFinalYield), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TargetFinalYield));
      }
    }

    public Primitive<string> SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubFactory));
      }
    }

    public RevisionedObjectRef[] Substitutes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Substitutes), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (Substitutes));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<double> TargetDurationPerUnit
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDurationPerUnit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TargetDurationPerUnit));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedObjectRef ProductType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ProductType));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<double> PlannedCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedCost));
      }
    }

    public Primitive<double> TargetCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TargetCycleTime));
      }
    }

    public Primitive<string> CustomerProductNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerProductNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerProductNumber));
      }
    }

    public Primitive<double> CurrentCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CurrentCost));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public Primitive<string> GLEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (GLEntity), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GLEntity));
      }
    }

    public Primitive<double> StdCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdCost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdCost));
      }
    }
  }
}
