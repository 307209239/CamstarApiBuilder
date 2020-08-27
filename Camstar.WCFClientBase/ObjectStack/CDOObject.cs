// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOObject
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public abstract class CDOObject : DCObject
  {
    [DataMember(EmitDefaultValue = false, Name = "Self")]
    public BaseObjectRef Self { get; set; }

    public override bool IsEmpty
    {
      get
      {
        return base.IsEmpty && this.Self.IsNullOrEmpty();
      }
    }
  }
}
