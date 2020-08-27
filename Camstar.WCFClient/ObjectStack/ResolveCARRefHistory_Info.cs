// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCARRefHistory_Info
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
  public class ResolveCARRefHistory_Info : QualityCrossRefHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefHistory_Info_CARResolutionAction")]
    protected Info _CARResolutionAction;

    public Info CARResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CARResolutionAction));
      }
    }
  }
}
