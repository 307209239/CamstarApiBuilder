// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReferenceField
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
  public class ReferenceField : ObjectField
  {
    [DataMember(EmitDefaultValue = false, Name = "ReferenceField_References")]
    protected ObjectReferencesInfo[] _References;

    public override bool Equals(object obj)
    {
      return obj is ReferenceField && this.CompareArrays((Array) this._References, (Array) ((ReferenceField) obj)._References) && base.Equals(obj);
    }

    public ObjectReferencesInfo[] References
    {
      [param: In] set
      {
        this.PropertySet(nameof (References), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo[]) this.PropertyGet(nameof (References));
      }
    }
  }
}
