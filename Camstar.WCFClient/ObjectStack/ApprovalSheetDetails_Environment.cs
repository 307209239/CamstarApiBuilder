// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetDetails_Environment
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
  public class ApprovalSheetDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_GeneralInstructions")]
    [Metadata("Comments", "", false, false, false, "String", 1051979, false, false, false, null)]
    protected Environment _GeneralInstructions;
    [Metadata("This is the list of transitions to which an approval sheet can be assigned.  The default values will be used as the Name of the ApprovalSheet in the list of sheets", "QualityTransitionsEnum", false, false, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_Name")]
    protected Environment _Name;
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, false, false, "NamedObjectRef", 1051615, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_ApprovalDecisionList")]
    protected Environment _ApprovalDecisionList;
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_ApprovalEntries")]
    [Metadata("Used to maintain the entries in an approval sheet for a parent object", "ApprovalEntryDetails", false, false, false, "ApprovalEntryDetails", 1052002, false, true, false, null)]
    protected ApprovalEntryDetails_Environment _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_ApprovalSheet")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    protected Environment _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_ApprovalRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051371, false, false, false, "0")]
    protected Environment _ApprovalRequired;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051404, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_AutoStart")]
    protected Environment _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_ExecuteAction")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1048872, false, false, false, "0")]
    protected Environment _ExecuteAction;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Environment_Description")]
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

    public Environment Name
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

    public ApprovalEntryDetails_Environment ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalEntryDetails_Environment) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
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

    public Environment AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Environment ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteAction));
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
