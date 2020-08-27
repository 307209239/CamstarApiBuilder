// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeDetailsBulk_Info
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
  public class CompDistributeDetailsBulk_Info : IssueDetailsBulk_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeDetailsBulk_Info_Actuals")]
    protected CompDistributeActualBulk_Info _Actuals;

    public CompDistributeActualBulk_Info Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (CompDistributeActualBulk_Info) this.PropertyGet(nameof (Actuals));
      }
    }
  }
}
