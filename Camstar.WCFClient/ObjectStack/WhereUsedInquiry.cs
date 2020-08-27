// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedInquiry
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
  public class WhereUsedInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_WhereUsedFiltered")]
    protected SubentityRef[] _WhereUsedFiltered;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_WhereUsed")]
    protected SubentityRef[] _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_WhereUsedConfig")]
    protected NamedObjectRef _WhereUsedConfig;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_SelectedRevisionedObjects")]
    protected RevisionedObjectRef[] _SelectedRevisionedObjects;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_MaxNumberOfWhereUsedInstances")]
    protected Primitive<int> _MaxNumberOfWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_SelectedNamedObjects")]
    protected NamedObjectRef[] _SelectedNamedObjects;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedInquiry_IsChangeMgtSettingsRequired")]
    protected Primitive<bool> _IsChangeMgtSettingsRequired;

    public override bool Equals(object obj)
    {
      return obj is WhereUsedInquiry && this.CompareArrays((Array) this._WhereUsedFiltered, (Array) ((WhereUsedInquiry) obj)._WhereUsedFiltered) && (this.CompareArrays((Array) this._WhereUsed, (Array) ((WhereUsedInquiry) obj)._WhereUsed) && object.Equals((object) this._WhereUsedConfig, (object) ((WhereUsedInquiry) obj)._WhereUsedConfig)) && (this.CompareArrays((Array) this._SelectedRevisionedObjects, (Array) ((WhereUsedInquiry) obj)._SelectedRevisionedObjects) && object.Equals((object) this._MaxNumberOfWhereUsedInstances, (object) ((WhereUsedInquiry) obj)._MaxNumberOfWhereUsedInstances) && (this.CompareArrays((Array) this._SelectedNamedObjects, (Array) ((WhereUsedInquiry) obj)._SelectedNamedObjects) && object.Equals((object) this._IsChangeMgtSettingsRequired, (object) ((WhereUsedInquiry) obj)._IsChangeMgtSettingsRequired))) && base.Equals(obj);
    }

    public SubentityRef[] WhereUsedFiltered
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedFiltered), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (WhereUsedFiltered));
      }
    }

    public SubentityRef[] WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public NamedObjectRef WhereUsedConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfig), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WhereUsedConfig));
      }
    }

    public RevisionedObjectRef[] SelectedRevisionedObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedRevisionedObjects), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (SelectedRevisionedObjects));
      }
    }

    public Primitive<int> MaxNumberOfWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxNumberOfWhereUsedInstances), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaxNumberOfWhereUsedInstances));
      }
    }

    public NamedObjectRef[] SelectedNamedObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedNamedObjects), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (SelectedNamedObjects));
      }
    }

    public Primitive<bool> IsChangeMgtSettingsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsChangeMgtSettingsRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsChangeMgtSettingsRequired));
      }
    }
  }
}
