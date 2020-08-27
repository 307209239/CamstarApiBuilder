// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivityDispositionChanges))]
  [KnownType(typeof (ActivityInvestigationChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ActivityChanges : ProcessObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_ExecutionContextType")]
    protected new Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_CompleteWithinUOM")]
    protected new Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Prerequisites")]
    protected new NamedSubentityRef[] _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_onExecuteRules")]
    protected BusinessRuleDataChanges[] _onExecuteRules;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_CompleteWithinQty")]
    protected new Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_AutoExecute")]
    protected Primitive<bool> _AutoExecute;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityChanges && object.Equals((object) this._ExecutionContextType, (object) ((ActivityChanges) obj)._ExecutionContextType) && (object.Equals((object) this._Description, (object) ((ActivityChanges) obj)._Description) && object.Equals((object) this._ListItemToChange, (object) ((ActivityChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((ActivityChanges) obj)._ObjectToChange) && object.Equals((object) this._CompleteWithinUOM, (object) ((ActivityChanges) obj)._CompleteWithinUOM) && (this.CompareArrays((Array) this._Prerequisites, (Array) ((ActivityChanges) obj)._Prerequisites) && this.CompareArrays((Array) this._onExecuteRules, (Array) ((ActivityChanges) obj)._onExecuteRules))) && (object.Equals((object) this._CompleteWithinQty, (object) ((ActivityChanges) obj)._CompleteWithinQty) && object.Equals((object) this._AutoExecute, (object) ((ActivityChanges) obj)._AutoExecute) && object.Equals((object) this._Name, (object) ((ActivityChanges) obj)._Name)) && base.Equals(obj);
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

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
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

    public BusinessRuleDataChanges[] onExecuteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onExecuteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onExecuteRules));
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

    public Primitive<bool> AutoExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoExecute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoExecute));
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
