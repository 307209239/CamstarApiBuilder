// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCARRefDetail_Environment
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
  public class ResolveCARRefDetail_Environment : QualityCrossRefDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefDetail_Environment_ResolutionAction")]
    [Metadata("Enumeration for the Resolution Action:\r\n1 = Close", "ResolutionActionEnum", false, false, false, "Integer", 1051644, false, false, true, null)]
    protected new Environment _ResolutionAction;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051526, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefDetail_Environment_CloseReference")]
    protected new Environment _CloseReference;

    public new Environment ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public new Environment CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseReference));
      }
    }
  }
}
