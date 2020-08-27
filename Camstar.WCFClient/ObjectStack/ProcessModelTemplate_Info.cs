// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplate_Info
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
  public class ProcessModelTemplate_Info : RevisionedObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_AssigneeRole")]
    protected Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_EffectiveFromDateGMT")]
    protected Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_onCompleteRules")]
    protected BusinessRuleData_Info _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Organizations")]
    protected Info _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_onStartRules")]
    protected BusinessRuleData_Info _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Details")]
    protected ProcessObject_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_EffectiveThruDateGMT")]
    protected Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_AssigneeOption")]
    protected Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_AllowReassignment")]
    protected Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_DefaultAssigneeInfo")]
    protected Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_AutoComplete")]
    protected Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Assignee")]
    protected Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Status")]
    protected new Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Info_Revision")]
    protected new Info _Revision;

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

    public BusinessRuleData_Info onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Info) this.PropertyGet(nameof (onCompleteRules));
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

    public new Info ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Info FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTags));
      }
    }

    public BusinessRuleData_Info onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Info) this.PropertyGet(nameof (onStartRules));
      }
    }

    public ProcessObject_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (Details));
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

    public new Info AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Info InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
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

    public new Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
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

    public new ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }
  }
}
