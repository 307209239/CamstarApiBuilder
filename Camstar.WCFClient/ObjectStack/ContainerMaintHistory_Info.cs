// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintHistory_Info
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
  public class ContainerMaintHistory_Info : ChgContainerAttrHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Info_HistoryDetails")]
    protected ContainerMaintHistDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Info_ChildProcessingMode")]
    protected new Info _ChildProcessingMode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Info_RecordDetailPostHistory")]
    protected new Info _RecordDetailPostHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Info_RecordDetailPreHistory")]
    protected new Info _RecordDetailPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public ContainerMaintHistDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ContainerMaintHistDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Info ChildProcessingMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildProcessingMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildProcessingMode));
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

    public new Info RecordDetailPostHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPostHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordDetailPostHistory));
      }
    }

    public new Info RecordDetailPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPreHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordDetailPreHistory));
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
