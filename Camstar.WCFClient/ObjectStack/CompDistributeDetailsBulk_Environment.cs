// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeDetailsBulk_Environment
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
  public class CompDistributeDetailsBulk_Environment : IssueDetailsBulk_Environment
  {
    [Metadata("Issue actual for ComponentDistribute transaction in bulk mode", "CompDistributeActualBulk", false, false, false, "CompDistributeActualBulk", 1049642, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeDetailsBulk_Environment_Actuals")]
    protected CompDistributeActualBulk_Environment _Actuals;

    public CompDistributeActualBulk_Environment Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (CompDistributeActualBulk_Environment) this.PropertyGet(nameof (Actuals));
      }
    }
  }
}
