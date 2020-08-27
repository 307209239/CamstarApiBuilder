// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeSequenceValidation_Info
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
  public class RecipeSequenceValidation_Info : ProcessSequenceValidation_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeSequenceValidation_Info_MaterialContainer")]
    protected Info _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "RecipeSequenceValidation_Info_CompleteTaskForBatch")]
    protected Info _CompleteTaskForBatch;

    public Info MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public Info CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
