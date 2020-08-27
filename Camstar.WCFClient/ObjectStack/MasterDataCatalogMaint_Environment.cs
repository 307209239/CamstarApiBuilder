// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterDataCatalogMaint_Environment
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
  public class MasterDataCatalogMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Master Data Catalog gives an organization the ability to enforce change control on their modeling objects.", "MasterDataCatalog", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Master Data Catalog gives an organization the ability to enforce change control on their modeling objects.", "MasterDataCatalog", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterDataCatalogMaint_Environment_ObjectChanges")]
    [Metadata("Master Data Catalog gives an organization the ability to enforce change control on their modeling objects.", "MasterDataCatalogChanges", false, false, false, "MasterDataCatalogChanges", 1048873, true, false, false, null)]
    protected MasterDataCatalogChanges_Environment _ObjectChanges;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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

    public MasterDataCatalogChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MasterDataCatalogChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
