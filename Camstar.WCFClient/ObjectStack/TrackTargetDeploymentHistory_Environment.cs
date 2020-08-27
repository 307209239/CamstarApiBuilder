// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackTargetDeploymentHistory_Environment
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
  public class TrackTargetDeploymentHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_Status")]
    [Metadata("Locked = 1\r\nCompleted = 2\r\nError = 3\r\nReprocess = 4", "TargetDeliveryStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_LastUpdatedDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053267, false, false, false, null)]
    protected Environment _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_ExportHeaderId")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053264, false, false, false, null)]
    protected Environment _ExportHeaderId;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053265, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_ExportTargetId")]
    protected Environment _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_LastUpdatedDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053255, false, false, false, null)]
    protected Environment _LastUpdatedDate;
    [Metadata("Message text.", "", false, false, true, "String", 1051161, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Environment_Message")]
    protected Environment _Message;

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
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

    public Environment LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Environment ExportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportHeaderId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportHeaderId));
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

    public Environment ExportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportTargetId));
      }
    }

    public Environment LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Environment Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Message));
      }
    }
  }
}
