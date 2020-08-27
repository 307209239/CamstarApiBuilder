// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateChanges
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
  public class PlanTemplateChanges : ProcessObjectTmpltChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_ExecutionContextType")]
    protected new Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_ApprovalSheets")]
    protected ApprovalSheetChanges[] _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_onCompleteRules")]
    protected BusinessRuleDataChanges[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_onStartRules")]
    protected BusinessRuleDataChanges[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Details")]
    protected new ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PlanTemplateChanges && object.Equals((object) this._ExecutionContextType, (object) ((PlanTemplateChanges) obj)._ExecutionContextType) && (this.CompareArrays((Array) this._ApprovalSheets, (Array) ((PlanTemplateChanges) obj)._ApprovalSheets) && object.Equals((object) this._ObjectToChange, (object) ((PlanTemplateChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._onCompleteRules, (Array) ((PlanTemplateChanges) obj)._onCompleteRules) && this.CompareArrays((Array) this._onStartRules, (Array) ((PlanTemplateChanges) obj)._onStartRules) && (this.CompareArrays((Array) this._Details, (Array) ((PlanTemplateChanges) obj)._Details) && object.Equals((object) this._Name, (object) ((PlanTemplateChanges) obj)._Name))) && base.Equals(obj);
    }

    public new Primitive<int> ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public ApprovalSheetChanges[] ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheetChanges[]) this.PropertyGet(nameof (ApprovalSheets));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public BusinessRuleDataChanges[] onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public BusinessRuleDataChanges[] onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new ProcessObjectChanges[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges[]) this.PropertyGet(nameof (Details));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
