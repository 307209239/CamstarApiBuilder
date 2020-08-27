// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectMaint_Info
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
  public class ProcessObjectMaint_Info : SubentityMaintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ObjectChanges")]
    protected ProcessObjectChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_BusinessRule")]
    protected Info _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ValidChildTypes")]
    protected Info _ValidChildTypes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_Template")]
    protected Info _Template;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_StructureChanges")]
    protected Info _StructureChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Info_ParentDataObject")]
    protected new Info _ParentDataObject;

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

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
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

    public ProcessObjectChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Info) this.PropertyGet(nameof (ObjectChanges));
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

    public Info Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Template));
      }
    }

    public Info StructureChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (StructureChanges), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StructureChanges));
      }
    }

    public new Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
