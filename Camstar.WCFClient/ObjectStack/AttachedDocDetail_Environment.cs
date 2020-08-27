// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDocDetail_Environment
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
  public class AttachedDocDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_File")]
    [Metadata("URL", "", false, false, false, "String", 1051142, false, false, false, null)]
    protected Environment _File;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051132, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_FileExtension")]
    protected Environment _FileExtension;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_FileName")]
    protected Environment _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_OriginalFileName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051142, false, false, false, null)]
    protected Environment _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_OriginalFilePath")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051135, false, false, false, null)]
    protected Environment _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_Action")]
    [Metadata("Enumeration for the Document Attachments:\r\n0 = Download\r\n1 = Upload\r\n2 = Delete\r\n3 = Update", "DocAttachmentActionEnum", false, true, false, "Integer", 1051130, false, false, false, "0")]
    protected Environment _Action;
    [Metadata("Attached Document", "AttachedDoc", false, false, false, "NamedSubentityRef", 1052366, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_AttachedDocRef")]
    protected Environment _AttachedDocRef;
    [Metadata("Generic String", "", false, false, false, "String", 1051137, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_Version")]
    protected Environment _Version;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051131, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_DocContentsId")]
    protected Environment _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051141, false, false, false, null)]
    protected Environment _Name;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Environment_Description")]
    protected Environment _Description;

    public Environment File
    {
      [param: In] set
      {
        this.PropertySet(nameof (File), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (File));
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

    public Environment AttachedDocRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocRef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedDocRef));
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
