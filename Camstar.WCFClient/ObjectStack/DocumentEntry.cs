// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentEntry
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
  public class DocumentEntry : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Attachment")]
    protected NamedSubentityRef _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_DocumentBrowseMode")]
    protected Primitive<int> _DocumentBrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_DocumentIdentifier")]
    protected Primitive<string> _DocumentIdentifier;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Document")]
    protected RevisionedObjectRef _Document;

    public override bool Equals(object obj)
    {
      return obj is DocumentEntry && object.Equals((object) this._ExportImportKey, (object) ((DocumentEntry) obj)._ExportImportKey) && (object.Equals((object) this._FileName, (object) ((DocumentEntry) obj)._FileName) && object.Equals((object) this._Name, (object) ((DocumentEntry) obj)._Name)) && (object.Equals((object) this._Attachment, (object) ((DocumentEntry) obj)._Attachment) && object.Equals((object) this._DocumentBrowseMode, (object) ((DocumentEntry) obj)._DocumentBrowseMode) && (object.Equals((object) this._IsFrozen, (object) ((DocumentEntry) obj)._IsFrozen) && object.Equals((object) this._DocumentSet, (object) ((DocumentEntry) obj)._DocumentSet))) && (object.Equals((object) this._DocumentIdentifier, (object) ((DocumentEntry) obj)._DocumentIdentifier) && object.Equals((object) this._Description, (object) ((DocumentEntry) obj)._Description) && object.Equals((object) this._Document, (object) ((DocumentEntry) obj)._Document)) && base.Equals(obj);
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

    public NamedSubentityRef Attachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachment), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Attachment));
      }
    }

    public Primitive<int> DocumentBrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentBrowseMode), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DocumentBrowseMode));
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

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Primitive<string> DocumentIdentifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentIdentifier), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentIdentifier));
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

    public RevisionedObjectRef Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Document));
      }
    }
  }
}
