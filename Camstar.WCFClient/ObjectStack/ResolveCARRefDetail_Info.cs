// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCARRefDetail_Info
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
  public class ResolveCARRefDetail_Info : QualityCrossRefDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefDetail_Info_ResolutionAction")]
    protected new Info _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefDetail_Info_CloseReference")]
    protected new Info _CloseReference;

    public new Info ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public new Info CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseReference));
      }
    }
  }
}
