// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgSubentityDetails
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
  public class ChgSubentityDetails : ChgObjectDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgSubentityDetails_NewObject")]
    protected SubentityRef _NewObject;

    public override bool Equals(object obj)
    {
      return obj is ChgSubentityDetails && object.Equals((object) this._NewObject, (object) ((ChgSubentityDetails) obj)._NewObject) && base.Equals(obj);
    }

    public SubentityRef NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
