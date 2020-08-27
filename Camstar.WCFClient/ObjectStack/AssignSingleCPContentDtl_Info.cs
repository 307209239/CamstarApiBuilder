// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignSingleCPContentDtl_Info
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
  public class AssignSingleCPContentDtl_Info : AssignChangePkgContentDtl_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContentDtl_Info_AssignSingleCPContent")]
    protected AssignSingleCPContent_Info _AssignSingleCPContent;
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContentDtl_Info_CPModelingInstanceDtl")]
    protected CPModelingInstanceDtl_Info _CPModelingInstanceDtl;

    public AssignSingleCPContent_Info AssignSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignSingleCPContent), (object) value);
      }
      get
      {
        return (AssignSingleCPContent_Info) this.PropertyGet(nameof (AssignSingleCPContent));
      }
    }

    public CPModelingInstanceDtl_Info CPModelingInstanceDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPModelingInstanceDtl), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Info) this.PropertyGet(nameof (CPModelingInstanceDtl));
      }
    }
  }
}
