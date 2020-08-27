// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PlanDispositionChanges))]
  [Serializable]
  public class PlanChanges : ProcessObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_ExecutionContextType")]
    protected new Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_CompleteWithinUOM")]
    protected new Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_ApprovalSheets")]
    protected ApprovalSheetChanges[] _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Prerequisites")]
    protected new NamedSubentityRef[] _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_onCompleteRules")]
    protected BusinessRuleDataChanges[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_onStartRules")]
    protected BusinessRuleDataChanges[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Details")]
    protected new ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_CompleteWithinQty")]
    protected new Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PlanChanges && object.Equals((object) this._ExecutionContextType, (object) ((PlanChanges) obj)._ExecutionContextType) && (object.Equals((object) this._CompleteWithinUOM, (object) ((PlanChanges) obj)._CompleteWithinUOM) && this.CompareArrays((Array) this._ApprovalSheets, (Array) ((PlanChanges) obj)._ApprovalSheets)) && (this.CompareArrays((Array) this._Prerequisites, (Array) ((PlanChanges) obj)._Prerequisites) && object.Equals((object) this._ObjectToChange, (object) ((PlanChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((PlanChanges) obj)._ListItemToChange) && this.CompareArrays((Array) this._onCompleteRules, (Array) ((PlanChanges) obj)._onCompleteRules))) && (this.CompareArrays((Array) this._onStartRules, (Array) ((PlanChanges) obj)._onStartRules) && this.CompareArrays((Array) this._Details, (Array) ((PlanChanges) obj)._Details) && (object.Equals((object) this._CompleteWithinQty, (object) ((PlanChanges) obj)._CompleteWithinQty) && object.Equals((object) this._Name, (object) ((PlanChanges) obj)._Name))) && base.Equals(obj);
    }

    public new Primitive<int> ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public new Enumeration<DurationUOMEnum, string> CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public ApprovalSheetChanges[] ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheetChanges[]) this.PropertyGet(nameof (ApprovalSheets));
      }
    }

    public new NamedSubentityRef[] Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public BusinessRuleDataChanges[] onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public BusinessRuleDataChanges[] onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new ProcessObjectChanges[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges[]) this.PropertyGet(nameof (Details));
      }
    }

    public new Primitive<int> CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
