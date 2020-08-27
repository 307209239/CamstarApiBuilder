// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentChanges
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
  public class DocumentChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_FileName")]
    protected Primitive<string> _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Identifier")]
    protected Primitive<string> _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_FileLocation")]
    protected Primitive<string> _FileLocation;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_BrowseMode")]
    protected Enumeration<BrowseModeEnum, int> _BrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_AuthenticationType")]
    protected Enumeration<AuthenticationTypeEnum, int> _AuthenticationType;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_UploadFile")]
    protected Primitive<bool> _UploadFile;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_IsAttachment")]
    protected Primitive<bool> _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Viewer")]
    protected NamedObjectRef _Viewer;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_FileVersion")]
    protected Primitive<string> _FileVersion;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DocumentChanges && object.Equals((object) this._FileName, (object) ((DocumentChanges) obj)._FileName) && (object.Equals((object) this._Identifier, (object) ((DocumentChanges) obj)._Identifier) && object.Equals((object) this._FileLocation, (object) ((DocumentChanges) obj)._FileLocation)) && (object.Equals((object) this._BrowseMode, (object) ((DocumentChanges) obj)._BrowseMode) && object.Equals((object) this._AuthenticationType, (object) ((DocumentChanges) obj)._AuthenticationType) && (object.Equals((object) this._UploadFile, (object) ((DocumentChanges) obj)._UploadFile) && object.Equals((object) this._IsAttachment, (object) ((DocumentChanges) obj)._IsAttachment))) && (object.Equals((object) this._ObjectToChange, (object) ((DocumentChanges) obj)._ObjectToChange) && object.Equals((object) this._Base, (object) ((DocumentChanges) obj)._Base) && (object.Equals((object) this._Viewer, (object) ((DocumentChanges) obj)._Viewer) && object.Equals((object) this._IsFrozen, (object) ((DocumentChanges) obj)._IsFrozen)) && (object.Equals((object) this._FileVersion, (object) ((DocumentChanges) obj)._FileVersion) && object.Equals((object) this._Name, (object) ((DocumentChanges) obj)._Name))) && base.Equals(obj);
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

    public Primitive<string> Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Identifier));
      }
    }

    public Primitive<string> FileLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileLocation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileLocation));
      }
    }

    public Enumeration<BrowseModeEnum, int> BrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrowseMode), (object) value);
      }
      get
      {
        return (Enumeration<BrowseModeEnum, int>) this.PropertyGet(nameof (BrowseMode));
      }
    }

    public Enumeration<AuthenticationTypeEnum, int> AuthenticationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthenticationType), (object) value);
      }
      get
      {
        return (Enumeration<AuthenticationTypeEnum, int>) this.PropertyGet(nameof (AuthenticationType));
      }
    }

    public Primitive<bool> UploadFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UploadFile), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UploadFile));
      }
    }

    public Primitive<bool> IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsAttachment));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public NamedObjectRef Viewer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Viewer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Viewer));
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

    public Primitive<string> FileVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileVersion), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FileVersion));
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
  }
}
