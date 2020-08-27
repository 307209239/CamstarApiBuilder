// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetChanges_Environment
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
  public class ApprovalSheetChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_GeneralInstructions")]
    [Metadata("Comments", "", false, false, false, "String", 1051979, false, false, false, null)]
    protected Environment _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntryChanges", false, false, false, "ApprovalSheetEntryChanges", 1052002, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ApprovalEntries")]
    protected ApprovalSheetEntryChanges_Environment _ApprovalEntries;
    [Metadata("This is the list of transitions to which an approval sheet can be assigned.  The default values will be used as the Name of the ApprovalSheet in the list of sheets", "QualityTransitionsEnum", false, false, false, "String", 1051626, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ApprovalDecisionList")]
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, true, false, "NamedObjectRef", 1051615, false, false, false, null)]
    protected Environment _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_FromStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051670, false, false, true, null)]
    protected Environment _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ToStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051971, false, false, true, null)]
    protected Environment _ToStage;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheetChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051682, false, false, true, null)]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ObjectToChange")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051995, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_LastApprovalCycle")]
    protected Environment _LastApprovalCycle;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051996, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_LastApprovalCycleGMT")]
    protected Environment _LastApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_ApprovalRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051371, false, false, false, "0")]
    protected Environment _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;

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

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetTemplate));
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

    public Environment LastApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycle), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastApprovalCycle));
      }
    }

    public Environment LastApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastApprovalCycleGMT));
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

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
