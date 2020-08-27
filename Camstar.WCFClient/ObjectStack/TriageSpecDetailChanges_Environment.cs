// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecDetailChanges_Environment
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
  public class TriageSpecDetailChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_Role")]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_ToCategory")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, true, false, "Integer", 1051432, false, false, true, null)]
    protected Environment _ToCategory;
    [Metadata("The TriageSpecDetail identifies the default values to assign to the Event or CAR as part of the Escalation process.", "TriageSpecDetailChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052971, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;
    [Metadata("The TriageSpecDetail identifies the default values to assign to the Event or CAR as part of the Escalation process.", "TriageSpecDetail", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051432, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Environment_Owner")]
    protected Environment _Owner;

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

    public Environment ToCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToCategory));
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
