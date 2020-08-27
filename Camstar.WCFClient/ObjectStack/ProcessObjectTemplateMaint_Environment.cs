// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTemplateMaint_Environment
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
  public class ProcessObjectTemplateMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_RuleList")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051392, false, false, false, null)]
    protected Environment _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ObjectChanges")]
    [Metadata("An abstract class to define the common fields", "ProcessObjectTmpltChanges", false, false, false, "ProcessObjectTmpltChanges", 1048873, true, false, false, null)]
    protected ProcessObjectTmpltChanges_Environment _ObjectChanges;
    [Metadata("An abstract class to define the common fields", "ProcessObjectTemplate", false, false, false, "ProcessObjectTemplate", 1051576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ProcessObjectTemplateDetails")]
    protected ProcessObjectTemplate_Environment _ProcessObjectTemplateDetails;
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1048810, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_BusinessRule")]
    protected Environment _BusinessRule;
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052389, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ChecklistTemplate")]
    protected Environment _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ExecuteChecklist")]
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    protected ExecuteChecklist_Environment _ExecuteChecklist;
    [Metadata("An abstract class to define the common fields", "ProcessObjectTemplate", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ObjectToChange")]
    [Metadata("An abstract class to define the common fields", "ProcessObjectTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_Templates")]
    [Metadata("Generic String", "", false, false, false, "String", 1052065, false, false, true, null)]
    protected Environment _Templates;
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Environment_ValidChildTypes")]
    protected Environment _ValidChildTypes;

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

    public ProcessObjectTmpltChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectTmpltChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ProcessObjectTemplate_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ProcessObjectTemplate_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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

    public Environment Templates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Templates), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Templates));
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
  }
}
