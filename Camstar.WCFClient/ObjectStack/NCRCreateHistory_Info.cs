// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCreateHistory_Info
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
  public class NCRCreateHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_RelatedNonconformance")]
    protected Info _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_HistoryDetails")]
    protected NCRDefectHistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_NCRFailureCodes")]
    protected Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_NCRFailureType")]
    protected Info _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Info_NCRComment")]
    protected Info _NCRComment;

    public Info RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public Info Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Task));
      }
    }

    public NCRDefectHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public Info NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureType));
      }
    }

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
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

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRComment));
      }
    }
  }
}
