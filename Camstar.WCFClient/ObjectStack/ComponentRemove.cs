// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentRemove
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
  public class ComponentRemove : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_ServiceDetails")]
    protected RemovalCandidate[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_RemovalHistoryDetails")]
    protected SubentityRef[] _RemovalHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_IssueActualsHistory")]
    protected SubentityRef[] _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_AllowIssuedContainers")]
    protected Primitive<bool> _AllowIssuedContainers;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemove_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;

    public override bool Equals(object obj)
    {
      return obj is ComponentRemove && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ComponentRemove) obj)._ServiceDetails) && (this.CompareArrays((Array) this._RemovalHistoryDetails, (Array) ((ComponentRemove) obj)._RemovalHistoryDetails) && this.CompareArrays((Array) this._IssueActualsHistory, (Array) ((ComponentRemove) obj)._IssueActualsHistory)) && (object.Equals((object) this._AllowIssuedContainers, (object) ((ComponentRemove) obj)._AllowIssuedContainers) && object.Equals((object) this._AllowZeroQtys, (object) ((ComponentRemove) obj)._AllowZeroQtys)) && base.Equals(obj);
    }

    public RemovalCandidate[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (RemovalCandidate[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public SubentityRef[] RemovalHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (RemovalHistoryDetails));
      }
    }

    public SubentityRef[] IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Primitive<bool> AllowIssuedContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowIssuedContainers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowIssuedContainers));
      }
    }

    public Primitive<bool> AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }
  }
}
