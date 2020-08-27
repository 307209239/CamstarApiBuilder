// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdate_Environment
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
  public class NCRUpdate_Environment : NCRTxn_Environment
  {
    [Metadata("This ServiceDetails object records failure defect data for a Nonconformance.  This information is recorded historically.  If an ActualComponentIssue value is assigned, then the Container, Lot, Product and ReferenceDesignator all default to the values in that history.  These values can be overridden by the client.", "NCRDefectDetails", false, false, false, "NCRDefectDetails", 1050451, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_ServiceDetails")]
    protected NCRDefectDetails_Environment _ServiceDetails;
    [Metadata("This ServiceDetails object contains the fields used to update an existing Nonconformance.  If a field is passed in from the client, then the corresponding field (based on the defined mappings) in the Nonconformance is overwritten.", "NCRUpdateDetail", false, false, false, "NCRUpdateDetail", 1050454, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_ServiceDetail")]
    protected NCRUpdateDetail_Environment _ServiceDetail;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, true, false, "NamedObjectRef", 1050601, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_NonconformanceReport")]
    protected new Environment _NonconformanceReport;
    [Metadata("NCR defect history details.", "NCRDefectHistoryDetails", false, false, true, "NCRDefectHistoryDetails", 1050455, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_NCRDefectHistoryDetails")]
    protected NCRDefectHistoryDetails_Environment _NCRDefectHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_IssueActualsHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "IssueActualsHistory", 1049663, false, true, false, null)]
    protected IssueActualsHistory_Environment _IssueActualsHistory;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_Container")]
    protected Environment _Container;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Environment_Factory")]
    protected new Environment _Factory;

    public NCRDefectDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public NCRUpdateDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRUpdateDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Environment NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceReport));
      }
    }

    public NCRDefectHistoryDetails_Environment NCRDefectHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectHistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Environment) this.PropertyGet(nameof (NCRDefectHistoryDetails));
      }
    }

    public IssueActualsHistory_Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
