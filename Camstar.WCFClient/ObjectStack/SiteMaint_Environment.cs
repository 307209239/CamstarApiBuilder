// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SiteMaint_Environment
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
  public class SiteMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SiteMaint_Environment_ObjectToChange")]
    [Metadata("A site is defined as an independent InSite entity within a manufacturing organization. While a factory is a physical facilities concept, a site is a self contained IT structure based on a single transaction processing database, along with the associated InSite servers that provide the capability to generate transactions in the database. A factory could have one or more sites; and a site could run one or more factories.", "Site", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A site is defined as an independent InSite entity within a manufacturing organization. While a factory is a physical facilities concept, a site is a self contained IT structure based on a single transaction processing database, along with the associated InSite servers that provide the capability to generate transactions in the database. A factory could have one or more sites; and a site could run one or more factories.", "Site", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SiteMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SiteMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for Site.", "SiteChanges", false, false, false, "SiteChanges", 1048873, true, false, false, null)]
    protected SiteChanges_Environment _ObjectChanges;

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

    public SiteChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SiteChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
