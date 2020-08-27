// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleData
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
  public class BusinessRuleData : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Parameters")]
    protected BizRuleParameter[] _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_ContextType")]
    protected Enumeration<BizRuleHolderTypeEnum, int> _ContextType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Handlers")]
    protected NamedObjectRef[] _Handlers;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Scope")]
    protected Enumeration<BizRuleScopeEnum, int> _Scope;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Condition")]
    protected Primitive<string> _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_AlwaysExecute")]
    protected Primitive<bool> _AlwaysExecute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is BusinessRuleData && object.Equals((object) this._DisplayName, (object) ((BusinessRuleData) obj)._DisplayName) && (object.Equals((object) this._ExportImportKey, (object) ((BusinessRuleData) obj)._ExportImportKey) && this.CompareArrays((Array) this._Parameters, (Array) ((BusinessRuleData) obj)._Parameters)) && (object.Equals((object) this._ContextType, (object) ((BusinessRuleData) obj)._ContextType) && this.CompareArrays((Array) this._Handlers, (Array) ((BusinessRuleData) obj)._Handlers) && (object.Equals((object) this._Scope, (object) ((BusinessRuleData) obj)._Scope) && object.Equals((object) this._Condition, (object) ((BusinessRuleData) obj)._Condition))) && (object.Equals((object) this._AlwaysExecute, (object) ((BusinessRuleData) obj)._AlwaysExecute) && object.Equals((object) this._Name, (object) ((BusinessRuleData) obj)._Name) && object.Equals((object) this._IsFrozen, (object) ((BusinessRuleData) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public BizRuleParameter[] Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleParameter[]) this.PropertyGet(nameof (Parameters));
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

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
