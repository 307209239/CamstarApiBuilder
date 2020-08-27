// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogChanges
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
  public class MasterDataCatalogChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_MasterDataCatalogDtl")]
    protected MasterDataCatalogDtlChanges[] _MasterDataCatalogDtl;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is MasterDataCatalogChanges && this.CompareArrays((Array) this._MasterDataCatalogDtl, (Array) ((MasterDataCatalogChanges) obj)._MasterDataCatalogDtl) && (object.Equals((object) this._ObjectToChange, (object) ((MasterDataCatalogChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((MasterDataCatalogChanges) obj)._Name)) && base.Equals(obj);
    }

    public MasterDataCatalogDtlChanges[] MasterDataCatalogDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterDataCatalogDtl), (object) value);
      }
      get
      {
        return (MasterDataCatalogDtlChanges[]) this.PropertyGet(nameof (MasterDataCatalogDtl));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
