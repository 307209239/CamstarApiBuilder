// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectChanges_Info
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
  public class RevisionedObjectChanges_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_ChangeHistory")]
    protected ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_FilterTags")]
    protected Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_AttachDocumentDetails")]
    protected AttachDocumentDetails_Info _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_ECO")]
    protected Info _ECO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_InstanceLocked")]
    protected Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_IsNDO")]
    protected Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_Base")]
    protected Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_AssociatedPackages")]
    protected Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_IsRDO")]
    protected Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_CanChangeRevOfRcd")]
    protected Info _CanChangeRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_ObjectToChange")]
    protected Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_IsRevOfRcd")]
    protected Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_Revision")]
    protected Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_IconId")]
    protected Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Info_Status")]
    protected Info _Status;

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public ChangeHistoryChanges_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Info FilterTags
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

    public AttachDocumentDetails_Info AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (AttachDocumentDetails_Info) this.PropertyGet(nameof (AttachDocumentDetails));
      }
    }

    public Info ECO
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

    public Info InstanceLocked
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

    public Info IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Info IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsNDO));
      }
    }

    public Info Base
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

    public Info AssociatedPackages
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

    public Info IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Info CanChangeRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (CanChangeRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CanChangeRevOfRcd));
      }
    }

    public Info ObjectToChange
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

    public Info Notes
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

    public Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
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

    public Info IsFrozen
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

    public Info Revision
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

    public Info IconId
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

    public Info Name
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

    public Info Status
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
  }
}
