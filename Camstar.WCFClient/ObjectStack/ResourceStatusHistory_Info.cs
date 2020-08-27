// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusHistory_Info
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
  public class ResourceStatusHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldResourceState")]
    protected Info _OldResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_ResourceState")]
    protected Info _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldLastStatusChangeDateGMT")]
    protected Info _OldLastStatusChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_UpdateLastStatusChangeDate")]
    protected Info _UpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldLastActivityDate")]
    protected Info _OldLastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldLastStatusChangeDate")]
    protected Info _OldLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_LastStatusChangeDate")]
    protected Info _LastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldUpdateLastStatusChangeDate")]
    protected Info _OldUpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldLastActivityDateGMT")]
    protected Info _OldLastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_LastStatusChangeDateGMT")]
    protected Info _LastStatusChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldResourceStatusReasonCode")]
    protected Info _OldResourceStatusReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldResourceStatusCode")]
    protected Info _OldResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldSetup")]
    protected Info _OldSetup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_ResourceStatusReasonCode")]
    protected Info _ResourceStatusReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_Run")]
    protected Info _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldRun")]
    protected Info _OldRun;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_ResourceStatusCode")]
    protected Info _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_Availability")]
    protected Info _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldProduct")]
    protected Info _OldProduct;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_OldAvailability")]
    protected Info _OldAvailability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Info_Setup")]
    protected Info _Setup;

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

    public Info OldResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldResourceState));
      }
    }

    public Info ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Info OldLastStatusChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastStatusChangeDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldLastStatusChangeDateGMT));
      }
    }

    public Info UpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpdateLastStatusChangeDate));
      }
    }

    public Info OldLastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastActivityDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldLastActivityDate));
      }
    }

    public Info OldLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldLastStatusChangeDate));
      }
    }

    public Info LastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStatusChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastStatusChangeDate));
      }
    }

    public Info OldUpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldUpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldUpdateLastStatusChangeDate));
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

    public Info OldLastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastActivityDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldLastActivityDateGMT));
      }
    }

    public Info LastStatusChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStatusChangeDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastStatusChangeDateGMT));
      }
    }

    public Info OldResourceStatusReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceStatusReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldResourceStatusReasonCode));
      }
    }

    public Info OldResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldResourceStatusCode));
      }
    }

    public Info OldSetup
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldSetup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldSetup));
      }
    }

    public Info ResourceStatusReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReasonCode));
      }
    }

    public Info Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Run));
      }
    }

    public Info OldRun
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldRun), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldRun));
      }
    }

    public Info ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public Info Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Availability));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public Info OldProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldProduct));
      }
    }

    public Info OldAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldAvailability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldAvailability));
      }
    }

    public Info Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Setup));
      }
    }
  }
}
