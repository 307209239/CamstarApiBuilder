// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeDetailsSerial_Environment
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
  public class CompDistributeDetailsSerial_Environment : IssueDetailsSerial_Environment
  {
    [Metadata("Issue actual for ComponentDistribute transaction in serial mode", "CompDistributeActualSerial", false, false, false, "CompDistributeActualSerial", 1049642, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeDetailsSerial_Environment_Actuals")]
    protected CompDistributeActualSerial_Environment _Actuals;

    public CompDistributeActualSerial_Environment Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (CompDistributeActualSerial_Environment) this.PropertyGet(nameof (Actuals));
      }
    }
  }
}
