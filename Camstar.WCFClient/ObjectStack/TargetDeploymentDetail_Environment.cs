// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetDeploymentDetail_Environment
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
  public class TargetDeploymentDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_StatusName")]
    [Metadata("Caption", "", false, false, false, "String", 1050396, false, false, false, null)]
    protected Environment _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_Owner")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, false, "String", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [Metadata("Target Deployment", "TargetDeployment", false, false, false, "SubentityRef", 16777318, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_TargetDeployment")]
    protected Environment _TargetDeployment;
    [Metadata("A CDO with the intention of being subclassed for usage in a business process which includes possibly a workflow.", "TrackableObject", false, false, true, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_TrackableObject")]
    protected Environment _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_TargetSystem")]
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "TargetSystem", 1053228, false, false, false, null)]
    protected TargetSystem_Environment _TargetSystem;
    [Metadata("Locked = 1\r\nCompleted = 2\r\nError = 3\r\nReprocess = 4", "TargetDeliveryStatusEnum", false, false, false, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_Status")]
    protected Environment _Status;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053265, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_ExportTargetId")]
    protected Environment _ExportTargetId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053264, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_ExportHeaderId")]
    protected Environment _ExportHeaderId;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053255, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_LastUpdatedDate")]
    protected Environment _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_LastUpdatedDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053267, false, false, false, null)]
    protected Environment _LastUpdatedDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777403, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_ExportDateGMT")]
    protected Environment _ExportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_ImportSequence")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777417, false, false, false, "0")]
    protected Environment _ImportSequence;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_ExportDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16777403, false, false, false, null)]
    protected Environment _ExportDate;
    [Metadata("Message text.", "", false, false, false, "String", 1051161, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_Message")]
    protected Environment _Message;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052747, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Environment_TargetSystemName")]
    protected Environment _TargetSystemName;

    public Environment StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusName));
      }
    }

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

    public Environment TargetDeployment
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetDeployment));
      }
    }

    public Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public TargetSystem_Environment TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Environment) this.PropertyGet(nameof (TargetSystem));
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

    public Environment ExportDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportDateGMT));
      }
    }

    public Environment ImportSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportSequence));
      }
    }

    public Environment ExportDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportDate));
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

    public Environment TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
