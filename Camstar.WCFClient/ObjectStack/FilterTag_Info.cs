// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTag_Info
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
  public class FilterTag_Info : UserCode_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_InstanceID")]
    protected Info _InstanceID;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Info_Notes")]
    protected new Info _Notes;

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

    public Info InstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceID));
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
  }
}
