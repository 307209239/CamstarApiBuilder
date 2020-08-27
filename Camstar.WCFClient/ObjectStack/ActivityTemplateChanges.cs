// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateChanges
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
  public class ActivityTemplateChanges : ProcessObjectTmpltChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_ExecutionContextType")]
    protected new Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Details")]
    protected new ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_onExecuteRules")]
    protected BusinessRuleDataChanges[] _onExecuteRules;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_AutoExecute")]
    protected Primitive<bool> _AutoExecute;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityTemplateChanges && object.Equals((object) this._DataCollectionDef, (object) ((ActivityTemplateChanges) obj)._DataCollectionDef) && (object.Equals((object) this._ExecutionContextType, (object) ((ActivityTemplateChanges) obj)._ExecutionContextType) && this.CompareArrays((Array) this._Details, (Array) ((ActivityTemplateChanges) obj)._Details)) && (this.CompareArrays((Array) this._onExecuteRules, (Array) ((ActivityTemplateChanges) obj)._onExecuteRules) && object.Equals((object) this._ObjectToChange, (object) ((ActivityTemplateChanges) obj)._ObjectToChange) && (object.Equals((object) this._AutoExecute, (object) ((ActivityTemplateChanges) obj)._AutoExecute) && object.Equals((object) this._Name, (object) ((ActivityTemplateChanges) obj)._Name))) && base.Equals(obj);
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
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

    public BusinessRuleDataChanges[] onExecuteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onExecuteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onExecuteRules));
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

    public Primitive<bool> AutoExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoExecute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoExecute));
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
