// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillMaint_Environment
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
  public class BillMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("A Bill is  an enumerated, well defined list of raw materials, sub-assemblies, instructions, etc. ", "BillBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "Bill", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillMaint_Environment_ObjectListInquiry")]
    [Metadata("A Bill is  an enumerated, well defined list of raw materials, sub-assemblies, instructions, etc. ", "BillBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "BillMaint_Environment_ObjectChanges")]
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "BillChanges", false, false, false, "BillChanges", 1048873, true, false, false, null)]
    protected BillChanges_Environment _ObjectChanges;

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

    public BillChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BillChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
