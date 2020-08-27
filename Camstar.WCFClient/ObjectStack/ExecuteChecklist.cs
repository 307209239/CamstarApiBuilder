// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklist
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
  public class ExecuteChecklist : GenericTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_ChecklistInstructions")]
    protected Primitive<string> _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_Checklist")]
    protected NamedSubentityRef _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_ServiceDetails")]
    protected ExecuteChecklistDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklist_Submit")]
    protected Primitive<bool> _Submit;

    public override bool Equals(object obj)
    {
      return obj is ExecuteChecklist && object.Equals((object) this._ChecklistInstructions, (object) ((ExecuteChecklist) obj)._ChecklistInstructions) && (object.Equals((object) this._Checklist, (object) ((ExecuteChecklist) obj)._Checklist) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ExecuteChecklist) obj)._ServiceDetails)) && object.Equals((object) this._Submit, (object) ((ExecuteChecklist) obj)._Submit) && base.Equals(obj);
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

    public ExecuteChecklistDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ExecuteChecklistDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }
  }
}
