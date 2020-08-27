// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContentDtl
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DetachSingleCPContentDtl))]
  [KnownType(typeof (AssignSingleCPContentDtl))]
  [Serializable]
  public class AssignChangePkgContentDtl : ChangePackageDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentDtl_Instances")]
    protected new CPModelingInstanceDtl[] _Instances;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentDtl_ModelingInstanceID")]
    protected BaseObjectRef _ModelingInstanceID;

    public override bool Equals(object obj)
    {
      return obj is AssignChangePkgContentDtl && this.CompareArrays((Array) this._Instances, (Array) ((AssignChangePkgContentDtl) obj)._Instances) && object.Equals((object) this._ModelingInstanceID, (object) ((AssignChangePkgContentDtl) obj)._ModelingInstanceID) && base.Equals(obj);
    }

    public new CPModelingInstanceDtl[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl[]) this.PropertyGet(nameof (Instances));
      }
    }

    public BaseObjectRef ModelingInstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceID), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ModelingInstanceID));
      }
    }
  }
}
