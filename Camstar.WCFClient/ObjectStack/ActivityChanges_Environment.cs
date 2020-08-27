// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivityDispositionChanges_Environment))]
  [KnownType(typeof (ActivityInvestigationChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ActivityChanges_Environment : ProcessObjectChanges_Environment
  {
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, "7694")]
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_ExecutionContextType")]
    protected new Environment _ExecutionContextType;
    [Metadata("Instruction", "", false, false, false, "String", 1051642, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_Description")]
    protected new Environment _Description;
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "ActivityChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_ObjectToChange")]
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051692, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_CompleteWithinUOM")]
    protected new Environment _CompleteWithinUOM;
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "ActivityChanges", false, false, false, "NamedSubentityRef", 1051405, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_Prerequisites")]
    protected new Environment _Prerequisites;
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052116, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_onExecuteRules")]
    protected BusinessRuleDataChanges_Environment _onExecuteRules;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    protected new Environment _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_AutoExecute")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051378, false, false, false, "0")]
    protected Environment _AutoExecute;
    [DataMember(EmitDefaultValue = false, Name = "ActivityChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
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

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public new Environment CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public new Environment Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Prerequisites));
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

    public new Environment CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithinQty));
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
