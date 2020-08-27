// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachSingleCPContentDtl
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
  public class DetachSingleCPContentDtl : AssignChangePkgContentDtl
  {
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContentDtl_ChangePackages")]
    protected NamedObjectRef[] _ChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContentDtl_DetachSingleCPContent")]
    protected DetachSingleCPContent _DetachSingleCPContent;

    public override bool Equals(object obj)
    {
      return obj is DetachSingleCPContentDtl && this.CompareArrays((Array) this._ChangePackages, (Array) ((DetachSingleCPContentDtl) obj)._ChangePackages) && object.Equals((object) this._DetachSingleCPContent, (object) ((DetachSingleCPContentDtl) obj)._DetachSingleCPContent) && base.Equals(obj);
    }

    public NamedObjectRef[] ChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackages), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChangePackages));
      }
    }

    public DetachSingleCPContent DetachSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetachSingleCPContent), (object) value);
      }
      get
      {
        return (DetachSingleCPContent) this.PropertyGet(nameof (DetachSingleCPContent));
      }
    }
  }
}
