// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigReqMaint_Environment
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
  public class ModelingESigReqMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Manage electronic signature requirements", "ModelingESigReqChanges", false, false, false, "ModelingESigReqChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_Environment_ObjectChanges")]
    protected ModelingESigReqChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_Environment_ObjectToChange")]
    [Metadata("Manage electronic signature requirements", "ModelingESigReq", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_Environment_ObjectListInquiry")]
    [Metadata("Manage electronic signature requirements", "ModelingESigReq", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050925, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_Environment_ServiceCDOType")]
    protected Environment _ServiceCDOType;

    public ModelingESigReqChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ModelingESigReqChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public Environment ServiceCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceCDOType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceCDOType));
      }
    }
  }
}
