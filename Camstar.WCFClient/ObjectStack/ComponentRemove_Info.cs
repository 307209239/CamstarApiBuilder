// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentRemove_Info
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
  public class ComponentRemove_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Info_ServiceDetails")]
    protected RemovalCandidate_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Info_RemovalHistoryDetails")]
    protected Info _RemovalHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Info_IssueActualsHistory")]
    protected Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Info_AllowIssuedContainers")]
    protected Info _AllowIssuedContainers;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;

    public RemovalCandidate_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (RemovalCandidate_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info RemovalHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemovalHistoryDetails));
      }
    }

    public Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Info AllowIssuedContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowIssuedContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowIssuedContainers));
      }
    }

    public Info AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }
  }
}
