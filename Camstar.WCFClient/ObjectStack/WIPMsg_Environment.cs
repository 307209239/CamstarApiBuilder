// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsg_Environment
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
  public class WIPMsg_Environment : Subentity_Environment
  {
    [Metadata("A WIPMsgDetails object contains the basic definition of a single WIP Message.  It contains the unresolved text and any processing options and message configuration.", "WIPMsgDetails", false, false, false, "WIPMsgDetails", 1049065, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_WIPMsgDetails")]
    protected WIPMsgDetails_Environment _WIPMsgDetails;
    [Metadata("Records the WIP Messages that were displayed as part of the transaction.", "WIPMsgHistoryDetail", false, false, false, "SubentityRef", 1049837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_WIPMsgHistoryDetail")]
    protected Environment _WIPMsgHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_WIPMsgHold")]
    [Metadata("This is the same as a hold transaction, except that it is meant to be dynamically called (automatically by another InSite transaction or other process), and in that it does not process WIP Messages.", "AutoHold", false, false, false, "BaseObjectRef", 1049838, false, false, false, null)]
    protected Environment _WIPMsgHold;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_EnteredPassword")]
    [Metadata("Password", "", false, false, false, "PasswordFieldType", 1049083, false, false, false, null)]
    protected Environment _EnteredPassword;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048754, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_PasswordRequired")]
    protected Environment _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_MsgAcknowledged")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049085, false, false, false, "0")]
    protected Environment _MsgAcknowledged;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_AcknowledgementRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048752, false, false, false, "0")]
    protected Environment _AcknowledgementRequired;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049084, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_EnteredUserName")]
    protected Environment _EnteredUserName;
    [Metadata("Message text.", "", false, false, false, "String", 1048746, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_MsgText")]
    protected Environment _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsg_Environment_Document")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, true, "Document", 1048606, false, false, false, null)]
    protected Document_Environment _Document;

    public WIPMsgDetails_Environment WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetails_Environment) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public Environment WIPMsgHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgHistoryDetail));
      }
    }

    public Environment WIPMsgHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgHold));
      }
    }

    public Environment EnteredPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnteredPassword), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnteredPassword));
      }
    }

    public Environment PasswordRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (PasswordRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PasswordRequired));
      }
    }

    public Environment MsgAcknowledged
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgAcknowledged), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MsgAcknowledged));
      }
    }

    public Environment AcknowledgementRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcknowledgementRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AcknowledgementRequired));
      }
    }

    public Environment EnteredUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnteredUserName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnteredUserName));
      }
    }

    public Environment MsgText
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MsgText));
      }
    }

    public Document_Environment Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Document_Environment) this.PropertyGet(nameof (Document));
      }
    }
  }
}
