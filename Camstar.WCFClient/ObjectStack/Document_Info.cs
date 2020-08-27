// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Document_Info
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
  public class Document_Info : RevisionedObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Identifier")]
    protected Info _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Attachment")]
    protected Info _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_AuthenticationType")]
    protected Info _AuthenticationType;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_BrowseMode")]
    protected Info _BrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_ECO")]
    protected new Info _ECO;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_IsAttachment")]
    protected Info _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Viewer")]
    protected Info _Viewer;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Status")]
    protected new Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_FileVersion")]
    protected Info _FileVersion;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Revision")]
    protected new Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_WIPMsgDefMgr")]
    protected new WIPMsgDefMgr_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "Document_Info_Description")]
    protected new Info _Description;

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

    public Info Attachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Attachment));
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

    public new Info FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Info ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceLocks));
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

    public new Info ECO
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ECO));
      }
    }

    public new Info InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Info AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackages));
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

    public new ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
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

    public new Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
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

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
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

    public new Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public new WIPMsgDefMgr_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new Info Description
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
