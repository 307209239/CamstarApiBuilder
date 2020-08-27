// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedInquiry_Info
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
  public class WhereUsedInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_WhereUsedFiltered")]
    protected Info _WhereUsedFiltered;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_WhereUsed")]
    protected Info _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_WhereUsedConfig")]
    protected Info _WhereUsedConfig;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_SelectedRevisionedObjects")]
    protected Info _SelectedRevisionedObjects;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_MaxNumberOfWhereUsedInstances")]
    protected Info _MaxNumberOfWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_SelectedNamedObjects")]
    protected Info _SelectedNamedObjects;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_Info_IsChangeMgtSettingsRequired")]
    protected Info _IsChangeMgtSettingsRequired;

    public Info WhereUsedFiltered
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedFiltered), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WhereUsedFiltered));
      }
    }

    public Info WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public Info WhereUsedConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfig), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WhereUsedConfig));
      }
    }

    public Info SelectedRevisionedObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedRevisionedObjects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedRevisionedObjects));
      }
    }

    public Info MaxNumberOfWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxNumberOfWhereUsedInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxNumberOfWhereUsedInstances));
      }
    }

    public Info SelectedNamedObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedNamedObjects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedNamedObjects));
      }
    }

    public Info IsChangeMgtSettingsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsChangeMgtSettingsRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsChangeMgtSettingsRequired));
      }
    }
  }
}
