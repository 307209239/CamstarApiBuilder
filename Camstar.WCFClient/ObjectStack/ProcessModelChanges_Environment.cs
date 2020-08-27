// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelChanges_Environment
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
  public class ProcessModelChanges_Environment : ProcessObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_ExecutionContextType")]
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, "7697")]
    protected new Environment _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_RuleList")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051388, false, false, false, null)]
    protected new Environment _RuleList;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1052122, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_Details")]
    protected new ProcessObjectChanges_Environment _Details;
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052115, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_onCompleteRules")]
    protected BusinessRuleDataChanges_Environment _onCompleteRules;
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052114, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_onStartRules")]
    protected BusinessRuleDataChanges_Environment _onStartRules;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public new Environment RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RuleList));
      }
    }

    public new ProcessObjectChanges_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Environment) this.PropertyGet(nameof (Details));
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

    public BusinessRuleDataChanges_Environment onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Environment) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public BusinessRuleDataChanges_Environment onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Environment) this.PropertyGet(nameof (onStartRules));
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
