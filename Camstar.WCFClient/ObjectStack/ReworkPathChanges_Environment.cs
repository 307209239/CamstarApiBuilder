// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPathChanges_Environment
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
  public class ReworkPathChanges_Environment : PathChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Environment_EndReworkStep")]
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1049627, false, false, true, null)]
    protected Environment _EndReworkStep;
    [Metadata("SpecStepChanges", "SpecStepChanges", false, false, false, "NamedSubentityRef", 1049469, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Environment_ReEntryStep")]
    protected Environment _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Environment_Steps")]
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "StepChanges", 1048932, false, true, false, null)]
    protected StepChanges_Environment _Steps;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050299, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public Environment ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public StepChanges_Environment Steps
    {
      [param: In] set
      {
        this.PropertySet(nameof (Steps), (object) value);
      }
      get
      {
        return (StepChanges_Environment) this.PropertyGet(nameof (Steps));
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
  }
}
