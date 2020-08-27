// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCAR_Environment
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
  public class ResolveCAR_Environment : CloseQualityObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCAR_Environment_QualityObject")]
    [Metadata("CAPA Request", "CAPARequest", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }
  }
}
