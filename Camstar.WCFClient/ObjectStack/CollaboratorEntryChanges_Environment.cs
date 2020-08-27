// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorEntryChanges_Environment
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
  public class CollaboratorEntryChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Instruction", "", false, false, false, "String", 16778079, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_Role")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1050342, false, false, true, null)]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_Status")]
    [Metadata("Status of collaboration process:\r\n1 - Pending\r\n2 - Late\r\n3 - Complete", "CollaborateStatusEnum", false, false, false, "Integer", 1048671, false, false, false, null)]
    protected Environment _Status;
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051375, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_DurationUOM")]
    protected Environment _DurationUOM;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_SubstituteOption")]
    [Metadata("ApprovalSubstituteOption", "ApprovalSubstituteOptionEnum", false, false, false, "Integer", 1051982, false, false, true, null)]
    protected Environment _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_SheetLevel")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1048809, false, false, false, null)]
    protected Environment _SheetLevel;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1048681, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_Collaborator")]
    protected Environment _Collaborator;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1051374, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_Duration")]
    protected Environment _Duration;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
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

    public Environment DurationUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DurationUOM));
      }
    }

    public Environment SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Environment SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Environment Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Collaborator));
      }
    }

    public Environment Duration
    {
      [param: In] set
      {
        this.PropertySet(nameof (Duration), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Duration));
      }
    }

    public Environment IsFrozen
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
  }
}
