// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (IssueDetailsStock_Info))]
  [KnownType(typeof (IssueDetailsQuantity_Info))]
  [KnownType(typeof (IssueDetailsDisplayOnly_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (IssueDetailsBulk_Info))]
  [KnownType(typeof (IssueDetailsLotStock_Info))]
  [KnownType(typeof (IssueDetailsSerial_Info))]
  [Serializable]
  public class IssueDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_Qty2Issued")]
    protected Info _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_Actuals")]
    protected IssueActuals_Info _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_IssueActualsHistory")]
    protected IssueActualsHistory_Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_RemovalHistoryDetails")]
    protected RemovalHistoryDetail_Info _RemovalHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_BOMLineItem")]
    protected Info _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_NetQty2Required")]
    protected Info _NetQty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_ActualQty2Issued")]
    protected Info _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_Qty2Required")]
    protected Info _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_IsRecipeQtyEvaluated")]
    protected Info _IsRecipeQtyEvaluated;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_AllowManualWeighOverride")]
    protected Info _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_AllowSubstitution")]
    protected Info _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_CloseWhenEmpty")]
    protected Info _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_IsManualReadingOnly")]
    protected Info _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_ValidateQtyDifference")]
    protected Info _ValidateQtyDifference;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_IssueControlName")]
    protected Info _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_ActualQtyIssued")]
    protected Info _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_NetQtyRequired")]
    protected Info _NetQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_QtyUpperLimit")]
    protected Info _QtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_QtyLowerLimit")]
    protected Info _QtyLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_ProductSubstitutes")]
    protected Info _ProductSubstitutes;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_QtyRequired")]
    protected Info _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_RecipeQtyMessage")]
    protected Info _RecipeQtyMessage;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetails_Info_QtyIssued")]
    protected Info _QtyIssued;

    public Info Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public Info IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public IssueActuals_Info Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActuals_Info) this.PropertyGet(nameof (Actuals));
      }
    }

    public IssueActualsHistory_Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Info) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public RemovalHistoryDetail_Info RemovalHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalHistoryDetails), (object) value);
      }
      get
      {
        return (RemovalHistoryDetail_Info) this.PropertyGet(nameof (RemovalHistoryDetails));
      }
    }

    public Info BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BOMLineItem));
      }
    }

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public Info NetQty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Required), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQty2Required));
      }
    }

    public Info ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info IsRecipeQtyEvaluated
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRecipeQtyEvaluated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRecipeQtyEvaluated));
      }
    }

    public Info ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Info AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Info AllowSubstitution
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowSubstitution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowSubstitution));
      }
    }

    public Info CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Info IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsManualReadingOnly));
      }
    }

    public Info ValidateQtyDifference
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateQtyDifference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidateQtyDifference));
      }
    }

    public Info IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Info ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }

    public Info NetQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQtyRequired));
      }
    }

    public Info QtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyUpperLimit));
      }
    }

    public Info QtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyLowerLimit));
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

    public Info ProductSubstitutes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductSubstitutes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductSubstitutes));
      }
    }

    public Info QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public Info ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Info RecipeQtyMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeQtyMessage));
      }
    }

    public Info QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyIssued));
      }
    }
  }
}
