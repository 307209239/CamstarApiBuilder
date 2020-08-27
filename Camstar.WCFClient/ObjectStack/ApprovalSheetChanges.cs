// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetChanges
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
  public class ApprovalSheetChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ApprovalEntries")]
    protected ApprovalSheetEntryChanges[] _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Name")]
    protected Enumeration<QualityTransitionsEnum, string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ApprovalDecisionList")]
    protected NamedObjectRef _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_FromStage")]
    protected Enumeration<StageEnum, int> _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ToStage")]
    protected Enumeration<StageEnum, int> _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_LastApprovalCycle")]
    protected Primitive<DateTime> _LastApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_LastApprovalCycleGMT")]
    protected Primitive<DateTime> _LastApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetChanges && object.Equals((object) this._GeneralInstructions, (object) ((ApprovalSheetChanges) obj)._GeneralInstructions) && (object.Equals((object) this._Comments, (object) ((ApprovalSheetChanges) obj)._Comments) && this.CompareArrays((Array) this._ApprovalEntries, (Array) ((ApprovalSheetChanges) obj)._ApprovalEntries)) && (object.Equals((object) this._Name, (object) ((ApprovalSheetChanges) obj)._Name) && object.Equals((object) this._ApprovalDecisionList, (object) ((ApprovalSheetChanges) obj)._ApprovalDecisionList) && (object.Equals((object) this._FromStage, (object) ((ApprovalSheetChanges) obj)._FromStage) && object.Equals((object) this._ToStage, (object) ((ApprovalSheetChanges) obj)._ToStage))) && (object.Equals((object) this._ListItemToChange, (object) ((ApprovalSheetChanges) obj)._ListItemToChange) && object.Equals((object) this._ApprovalSheetTemplate, (object) ((ApprovalSheetChanges) obj)._ApprovalSheetTemplate) && (object.Equals((object) this._ObjectToChange, (object) ((ApprovalSheetChanges) obj)._ObjectToChange) && object.Equals((object) this._LastApprovalCycle, (object) ((ApprovalSheetChanges) obj)._LastApprovalCycle)) && (object.Equals((object) this._LastApprovalCycleGMT, (object) ((ApprovalSheetChanges) obj)._LastApprovalCycleGMT) && object.Equals((object) this._ApprovalRequired, (object) ((ApprovalSheetChanges) obj)._ApprovalRequired) && object.Equals((object) this._Description, (object) ((ApprovalSheetChanges) obj)._Description))) && base.Equals(obj);
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
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

    public ApprovalSheetEntryChanges[] ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalSheetEntryChanges[]) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public Enumeration<QualityTransitionsEnum, string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Enumeration<QualityTransitionsEnum, string>) this.PropertyGet(nameof (Name));
      }
    }

    public NamedObjectRef ApprovalDecisionList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisionList), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalDecisionList));
      }
    }

    public Enumeration<StageEnum, int> FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (FromStage));
      }
    }

    public Enumeration<StageEnum, int> ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (ToStage));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<DateTime> LastApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycle), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastApprovalCycle));
      }
    }

    public Primitive<DateTime> LastApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastApprovalCycleGMT));
      }
    }

    public Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
