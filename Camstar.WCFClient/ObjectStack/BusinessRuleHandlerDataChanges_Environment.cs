// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleHandlerDataChanges_Environment
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
  public class BusinessRuleHandlerDataChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("Code Block", "", false, false, false, "String", 1050971, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Environment_Script")]
    protected Environment _Script;
    [Metadata("Enumeration for the Biz Rule Handler Type:\r\n1 = Script\r\n2 = Service\r\n3 = CLF\r\n4 = Method", "BizRuleHandlerTypeEnum", false, false, false, "Integer", 1051232, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Environment_BizRuleHandlerType")]
    protected Environment _BizRuleHandlerType;
    [Metadata("UpdateService", "", false, false, false, "Integer", 1050972, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Environment_ServiceType")]
    protected Environment _ServiceType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Environment_Parameters")]
    [Metadata("Business Rule Handler Parameter Changes", "BizRuleHandlerParameterChanges", false, false, false, "BizRuleHandlerParameterChanges", 1050947, false, true, false, null)]
    protected BizRuleHandlerParameterChanges_Environment _Parameters;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment Script
    {
      [param: In] set
      {
        this.PropertySet(nameof (Script), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Script));
      }
    }

    public Environment BizRuleHandlerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BizRuleHandlerType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BizRuleHandlerType));
      }
    }

    public Environment ServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceType));
      }
    }

    public BizRuleHandlerParameterChanges_Environment Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleHandlerParameterChanges_Environment) this.PropertyGet(nameof (Parameters));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
