// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleHandlerChanges_Environment
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
  public class BusinessRuleHandlerChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Business Rule Handler Data Changes", "BusinessRuleHandlerDataChanges", false, false, false, "BusinessRuleHandlerDataChanges", 1051182, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Environment_HandlerData")]
    protected BusinessRuleHandlerDataChanges_Environment _HandlerData;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Environment_ObjectToChange")]
    [Metadata("Business Rule Handler", "BusinessRuleHandler", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Environment_ValidationStatus")]
    [Metadata("Enumeration for the Biz Rule Handler Status:\r\n0 = NotValid\r\n1 = Valid", "BizRuleHandlerStatusEnum", false, false, false, "Integer", 1051185, false, false, true, null)]
    protected Environment _ValidationStatus;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051279, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Environment_ValidateOnSave")]
    protected Environment _ValidateOnSave;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleHandlerChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051173, false, false, false, null)]
    protected new Environment _Name;

    public BusinessRuleHandlerDataChanges_Environment HandlerData
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerData), (object) value);
      }
      get
      {
        return (BusinessRuleHandlerDataChanges_Environment) this.PropertyGet(nameof (HandlerData));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment ValidationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidationStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidationStatus));
      }
    }

    public Environment ValidateOnSave
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateOnSave), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidateOnSave));
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
