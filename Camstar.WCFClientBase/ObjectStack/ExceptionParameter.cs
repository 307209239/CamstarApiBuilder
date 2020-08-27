// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExceptionParameter
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class ExceptionParameter
  {
    [DataMember(EmitDefaultValue = false)]
    public string Name;
    [DataMember(EmitDefaultValue = false)]
    public string Value;

    public ExceptionParameter()
    {
    }

    public ExceptionParameter(string name, string value)
    {
      this.Name = name;
      this.Value = value;
    }
  }
}
