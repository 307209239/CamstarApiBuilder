// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentChanges_Info
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
  public class DocumentChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_Identifier")]
    protected Info _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_FileLocation")]
    protected Info _FileLocation;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_BrowseMode")]
    protected Info _BrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_AuthenticationType")]
    protected Info _AuthenticationType;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_UploadFile")]
    protected Info _UploadFile;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_IsAttachment")]
    protected Info _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_Viewer")]
    protected Info _Viewer;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_FileVersion")]
    protected Info _FileVersion;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Info_Name")]
    protected new Info _Name;

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

    public Info Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Identifier));
      }
    }

    public Info FileLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileLocation));
      }
    }

    public Info BrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrowseMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BrowseMode));
      }
    }

    public Info AuthenticationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthenticationType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AuthenticationType));
      }
    }

    public Info UploadFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UploadFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UploadFile));
      }
    }

    public Info IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsAttachment));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info Viewer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Viewer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Viewer));
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

    public Info FileVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileVersion), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileVersion));
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
  }
}
