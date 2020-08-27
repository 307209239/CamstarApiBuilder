// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleHandlerDataChanges
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
  public class BusinessRuleHandlerDataChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Script")]
    protected Primitive<string> _Script;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_BizRuleHandlerType")]
    protected Enumeration<BizRuleHandlerTypeEnum, int> _BizRuleHandlerType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_ServiceType")]
    protected Primitive<int> _ServiceType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Parameters")]
    protected BizRuleHandlerParameterChanges[] _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BusinessRuleHandlerDataChanges && object.Equals((object) this._Script, (object) ((BusinessRuleHandlerDataChanges) obj)._Script) && (object.Equals((object) this._BizRuleHandlerType, (object) ((BusinessRuleHandlerDataChanges) obj)._BizRuleHandlerType) && object.Equals((object) this._ServiceType, (object) ((BusinessRuleHandlerDataChanges) obj)._ServiceType)) && (this.CompareArrays((Array) this._Parameters, (Array) ((BusinessRuleHandlerDataChanges) obj)._Parameters) && object.Equals((object) this._Name, (object) ((BusinessRuleHandlerDataChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> Script
    {
      [param: In] set
      {
        this.PropertySet(nameof (Script), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Script));
      }
    }

    public Enumeration<BizRuleHandlerTypeEnum, int> BizRuleHandlerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BizRuleHandlerType), (object) value);
      }
      get
      {
        return (Enumeration<BizRuleHandlerTypeEnum, int>) this.PropertyGet(nameof (BizRuleHandlerType));
      }
    }

    public Primitive<int> ServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ServiceType));
      }
    }

    public BizRuleHandlerParameterChanges[] Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleHandlerParameterChanges[]) this.PropertyGet(nameof (Parameters));
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
