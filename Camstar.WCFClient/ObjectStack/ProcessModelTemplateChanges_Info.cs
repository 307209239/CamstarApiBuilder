// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplateChanges_Info
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
  public class ProcessModelTemplateChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_WIPMsgDefMgr")]
    protected new WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_ExecutionContextType")]
    protected Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_AssigneeRole")]
    protected Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_EffectiveFromDateGMT")]
    protected Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_Organizations")]
    protected Info _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_onCompleteRules")]
    protected BusinessRuleDataChanges_Info _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_AssigneeOption")]
    protected Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_onStartRules")]
    protected BusinessRuleDataChanges_Info _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_AllowReassignment")]
    protected Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_Details")]
    protected ProcessObjectChanges_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_EffectiveThruDateGMT")]
    protected Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_AutoComplete")]
    protected Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_DefaultAssigneeInfo")]
    protected Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_Assignee")]
    protected Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Info_Name")]
    protected new Info _Name;

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public new WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Info ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

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

    public Info AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Info EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Info Organizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organizations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organizations));
      }
    }

    public BusinessRuleDataChanges_Info onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public Info AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public BusinessRuleDataChanges_Info onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onStartRules));
      }
    }

    public Info AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public ProcessObjectChanges_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Info) this.PropertyGet(nameof (Details));
      }
    }

    public Info EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Info EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
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

    public Info EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Info AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public Info DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultAssigneeInfo));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Info Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Assignee));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
