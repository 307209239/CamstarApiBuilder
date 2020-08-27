// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectMaint_Environment
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
  public class ProcessObjectMaint_Environment : SubentityMaintenance_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_RuleList")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051394, false, false, false, null)]
    protected Environment _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ObjectListInquiry")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052389, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051618, false, false, true, null)]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ObjectToChange")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ObjectChanges")]
    protected ProcessObjectChanges_Environment _ObjectChanges;
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ExecuteChecklist")]
    protected ExecuteChecklist_Environment _ExecuteChecklist;
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1048810, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_BusinessRule")]
    protected Environment _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ValidChildTypes")]
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    protected Environment _ValidChildTypes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_Template")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051395, false, false, true, null)]
    protected Environment _Template;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_StructureChanges")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051986, false, false, false, null)]
    protected Environment _StructureChanges;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050488, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Environment_ParentDataObject")]
    protected new Environment _ParentDataObject;

    public Environment RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RuleList));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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

    public ProcessObjectChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ExecuteChecklist_Environment ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Environment BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Environment ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidChildTypes));
      }
    }

    public Environment Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Template));
      }
    }

    public Environment StructureChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (StructureChanges), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StructureChanges));
      }
    }

    public new Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
