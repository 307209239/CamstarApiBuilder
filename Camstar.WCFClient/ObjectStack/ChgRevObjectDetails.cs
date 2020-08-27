// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgRevObjectDetails
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
  public class ChgRevObjectDetails : ChgObjectDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgRevObjectDetails_NewObject")]
    protected RevisionedObjectRef _NewObject;

    public override bool Equals(object obj)
    {
      return obj is ChgRevObjectDetails && object.Equals((object) this._NewObject, (object) ((ChgRevObjectDetails) obj)._NewObject) && base.Equals(obj);
    }

    public RevisionedObjectRef NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
