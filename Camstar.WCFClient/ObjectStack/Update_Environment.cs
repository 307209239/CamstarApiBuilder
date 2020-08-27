// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Update_Environment
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
  public class Update_Environment : Service_Environment
  {
    [Metadata("ACEStatus field indicates the success or failure of the after commit events (AfterCommit and AfterCommitEventFailure)\r\nEnumeration for the after commit event status codes.\r\n\r\nValue\tName\t                Meaning\r\n1\tACESuccess\tafter commit event completed successfully\r\n2\tACEFSuccess\tan unhandled error in the after commit event was caught and after commit event failure event completed successfully\r\n3\tACEFFail\t                an unhandled error in the after commit event was caught and another unhandled error was raised in the after commit event failure event\r\n> 99\t<custom status>\tUser specific status codes (Designer based)", "ACEStatusEnum", false, false, true, "Integer", 1050633, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_ACEStatus")]
    protected Environment _ACEStatus;
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgr", false, false, false, "WIPMsgMgr", 1048865, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_WIPMsgMgr")]
    protected new WIPMsgMgr_Environment _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_MfgProcessOverrides")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    protected new Environment _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_IsRemoteService")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049887, false, false, false, "0")]
    protected new Environment _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "Update_Environment_ACEMessage")]
    [Metadata("Message text.", "", false, false, true, "String", 1050632, false, false, false, null)]
    protected Environment _ACEMessage;

    public Environment ACEStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ACEStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ACEStatus));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new WIPMsgMgr_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public new Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public new Environment IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public Environment ACEMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ACEMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ACEMessage));
      }
    }
  }
}
