// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryView_Info
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
  public class HistoryView_Info : NamedDataObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_HistViewHistMainlineDtl")]
    protected HistViewHistMainlineDtl_Info _HistViewHistMainlineDtl;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_HistViewDtls")]
    protected HistViewDtl_Info _HistViewDtls;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;

    public HistViewHistMainlineDtl_Info HistViewHistMainlineDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewHistMainlineDtl), (object) value);
      }
      get
      {
        return (HistViewHistMainlineDtl_Info) this.PropertyGet(nameof (HistViewHistMainlineDtl));
      }
    }

    public HistViewDtl_Info HistViewDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewDtls), (object) value);
      }
      get
      {
        return (HistViewDtl_Info) this.PropertyGet(nameof (HistViewDtls));
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
  }
}
