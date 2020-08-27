// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResponseItemChanges_Environment
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
  public class ResponseItemChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_Environment_ResponseLabel")]
    [Metadata("Generic String", "", false, false, false, "String", 1052371, false, false, false, null)]
    protected Environment _ResponseLabel;
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_Environment_ResponseValue")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052370, false, false, false, null)]
    protected Environment _ResponseValue;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment ResponseLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseLabel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseLabel));
      }
    }

    public Environment ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResponseValue));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
