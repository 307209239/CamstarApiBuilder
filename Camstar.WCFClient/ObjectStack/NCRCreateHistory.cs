// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCreateHistory
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
  public class NCRCreateHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_RelatedNonconformance")]
    protected NamedObjectRef _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_HistoryDetails")]
    protected NCRDefectHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_NCRFailureCodes")]
    protected NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_NCRFailureType")]
    protected NamedObjectRef _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_NCRComment")]
    protected Primitive<string> _NCRComment;

    public override bool Equals(object obj)
    {
      return obj is NCRCreateHistory && object.Equals((object) this._RelatedNonconformance, (object) ((NCRCreateHistory) obj)._RelatedNonconformance) && (object.Equals((object) this._Task, (object) ((NCRCreateHistory) obj)._Task) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((NCRCreateHistory) obj)._HistoryDetails)) && (object.Equals((object) this._ExportImportKey, (object) ((NCRCreateHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NCRCreateHistory) obj)._NCRFailureCodes) && (object.Equals((object) this._NCRFailureType, (object) ((NCRCreateHistory) obj)._NCRFailureType) && object.Equals((object) this._ChargeToStep, (object) ((NCRCreateHistory) obj)._ChargeToStep))) && (object.Equals((object) this._HistoryId, (object) ((NCRCreateHistory) obj)._HistoryId) && object.Equals((object) this._Container, (object) ((NCRCreateHistory) obj)._Container) && object.Equals((object) this._NCRComment, (object) ((NCRCreateHistory) obj)._NCRComment)) && base.Equals(obj);
    }

    public NamedObjectRef RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public NamedSubentityRef Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Task));
      }
    }

    public NCRDefectHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public NamedObjectRef[] NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public NamedObjectRef NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRFailureType));
      }
    }

    public NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
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

    public Primitive<string> NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NCRComment));
      }
    }
  }
}
