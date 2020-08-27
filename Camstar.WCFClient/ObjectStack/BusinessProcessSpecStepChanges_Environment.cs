// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessSpecStepChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangeMgtSpecStepChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class BusinessProcessSpecStepChanges_Environment : StepChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, "0")]
    protected new Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Environment_ObjectToChange")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.", "BusinessProcessSpec", false, false, false, "RevisionedObjectRef", 1049033, false, false, false, null)]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Environment_OnDefaultRoute")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048913, false, false, false, "0")]
    protected new Environment _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053251, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1048918, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessSpecStepChanges_Environment_StepType")]
    protected new Environment _StepType;

    public new Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
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

    public new Environment OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public new Environment Name
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

    public new Environment StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepType));
      }
    }
  }
}
