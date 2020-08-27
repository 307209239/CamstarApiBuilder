// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyMaterialContainer
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
  public class EmptyMaterialContainer : EmptyCarrier
  {
    [DataMember(EmitDefaultValue = false, Name = "EmptyMaterialContainer_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "EmptyMaterialContainer_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "EmptyMaterialContainer_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "EmptyMaterialContainer_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "EmptyMaterialContainer_Batch")]
    protected ContainerRef _Batch;

    public override bool Equals(object obj)
    {
      return obj is EmptyMaterialContainer && object.Equals((object) this._Spec, (object) ((EmptyMaterialContainer) obj)._Spec) && (object.Equals((object) this._Container, (object) ((EmptyMaterialContainer) obj)._Container) && object.Equals((object) this._MasterRecipe, (object) ((EmptyMaterialContainer) obj)._MasterRecipe)) && (object.Equals((object) this._Carrier, (object) ((EmptyMaterialContainer) obj)._Carrier) && object.Equals((object) this._Batch, (object) ((EmptyMaterialContainer) obj)._Batch)) && base.Equals(obj);
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
  }
}
