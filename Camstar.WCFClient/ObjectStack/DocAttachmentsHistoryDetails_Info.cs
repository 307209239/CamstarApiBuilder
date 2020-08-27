// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsHistoryDetails_Info
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
  public class DocAttachmentsHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_OriginalFileName")]
    protected Info _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_Action")]
    protected Info _Action;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_OwnerDisplayName")]
    protected Info _OwnerDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_OriginalFilePath")]
    protected Info _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_FileExtension")]
    protected Info _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_DocContentsId")]
    protected Info _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_Version")]
    protected Info _Version;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Info_Description")]
    protected Info _Description;

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

    public Info OriginalFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalFileName));
      }
    }

    public Info FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileName));
      }
    }

    public Info Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Action));
      }
    }

    public Info OwnerDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerDisplayName));
      }
    }

    public Info OriginalFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFilePath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalFilePath));
      }
    }

    public Info FileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileExtension), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileExtension));
      }
    }

    public Info DocContentsId
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocContentsId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocContentsId));
      }
    }

    public Info Version
    {
      [param: In] set
      {
        this.PropertySet(nameof (Version), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Version));
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

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
