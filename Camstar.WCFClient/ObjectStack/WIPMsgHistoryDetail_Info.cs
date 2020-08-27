// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgHistoryDetail_Info
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
  public class WIPMsgHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_WIPMsgDetails")]
    protected Info _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_AcknowledgementRequired")]
    protected Info _AcknowledgementRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_MsgAcknowledged")]
    protected Info _MsgAcknowledged;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_PasswordRequired")]
    protected Info _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_MsgText")]
    protected Info _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_EnteredUserName")]
    protected Info _EnteredUserName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Info_Document")]
    protected Info _Document;

    public Info WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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

    public Info Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Document));
      }
    }
  }
}
