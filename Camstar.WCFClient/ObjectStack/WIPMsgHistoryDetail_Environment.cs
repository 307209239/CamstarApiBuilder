// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgHistoryDetail_Environment
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
  public class WIPMsgHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_WIPMsgDetails")]
    [Metadata("A WIPMsgDetails object contains the basic definition of a single WIP Message.  It contains the unresolved text and any processing options and message configuration.", "WIPMsgDetails", false, false, false, "SubentityRef", 1049065, false, false, false, null)]
    protected Environment _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_AcknowledgementRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048752, false, false, false, "0")]
    protected Environment _AcknowledgementRequired;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049085, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_MsgAcknowledged")]
    protected Environment _MsgAcknowledged;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048754, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_PasswordRequired")]
    protected Environment _PasswordRequired;
    [Metadata("Message text.", "", false, false, false, "String", 1049062, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_MsgText")]
    protected Environment _MsgText;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049084, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_EnteredUserName")]
    protected Environment _EnteredUserName;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048606, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgHistoryDetail_Environment_Document")]
    protected Environment _Document;

    public Environment WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgDetails));
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

    public Environment Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Document));
      }
    }
  }
}
