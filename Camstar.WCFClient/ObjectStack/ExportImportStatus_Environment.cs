// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportStatus_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ExportTargetDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ExportImportStatus_Environment : ServiceData_Environment
  {
    [Metadata("ExportImportStatusType", "ExportImportStatusEnum", false, false, true, "Integer", 1050837, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_LogDetails")]
    [Metadata("Export Import Log Detail", "ExportImportLogDetail", false, false, true, "ExportImportLogDetail", 1050839, false, true, false, null)]
    protected ExportImportLogDetail_Environment _LogDetails;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_TotalObjectCount")]
    protected Environment _TotalObjectCount;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050833, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_ProcessStartTime")]
    protected Environment _ProcessStartTime;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050835, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_ProcessedObjectCount")]
    protected Environment _ProcessedObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_LastUpdatedTime")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050834, false, false, false, null)]
    protected Environment _LastUpdatedTime;
    [Metadata("Message text.", "", false, false, true, "String", 1050838, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Environment_CompletionMessage")]
    protected Environment _CompletionMessage;

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public ExportImportLogDetail_Environment LogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogDetails), (object) value);
      }
      get
      {
        return (ExportImportLogDetail_Environment) this.PropertyGet(nameof (LogDetails));
      }
    }

    public Environment TotalObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalObjectCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalObjectCount));
      }
    }

    public Environment ProcessStartTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessStartTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessStartTime));
      }
    }

    public Environment ProcessedObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessedObjectCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessedObjectCount));
      }
    }

    public Environment LastUpdatedTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedTime));
      }
    }

    public Environment CompletionMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionMessage));
      }
    }
  }
}
