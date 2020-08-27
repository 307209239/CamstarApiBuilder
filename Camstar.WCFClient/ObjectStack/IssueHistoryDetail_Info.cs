// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueHistoryDetail_Info
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
  public class IssueHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_BOMLineItem")]
    protected Info _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_Actuals")]
    protected IssueActualsHistory_Info _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_Qty2Required")]
    protected Info _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_ActualQty2Issued")]
    protected Info _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_AllowManualWeighOverride")]
    protected Info _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_IsManualReadingOnly")]
    protected Info _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_CloseWhenEmpty")]
    protected Info _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_ActualQtyIssued")]
    protected Info _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_QtyUpperLimit")]
    protected Info _QtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_QtyLowerLimit")]
    protected Info _QtyLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_QtyRequired")]
    protected Info _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "IssueHistoryDetail_Info_Notes")]
    protected Info _Notes;

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

    public IssueActualsHistory_Info Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Info) this.PropertyGet(nameof (Actuals));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
