// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplateMaint_Environment
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
  public class ProcessModelTemplateMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1051393, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_RuleList")]
    protected Environment _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_ObjectToChange")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplate", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_ObjectListInquiry")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplateBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_BaseToChange")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplateBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1048810, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_BusinessRule")]
    protected Environment _BusinessRule;
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplateChanges", false, false, false, "ProcessModelTemplateChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_ObjectChanges")]
    protected ProcessModelTemplateChanges_Environment _ObjectChanges;
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplate", false, false, false, "ProcessModelTemplate", 1051576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_ProcessObjectTemplateDetails")]
    protected ProcessModelTemplate_Environment _ProcessObjectTemplateDetails;
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Environment_ValidChildTypes")]
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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public ProcessModelTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessModelTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ProcessModelTemplate_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ProcessModelTemplate_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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
