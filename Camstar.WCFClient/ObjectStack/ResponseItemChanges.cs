// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResponseItemChanges
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
  public class ResponseItemChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_ResponseLabel")]
    protected Primitive<string> _ResponseLabel;
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_ResponseValue")]
    protected Primitive<int> _ResponseValue;
    [DataMember(EmitDefaultValue = false, Name = "ResponseItemChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ResponseItemChanges && object.Equals((object) this._ResponseLabel, (object) ((ResponseItemChanges) obj)._ResponseLabel) && (object.Equals((object) this._ResponseValue, (object) ((ResponseItemChanges) obj)._ResponseValue) && object.Equals((object) this._IsFrozen, (object) ((ResponseItemChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Primitive<string> ResponseLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseLabel), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResponseLabel));
      }
    }

    public Primitive<int> ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResponseValue));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
