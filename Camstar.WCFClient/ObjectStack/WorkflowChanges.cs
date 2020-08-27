// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkflowChanges
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
  public class WorkflowChanges : BusinessProcessWorkflowChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Gates")]
    protected GateChanges[] _Gates;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_FirstStep")]
    protected new NamedSubentityRef _FirstStep;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_ERPRoute")]
    protected RevisionedObjectRef _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Steps")]
    protected new StepChanges[] _Steps;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Image")]
    protected Primitive<string> _Image;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_TotalYield")]
    protected Primitive<double> _TotalYield;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_TotalCycleTime")]
    protected Primitive<double> _TotalCycleTime;

    public override bool Equals(object obj)
    {
      return obj is WorkflowChanges && this.CompareArrays((Array) this._Gates, (Array) ((WorkflowChanges) obj)._Gates) && (object.Equals((object) this._FirstStep, (object) ((WorkflowChanges) obj)._FirstStep) && object.Equals((object) this._ERPRoute, (object) ((WorkflowChanges) obj)._ERPRoute)) && (this.CompareArrays((Array) this._Steps, (Array) ((WorkflowChanges) obj)._Steps) && object.Equals((object) this._Image, (object) ((WorkflowChanges) obj)._Image) && (object.Equals((object) this._TotalYield, (object) ((WorkflowChanges) obj)._TotalYield) && object.Equals((object) this._ObjectToChange, (object) ((WorkflowChanges) obj)._ObjectToChange))) && (object.Equals((object) this._IsRevOfRcd, (object) ((WorkflowChanges) obj)._IsRevOfRcd) && object.Equals((object) this._Name, (object) ((WorkflowChanges) obj)._Name) && (object.Equals((object) this._Base, (object) ((WorkflowChanges) obj)._Base) && object.Equals((object) this._TotalCycleTime, (object) ((WorkflowChanges) obj)._TotalCycleTime))) && base.Equals(obj);
    }

    public GateChanges[] Gates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gates), (object) value);
      }
      get
      {
        return (GateChanges[]) this.PropertyGet(nameof (Gates));
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

    public RevisionedObjectRef ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ERPRoute));
      }
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

    public Primitive<string> Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Image));
      }
    }

    public Primitive<double> TotalYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalYield), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TotalYield));
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

    public Primitive<double> TotalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalCycleTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TotalCycleTime));
      }
    }
  }
}
