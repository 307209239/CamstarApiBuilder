// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (PhaseDispositionChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class PhaseChanges : ProcessObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_ExecutionContextType")]
    protected new Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Details")]
    protected new ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_CompleteWithinUOM")]
    protected new Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_onStartRules")]
    protected BusinessRuleDataChanges[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Prerequisites")]
    protected new NamedSubentityRef[] _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_onCompleteRules")]
    protected BusinessRuleDataChanges[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_ApprovalSheets")]
    protected ApprovalSheetChanges[] _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_CompleteWithinQty")]
    protected new Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PhaseChanges && object.Equals((object) this._ExecutionContextType, (object) ((PhaseChanges) obj)._ExecutionContextType) && (this.CompareArrays((Array) this._Details, (Array) ((PhaseChanges) obj)._Details) && object.Equals((object) this._CompleteWithinUOM, (object) ((PhaseChanges) obj)._CompleteWithinUOM)) && (this.CompareArrays((Array) this._onStartRules, (Array) ((PhaseChanges) obj)._onStartRules) && this.CompareArrays((Array) this._Prerequisites, (Array) ((PhaseChanges) obj)._Prerequisites) && (this.CompareArrays((Array) this._onCompleteRules, (Array) ((PhaseChanges) obj)._onCompleteRules) && this.CompareArrays((Array) this._ApprovalSheets, (Array) ((PhaseChanges) obj)._ApprovalSheets))) && (object.Equals((object) this._ObjectToChange, (object) ((PhaseChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((PhaseChanges) obj)._ListItemToChange) && (object.Equals((object) this._CompleteWithinQty, (object) ((PhaseChanges) obj)._CompleteWithinQty) && object.Equals((object) this._Name, (object) ((PhaseChanges) obj)._Name))) && base.Equals(obj);
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
