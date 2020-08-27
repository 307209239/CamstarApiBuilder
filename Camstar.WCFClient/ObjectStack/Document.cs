// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Document
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
  public class Document : RevisionedObject
  {
    [DataMember(EmitDefaultValue = false, Name = "Document_Identifier")]
    protected Primitive<string> _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "Document_Attachment")]
    protected NamedSubentityRef _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "Document_AuthenticationType")]
    protected Enumeration<AuthenticationTypeEnum, int> _AuthenticationType;
    [DataMember(EmitDefaultValue = false, Name = "Document_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "Document_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "Document_BrowseMode")]
    protected Enumeration<BrowseModeEnum, int> _BrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "Document_ECO")]
    protected new Primitive<string> _ECO;
    [DataMember(EmitDefaultValue = false, Name = "Document_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "Document_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "Document_IsAttachment")]
    protected Primitive<bool> _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "Document_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Document_Viewer")]
    protected NamedObjectRef _Viewer;
    [DataMember(EmitDefaultValue = false, Name = "Document_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "Document_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Document_Status")]
    protected new Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "Document_FileVersion")]
    protected Primitive<string> _FileVersion;
    [DataMember(EmitDefaultValue = false, Name = "Document_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "Document_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "Document_Revision")]
    protected new Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "Document_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Document_WIPMsgDefMgr")]
    protected new WIPMsgDefMgr _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "Document_Description")]
    protected new Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is Document && object.Equals((object) this._Identifier, (object) ((Document) obj)._Identifier) && (object.Equals((object) this._Attachment, (object) ((Document) obj)._Attachment) && object.Equals((object) this._AuthenticationType, (object) ((Document) obj)._AuthenticationType)) && (object.Equals((object) this._FilterTags, (object) ((Document) obj)._FilterTags) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((Document) obj)._ModelingInstanceLocks) && (object.Equals((object) this._BrowseMode, (object) ((Document) obj)._BrowseMode) && object.Equals((object) this._ECO, (object) ((Document) obj)._ECO))) && (object.Equals((object) this._InstanceLocked, (object) ((Document) obj)._InstanceLocked) && object.Equals((object) this._AssociatedPackages, (object) ((Document) obj)._AssociatedPackages) && (object.Equals((object) this._IsAttachment, (object) ((Document) obj)._IsAttachment) && object.Equals((object) this._Name, (object) ((Document) obj)._Name)) && (object.Equals((object) this._Viewer, (object) ((Document) obj)._Viewer) && object.Equals((object) this._ChangeHistory, (object) ((Document) obj)._ChangeHistory) && (object.Equals((object) this._IsFrozen, (object) ((Document) obj)._IsFrozen) && object.Equals((object) this._Status, (object) ((Document) obj)._Status)))) && (object.Equals((object) this._FileVersion, (object) ((Document) obj)._FileVersion) && object.Equals((object) this._IconId, (object) ((Document) obj)._IconId) && (object.Equals((object) this._Base, (object) ((Document) obj)._Base) && object.Equals((object) this._Revision, (object) ((Document) obj)._Revision)) && (object.Equals((object) this._Notes, (object) ((Document) obj)._Notes) && object.Equals((object) this._WIPMsgDefMgr, (object) ((Document) obj)._WIPMsgDefMgr) && object.Equals((object) this._Description, (object) ((Document) obj)._Description))) && base.Equals(obj);
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

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
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

    public new Primitive<string> ECO
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECO), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ECO));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
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

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
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

    public new Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
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

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
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

    public new Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public new WIPMsgDefMgr WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new Primitive<string> Description
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
