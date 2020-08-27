// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsg
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
  public class WIPMsg : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_WIPMsgDetails")]
    protected WIPMsgDetails _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_WIPMsgHistoryDetail")]
    protected SubentityRef _WIPMsgHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_WIPMsgHold")]
    protected BaseObjectRef _WIPMsgHold;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_EnteredPassword")]
    protected PasswordFieldType _EnteredPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_PasswordRequired")]
    protected Primitive<bool> _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_MsgAcknowledged")]
    protected Primitive<bool> _MsgAcknowledged;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_AcknowledgementRequired")]
    protected Primitive<bool> _AcknowledgementRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_EnteredUserName")]
    protected Primitive<string> _EnteredUserName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_MsgText")]
    protected Primitive<string> _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Document")]
    protected Document _Document;

    public override bool Equals(object obj)
    {
      return obj is WIPMsg && object.Equals((object) this._WIPMsgDetails, (object) ((WIPMsg) obj)._WIPMsgDetails) && (object.Equals((object) this._WIPMsgHistoryDetail, (object) ((WIPMsg) obj)._WIPMsgHistoryDetail) && object.Equals((object) this._WIPMsgHold, (object) ((WIPMsg) obj)._WIPMsgHold)) && (object.Equals((object) this._EnteredPassword, (object) ((WIPMsg) obj)._EnteredPassword) && object.Equals((object) this._PasswordRequired, (object) ((WIPMsg) obj)._PasswordRequired) && (object.Equals((object) this._MsgAcknowledged, (object) ((WIPMsg) obj)._MsgAcknowledged) && object.Equals((object) this._AcknowledgementRequired, (object) ((WIPMsg) obj)._AcknowledgementRequired))) && (object.Equals((object) this._EnteredUserName, (object) ((WIPMsg) obj)._EnteredUserName) && object.Equals((object) this._MsgText, (object) ((WIPMsg) obj)._MsgText) && object.Equals((object) this._Document, (object) ((WIPMsg) obj)._Document)) && base.Equals(obj);
    }

    public WIPMsgDetails WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetails) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public SubentityRef WIPMsgHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WIPMsgHistoryDetail));
      }
    }

    public BaseObjectRef WIPMsgHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHold), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (WIPMsgHold));
      }
    }

    public PasswordFieldType EnteredPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnteredPassword), (object) value);
      }
      get
      {
        return (PasswordFieldType) this.PropertyGet(nameof (EnteredPassword));
      }
    }

    public Primitive<bool> PasswordRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (PasswordRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PasswordRequired));
      }
    }

    public Primitive<bool> MsgAcknowledged
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgAcknowledged), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (MsgAcknowledged));
      }
    }

    public Primitive<bool> AcknowledgementRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcknowledgementRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AcknowledgementRequired));
      }
    }

    public Primitive<string> EnteredUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnteredUserName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EnteredUserName));
      }
    }

    public Primitive<string> MsgText
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MsgText));
      }
    }

    public Document Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Document) this.PropertyGet(nameof (Document));
      }
    }
  }
}
