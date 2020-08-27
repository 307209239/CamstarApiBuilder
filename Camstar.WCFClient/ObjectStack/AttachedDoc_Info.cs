// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDoc_Info
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
  public class AttachedDoc_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_FileExtension")]
    protected Info _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_OriginalFileName")]
    protected Info _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_OriginalFilePath")]
    protected Info _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_DocContentsId")]
    protected Info _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_Version")]
    protected Info _Version;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Info_Description")]
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

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Info Name
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
