// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgSubentityDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgRevObjectDetails))]
  [KnownType(typeof (ChgContainerDetails))]
  [KnownType(typeof (ChgNamedObjectDetails))]
  [Serializable]
  public class ChgObjectDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectDetails_NewObject")]
    protected BaseObjectRef _NewObject;

    public override bool Equals(object obj)
    {
      return obj is ChgObjectDetails && object.Equals((object) this._NewObject, (object) ((ChgObjectDetails) obj)._NewObject) && base.Equals(obj);
    }

    public BaseObjectRef NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
