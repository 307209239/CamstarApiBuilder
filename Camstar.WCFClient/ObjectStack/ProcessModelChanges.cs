// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelChanges
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
  public class ProcessModelChanges : ProcessObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_ExecutionContextType")]
    protected new Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_RuleList")]
    protected new Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Details")]
    protected new ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_onCompleteRules")]
    protected BusinessRuleDataChanges[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_onStartRules")]
    protected BusinessRuleDataChanges[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ProcessModelChanges && object.Equals((object) this._ExecutionContextType, (object) ((ProcessModelChanges) obj)._ExecutionContextType) && (object.Equals((object) this._RuleList, (object) ((ProcessModelChanges) obj)._RuleList) && this.CompareArrays((Array) this._Details, (Array) ((ProcessModelChanges) obj)._Details)) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessModelChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._onCompleteRules, (Array) ((ProcessModelChanges) obj)._onCompleteRules) && (this.CompareArrays((Array) this._onStartRules, (Array) ((ProcessModelChanges) obj)._onStartRules) && object.Equals((object) this._Name, (object) ((ProcessModelChanges) obj)._Name))) && base.Equals(obj);
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

    public new Primitive<string> RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RuleList));
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
