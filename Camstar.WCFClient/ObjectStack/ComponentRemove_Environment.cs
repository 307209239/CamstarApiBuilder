// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentRemove_Environment
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
  public class ComponentRemove_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Environment_ServiceDetails")]
    [Metadata("Service detail with net quantity issued", "RemovalCandidate", false, true, false, "RemovalCandidate", 1049644, false, true, false, null)]
    protected RemovalCandidate_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Environment_RemovalHistoryDetails")]
    [Metadata("Records the details of the removal of components from a WIP container", "RemovalHistoryDetail", false, false, false, "SubentityRef", 1049845, false, true, false, null)]
    protected Environment _RemovalHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Environment_IssueActualsHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "SubentityRef", 1049765, false, true, false, null)]
    protected Environment _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Environment_AllowIssuedContainers")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779373, false, false, false, "0")]
    protected Environment _AllowIssuedContainers;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_Environment_AllowZeroQtys")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051471, false, false, false, "1")]
    protected Environment _AllowZeroQtys;

    public RemovalCandidate_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (RemovalCandidate_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment RemovalHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemovalHistoryDetails));
      }
    }

    public Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment AllowIssuedContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowIssuedContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowIssuedContainers));
      }
    }

    public Environment AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }
  }
}
