// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogChanges_Environment
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
  public class MasterDataCatalogChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Environment_MasterDataCatalogDtl")]
    [Metadata("The detail information for the Master Data Catalog", "MasterDataCatalogDtlChanges", false, false, false, "MasterDataCatalogDtlChanges", 16778035, false, true, false, null)]
    protected MasterDataCatalogDtlChanges_Environment _MasterDataCatalogDtl;
    [Metadata("Master Data Catalog gives an organization the ability to enforce change control on their modeling objects.", "MasterDataCatalog", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16778027, false, false, false, null)]
    protected new Environment _Name;

    public MasterDataCatalogDtlChanges_Environment MasterDataCatalogDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterDataCatalogDtl), (object) value);
      }
      get
      {
        return (MasterDataCatalogDtlChanges_Environment) this.PropertyGet(nameof (MasterDataCatalogDtl));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
