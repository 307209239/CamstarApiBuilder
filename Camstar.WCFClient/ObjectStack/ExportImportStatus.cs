// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportStatus
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ExportTargetDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ExportImportStatus : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_Status")]
    protected Enumeration<ExportImportStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_LogDetails")]
    protected ExportImportLogDetail[] _LogDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_TotalObjectCount")]
    protected Primitive<int> _TotalObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_ProcessStartTime")]
    protected Primitive<DateTime> _ProcessStartTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_ProcessedObjectCount")]
    protected Primitive<int> _ProcessedObjectCount;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_LastUpdatedTime")]
    protected Primitive<DateTime> _LastUpdatedTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportStatus_CompletionMessage")]
    protected Primitive<string> _CompletionMessage;

    public override bool Equals(object obj)
    {
      return obj is ExportImportStatus && object.Equals((object) this._Status, (object) ((ExportImportStatus) obj)._Status) && (this.CompareArrays((Array) this._LogDetails, (Array) ((ExportImportStatus) obj)._LogDetails) && object.Equals((object) this._TotalObjectCount, (object) ((ExportImportStatus) obj)._TotalObjectCount)) && (object.Equals((object) this._ProcessStartTime, (object) ((ExportImportStatus) obj)._ProcessStartTime) && object.Equals((object) this._ProcessedObjectCount, (object) ((ExportImportStatus) obj)._ProcessedObjectCount) && (object.Equals((object) this._LastUpdatedTime, (object) ((ExportImportStatus) obj)._LastUpdatedTime) && object.Equals((object) this._CompletionMessage, (object) ((ExportImportStatus) obj)._CompletionMessage))) && base.Equals(obj);
    }

    public Enumeration<ExportImportStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public ExportImportLogDetail[] LogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogDetails), (object) value);
      }
      get
      {
        return (ExportImportLogDetail[]) this.PropertyGet(nameof (LogDetails));
      }
    }

    public Primitive<int> TotalObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalObjectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalObjectCount));
      }
    }

    public Primitive<DateTime> ProcessStartTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessStartTime), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ProcessStartTime));
      }
    }

    public Primitive<int> ProcessedObjectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessedObjectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ProcessedObjectCount));
      }
    }

    public Primitive<DateTime> LastUpdatedTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedTime), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedTime));
      }
    }

    public Primitive<string> CompletionMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionMessage));
      }
    }
  }
}
