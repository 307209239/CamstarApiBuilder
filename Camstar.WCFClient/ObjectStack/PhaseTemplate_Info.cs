// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplate_Info
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
  public class PhaseTemplate_Info : ProcessObjectTemplate_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_AssigneeRole")]
    protected new Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Organizations")]
    protected new Info _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_CompleteWithinUOM")]
    protected new Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_onStartRules")]
    protected BusinessRuleData_Info _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_onCompleteRules")]
    protected BusinessRuleData_Info _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Checklist")]
    protected new Checklist_Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Details")]
    protected new ProcessObject_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_AllowReassignment")]
    protected new Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_ApprovalSheets")]
    protected ApprovalSheet_Info _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_AssigneeOption")]
    protected new Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_IsRequired")]
    protected new Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_AutoStart")]
    protected new Info _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_CompleteWithinQty")]
    protected new Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_DefaultAssigneeInfo")]
    protected new Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_ApprovalRequired")]
    protected new Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_AutoComplete")]
    protected new Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Assignee")]
    protected new Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_DocumentSet")]
    protected new Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Info_Status")]
    protected new Info _Status;

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

    public new Info AssigneeRole
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

    public new Info Organizations
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

    public new Info CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinUOM));
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

    public new Checklist_Info Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Checklist_Info) this.PropertyGet(nameof (Checklist));
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

    public new ProcessObject_Info Details
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

    public new Info AllowReassignment
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

    public ApprovalSheet_Info ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheet_Info) this.PropertyGet(nameof (ApprovalSheets));
      }
    }

    public new Info AssigneeOption
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

    public new Info IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRequired));
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

    public new Info AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoStart));
      }
    }

    public new Info CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public new Info DefaultAssigneeInfo
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

    public new Info ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public new Info AutoComplete
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

    public new Info Assignee
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

    public new Info DocumentSet
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
  }
}
