// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackableObjectCurrentStatus
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
  public class TrackableObjectCurrentStatus : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_LastMoveDate")]
    protected Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_LastMoveDateGMT")]
    protected Primitive<DateTime> _LastMoveDateGMT;

    public override bool Equals(object obj)
    {
      return obj is TrackableObjectCurrentStatus && object.Equals((object) this._WorkflowStep, (object) ((TrackableObjectCurrentStatus) obj)._WorkflowStep) && (this.CompareArrays((Array) this._WorkflowStack, (Array) ((TrackableObjectCurrentStatus) obj)._WorkflowStack) && object.Equals((object) this._Workflow, (object) ((TrackableObjectCurrentStatus) obj)._Workflow)) && (object.Equals((object) this._LastMoveDate, (object) ((TrackableObjectCurrentStatus) obj)._LastMoveDate) && object.Equals((object) this._LastMoveDateGMT, (object) ((TrackableObjectCurrentStatus) obj)._LastMoveDateGMT)) && base.Equals(obj);
    }

    public NamedSubentityRef WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public NamedSubentityRef[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public Primitive<DateTime> LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Primitive<DateTime> LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }
  }
}
