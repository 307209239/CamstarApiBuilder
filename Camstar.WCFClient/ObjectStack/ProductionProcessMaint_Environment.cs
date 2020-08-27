// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionProcessMaint_Environment
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
  public class ProductionProcessMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcessBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcess", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcessBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessMaint_Environment_ObjectChanges")]
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcessChanges", false, false, false, "ProductionProcessChanges", 1048873, true, false, false, null)]
    protected ProductionProcessChanges_Environment _ObjectChanges;

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

    public ProductionProcessChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProductionProcessChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
