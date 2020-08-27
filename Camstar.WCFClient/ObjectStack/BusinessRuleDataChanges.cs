// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleDataChanges
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
  public class BusinessRuleDataChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Condition")]
    protected Primitive<string> _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_BusinessRuleToLoad")]
    protected NamedObjectRef _BusinessRuleToLoad;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Parameters")]
    protected BizRuleParameterChanges[] _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Handlers")]
    protected NamedObjectRef[] _Handlers;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Scope")]
    protected Enumeration<BizRuleScopeEnum, int> _Scope;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_ContextType")]
    protected Enumeration<BizRuleHolderTypeEnum, int> _ContextType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_AlwaysExecute")]
    protected Primitive<bool> _AlwaysExecute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BusinessRuleDataChanges && object.Equals((object) this._Condition, (object) ((BusinessRuleDataChanges) obj)._Condition) && (object.Equals((object) this._BusinessRuleToLoad, (object) ((BusinessRuleDataChanges) obj)._BusinessRuleToLoad) && object.Equals((object) this._ObjectToChange, (object) ((BusinessRuleDataChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._Parameters, (Array) ((BusinessRuleDataChanges) obj)._Parameters) && this.CompareArrays((Array) this._Handlers, (Array) ((BusinessRuleDataChanges) obj)._Handlers) && (object.Equals((object) this._ListItemToChange, (object) ((BusinessRuleDataChanges) obj)._ListItemToChange) && object.Equals((object) this._Scope, (object) ((BusinessRuleDataChanges) obj)._Scope))) && (object.Equals((object) this._ContextType, (object) ((BusinessRuleDataChanges) obj)._ContextType) && object.Equals((object) this._AlwaysExecute, (object) ((BusinessRuleDataChanges) obj)._AlwaysExecute) && object.Equals((object) this._Name, (object) ((BusinessRuleDataChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> Condition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Condition), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Condition));
      }
    }

    public NamedObjectRef BusinessRuleToLoad
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleToLoad), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BusinessRuleToLoad));
      }
    }

    public NamedSubentityRef ObjectToChange
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

    public BizRuleParameterChanges[] Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleParameterChanges[]) this.PropertyGet(nameof (Parameters));
      }
    }

    public NamedObjectRef[] Handlers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handlers), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Handlers));
      }
    }

    public NamedSubentityRef ListItemToChange
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

    public Enumeration<BizRuleScopeEnum, int> Scope
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scope), (object) value);
      }
      get
      {
        return (Enumeration<BizRuleScopeEnum, int>) this.PropertyGet(nameof (Scope));
      }
    }

    public Enumeration<BizRuleHolderTypeEnum, int> ContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextType), (object) value);
      }
      get
      {
        return (Enumeration<BizRuleHolderTypeEnum, int>) this.PropertyGet(nameof (ContextType));
      }
    }

    public Primitive<bool> AlwaysExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AlwaysExecute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AlwaysExecute));
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
