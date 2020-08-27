// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTmpltChanges_Info
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
  public class ProcessObjectTmpltChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_ExecutionContextType")]
    protected Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_AssigneeRole")]
    protected Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Organizations")]
    protected Info _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Checklist")]
    protected ChecklistChanges_Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_AllowReassignment")]
    protected Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Details")]
    protected ProcessObjectChanges_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_AssigneeOption")]
    protected Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_CompleteWithinUOM")]
    protected Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_CompleteWithinQty")]
    protected Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_AutoStart")]
    protected Info _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_DefaultAssigneeInfo")]
    protected Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_ApprovalRequired")]
    protected Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_AutoComplete")]
    protected Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_IsRequired")]
    protected Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Assignee")]
    protected Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Info_Status")]
    protected Info _Status;

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

    public ChecklistChanges_Info Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (ChecklistChanges_Info) this.PropertyGet(nameof (Checklist));
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

    public Info CompleteWithinUOM
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

    public Info CompleteWithinQty
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

    public Info AutoStart
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

    public Info ApprovalRequired
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

    public Info IsRequired
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

    public Info Status
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
