// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplateMaint_Info
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
  public class ProcessModelTemplateMaint_Info : RevisionedObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_BaseToChange")]
    protected new Info _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_BusinessRule")]
    protected Info _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_ObjectChanges")]
    protected ProcessModelTemplateChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_ProcessObjectTemplateDetails")]
    protected ProcessModelTemplate_Info _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_Info_ValidChildTypes")]
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

    public new Info BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BaseToChange));
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

    public ProcessModelTemplateChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessModelTemplateChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ProcessModelTemplate_Info ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ProcessModelTemplate_Info) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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
