// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackTargetDeployment_Environment
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
  public class TrackTargetDeployment_Environment : ShopFloor_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, false, "String", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_ServiceDetails")]
    [Metadata("Target Deployment Detail", "TargetDeploymentDetail", false, false, false, "TargetDeploymentDetail", 1049843, false, true, false, null)]
    protected TargetDeploymentDetail_Environment _ServiceDetails;
    [Metadata("Locked = 1\r\nCompleted = 2\r\nError = 3\r\nReprocess = 4", "TargetDeliveryStatusEnum", false, true, false, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_TargetDeployments")]
    [Metadata("Target Deployment Detail", "TargetDeploymentDetail", false, false, false, "TargetDeploymentDetail", 1053268, false, true, false, null)]
    protected TargetDeploymentDetail_Environment _TargetDeployments;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053264, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_ExportHeaderId")]
    protected Environment _ExportHeaderId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053265, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_ExportTargetId")]
    protected Environment _ExportTargetId;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053267, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_LastUpdatedDateGMT")]
    protected Environment _LastUpdatedDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_LastUpdatedDate")]
    protected Environment _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Environment_Message")]
    [Metadata("Message text.", "", false, false, false, "String", 1051161, false, false, false, null)]
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

    public TargetDeploymentDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
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

    public TargetDeploymentDetail_Environment TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Environment) this.PropertyGet(nameof (TargetDeployments));
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
