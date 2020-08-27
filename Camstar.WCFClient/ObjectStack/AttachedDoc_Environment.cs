// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDoc_Environment
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
  public class AttachedDoc_Environment : NamedSubentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_FileExtension")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051132, false, false, false, null)]
    protected Environment _FileExtension;
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_FileName")]
    protected Environment _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_OriginalFileName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051142, false, false, false, null)]
    protected Environment _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_OriginalFilePath")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051135, false, false, false, null)]
    protected Environment _OriginalFilePath;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051131, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_DocContentsId")]
    protected Environment _DocContentsId;
    [Metadata("Generic String", "", false, false, true, "String", 1051137, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_Version")]
    protected Environment _Version;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051141, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Environment_Description")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048678, false, false, false, null)]
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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Environment Name
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
