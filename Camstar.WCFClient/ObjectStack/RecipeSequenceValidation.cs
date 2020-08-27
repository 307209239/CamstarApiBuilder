// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeSequenceValidation
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
  public class RecipeSequenceValidation : ProcessSequenceValidation
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeSequenceValidation_MaterialContainer")]
    protected ContainerRef _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "RecipeSequenceValidation_CompleteTaskForBatch")]
    protected Primitive<bool> _CompleteTaskForBatch;

    public override bool Equals(object obj)
    {
      return obj is RecipeSequenceValidation && object.Equals((object) this._MaterialContainer, (object) ((RecipeSequenceValidation) obj)._MaterialContainer) && object.Equals((object) this._CompleteTaskForBatch, (object) ((RecipeSequenceValidation) obj)._CompleteTaskForBatch) && base.Equals(obj);
    }

    public ContainerRef MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public Primitive<bool> CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
