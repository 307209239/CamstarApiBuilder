// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCARRefHistory_Environment
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
  public class ResolveCARRefHistory_Environment : QualityCrossRefHistory_Environment
  {
    [Metadata("Enumeration for the CAR Resolution Action:\r\n1 = Close\r\n2 = AttachToCAPA\r\n3 = CreateCAPA", "CARResolutionActionEnum", false, false, true, "Integer", 1051477, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefHistory_Environment_CARResolutionAction")]
    protected Environment _CARResolutionAction;

    public Environment CARResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CARResolutionAction));
      }
    }
  }
}
