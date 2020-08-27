// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventClassSpecMapChanges_Environment
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
  public class EventClassSpecMapChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Grouping mechanism for the FailureModes.  Identifies the possible FailureModes that can be assigned to an Event.", "FailureModeGroup", false, true, false, "NamedObjectRef", 1051035, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_FailureModeGroup")]
    protected Environment _FailureModeGroup;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_Role")]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_ListItemToChange")]
    [Metadata("This subentity defines the valid classification/subclassification combinations for the organization.", "EventClassSpecMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Used to classify QualityObjects", "Classification", false, true, false, "NamedObjectRef", 1051055, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_Classification")]
    protected Environment _Classification;
    [Metadata("This subentity defines the valid classification/subclassification combinations for the organization.", "EventClassificationSpecMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052971, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_Subclassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, true, false, "NamedObjectRef", 1051146, false, false, true, null)]
    protected Environment _Subclassification;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778284, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_PEDefault")]
    protected Environment _PEDefault;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Environment_Owner")]
    protected Environment _Owner;

    public Environment FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureModeGroup));
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

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
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

    public Environment ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public Environment Subclassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Subclassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Subclassification));
      }
    }

    public Environment PEDefault
    {
      [param: In] set
      {
        this.PropertySet(nameof (PEDefault), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PEDefault));
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

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
