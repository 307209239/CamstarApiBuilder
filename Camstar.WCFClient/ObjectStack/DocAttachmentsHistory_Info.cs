// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsHistory_Info
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
  public class DocAttachmentsHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_ParentDisplayName")]
    protected Info _ParentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_HistoryDetails")]
    protected DocAttachmentsHistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_AttachmentsOwner")]
    protected Info _AttachmentsOwner;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_ObjectRev")]
    protected Info _ObjectRev;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_Info_ObjectName")]
    protected Info _ObjectName;

    public Info ParentDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDisplayName));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
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

    public DocAttachmentsHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info AttachmentsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentsOwner));
      }
    }

    public Info ObjectRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectRev));
      }
    }

    public Info ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectName));
      }
    }
  }
}
