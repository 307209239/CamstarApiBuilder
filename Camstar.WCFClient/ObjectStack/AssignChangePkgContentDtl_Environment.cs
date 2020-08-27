// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContentDtl_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DetachSingleCPContentDtl_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (AssignSingleCPContentDtl_Environment))]
  [Serializable]
  public class AssignChangePkgContentDtl_Environment : ChangePackageDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentDtl_Environment_Instances")]
    [Metadata("Change Package Modeling Instance Detail", "CPModelingInstanceDtl", false, false, false, "CPModelingInstanceDtl", 1053260, false, true, false, null)]
    protected new CPModelingInstanceDtl_Environment _Instances;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentDtl_Environment_ModelingInstanceID")]
    protected Environment _ModelingInstanceID;

    public new CPModelingInstanceDtl_Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Environment) this.PropertyGet(nameof (Instances));
      }
    }

    public Environment ModelingInstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingInstanceID));
      }
    }
  }
}
