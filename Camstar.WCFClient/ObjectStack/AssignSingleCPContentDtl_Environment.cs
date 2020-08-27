// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignSingleCPContentDtl_Environment
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
  public class AssignSingleCPContentDtl_Environment : AssignChangePkgContentDtl_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContentDtl_Environment_AssignSingleCPContent")]
    [Metadata("Assigns content/modeling instance to a ChangePackage.", "AssignSingleCPContent", false, false, false, "AssignSingleCPContent", 16778052, false, false, false, null)]
    protected AssignSingleCPContent_Environment _AssignSingleCPContent;
    [Metadata("Change Package Modeling Instance Detail", "CPModelingInstanceDtl", false, false, false, "CPModelingInstanceDtl", 16778051, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContentDtl_Environment_CPModelingInstanceDtl")]
    protected CPModelingInstanceDtl_Environment _CPModelingInstanceDtl;

    public AssignSingleCPContent_Environment AssignSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignSingleCPContent), (object) value);
      }
      get
      {
        return (AssignSingleCPContent_Environment) this.PropertyGet(nameof (AssignSingleCPContent));
      }
    }

    public CPModelingInstanceDtl_Environment CPModelingInstanceDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPModelingInstanceDtl), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Environment) this.PropertyGet(nameof (CPModelingInstanceDtl));
      }
    }
  }
}
