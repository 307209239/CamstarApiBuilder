// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageQualityObject_Environment
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
  public class TriageQualityObject_Environment : QualityTxn_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_QualityObjectRole")]
    protected Environment _QualityObjectRole;
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, false, "Integer", 1051206, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_Category")]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, false, "NamedObjectRef", 1051051, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_ChecklistTemplate")]
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052971, false, false, true, null)]
    protected Environment _ChecklistTemplate;
    [Metadata("The TriageSpecDetail identifies the default values to assign to the Event or CAR as part of the Escalation process.", "TriageSpecDetail", false, false, false, "NamedSubentityRef", 1051443, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_TriageSpecDetail")]
    protected Environment _TriageSpecDetail;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_ProcessModelTemplate")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplate", false, false, false, "RevisionedObjectRef", 1052177, false, false, true, null)]
    protected Environment _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_ProcessModelMaint")]
    [Metadata("Maintain the Process subentity of a Quality object.  This can be used to change the attributes of an already assigned process, copy a ProcessModel to create a new process, or to manually replace the entire subentity structure of an assigned process.", "ProcessModelMaint", false, false, false, "ProcessModelMaint", 1051571, false, false, false, null)]
    protected ProcessModelMaint_Environment _ProcessModelMaint;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_AssignChecklist")]
    [Metadata("Assign Checklist transaction is used to assign checklist to Trackable Object.", "AssignChecklist", false, false, false, "AssignChecklist", 1053003, true, false, false, null)]
    protected AssignChecklist_Environment _AssignChecklist;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051655, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_TriageComplete")]
    protected Environment _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_RouteProcessModelEnabled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052278, false, false, false, "0")]
    protected Environment _RouteProcessModelEnabled;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051728, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_IsCARRequiredToClose")]
    protected Environment _IsCARRequiredToClose;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052178, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_RouteProcessModel")]
    protected Environment _RouteProcessModel;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TriageQualityObject_Environment_QualityObjectOwner")]
    protected Environment _QualityObjectOwner;

    public Environment QualityObjectRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectRole));
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

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevel));
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

    public Environment TriageSpecDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageSpecDetail));
      }
    }

    public Environment ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public ProcessModelMaint_Environment ProcessModelMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelMaint), (object) value);
      }
      get
      {
        return (ProcessModelMaint_Environment) this.PropertyGet(nameof (ProcessModelMaint));
      }
    }

    public AssignChecklist_Environment AssignChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignChecklist), (object) value);
      }
      get
      {
        return (AssignChecklist_Environment) this.PropertyGet(nameof (AssignChecklist));
      }
    }

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Environment RouteProcessModelEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModelEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteProcessModelEnabled));
      }
    }

    public Environment IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public Environment RouteProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteProcessModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteProcessModel));
      }
    }

    public Environment QualityObjectOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObjectOwner));
      }
    }
  }
}
