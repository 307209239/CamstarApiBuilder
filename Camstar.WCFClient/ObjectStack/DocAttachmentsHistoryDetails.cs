// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsHistoryDetails
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
  public class DocAttachmentsHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_OriginalFileName")]
    protected Primitive<string> _OriginalFileName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Action")]
    protected Enumeration<DocAttachmentActionEnum, int> _Action;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_OwnerDisplayName")]
    protected Primitive<string> _OwnerDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_OriginalFilePath")]
    protected Primitive<string> _OriginalFilePath;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_FileExtension")]
    protected Primitive<string> _FileExtension;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_DocContentsId")]
    protected Primitive<int> _DocContentsId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Version")]
    protected Primitive<string> _Version;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistoryDetails_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is DocAttachmentsHistoryDetails && object.Equals((object) this._ExportImportKey, (object) ((DocAttachmentsHistoryDetails) obj)._ExportImportKey) && (object.Equals((object) this._OriginalFileName, (object) ((DocAttachmentsHistoryDetails) obj)._OriginalFileName) && object.Equals((object) this._FileName, (object) ((DocAttachmentsHistoryDetails) obj)._FileName)) && (object.Equals((object) this._Action, (object) ((DocAttachmentsHistoryDetails) obj)._Action) && object.Equals((object) this._OwnerDisplayName, (object) ((DocAttachmentsHistoryDetails) obj)._OwnerDisplayName) && (object.Equals((object) this._OriginalFilePath, (object) ((DocAttachmentsHistoryDetails) obj)._OriginalFilePath) && object.Equals((object) this._FileExtension, (object) ((DocAttachmentsHistoryDetails) obj)._FileExtension))) && (object.Equals((object) this._DocContentsId, (object) ((DocAttachmentsHistoryDetails) obj)._DocContentsId) && object.Equals((object) this._Version, (object) ((DocAttachmentsHistoryDetails) obj)._Version) && (object.Equals((object) this._HistoryId, (object) ((DocAttachmentsHistoryDetails) obj)._HistoryId) && object.Equals((object) this._Name, (object) ((DocAttachmentsHistoryDetails) obj)._Name)) && object.Equals((object) this._Description, (object) ((DocAttachmentsHistoryDetails) obj)._Description)) && base.Equals(obj);
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

    public Primitive<string> OwnerDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerDisplayName));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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
