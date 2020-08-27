// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Update
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
  public class Update : Service
  {
    [DataMember(EmitDefaultValue = false, Name = "Update_ACEStatus")]
    protected Enumeration<ACEStatusEnum, int> _ACEStatus;
    [DataMember(EmitDefaultValue = false, Name = "Update_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "Update_WIPMsgMgr")]
    protected new WIPMsgMgr _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Update_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Update_IsRemoteService")]
    protected new Primitive<bool> _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "Update_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "Update_ACEMessage")]
    protected Primitive<string> _ACEMessage;

    public override bool Equals(object obj)
    {
      return obj is Update && object.Equals((object) this._ACEStatus, (object) ((Update) obj)._ACEStatus) && (object.Equals((object) this._Comments, (object) ((Update) obj)._Comments) && object.Equals((object) this._WIPMsgMgr, (object) ((Update) obj)._WIPMsgMgr)) && (object.Equals((object) this._MfgProcessOverrides, (object) ((Update) obj)._MfgProcessOverrides) && object.Equals((object) this._IsRemoteService, (object) ((Update) obj)._IsRemoteService) && (object.Equals((object) this._Factory, (object) ((Update) obj)._Factory) && object.Equals((object) this._ACEMessage, (object) ((Update) obj)._ACEMessage))) && base.Equals(obj);
    }

    public Enumeration<ACEStatusEnum, int> ACEStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ACEStatus), (object) value);
      }
      get
      {
        return (Enumeration<ACEStatusEnum, int>) this.PropertyGet(nameof (ACEStatus));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public new WIPMsgMgr WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public new RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public new Primitive<bool> IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public Primitive<string> ACEMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ACEMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ACEMessage));
      }
    }
  }
}
