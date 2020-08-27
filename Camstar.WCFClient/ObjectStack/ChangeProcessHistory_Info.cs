// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeProcessHistory_Info
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
  public class ChangeProcessHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_AuditTrail")]
    protected ModelingAuditTrailHeader_Info _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_ProcessObjectDisplay")]
    protected Info _ProcessObjectDisplay;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_ProcessObject")]
    protected Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public ModelingAuditTrailHeader_Info AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Info) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info ProcessObjectDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDisplay), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObjectDisplay));
      }
    }

    public Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
