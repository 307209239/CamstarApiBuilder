// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueHistoryDetail_Environment
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
  public class IssueHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "ProductMaterialListItem", false, false, false, "NamedSubentityRef", 1049462, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_BOMLineItem")]
    protected Environment _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_Actuals")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "IssueActualsHistory", 1049459, false, true, false, null)]
    protected IssueActualsHistory_Environment _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1052593, false, false, false, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_IssueDifferenceReason")]
    [Metadata("Describes the reason for the difference between the required quantity and the actual quantity issued.", "IssueDifferenceReason", false, false, false, "NamedObjectRef", 1049466, false, false, false, null)]
    protected Environment _IssueDifferenceReason;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049415, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_Qty2Required")]
    protected Environment _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_ActualQty2Issued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050041, false, false, false, null)]
    protected Environment _ActualQty2Issued;
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_ReferenceDesignator")]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_IssueControl")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049463, false, false, false, null)]
    protected Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051817, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_AllowManualWeighOverride")]
    protected Environment _AllowManualWeighOverride;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051863, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_IsManualReadingOnly")]
    protected Environment _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_CloseWhenEmpty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049402, false, false, false, "0")]
    protected Environment _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1049450, false, false, false, null)]
    protected Environment _Product;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049464, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_ActualQtyIssued")]
    protected Environment _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_QtyUpperLimit")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1052138, false, false, false, null)]
    protected Environment _QtyUpperLimit;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1052137, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_QtyLowerLimit")]
    protected Environment _QtyLowerLimit;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049414, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_QtyRequired")]
    protected Environment _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Notes;

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

    public IssueActualsHistory_Environment Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (Actuals));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
