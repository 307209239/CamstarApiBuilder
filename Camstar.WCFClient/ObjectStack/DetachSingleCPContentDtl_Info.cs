// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachSingleCPContentDtl_Info
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
  public class DetachSingleCPContentDtl_Info : AssignChangePkgContentDtl_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContentDtl_Info_ChangePackages")]
    protected Info _ChangePackages;
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContentDtl_Info_DetachSingleCPContent")]
    protected DetachSingleCPContent_Info _DetachSingleCPContent;

    public Info ChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackages));
      }
    }

    public DetachSingleCPContent_Info DetachSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetachSingleCPContent), (object) value);
      }
      get
      {
        return (DetachSingleCPContent_Info) this.PropertyGet(nameof (DetachSingleCPContent));
      }
    }
  }
}
