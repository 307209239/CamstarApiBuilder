// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackableObject
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
  public class TrackableObject : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_WorkflowNavigator")]
    protected SubentityRef _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_CurrentStatus")]
    protected TrackableObjectCurrentStatus _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_LastActivityDate")]
    protected Primitive<DateTime> _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_LastUpdatedDateGMT")]
    protected Primitive<DateTime> _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_LastMoveDateGMT")]
    protected Primitive<DateTime> _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_LastMoveDate")]
    protected Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_LastActivityDateGMT")]
    protected Primitive<DateTime> _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TrackableObject && object.Equals((object) this._WorkflowNavigator, (object) ((TrackableObject) obj)._WorkflowNavigator) && (object.Equals((object) this._Spec, (object) ((TrackableObject) obj)._Spec) && object.Equals((object) this._CurrentStatus, (object) ((TrackableObject) obj)._CurrentStatus)) && (object.Equals((object) this._Workflow, (object) ((TrackableObject) obj)._Workflow) && object.Equals((object) this._LastActivityDate, (object) ((TrackableObject) obj)._LastActivityDate) && (object.Equals((object) this._LastUpdatedDate, (object) ((TrackableObject) obj)._LastUpdatedDate) && object.Equals((object) this._LastUpdatedDateGMT, (object) ((TrackableObject) obj)._LastUpdatedDateGMT))) && (object.Equals((object) this._LastMoveDateGMT, (object) ((TrackableObject) obj)._LastMoveDateGMT) && object.Equals((object) this._LastMoveDate, (object) ((TrackableObject) obj)._LastMoveDate) && (object.Equals((object) this._LastActivityDateGMT, (object) ((TrackableObject) obj)._LastActivityDateGMT) && object.Equals((object) this._Description, (object) ((TrackableObject) obj)._Description)) && (object.Equals((object) this._WorkflowStep, (object) ((TrackableObject) obj)._WorkflowStep) && object.Equals((object) this._Name, (object) ((TrackableObject) obj)._Name))) && base.Equals(obj);
    }

    public SubentityRef WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public TrackableObjectCurrentStatus CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (TrackableObjectCurrentStatus) this.PropertyGet(nameof (CurrentStatus));
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

    public Primitive<DateTime> LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<DateTime> LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDateGMT));
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

    public Primitive<DateTime> LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
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

    public Primitive<string> Name
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
