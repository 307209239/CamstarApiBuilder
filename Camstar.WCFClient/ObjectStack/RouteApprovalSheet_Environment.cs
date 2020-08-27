// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteApprovalSheet_Environment
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
  public class RouteApprovalSheet_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteApprovalSheet_Environment_ProcessObjectDetails")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "ProcessObject", 1051396, false, false, false, null)]
    protected ProcessObject_Environment _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "RouteApprovalSheet_Environment_ApprovalSheet")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, true, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    protected Environment _ApprovalSheet;

    public ProcessObject_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
      }
    }
  }
}
