// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetTemplateChanges
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
  public class ApprovalSheetTemplateChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_ToStage")]
    protected Enumeration<StageEnum, int> _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_ApprovalDecisionList")]
    protected NamedObjectRef _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_ApprovalEntries")]
    protected ApprovalSheetEntryChanges[] _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_FromStage")]
    protected Enumeration<StageEnum, int> _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetTemplateChanges && object.Equals((object) this._GeneralInstructions, (object) ((ApprovalSheetTemplateChanges) obj)._GeneralInstructions) && (object.Equals((object) this._ToStage, (object) ((ApprovalSheetTemplateChanges) obj)._ToStage) && object.Equals((object) this._ObjectToChange, (object) ((ApprovalSheetTemplateChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ApprovalDecisionList, (object) ((ApprovalSheetTemplateChanges) obj)._ApprovalDecisionList) && this.CompareArrays((Array) this._ApprovalEntries, (Array) ((ApprovalSheetTemplateChanges) obj)._ApprovalEntries) && (object.Equals((object) this._FromStage, (object) ((ApprovalSheetTemplateChanges) obj)._FromStage) && object.Equals((object) this._ApprovalRequired, (object) ((ApprovalSheetTemplateChanges) obj)._ApprovalRequired))) && object.Equals((object) this._Name, (object) ((ApprovalSheetTemplateChanges) obj)._Name) && base.Equals(obj);
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

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
