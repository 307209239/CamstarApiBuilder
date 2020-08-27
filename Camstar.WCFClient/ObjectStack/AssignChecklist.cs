// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChecklist
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
  public class AssignChecklist : GenericTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_Checklist")]
    protected NamedSubentityRef _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "AssignChecklist_ServiceDetails")]
    protected ChecklistEntryDetails[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is AssignChecklist && object.Equals((object) this._ChecklistInstructions, (object) ((AssignChecklist) obj)._ChecklistInstructions) && (object.Equals((object) this._Checklist, (object) ((AssignChecklist) obj)._Checklist) && object.Equals((object) this._ChecklistTemplate, (object) ((AssignChecklist) obj)._ChecklistTemplate)) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((AssignChecklist) obj)._ServiceDetails) && base.Equals(obj);
    }

    public Primitive<string> ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChecklistInstructions));
      }
    }

    public NamedSubentityRef Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Checklist));
      }
    }

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public ChecklistEntryDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChecklistEntryDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
