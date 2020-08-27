// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TextVariableMaint_Result
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TextVariableMaint_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected TextVariableMaint _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected TextVariableMaint_Environment _Environment;

    public TextVariableMaint Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (TextVariableMaint) this.PropertyGet(nameof (Value));
      }
    }

    public TextVariableMaint_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (TextVariableMaint_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
