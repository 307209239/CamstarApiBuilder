// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleChanges_Environment
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
  public class BusinessRuleChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1051195, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleChanges_Environment_Data")]
    protected BusinessRuleDataChanges_Environment _Data;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleChanges_Environment_ObjectToChange")]
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051186, false, false, false, null)]
    protected new Environment _Name;

    public BusinessRuleDataChanges_Environment Data
    {
      [param: In] set
      {
        this.PropertySet(nameof (Data), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Environment) this.PropertyGet(nameof (Data));
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
