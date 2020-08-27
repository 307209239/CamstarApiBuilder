// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleHandlerDataChanges_Info
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
  public class BusinessRuleHandlerDataChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Info_Script")]
    protected Info _Script;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Info_BizRuleHandlerType")]
    protected Info _BizRuleHandlerType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Info_ServiceType")]
    protected Info _ServiceType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Info_Parameters")]
    protected BizRuleHandlerParameterChanges_Info _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerDataChanges_Info_Name")]
    protected new Info _Name;

    public Info Script
    {
      [param: In] set
      {
        this.PropertySet(nameof (Script), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Script));
      }
    }

    public Info BizRuleHandlerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BizRuleHandlerType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BizRuleHandlerType));
      }
    }

    public Info ServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceType));
      }
    }

    public BizRuleHandlerParameterChanges_Info Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleHandlerParameterChanges_Info) this.PropertyGet(nameof (Parameters));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
