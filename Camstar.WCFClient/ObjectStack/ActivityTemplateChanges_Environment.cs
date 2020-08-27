// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateChanges_Environment
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
  public class ActivityTemplateChanges_Environment : ProcessObjectTmpltChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, true, null)]
    protected Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_ExecutionContextType")]
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, "7694")]
    protected new Environment _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_Details")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1049090, false, true, false, null)]
    protected new ProcessObjectChanges_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_onExecuteRules")]
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1051737, false, true, false, null)]
    protected BusinessRuleDataChanges_Environment _onExecuteRules;
    [Metadata("A template of an Activity, which is the basic unit of work used to process a Quality object.", "ActivityTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_AutoExecute")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051378, false, false, false, "0")]
    protected Environment _AutoExecute;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

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

    public BusinessRuleDataChanges_Environment onExecuteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onExecuteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Environment) this.PropertyGet(nameof (onExecuteRules));
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

    public Environment AutoExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoExecute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoExecute));
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
