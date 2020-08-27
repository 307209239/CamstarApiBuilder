// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePkgCurrentStatusStartDtl_Environment
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
  public class ChangePkgCurrentStatusStartDtl_Environment : TrackObjCurrentStatusStartDtls_Environment
  {
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, false, "RevisionedObjectRef", 16777316, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePkgCurrentStatusStartDtl_Environment_Workflow")]
    protected new Environment _Workflow;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "ChangeMgtSpecStep", false, false, true, "NamedSubentityRef", 1049828, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePkgCurrentStatusStartDtl_Environment_SpecStep")]
    protected new Environment _SpecStep;

    public new Environment Workflow
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

    public new Environment SpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecStep));
      }
    }
  }
}
