// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExceptionDataType
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ExceptionDataType
  {
    [DataMember(EmitDefaultValue = false)]
    public int Code { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Source { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string FailureContext { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public ExceptionLevel ExceptionLevel { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public Camstar.WCF.ObjectStack.ExceptionParameter[] ExceptionParameters { get; set; }

    public string ExceptionParameter(string name)
    {
      string str = (string) null;
      if (this.ExceptionParameters != null)
      {
        foreach (Camstar.WCF.ObjectStack.ExceptionParameter exceptionParameter in this.ExceptionParameters)
        {
          if (exceptionParameter.Name == name)
            str = exceptionParameter.Value;
        }
      }
      return str;
    }

    public override string ToString()
    {
      return this.Description;
    }
  }
}
