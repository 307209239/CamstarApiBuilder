// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkflowMaint_Environment
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
  public class WorkflowMaint_Environment : BusinessProcessWorkflowMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkflowMaint_Environment_ObjectChanges")]
    [Metadata("WorkflowChanges", "WorkflowChanges", false, false, false, "WorkflowChanges", 1048873, true, false, false, null)]
    protected WorkflowChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowMaint_Environment_ObjectListInquiry")]
    [Metadata("The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.  WorkflowBase is the specific type of RevisionBase used for a workflow, which defines the route and processing details required for a manufacturing process.", "WorkflowBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkflowMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.  WorkflowBase is the specific type of RevisionBase used for a workflow, which defines the route and processing details required for a manufacturing process.", "WorkflowBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkflowMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;

    public WorkflowChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (WorkflowChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }
  }
}
