// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRequirementMaint_Environment
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
  public class TrainingRequirementMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirementChanges", false, false, false, "TrainingRequirementChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementMaint_Environment_ObjectChanges")]
    protected TrainingRequirementChanges_Environment _ObjectChanges;
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirementBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementMaint_Environment_BaseToChange")]
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

    public TrainingRequirementChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TrainingRequirementChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
