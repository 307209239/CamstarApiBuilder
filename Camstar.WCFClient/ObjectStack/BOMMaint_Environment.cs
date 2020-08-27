// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BOMMaint_Environment
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
  public class BOMMaint_Environment : BillMaint_Environment
  {
    [Metadata("A bill of material(BOM) defines the materials (raw materials, sub-assemblies, instructions, etc.) needed to produce a container.  BOMs are most often defined per product, but can be defined per order, per container, etc.", "BOMBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BOMMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "BOMMaint_Environment_ObjectChanges")]
    [Metadata("A bill of material defines the materials needed to produce a specific product.", "BOMChanges", false, false, false, "BOMChanges", 1048873, true, false, false, null)]
    protected BOMChanges_Environment _ObjectChanges;
    [Metadata("A bill of material defines the materials needed to produce a specific product.", "BOM", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BOMMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A bill of material(BOM) defines the materials (raw materials, sub-assemblies, instructions, etc.) needed to produce a container.  BOMs are most often defined per product, but can be defined per order, per container, etc.", "BOMBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BOMMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

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

    public BOMChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BOMChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
