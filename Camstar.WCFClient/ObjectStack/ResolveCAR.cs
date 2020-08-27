// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCAR
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
  public class ResolveCAR : CloseQualityObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCAR_QualityObject")]
    protected new NamedObjectRef _QualityObject;

    public override bool Equals(object obj)
    {
      return obj is ResolveCAR && object.Equals((object) this._QualityObject, (object) ((ResolveCAR) obj)._QualityObject) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }
  }
}
