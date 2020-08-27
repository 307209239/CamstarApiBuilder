// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReferenceField_Environment
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
  public class ReferenceField_Environment : ObjectField_Environment
  {
    [Metadata("Contains all the object reference type fields information. Includes owned subentities as well.", "ObjectReferencesInfo", false, false, true, "ObjectReferencesInfo", 1050848, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReferenceField_Environment_References")]
    protected ObjectReferencesInfo_Environment _References;

    public ObjectReferencesInfo_Environment References
    {
      [param: In] set
      {
        this.PropertySet(nameof (References), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo_Environment) this.PropertyGet(nameof (References));
      }
    }
  }
}
