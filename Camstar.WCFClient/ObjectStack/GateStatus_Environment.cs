// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GateStatus_Environment
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
  public class GateStatus_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Environment_CompletedSteps")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049048, false, true, false, null)]
    protected Environment _CompletedSteps;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Environment_GateType")]
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1048924, false, false, false, null)]
    protected Environment _GateType;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Environment_Gate")]
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nGates are used to group one or more Steps for a specific purpose. There are three types of Gates: Cycle-time, Processing, and Collection. Each Gate has an Entry Point and an Exit Point. An Entry or Exit Point is a transaction at a Step. For use in defining Entry and Exit Points, transactions are grouped as Begin Work, or Complete Work.  Begin Work is any transaction that changes the \"Work started\" status attribute of a Container to True. Complete Work is any transaction that changes the location of a Container.\r\n\r\nGates are referenced by name or by Id. Gates names are unique within the context of their Workflow.", "Gate", false, false, false, "NamedSubentityRef", 1049049, false, false, false, null)]
    protected Environment _Gate;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049050, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Environment_RequiredStepsRemaining")]
    protected Environment _RequiredStepsRemaining;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment CompletedSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSteps), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletedSteps));
      }
    }

    public Environment GateType
    {
      [param: In] set
      {
        this.PropertySet(nameof (GateType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GateType));
      }
    }

    public Environment Gate
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Gate));
      }
    }

    public Environment RequiredStepsRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredStepsRemaining), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequiredStepsRemaining));
      }
    }
  }
}
