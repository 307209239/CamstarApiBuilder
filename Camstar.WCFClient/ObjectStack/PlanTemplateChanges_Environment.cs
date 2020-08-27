// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateChanges_Environment
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
  public class PlanTemplateChanges_Environment : ProcessObjectTmpltChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_ExecutionContextType")]
    [Metadata("CDOType", "", false, false, false, "Integer", 1049631, false, false, false, "7696")]
    protected new Environment _ExecutionContextType;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheetChanges", false, false, false, "ApprovalSheetChanges", 1052012, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_ApprovalSheets")]
    protected ApprovalSheetChanges_Environment _ApprovalSheets;
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_onCompleteRules")]
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052119, false, true, false, null)]
    protected BusinessRuleDataChanges_Environment _onCompleteRules;
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "BusinessRuleDataChanges", 1052120, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_onStartRules")]
    protected BusinessRuleDataChanges_Environment _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_Details")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1049090, false, true, false, null)]
    protected new ProcessObjectChanges_Environment _Details;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Environment_Name")]
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
