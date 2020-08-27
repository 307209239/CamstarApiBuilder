// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetTemplateChanges_Info
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
  public class ApprovalSheetTemplateChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_GeneralInstructions")]
    protected Info _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_ToStage")]
    protected Info _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_ApprovalDecisionList")]
    protected Info _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_ApprovalEntries")]
    protected ApprovalSheetEntryChanges_Info _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_FromStage")]
    protected Info _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_ApprovalRequired")]
    protected Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Info_Name")]
    protected new Info _Name;

    public Info GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Info ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStage));
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

    public Info ApprovalDecisionList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisionList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalDecisionList));
      }
    }

    public ApprovalSheetEntryChanges_Info ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalSheetEntryChanges_Info) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public Info FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStage));
      }
    }

    public Info ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
