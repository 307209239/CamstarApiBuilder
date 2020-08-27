// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgNamedObjectDetails
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
  public class ChgNamedObjectDetails : ChgObjectDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgNamedObjectDetails_NewObject")]
    protected NamedObjectRef _NewObject;

    public override bool Equals(object obj)
    {
      return obj is ChgNamedObjectDetails && object.Equals((object) this._NewObject, (object) ((ChgNamedObjectDetails) obj)._NewObject) && base.Equals(obj);
    }

    public NamedObjectRef NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
