// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PhaseDispositionChanges_Environment))]
  [Serializable]
  public class PhaseChanges_Environment : ProcessObjectChanges_Environment
  {
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, "7695")]
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_ExecutionContextType")]
    protected new Environment _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_Details")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1049090, false, true, false, null)]
    protected new ProcessObjectChanges_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_CompleteWithinUOM")]
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, false, "String", 1051692, false, false, true, null)]
    protected new Environment _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_onStartRules")]
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052118, false, true, false, null)]
    protected BusinessRuleDataChanges_Environment _onStartRules;
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "PhaseChanges", false, false, false, "NamedSubentityRef", 1051405, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_Prerequisites")]
    protected new Environment _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_onCompleteRules")]
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052117, false, true, false, null)]
    protected BusinessRuleDataChanges_Environment _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_ApprovalSheets")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheetChanges", false, false, false, "ApprovalSheetChanges", 1052012, false, true, false, null)]
    protected ApprovalSheetChanges_Environment _ApprovalSheets;
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "Phase", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_ListItemToChange")]
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "PhaseChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051407, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_CompleteWithinQty")]
    protected new Environment _CompleteWithinQty;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseChanges_Environment_Name")]
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
