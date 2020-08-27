// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeProcessHistory_Environment
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
  public class ChangeProcessHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_AuditTrail")]
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, true, "ModelingAuditTrailHeader", 1051403, false, false, false, null)]
    protected ModelingAuditTrailHeader_Environment _AuditTrail;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_QualityObject")]
    protected Environment _QualityObject;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("DisplayName", "", false, false, true, "String", 1051656, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_ProcessObjectDisplay")]
    protected Environment _ProcessObjectDisplay;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_ProcessObject")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1051396, false, false, false, null)]
    protected Environment _ProcessObject;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051655, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_TriageComplete")]
    protected Environment _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public ModelingAuditTrailHeader_Environment AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Environment) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment ProcessObjectDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDisplay), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObjectDisplay));
      }
    }

    public Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
