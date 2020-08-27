// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CategoryMapChanges_Environment
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
  public class CategoryMapChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_Role")]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_Category")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, true, false, "Integer", 1051206, false, false, true, null)]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_ObjectToChange")]
    [Metadata("The CategoryMap sets up that relationship of the QualityObject's Category to a particular TriageSpec.", "CategoryMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_TriageSpec")]
    [Metadata("The specifications for Triaging an Event or CAR.  The Triage process handles escalating or closing the Event or CAR.", "TriageSpec", false, false, false, "NamedObjectRef", 1051428, false, false, true, null)]
    protected Environment _TriageSpec;
    [Metadata("The ApprovalSheetMap sets up that relationship of the ResolutionAction to the ApprovalSheetTemplate.", "ApprovalSheetMapChanges", false, false, false, "ApprovalSheetMapChanges", 1051646, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_ApprovalSheetMap")]
    protected ApprovalSheetMapChanges_Environment _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_ListItemToChange")]
    [Metadata("The CategoryMap sets up that relationship of the QualityObject's Category to a particular TriageSpec.", "CategoryMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Environment_Owner")]
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

    public Environment Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Category));
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

    public Environment TriageSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageSpec));
      }
    }

    public ApprovalSheetMapChanges_Environment ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (ApprovalSheetMapChanges_Environment) this.PropertyGet(nameof (ApprovalSheetMap));
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
