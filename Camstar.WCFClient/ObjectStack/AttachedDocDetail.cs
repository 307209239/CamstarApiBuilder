// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AttachedDocDetail
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
  public class AttachedDocDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_File")]
    protected Primitive<string> _File;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_FileExtension")]
    protected Primitive<string> _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_OriginalFileName")]
    protected Primitive<string> _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_OriginalFilePath")]
    protected Primitive<string> _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Action")]
    protected Enumeration<DocAttachmentActionEnum, int> _Action;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_AttachedDocRef")]
    protected NamedSubentityRef _AttachedDocRef;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Version")]
    protected Primitive<string> _Version;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_DocContentsId")]
    protected Primitive<int> _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "AttachedDocDetail_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is AttachedDocDetail && object.Equals((object) this._File, (object) ((AttachedDocDetail) obj)._File) && (object.Equals((object) this._FileExtension, (object) ((AttachedDocDetail) obj)._FileExtension) && object.Equals((object) this._FileName, (object) ((AttachedDocDetail) obj)._FileName)) && (object.Equals((object) this._OriginalFileName, (object) ((AttachedDocDetail) obj)._OriginalFileName) && object.Equals((object) this._OriginalFilePath, (object) ((AttachedDocDetail) obj)._OriginalFilePath) && (object.Equals((object) this._Action, (object) ((AttachedDocDetail) obj)._Action) && object.Equals((object) this._AttachedDocRef, (object) ((AttachedDocDetail) obj)._AttachedDocRef))) && (object.Equals((object) this._Version, (object) ((AttachedDocDetail) obj)._Version) && object.Equals((object) this._DocContentsId, (object) ((AttachedDocDetail) obj)._DocContentsId) && (object.Equals((object) this._Name, (object) ((AttachedDocDetail) obj)._Name) && object.Equals((object) this._Description, (object) ((AttachedDocDetail) obj)._Description))) && base.Equals(obj);
    }

    public Primitive<string> File
    {
      [param: In] set
      {
        this.PropertySet(nameof (File), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (File));
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

    public Enumeration<DocAttachmentActionEnum, int> Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Enumeration<DocAttachmentActionEnum, int>) this.PropertyGet(nameof (Action));
      }
    }

    public NamedSubentityRef AttachedDocRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocRef), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (AttachedDocRef));
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

    public Primitive<string> Name
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
