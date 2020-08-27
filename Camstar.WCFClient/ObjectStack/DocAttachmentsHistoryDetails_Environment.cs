// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsHistoryDetails_Environment
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
  public class DocAttachmentsHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051134, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_OriginalFileName")]
    protected Environment _OriginalFileName;
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_FileName")]
    protected Environment _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_Action")]
    [Metadata("Enumeration for the Document Attachments:\r\n0 = Download\r\n1 = Upload\r\n2 = Delete\r\n3 = Update", "DocAttachmentActionEnum", false, false, true, "Integer", 1051130, false, false, false, null)]
    protected Environment _Action;
    [Metadata("DisplayName", "", false, false, true, "String", 1051136, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_OwnerDisplayName")]
    protected Environment _OwnerDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_OriginalFilePath")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051135, false, false, false, null)]
    protected Environment _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_FileExtension")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051132, false, false, false, null)]
    protected Environment _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_DocContentsId")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051131, false, false, false, null)]
    protected Environment _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_Version")]
    [Metadata("Generic String", "", false, false, true, "String", 1051137, false, false, false, null)]
    protected Environment _Version;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_Name")]
    protected Environment _Name;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Environment_Description")]
    protected Environment _Description;

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

    public Environment OriginalFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalFileName));
      }
    }

    public Environment FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileName));
      }
    }

    public Environment Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Action));
      }
    }

    public Environment OwnerDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerDisplayName));
      }
    }

    public Environment OriginalFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFilePath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalFilePath));
      }
    }

    public Environment FileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileExtension), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileExtension));
      }
    }

    public Environment DocContentsId
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocContentsId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocContentsId));
      }
    }

    public Environment Version
    {
      [param: In] set
      {
        this.PropertySet(nameof (Version), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Version));
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

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
