// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (IssueDetailsLotStock))]
  [KnownType(typeof (IssueDetailsBulk))]
  [KnownType(typeof (IssueDetailsSerial))]
  [KnownType(typeof (IssueDetailsDisplayOnly))]
  [KnownType(typeof (IssueDetailsStock))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (IssueDetailsQuantity))]
  [Serializable]
  public class IssueDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Qty2Issued")]
    protected Primitive<double> _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Actuals")]
    protected IssueActuals[] _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_IssueActualsHistory")]
    protected Camstar.WCF.ObjectStack.IssueActualsHistory[] _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_RemovalHistoryDetails")]
    protected RemovalHistoryDetail[] _RemovalHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_NetQty2Required")]
    protected Primitive<double> _NetQty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_ActualQty2Issued")]
    protected Primitive<double> _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Qty2Required")]
    protected Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_IssueControl")]
    protected Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_IsRecipeQtyEvaluated")]
    protected Primitive<bool> _IsRecipeQtyEvaluated;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_AllowManualWeighOverride")]
    protected Primitive<bool> _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_AllowSubstitution")]
    protected Primitive<bool> _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_CloseWhenEmpty")]
    protected Primitive<bool> _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_IsManualReadingOnly")]
    protected Primitive<bool> _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_ValidateQtyDifference")]
    protected Primitive<bool> _ValidateQtyDifference;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_IssueControlName")]
    protected Primitive<string> _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_ActualQtyIssued")]
    protected Primitive<double> _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_NetQtyRequired")]
    protected Primitive<double> _NetQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_QtyUpperLimit")]
    protected Primitive<double> _QtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_QtyLowerLimit")]
    protected Primitive<double> _QtyLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_ProductSubstitutes")]
    protected RevisionedObjectRef[] _ProductSubstitutes;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_QtyRequired")]
    protected Primitive<double> _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_RecipeQtyMessage")]
    protected Primitive<string> _RecipeQtyMessage;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_QtyIssued")]
    protected Primitive<double> _QtyIssued;

    public override bool Equals(object obj)
    {
      return obj is IssueDetails && object.Equals((object) this._Qty2Issued, (object) ((IssueDetails) obj)._Qty2Issued) && (object.Equals((object) this._IssueDifferenceReason, (object) ((IssueDetails) obj)._IssueDifferenceReason) && this.CompareArrays((Array) this._Actuals, (Array) ((IssueDetails) obj)._Actuals)) && (this.CompareArrays((Array) this._IssueActualsHistory, (Array) ((IssueDetails) obj)._IssueActualsHistory) && this.CompareArrays((Array) this._RemovalHistoryDetails, (Array) ((IssueDetails) obj)._RemovalHistoryDetails) && (object.Equals((object) this._BOMLineItem, (object) ((IssueDetails) obj)._BOMLineItem) && object.Equals((object) this._UOM2, (object) ((IssueDetails) obj)._UOM2))) && (object.Equals((object) this._UOM, (object) ((IssueDetails) obj)._UOM) && object.Equals((object) this._NetQty2Required, (object) ((IssueDetails) obj)._NetQty2Required) && (object.Equals((object) this._ActualQty2Issued, (object) ((IssueDetails) obj)._ActualQty2Issued) && object.Equals((object) this._Comments, (object) ((IssueDetails) obj)._Comments)) && (object.Equals((object) this._Qty2Required, (object) ((IssueDetails) obj)._Qty2Required) && object.Equals((object) this._IssueControl, (object) ((IssueDetails) obj)._IssueControl) && (object.Equals((object) this._IsRecipeQtyEvaluated, (object) ((IssueDetails) obj)._IsRecipeQtyEvaluated) && object.Equals((object) this._ReferenceDesignator, (object) ((IssueDetails) obj)._ReferenceDesignator)))) && (object.Equals((object) this._AllowManualWeighOverride, (object) ((IssueDetails) obj)._AllowManualWeighOverride) && object.Equals((object) this._AllowSubstitution, (object) ((IssueDetails) obj)._AllowSubstitution) && (object.Equals((object) this._CloseWhenEmpty, (object) ((IssueDetails) obj)._CloseWhenEmpty) && object.Equals((object) this._IsManualReadingOnly, (object) ((IssueDetails) obj)._IsManualReadingOnly)) && (object.Equals((object) this._ValidateQtyDifference, (object) ((IssueDetails) obj)._ValidateQtyDifference) && object.Equals((object) this._IssueControlName, (object) ((IssueDetails) obj)._IssueControlName) && (object.Equals((object) this._ActualQtyIssued, (object) ((IssueDetails) obj)._ActualQtyIssued) && object.Equals((object) this._NetQtyRequired, (object) ((IssueDetails) obj)._NetQtyRequired))) && (object.Equals((object) this._QtyUpperLimit, (object) ((IssueDetails) obj)._QtyUpperLimit) && object.Equals((object) this._QtyLowerLimit, (object) ((IssueDetails) obj)._QtyLowerLimit) && (object.Equals((object) this._Product, (object) ((IssueDetails) obj)._Product) && this.CompareArrays((Array) this._ProductSubstitutes, (Array) ((IssueDetails) obj)._ProductSubstitutes)) && (object.Equals((object) this._QtyRequired, (object) ((IssueDetails) obj)._QtyRequired) && object.Equals((object) this._ProductDescription, (object) ((IssueDetails) obj)._ProductDescription) && (object.Equals((object) this._RecipeQtyMessage, (object) ((IssueDetails) obj)._RecipeQtyMessage) && object.Equals((object) this._QtyIssued, (object) ((IssueDetails) obj)._QtyIssued))))) && base.Equals(obj);
    }

    public Primitive<double> Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public NamedObjectRef IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public IssueActuals[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActuals[]) this.PropertyGet(nameof (Actuals));
      }
    }

    public Camstar.WCF.ObjectStack.IssueActualsHistory[] IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.IssueActualsHistory[]) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public RemovalHistoryDetail[] RemovalHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalHistoryDetails), (object) value);
      }
      get
      {
        return (RemovalHistoryDetail[]) this.PropertyGet(nameof (RemovalHistoryDetails));
      }
    }

    public NamedSubentityRef BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (BOMLineItem));
      }
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public Primitive<double> NetQty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Required), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQty2Required));
      }
    }

    public Primitive<double> ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Primitive<double> Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Primitive<bool> IsRecipeQtyEvaluated
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRecipeQtyEvaluated), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRecipeQtyEvaluated));
      }
    }

    public Primitive<string> ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Primitive<bool> AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Primitive<bool> AllowSubstitution
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowSubstitution), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowSubstitution));
      }
    }

    public Primitive<bool> CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Primitive<bool> IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsManualReadingOnly));
      }
    }

    public Primitive<bool> ValidateQtyDifference
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateQtyDifference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ValidateQtyDifference));
      }
    }

    public Primitive<string> IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Primitive<double> ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }

    public Primitive<double> NetQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyRequired), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQtyRequired));
      }
    }

    public Primitive<double> QtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyUpperLimit));
      }
    }

    public Primitive<double> QtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyLowerLimit));
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

    public RevisionedObjectRef[] ProductSubstitutes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductSubstitutes), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ProductSubstitutes));
      }
    }

    public Primitive<double> QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public Primitive<string> ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Primitive<string> RecipeQtyMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RecipeQtyMessage));
      }
    }

    public Primitive<double> QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyIssued));
      }
    }
  }
}
