// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchRuleChanges_Environment
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
  public class DispatchRuleChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Environment_ObjectToChange")]
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRule", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Environment_DispatchDetails")]
    [Metadata("Dispatch Detail Change", "DispatchDetailChanges", false, false, false, "DispatchDetailChanges", 1050495, false, true, false, null)]
    protected DispatchDetailChanges_Environment _DispatchDetails;
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Environment_QueryType")]
    [Metadata("QueryType", "QueryTypeEnum", false, false, false, "Integer", 1050374, false, false, true, null)]
    protected Environment _QueryType;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050496, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Environment_EnforcementRange")]
    protected Environment _EnforcementRange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050371, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispatchRuleChanges_Environment_Name")]
    protected new Environment _Name;

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

    public DispatchDetailChanges_Environment DispatchDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchDetails), (object) value);
      }
      get
      {
        return (DispatchDetailChanges_Environment) this.PropertyGet(nameof (DispatchDetails));
      }
    }

    public Environment QueryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryType));
      }
    }

    public Environment EnforcementRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforcementRange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnforcementRange));
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
