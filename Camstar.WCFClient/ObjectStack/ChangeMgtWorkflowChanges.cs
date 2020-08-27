// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtWorkflowChanges
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
  public class ChangeMgtWorkflowChanges : BusinessProcessWorkflowChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Steps")]
    protected new StepChanges[] _Steps;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_FirstStep")]
    protected new NamedSubentityRef _FirstStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtWorkflowChanges && this.CompareArrays((Array) this._Steps, (Array) ((ChangeMgtWorkflowChanges) obj)._Steps) && (object.Equals((object) this._FirstStep, (object) ((ChangeMgtWorkflowChanges) obj)._FirstStep) && object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtWorkflowChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Base, (object) ((ChangeMgtWorkflowChanges) obj)._Base) && object.Equals((object) this._Name, (object) ((ChangeMgtWorkflowChanges) obj)._Name)) && base.Equals(obj);
    }

    public new StepChanges[] Steps
    {
      [param: In] set
      {
        this.PropertySet(nameof (Steps), (object) value);
      }
      get
      {
        return (StepChanges[]) this.PropertyGet(nameof (Steps));
      }
    }

    public new NamedSubentityRef FirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FirstStep));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
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
