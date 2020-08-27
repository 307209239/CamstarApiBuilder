// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PlanDispositionChanges_Environment))]
  [Serializable]
  public class PlanChanges_Environment : ProcessObjectChanges_Environment
  {
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, "7696")]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_ExecutionContextType")]
    protected new Environment _ExecutionContextType;
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051692, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_CompleteWithinUOM")]
    protected new Environment _CompleteWithinUOM;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheetChanges", false, false, false, "ApprovalSheetChanges", 1052012, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_ApprovalSheets")]
    protected ApprovalSheetChanges_Environment _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_Prerequisites")]
    [Metadata("A plan is a list of activities used during the processing of a Quality object", "PlanChanges", false, false, false, "NamedSubentityRef", 1051405, false, true, true, null)]
    protected new Environment _Prerequisites;
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A plan is a list of activities used during the processing of a Quality object", "PlanChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_onCompleteRules")]
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052119, false, true, false, null)]
    protected BusinessRuleDataChanges_Environment _onCompleteRules;
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052120, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_onStartRules")]
    protected BusinessRuleDataChanges_Environment _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_Details")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1052212, false, true, false, null)]
    protected new ProcessObjectChanges_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    protected new Environment _CompleteWithinQty;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanChanges_Environment_Name")]
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

    public ApprovalSheetChanges_Environment ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheetChanges_Environment) this.PropertyGet(nameof (ApprovalSheets));
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
