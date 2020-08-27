// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackableObject_Environment
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
  public class TrackableObject_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_WorkflowNavigator")]
    [Metadata("Navigate through a workflow, including subworkflows and rework information.", "WorkflowNavigator", false, false, true, "SubentityRef", 1049790, false, false, false, null)]
    protected Environment _WorkflowNavigator;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.", "BusinessProcessSpec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_CurrentStatus")]
    [Metadata("The Current Status contains the current information for a trackable object.", "TrackableObjectCurrentStatus", false, false, false, "TrackableObjectCurrentStatus", 1048786, false, false, false, null)]
    protected TrackableObjectCurrentStatus_Environment _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    protected Environment _Workflow;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048803, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_LastActivityDate")]
    protected Environment _LastActivityDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_LastUpdatedDate")]
    protected Environment _LastUpdatedDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_LastUpdatedDateGMT")]
    protected Environment _LastUpdatedDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048808, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_LastMoveDateGMT")]
    protected Environment _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_LastMoveDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048807, false, false, false, null)]
    protected Environment _LastMoveDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048804, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_LastActivityDateGMT")]
    protected Environment _LastActivityDateGMT;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_WorkflowStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1048855, false, false, false, null)]
    protected Environment _WorkflowStep;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1053234, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Environment_Name")]
    protected Environment _Name;

    public Environment WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public TrackableObjectCurrentStatus_Environment CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (TrackableObjectCurrentStatus_Environment) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public Environment LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Environment LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Environment LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Environment LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Environment LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Environment LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public Environment Name
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
