// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidateSerial_Environment
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
  public class RemovalCandidateSerial_Environment : RemovalCandidate_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateSerial_Environment_IssueActualHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type serial.", "IssueActualsHistorySerial", false, false, false, "IssueActualsHistorySerial", 1049872, false, false, false, null)]
    protected IssueActualsHistorySerial_Environment _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateSerial_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, true, "1")]
    protected new Environment _IssueControl;
    [Metadata("Components removed from the WIP Container are serialized and must be put back into a container of the same product.", "RemovalDetailSerial", false, false, false, "RemovalDetailSerial", 1049873, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidateSerial_Environment_RemovalDetail")]
    protected RemovalDetailSerial_Environment _RemovalDetail;

    public IssueActualsHistorySerial_Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistorySerial_Environment) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public RemovalDetailSerial_Environment RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetailSerial_Environment) this.PropertyGet(nameof (RemovalDetail));
      }
    }
  }
}
