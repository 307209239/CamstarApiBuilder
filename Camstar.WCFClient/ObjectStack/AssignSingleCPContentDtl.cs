// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignSingleCPContentDtl
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
  public class AssignSingleCPContentDtl : AssignChangePkgContentDtl
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContentDtl_AssignSingleCPContent")]
    protected AssignSingleCPContent _AssignSingleCPContent;
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContentDtl_CPModelingInstanceDtl")]
    protected CPModelingInstanceDtl _CPModelingInstanceDtl;

    public override bool Equals(object obj)
    {
      return obj is AssignSingleCPContentDtl && object.Equals((object) this._AssignSingleCPContent, (object) ((AssignSingleCPContentDtl) obj)._AssignSingleCPContent) && object.Equals((object) this._CPModelingInstanceDtl, (object) ((AssignSingleCPContentDtl) obj)._CPModelingInstanceDtl) && base.Equals(obj);
    }

    public AssignSingleCPContent AssignSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignSingleCPContent), (object) value);
      }
      get
      {
        return (AssignSingleCPContent) this.PropertyGet(nameof (AssignSingleCPContent));
      }
    }

    public CPModelingInstanceDtl CPModelingInstanceDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPModelingInstanceDtl), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl) this.PropertyGet(nameof (CPModelingInstanceDtl));
      }
    }
  }
}
