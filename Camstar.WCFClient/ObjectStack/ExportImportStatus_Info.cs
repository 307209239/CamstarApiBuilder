// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportStatus_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ExportTargetDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ExportImportStatus_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_LogDetails")]
    protected ExportImportLogDetail_Info _LogDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_TotalObjectCount")]
    protected Info _TotalObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_ProcessStartTime")]
    protected Info _ProcessStartTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_ProcessedObjectCount")]
    protected Info _ProcessedObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_LastUpdatedTime")]
    protected Info _LastUpdatedTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Info_CompletionMessage")]
    protected Info _CompletionMessage;

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public ExportImportLogDetail_Info LogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogDetails), (object) value);
      }
      get
      {
        return (ExportImportLogDetail_Info) this.PropertyGet(nameof (LogDetails));
      }
    }

    public Info TotalObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalObjectCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalObjectCount));
      }
    }

    public Info ProcessStartTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessStartTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessStartTime));
      }
    }

    public Info ProcessedObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessedObjectCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessedObjectCount));
      }
    }

    public Info LastUpdatedTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedTime));
      }
    }

    public Info CompletionMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionMessage));
      }
    }
  }
}
