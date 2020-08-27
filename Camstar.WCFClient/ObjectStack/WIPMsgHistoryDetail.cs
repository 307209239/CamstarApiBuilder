// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgHistoryDetail
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
  public class WIPMsgHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_WIPMsgDetails")]
    protected SubentityRef _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_AcknowledgementRequired")]
    protected Primitive<bool> _AcknowledgementRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_MsgAcknowledged")]
    protected Primitive<bool> _MsgAcknowledged;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_PasswordRequired")]
    protected Primitive<bool> _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_MsgText")]
    protected Primitive<string> _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_EnteredUserName")]
    protected Primitive<string> _EnteredUserName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Document")]
    protected RevisionedObjectRef _Document;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgHistoryDetail && object.Equals((object) this._WIPMsgDetails, (object) ((WIPMsgHistoryDetail) obj)._WIPMsgDetails) && (object.Equals((object) this._ExportImportKey, (object) ((WIPMsgHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((WIPMsgHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._AcknowledgementRequired, (object) ((WIPMsgHistoryDetail) obj)._AcknowledgementRequired) && object.Equals((object) this._MsgAcknowledged, (object) ((WIPMsgHistoryDetail) obj)._MsgAcknowledged) && (object.Equals((object) this._PasswordRequired, (object) ((WIPMsgHistoryDetail) obj)._PasswordRequired) && object.Equals((object) this._MsgText, (object) ((WIPMsgHistoryDetail) obj)._MsgText))) && (object.Equals((object) this._EnteredUserName, (object) ((WIPMsgHistoryDetail) obj)._EnteredUserName) && object.Equals((object) this._Document, (object) ((WIPMsgHistoryDetail) obj)._Document)) && base.Equals(obj);
    }

    public SubentityRef WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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

    public RevisionedObjectRef Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Document));
      }
    }
  }
}
