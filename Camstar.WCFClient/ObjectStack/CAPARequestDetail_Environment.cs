// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPARequestDetail_Environment
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
  public class CAPARequestDetail_Environment : CAPADetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPARequestDetail_Environment_ProposedResolution")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1051333, false, false, false, null)]
    protected Environment _ProposedResolution;

    public Environment ProposedResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProposedResolution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProposedResolution));
      }
    }
  }
}
