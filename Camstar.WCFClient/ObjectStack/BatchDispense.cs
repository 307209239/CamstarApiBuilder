// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchDispense
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
  public class BatchDispense : ComponentIssue
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Batch")]
    protected ContainerRef _Batch;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_UseMaterialFromBatch")]
    protected Primitive<bool> _UseMaterialFromBatch;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_BatchRecipeName")]
    protected Primitive<string> _BatchRecipeName;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_BatchProductName")]
    protected Primitive<string> _BatchProductName;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Operation")]
    protected new NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is BatchDispense && object.Equals((object) this._Spec, (object) ((BatchDispense) obj)._Spec) && (object.Equals((object) this._Carrier, (object) ((BatchDispense) obj)._Carrier) && object.Equals((object) this._Batch, (object) ((BatchDispense) obj)._Batch)) && (object.Equals((object) this._Container, (object) ((BatchDispense) obj)._Container) && object.Equals((object) this._MasterRecipe, (object) ((BatchDispense) obj)._MasterRecipe) && (object.Equals((object) this._UseMaterialFromBatch, (object) ((BatchDispense) obj)._UseMaterialFromBatch) && object.Equals((object) this._BatchRecipeName, (object) ((BatchDispense) obj)._BatchRecipeName))) && (object.Equals((object) this._BatchProductName, (object) ((BatchDispense) obj)._BatchProductName) && object.Equals((object) this._Operation, (object) ((BatchDispense) obj)._Operation)) && base.Equals(obj);
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public ContainerRef Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Batch));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public RevisionedObjectRef MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public Primitive<bool> UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Primitive<string> BatchRecipeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchRecipeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BatchRecipeName));
      }
    }

    public Primitive<string> BatchProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BatchProductName));
      }
    }

    public new NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
