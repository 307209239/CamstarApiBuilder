// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessWorkflowMaint_Environment
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
  public class BusinessProcessWorkflowMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflowChanges", false, false, false, "BusinessProcessWorkflowChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_Environment_ObjectChanges")]
    protected BusinessProcessWorkflowChanges_Environment _ObjectChanges;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflowBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowMaint_Environment_BaseToChange")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflowBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;

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

    public BusinessProcessWorkflowChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BusinessProcessWorkflowChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
