// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeProcessHistory
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
  public class ChangeProcessHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_AuditTrail")]
    protected ModelingAuditTrailHeader _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_ProcessObjectDisplay")]
    protected Primitive<string> _ProcessObjectDisplay;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcessHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ChangeProcessHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ChangeProcessHistory) obj)._HistoryDetails) && (object.Equals((object) this._AuditTrail, (object) ((ChangeProcessHistory) obj)._AuditTrail) && object.Equals((object) this._QualityObject, (object) ((ChangeProcessHistory) obj)._QualityObject)) && (object.Equals((object) this._ExportImportKey, (object) ((ChangeProcessHistory) obj)._ExportImportKey) && object.Equals((object) this._ProcessObjectDisplay, (object) ((ChangeProcessHistory) obj)._ProcessObjectDisplay) && (object.Equals((object) this._ProcessObject, (object) ((ChangeProcessHistory) obj)._ProcessObject) && object.Equals((object) this._TriageComplete, (object) ((ChangeProcessHistory) obj)._TriageComplete))) && object.Equals((object) this._HistoryId, (object) ((ChangeProcessHistory) obj)._HistoryId) && base.Equals(obj);
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public ModelingAuditTrailHeader AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> ProcessObjectDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDisplay), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessObjectDisplay));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
