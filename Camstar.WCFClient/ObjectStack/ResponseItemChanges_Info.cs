// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResponseItemChanges_Info
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
  public class ResponseItemChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_Info_ResponseLabel")]
    protected Info _ResponseLabel;
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_Info_ResponseValue")]
    protected Info _ResponseValue;
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info ResponseLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseLabel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseLabel));
      }
    }

    public Info ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseValue));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
