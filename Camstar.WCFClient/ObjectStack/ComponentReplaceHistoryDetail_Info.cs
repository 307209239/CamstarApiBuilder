// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceHistoryDetail_Info
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
  public class ComponentReplaceHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_RemovalDetails")]
    protected Info _RemovalDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_Actuals")]
    protected IssueActualsHistory_Info _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_Qty2Required")]
    protected Info _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_BOMLineItem")]
    protected Info _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_SubstitutionReason")]
    protected Info _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_IssueDetails")]
    protected Info _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_VendorItem")]
    protected Info _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_Qty2Removed")]
    protected Info _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_ReplaceReason")]
    protected Info _ReplaceReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_IsScrapReplaced")]
    protected Info _IsScrapReplaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_ActualQty2Issued")]
    protected Info _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_ActualQtyIssued")]
    protected Info _ActualQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_QtyRemoved")]
    protected Info _QtyRemoved;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Info_QtyRequired")]
    protected Info _QtyRequired;

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

    public Info RemovalDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemovalDetails));
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

    public Info SubstitutionReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstitutionReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubstitutionReason));
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

    public Info IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueDetails));
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

    public Info VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorItem));
      }
    }

    public Info Qty2Removed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Removed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Removed));
      }
    }

    public Info ReplaceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReplaceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReplaceReason));
      }
    }

    public Info IsScrapReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsScrapReplaced), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsScrapReplaced));
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

    public Info QtyRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemoved), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRemoved));
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
  }
}
