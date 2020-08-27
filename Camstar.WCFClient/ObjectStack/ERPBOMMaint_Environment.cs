// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPBOMMaint_Environment
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
  public class ERPBOMMaint_Environment : BillMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMMaint_Environment_ObjectChanges")]
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOMChanges", false, false, false, "ERPBOMChanges", 1048873, true, false, false, null)]
    protected ERPBOMChanges_Environment _ObjectChanges;
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOM", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOMBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOMBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;

    public ERPBOMChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ERPBOMChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }
  }
}
