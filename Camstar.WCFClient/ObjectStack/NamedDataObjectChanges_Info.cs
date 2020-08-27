// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObjectChanges_Info
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
  public class NamedDataObjectChanges_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_ChangeHistory")]
    protected ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_AttachDocumentDetails")]
    protected AttachDocumentDetails_Info _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_FilterTags")]
    protected Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_AssociatedPackages")]
    protected Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_UseRORProxy")]
    protected Info _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_AttachAsRORProxy")]
    protected Info _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_UseROR")]
    protected Info _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_IsNDO")]
    protected Info _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_InstanceLocked")]
    protected Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_IsRDO")]
    protected Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_ObjectToChange")]
    protected Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_IconId")]
    protected Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseRORProxy));
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

    public Info AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public Info UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseROR));
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
  }
}
