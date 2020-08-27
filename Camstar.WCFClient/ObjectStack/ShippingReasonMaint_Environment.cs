// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShippingReasonMaint_Environment
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
  public class ShippingReasonMaint_Environment : UserCodeWithWMMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonMaint_Environment_ObjectListInquiry")]
    [Metadata("The user code for shipping reason", "ShippingReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonMaint_Environment_ObjectToChange")]
    [Metadata("The user code for shipping reason", "ShippingReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Changes CDO for ShippingReason.", "ShippingReasonChanges", false, false, false, "ShippingReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonMaint_Environment_ObjectChanges")]
    protected ShippingReasonChanges_Environment _ObjectChanges;

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

    public ShippingReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ShippingReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
