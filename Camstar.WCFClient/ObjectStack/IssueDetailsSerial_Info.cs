// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetailsSerial_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompDistributeDetailsSerial_Info))]
  [Serializable]
  public class IssueDetailsSerial_Info : IssueDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsSerial_Info_Actuals")]
    protected ActualsSerial_Info _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsSerial_Info_IssueControl")]
    protected new Info _IssueControl;

    public ActualsSerial_Info Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (ActualsSerial_Info) this.PropertyGet(nameof (Actuals));
      }
    }

    public new Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
