// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessWorkflowChanges
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
  public class BusinessProcessWorkflowChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_FirstStep")]
    protected NamedSubentityRef _FirstStep;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Steps")]
    protected StepChanges[] _Steps;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BusinessProcessWorkflowChanges && object.Equals((object) this._FirstStep, (object) ((BusinessProcessWorkflowChanges) obj)._FirstStep) && (this.CompareArrays((Array) this._Steps, (Array) ((BusinessProcessWorkflowChanges) obj)._Steps) && object.Equals((object) this._ObjectToChange, (object) ((BusinessProcessWorkflowChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Base, (object) ((BusinessProcessWorkflowChanges) obj)._Base) && object.Equals((object) this._IsRevOfRcd, (object) ((BusinessProcessWorkflowChanges) obj)._IsRevOfRcd) && object.Equals((object) this._Name, (object) ((BusinessProcessWorkflowChanges) obj)._Name)) && base.Equals(obj);
    }

    public NamedSubentityRef FirstStep
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

    public StepChanges[] Steps
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

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
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
