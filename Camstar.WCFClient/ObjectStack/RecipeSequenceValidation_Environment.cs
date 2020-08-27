// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeSequenceValidation_Environment
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
  public class RecipeSequenceValidation_Environment : ProcessSequenceValidation_Environment
  {
    [Metadata("Material Container", "MaterialContainer", false, false, true, "ContainerRef", 1051878, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeSequenceValidation_Environment_MaterialContainer")]
    protected Environment _MaterialContainer;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051888, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeSequenceValidation_Environment_CompleteTaskForBatch")]
    protected Environment _CompleteTaskForBatch;

    public Environment MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public Environment CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
