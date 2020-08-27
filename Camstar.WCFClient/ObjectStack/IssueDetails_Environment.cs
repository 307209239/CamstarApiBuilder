// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (IssueDetailsBulk_Environment))]
  [KnownType(typeof (IssueDetailsStock_Environment))]
  [KnownType(typeof (IssueDetailsLotStock_Environment))]
  [KnownType(typeof (IssueDetailsDisplayOnly_Environment))]
  [KnownType(typeof (IssueDetailsSerial_Environment))]
  [KnownType(typeof (IssueDetailsQuantity_Environment))]
  [Serializable]
  public class IssueDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049452, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_Qty2Issued")]
    protected Environment _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_IssueDifferenceReason")]
    [Metadata("Describes the reason for the difference between the required quantity and the actual quantity issued.", "IssueDifferenceReason", false, false, false, "NamedObjectRef", 1049467, false, false, true, null)]
    protected Environment _IssueDifferenceReason;
    [Metadata("Records the actual shop floor material issues. These may differ from the defined requirements ... substitute items may be used, greater or lessor quantities may be used. Actuals are correlated back to BOM requirements using the BillLineItem field.\r\n", "IssueActuals", false, false, false, "IssueActuals", 1049642, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_Actuals")]
    protected IssueActuals_Environment _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_IssueActualsHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "IssueActualsHistory", 1049765, false, true, false, null)]
    protected IssueActualsHistory_Environment _IssueActualsHistory;
    [Metadata("Records the details of the removal of components from a WIP container", "RemovalHistoryDetail", false, false, false, "RemovalHistoryDetail", 1049845, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_RemovalHistoryDetails")]
    protected RemovalHistoryDetail_Environment _RemovalHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_BOMLineItem")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItem", false, false, false, "NamedSubentityRef", 1049462, false, false, false, null)]
    protected Environment _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048630, false, false, true, null)]
    protected Environment _UOM2;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049687, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_NetQty2Required")]
    protected Environment _NetQty2Required;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049464, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_ActualQty2Issued")]
    protected Environment _ActualQty2Issued;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049415, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_Qty2Required")]
    protected Environment _Qty2Required;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049463, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_IssueControl")]
    protected Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_IsRecipeQtyEvaluated")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051942, false, false, false, "1")]
    protected Environment _IsRecipeQtyEvaluated;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051817, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_AllowManualWeighOverride")]
    protected Environment _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_AllowSubstitution")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049488, false, false, false, "0")]
    protected Environment _AllowSubstitution;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049402, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_CloseWhenEmpty")]
    protected Environment _CloseWhenEmpty;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051863, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_IsManualReadingOnly")]
    protected Environment _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_ValidateQtyDifference")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16779387, false, false, false, "1")]
    protected Environment _ValidateQtyDifference;
    [Metadata("Generic String", "", false, false, false, "String", 1049491, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_IssueControlName")]
    protected Environment _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_ActualQtyIssued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049464, false, false, false, null)]
    protected Environment _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_NetQtyRequired")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049686, false, false, false, null)]
    protected Environment _NetQtyRequired;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_QtyUpperLimit")]
    protected Environment _QtyUpperLimit;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_QtyLowerLimit")]
    protected Environment _QtyLowerLimit;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1049450, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_ProductSubstitutes")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1052587, false, true, false, null)]
    protected Environment _ProductSubstitutes;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_QtyRequired")]
    [Metadata("Material quantity (individual)", "", false, true, false, "Fixed", 1049414, false, false, false, null)]
    protected Environment _QtyRequired;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1049279, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_ProductDescription")]
    protected Environment _ProductDescription;
    [Metadata("Message text.", "", false, false, false, "String", 1051943, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_RecipeQtyMessage")]
    protected Environment _RecipeQtyMessage;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Environment_QtyIssued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049451, false, false, false, null)]
    protected Environment _QtyIssued;

    public Environment Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public Environment IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public IssueActuals_Environment Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActuals_Environment) this.PropertyGet(nameof (Actuals));
      }
    }

    public IssueActualsHistory_Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public RemovalHistoryDetail_Environment RemovalHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalHistoryDetails), (object) value);
      }
      get
      {
        return (RemovalHistoryDetail_Environment) this.PropertyGet(nameof (RemovalHistoryDetails));
      }
    }

    public Environment BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BOMLineItem));
      }
    }

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

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

    public Environment NetQty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Required), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQty2Required));
      }
    }

    public Environment ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Environment IsRecipeQtyEvaluated
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRecipeQtyEvaluated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRecipeQtyEvaluated));
      }
    }

    public Environment ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Environment AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Environment AllowSubstitution
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowSubstitution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowSubstitution));
      }
    }

    public Environment CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Environment IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsManualReadingOnly));
      }
    }

    public Environment ValidateQtyDifference
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateQtyDifference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidateQtyDifference));
      }
    }

    public Environment IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Environment ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }

    public Environment NetQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQtyRequired));
      }
    }

    public Environment QtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyUpperLimit));
      }
    }

    public Environment QtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyLowerLimit));
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

    public Environment ProductSubstitutes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductSubstitutes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductSubstitutes));
      }
    }

    public Environment QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public Environment ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Environment RecipeQtyMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeQtyMessage));
      }
    }

    public Environment QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyIssued));
      }
    }
  }
}
