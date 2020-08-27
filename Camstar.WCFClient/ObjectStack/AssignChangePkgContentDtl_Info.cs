// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContentDtl_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (AssignSingleCPContentDtl_Info))]
  [KnownType(typeof (DetachSingleCPContentDtl_Info))]
  [Serializable]
  public class AssignChangePkgContentDtl_Info : ChangePackageDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentDtl_Info_Instances")]
    protected new CPModelingInstanceDtl_Info _Instances;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentDtl_Info_ModelingInstanceID")]
    protected Info _ModelingInstanceID;

    public new CPModelingInstanceDtl_Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Info) this.PropertyGet(nameof (Instances));
      }
    }

    public Info ModelingInstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceID));
      }
    }
  }
}
