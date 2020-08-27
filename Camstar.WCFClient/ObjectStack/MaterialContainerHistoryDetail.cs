// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerHistoryDetail
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
  public class MaterialContainerHistoryDetail : StartHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerHistoryDetail_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;

    public override bool Equals(object obj)
    {
      return obj is MaterialContainerHistoryDetail && object.Equals((object) this._MasterRecipe, (object) ((MaterialContainerHistoryDetail) obj)._MasterRecipe) && base.Equals(obj);
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
  }
}
