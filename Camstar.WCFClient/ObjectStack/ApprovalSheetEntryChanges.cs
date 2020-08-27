// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetEntryChanges
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
  public class ApprovalSheetEntryChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_ApproverRole")]
    protected NamedObjectRef _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_PLMApprovalURL")]
    protected Primitive<string> _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_PLMApprovalCode")]
    protected Primitive<string> _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_SubstituteOption")]
    protected Enumeration<ApprovalSubstituteOptionEnum, int> _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_EditOption")]
    protected Enumeration<ApprovalEditOptionEnum, int> _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_DecisionType")]
    protected Enumeration<DecisionTypeEnum, int> _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_LastRoutedOnGMT")]
    protected Primitive<DateTime> _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_FirstRoutedOn")]
    protected Primitive<DateTime> _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_LastRoutedOn")]
    protected Primitive<DateTime> _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_CompleteByGMT")]
    protected Primitive<DateTime> _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_Approver")]
    protected NamedObjectRef _Approver;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntryChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetEntryChanges && object.Equals((object) this._ApproverRole, (object) ((ApprovalSheetEntryChanges) obj)._ApproverRole) && (object.Equals((object) this._PLMApprovalURL, (object) ((ApprovalSheetEntryChanges) obj)._PLMApprovalURL) && object.Equals((object) this._SpecialInstructions, (object) ((ApprovalSheetEntryChanges) obj)._SpecialInstructions)) && (object.Equals((object) this._PLMApprovalCode, (object) ((ApprovalSheetEntryChanges) obj)._PLMApprovalCode) && object.Equals((object) this._ObjectToChange, (object) ((ApprovalSheetEntryChanges) obj)._ObjectToChange) && (object.Equals((object) this._SubstituteOption, (object) ((ApprovalSheetEntryChanges) obj)._SubstituteOption) && object.Equals((object) this._EditOption, (object) ((ApprovalSheetEntryChanges) obj)._EditOption))) && (object.Equals((object) this._CompleteWithinUOM, (object) ((ApprovalSheetEntryChanges) obj)._CompleteWithinUOM) && object.Equals((object) this._DecisionType, (object) ((ApprovalSheetEntryChanges) obj)._DecisionType) && (object.Equals((object) this._ListItemToChange, (object) ((ApprovalSheetEntryChanges) obj)._ListItemToChange) && object.Equals((object) this._LastRoutedOnGMT, (object) ((ApprovalSheetEntryChanges) obj)._LastRoutedOnGMT)) && (object.Equals((object) this._SheetLevel, (object) ((ApprovalSheetEntryChanges) obj)._SheetLevel) && object.Equals((object) this._EntryRequired, (object) ((ApprovalSheetEntryChanges) obj)._EntryRequired) && (object.Equals((object) this._FirstRoutedOn, (object) ((ApprovalSheetEntryChanges) obj)._FirstRoutedOn) && object.Equals((object) this._LastRoutedOn, (object) ((ApprovalSheetEntryChanges) obj)._LastRoutedOn)))) && (object.Equals((object) this._CompleteWithinQty, (object) ((ApprovalSheetEntryChanges) obj)._CompleteWithinQty) && object.Equals((object) this._CompleteByGMT, (object) ((ApprovalSheetEntryChanges) obj)._CompleteByGMT) && (object.Equals((object) this._Approver, (object) ((ApprovalSheetEntryChanges) obj)._Approver) && object.Equals((object) this._IsFrozen, (object) ((ApprovalSheetEntryChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public NamedObjectRef ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApproverRole));
      }
    }

    public Primitive<string> PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public Primitive<string> SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Primitive<string> PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<ApprovalSubstituteOptionEnum, int> SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalSubstituteOptionEnum, int>) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Enumeration<ApprovalEditOptionEnum, int> EditOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (EditOption), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalEditOptionEnum, int>) this.PropertyGet(nameof (EditOption));
      }
    }

    public Enumeration<DurationUOMEnum, string> CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public Enumeration<DecisionTypeEnum, int> DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Enumeration<DecisionTypeEnum, int>) this.PropertyGet(nameof (DecisionType));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<DateTime> LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastRoutedOnGMT));
      }
    }

    public Primitive<int> SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Primitive<bool> EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (EntryRequired));
      }
    }

    public Primitive<DateTime> FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public Primitive<DateTime> LastRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastRoutedOn));
      }
    }

    public Primitive<int> CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public Primitive<DateTime> CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public NamedObjectRef Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Approver));
      }
    }

    public Primitive<bool> IsFrozen
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
  }
}
