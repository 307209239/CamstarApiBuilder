// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdate
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
  public class NCRUpdate : NCRTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_ServiceDetails")]
    protected NCRDefectDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_ServiceDetail")]
    protected NCRUpdateDetail _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_NonconformanceReport")]
    protected new NamedObjectRef _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_NCRDefectHistoryDetails")]
    protected Camstar.WCF.ObjectStack.NCRDefectHistoryDetails[] _NCRDefectHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_IssueActualsHistory")]
    protected Camstar.WCF.ObjectStack.IssueActualsHistory[] _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is NCRUpdate && this.CompareArrays((Array) this._ServiceDetails, (Array) ((NCRUpdate) obj)._ServiceDetails) && (object.Equals((object) this._ServiceDetail, (object) ((NCRUpdate) obj)._ServiceDetail) && object.Equals((object) this._NonconformanceReport, (object) ((NCRUpdate) obj)._NonconformanceReport)) && (this.CompareArrays((Array) this._NCRDefectHistoryDetails, (Array) ((NCRUpdate) obj)._NCRDefectHistoryDetails) && this.CompareArrays((Array) this._IssueActualsHistory, (Array) ((NCRUpdate) obj)._IssueActualsHistory) && (object.Equals((object) this._Container, (object) ((NCRUpdate) obj)._Container) && object.Equals((object) this._Factory, (object) ((NCRUpdate) obj)._Factory))) && base.Equals(obj);
    }

    public NCRDefectDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public NCRUpdateDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRUpdateDetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new NamedObjectRef NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NonconformanceReport));
      }
    }

    public Camstar.WCF.ObjectStack.NCRDefectHistoryDetails[] NCRDefectHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectHistoryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.NCRDefectHistoryDetails[]) this.PropertyGet(nameof (NCRDefectHistoryDetails));
      }
    }

    public Camstar.WCF.ObjectStack.IssueActualsHistory[] IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.IssueActualsHistory[]) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
