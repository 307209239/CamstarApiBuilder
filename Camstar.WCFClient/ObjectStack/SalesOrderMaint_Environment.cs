// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SalesOrderMaint_Environment
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
  public class SalesOrderMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SalesOrderMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for SalesOrder.", "SalesOrderChanges", false, false, false, "SalesOrderChanges", 1048873, true, false, false, null)]
    protected SalesOrderChanges_Environment _ObjectChanges;
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SalesOrderMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SalesOrderMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public SalesOrderChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SalesOrderChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
