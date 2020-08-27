// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetEntryChanges_Info
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
  public class ApprovalSheetEntryChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_ApproverRole")]
    protected Info _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_PLMApprovalURL")]
    protected Info _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_PLMApprovalCode")]
    protected Info _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_SubstituteOption")]
    protected Info _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_EditOption")]
    protected Info _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_CompleteWithinUOM")]
    protected Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_DecisionType")]
    protected Info _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_LastRoutedOnGMT")]
    protected Info _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_EntryRequired")]
    protected Info _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_FirstRoutedOn")]
    protected Info _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_LastRoutedOn")]
    protected Info _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_CompleteWithinQty")]
    protected Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_CompleteByGMT")]
    protected Info _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_Approver")]
    protected Info _Approver;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApproverRole));
      }
    }

    public Info PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public Info SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Info PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PLMApprovalCode));
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

    public Info SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Info EditOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (EditOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EditOption));
      }
    }

    public Info CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public Info DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecisionType));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRoutedOnGMT));
      }
    }

    public Info SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Info EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryRequired));
      }
    }

    public Info FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public Info LastRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRoutedOn));
      }
    }

    public Info CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public Info CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public Info Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Approver));
      }
    }

    public Info IsFrozen
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
  }
}
