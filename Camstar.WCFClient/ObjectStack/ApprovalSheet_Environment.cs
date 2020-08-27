// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheet_Environment
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
  public class ApprovalSheet_Environment : NamedSubentity_Environment
  {
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Comments", "", false, false, true, "String", 1051979, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_GeneralInstructions")]
    protected Environment _GeneralInstructions;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051670, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_FromStage")]
    protected Environment _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_ToStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051971, false, false, false, null)]
    protected Environment _ToStage;
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1051625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_ApprovalEntries")]
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, true, "ApprovalSheetEntry", 1052002, false, true, false, null)]
    protected ApprovalSheetEntry_Environment _ApprovalEntries;
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, false, true, "NamedObjectRef", 1051615, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_ApprovalDecisionList")]
    protected Environment _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_ApprovalRoutingInfo")]
    [Metadata("Information stored for Approvals as part of the Routing.", "ApprovalRoutingInfo", false, false, true, "SubentityRef", 1051669, false, false, false, null)]
    protected Environment _ApprovalRoutingInfo;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051995, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_LastApprovalCycle")]
    protected Environment _LastApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_DesignateOnApproval")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052205, false, false, false, "0")]
    protected Environment _DesignateOnApproval;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_ApprovalRequired")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051371, false, false, false, "0")]
    protected Environment _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_LastApprovalCycleGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051996, false, false, false, null)]
    protected Environment _LastApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051626, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheet_Environment_Description")]
    protected Environment _Description;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

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

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public ApprovalSheetEntry_Environment ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalSheetEntry_Environment) this.PropertyGet(nameof (ApprovalEntries));
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

    public Environment ApprovalRoutingInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRoutingInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalRoutingInfo));
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

    public Environment DesignateOnApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (DesignateOnApproval), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DesignateOnApproval));
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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
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
