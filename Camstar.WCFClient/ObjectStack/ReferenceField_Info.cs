// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReferenceField_Info
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
  public class ReferenceField_Info : ObjectField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReferenceField_Info_References")]
    protected ObjectReferencesInfo_Info _References;

    public ObjectReferencesInfo_Info References
    {
      [param: In] set
      {
        this.PropertySet(nameof (References), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo_Info) this.PropertyGet(nameof (References));
      }
    }
  }
}
