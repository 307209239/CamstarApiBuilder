// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTemplateMaint_Info
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
  public class ProcessObjectTemplateMaint_Info : NamedDataObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ObjectChanges")]
    protected ProcessObjectTmpltChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ProcessObjectTemplateDetails")]
    protected ProcessObjectTemplate_Info _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_BusinessRule")]
    protected Info _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_Templates")]
    protected Info _Templates;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Info_ValidChildTypes")]
    protected Info _ValidChildTypes;

    public Info RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RuleList));
      }
    }

    public ProcessObjectTmpltChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectTmpltChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ProcessObjectTemplate_Info ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ProcessObjectTemplate_Info) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public Info BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Info ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public ExecuteChecklist_Info ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Info) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Templates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Templates), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Templates));
      }
    }

    public Info ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
