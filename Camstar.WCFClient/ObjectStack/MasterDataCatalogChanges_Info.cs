// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogChanges_Info
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
  public class MasterDataCatalogChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Info_MasterDataCatalogDtl")]
    protected MasterDataCatalogDtlChanges_Info _MasterDataCatalogDtl;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Info_Name")]
    protected new Info _Name;

    public MasterDataCatalogDtlChanges_Info MasterDataCatalogDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterDataCatalogDtl), (object) value);
      }
      get
      {
        return (MasterDataCatalogDtlChanges_Info) this.PropertyGet(nameof (MasterDataCatalogDtl));
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
