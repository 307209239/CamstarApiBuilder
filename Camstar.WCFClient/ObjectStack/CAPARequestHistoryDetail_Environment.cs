// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPARequestHistoryDetail_Environment
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
  public class CAPARequestHistoryDetail_Environment : CAPAHistoryDetail_Environment
  {
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051333, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPARequestHistoryDetail_Environment_ProposedResolution")]
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
