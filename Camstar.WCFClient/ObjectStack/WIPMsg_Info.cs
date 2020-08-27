// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsg_Info
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
  public class WIPMsg_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_WIPMsgDetails")]
    protected WIPMsgDetails_Info _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_WIPMsgHistoryDetail")]
    protected Info _WIPMsgHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_WIPMsgHold")]
    protected Info _WIPMsgHold;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_EnteredPassword")]
    protected Info _EnteredPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_PasswordRequired")]
    protected Info _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_MsgAcknowledged")]
    protected Info _MsgAcknowledged;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_AcknowledgementRequired")]
    protected Info _AcknowledgementRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_EnteredUserName")]
    protected Info _EnteredUserName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_MsgText")]
    protected Info _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Info_Document")]
    protected Document_Info _Document;

    public WIPMsgDetails_Info WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetails_Info) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public Info WIPMsgHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgHistoryDetail));
      }
    }

    public Info WIPMsgHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgHold));
      }
    }

    public Info EnteredPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnteredPassword), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnteredPassword));
      }
    }

    public Info PasswordRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (PasswordRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PasswordRequired));
      }
    }

    public Info MsgAcknowledged
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgAcknowledged), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MsgAcknowledged));
      }
    }

    public Info AcknowledgementRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcknowledgementRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AcknowledgementRequired));
      }
    }

    public Info EnteredUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnteredUserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnteredUserName));
      }
    }

    public Info MsgText
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MsgText));
      }
    }

    public Document_Info Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Document_Info) this.PropertyGet(nameof (Document));
      }
    }
  }
}
