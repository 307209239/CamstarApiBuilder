// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivity_Environment
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
  public class CompleteActivity_Environment : ProcessObjectTxn_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_ProcessObjectDetails")]
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, true, "Activity", 1051538, false, false, false, null)]
    protected Activity_Environment _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_CollectDataPoints")]
    [Metadata("The Collect Data Points transaction is used to collect data points for a trackable object.  It requires that the trackable object have a DataPointCollection assigned to it.", "CollectDataPoints", false, false, false, "CollectDataPoints", 1052463, true, false, false, null)]
    protected CollectDataPoints_Environment _CollectDataPoints;
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, true, false, "NamedSubentityRef", 1050968, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_ProcessObject")]
    protected new Environment _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_ExecuteChecklist")]
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    protected ExecuteChecklist_Environment _ExecuteChecklist;
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, true, "NamedSubentityRef", 1050968, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_Activity")]
    protected Environment _Activity;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_Submit")]
    protected Environment _Submit;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivity_Environment_CompletionComments")]
    protected Environment _CompletionComments;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Activity_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (Activity_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public CollectDataPoints_Environment CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints_Environment) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public ExecuteChecklist_Environment ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public Environment Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Activity));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
      }
    }

    public Environment CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
