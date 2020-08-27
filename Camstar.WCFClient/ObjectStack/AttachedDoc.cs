// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDoc
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
  public class AttachedDoc : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_FileExtension")]
    protected Primitive<string> _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_OriginalFileName")]
    protected Primitive<string> _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_OriginalFilePath")]
    protected Primitive<string> _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_DocContentsId")]
    protected Primitive<int> _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Version")]
    protected Primitive<string> _Version;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDoc_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is AttachedDoc && object.Equals((object) this._ExportImportKey, (object) ((AttachedDoc) obj)._ExportImportKey) && (object.Equals((object) this._FileExtension, (object) ((AttachedDoc) obj)._FileExtension) && object.Equals((object) this._FileName, (object) ((AttachedDoc) obj)._FileName)) && (object.Equals((object) this._OriginalFileName, (object) ((AttachedDoc) obj)._OriginalFileName) && object.Equals((object) this._OriginalFilePath, (object) ((AttachedDoc) obj)._OriginalFilePath) && (object.Equals((object) this._DocContentsId, (object) ((AttachedDoc) obj)._DocContentsId) && object.Equals((object) this._Version, (object) ((AttachedDoc) obj)._Version))) && (object.Equals((object) this._IsFrozen, (object) ((AttachedDoc) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((AttachedDoc) obj)._Name) && object.Equals((object) this._Description, (object) ((AttachedDoc) obj)._Description)) && base.Equals(obj);
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

    public Primitive<string> FileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileExtension), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileExtension));
      }
    }

    public Primitive<string> FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileName));
      }
    }

    public Primitive<string> OriginalFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OriginalFileName));
      }
    }

    public Primitive<string> OriginalFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFilePath), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OriginalFilePath));
      }
    }

    public Primitive<int> DocContentsId
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocContentsId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DocContentsId));
      }
    }

    public Primitive<string> Version
    {
      [param: In] set
      {
        this.PropertySet(nameof (Version), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Version));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
