// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetTemplateChanges_Environment
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
  public class ApprovalSheetTemplateChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1051979, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_GeneralInstructions")]
    protected Environment _GeneralInstructions;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051971, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_ToStage")]
    protected Environment _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_ObjectToChange")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_ApprovalDecisionList")]
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, true, false, "NamedObjectRef", 1051615, false, false, true, null)]
    protected Environment _ApprovalDecisionList;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntryChanges", false, false, false, "ApprovalSheetEntryChanges", 1051691, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_ApprovalEntries")]
    protected ApprovalSheetEntryChanges_Environment _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_FromStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051670, false, false, true, null)]
    protected Environment _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_ApprovalRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051371, false, false, false, "0")]
    protected Environment _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetTemplateChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052250, false, false, false, null)]
    protected new Environment _Name;

    public Environment GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Environment ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStage));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment ApprovalDecisionList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisionList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalDecisionList));
      }
    }

    public ApprovalSheetEntryChanges_Environment ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalSheetEntryChanges_Environment) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public Environment FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStage));
      }
    }

    public Environment ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
